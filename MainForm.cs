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
        private WebSocket WsClient;

        private readonly SynchronizationContext Context;

        private Process GosuProcess;

        private string StyleCode;

        private readonly List<char> SpCharList = new List<char>();

        public static readonly StringBuilder GosuLog = new StringBuilder();

        public static readonly string DefaultStyleCode = "Style: Default,黑体,45,&H00FFFFFF,&H00F0B075,&H00C34F22,&H00000000,0,0,0,0,100,100,0,0,1,1.5,1.99999,2,11,11,50,1\r\n";

        private readonly static string ApplicationBasePath = new FileInfo(Application.ExecutablePath).DirectoryName;

        private readonly static string GosuBasePath = $"{ApplicationBasePath}/gosumemory/";

        private readonly static string GosuConfigPath = $"{GosuBasePath}/config.ini";

        private readonly static string GosuPath = $"{GosuBasePath}/gosumemory.exe";

        public MainForm()
        {
            InitializeComponent();
            Context = SynchronizationContext.Current;
        }

        protected override void OnLoad(EventArgs e)
        {
            UpdateCharList();
            UpdateStyleCode();
            RestartGosuBtn.PerformClick();
            GosuModeRBtn.Checked = true;
        }

        private void RunGosu()
        {
            try
            {

                if (!Directory.Exists(GosuBasePath))
                {
                    Directory.CreateDirectory(GosuBasePath);
                }

                if (!File.Exists(GosuPath))
                {
                    File.WriteAllBytes(GosuPath, Resources.gosumemory);
                }

                if (!File.Exists(GosuConfigPath))
                {
                    File.WriteAllText(GosuConfigPath, Resources.config);
                }

                if (GosuProcess != null && !GosuProcess.HasExited)
                {
                    GosuProcess.CloseMainWindow();
                    GosuProcess = null;
                }

                //Read gosumemory config.ini
                Ini ini = Ini.Parse(File.ReadAllText(GosuConfigPath));

                //Execute gosumemory
                GosuProcess = new Process();
                GosuProcess.StartInfo.FileName = GosuPath;
                GosuProcess.StartInfo.CreateNoWindow = true;
                GosuProcess.StartInfo.UseShellExecute = false;
                GosuProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                GosuProcess.StartInfo.RedirectStandardInput = true;
                GosuProcess.StartInfo.RedirectStandardOutput = true;
                new Thread(() =>
                {
                    byte[] buffer = new byte[2048];
                    while (!this.IsDisposed)
                    {
                        try
                        {
                            int? length = GosuProcess?.StandardOutput?.BaseStream?.Read(buffer, 0, buffer.Length);
                            GosuLog.Append(Encoding.Default.GetString(buffer, 0, (int)length));
                        }
                        catch
                        {

                        }
                    }
                }).Start();
                GosuProcess.Start();

                //Read websocket url
                string serverip = ini.GetValue<string>("Web", "serverip");

                if (serverip.StartsWith("0.0.0.0"))
                {
                    serverip = serverip.Replace("0.0.0.0", "127.0.0.1");
                }

                string server = $"ws://{serverip}/ws";

                

                //Connect to gosumemory

                WsClient = new WebSocket(server);
                WsClient.Log.File = null;
                WsClient.OnMessage += OnMessage;
                WsClient.OnClose += OnClose;
                WsClient.Connect();
            }catch(Exception ex)
            {
                Context.Post((obj) => 
                {
                    if(obj is Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }, ex);
            }
        }

        private void OnClose(object sender, CloseEventArgs e)
        {
            Context.Post((s) => { gosuStatusLB.ForeColor = Color.Red ; gosuStatusLB.Text = "gosu未启动";  }, null );
            //ReConnect to gosumemory
            if (!IsDisposed)
            {
                Thread.Sleep(1000);
                WsClient.Connect();
            }
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

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region 参数校验

                if (string.IsNullOrWhiteSpace(AssPathTB.Text))
                {
                    throw new Exception("未选择ass保存路径");
                }

                if (!int.TryParse(WidthTB.Text, out int width) || !int.TryParse(HeightTB.Text, out int height))
                {
                    throw new Exception("画布宽度值必须是整数值");
                }

                if (!float.TryParse(SpeedTB.Text, out float speed))
                {
                    throw new Exception("字幕速度不是数字，请填写正确的数值");
                }

                int startOffset = 0;
                int endOffset = 0;

                if (GlobalPage.Equals(tabControl1.SelectedTab))
                {
                    if (!int.TryParse(GlobalOffsetTB.Text, out startOffset))
                    {
                        throw new Exception("全局偏移值必须是整数值");
                    }
                    endOffset = startOffset;
                }
                else
                {
                    if (!int.TryParse(StartOffsetTB.Text, out startOffset) || !int.TryParse(EndOffsetTB.Text, out endOffset))
                    {
                        throw new Exception("开始和结束的偏移值必须是整数值");
                    }
                }

                

                #endregion

                StringBuilder ass = new StringBuilder();

                //视频画布大小
                ass.Append("[Script Info]\r\n");
                ass.Append($"PlayResX: {width}\r\n");
                ass.Append($"PlayResY: {height}\r\n");


                //媒体文件
                ass.Append("\r\n[Aegisub Project Garbage]\r\n");

                if (!string.IsNullOrWhiteSpace(MediaNameTB.Text))
                {
                    ass.Append($"Audio File: {MediaNameTB.Text}\r\n");
                }

                if (UseBackgroundBtn.Checked)
                {
                    ass.Append($"Video File: ?dummy:30:40000:{width}:{height}:0:0:0:\r\n");
                }
                else if (!string.IsNullOrWhiteSpace(MediaNameTB.Text))
                {
                    ass.Append($"Video File: {MediaNameTB.Text}\r\n");
                }
                
                //样式代码
                ass.Append("\r\n[V4+ Styles]\r\n");
                ass.Append("Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding\r\n");
                ass.Append(StyleCode).Append("\r\n");
                
                //字幕主体
                ass.Append("\r\n[Events]\r\n");
                ass.Append("Format: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text\r\n");


                List<int> times = GetTimes(speed);

                List<List<StringBuilder>> lrcs = GetLrcs();

                //Dialogue: 0,0:00:07.96,0:00:12.60,Default,,0,0,0,,PCゲーム「穢翼のユースティア」OP

                int index = 0;
                foreach (var item in lrcs)
                {
                    StringBuilder content = new StringBuilder();
                    if (index >= times.Count) break;
                    int startTime = times[index];

                    int currentTime = startTime;

                    foreach (var c in item)
                    {
                        index++;
                        if (index >= times.Count) break;
                        content.Append("{\\kf" + (times[index] - currentTime) / 10 + "}");

                        content.Append(c);
                        currentTime = times[index];
                    }

                    if (!string.IsNullOrWhiteSpace(content.ToString()))
                    {
                        ass.Append("Dialogue: 0,");
                        ass.Append(Offset2AssTime(startTime + startOffset) + ",");
                        ass.Append(Offset2AssTime(currentTime + endOffset) + $",{StyleBox.Text},,0,0,0,,");
                        ass.Append(content);
                        ass.Append("\r\n");
                    }
                    index++;
                }

                AssTB.Text = ass.ToString();
                if (AssPathTB.Text.Equals(MediaNameTB.Text) || !AssPathTB.Text.ToLower().EndsWith(".ass"))
                {
                    AssPathTB.Text = AssPathTB.Text + ".ass";
                }

                File.WriteAllText(AssPathTB.Text, AssTB.Text);
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

                foreach (var line in lrcs)
                {
                    foreach (var c in line)
                    {
                        sb.Append(c).Append("|");
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

        private List<int> GetTimes(float speed)
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
                        offset.Add((int)(int.Parse(vs[2]) / speed));
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

                        if (currentChar > 255 && !CheckChar(currentChar))
                        {
                            lrc.Add(new StringBuilder().Append(currentChar));
                        }
                        else if ((lastChar > 255 || CheckChar(lastChar)) && !CheckChar(currentChar))
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

        private bool CheckChar(char c)
        {
            return SpCharList.Contains(c);
        }

        private string Offset2AssTime(int offset)
        {
            int tmp = offset;
            int ms = tmp % 1000;

            tmp /= 1000;
            int s = tmp % 60;

            tmp /= 60;
            int m = tmp % 60;

            int h = tmp / 60;
            return $"{h:D2}:{m:D2}:{s:D2}.{ms / 10:D2}";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GosuProcess != null && !GosuProcess.HasExited)
            {
                GosuProcess.Kill();
            }
        }

        private void CharBtn_Click(object sender, EventArgs e)
        {
            new CharForm().ShowDialog();
            UpdateCharList();
        }

        private void UpdateCharList()
        {
            try
            {
                if (File.Exists(CharForm.CharPath))
                {
                    string content = File.ReadAllText(CharForm.CharPath);
                    if (!string.IsNullOrWhiteSpace(content))
                    {
                        SpCharList.Clear();
                        foreach (char c in content.ToCharArray())
                        {
                            if (SpCharList.Contains(c)) continue;
                            SpCharList.Add(c);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AssBrowserBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "所有文件(*.*)|*.*";
            dialog.DefaultExt = ".ass";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AssPathTB.Text = dialog.FileName;
            }
        }

        private void MediaBrowserBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MediaNameTB.Text = new FileInfo(dialog.FileName).Name;
            }
        }

        private void StyleCodeBtn_Click(object sender, EventArgs e)
        {
            new StyleForm().ShowDialog();
            UpdateStyleCode();
        }
       
        private void UpdateStyleCode()
        {
            try
            {
                if (File.Exists(StyleForm.StylePath))
                {
                    StyleCode = File.ReadAllText(StyleForm.StylePath);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            finally
            {
                if (string.IsNullOrWhiteSpace(StyleCode))
                {
                    StyleCode = DefaultStyleCode;
                }
            }

            StyleBox.Items.Clear();

            foreach(var item in StyleCode.Split('\n'))
            {
                string line = item.Trim();

                if (line.ToLower().StartsWith("style:") && line.Length > 6)
                {
                    line = line.Substring(6);
                    int index = line.IndexOf(',');
                    if(index >= 0)
                    {
                        string name = line.Substring(0, index).Trim();
                        StyleBox.Items.Add(name);
                    }
                }
            }

            if(StyleBox.Items.Count >0)
            {
                StyleBox.SelectedIndex = 0;
            }
        }

        private void GosuLogBtn_Click(object sender, EventArgs e)
        {
            new GosuLogForm(GosuLog).ShowDialog();
        }
    }
}
