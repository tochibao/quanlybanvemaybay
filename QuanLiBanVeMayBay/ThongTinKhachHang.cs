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

namespace QuanLiBanVeMayBay
{
    public partial class ThongTinKhachHang : Form
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            dt.Connect();
            DataSet data = new DataSet();
            string query = " Select MAKH 'Mã khách hàng', TENKH 'Tên khách hàng', CMND 'Số chứng mình nhân dân', DIENTHOAI 'Số điện thoại'"
                        + " from KKHACHHANG";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewTTKhachHang.DataSource = data.Tables[0];
            dataGridViewTTKhachHang.Columns["Mã khách hàng"].Width = 110;
            dataGridViewTTKhachHang.Columns["Tên khách hàng"].Width = 150;
        }

        private void ThongTinKhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }
    }
}
