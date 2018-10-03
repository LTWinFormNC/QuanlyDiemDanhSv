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
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        QL_NguoiDung Cauhinh = new QL_NguoiDung();
        public frmCauHinh()
        {
            InitializeComponent();
        }

        private void cbo_svname_DropDown(object sender, EventArgs e)
        {
            DataTable dt = Cauhinh.GetServerName();
            cbo_svname.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                string str = row[0] + "\\" + row[1].ToString();
                cbo_svname.Items.Add(str);
            }
        }

        private void cboDatabase_DropDown(object sender, EventArgs e)
        {
            cboDatabase.Items.Clear();
            List<string> list = Cauhinh.GetDatabaseName(cbo_svname.Text, txtUsername.Text, txtPassWord.Text);
            if (list == null)
            {
                MessageBox.Show("Thông tin cấu hình chưa chính xác");
                return;
            }
            foreach (string item in list)
            {
                cboDatabase.Items.Add(item);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Cauhinh.ChangeConnectionString(cbo_svname.Text, cboDatabase.Text, txtUsername.Text, txtPassWord.Text);
            this.Close();
        }
    }
}