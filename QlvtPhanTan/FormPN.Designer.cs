
namespace QlvtPhanTan
{
    partial class FormPN
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label mAPNLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPN));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemPN = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoi = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinhDDH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelCmbChiNhanh = new System.Windows.Forms.Label();
            this.DS = new QlvtPhanTan.DS();
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.CTPNTableAdapter = new QlvtPhanTan.DSTableAdapters.CTPNTableAdapter();
            this.khoTableAdapter = new QlvtPhanTan.DSTableAdapters.KhoTableAdapter();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuPN = new DevExpress.XtraEditors.PanelControl();
            this.cmbMaSoDDH = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNhanVien = new System.Windows.Forms.ComboBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.maKhoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.masoDDHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.maPNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.hoTenNVTableAdapter = new QlvtPhanTan.DSTableAdapters.HoTenNVTableAdapter();
            this.CTPNDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhucHoiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.vattuTableAdapter = new QlvtPhanTan.DSTableAdapters.VattuTableAdapter();
            this.panelNhapLieuCTPN = new DevExpress.XtraEditors.PanelControl();
            this.maPN = new DevExpress.XtraEditors.TextEdit();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.donGiaTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SLTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuPN)).BeginInit();
            this.panelNhapLieuPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPNDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTPN)).BeginInit();
            this.panelNhapLieuCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maPN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maVTTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(61, 24);
            mAPNLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(48, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(304, 26);
            nGAYLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(18, 89);
            masoDDHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(77, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(339, 155);
            mANVLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(326, 255);
            mAKHOLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(261, 111);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(229, 188);
            sOLUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(2, 188);
            dONGIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(63, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(-1, 111);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 17);
            label1.TabIndex = 9;
            label1.Text = "Tên VT:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(9, 26);
            mAPNLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(48, 17);
            mAPNLabel1.TabIndex = 9;
            mAPNLabel1.Text = "MAPN:";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThem,
            this.btnGhi,
            this.btnXoa,
            this.btnPhucHoi,
            this.btnReload,
            this.btnThoatNV,
            this.btnHieuChinhDDH,
            this.btnThoat,
            this.btnThemPN,
            this.barButtonItem2,
            this.btnSua});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 16;
            this.barManager.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.FloatLocation = new System.Drawing.Point(499, 190);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemPN, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemPN
            // 
            this.btnThemPN.Caption = "Thêm";
            this.btnThemPN.Id = 13;
            this.btnThemPN.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPN.ImageOptions.SvgImage")));
            this.btnThemPN.Name = "btnThemPN";
            this.btnThemPN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPN_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.Id = 6;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sữa";
            this.btnSua.Id = 15;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 3;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoi
            // 
            this.btnPhucHoi.Caption = "Phục hồi";
            this.btnPhucHoi.Enabled = false;
            this.btnPhucHoi.Id = 7;
            this.btnPhucHoi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoi.Name = "btnPhucHoi";
            this.btnPhucHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoi_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.Id = 8;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 11;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1277, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 776);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1277, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 725);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1277, 51);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 725);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 1;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.Caption = "Thoát";
            this.btnThoatNV.Id = 9;
            this.btnThoatNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatNV.ImageOptions.SvgImage")));
            this.btnThoatNV.Name = "btnThoatNV";
            // 
            // btnHieuChinhDDH
            // 
            this.btnHieuChinhDDH.Caption = "Hiệu Chỉnh";
            this.btnHieuChinhDDH.Id = 10;
            this.btnHieuChinhDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinhDDH.ImageOptions.SvgImage")));
            this.btnHieuChinhDDH.Name = "btnHieuChinhDDH";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 14;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.cmbChiNhanh);
            this.panelControl.Controls.Add(this.labelCmbChiNhanh);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 51);
            this.panelControl.Margin = new System.Windows.Forms.Padding(4);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1277, 62);
            this.panelControl.TabIndex = 10;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(138, 18);
            this.cmbChiNhanh.Margin = new System.Windows.Forms.Padding(4);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(215, 24);
            this.cmbChiNhanh.TabIndex = 1;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // labelCmbChiNhanh
            // 
            this.labelCmbChiNhanh.AutoSize = true;
            this.labelCmbChiNhanh.Location = new System.Drawing.Point(42, 22);
            this.labelCmbChiNhanh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCmbChiNhanh.Name = "labelCmbChiNhanh";
            this.labelCmbChiNhanh.Size = new System.Drawing.Size(70, 17);
            this.labelCmbChiNhanh.TabIndex = 0;
            this.labelCmbChiNhanh.Text = "Chi nhánh";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "PhieuNhap";
            this.bdsPN.DataSource = this.DS;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = this.CTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // CTPNTableAdapter
            // 
            this.CTPNTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.bdsPN;
            this.phieuNhapGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.phieuNhapGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.phieuNhapGridControl.Location = new System.Drawing.Point(0, 113);
            this.phieuNhapGridControl.MainView = this.gridView1;
            this.phieuNhapGridControl.Margin = new System.Windows.Forms.Padding(4);
            this.phieuNhapGridControl.MenuManager = this.barManager;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(1277, 275);
            this.phieuNhapGridControl.TabIndex = 11;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.phieuNhapGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPN
            // 
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 31;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 117;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 31;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 117;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 31;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 117;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 31;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 117;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 31;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 117;
            // 
            // panelNhapLieuPN
            // 
            this.panelNhapLieuPN.Controls.Add(this.cmbMaSoDDH);
            this.panelNhapLieuPN.Controls.Add(this.labelControl2);
            this.panelNhapLieuPN.Controls.Add(this.cmbKho);
            this.panelNhapLieuPN.Controls.Add(this.labelControl1);
            this.panelNhapLieuPN.Controls.Add(this.cmbNhanVien);
            this.panelNhapLieuPN.Controls.Add(mAKHOLabel);
            this.panelNhapLieuPN.Controls.Add(this.maKhoTextEdit);
            this.panelNhapLieuPN.Controls.Add(mANVLabel);
            this.panelNhapLieuPN.Controls.Add(this.maNVTextEdit);
            this.panelNhapLieuPN.Controls.Add(masoDDHLabel);
            this.panelNhapLieuPN.Controls.Add(this.masoDDHTextEdit);
            this.panelNhapLieuPN.Controls.Add(nGAYLabel);
            this.panelNhapLieuPN.Controls.Add(this.ngayDateEdit);
            this.panelNhapLieuPN.Controls.Add(mAPNLabel);
            this.panelNhapLieuPN.Controls.Add(this.maPNTextEdit);
            this.panelNhapLieuPN.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieuPN.Enabled = false;
            this.panelNhapLieuPN.Location = new System.Drawing.Point(0, 388);
            this.panelNhapLieuPN.Margin = new System.Windows.Forms.Padding(4);
            this.panelNhapLieuPN.Name = "panelNhapLieuPN";
            this.panelNhapLieuPN.Size = new System.Drawing.Size(628, 388);
            this.panelNhapLieuPN.TabIndex = 12;
            // 
            // cmbMaSoDDH
            // 
            this.cmbMaSoDDH.FormattingEnabled = true;
            this.cmbMaSoDDH.Location = new System.Drawing.Point(409, 82);
            this.cmbMaSoDDH.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaSoDDH.Name = "cmbMaSoDDH";
            this.cmbMaSoDDH.Size = new System.Drawing.Size(155, 24);
            this.cmbMaSoDDH.TabIndex = 14;
            this.cmbMaSoDDH.Visible = false;
            this.cmbMaSoDDH.SelectedIndexChanged += new System.EventHandler(this.cmbMaSoDDH_SelectedIndexChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 255);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên kho";
            // 
            // cmbKho
            // 
            this.cmbKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MAKHO", true));
            this.cmbKho.DataSource = this.bdsKho;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(122, 249);
            this.cmbKho.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(150, 24);
            this.cmbKho.TabIndex = 12;
            this.cmbKho.ValueMember = "MAKHO";
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 161);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Họ tên NV";
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPN, "MANV", true));
            this.cmbNhanVien.DataSource = this.bdsNV;
            this.cmbNhanVien.DisplayMember = "HOTEN";
            this.cmbNhanVien.FormattingEnabled = true;
            this.cmbNhanVien.Location = new System.Drawing.Point(129, 155);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(150, 24);
            this.cmbNhanVien.TabIndex = 10;
            this.cmbNhanVien.ValueMember = "MANV";
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "HoTenNV";
            this.bdsNV.DataSource = this.DS;
            // 
            // maKhoTextEdit
            // 
            this.maKhoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAKHO", true));
            this.maKhoTextEdit.Enabled = false;
            this.maKhoTextEdit.Location = new System.Drawing.Point(414, 254);
            this.maKhoTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.maKhoTextEdit.MenuManager = this.barManager;
            this.maKhoTextEdit.Name = "maKhoTextEdit";
            this.maKhoTextEdit.Size = new System.Drawing.Size(151, 22);
            this.maKhoTextEdit.TabIndex = 9;
            // 
            // maNVTextEdit
            // 
            this.maNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MANV", true));
            this.maNVTextEdit.Enabled = false;
            this.maNVTextEdit.Location = new System.Drawing.Point(409, 158);
            this.maNVTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.maNVTextEdit.MenuManager = this.barManager;
            this.maNVTextEdit.Name = "maNVTextEdit";
            this.maNVTextEdit.Size = new System.Drawing.Size(156, 22);
            this.maNVTextEdit.TabIndex = 7;
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MasoDDH", true));
            this.masoDDHTextEdit.Location = new System.Drawing.Point(129, 85);
            this.masoDDHTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.masoDDHTextEdit.MenuManager = this.barManager;
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(156, 22);
            this.masoDDHTextEdit.TabIndex = 5;
            // 
            // ngayDateEdit
            // 
            this.ngayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "NGAY", true));
            this.ngayDateEdit.EditValue = null;
            this.ngayDateEdit.Location = new System.Drawing.Point(409, 20);
            this.ngayDateEdit.Margin = new System.Windows.Forms.Padding(4);
            this.ngayDateEdit.MenuManager = this.barManager;
            this.ngayDateEdit.Name = "ngayDateEdit";
            this.ngayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDateEdit.Size = new System.Drawing.Size(156, 22);
            this.ngayDateEdit.TabIndex = 3;
            // 
            // maPNTextEdit
            // 
            this.maPNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPN, "MAPN", true));
            this.maPNTextEdit.Location = new System.Drawing.Point(129, 20);
            this.maPNTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.maPNTextEdit.MenuManager = this.barManager;
            this.maPNTextEdit.Name = "maPNTextEdit";
            this.maPNTextEdit.Size = new System.Drawing.Size(156, 22);
            this.maPNTextEdit.TabIndex = 1;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsCTPN.DataSource = this.bdsPN;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // CTPNDataGridView
            // 
            this.CTPNDataGridView.AllowUserToAddRows = false;
            this.CTPNDataGridView.AutoGenerateColumns = false;
            this.CTPNDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTPNDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTPNDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.CTPNDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.CTPNDataGridView.DataSource = this.bdsCTPN;
            this.CTPNDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CTPNDataGridView.Location = new System.Drawing.Point(630, 388);
            this.CTPNDataGridView.Name = "CTPNDataGridView";
            this.CTPNDataGridView.RowHeadersWidth = 51;
            this.CTPNDataGridView.RowTemplate.Height = 24;
            this.CTPNDataGridView.Size = new System.Drawing.Size(647, 388);
            this.CTPNDataGridView.TabIndex = 16;
            this.CTPNDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CTPNDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPN";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPN";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.DataSource = this.bdsVatTu;
            this.dataGridViewTextBoxColumn2.DisplayMember = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "MAVT";
            this.dataGridViewTextBoxColumn2.Width = 260;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVT,
            this.btnXoaVT,
            this.btnSuaVT,
            this.btnGhiVT,
            this.btnPhucHoiVT});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(158, 124);
            // 
            // btnThemVT
            // 
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(157, 24);
            this.btnThemVT.Text = "Thêm vật tư";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(157, 24);
            this.btnXoaVT.Text = "Xóa vật tư";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // btnSuaVT
            // 
            this.btnSuaVT.Name = "btnSuaVT";
            this.btnSuaVT.Size = new System.Drawing.Size(157, 24);
            this.btnSuaVT.Text = "Sữa vật tư";
            this.btnSuaVT.Click += new System.EventHandler(this.btnSuaVT_Click);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Enabled = false;
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(157, 24);
            this.btnGhiVT.Text = "Ghi";
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
            // 
            // btnPhucHoiVT
            // 
            this.btnPhucHoiVT.Enabled = false;
            this.btnPhucHoiVT.Name = "btnPhucHoiVT";
            this.btnPhucHoiVT.Size = new System.Drawing.Size(157, 24);
            this.btnPhucHoiVT.Text = "Phục hồi";
            this.btnPhucHoiVT.Click += new System.EventHandler(this.btnPhucHoiVT_Click);
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // panelNhapLieuCTPN
            // 
            this.panelNhapLieuCTPN.Controls.Add(mAPNLabel1);
            this.panelNhapLieuCTPN.Controls.Add(this.maPN);
            this.panelNhapLieuCTPN.Controls.Add(label1);
            this.panelNhapLieuCTPN.Controls.Add(this.cmbVT);
            this.panelNhapLieuCTPN.Controls.Add(dONGIALabel);
            this.panelNhapLieuCTPN.Controls.Add(this.donGiaTextEdit);
            this.panelNhapLieuCTPN.Controls.Add(sOLUONGLabel);
            this.panelNhapLieuCTPN.Controls.Add(this.SLTextEdit);
            this.panelNhapLieuCTPN.Controls.Add(mAVTLabel);
            this.panelNhapLieuCTPN.Controls.Add(this.maVTTextEdit);
            this.panelNhapLieuCTPN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieuCTPN.Enabled = false;
            this.panelNhapLieuCTPN.Location = new System.Drawing.Point(628, 388);
            this.panelNhapLieuCTPN.Margin = new System.Windows.Forms.Padding(4);
            this.panelNhapLieuCTPN.Name = "panelNhapLieuCTPN";
            this.panelNhapLieuCTPN.Size = new System.Drawing.Size(2, 388);
            this.panelNhapLieuCTPN.TabIndex = 17;
            // 
            // maPN
            // 
            this.maPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAPN", true));
            this.maPN.Enabled = false;
            this.maPN.Location = new System.Drawing.Point(76, 22);
            this.maPN.Margin = new System.Windows.Forms.Padding(4);
            this.maPN.MenuManager = this.barManager;
            this.maPN.Name = "maPN";
            this.maPN.Size = new System.Drawing.Size(156, 22);
            this.maPN.TabIndex = 10;
            // 
            // cmbVT
            // 
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(76, 102);
            this.cmbVT.Margin = new System.Windows.Forms.Padding(4);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(150, 24);
            this.cmbVT.TabIndex = 8;
            this.cmbVT.Visible = false;
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // donGiaTextEdit
            // 
            this.donGiaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "DONGIA", true));
            this.donGiaTextEdit.Location = new System.Drawing.Point(89, 184);
            this.donGiaTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.donGiaTextEdit.MenuManager = this.barManager;
            this.donGiaTextEdit.Name = "donGiaTextEdit";
            this.donGiaTextEdit.Size = new System.Drawing.Size(130, 22);
            this.donGiaTextEdit.TabIndex = 7;
            // 
            // SLTextEdit
            // 
            this.SLTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "SOLUONG", true));
            this.SLTextEdit.Location = new System.Drawing.Point(330, 184);
            this.SLTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.SLTextEdit.MenuManager = this.barManager;
            this.SLTextEdit.Name = "SLTextEdit";
            this.SLTextEdit.Size = new System.Drawing.Size(156, 22);
            this.SLTextEdit.TabIndex = 5;
            // 
            // maVTTextEdit
            // 
            this.maVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPN, "MAVT", true));
            this.maVTTextEdit.Enabled = false;
            this.maVTTextEdit.Location = new System.Drawing.Point(344, 108);
            this.maVTTextEdit.Margin = new System.Windows.Forms.Padding(4);
            this.maVTTextEdit.MenuManager = this.barManager;
            this.maVTTextEdit.Name = "maVTTextEdit";
            this.maVTTextEdit.Size = new System.Drawing.Size(142, 22);
            this.maVTTextEdit.TabIndex = 3;
            // 
            // FormPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 796);
            this.Controls.Add(this.panelNhapLieuCTPN);
            this.Controls.Add(this.CTPNDataGridView);
            this.Controls.Add(this.panelNhapLieuPN);
            this.Controls.Add(this.phieuNhapGridControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPN";
            this.Text = "FormPN";
            this.Load += new System.EventHandler(this.FormPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuPN)).EndInit();
            this.panelNhapLieuPN.ResumeLayout(false);
            this.panelNhapLieuPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPNDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTPN)).EndInit();
            this.panelNhapLieuCTPN.ResumeLayout(false);
            this.panelNhapLieuCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maPN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SLTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maVTTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
  
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
   
        private DevExpress.XtraBars.BarButtonItem btnThoatNV;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhDDH;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsPN;
        private DS DS;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuPN;
        private DevExpress.XtraEditors.TextEdit maKhoTextEdit;
        private DevExpress.XtraEditors.TextEdit maNVTextEdit;
        private DevExpress.XtraEditors.TextEdit masoDDHTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayDateEdit;
        private DevExpress.XtraEditors.TextEdit maPNTextEdit;
        private DSTableAdapters.CTPNTableAdapter CTPNTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbKho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbNhanVien;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private System.Windows.Forms.ComboBox cmbMaSoDDH;
        private System.Windows.Forms.DataGridView CTPNDataGridView;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuCTPN;
        private DevExpress.XtraBars.BarButtonItem btnThemPN;
        private DevExpress.XtraEditors.TextEdit donGiaTextEdit;
        private DevExpress.XtraEditors.TextEdit SLTextEdit;
        private DevExpress.XtraEditors.TextEdit maVTTextEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private System.Windows.Forms.ToolStripMenuItem btnSuaVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private System.Windows.Forms.ToolStripMenuItem btnPhucHoiVT;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ComboBox cmbVT;
        private DevExpress.XtraEditors.TextEdit maPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}