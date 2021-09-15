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
    public partial class TakeFaceMatch : Form
    {
        public TakeFaceMatch()
        {
            InitializeComponent();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new FrmMain("attendance");
            if (mainForm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            var mainForm = new FrmAdminLogin();
            if (mainForm.ShowDialog() == DialogResult.Cancel)
            {
                Application.Exit();
            }
        }
    }
}
