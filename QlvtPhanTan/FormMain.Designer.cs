
namespace QlvtPhanTan
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.xtraTabbedMdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnNhapXuatNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnNhapXuatVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPN = new DevExpress.XtraBars.BarButtonItem();
            this.ntnPX = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnBaoCaoVT = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageNhapXuat = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.toolStripStatusLabelMSNV = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRole = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnDDHChuaPN = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager
            // 
            this.xtraTabbedMdiManager.MdiParent = this;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangNhap);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTaoTaiKhoan);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Caption = "Đăng nhập";
            this.btnDangNhap.Id = 1;
            this.btnDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangNhap.ImageOptions.SvgImage")));
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangNhap_ItemClick);
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "Tạo TK";
            this.btnTaoTaiKhoan.Id = 2;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            this.btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnTaoTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTaoTaiKhoan_ItemClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 3;
            this.btnDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDangXuat.ImageOptions.SvgImage")));
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(62, 57, 62, 57);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangNhap,
            this.btnTaoTaiKhoan,
            this.btnDangXuat,
            this.btnNhapXuatNV,
            this.btnNhapXuatVatTu,
            this.btnKho,
            this.btnDDH,
            this.btnPN,
            this.ntnPX,
            this.btnBaoCaoNV,
            this.btnBaoCaoVT,
            this.btnDDHChuaPN});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ribbonControl1.MaxItemId = 14;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 687;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPageNhapXuat,
            this.ribbonPageBaoCao});
            this.ribbonControl1.Size = new System.Drawing.Size(1353, 193);
            // 
            // btnNhapXuatNV
            // 
            this.btnNhapXuatNV.Caption = "Nhân viên";
            this.btnNhapXuatNV.Id = 4;
            this.btnNhapXuatNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapXuatNV.ImageOptions.SvgImage")));
            this.btnNhapXuatNV.Name = "btnNhapXuatNV";
            this.btnNhapXuatNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapXuatNV_ItemClick);
            // 
            // btnNhapXuatVatTu
            // 
            this.btnNhapXuatVatTu.Caption = "Vật tư";
            this.btnNhapXuatVatTu.Id = 6;
            this.btnNhapXuatVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNhapXuatVatTu.ImageOptions.SvgImage")));
            this.btnNhapXuatVatTu.Name = "btnNhapXuatVatTu";
            this.btnNhapXuatVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNhapXuatVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "Kho";
            this.btnKho.Id = 7;
            this.btnKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKho.ImageOptions.SvgImage")));
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDDH
            // 
            this.btnDDH.Caption = "Đơn đặt hàng";
            this.btnDDH.Id = 8;
            this.btnDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDDH.ImageOptions.SvgImage")));
            this.btnDDH.Name = "btnDDH";
            this.btnDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDDH_ItemClick);
            // 
            // btnPN
            // 
            this.btnPN.Caption = "Phiếu nhập";
            this.btnPN.Id = 9;
            this.btnPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPN.ImageOptions.SvgImage")));
            this.btnPN.Name = "btnPN";
            this.btnPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPN_ItemClick);
            // 
            // ntnPX
            // 
            this.ntnPX.Caption = "Phiếu Xuất";
            this.ntnPX.Id = 10;
            this.ntnPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ntnPX.ImageOptions.SvgImage")));
            this.ntnPX.Name = "ntnPX";
            this.ntnPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ntnPX_ItemClick);
            // 
            // btnBaoCaoNV
            // 
            this.btnBaoCaoNV.Caption = "Nhân viên";
            this.btnBaoCaoNV.Id = 11;
            this.btnBaoCaoNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBaoCaoNV.ImageOptions.SvgImage")));
            this.btnBaoCaoNV.Name = "btnBaoCaoNV";
            this.btnBaoCaoNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoNV_ItemClick);
            // 
            // btnBaoCaoVT
            // 
            this.btnBaoCaoVT.Caption = "Vật tư";
            this.btnBaoCaoVT.Id = 12;
            this.btnBaoCaoVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBaoCaoVT.ImageOptions.SvgImage")));
            this.btnBaoCaoVT.Name = "btnBaoCaoVT";
            this.btnBaoCaoVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBaoCaoVT_ItemClick);
            // 
            // ribbonPageNhapXuat
            // 
            this.ribbonPageNhapXuat.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.ribbonPageNhapXuat.Name = "ribbonPageNhapXuat";
            this.ribbonPageNhapXuat.Text = "Nhập xuất";
            this.ribbonPageNhapXuat.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapXuatNV);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnNhapXuatVatTu, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKho, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDDH);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnPN);
            this.ribbonPageGroup3.ItemLinks.Add(this.ntnPX);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPageBaoCao
            // 
            this.ribbonPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPageBaoCao.Name = "ribbonPageBaoCao";
            this.ribbonPageBaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBaoCaoNV);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnBaoCaoVT);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnDDHChuaPN);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // toolStripStatusLabelMSNV
            // 
            this.toolStripStatusLabelMSNV.Name = "toolStripStatusLabelMSNV";
            this.toolStripStatusLabelMSNV.Size = new System.Drawing.Size(43, 20);
            this.toolStripStatusLabelMSNV.Text = "Msnv";
            // 
            // toolStripStatusLabelTen
            // 
            this.toolStripStatusLabelTen.Name = "toolStripStatusLabelTen";
            this.toolStripStatusLabelTen.Size = new System.Drawing.Size(73, 20);
            this.toolStripStatusLabelTen.Text = "Họ và tên";
            this.toolStripStatusLabelTen.Click += new System.EventHandler(this.toolStripStatusLabelTen_Click);
            // 
            // toolStripStatusLabelRole
            // 
            this.toolStripStatusLabelRole.Name = "toolStripStatusLabelRole";
            this.toolStripStatusLabelRole.Size = new System.Drawing.Size(39, 20);
            this.toolStripStatusLabelRole.Text = "Role";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMSNV,
            this.toolStripStatusLabelTen,
            this.toolStripStatusLabelRole});
            this.statusStrip.Location = new System.Drawing.Point(0, 688);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip.Size = new System.Drawing.Size(1353, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Nhân viên";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnDDHChuaPN
            // 
            this.btnDDHChuaPN.Caption = "DH chưa PN";
            this.btnDDHChuaPN.Id = 13;
            this.btnDDHChuaPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDDHChuaPN.ImageOptions.SvgImage")));
            this.btnDDHChuaPN.Name = "btnDDHChuaPN";
            this.btnDDHChuaPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDDHChuaPN_ItemClick);
            // 
            // FormMain
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 714);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản lý vật tư";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager;
        private System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMSNV;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTen;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRole;
        private DevExpress.XtraBars.BarButtonItem btnNhapXuatNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageNhapXuat;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnNhapXuatVatTu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnDDH;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnPN;
        private DevExpress.XtraBars.BarButtonItem ntnPX;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoNV;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnBaoCaoVT;
        private DevExpress.XtraBars.BarButtonItem btnDDHChuaPN;
    }
}

