
namespace osu2ass
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.OsuCodeTB = new System.Windows.Forms.TextBox();
            this.OsuCodeTitleLB = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GosuLogBtn = new System.Windows.Forms.Button();
            this.gosuStatusLB = new System.Windows.Forms.Label();
            this.GosuModeRBtn = new System.Windows.Forms.RadioButton();
            this.ManualModeRBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RestartGosuBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LrcTB = new System.Windows.Forms.TextBox();
            this.LRCTitleLB = new System.Windows.Forms.Label();
            this.CharBtn = new System.Windows.Forms.Button();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.StyleBox = new System.Windows.Forms.ComboBox();
            this.StyleCodeBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.HeightTB = new System.Windows.Forms.TextBox();
            this.WidthTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.UseBackgroundRBtn = new System.Windows.Forms.CheckBox();
            this.MediaBrowserBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MediaNameTB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.GlobalPage = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.GlobalOffsetTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ManualPage = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.EndOffsetTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.StartOffsetTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TestBtn = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.OptionLB = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AssBrowserBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AssPathTB = new System.Windows.Forms.TextBox();
            this.AssTB = new System.Windows.Forms.TextBox();
            this.AssTitleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.GlobalPage.SuspendLayout();
            this.ManualPage.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // OsuCodeTB
            // 
            this.OsuCodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OsuCodeTB.Location = new System.Drawing.Point(12, 159);
            this.OsuCodeTB.Multiline = true;
            this.OsuCodeTB.Name = "OsuCodeTB";
            this.OsuCodeTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OsuCodeTB.Size = new System.Drawing.Size(346, 445);
            this.OsuCodeTB.TabIndex = 0;
            // 
            // OsuCodeTitleLB
            // 
            this.OsuCodeTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OsuCodeTitleLB.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OsuCodeTitleLB.Location = new System.Drawing.Point(8, 9);
            this.OsuCodeTitleLB.Name = "OsuCodeTitleLB";
            this.OsuCodeTitleLB.Size = new System.Drawing.Size(350, 33);
            this.OsuCodeTitleLB.TabIndex = 1;
            this.OsuCodeTitleLB.Text = "osu代码";
            this.OsuCodeTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.GosuLogBtn);
            this.panel1.Controls.Add(this.gosuStatusLB);
            this.panel1.Controls.Add(this.GosuModeRBtn);
            this.panel1.Controls.Add(this.ManualModeRBtn);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 71);
            this.panel1.TabIndex = 2;
            // 
            // GosuLogBtn
            // 
            this.GosuLogBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GosuLogBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GosuLogBtn.Location = new System.Drawing.Point(252, 37);
            this.GosuLogBtn.Name = "GosuLogBtn";
            this.GosuLogBtn.Size = new System.Drawing.Size(91, 29);
            this.GosuLogBtn.TabIndex = 5;
            this.GosuLogBtn.Text = "gosu日志";
            this.GosuLogBtn.UseVisualStyleBackColor = true;
            this.GosuLogBtn.Click += new System.EventHandler(this.GosuLogBtn_Click);
            // 
            // gosuStatusLB
            // 
            this.gosuStatusLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gosuStatusLB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gosuStatusLB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gosuStatusLB.Location = new System.Drawing.Point(157, 37);
            this.gosuStatusLB.Name = "gosuStatusLB";
            this.gosuStatusLB.Size = new System.Drawing.Size(92, 27);
            this.gosuStatusLB.TabIndex = 4;
            this.gosuStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GosuModeRBtn
            // 
            this.GosuModeRBtn.AutoSize = true;
            this.GosuModeRBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GosuModeRBtn.Location = new System.Drawing.Point(13, 40);
            this.GosuModeRBtn.Name = "GosuModeRBtn";
            this.GosuModeRBtn.Size = new System.Drawing.Size(138, 20);
            this.GosuModeRBtn.TabIndex = 1;
            this.GosuModeRBtn.TabStop = true;
            this.GosuModeRBtn.Text = "Gosumemory模式";
            this.GosuModeRBtn.UseVisualStyleBackColor = true;
            this.GosuModeRBtn.CheckedChanged += new System.EventHandler(this.GosuModeRBtn_CheckedChanged);
            // 
            // ManualModeRBtn
            // 
            this.ManualModeRBtn.AutoSize = true;
            this.ManualModeRBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ManualModeRBtn.Location = new System.Drawing.Point(13, 14);
            this.ManualModeRBtn.Name = "ManualModeRBtn";
            this.ManualModeRBtn.Size = new System.Drawing.Size(90, 20);
            this.ManualModeRBtn.TabIndex = 0;
            this.ManualModeRBtn.TabStop = true;
            this.ManualModeRBtn.Text = "手动模式";
            this.ManualModeRBtn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RestartGosuBtn);
            this.panel2.Controls.Add(this.OsuCodeTB);
            this.panel2.Controls.Add(this.OsuCodeTitleLB);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 616);
            this.panel2.TabIndex = 3;
            // 
            // RestartGosuBtn
            // 
            this.RestartGosuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestartGosuBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RestartGosuBtn.Location = new System.Drawing.Point(12, 122);
            this.RestartGosuBtn.Name = "RestartGosuBtn";
            this.RestartGosuBtn.Size = new System.Drawing.Size(346, 32);
            this.RestartGosuBtn.TabIndex = 4;
            this.RestartGosuBtn.Text = "重启Gosumemory";
            this.RestartGosuBtn.UseVisualStyleBackColor = true;
            this.RestartGosuBtn.Click += new System.EventHandler(this.RestartGosuBtn_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DimGray;
            this.splitter1.Location = new System.Drawing.Point(370, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 616);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LrcTB);
            this.panel3.Controls.Add(this.LRCTitleLB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(373, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 616);
            this.panel3.TabIndex = 5;
            // 
            // LrcTB
            // 
            this.LrcTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LrcTB.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LrcTB.Location = new System.Drawing.Point(10, 45);
            this.LrcTB.Multiline = true;
            this.LrcTB.Name = "LrcTB";
            this.LrcTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LrcTB.Size = new System.Drawing.Size(527, 559);
            this.LrcTB.TabIndex = 3;
            // 
            // LRCTitleLB
            // 
            this.LRCTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LRCTitleLB.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LRCTitleLB.Location = new System.Drawing.Point(6, 9);
            this.LRCTitleLB.Name = "LRCTitleLB";
            this.LRCTitleLB.Size = new System.Drawing.Size(540, 33);
            this.LRCTitleLB.TabIndex = 2;
            this.LRCTitleLB.Text = "歌词";
            this.LRCTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CharBtn
            // 
            this.CharBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CharBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CharBtn.Location = new System.Drawing.Point(144, 211);
            this.CharBtn.Name = "CharBtn";
            this.CharBtn.Size = new System.Drawing.Size(92, 32);
            this.CharBtn.TabIndex = 8;
            this.CharBtn.Text = "特殊字符";
            this.CharBtn.UseVisualStyleBackColor = true;
            this.CharBtn.Click += new System.EventHandler(this.CharBtn_Click);
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.DimGray;
            this.splitter3.Location = new System.Drawing.Point(923, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 616);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.AllowDrop = true;
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.StyleBox);
            this.panel4.Controls.Add(this.StyleCodeBtn);
            this.panel4.Controls.Add(this.groupBox2);
            this.panel4.Controls.Add(this.UseBackgroundRBtn);
            this.panel4.Controls.Add(this.CharBtn);
            this.panel4.Controls.Add(this.MediaBrowserBtn);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.MediaNameTB);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Controls.Add(this.TestBtn);
            this.panel4.Controls.Add(this.ConvertBtn);
            this.panel4.Controls.Add(this.OptionLB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(926, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(593, 249);
            this.panel4.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(374, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 33);
            this.label11.TabIndex = 24;
            this.label11.Text = "样式名称";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StyleBox
            // 
            this.StyleBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StyleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StyleBox.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StyleBox.FormattingEnabled = true;
            this.StyleBox.Location = new System.Drawing.Point(458, 154);
            this.StyleBox.Name = "StyleBox";
            this.StyleBox.Size = new System.Drawing.Size(123, 24);
            this.StyleBox.TabIndex = 23;
            // 
            // StyleCodeBtn
            // 
            this.StyleCodeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StyleCodeBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StyleCodeBtn.Location = new System.Drawing.Point(368, 106);
            this.StyleCodeBtn.Name = "StyleCodeBtn";
            this.StyleCodeBtn.Size = new System.Drawing.Size(213, 32);
            this.StyleCodeBtn.TabIndex = 22;
            this.StyleCodeBtn.Text = "默认Style代码";
            this.StyleCodeBtn.UseVisualStyleBackColor = true;
            this.StyleCodeBtn.Click += new System.EventHandler(this.StyleCodeBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.HeightTB);
            this.groupBox2.Controls.Add(this.WidthTB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(245, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 102);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "画布";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "长";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HeightTB
            // 
            this.HeightTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeightTB.Location = new System.Drawing.Point(46, 55);
            this.HeightTB.Name = "HeightTB";
            this.HeightTB.Size = new System.Drawing.Size(63, 26);
            this.HeightTB.TabIndex = 20;
            this.HeightTB.Text = "1080";
            // 
            // WidthTB
            // 
            this.WidthTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WidthTB.Location = new System.Drawing.Point(46, 23);
            this.WidthTB.Name = "WidthTB";
            this.WidthTB.Size = new System.Drawing.Size(63, 26);
            this.WidthTB.TabIndex = 18;
            this.WidthTB.Text = "1920";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 33);
            this.label2.TabIndex = 19;
            this.label2.Text = "宽";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UseBackgroundRBtn
            // 
            this.UseBackgroundRBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UseBackgroundRBtn.Location = new System.Drawing.Point(245, 76);
            this.UseBackgroundRBtn.Name = "UseBackgroundRBtn";
            this.UseBackgroundRBtn.Size = new System.Drawing.Size(129, 24);
            this.UseBackgroundRBtn.TabIndex = 16;
            this.UseBackgroundRBtn.Text = "使用纯色背景";
            this.UseBackgroundRBtn.UseVisualStyleBackColor = true;
            // 
            // MediaBrowserBtn
            // 
            this.MediaBrowserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaBrowserBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MediaBrowserBtn.Location = new System.Drawing.Point(489, 41);
            this.MediaBrowserBtn.Name = "MediaBrowserBtn";
            this.MediaBrowserBtn.Size = new System.Drawing.Size(92, 32);
            this.MediaBrowserBtn.TabIndex = 15;
            this.MediaBrowserBtn.Text = "浏览";
            this.MediaBrowserBtn.UseVisualStyleBackColor = true;
            this.MediaBrowserBtn.Click += new System.EventHandler(this.MediaBrowserBtn_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(242, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "媒体文件";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MediaNameTB
            // 
            this.MediaNameTB.AllowDrop = true;
            this.MediaNameTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MediaNameTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MediaNameTB.Location = new System.Drawing.Point(325, 44);
            this.MediaNameTB.Name = "MediaNameTB";
            this.MediaNameTB.ReadOnly = true;
            this.MediaNameTB.Size = new System.Drawing.Size(158, 26);
            this.MediaNameTB.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 160);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "偏移";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.GlobalPage);
            this.tabControl1.Controls.Add(this.ManualPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(220, 135);
            this.tabControl1.TabIndex = 0;
            // 
            // GlobalPage
            // 
            this.GlobalPage.Controls.Add(this.label4);
            this.GlobalPage.Controls.Add(this.GlobalOffsetTB);
            this.GlobalPage.Controls.Add(this.label9);
            this.GlobalPage.Location = new System.Drawing.Point(4, 26);
            this.GlobalPage.Name = "GlobalPage";
            this.GlobalPage.Padding = new System.Windows.Forms.Padding(3);
            this.GlobalPage.Size = new System.Drawing.Size(212, 105);
            this.GlobalPage.TabIndex = 0;
            this.GlobalPage.Text = "全局";
            this.GlobalPage.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(175, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "ms";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GlobalOffsetTB
            // 
            this.GlobalOffsetTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GlobalOffsetTB.Location = new System.Drawing.Point(74, 39);
            this.GlobalOffsetTB.Name = "GlobalOffsetTB";
            this.GlobalOffsetTB.Size = new System.Drawing.Size(95, 26);
            this.GlobalOffsetTB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(9, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 33);
            this.label9.TabIndex = 14;
            this.label9.Text = "偏移";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManualPage
            // 
            this.ManualPage.Controls.Add(this.label7);
            this.ManualPage.Controls.Add(this.EndOffsetTB);
            this.ManualPage.Controls.Add(this.label8);
            this.ManualPage.Controls.Add(this.label5);
            this.ManualPage.Controls.Add(this.StartOffsetTB);
            this.ManualPage.Controls.Add(this.label6);
            this.ManualPage.Location = new System.Drawing.Point(4, 26);
            this.ManualPage.Name = "ManualPage";
            this.ManualPage.Padding = new System.Windows.Forms.Padding(3);
            this.ManualPage.Size = new System.Drawing.Size(212, 105);
            this.ManualPage.TabIndex = 1;
            this.ManualPage.Text = "微调";
            this.ManualPage.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(173, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 33);
            this.label7.TabIndex = 16;
            this.label7.Text = "ms";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndOffsetTB
            // 
            this.EndOffsetTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.EndOffsetTB.Location = new System.Drawing.Point(72, 55);
            this.EndOffsetTB.Name = "EndOffsetTB";
            this.EndOffsetTB.Size = new System.Drawing.Size(95, 26);
            this.EndOffsetTB.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(7, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "结束";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(173, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 33);
            this.label5.TabIndex = 13;
            this.label5.Text = "ms";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartOffsetTB
            // 
            this.StartOffsetTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartOffsetTB.Location = new System.Drawing.Point(72, 23);
            this.StartOffsetTB.Name = "StartOffsetTB";
            this.StartOffsetTB.Size = new System.Drawing.Size(95, 26);
            this.StartOffsetTB.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(7, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 33);
            this.label6.TabIndex = 11;
            this.label6.Text = "开始";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestBtn
            // 
            this.TestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TestBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestBtn.Location = new System.Drawing.Point(13, 211);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(92, 32);
            this.TestBtn.TabIndex = 7;
            this.TestBtn.Text = "分词测试";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // ConvertBtn
            // 
            this.ConvertBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConvertBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConvertBtn.Location = new System.Drawing.Point(245, 211);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(336, 32);
            this.ConvertBtn.TabIndex = 5;
            this.ConvertBtn.Text = "开始转换";
            this.ConvertBtn.UseVisualStyleBackColor = true;
            this.ConvertBtn.Click += new System.EventHandler(this.ConvertBtn_Click);
            // 
            // OptionLB
            // 
            this.OptionLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionLB.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OptionLB.Location = new System.Drawing.Point(6, 9);
            this.OptionLB.Name = "OptionLB";
            this.OptionLB.Size = new System.Drawing.Size(575, 33);
            this.OptionLB.TabIndex = 3;
            this.OptionLB.Text = "选项";
            this.OptionLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.DimGray;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(926, 249);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(593, 3);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AssBrowserBtn);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.AssPathTB);
            this.panel5.Controls.Add(this.AssTB);
            this.panel5.Controls.Add(this.AssTitleLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(926, 252);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(593, 364);
            this.panel5.TabIndex = 11;
            // 
            // AssBrowserBtn
            // 
            this.AssBrowserBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AssBrowserBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssBrowserBtn.Location = new System.Drawing.Point(489, 39);
            this.AssBrowserBtn.Name = "AssBrowserBtn";
            this.AssBrowserBtn.Size = new System.Drawing.Size(92, 32);
            this.AssBrowserBtn.TabIndex = 12;
            this.AssBrowserBtn.Text = "浏览";
            this.AssBrowserBtn.UseVisualStyleBackColor = true;
            this.AssBrowserBtn.Click += new System.EventHandler(this.AssBrowserBtn_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(9, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 33);
            this.label3.TabIndex = 11;
            this.label3.Text = "文件路径";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssPathTB
            // 
            this.AssPathTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssPathTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssPathTB.Location = new System.Drawing.Point(92, 43);
            this.AssPathTB.Name = "AssPathTB";
            this.AssPathTB.ReadOnly = true;
            this.AssPathTB.Size = new System.Drawing.Size(391, 26);
            this.AssPathTB.TabIndex = 10;
            // 
            // AssTB
            // 
            this.AssTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssTB.Location = new System.Drawing.Point(10, 77);
            this.AssTB.Multiline = true;
            this.AssTB.Name = "AssTB";
            this.AssTB.ReadOnly = true;
            this.AssTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AssTB.Size = new System.Drawing.Size(571, 275);
            this.AssTB.TabIndex = 4;
            // 
            // AssTitleLabel
            // 
            this.AssTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssTitleLabel.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.AssTitleLabel.Name = "AssTitleLabel";
            this.AssTitleLabel.Size = new System.Drawing.Size(584, 33);
            this.AssTitleLabel.TabIndex = 3;
            this.AssTitleLabel.Text = "转换结果";
            this.AssTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 616);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "MainForm";
            this.Text = "osu2ass";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.GlobalPage.ResumeLayout(false);
            this.GlobalPage.PerformLayout();
            this.ManualPage.ResumeLayout(false);
            this.ManualPage.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OsuCodeTB;
        private System.Windows.Forms.Label OsuCodeTitleLB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton ManualModeRBtn;
        private System.Windows.Forms.RadioButton GosuModeRBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox LrcTB;
        private System.Windows.Forms.Label LRCTitleLB;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox AssTB;
        private System.Windows.Forms.Label AssTitleLabel;
        private System.Windows.Forms.Label OptionLB;
        private System.Windows.Forms.Label gosuStatusLB;
        private System.Windows.Forms.Button RestartGosuBtn;
        private System.Windows.Forms.Button ConvertBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Button CharBtn;
        private System.Windows.Forms.Button AssBrowserBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AssPathTB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage GlobalPage;
        private System.Windows.Forms.TabPage ManualPage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GlobalOffsetTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EndOffsetTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox StartOffsetTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button MediaBrowserBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MediaNameTB;
        private System.Windows.Forms.Button GosuLogBtn;
        private System.Windows.Forms.TextBox HeightTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WidthTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox UseBackgroundRBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button StyleCodeBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox StyleBox;
    }
}

