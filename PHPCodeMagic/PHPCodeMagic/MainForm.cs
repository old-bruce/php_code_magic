using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHPCodeMagic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void codeIgniterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CIForm ci = new CIForm();
            ci.MdiParent = this;
            ci.Show();
        }
    }
}
