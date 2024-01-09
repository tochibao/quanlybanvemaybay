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
    public partial class HangVe : Form
    {
        public HangVe()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult retThoat = MessageBox.Show("Bạn thực sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        ConnectData dt = new ConnectData();
        private void btnThem_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = "INSERT INTO HANGVE VALUES ("
                        + "'" + txtMaHangVe.Text + "', "
                        + "N'" + txtTenHangVe.Text + "')";
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

        private void HangVe_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = " UPDATE HANGVE "
                        + " SET "
                                + "tenhangve = N'" + txtTenHangVe.Text + "' "
                        + " WHERE "
                                + "mahangve = '" + txtMaHangVe.Text + "'";
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

        private void HangVe_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
        }

        private void ShowData()
        {
            dataGridViewHangVe.DataSource = dt.ExecuteData("Select mahangve 'Mã hạng vé', tenhangve 'Tên hạng vé' from HANGVE");
            dataGridViewHangVe.Columns["Mã hạng vé"].Width = 150;
            dataGridViewHangVe.Columns["Tên hạng vé"].Width = 150;
        }

        private void dataGridViewHangVe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaHangVe.Text = dataGridViewHangVe.Rows[numrow].Cells[0].Value.ToString();
            txtTenHangVe.Text = dataGridViewHangVe.Rows[numrow].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string query = " DELETE HANGVE "
                        + " WHERE "
                                + "mahangve = '" + txtMaHangVe.Text + "' and "
                                + "tenhangve = N'" + txtTenHangVe.Text + "' ";
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
