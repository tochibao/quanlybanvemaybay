using System;
using System.Collections;
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
    public partial class KhachHang : Form
    {
        public KhachHang()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void KhachHang_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
        }

        private void KhachHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaKhachHang.Text = dataGridViewKhachHang.Rows[numrow].Cells[0].Value.ToString();
            txtTenKhachHang.Text = dataGridViewKhachHang.Rows[numrow].Cells[1].Value.ToString();
            txtSoCMND.Text = dataGridViewKhachHang.Rows[numrow].Cells[2].Value.ToString();
            txtSDT.Text = dataGridViewKhachHang.Rows[numrow].Cells[3].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = " Select MAKH 'Mã khách hàng', TENKH 'Tên khách hàng', CMND 'Số chứng minh nhân dân', DIENTHOAI 'Số điện thoại' "
                            + " from KKHACHHANG"
                            + " where "
                            + " MAKH like '%" + txtMaKhachHang.Text + "%'"
                            + " and TENKH like N'%" + txtTenKhachHang.Text + "%'"
                            + " and CMND like '%" + txtSoCMND.Text + "%'"
                            + " and DIENTHOAI like '%" + txtSDT.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewKhachHang.DataSource = data.Tables[0];
            dataGridViewKhachHang.Columns["Mã khách hàng"].Width = 100;
            dataGridViewKhachHang.Columns["Tên khách hàng"].Width = 150;
            dataGridViewKhachHang.Columns["Số chứng minh nhân dân"].Width = 100;
            dataGridViewKhachHang.Columns["Số điện thoại"].Width = 100;
        }

        private void ShowData()
        {
            DataSet data = new DataSet();
            string query = " Select MAKH 'Mã khách hàng', TENKH 'Tên khách hàng', CMND 'Số chứng minh nhân dân', DIENTHOAI 'Số điện thoại' "
                            + " from KKHACHHANG";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewKhachHang.DataSource = data.Tables[0];
            dataGridViewKhachHang.Columns["Mã khách hàng"].Width = 100;
            dataGridViewKhachHang.Columns["Tên khách hàng"].Width = 150;
            dataGridViewKhachHang.Columns["Số chứng minh nhân dân"].Width = 100;
            dataGridViewKhachHang.Columns["Số điện thoại"].Width = 100;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO KKHACHHANG VALUES ("
                        + "'" + txtMaKhachHang.Text + "', "
                        + "'" + txtSoCMND.Text + "', "
                        + "N'" + txtTenKhachHang.Text + "', "
                        + "'" + txtSDT.Text + "')";
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
            string query = " UPDATE KKHACHHANG "
                        + " SET "
                                + "CMND = '" + txtSoCMND.Text + "', "
                                + "TENKH = N'" + txtTenKhachHang.Text + "', "
                                + "DIENTHOAI = '" + txtSDT.Text + "' "
                        + " WHERE "
                                + "MAKH = '" + txtMaKhachHang.Text + "'";
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

        private void Xóa_Click(object sender, EventArgs e)
        {
            string query = " DELETE KKHACHHANG "
                        + " WHERE "
                                + "MAKH = '" + txtMaKhachHang.Text + "' and "
                                + "CMND = '" + txtSoCMND.Text + "' and "
                                + "TENKH = N'" + txtTenKhachHang.Text + "' and "
                                + "DIENTHOAI = '" + txtSDT.Text + "' ";
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
    }
}
