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

namespace PHPCodeMagic
{
    public partial class CIForm : Form
    {
        public CIForm()
        {
            InitializeComponent();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {
            string code = File.ReadAllText(Application.StartupPath + @"\templates\codeigniter\model.php");
            string table = tbxTable.Text.Trim();
            string TABLE = tbxTable.Text.Trim().ToUpper()[0] + tbxTable.Text.Trim().ToLower().Substring(1, tbxTable.Text.Trim().Length - 1);
            code = code.Replace("{TABLE}", TABLE);
            code = code.Replace("{table}", table);
            rbxCode.Text = code;
        }

        private void btnController_Click(object sender, EventArgs e)
        {
            string code = File.ReadAllText(Application.StartupPath + @"\templates\codeigniter\controller.php");
            string table = tbxTable.Text.Trim();
            string TABLE = tbxTable.Text.Trim().ToUpper()[0] + tbxTable.Text.Trim().ToLower().Substring(1, tbxTable.Text.Trim().Length - 1);
            code = code.Replace("{TABLE}", TABLE);
            code = code.Replace("{table}", table);
            rbxCode.Text = code;
        }

        private void tbxTable_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnModel_Click(btnModel, EventArgs.Empty);
            }
        }

        private void btnEmptyController_Click(object sender, EventArgs e)
        {
            string code = File.ReadAllText(Application.StartupPath + @"\templates\codeigniter\empty.controller.php");
            string table = tbxTable.Text.Trim();
            string TABLE = tbxTable.Text.Trim().ToUpper()[0] + tbxTable.Text.Trim().ToLower().Substring(1, tbxTable.Text.Trim().Length - 1);
            code = code.Replace("{TABLE}", TABLE);
            code = code.Replace("{table}", table);
            rbxCode.Text = code;
        }
    }
}
