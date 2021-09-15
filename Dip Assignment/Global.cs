using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip_Assignment
{
    static class Global
    {
        private static string customerID = "";
        public static string CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }
        private static string customername = "";
        public static string CustomerName
        {
            get
            {
                return customername;
            }

            set
            {
                customername = value;
            }
        }
        private static string accountno = "";
        public static string AccountNo
        {
            get
            {
                return accountno;
            }

            set
            {
                accountno = value;
            }
        }
        private static string pin = "";
        public static string PIN
        {
            get
            {
                return pin;
            }

            set
            {
                pin = value;
            }
        }
        private static string accountbalance = "";
        public static string AccountBalance
        {
            get
            {
                return accountbalance;
            }

            set
            {
                accountbalance = value;
            }
        }
        private static string username = "";
        public static string UserName
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        private static string professor = "";
        public static string Professor
        {
            get
            {
                return professor;
            }

            set
            {
                professor = value;
            }
        }

        private static string professorid = "";
        public static string Professorid
        {
            get
            {
                return professorid;
            }

            set
            {
                professorid = value;
            }
        }

        private static string courseid = "";
        public static string Courseid
        {
            get
            {
                return courseid;
            }

            set
            {
                courseid = value;
            }
        }
    }
}
