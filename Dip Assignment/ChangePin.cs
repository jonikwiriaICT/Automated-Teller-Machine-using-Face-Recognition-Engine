using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dip_Assignment
{
    public partial class ChangePin : Form
    {
        public string _identificationNumber = "";
        SysAdminModel objAdm = new SysAdminModel();
        public ChangePin()
        {
            InitializeComponent();
        }
        private void ChangePin_Load(object senser, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {

            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ChangePinFunction();
            }
            catch(Exception ex)
            {

            }
        }
        private void ChangePinFunction()
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewPin.Text))
                {
                    MessageBox.Show("Please enter your new PIN.");
                }

                else
                {
                    if (objAdm.changePassword(Global.CustomerID, txtNewPin.Text) == true)
                    {
                        MessageBox.Show(objAdm.ErrorMessage);
                    }
                    else
                    {
                        MessageBox.Show(objAdm.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Hide();
                var NewCustomers = new UserATMTransaction();

                if (NewCustomers.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {

            }
        }
        // Select and Update Password
    }
}
