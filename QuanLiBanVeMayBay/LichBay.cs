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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiBanVeMayBay
{
    public partial class LichBay : Form
    {
        public LichBay()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void LichBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void LichBay_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
        }

        private void dataGridViewLichBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaChuyenBay.Text = dataGridViewLichBay.Rows[numrow].Cells[0].Value.ToString();
            cbbSanBayDi.Text = dataGridViewLichBay.Rows[numrow].Cells[1].Value.ToString();
            cbbSanBayDen.Text = dataGridViewLichBay.Rows[numrow].Cells[2].Value.ToString();
            dateTimeNgayGio.Text = dataGridViewLichBay.Rows[numrow].Cells[3].Value.ToString();
            txtThoiGianBay.Text = dataGridViewLichBay.Rows[numrow].Cells[4].Value.ToString();
            txtSoLuongHangVe1.Text = dataGridViewLichBay.Rows[numrow].Cells[5].Value.ToString();
            txtSoLuongHangVe2.Text = dataGridViewLichBay.Rows[numrow].Cells[6].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = " Select MACHUYENBAY 'Mã chuyến bay', SANBAYDI 'Sân bay đi', SANBAYDEN 'Sân bay đến', NGAYGIO 'Ngày giờ', THOIGIANBAY 'Thời gian bay',   SOLUONGGHEHANG1 'Số lượng ghế hạng 1', SOLUONGGHEHANG2 'Số lượng ghế hạng 2' "
                           + " from CCHUYENBAY "
                           + " where "
                           + " MACHUYENBAY like '%" + txtMaChuyenBay.Text + "%'"
                           + " and SANBAYDI like N'%" + cbbSanBayDi.Text + "%'"
                           + " and SANBAYDEN like N'%" + cbbSanBayDen.Text + "%'"
                           + " and NGAYGIO = '" + dateTimeNgayGio.Text + "'";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewLichBay.DataSource = data.Tables[0];
            dataGridViewLichBay.Columns["Mã chuyến bay"].Width = 120;
            dataGridViewLichBay.Columns["Sân bay đi"].Width = 100;
            dataGridViewLichBay.Columns["Sân bay đến"].Width = 100;
            dataGridViewLichBay.Columns["Ngày giờ"].Width = 100;
            dataGridViewLichBay.Columns["Thời gian bay"].Width = 100;
            dataGridViewLichBay.Columns["Số lượng ghế hạng 1"].Width = 120;
            dataGridViewLichBay.Columns["Số lượng ghế hạng 2"].Width = 120;
        }

        public void ShowData()
        {
            //DataSet data = new DataSet();
            //string query = " Select MACHUYENBAY 'Mã chuyến bay', SANBAYDI 'Sân bay đi', SANBAYDEN 'Sân bay đến', NGAYGIO 'Ngày giờ', THOIGIANBAY 'Thời gian bay',   SOLUONGGHEHANG1 'Số lượng ghế hạng 1', SOLUONGGHEHANG2 'Số lượng ghế hạng 2' "
            //               + " from CCHUYENBAY ";
            //SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            //adp.Fill(data);
            //dataGridViewLichBay.DataSource = data.Tables[0];
            cbbSanBayDi.DataSource = dt.ExecuteData("select * from sanbay ");
            cbbSanBayDi.DisplayMember = "tensanbay";
            cbbSanBayDi.ValueMember = "masanbay";
            this.cbbSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;   //không cho người dùng nhập vào combobox chỉ được chọn

            cbbSanBayDen.DataSource = dt.ExecuteData("select * from sanbay ");
            cbbSanBayDen.DisplayMember = "tensanbay";
            cbbSanBayDen.ValueMember = "masanbay";
            this.cbbSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;   //không cho người dùng nhập vào combobox chỉ được chọn

            dataGridViewLichBay.DataSource = dt.ExecuteData(" Select MACHUYENBAY 'Mã chuyến bay', SANBAYDI 'Sân bay đi', SANBAYDEN 'Sân bay đến', NGAYGIO 'Ngày giờ', THOIGIANBAY 'Thời gian bay',   SOLUONGGHEHANG1 'Số lượng ghế hạng 1', SOLUONGGHEHANG2 'Số lượng ghế hạng 2' " + " from CCHUYENBAY ");
            dataGridViewLichBay.Columns["Mã chuyến bay"].Width = 120;
            dataGridViewLichBay.Columns["Sân bay đi"].Width = 100;
            dataGridViewLichBay.Columns["Sân bay đến"].Width = 100;
            dataGridViewLichBay.Columns["Ngày giờ"].Width = 100;
            dataGridViewLichBay.Columns["Thời gian bay"].Width = 100;
            dataGridViewLichBay.Columns["Số lượng ghế hạng 1"].Width = 120;
            dataGridViewLichBay.Columns["Số lượng ghế hạng 2"].Width = 120;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimeNgayGio.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            DataSet data = new DataSet();
            string query = "INSERT INTO CCHUYENBAY VALUES ("
                         + "'" + txtMaChuyenBay.Text + "', "
                         + "N'" + cbbSanBayDi.Text + "', "
                         + "N'" + cbbSanBayDen.Text + "', "
                         + "'" + formattedDate + "', "
                         + "'" + txtThoiGianBay.Text + "', "
                         + "'" + txtSoLuongHangVe1.Text + "', "
                         + "'" + txtSoLuongHangVe2.Text + "')";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã thêm dữ liệu");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể thêm dữ liệu");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimeNgayGio.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            string query = " UPDATE CCHUYENBAY "
                        + " SET "
                                + "SANBAYDI = N'" + cbbSanBayDi.Text + "', "
                                + "SANBAYDEN = N'" + cbbSanBayDen.Text + "', "
                                + "NGAYGIO = '" + formattedDate + "', "
                                + "THOIGIANBAY = '" + txtThoiGianBay.Text + "', "
                                + "SOLUONGGHEHANG1 = '" + txtSoLuongHangVe1.Text + "', "
                                + "SOLUONGGHEHANG2 = '" + txtSoLuongHangVe2.Text + "' "
                        + " WHERE "
                                + "MACHUYENBAY = '" + txtMaChuyenBay.Text + "'";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã sửa dữ liệu thành công");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể sửa dữ liệu");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = " DELETE CCHUYENBAY "
                        + " WHERE "
                                + "MACHUYENBAY = '" + txtMaChuyenBay.Text + "' and "
                                + "SANBAYDI = N'" + cbbSanBayDi.Text + "' and "
                                + "SANBAYDEN = N'" + cbbSanBayDen.Text + "' and "                               
                                + "THOIGIANBAY = '" + txtThoiGianBay.Text + "' and "
                                + "SOLUONGGHEHANG1 = '" + txtSoLuongHangVe1.Text + "' and "
                                + "SOLUONGGHEHANG2 = '" + txtSoLuongHangVe2.Text + "' ";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã xóa dữ liệu thành công");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể xóa dữ liệu");
            }
        }

        private void dateTimeNgayGio_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
