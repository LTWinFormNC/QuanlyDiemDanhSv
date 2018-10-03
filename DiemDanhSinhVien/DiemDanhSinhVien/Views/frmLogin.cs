using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DiemDanhSinhVien.Controllers;

namespace DiemDanhSinhVien.Views
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        QL_NguoiDung Cauhinh = new QL_NguoiDung();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void hperlink_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy frmdky = new frmDangKy();
            frmdky.ShowDialog();
            this.Show();
        }
        public void ProcessLogin()
        {
            int result;
            result = Cauhinh.Check_User(txtUser.Text, txtPass.Text);
            if (result == 0)
            {
                MessageBox.Show("Sai" + lblUser.Text + " hoặc " + lblPass.Text);
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
                return;
            }
            else if (result == 1)
            {
                MessageBox.Show("Tài khoản bị khóa");
                return;
            }
            else
            {
                MessageBox.Show("Đăng nhập thành công!");
                this.Hide();
                frmMain frmMnger = new frmMain(txtUser.Text);
                frmMnger.ShowDialog();
                this.Show();
            }
        }
        public void ProcessConfig()
        {
            frmCauHinh frmCh = new frmCauHinh();
            frmCh.ShowDialog();
        }
        private void btnDangnhap_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblUser.Text.ToLower());
                this.txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                MessageBox.Show("Không được bỏ trống " + lblPass.Text.ToLower());
                this.txtPass.Focus();
                return;
            }
            if (Cauhinh.Check_Config() == 0)
                ProcessLogin();
            else if (Cauhinh.Check_Config() == 1)
            {
                MessageBox.Show("Chuỗi cấu hình không tồn tại"); //xử lý cấu hinh
                ProcessConfig();
            }
            else
            {
                MessageBox.Show("Chuỗi cấu hình không phù hợp"); //xử lý cấu hinh
                ProcessConfig();
            }
        }
    }
}