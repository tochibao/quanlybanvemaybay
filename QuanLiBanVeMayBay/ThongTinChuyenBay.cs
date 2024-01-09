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
    public partial class ThongTinChuyenBay : Form
    {
        public ThongTinChuyenBay()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void ThongTinChuyenBay_Load(object sender, EventArgs e)
        {
            dt.Connect();
            DataSet data = new DataSet();
            string query = "Select MACHUYENBAY 'Mã chuyến bay', SANBAYDI 'Sân bay đi', SANBAYDEN 'Sân bay đến', NGAYGIO 'Ngày giờ', THOIGIANBAY 'Thời gian bay', SOLUONGGHEHANG1 'Số lượng ghế hạng 1', SOLUONGGHEHANG2 'Số lượng ghế hạng 2'"
                        + " from CCHUYENBAY";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewTTChuyenBay.DataSource = data.Tables[0];
            dataGridViewTTChuyenBay.Columns["Mã chuyến bay"].Width = 110;
            dataGridViewTTChuyenBay.Columns["Sân bay đến"].Width = 110;
            dataGridViewTTChuyenBay.Columns["Sân bay đi"].Width = 110;
            dataGridViewTTChuyenBay.Columns["Số lượng ghế hạng 1"].Width = 130;
            dataGridViewTTChuyenBay.Columns["Số lượng ghế hạng 2"].Width = 130;
        }

        private void ThongTinChuyenBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }
    }
}
