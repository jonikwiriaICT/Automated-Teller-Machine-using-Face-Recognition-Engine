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
    public partial class Withdraw : Form
    {
        
        public Withdraw()
        {
            InitializeComponent();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {
           
           
        }

        private void UpdateCustomerAccount() //adds to database
        {

            using (SqlConnection Connection = new SqlConnection("Data Source=CIT-VUNA\\SQLEXPRESS;Initial Catalog=FaceMatchingATM;Integrated Security=True;"))
            {

                try
                {
                    Connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Customer set AccountBalance=@AccountBalance where customer_id=@customer_id ", Connection);
                    cmd.Parameters.AddWithValue("@AccountBalance", Global.AccountBalance);
                    cmd.Parameters.AddWithValue("@customer_id", Global.CustomerID);
                    cmd.ExecuteNonQuery();
                    Connection.Close();
                    txtWithdraw.Clear();
                    MessageBox.Show("New Transaction has been executed successfully.");

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
                    txtWithdraw.Clear();
                    MessageBox.Show("New Transaction has been executed successfully.");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error has occured:" + ex.Message);

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtWithdraw.Text == "")
            {
                MessageBox.Show("Please enter your Withdrawal Amount");
            }
            else
            {
                if (decimal.Parse(Global.AccountBalance) <= decimal.Parse(txtWithdraw.Text))
                {
                    MessageBox.Show("Please you cannot make withdrawal because your balance is less or equal to the amount that you want to withdraw.");
                }
                else
                {
                    decimal NewAmount = 0;
                    decimal AmountWithdraw = decimal.Parse(txtWithdraw.Text);
                    decimal InitialAmount = decimal.Parse(Global.AccountBalance);
                    NewAmount = decimal.Parse(Global.AccountBalance) - decimal.Parse(txtWithdraw.Text);
                    Global.AccountBalance = NewAmount.ToString();
                    UpdateCustomerAccount();
                    InsertCustomerTransaction(InitialAmount, AmountWithdraw);

                }
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
    }
}
