using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanVeMayBay
{
    internal class Authentication
    {
        public static bool isauthorized(string username, string password)
        {
            ConnectData dt = new ConnectData();
            try
            {
                dt.Connect();
                string matkhau = HashMD5.getPassWordEncrypted(password);
                string sql = "Select * from NHANVIEN where manv = '" + username
                    + "' and matkhau = '" + matkhau + " ' ";
                SqlCommand com = new SqlCommand(sql, dt.conn);
                SqlDataReader reader = com.ExecuteReader();
                return reader.Read();
            }
            finally {
                dt.Disconnect();
            }
        }

        public static bool updatePassWord(string username, string newpassword)
        {
            ConnectData dt = new ConnectData();
            try
            {
                dt.Connect();
                string matkhau = HashMD5.getPassWordEncrypted(newpassword);
                string sql = "UPDATE NHANVIEN "
                            + "SET "
                            + "matkhau = '" + matkhau + "' "
                            + "WHERE "
                            + "manv = '" + username + "'";


                SqlCommand com = new SqlCommand(sql, dt.conn);
                return dt.exeSQL(sql);
            }
            finally
            {
                dt.Disconnect();
            }
        }
    }
}
