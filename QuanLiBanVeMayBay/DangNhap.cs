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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult retThoat = MessageBox.Show("Bạn thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retThoat == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(Authentication.isauthorized(txtTaiKhoan.Text, txtMatKhau.Text))
            {

                UserSession.GetUserSession(txtTaiKhoan.Text);

                this.Hide();
                frmMain main = new frmMain();
                main.Show();
               
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
           
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Focus();
        }
    }
}
