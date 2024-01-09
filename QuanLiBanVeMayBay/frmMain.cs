using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanVeMayBay
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoátToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult retExit = MessageBox.Show("Bạn có chắc muốn thoát không?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (retExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void doanhThuToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("DoanhThu"))
            {
                DoanhThu frmDoanhThu = new DoanhThu();
                frmDoanhThu.MdiParent = this;
                frmDoanhThu.Name = "DoanhThu";
                frmDoanhThu.Show();
            }
            else
            {
                ActiveChildForm("DoanhThu");
            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("NhanVien"))
            {
                NhanVien frmNhanVien = new NhanVien();
                frmNhanVien.MdiParent = this;
                frmNhanVien.Name = "NhanVien";
                frmNhanVien.WindowState = FormWindowState.Maximized;
                frmNhanVien.Show();
            }
            else
            {
                ActiveChildForm("NhanVien");
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("DoiMatKhau"))
            {
                DoiMatKhau frm = new DoiMatKhau();
                frm.MdiParent = this;
                frm.Name = "DoiMatKhau";
                frm.Show();
            }
            else
            {
                ActiveChildForm("DoiMatKhau");
            }
        }

        private void đăngXuấtToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn thực sự muốn đăng xuất!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ret == DialogResult.Yes) 
            {
                this.Hide();
                DangNhap dn = new DangNhap();
                dn.Show();
            }
        }

        private void sânBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("SanBay"))
            {
                SanBay frmSanBay = new SanBay();
                frmSanBay.MdiParent = this;
                frmSanBay.Name = "SanBay";
                frmSanBay.Show();
            }
            else
            {
                ActiveChildForm("SanBay");
            }
        }

        private void tuyếnBayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("TuyenBay"))
            {
                TuyenBay frmTuyenBay = new TuyenBay();
                frmTuyenBay.MdiParent = this;
                frmTuyenBay.Name = "TuyenBay";
                frmTuyenBay.Show();
            }
            else
            {
                ActiveChildForm("TuyenBay");
            }
        }

        private void lịchBayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("LichBay"))
            {
                LichBay frmLichBay = new LichBay();
                frmLichBay.MdiParent = this;
                frmLichBay.Name = "LichBay";
                frmLichBay.Show();
            }
            else
            {
                ActiveChildForm("LichBay");
            }
        }

        private void hạngVéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("HangVe"))
            {
                HangVe frmHangVe = new HangVe();
                frmHangVe.MdiParent = this;
                frmHangVe.Name = "HangVe";
                frmHangVe.Show();
            }
            else
            {
                ActiveChildForm("HangVe");
            }
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("KhachHang"))
            {
                KhachHang frmKhachHang = new KhachHang();
                frmKhachHang.MdiParent = this;
                frmKhachHang.Name = "KhachHang";
                frmKhachHang.Show();
            }
            else
            {
                ActiveChildForm("KhachHang");
            }
        }

        private void đặtChỗToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("DatCho"))
            {
                DatCho frmDatCho = new DatCho();
                frmDatCho.MdiParent = this;
                frmDatCho.Name = "DatCho";
                frmDatCho.Show();
            }
            else
            {
                ActiveChildForm("DatCho");
            }
        }

        private void traCứuThôngTinChuyếnBayToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("ThongTinChuyenBay"))
            {
                ThongTinChuyenBay frmThongTinChuyenBay = new ThongTinChuyenBay();
                frmThongTinChuyenBay.MdiParent = this;
                frmThongTinChuyenBay.Name = "ThongTinChuyenBay";
                frmThongTinChuyenBay.Show();
            }
            else
            {
                ActiveChildForm("ThongTinChuyenBay");
            }
        }

        private void traCứuThôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExitsForm("ThongTinKhachHang"))
            {
                ThongTinKhachHang frmThongTinKhachHang = new ThongTinKhachHang();
                frmThongTinKhachHang.MdiParent = this;
                frmThongTinKhachHang.Name = "ThongTinKhachHang";
                frmThongTinKhachHang.Show();
            }
            else
            {
                ActiveChildForm("ThongTinKhachHang");
            }
        }

        private bool CheckExitsForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if(frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
