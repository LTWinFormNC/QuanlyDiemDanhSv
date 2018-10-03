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

<<<<<<< HEAD:DiemDanhSinhVien/DiemDanhSinhVien/Views/frmMain.cs
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
=======
       
>>>>>>> cca4e3c6310f3df2a11cdf2e4462f8aa65ddba7b:DiemDanhSinhVien/DiemDanhSinhVien/Views/Form1.cs
    }
}
