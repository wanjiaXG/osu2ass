using Newtonsoft.Json;
using osu2ass.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WebSocketSharp;

namespace osu2ass
{
    public partial class MainForm : Form
    {

        private WebSocket WebSocket;

        private SynchronizationContext Context;

        private Process process;

        public MainForm()
        {
            InitializeComponent();
            Context = SynchronizationContext.Current;
        }

        protected override void OnLoad(EventArgs e)
        {
            RestartGosuBtn.PerformClick();
            GosuModeRBtn.Checked = true;
        }

        private void RunGosu()
        {
            //Init Path
            string ApplicationBasePath = new FileInfo(Application.ExecutablePath).DirectoryName;

            string gosuBasePath = $"{ApplicationBasePath}/gosumemory/";

            string gosuConfigPath = $"{gosuBasePath}/config.ini";

            string gosuPath = $"{gosuBasePath}/gosumemory.exe";


            if (!Directory.Exists(gosuBasePath))
            {
                Directory.CreateDirectory(gosuBasePath);
            }

            if (!File.Exists(gosuPath))
            {
                File.WriteAllBytes(gosuPath, Resources.gosumemory);
            }
            if (!File.Exists(gosuConfigPath))
            {
                File.WriteAllText(gosuConfigPath, Resources.config);
            }

            if (process != null && !process.HasExited)
            {
                process.CloseMainWindow();
                process = null;
            }



            //Read gosumemory config.ini
            Ini ini = Ini.Parse(File.ReadAllText(gosuConfigPath));

            //Execute gosumemory
            process = new Process();
            process.StartInfo.FileName = gosuPath;
/*            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;*/
            process.Start();


            //Read websocket url
            string server = $"ws://{ini.GetValue<string>("Web", "serverip")}/ws";

            //Connect to gosumemory
            WebSocket = new WebSocket(server);
            WebSocket.OnMessage += OnMessage;
            WebSocket.OnClose += OnClose;
            WebSocket.Connect();
        }

        private void OnClose(object sender, CloseEventArgs e)
        {
            Context.Post((s) => { gosuStatusLB.ForeColor = Color.Red ; gosuStatusLB.Text = "gosu未启动";  }, null );
            //ReConnect to gosumemory
            Thread.Sleep(1000);
            WebSocket.Connect();
        }

        private GosumemoryData gosumemoryData;

        private void OnMessage(object sender, MessageEventArgs e)
        {
            Context.Post((s) => { gosuStatusLB.ForeColor = Color.Green; gosuStatusLB.Text = "gosu运行中"; }, null);

            try
            {
                //Update osu realtime data
                gosumemoryData = JsonConvert.DeserializeObject<GosumemoryData>(e.Data);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void GosuModeRBtn_CheckedChanged(object sender, EventArgs e)
        {
            OsuCodeTB.ReadOnly = GosuModeRBtn.Checked;
        }

        private void RestartGosuBtn_Click(object sender, EventArgs e)
        {
            new Thread(RunGosu).Start();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "所有文件(*.*)|*.*";
            dialog.DefaultExt = ".ass";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, AssTB.Text);
            }
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int globalOffset = 0;
                if (!string.IsNullOrWhiteSpace(GlobalOffsetTB.Text))
                {
                    if (int.TryParse(GlobalOffsetTB.Text, out int result))
                    {
                        globalOffset = result;
                    }
                    else
                    {
                        throw new Exception("全局偏移必须是整数值");
                    }
                }


                StringBuilder ass = new StringBuilder();
                ass.Append("[Script Info]\r\n\r\n");
                ass.Append("[V4+ Styles]\r\n");
                ass.Append("Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding\r\n");
                ass.Append("Style: Default,黑体,75,&H00FFFFFF,&H00F0B075,&H00C34F22,&H00000000,0,0,0,0,100,100,0,0,1,1.5,1.99999,2,11,11,50,1\r\n\r\n");
                ass.Append("[Events]\r\n");
                ass.Append("Format: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text\r\n");


                List<int> offsets = GetOffsets();

                List<List<StringBuilder>> lrcs = GetLrcs();

                //Dialogue: 0,0:00:07.96,0:00:12.60,Default,,0,0,0,,PCゲーム「穢翼のユースティア」OP

                int index = 0;
                foreach (var item in lrcs)
                {
                    StringBuilder content = new StringBuilder();

                    ass.Append("Dialogue: 0,");
                    if (index >= offsets.Count)
                    {
                        throw new Exception("歌词分段数量与osu代码数量不匹配, 请校对后重新转换.");
                    }

                    int offset = offsets[index];
                    ass.Append(GetAssTime(offset + globalOffset) + ",");


                    foreach (var c in item)
                    {
                        index++;

                        if(index >= offsets.Count)
                        {
                            throw new Exception("歌词分段数量与osu代码数量不匹配, 请校对后重新转换.");
                        }

                        content.Append("{\\kf" + (offsets[index] - offset) / 10 + "}").Append(c);
                        offset = offsets[index];
                    }

                    ass.Append(GetAssTime(offset) + $",Default,,0,0,0,,");
                    ass.Append(content);

                    ass.Append("\r\n");
                    index++;
                }


                AssTB.Text = ass.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<List<StringBuilder>> lrcs = GetLrcs();

                StringBuilder sb = new StringBuilder();

                foreach (var l in lrcs)
                {
                    foreach (var i in l)
                    {
                        sb.Append(i).Append("|");
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append("\r\n");
                }
                AssTB.Text = sb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private List<int> GetOffsets()
        {
            #region read Offset

            List<int> offset = new List<int>();

            if (GosuModeRBtn.Checked)
            {
                string osuFilePath = $"{gosumemoryData.settings.folders.songs}\\{gosumemoryData.menu.bm.path.folder }\\{gosumemoryData.menu.bm.path.file}";
                if (File.Exists(osuFilePath))
                {
                    OsuCodeTB.Text = File.ReadAllText(osuFilePath);
                }
                else
                {
                    throw new FileNotFoundException("File not found.", osuFilePath);
                }
            }

            if (string.IsNullOrWhiteSpace(OsuCodeTB.Text))
            {
                throw new ArgumentException("Osu代码不能为空.");
            }


            bool canRead = false;
            foreach (var item in OsuCodeTB.Text.Split('\n'))
            {
                string line = item.Trim();
                if (canRead)
                {
                    string[] vs = line.Split(',');
                    if (vs.Length >= 3)
                    {
                        offset.Add(int.Parse(vs[2]));
                    }
                    continue;
                }
                if (line.Equals("[HitObjects]"))
                {
                    canRead = true;
                    continue;
                }
            }

            #endregion

            return offset;
        }

        private List<List<StringBuilder>> GetLrcs()
        {
            #region 分割字符
            List<List<StringBuilder>> lrcs = new List<List<StringBuilder>>();
            if (string.IsNullOrWhiteSpace(LrcTB.Text))
            {
                throw new ArgumentException("歌词不能为空.");
            }
            foreach (var item in LrcTB.Text.Split('\n'))
            {
                string line = item.Trim();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    List<StringBuilder> lrc = new List<StringBuilder>();
                    char[] arr = line.ToCharArray();
                    char lastChar = arr[0];
                    lrc.Add(new StringBuilder().Append(lastChar));
                    for (int i = 1; i < arr.Length; i++)
                    {
                        char currentChar = arr[i];
                        if (currentChar > 255 && currentChar != 12288)
                        {
                            lrc.Add(new StringBuilder().Append(currentChar));
                        }
                        else if ((lastChar == 32 || lastChar > 255 || lastChar == 12288) && currentChar != 32 && currentChar != 12288)
                        {
                            lrc.Add(new StringBuilder().Append(currentChar));
                        }
                        else
                        {
                            lrc[lrc.Count - 1].Append(currentChar);
                        }
                        lastChar = currentChar;
                    }
                    lrcs.Add(lrc);
                }
            }
            #endregion
            return lrcs;
        }

        private string GetAssTime(int offset)
        {
            int tmp = offset;
            int ms = tmp % 1000;

            tmp /= 1000;
            int s = tmp % 60;

            tmp /= 60;
            int m = tmp % 60;

            int h = tmp / 60;

            return $"{h}:{m}:{s}.{ms / 10}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.CloseMainWindow();
                process = null;
            }
        }
    }
}
