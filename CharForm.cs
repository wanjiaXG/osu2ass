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
    public partial class CharForm : Form
    {
        public CharForm()
        {
            InitializeComponent();
        }

        public static readonly string CharPath = $"{new FileInfo(Application.ExecutablePath).DirectoryName}\\char.txt";

        protected override void OnLoad(EventArgs e)
        {
            try
            {
                if (File.Exists(CharPath)) textBox1.Text = File.ReadAllText(CharPath);
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
                File.WriteAllText(CharPath, textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
