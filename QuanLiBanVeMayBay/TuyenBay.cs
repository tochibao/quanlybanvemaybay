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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLiBanVeMayBay
{
    public partial class TuyenBay : Form
    {
        public TuyenBay()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();
        private void TuyenBay_Load(object sender, EventArgs e)
        {
            dt.Connect();
            ShowData();
        }

        private void TuyenBay_FormClosed(object sender, FormClosedEventArgs e)
        {
            dt.Disconnect();
        }

        private void dataGridViewTuyenBay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txtMaTuyenBay.Text = dataGridViewTuyenBay.Rows[numrow].Cells[0].Value.ToString();
            comboBoxTenSanBayDi.SelectedValue = dataGridViewTuyenBay.Rows[numrow].Cells[1].Value.ToString();
            comboBoxTenSanBayDen.SelectedValue = dataGridViewTuyenBay.Rows[numrow].Cells[2].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            string query = " Select matuyenbay 'Mã tuyến bay', masanbaydi 'Mã sân bay đi', masanbayden 'Mã sân bay đến' "
                           + " from TUYENBAY "
                           + " where "
                                + " matuyenbay like '%" + txtMaTuyenBay.Text + "%' "
                                + " and masanbaydi like N'%" + comboBoxTenSanBayDi.SelectedValue + "%' "
                                + " and masanbayden like N'%" + comboBoxTenSanBayDen.SelectedValue + "%'";
            SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            adp.Fill(data);
            dataGridViewTuyenBay.DataSource = data.Tables[0];
            dataGridViewTuyenBay.Columns["Mã tuyến bay"].Width = 150;
            dataGridViewTuyenBay.Columns["Mã sân bay đi"].Width = 150;
            dataGridViewTuyenBay.Columns["Mã sân bay đến"].Width = 150;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO TUYENBAY VALUES ("
                         + "'" + txtMaTuyenBay.Text + "', "
                         + "'" + comboBoxTenSanBayDi.SelectedValue + "', "
                         + "'" + comboBoxTenSanBayDen.SelectedValue + "')";
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

        private void ShowData()
        {
            //DataSet data = new DataSet();
            //string query = " Select matuyenbay 'Mã tuyến bay', masanbaydi 'Mã sân bay đi', masanbayden 'Mã sân bay đến' "
            //            + " from TUYENBAY";

            //SqlDataAdapter adp = new SqlDataAdapter(query, dt.conn);
            //adp.Fill(data);
            //dataGridViewTuyenBay.DataSource = data.Tables[0];
            comboBoxTenSanBayDi.DataSource = dt.ExecuteData("Select * from SANBAY");
            comboBoxTenSanBayDi.DisplayMember = "tensanbay";
            comboBoxTenSanBayDi.ValueMember = "masanbay";
            this.comboBoxTenSanBayDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;   //không cho người dùng nhập vào combobox chỉ được chọn
            comboBoxTenSanBayDen.DataSource = dt.ExecuteData("Select * from SANBAY");
            comboBoxTenSanBayDen.DisplayMember = "tensanbay";
            comboBoxTenSanBayDen.ValueMember = "masanbay";
            this.comboBoxTenSanBayDen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            txtMaTuyenBay.Text = "";
            //Hiển thị dữ liệu lên dataGridView
            dataGridViewTuyenBay.DataSource = dt.ExecuteData(" Select matuyenbay 'Mã tuyến bay', masanbaydi 'Mã sân bay đi', masanbayden 'Mã sân bay đến' "
                        + " from TUYENBAY");
            dataGridViewTuyenBay.Columns["Mã tuyến bay"].Width = 150;
            dataGridViewTuyenBay.Columns["Mã sân bay đi"].Width = 150;
            dataGridViewTuyenBay.Columns["Mã sân bay đến"].Width = 150;
        }

        private void comboBoxTenSanBayDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtMaTuyenBay.Text = comboBoxTenSanBayDi.SelectedValue + "-" + comboBoxTenSanBayDen.SelectedValue;
        }

        private void comboBoxTenSanBayDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtMaTuyenBay.Text = comboBoxTenSanBayDi.SelectedValue + "-" + comboBoxTenSanBayDen.SelectedValue;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string query = " UPDATE TUYENBAY "
                        + " SET "
                                + "masanbaydi = '" + comboBoxTenSanBayDi.SelectedValue + "', "
                                + "masanbayden = '" + comboBoxTenSanBayDen.SelectedValue + "' "
                        + " WHERE "
                                + "matuyenbay = '" + txtMaTuyenBay.Text + "'";
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
            string query = " DELETE FROM TUYENBAY"
                        + " WHERE "
                                + "matuyenbay = '" + txtMaTuyenBay.Text + "' and "
                                + "masanbaydi = '" + comboBoxTenSanBayDi.SelectedValue + "' and "
                                + "masanbayden = '" + comboBoxTenSanBayDen.SelectedValue + "' ";
            bool kq = dt.exeSQL(query);
            if (kq == true)
            {
                MessageBox.Show("Đã xóa dữ liệu thành công");
                ShowData();
            }
            else
            {
                MessageBox.Show("Không thể sửa dữ liệu");
            }
        }
    }
}
