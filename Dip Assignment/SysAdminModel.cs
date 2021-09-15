using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _Foundation;
using System.Data;
using System.Configuration;

namespace Dip_Assignment
{
    public partial class SysAdminModel : _Database 
    {
        public static string myConn = ConfigurationManager.ConnectionStrings["mssqlConnectionString"].ConnectionString;

        public DataTable GetReport()
        {
            try
            {
                var datatable = new DataTable();
                using (SqlConnection con=new SqlConnection(myConn))
                {
                    con.Open();
                    using (SqlCommand com=new SqlCommand ("select * from Transactions", con))
                    {
                        using (SqlDataAdapter adapter=new SqlDataAdapter(com))
                        {
                            adapter.Fill(datatable);
                        }
                    }
                }
                return datatable;
            }
            catch (Exception ex)
            {
                ErrorMessage += ex.Message;
                return null;
            }
        }
        public bool changePassword(string Username, string NewPassword)
        {
            try
            {
                string sSQL = "update Customer set PIN='" + NewPassword + "' where customer_id='" + Username + "'";
                SqlCommand objCmd = new SqlCommand();
                objCmd.CommandText = sSQL;
                if (ExecuteNonQuery(objCmd) <= 0)
                {
                    ErrorMessage = "Unable to update transaction";
                    return false;
                }
                ErrorMessage = "Password Changed successfully .";
                return true;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.ToString();
                return false;
            }
        }
    }
}
