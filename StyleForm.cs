using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace osu2ass
{
    public partial class StyleForm : Form
    {
        public StyleForm()
        {
            InitializeComponent();
        }

        public static readonly string StylePath = $"{new FileInfo(Application.ExecutablePath).DirectoryName}\\style.txt";

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                if (File.Exists(StylePath)) textBox1.Text = File.ReadAllText(StylePath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CharForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                File.WriteAllText(StylePath, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
