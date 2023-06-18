
namespace QlvtPhanTan
{
    partial class FormDangNhap
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControlChiNhanh = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelControlTenDangNhap = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenDangNhap = new DevExpress.XtraEditors.TextEdit();
            this.labelControlMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.textEditMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.btnDangNhap = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenDangNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Location = new System.Drawing.Point(1071, 622);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(11, 10);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // labelControlChiNhanh
            // 
            this.labelControlChiNhanh.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlChiNhanh.Appearance.Options.UseFont = true;
            this.labelControlChiNhanh.Location = new System.Drawing.Point(35, 44);
            this.labelControlChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.labelControlChiNhanh.Name = "labelControlChiNhanh";
            this.labelControlChiNhanh.Size = new System.Drawing.Size(82, 22);
            this.labelControlChiNhanh.TabIndex = 0;
            this.labelControlChiNhanh.Text = "Chi nhánh";
            // 
            // comboBoxChiNhanh
            // 
            this.comboBoxChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChiNhanh.FormattingEnabled = true;
            this.comboBoxChiNhanh.Location = new System.Drawing.Point(35, 69);
            this.comboBoxChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxChiNhanh.Name = "comboBoxChiNhanh";
            this.comboBoxChiNhanh.Size = new System.Drawing.Size(353, 30);
            this.comboBoxChiNhanh.TabIndex = 1;
            this.comboBoxChiNhanh.SelectedIndexChanged += new System.EventHandler(this.comboBoxChiNhanh_SelectedIndexChanged);
            // 
            // labelControlTenDangNhap
            // 
            this.labelControlTenDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlTenDangNhap.Appearance.Options.UseFont = true;
            this.labelControlTenDangNhap.Location = new System.Drawing.Point(33, 113);
            this.labelControlTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.labelControlTenDangNhap.Name = "labelControlTenDangNhap";
            this.labelControlTenDangNhap.Size = new System.Drawing.Size(83, 24);
            this.labelControlTenDangNhap.TabIndex = 2;
            this.labelControlTenDangNhap.Text = "Tài khoản";
            // 
            // textEditTenDangNhap
            // 
            this.textEditTenDangNhap.EditValue = "";
            this.textEditTenDangNhap.Location = new System.Drawing.Point(33, 138);
            this.textEditTenDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.textEditTenDangNhap.Name = "textEditTenDangNhap";
            this.textEditTenDangNhap.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditTenDangNhap.Properties.Appearance.Options.UseFont = true;
            this.textEditTenDangNhap.Size = new System.Drawing.Size(355, 28);
            this.textEditTenDangNhap.TabIndex = 3;
            // 
            // labelControlMatKhau
            // 
            this.labelControlMatKhau.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControlMatKhau.Appearance.Options.UseFont = true;
            this.labelControlMatKhau.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControlMatKhau.Location = new System.Drawing.Point(33, 187);
            this.labelControlMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.labelControlMatKhau.Name = "labelControlMatKhau";
            this.labelControlMatKhau.Size = new System.Drawing.Size(84, 21);
            this.labelControlMatKhau.TabIndex = 4;
            this.labelControlMatKhau.Text = "Mật khẩu";
            // 
            // textEditMatKhau
            // 
            this.textEditMatKhau.Location = new System.Drawing.Point(33, 211);
            this.textEditMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.textEditMatKhau.Name = "textEditMatKhau";
            this.textEditMatKhau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditMatKhau.Properties.Appearance.Options.UseFont = true;
            this.textEditMatKhau.Properties.PasswordChar = '*';
            this.textEditMatKhau.Size = new System.Drawing.Size(355, 28);
            this.textEditMatKhau.TabIndex = 5;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Appearance.Options.UseFont = true;
            this.btnDangNhap.Location = new System.Drawing.Point(33, 280);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(134, 36);
            this.btnDangNhap.TabIndex = 6;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(254, 280);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(134, 36);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormDangNhap
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 654);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textEditMatKhau);
            this.Controls.Add(this.comboBoxChiNhanh);
            this.Controls.Add(this.labelControlMatKhau);
            this.Controls.Add(this.labelControlChiNhanh);
            this.Controls.Add(this.textEditTenDangNhap);
            this.Controls.Add(this.labelControlTenDangNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenDangNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMatKhau.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControlChiNhanh;
        private System.Windows.Forms.ComboBox comboBoxChiNhanh;
        private DevExpress.XtraEditors.LabelControl labelControlTenDangNhap;
        private DevExpress.XtraEditors.LabelControl labelControlMatKhau;
        private DevExpress.XtraEditors.SimpleButton btnDangNhap;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        public DevExpress.XtraEditors.TextEdit textEditTenDangNhap;
        public DevExpress.XtraEditors.TextEdit textEditMatKhau;
    }
}