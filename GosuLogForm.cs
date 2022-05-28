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
    public partial class GosuLogForm : Form
    {
        private StringBuilder GosumemoryLog;
        public GosuLogForm()
        {
            InitializeComponent();
        }

        public GosuLogForm(StringBuilder gosumemoryLog): this()
        {
            GosumemoryLog = gosumemoryLog;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            textBox1.Text = GosumemoryLog.ToString();
        }
    }
}
