using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using Db._PIS_DEVDataSetTableAdapters;

namespace Db
{
    public partial class Form1 : Form
    {
        private DataTable dt = null;
        public string Name;
        public Form1()
        {
            InitializeComponent();
            
            try
            {
                lock (DBHelper.DBConn)
                {
                    if (!DBHelper.IsDBConnected)
                    {
                        MessageBox.Show("DB연결 확인");
                        return;
                    }
                    else
                    {
                        String query = "SELECT * FROM MemberInfo";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, DBHelper.DBConn);
                        dt = new DataTable();
                        try
                        {
                            adapter.Fill(dt);
                            dataGridView1.DataSource = dt;
                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                        catch (Exception e)
                        {
                            MessageBox.Show(e.Message, "DataGrid Load Error");
                        }
                        DBHelper.Close();
                    }
                }
            }
            catch(ArgumentNullException ane)
            {
                MessageBox.Show(ane.Message, "응 실패");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            _PIS_DEVDataSet ds = new _PIS_DEVDataSet();
            MemberInfoTableAdapter mt = new MemberInfoTableAdapter();
            DateTime datetime = DateTime.ParseExact(textBox2.Text, "yyyy-mm-dd", null);
            mt.Insert(textBox1.Text, datetime, textBox3.Text, Convert.ToByte(textBox4.Text));
            mt.Fill(ds.MemberInfo);
            selectDB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0) return;
            DataGridViewRow dgvr = dataGridView1.CurrentRow;
            DataRow row = (dgvr.DataBoundItem as DataRowView).Row;
            
            
            MemberInfoTableAdapter mt = new MemberInfoTableAdapter();
            mt.Delete((row["Name"]).ToString(), DateTime.Parse(((row["Birth"]).ToString())), (row["Email"]).ToString(), Convert.ToByte(row["Family"]));
            selectDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.RowCount == 0) return;
            DataGridViewRow dgvr = dataGridView1.CurrentRow;
            DataRow row = (dgvr.DataBoundItem as DataRowView).Row;

            _PIS_DEVDataSet ds = new _PIS_DEVDataSet();
            MemberInfoTableAdapter mt = new MemberInfoTableAdapter();
            //_PIS_DEVDataSet.MemberInfoRow[] rows = ds.MemberInfo.Select((row).ToString()) as _PIS_DEVDataSet.MemberInfoRow[];
            mt.Update(row);
            selectDB();
        }

        private void selectDB()
        {
            String query = "SELECT * FROM MemberInfo";
            SqlDataAdapter adapter = new SqlDataAdapter(query, DBHelper.DBConn);
            dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        
    }
    /*public class MemberInfoDAC
    {
        static void Main(string[] args)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["TestDB"].ConnectionString;
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();

                MemberInfoDAC dac = new MemberInfoDAC(sqlCon);

                DataRow newItem = dac.NewRow();
                newItem["Name"] = "Jenniger";
                newItem["Birth"] = new DateTime(1992, 5, 6);
                newItem["Email"] = "Jennifer@gmail.com";
                newItem["Family"] = 0;

                dac.Insert(newItem);

                newItem["Name"] = "Jenny";
                dac.Update(newItem);

                DataSet ds = dac.SelectAll();
                foreach (DataRow member in ds.Tables["MemberInfo"].Rows)
                {
                    Console.WriteLine(member["Email"]);
                }
                //dac.Delete(newItem);
            }
        }
        SqlConnection _sqlCon;
        DataTable _table;
        public MemberInfoDAC(SqlConnection sqlCon)
        {
            _sqlCon = sqlCon;

            DataColumn nameCol = new DataColumn("Name", typeof(string));
            DataColumn birthCol = new DataColumn("Birth", typeof(DateTime));
            DataColumn emailCol = new DataColumn("email", typeof(string));
            DataColumn familyCol = new DataColumn("Family", typeof(byte));

            _table = new DataTable("MemberInfo");
            _table.Columns.Add(nameCol);
            _table.Columns.Add(birthCol);
            _table.Columns.Add(emailCol);
            _table.Columns.Add(familyCol);
        }
        public DataRow NewRow()
        {
            return _table.NewRow();
        }

        void FillParameters(SqlCommand cmd, DataRow item)
        {
            SqlParameter paramName = new SqlParameter("Name", SqlDbType.NVarChar, 20);
            paramName.Value = item["Name"];

            SqlParameter paramBirth = new SqlParameter("Birth", SqlDbType.Date);
            paramBirth.Value = item["Birth"];

            SqlParameter paramEmail = new SqlParameter("Email", SqlDbType.NVarChar, 100);
            paramEmail.Value = item["Email"];

            SqlParameter paramFamily = new SqlParameter("Family", SqlDbType.TinyInt);
            paramFamily.Value = item["Family"];

            cmd.Parameters.Add(paramName);
            cmd.Parameters.Add(paramBirth);
            cmd.Parameters.Add(paramEmail);
            cmd.Parameters.Add(paramFamily);
        }
        public void Insert(DataRow item)
        {
            string txt = "INSERT INTO MemberInfo(Name, Birth, Family) VALUES (@Name, @Birth, @Email, @Family)";

            SqlCommand cmd = new SqlCommand(txt, _sqlCon);
            FillParameters(cmd, item);
            cmd.ExecuteNonQuery();
        }

        public void Update(DataRow item)
        {
            string txt = "UPDATE MemberInfo SET Name=@Name, Birth=@Birth, Family=@Family WHERE Email=@Email";
            SqlCommand cmd = new SqlCommand(txt, _sqlCon);
            FillParameters(cmd, item);
            cmd.ExecuteNonQuery();
        }

        public void Delete(DataRow item)
        {
            string txt = "DELETE FROM MemberInfo WHRER Email=@Email";

            SqlCommand cmd = new SqlCommand(txt, _sqlCon);
            FillParameters(cmd, item);
            cmd.ExecuteNonQuery();
        }

        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM MemberInfo", _sqlCon);
            sda.Fill(ds, "MemberInfo");
            return ds;
        }
    }*/
}
