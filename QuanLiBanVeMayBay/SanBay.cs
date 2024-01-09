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
    public partial class SanBay : Form
    {
        public SanBay()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void SanBay_Load(object sender, EventArgs e)
        {
            dt.Connect();

            //Trình bày dữ liệu lên dataGridView
            ShowData();
        }

        private void SanBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewSanBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaSanBay.Text = dataGridViewSanBay.Rows[numrow].Cells[0].Value.ToString();
            txtTenSanBay.Text = dataGridViewSanBay.Rows[numrow].Cells[1].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = " Select masanbay 'Mã sân bay', tensanbay 'Tên sân bay' "
                        + " from SANBAY "
                        + " where "
                        + " masanbay like '%" + txtMaSanBay.Text + "%'"
                        + " and tensanbay like N'%" + txtTenSanBay.Text + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewSanBay.DataSource = data.Tables[0];
        }

        private void ShowData()
        {
            DataSet data = new DataSet();
            string query = "Select masanbay ' Mã sân bay ', tensanbay ' Tên sân bay' "
                        + " from SANBAY ";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewSanBay.DataSource = data.Tables[0];
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = " INSERT INTO SANBAY VALUES ("
                                + "'" + txtMaSanBay.Text + "',"
                                + " N'" + txtTenSanBay.Text + "')";
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
            dt.Connect();
            string query = " UPDATE SANBAY "
                        + " SET "
                                + "tensanbay = N'" + txtTenSanBay.Text + "', " + "masanbay = N'" + txtMaSanBay.Text + "'"
            + " WHERE "
                                + "masanbay = N'" + txtMaSanBay.Text + "'";
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
            string query = " DELETE SANBAY "
                        + " WHERE "
                                + "masanbay = '" + txtMaSanBay.Text + "' and "
                                + "tensanbay = N'" + txtTenSanBay.Text + "' ";
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
