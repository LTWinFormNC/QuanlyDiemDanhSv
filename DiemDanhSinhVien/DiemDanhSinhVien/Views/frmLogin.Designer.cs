namespace DiemDanhSinhVien.Views
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grb_DangNhap = new DevExpress.XtraEditors.GroupControl();
            this.hperlink_DangKy = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPass = new DevExpress.XtraEditors.TextEdit();
            this.lblPass = new DevExpress.XtraEditors.LabelControl();
            this.txtUser = new DevExpress.XtraEditors.TextEdit();
            this.lblUser = new DevExpress.XtraEditors.LabelControl();
            this.btnDangnhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.grb_DangNhap)).BeginInit();
            this.grb_DangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_DangNhap
            // 
            this.grb_DangNhap.Controls.Add(this.hperlink_DangKy);
            this.grb_DangNhap.Controls.Add(this.labelControl3);
            this.grb_DangNhap.Controls.Add(this.pictureBox1);
            this.grb_DangNhap.Controls.Add(this.txtPass);
            this.grb_DangNhap.Controls.Add(this.lblPass);
            this.grb_DangNhap.Controls.Add(this.txtUser);
            this.grb_DangNhap.Controls.Add(this.lblUser);
            this.grb_DangNhap.Location = new System.Drawing.Point(12, 12);
            this.grb_DangNhap.Name = "grb_DangNhap";
            this.grb_DangNhap.Size = new System.Drawing.Size(411, 155);
            this.grb_DangNhap.TabIndex = 0;
            this.grb_DangNhap.Text = "Thông tin đăng nhập";
            // 
            // hperlink_DangKy
            // 
            this.hperlink_DangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hperlink_DangKy.Location = new System.Drawing.Point(242, 132);
            this.hperlink_DangKy.Name = "hperlink_DangKy";
            this.hperlink_DangKy.Size = new System.Drawing.Size(40, 13);
            this.hperlink_DangKy.TabIndex = 6;
            this.hperlink_DangKy.Text = "Đăng ký";
            this.hperlink_DangKy.Click += new System.EventHandler(this.hperlink_DangKy_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(125, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(111, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Bạn chưa có tài khoản?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DiemDanhSinhVien.Properties.Resources.manager;
            this.pictureBox1.Location = new System.Drawing.Point(6, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(209, 86);
            this.txtPass.Name = "txtPass";
            this.txtPass.Properties.UseSystemPasswordChar = true;
            this.txtPass.Size = new System.Drawing.Size(197, 20);
            this.txtPass.TabIndex = 3;
            // 
            // lblPass
            // 
            this.lblPass.Location = new System.Drawing.Point(125, 89);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(48, 13);
            this.lblPass.TabIndex = 2;
            this.lblPass.Text = "Mật khẩu:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(209, 44);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(197, 20);
            this.txtUser.TabIndex = 1;
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(125, 47);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(79, 13);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Tên người dùng:";
            // 
            // btnDangnhap
            // 
            this.btnDangnhap.Location = new System.Drawing.Point(221, 173);
            this.btnDangnhap.Name = "btnDangnhap";
            this.btnDangnhap.Size = new System.Drawing.Size(86, 23);
            this.btnDangnhap.TabIndex = 1;
            this.btnDangnhap.Text = "Đăng nhập";
            this.btnDangnhap.Click += new System.EventHandler(this.btnDangnhap_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(337, 171);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(86, 23);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 206);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDangnhap);
            this.Controls.Add(this.grb_DangNhap);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.grb_DangNhap)).EndInit();
            this.grb_DangNhap.ResumeLayout(false);
            this.grb_DangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUser.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grb_DangNhap;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txtPass;
        private DevExpress.XtraEditors.LabelControl lblPass;
        private DevExpress.XtraEditors.TextEdit txtUser;
        private DevExpress.XtraEditors.LabelControl lblUser;
        private DevExpress.XtraEditors.HyperlinkLabelControl hperlink_DangKy;
        private DevExpress.XtraEditors.SimpleButton btnDangnhap;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}