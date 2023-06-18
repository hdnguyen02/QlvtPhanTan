
namespace QlvtPhanTan
{
    partial class FormReportBCNV
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
            System.Windows.Forms.Label label1;
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelCmbChiNhanh = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.DS = new QlvtPhanTan.DS();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.hoTenNVTableAdapter = new QlvtPhanTan.DSTableAdapters.HoTenNVTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.hOTENComboBox = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            hOTENLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.cmbChiNhanh);
            this.panelControl.Controls.Add(this.labelCmbChiNhanh);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1055, 50);
            this.panelControl.TabIndex = 12;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(607, 38);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(143, 50);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(110, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(173, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelCmbChiNhanh
            // 
            this.labelCmbChiNhanh.AutoSize = true;
            this.labelCmbChiNhanh.Location = new System.Drawing.Point(34, 18);
            this.labelCmbChiNhanh.Name = "labelCmbChiNhanh";
            this.labelCmbChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.labelCmbChiNhanh.TabIndex = 0;
            this.labelCmbChiNhanh.Text = "Chi nhánh";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(label1);
            this.panelControl1.Controls.Add(this.comboBox1);
            this.panelControl1.Controls.Add(hOTENLabel);
            this.panelControl1.Controls.Add(this.hOTENComboBox);
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1055, 125);
            this.panelControl1.TabIndex = 13;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "HoTenNV";
            this.bdsNV.DataSource = this.DS;
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
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(38, 55);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(70, 17);
            hOTENLabel.TabIndex = 2;
            hOTENLabel.Text = "Họ tên NV";
            // 
            // hOTENComboBox
            // 
            this.hOTENComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNV, "HOTEN", true));
            this.hOTENComboBox.DataSource = this.bdsNV;
            this.hOTENComboBox.DisplayMember = "HOTEN";
            this.hOTENComboBox.FormattingEnabled = true;
            this.hOTENComboBox.Location = new System.Drawing.Point(110, 52);
            this.hOTENComboBox.Name = "hOTENComboBox";
            this.hOTENComboBox.Size = new System.Drawing.Size(173, 24);
            this.hOTENComboBox.TabIndex = 3;
            this.hOTENComboBox.ValueMember = "MANV";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.comboBox1.Location = new System.Drawing.Point(424, 52);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(351, 55);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(69, 17);
            label1.TabIndex = 5;
            label1.Text = "Loại phiếu";
            // 
            // FormReportBCNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 519);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl);
            this.Name = "FormReportBCNV";
            this.Text = "FormReportBCNV";
            this.Load += new System.EventHandler(this.FormReportBCNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
        private System.Windows.Forms.Button btnPreview;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox hOTENComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}