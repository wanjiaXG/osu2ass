using Newtonsoft.Json;
using osu2ass.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using WebSocketSharp;

namespace osu2ass
{
    public partial class MainForm : Form
    {

        private WebSocket webSocket;

        private readonly SynchronizationContext Context;

        private Process process;

        private string StyleCode;

        private List<char> CharList = new List<char>();

        public static readonly StringBuilder GosumemoryLog = new StringBuilder();

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
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.RedirectStandardOutput = true;
            new Thread(()=>
            {
                byte[] buffer = new byte[2048];
                while (!this.IsDisposed)
                {
                    try
                    {
                        int? length = process?.StandardOutput?.BaseStream?.Read(buffer, 0, buffer.Length);
                        GosumemoryLog.Append(Encoding.Default.GetString(buffer, 0, (int)length));
                    }
                    catch
                    {

                    }
                }
            }).Start();
            process.Start();


            //Read websocket url
            string server = $"ws://{ini.GetValue<string>("Web", "serverip")}/ws";

            //Connect to gosumemory
            
            webSocket = new WebSocket(server);
            webSocket.Log.File = null;
            webSocket.OnMessage += OnMessage;
            webSocket.OnClose += OnClose;
            webSocket.Connect();

        }

        private void OnClose(object sender, CloseEventArgs e)
        {
            Context.Post((s) => { gosuStatusLB.ForeColor = Color.Red ; gosuStatusLB.Text = "gosu未启动";  }, null );
            //ReConnect to gosumemory
            Thread.Sleep(1000);
            webSocket.Connect();
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
            
        }

        private void ConvertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(AssPathTB.Text))
                {
                    throw new Exception("未选择ass保存路径");
                }
                int GlobalStartOffset = 0;
                int GlobalEndOffset = 0;

                if (GlobalPage.Equals(tabControl1.SelectedTab))
                {
                    if (!string.IsNullOrWhiteSpace(GlobalOffsetTB.Text))
                    {
                        if (int.TryParse(GlobalOffsetTB.Text, out int result))
                        {
                            GlobalStartOffset = GlobalEndOffset = result;
                        }
                        else
                        {
                            throw new Exception("偏移值必须是整数值");
                        }
                    }
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(StartOffsetTB.Text))
                    {
                        if (int.TryParse(StartOffsetTB.Text, out int result))
                        {
                            GlobalStartOffset = result;
                        }
                        else
                        {
                            throw new Exception("偏移值必须是整数值");
                        }
                    }

                    if (!string.IsNullOrWhiteSpace(EndOffsetTB.Text))
                    {
                        if (int.TryParse(EndOffsetTB.Text, out int result))
                        {
                            GlobalEndOffset = result;
                        }
                        else
                        {
                            throw new Exception("偏移值必须是整数值");
                        }
                    }
                }

                StringBuilder ass = new StringBuilder();
                ass.Append("[Script Info]\r\n");
                
                ass.Append("\r\n[Aegisub Project Garbage]\r\n");

                if (!string.IsNullOrWhiteSpace(MediaNameTB.Text))
                {
                    ass.Append($"Audio File: {MediaNameTB.Text}\r\n");
                }

                if (UseBackgroundRBtn.Checked)
                {
                    int width = 0;
                    int height = 0;

                    if (int.TryParse(WidthTB.Text, out int w))
                    {
                        width = w;
                    }
                    else
                    {
                        throw new Exception("画布宽度值必须是整数值");
                    }

                    if (int.TryParse(HeightTB.Text, out int h))
                    {
                        height = h;
                    }
                    else
                    {
                        throw new Exception("画布长度值必须是整数值");
                    }
                    ass.Append($"Video File: ?dummy:30:40000:{width}:{height}:0:0:0:\r\n");
                }
                else if (!string.IsNullOrWhiteSpace(MediaNameTB.Text))
                {
                    ass.Append($"Video File: {MediaNameTB.Text}\r\n");
                }
                
                ass.Append("\r\n[V4+ Styles]\r\n");
                ass.Append("Format: Name, Fontname, Fontsize, PrimaryColour, SecondaryColour, OutlineColour, BackColour, Bold, Italic, Underline, StrikeOut, ScaleX, ScaleY, Spacing, Angle, BorderStyle, Outline, Shadow, Alignment, MarginL, MarginR, MarginV, Encoding\r\n");
                ass.Append(StyleCode).Append("\r\n");
                ass.Append("\r\n[Events]\r\n");
                ass.Append("Format: Layer, Start, End, Style, Name, MarginL, MarginR, MarginV, Effect, Text\r\n");


                List<int> offsets = GetOffsets();

                List<List<StringBuilder>> lrcs = GetLrcs();

                //Dialogue: 0,0:00:07.96,0:00:12.60,Default,,0,0,0,,PCゲーム「穢翼のユースティア」OP

                int index = 0;
                foreach (var item in lrcs)
                {
                    StringBuilder content = new StringBuilder();
                    if (index >= offsets.Count) break;
                    int StartOffset = offsets[index];
                    int CurrentOffset = StartOffset;

                    foreach (var c in item)
                    {
                        index++;
                        if (index >= offsets.Count) break;
                        content.Append("{\\kf" + (offsets[index] - CurrentOffset) / 10 + "}").Append(c);
                        CurrentOffset = offsets[index];
                    }

                    if (!string.IsNullOrWhiteSpace(content.ToString()))
                    {
                        ass.Append("Dialogue: 0,");
                        ass.Append(GetAssTime(StartOffset + GlobalStartOffset) + ",");
                        ass.Append(GetAssTime(CurrentOffset + GlobalStartOffset) + $",{StyleBox.Text},,0,0,0,,");
                        ass.Append(content);
                        ass.Append("\r\n");
                    }
                    index++;
                }
                AssTB.Text = ass.ToString();
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
            return CharList.Contains(c);
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
            return $"{h:D2}:{m:D2}:{s:D2}.{ms / 10:D2}";
        }


        [DllImport("kernel32.dll")]
        static extern bool GenerateConsoleCtrlEvent(int dwCtrlEvent, int dwProcessGroupId);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleCtrlHandler(IntPtr handlerRoutine, bool add);

        [DllImport("kernel32.dll")]
        static extern bool AttachConsole(int dwProcessId);

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (process != null && !process.HasExited)
            {
                process.Kill();
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
                    List<char> tmpList = new List<char>();
                    string content = File.ReadAllText(CharForm.CharPath);
                    if (content != null)
                    {
                        foreach (char c in content.ToCharArray())
                        {
                            if (tmpList.Contains(c)) continue;
                            tmpList.Add(c);
                        }
                        CharList = tmpList;
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

        private void UseBackgroundRBtn_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = UseBackgroundRBtn.Enabled;
        }

        private void StyleCodeBtn_Click(object sender, EventArgs e)
        {
            new StyleForm().ShowDialog();
            UpdateStyleCode();
        }
        private void UpdateStyleCode()
        {
            string Code = "Style: Default,黑体,45,&H00FFFFFF,&H00F0B075,&H00C34F22,&H00000000,0,0,0,0,100,100,0,0,1,1.5,1.99999,2,11,11,50,1\r\n";
            try
            {
                if (File.Exists(StyleForm.StylePath))
                {
                    StyleCode = File.ReadAllText(StyleForm.StylePath);
                }
                else
                {
                    StyleCode = Code;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                StyleCode = Code;
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
            StyleBox.SelectedIndex = 0;
        }

        private void GosuLogBtn_Click(object sender, EventArgs e)
        {
            new GosuLogForm(GosumemoryLog).ShowDialog();
        }
    }
}
