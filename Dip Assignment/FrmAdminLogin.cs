using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dip_Assignment
{
    public partial class FrmAdminLogin : Form
    {
        SqlConnection con = new SqlConnection("Data Source=CIT-VUNA\\SQLEXPRESS;Initial Catalog=FaceMatchingATM;Integrated Security=True;");
        public FrmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                txtUsername.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Please Input Username and Password");
            }
            else
            {
                if (txtUsername.Text =="admin" && txtPassword .Text == "admin")
                {
                    var Main = new Form1();
                    Hide();
                    if (Main.ShowDialog() == DialogResult.Cancel)
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select count(*) from Customer where username=@name and PIN=@pwd;", con);
                    cmd.Parameters.Add(new SqlParameter("@name", txtUsername.Text));
                    cmd.Parameters.Add(new SqlParameter("@pwd", txtPassword.Text));
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();

                    if (count >= 1)
                    {
                        con.Open();
                        SqlCommand cmd1 = new SqlCommand("select customer_id,fullname,account_no,PIN, AccountBalance,username from Customer where username=@name and PIN=@pwd;", con);
                        cmd1.Parameters.Add(new SqlParameter("@name", txtUsername.Text));
                        cmd1.Parameters.Add(new SqlParameter("@pwd", txtPassword.Text));
                        SqlDataReader dr = cmd1.ExecuteReader();
                        while (dr.Read())
                        {
                            Global.CustomerID = dr["customer_id"].ToString();
                            Global.CustomerName = dr["fullname"].ToString();
                            Global.AccountNo = dr["account_no"].ToString();
                            Global.PIN = dr["PIN"].ToString();
                            Global.AccountBalance = dr["AccountBalance"].ToString();
                            Global.UserName  = dr["username"].ToString();
                        }
                        dr.Close();
                        MessageBox.Show("Login Successful. Welcome Customer " + Global.CustomerName);
                        con.Close();
                        var FaceMatch = new TakeFaceMatch();
                        Hide();
                        if (FaceMatch.ShowDialog() == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                        //var adminOptionsForm = new FrmAdminOptions();
                        //Hide();
                        //if (adminOptionsForm.ShowDialog() == DialogResult.Cancel)
                        //{
                        //    Show();
                        //}
                    }
                    else
                    {
                        txtUsername.Text = "";
                        txtPassword.Text = "";
                        MessageBox.Show("Invalid Username/Password");
                    }
                }
            }
        }

        private void FrmAdminLogin_Load(object sender, EventArgs e)
        {
            Hide();
            //Show SplashScreen first
            var splashScreen = new FrmSplashScreen(this);
            splashScreen.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void btnUserLogin_Click(object sender, EventArgs e)
        //{
        //    Hide();
        //    var mainForm = new FrmMain(true);
        //    if (mainForm.ShowDialog() == DialogResult.Cancel)
        //    {
        //        Show();
        //    }
        //}
    }
}
