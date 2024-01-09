using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLiBanVeMayBay
{
    internal class ConnectData
    {
        public SqlConnection conn; //biến kết nối
        public void Connect() //Phương thức kết nối
        {
            string strCon = @"Data Source=LAPTOP-CBP892N3;Initial Catalog=QLMB;Integrated Security=True";
            try
            {
                conn = new SqlConnection(strCon);
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi kết nối","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public void Disconnect() // phương thức ngắt kết nối
        {
            conn.Close();
            conn.Dispose();
            conn = null;
        }

        public Boolean exeSQL(string cmd)   // truyền vào câu lệnh sql và thực thi câu lệnh
        {
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery(); 
                return true;    //thực hiện đc trả về true
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable ExecuteData(string Query)
        {
            try
            {
                //Connect();
                SqlDataAdapter adapter = new SqlDataAdapter(Query, conn);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);
                //Disconnect();
                return dataset.Tables[0];
            }
            catch 
            { 
                return null; 
            }
        }
    }
}
