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

namespace Db
{
    public class DBHelper 
    {
        public static string uid = "pis-dev";
        public static string password = "huen3549";
        public static string database = "PIS-DEV";
        public static string server = "devsql.huen.biz";

        private static SqlConnection conn = null;
        private static string DBConnString { get; set; }
        public static bool DBConnCheck = false;
        private static int errorBoxCount = 0;
        public DBHelper() { }
        
        public static SqlConnection sqlConnection
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }
        
        public static SqlConnection DBConn
        {
            get
            {
                if (!ConnectToDB())
                {
                    return null;
                }
                return conn;
            }
        }
        public static bool ConnectToDB()
        {
            if(conn == null)
            {
                SqlConnection DBConnection = new SqlConnection();
                string connStr = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + ";";
                conn = new SqlConnection(connStr);
            }
            try
            {
                if (!IsDBConnected)
                {
                    conn.Open();
                    if(conn.State == System.Data.ConnectionState.Open)
                    {
                        DBConnCheck = true;
                    }
                    else
                    {
                        DBConnCheck = false;
                    }
                }
            }catch(SqlException e)
            {
                errorBoxCount++;
                if(errorBoxCount == 1)
                {
                    MessageBox.Show(e.Message, "DBHelper - ConnectToDB()");
                }
                return false;
            }
            return true;
        }
        public static bool IsDBConnected
        {
            get
            {
                if(conn.State != System.Data.ConnectionState.Open)
                {
                    return false;
                }
                return true;
            }
        }
        public static void Close()
        {
            if (IsDBConnected) DBConn.Close();
        }
    }
}
