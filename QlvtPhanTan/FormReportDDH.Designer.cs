
namespace QlvtPhanTan
{
    partial class FormReportDDH
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
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new System.Windows.Forms.Button();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelCmbChiNhanh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnPreview);
            this.panelControl.Controls.Add(this.cmbChiNhanh);
            this.panelControl.Controls.Add(this.labelCmbChiNhanh);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Margin = new System.Windows.Forms.Padding(5);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(982, 63);
            this.panelControl.TabIndex = 12;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(477, 14);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(118, 36);
            this.btnPreview.TabIndex = 2;
            this.btnPreview.Text = "preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(172, 22);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(5);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(268, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelCmbChiNhanh
            // 
            this.labelCmbChiNhanh.AutoSize = true;
            this.labelCmbChiNhanh.Location = new System.Drawing.Point(52, 28);
            this.labelCmbChiNhanh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCmbChiNhanh.Name = "labelCmbChiNhanh";
            this.labelCmbChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.labelCmbChiNhanh.TabIndex = 0;
            this.labelCmbChiNhanh.Text = "Chi nhánh";
            // 
            // FormReportDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 590);
            this.Controls.Add(this.panelControl);
            this.Name = "FormReportDDH";
            this.Text = "FormReportDDH";
            this.Load += new System.EventHandler(this.FormReportDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
    }
}