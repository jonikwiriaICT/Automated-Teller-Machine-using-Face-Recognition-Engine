using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dip_Assignment
{
    public partial class NewCustomer : Form
    {
        string conString = "Data Source=CIT-VUNA\\SQLEXPRESS;Initial Catalog=FaceMatchingATM;Integrated Security=True;";

        SqlConnection sqlCon;
        SqlCommand sqlCmd;
        string EmployeeId = "";
        public NewCustomer()
        {
            InitializeComponent();
            sqlCon = new SqlConnection(conString);
            sqlCon.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Enter Customer Name !!!");
                    txtName.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
                {
                    MessageBox.Show("Enter Account Number !!!");
                    txtAccountNumber.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtPin.Text))
                {
                    MessageBox.Show("Enter PIN !!!");
                    txtPin.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtAccountBalance.Text))
                {
                    MessageBox.Show("Enter Account Balance !!!");
                    txtAccountBalance.Select();
                }
                else if (string.IsNullOrWhiteSpace(txtUsername.Text))
                {
                    MessageBox.Show("Enter Username !!!");
                    txtUsername.Select();
                }
                else
                {
                    try
                    {
                        if (sqlCon.State == ConnectionState.Closed)
                        {
                            sqlCon.Open();
                        }
                        DataTable dtData = new DataTable();
                        sqlCmd = new SqlCommand("spCustomer", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                        sqlCmd.Parameters.AddWithValue("@customer_id", EmployeeId);
                        sqlCmd.Parameters.AddWithValue("@fullname", txtName.Text);
                        sqlCmd.Parameters.AddWithValue("@account_no", txtAccountNumber.Text);
                        sqlCmd.Parameters.AddWithValue("@PIN", txtPin.Text);
                        sqlCmd.Parameters.AddWithValue("@AccountBalance", txtAccountBalance.Text);
                        sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text);
                        int numRes = sqlCmd.ExecuteNonQuery();
                        if (numRes > 0)
                        {
                            MessageBox.Show("Record Saved Successfully !!!");
                            ClearAllData();
                        }
                        else
                            MessageBox.Show("Please Try Again !!!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:- " + ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {

            }

        }
        private void NewCustomer_Load(object sender, EventArgs e)
        {
            dgvEmp.AutoGenerateColumns = false; // dgvEmp is DataGridView name
            dgvEmp.DataSource = FetchEmpDetails();
        }

        private DataTable FetchEmpDetails()
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand("spCustomer", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchData");
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private DataTable FetchEmpRecords(string empId)
        {
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
            DataTable dtData = new DataTable();
            sqlCmd = new SqlCommand("spCustomer", sqlCon);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@ActionType", "FetchRecord");
            sqlCmd.Parameters.AddWithValue("@EmployeeId", empId);
            SqlDataAdapter sqlSda = new SqlDataAdapter(sqlCmd);
            sqlSda.Fill(dtData);
            return dtData;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName .Text))
            {
                MessageBox.Show("Enter Customer Name !!!");
                txtName .Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAccountNumber .Text))
            {
                MessageBox.Show("Enter Account Number !!!");
                txtAccountNumber.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtPin.Text))
            {
                MessageBox.Show("Enter PIN !!!");
                txtPin .Select();
            }
            else if (string.IsNullOrWhiteSpace(txtAccountBalance.Text))
            {
                MessageBox.Show("Enter Account Balance !!!");
                txtAccountBalance.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtUsername .Text))
            {
                MessageBox.Show("Enter Username !!!");
                txtUsername.Select();
            }
            else
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "SaveData");
                    sqlCmd.Parameters.AddWithValue("@customer_id", EmployeeId);
                    sqlCmd.Parameters.AddWithValue("@fullname", txtName .Text);
                    sqlCmd.Parameters.AddWithValue("@account_no", txtAccountNumber.Text);
                    sqlCmd.Parameters.AddWithValue("@PIN", txtPin.Text);
                    sqlCmd.Parameters.AddWithValue("@AccountBalance", txtAccountBalance.Text);
                    sqlCmd.Parameters.AddWithValue("@username", txtUsername .Text);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Saved Successfully !!!");
                        ClearAllData();
                    }
                    else
                        MessageBox.Show("Please Try Again !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmployeeId))
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@customer_id", EmployeeId);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully !!!");
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Please Try Again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Record !!!");
            }
        }

        private void dgvEmp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                button1.Text = "Update";
                EmployeeId = dgvEmp.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable dtData = FetchEmpRecords(EmployeeId);
                if (dtData.Rows.Count > 0)
                {
                    EmployeeId = dtData.Rows[0][0].ToString();
                    txtName .Text = dtData.Rows[0][1].ToString();
                    txtAccountNumber.Text = dtData.Rows[0][2].ToString();
                    txtPin.Text = dtData.Rows[0][3].ToString();
                    txtAccountBalance.Text = dtData.Rows[0][4].ToString();
                    txtUsername.Text = dtData.Rows[0][5].ToString();
                }
                else
                {
                    ClearAllData(); // For clear all control and refresh DataGridView data.
                }
            }
        }

        private void ClearAllData()
        {
            btnSave.Text = "Save";
            txtName .Text = "";
            txtAccountNumber.Text = "";
            txtPin.Text = "";
            txtAccountBalance.Text  = "";
            txtUsername.Text = "";
            EmployeeId = "";
            dgvEmp.AutoGenerateColumns = false;
            dgvEmp.DataSource = FetchEmpDetails();
        }

        private void dgvEmp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            try
            {
                Hide();
                var NewCustomers = new Form1();

                if (NewCustomers.ShowDialog() == DialogResult.Cancel)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(EmployeeId))
            {
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                    {
                        sqlCon.Open();
                    }
                    DataTable dtData = new DataTable();
                    sqlCmd = new SqlCommand("spCustomer", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@ActionType", "DeleteData");
                    sqlCmd.Parameters.AddWithValue("@customer_id", EmployeeId);
                    int numRes = sqlCmd.ExecuteNonQuery();
                    if (numRes > 0)
                    {
                        MessageBox.Show("Record Deleted Successfully !!!");
                        ClearAllData();
                    }
                    else
                    {
                        MessageBox.Show("Please Try Again !!!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:- " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please Select A Record !!!");
            }
        }
    }
}
