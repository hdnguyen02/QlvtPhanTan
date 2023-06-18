
namespace QlvtPhanTan
{
    partial class FormTaoTaiKhoan
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hOTENLabel;
            this.textEditLoginName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.DS = new QlvtPhanTan.DS();
            this.bdsHoTen = new System.Windows.Forms.BindingSource(this.components);
            this.hoTenNVTableAdapter = new QlvtPhanTan.DSTableAdapters.HoTenNVTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            this.btnTaoTK = new DevExpress.XtraEditors.SimpleButton();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEditCfpw = new DevExpress.XtraEditors.TextEdit();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCfpw.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(36, 141);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(98, 24);
            hOTENLabel.TabIndex = 11;
            hOTENLabel.Text = "Họ tên NV";
            // 
            // textEditLoginName
            // 
            this.textEditLoginName.Location = new System.Drawing.Point(168, 79);
            this.textEditLoginName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEditLoginName.Name = "textEditLoginName";
            this.textEditLoginName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditLoginName.Properties.Appearance.Options.UseFont = true;
            this.textEditLoginName.Size = new System.Drawing.Size(196, 28);
            this.textEditLoginName.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(41, 78);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(93, 22);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Login name";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(413, 144);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 22);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Password";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(517, 145);
            this.textEditPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPassword.Properties.Appearance.Options.UseFont = true;
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Size = new System.Drawing.Size(196, 28);
            this.textEditPassword.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(43, 215);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 22);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Role";
            // 
            // textEditUserName
            // 
            this.textEditUserName.Enabled = false;
            this.textEditUserName.Location = new System.Drawing.Point(517, 79);
            this.textEditUserName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEditUserName.Name = "textEditUserName";
            this.textEditUserName.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditUserName.Properties.Appearance.Options.UseFont = true;
            this.textEditUserName.Size = new System.Drawing.Size(196, 28);
            this.textEditUserName.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(410, 78);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 22);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Username";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsHoTen
            // 
            this.bdsHoTen.DataMember = "HoTenNV";
            this.bdsHoTen.DataSource = this.DS;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsHoTen, "HOTEN", true));
            this.hOTENComboBox.DataSource = this.bdsHoTen;
            this.hOTENComboBox.DisplayMember = "HOTEN";
            this.hOTENComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(167, 143);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(196, 30);
            this.hOTENComboBox.TabIndex = 12;
            this.hOTENComboBox.ValueMember = "MANV";
            this.hOTENComboBox.SelectedIndexChanged += new System.EventHandler(this.hOTENComboBox_SelectedIndexChanged);
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoTK.Appearance.Options.UseFont = true;
            this.btnTaoTK.Location = new System.Drawing.Point(167, 275);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(196, 37);
            this.btnTaoTK.TabIndex = 14;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // cmbRole
            // 
            this.cmbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(167, 212);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(196, 30);
            this.cmbRole.TabIndex = 15;
            // 
            // btnThoat
            // 
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Location = new System.Drawing.Point(517, 275);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(196, 37);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(373, 212);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(134, 22);
            this.labelControl5.TabIndex = 18;
            this.labelControl5.Text = "Cofirm password";
            // 
            // textEditCfpw
            // 
            this.textEditCfpw.Location = new System.Drawing.Point(517, 209);
            this.textEditCfpw.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textEditCfpw.Name = "textEditCfpw";
            this.textEditCfpw.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditCfpw.Properties.Appearance.Options.UseFont = true;
            this.textEditCfpw.Properties.PasswordChar = '*';
            this.textEditCfpw.Size = new System.Drawing.Size(196, 28);
            this.textEditCfpw.TabIndex = 17;
            // 
            // FormTaoTaiKhoan
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 792);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.textEditCfpw);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.hOTENComboBox);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditUserName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEditLoginName);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormTaoTaiKhoan";
            this.Text = "Tạo tài khoản";
            this.Load += new System.EventHandler(this.FormTaoTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsHoTen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCfpw.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEditLoginName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditUserName;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsHoTen;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hOTENComboBox;
        private DevExpress.XtraEditors.SimpleButton btnTaoTK;
        private System.Windows.Forms.ComboBox cmbRole;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit textEditCfpw;
    }
}