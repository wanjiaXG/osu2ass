
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
            this.GosuModeRBtn = new System.Windows.Forms.RadioButton();
            this.ManualModeRBtn = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gosuStatusLB = new System.Windows.Forms.Label();
            this.RestartGosuBtn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LrcTB = new System.Windows.Forms.TextBox();
            this.LRCTitleLB = new System.Windows.Forms.Label();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.GlobalOffsetTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestBtn = new System.Windows.Forms.Button();
            this.ConvertBtn = new System.Windows.Forms.Button();
            this.OptionLB = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AssTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.AssTitleLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // OsuCodeTB
            // 
            this.OsuCodeTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OsuCodeTB.Location = new System.Drawing.Point(12, 122);
            this.OsuCodeTB.Multiline = true;
            this.OsuCodeTB.Name = "OsuCodeTB";
            this.OsuCodeTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.OsuCodeTB.Size = new System.Drawing.Size(323, 482);
            this.OsuCodeTB.TabIndex = 0;
            // 
            // OsuCodeTitleLB
            // 
            this.OsuCodeTitleLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OsuCodeTitleLB.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OsuCodeTitleLB.Location = new System.Drawing.Point(8, 9);
            this.OsuCodeTitleLB.Name = "OsuCodeTitleLB";
            this.OsuCodeTitleLB.Size = new System.Drawing.Size(327, 33);
            this.OsuCodeTitleLB.TabIndex = 1;
            this.OsuCodeTitleLB.Text = "osu代码";
            this.OsuCodeTitleLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.GosuModeRBtn);
            this.panel1.Controls.Add(this.ManualModeRBtn);
            this.panel1.Location = new System.Drawing.Point(12, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 71);
            this.panel1.TabIndex = 2;
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
            this.panel2.Controls.Add(this.gosuStatusLB);
            this.panel2.Controls.Add(this.RestartGosuBtn);
            this.panel2.Controls.Add(this.OsuCodeTB);
            this.panel2.Controls.Add(this.OsuCodeTitleLB);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 616);
            this.panel2.TabIndex = 3;
            // 
            // gosuStatusLB
            // 
            this.gosuStatusLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gosuStatusLB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gosuStatusLB.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.gosuStatusLB.Location = new System.Drawing.Point(177, 85);
            this.gosuStatusLB.Name = "gosuStatusLB";
            this.gosuStatusLB.Size = new System.Drawing.Size(158, 27);
            this.gosuStatusLB.TabIndex = 4;
            this.gosuStatusLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestartGosuBtn
            // 
            this.RestartGosuBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RestartGosuBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RestartGosuBtn.Location = new System.Drawing.Point(177, 44);
            this.RestartGosuBtn.Name = "RestartGosuBtn";
            this.RestartGosuBtn.Size = new System.Drawing.Size(158, 32);
            this.RestartGosuBtn.TabIndex = 4;
            this.RestartGosuBtn.Text = "重启Gosumemory";
            this.RestartGosuBtn.UseVisualStyleBackColor = true;
            this.RestartGosuBtn.Click += new System.EventHandler(this.RestartGosuBtn_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DimGray;
            this.splitter1.Location = new System.Drawing.Point(347, 0);
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
            this.panel3.Location = new System.Drawing.Point(350, 0);
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
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.Color.DimGray;
            this.splitter3.Location = new System.Drawing.Point(900, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 616);
            this.splitter3.TabIndex = 8;
            this.splitter3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.GlobalOffsetTB);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.TestBtn);
            this.panel4.Controls.Add(this.ConvertBtn);
            this.panel4.Controls.Add(this.OptionLB);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(903, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(616, 116);
            this.panel4.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(229, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 33);
            this.label2.TabIndex = 10;
            this.label2.Text = "ms";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GlobalOffsetTB
            // 
            this.GlobalOffsetTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GlobalOffsetTB.Location = new System.Drawing.Point(92, 47);
            this.GlobalOffsetTB.Name = "GlobalOffsetTB";
            this.GlobalOffsetTB.Size = new System.Drawing.Size(131, 26);
            this.GlobalOffsetTB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "全局偏移";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestBtn
            // 
            this.TestBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TestBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TestBtn.Location = new System.Drawing.Point(10, 78);
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
            this.ConvertBtn.Location = new System.Drawing.Point(512, 78);
            this.ConvertBtn.Name = "ConvertBtn";
            this.ConvertBtn.Size = new System.Drawing.Size(92, 32);
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
            this.OptionLB.Size = new System.Drawing.Size(598, 33);
            this.OptionLB.TabIndex = 3;
            this.OptionLB.Text = "选项";
            this.OptionLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.DimGray;
            this.splitter2.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(903, 116);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(616, 3);
            this.splitter2.TabIndex = 10;
            this.splitter2.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.AssTB);
            this.panel5.Controls.Add(this.SaveBtn);
            this.panel5.Controls.Add(this.AssTitleLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(903, 119);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(616, 497);
            this.panel5.TabIndex = 11;
            // 
            // AssTB
            // 
            this.AssTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssTB.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssTB.Location = new System.Drawing.Point(10, 36);
            this.AssTB.Multiline = true;
            this.AssTB.Name = "AssTB";
            this.AssTB.ReadOnly = true;
            this.AssTB.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.AssTB.Size = new System.Drawing.Size(594, 412);
            this.AssTB.TabIndex = 4;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SaveBtn.Location = new System.Drawing.Point(512, 453);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(92, 32);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // AssTitleLabel
            // 
            this.AssTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AssTitleLabel.Font = new System.Drawing.Font("黑体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AssTitleLabel.Location = new System.Drawing.Point(6, 3);
            this.AssTitleLabel.Name = "AssTitleLabel";
            this.AssTitleLabel.Size = new System.Drawing.Size(607, 33);
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
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox GlobalOffsetTB;
        private System.Windows.Forms.Label label1;
    }
}

