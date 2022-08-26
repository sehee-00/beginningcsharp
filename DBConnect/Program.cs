using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
namespace DBConnect
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string connectionString = ConfigurationManager.ConnectionStrings["TestDb"].ConnectionString;

            MemberInfo item = new MemberInfo();
            item.Name = "Jennifer";
            item.Birth = new DateTime(1997, 2, 14);
            item.Email = "Jenni@gmail.com";
            item.Family = 0;

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                MemberInfoDAC dac = new MemberInfoDAC(sqlCon);
                dac.Insert(item);

                item.Name = "Jenny";
                dac.Update(item);

                MemberInfo[] list = dac.SelectAll();
                foreach(MemberInfo member in list)
                {
                    Console.WriteLine(member.Email);
                }
                dac.Delete(item);
            }
        }
    }
}
