using DiemDanhSinhVien.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DiemDanhSinhVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string user;

        public string User
        {
            get { return user; }
            set { user = value; }
        }
        public frmMain(string ten)
        {
            InitializeComponent();
            user = ten;
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < rbc_menu.Items.Count;i++ )
            {
                rbc_menu.Items[i].Enabled = false;
            }
            rbc_menu.Items["btnLogin"].Enabled = true;
            stt_user.Caption = User;
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Hide();
            frmLogin frmlog = new frmLogin();
            frmlog.ShowDialog();
            this.Show();
        }
    }
}
