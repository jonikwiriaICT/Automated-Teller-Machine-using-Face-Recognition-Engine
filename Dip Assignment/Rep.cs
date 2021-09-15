using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dip_Assignment
{
    public partial class Rep : Form
    {
        SysAdminModel objAdm = new SysAdminModel();
        public Rep()
        {
            InitializeComponent();
        }
        private void Rep_Load(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var adminoptions = new Form1();
            if (adminoptions.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void Rep_Load_1(object sender, EventArgs e)
        {
            dgvEmp.AutoGenerateColumns = true; // dgvEmp is DataGridView name
            dgvEmp.DataSource = objAdm.GetReport();
        }
    }
}
