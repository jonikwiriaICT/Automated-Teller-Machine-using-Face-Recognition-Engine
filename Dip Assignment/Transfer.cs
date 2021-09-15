using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dip_Assignment
{
    public partial class Transfer : Form
    {
        
        public Transfer()
        {
            InitializeComponent();
        }

        private void FrmUploadDocument_Load(object sender, EventArgs e)
        {
            
        }
        private void TransferMoney()
        {
            try
            {
                if (string.IsNullOrEmpty(txtAccountNumber.Text))
                {
                    MessageBox.Show("Please enter the account number that you want to transfer money to.");

                }
                else if (string.IsNullOrEmpty(txtAmount.Text))
                {
                    MessageBox.Show("Please enter the amount that you want to transfer to" + " " + txtAccountNumber.Text);
                }
                else
                {
                    if (int.Parse(txtAmount.Text) >= int.Parse(Global.AccountBalance))
                    {
                        MessageBox.Show("Please your account balance should not be less or equal than the specified amount you specified.");
                    }
                    else
                    {
                        UpdateTransferAccount();
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void UpdateTransferAccount() //adds to database
        {

            using (SqlConnection Connection = new SqlConnection("Data Source=CIT-VUNA\\SQLEXPRESS;Initial Catalog=FaceMatchingATM;Integrated Security=True;"))
            {

                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer set AccountBalance=@AccountBalance where acccount_no=@acccount_no ", Connection);
                    cmd.Parameters.AddWithValue("@AccountBalance", Global.AccountBalance);
                    cmd.Parameters.AddWithValue("@acccount_no", Global.CustomerID);
                    cmd.ExecuteNonQuery();
                    Connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error has occured:" + ex.Message);

                }
            }

        }
        private void InsertCustomerTransaction(decimal InitialAmount, decimal AmountWithdraw) //adds to database
        {

            using (SqlConnection Connection = new SqlConnection("Data Source=CIT-VUNA\\SQLEXPRESS;Initial Catalog=FaceMatchingATM;Integrated Security=True;"))
            {
                string textWithdraw = "Withdraw" + "  " + AmountWithdraw.ToString();

                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("insert into CustomerTransaction (customer_id, transaction_amount, InitialAmount, transaction_type) values (@customer_id, @transaction_amount, @InitialAmount, '" + textWithdraw.ToString() + "')", Connection);
                    cmd.Parameters.AddWithValue("@customer_id", Global.CustomerID);
                    cmd.Parameters.AddWithValue("@transaction_amount", Global.AccountBalance);
                    cmd.Parameters.AddWithValue("@InitialAmount", InitialAmount);
                    cmd.ExecuteNonQuery();
                    Connection.Close();

                    MessageBox.Show("New Transaction has been executed successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error has occured:" + ex.Message);

                }
            }

        }



        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TransferMoney();
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
    }
}
