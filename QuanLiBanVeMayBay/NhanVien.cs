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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();

        private void NhanVien_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
        }

        private void NhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtTenNhanVien.Text = dataGridViewNhanVien.Rows[numrow].Cells[1].Value.ToString();
            txtMaNhanVien.Text = dataGridViewNhanVien.Rows[numrow].Cells[0].Value.ToString();
            txtSoDienThoai.Text = dataGridViewNhanVien.Rows[numrow].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridViewNhanVien.Rows[numrow].Cells[3].Value.ToString();
        }

        private void ShowData()
        {
            //DataSet data = new DataSet();
            //String query = "Select manv 'Mã nhân viên', tennv 'Tên nhân viên', dienthoai 'Số điện thoại', diachi 'Địa chỉ'"
            //               + " from NHANVIEN ";
            //SqlDataAdapter adapter = new SqlDataAdapter(query, dt.conn);
            //adapter.Fill(data);
            //dataGridViewNhanVien.DataSource = data.Tables[0];
            dataGridViewNhanVien.DataSource = dt.ExecuteData("Select manv 'Mã nhân viên', tennv 'Tên nhân viên', dienthoai 'Số điện thoại', diachi 'Địa chỉ'" + " from NHANVIEN ");
            dataGridViewNhanVien.Columns["Tên nhân viên"].Width = 150;  //đặt lại độ rộng cột
            dataGridViewNhanVien.Columns["Địa chỉ"].Width = 300;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string matkhau = HashMD5.getPassWordEncrypted("1234");
            string query = " INSERT INTO NHANVIEN (manv, tennv, dienthoai, diachi, matkhau) VALUES ("
                        + "'" + txtMaNhanVien.Text + "', "
                        + "N'" + txtTenNhanVien.Text + "', "
                        + "'" + txtSoDienThoai.Text + "', "
                        + "N'" + txtDiaChi.Text + "', "
                        + "'" + matkhau +"')";
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

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            String query = "Select manv 'Mã nhân viên', tennv 'Tên nhân viên', dienthoai 'Số điện thoại', diachi 'Địa chỉ'"
                           + " from NHANVIEN "
                           + " where "
                           + " manv like '%" + txtMaNhanVien.Text + "%'"
                           + " and tennv like N'%" + txtTenNhanVien.Text + "%'"
                           + " and dienthoai like '%" + txtSoDienThoai.Text + "%'"
                           + " and diachi like N'%" + txtDiaChi.Text + "%'";
            SqlDataAdapter adapter = new SqlDataAdapter(query, dt.conn);
            adapter.Fill(data);
            dataGridViewNhanVien.DataSource = data.Tables[0];
            dataGridViewNhanVien.Columns["Tên nhân viên"].Width = 150;  //đặt lại độ rộng cột
            dataGridViewNhanVien.Columns["Địa chỉ"].Width = 300;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = " UPDATE NHANVIEN "
                        + " SET "
                                + "tennv = N'" + txtTenNhanVien.Text + "', "
                                + "dienthoai = '" + txtSoDienThoai.Text + "', "
                                + "diachi = N'" + txtDiaChi.Text + "' "
                        + " WHERE "
                                + "manv = '" + txtMaNhanVien.Text + "'";
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
            string query = " DELETE NHANVIEN "
                        + " WHERE "
                                + "manv = '" + txtMaNhanVien.Text + "' and "
                                + "tennv = N'" + txtTenNhanVien.Text + "' and "
                                + "dienthoai = '" + txtSoDienThoai.Text + "' and "
                                + "diachi = N'" + txtDiaChi.Text + "' ";
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
