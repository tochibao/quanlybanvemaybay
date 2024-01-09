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
    public partial class DoiMatKhau : Form
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        ConnectData dt = new ConnectData();

        private void ntnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThayDoi_Click(object sender, EventArgs e)
        {
            if (!Authentication.isauthorized(txtTaiKhoan.Text, txtMatKhauCu.Text))
            {
                MessageBox.Show("Mật khẩu cũ không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text == string.Empty)
            {
                MessageBox.Show("Mật khẩu mới không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtKTMatKhauMoi.Text == string.Empty)
            {
                MessageBox.Show("Cần nhập lại mật khẩu mới", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMatKhauMoi.Text != txtKTMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới nhập lại k khớp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Authentication.updatePassWord(txtTaiKhoan.Text, txtMatKhauMoi.Text))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
           UserSession user =  UserSession.GetUserSession("");
            txtTaiKhoan.Text = user.getUserName();
        }
    }
}
