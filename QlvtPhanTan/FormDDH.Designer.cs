
namespace QlvtPhanTan
{
    partial class FormDDH
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDDH));
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDDH = new System.Windows.Forms.BindingSource(this.components);
            this.DS = new QlvtPhanTan.DS();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiDDH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatDDH = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinhDDH = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelCmbChiNhanh = new System.Windows.Forms.Label();
            this.datHangTableAdapter = new QlvtPhanTan.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuDDH = new DevExpress.XtraEditors.PanelControl();
            this.MANVTextBox = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.MAKHOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNV = new System.Windows.Forms.ComboBox();
            this.hoTenNVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhaCCTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.nGAYDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.masoDDHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            this.CTDDHTableAdapter = new QlvtPhanTan.DSTableAdapters.CTDDHTableAdapter();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemCTDDH = new System.Windows.Forms.ToolStripMenuItem();
            this.suaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVatTu = new System.Windows.Forms.ToolStripMenuItem();
            this.phụcHồiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.hoTenNVTableAdapter = new QlvtPhanTan.DSTableAdapters.HoTenNVTableAdapter();
            this.khoTableAdapter = new QlvtPhanTan.DSTableAdapters.KhoTableAdapter();
            this.vattuTableAdapter = new QlvtPhanTan.DSTableAdapters.VattuTableAdapter();
            this.phieuNhapTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuNhapTableAdapter();
            this.panelNhapLieuCTDDH = new DevExpress.XtraEditors.PanelControl();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.dONGIATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sOLUONGTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.maVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maSoDDHCT = new DevExpress.XtraEditors.TextEdit();
            this.CTDDHDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            masoDDHLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuDDH)).BeginInit();
            this.panelNhapLieuDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAKHOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenNVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTDDH)).BeginInit();
            this.panelNhapLieuCTDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maSoDDHCT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTDDHDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(12, 21);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Mã số DDH:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPN, "MAPN", true));
            nGAYLabel.Location = new System.Drawing.Point(288, 19);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(53, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "Ngày:  ";
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPN.DataSource = this.bdsDDH;
            // 
            // bdsDDH
            // 
            this.bdsDDH.DataMember = "DatHang";
            this.bdsDDH.DataSource = this.DS;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(12, 69);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(59, 17);
            nhaCCLabel.TabIndex = 4;
            nhaCCLabel.Text = "Nhà CC:";
            nhaCCLabel.Click += new System.EventHandler(this.nhaCCLabel_Click);
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(284, 177);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(57, 17);
            mAKHOLabel.TabIndex = 10;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(290, 120);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(51, 17);
            mANVLabel.TabIndex = 13;
            mANVLabel.Text = "Mã NV:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Location = new System.Drawing.Point(7, 21);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel1.TabIndex = 0;
            masoDDHLabel1.Text = "Mã số DDH:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(293, 66);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(76, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "Mã vật tư: ";
            mAVTLabel.Click += new System.EventHandler(this.mAVTLabel_Click);
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(22, 119);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(72, 17);
            sOLUONGLabel.TabIndex = 6;
            sOLUONGLabel.Text = "Số lượng: ";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(306, 121);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(60, 17);
            dONGIALabel.TabIndex = 8;
            dONGIALabel.Text = "Đơn giá:";
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
            this.btnThemDDH,
            this.btnHieuChinh,
            this.btnGhiDDH,
            this.btnXoaDDH,
            this.btnPhucHoiDDH,
            this.btnReloadDDH,
            this.btnThoatNV,
            this.btnHieuChinhDDH,
            this.btnThoatDDH,
            this.btnSuaDDH});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 13;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatDDH, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemDDH
            // 
            this.btnThemDDH.Caption = "Thêm";
            this.btnThemDDH.Id = 1;
            this.btnThemDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemDDH.ImageOptions.SvgImage")));
            this.btnThemDDH.Name = "btnThemDDH";
            this.btnThemDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemDDH_ItemClick);
            // 
            // btnXoaDDH
            // 
            this.btnXoaDDH.Caption = "Xóa";
            this.btnXoaDDH.Id = 6;
            this.btnXoaDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaDDH.ImageOptions.SvgImage")));
            this.btnXoaDDH.Name = "btnXoaDDH";
            this.btnXoaDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaDDH_ItemClick);
            // 
            // btnSuaDDH
            // 
            this.btnSuaDDH.Caption = "Sữa";
            this.btnSuaDDH.Id = 12;
            this.btnSuaDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaDDH.ImageOptions.SvgImage")));
            this.btnSuaDDH.Name = "btnSuaDDH";
            this.btnSuaDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaDDH_ItemClick);
            // 
            // btnGhiDDH
            // 
            this.btnGhiDDH.Caption = "Ghi";
            this.btnGhiDDH.Enabled = false;
            this.btnGhiDDH.Id = 3;
            this.btnGhiDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiDDH.ImageOptions.SvgImage")));
            this.btnGhiDDH.Name = "btnGhiDDH";
            this.btnGhiDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiDDH_ItemClick);
            // 
            // btnReloadDDH
            // 
            this.btnReloadDDH.Caption = "Reload";
            this.btnReloadDDH.Id = 8;
            this.btnReloadDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReloadDDH.ImageOptions.SvgImage")));
            this.btnReloadDDH.Name = "btnReloadDDH";
            this.btnReloadDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadDDH_ItemClick);
            // 
            // btnPhucHoiDDH
            // 
            this.btnPhucHoiDDH.Caption = "Phục hồi";
            this.btnPhucHoiDDH.Enabled = false;
            this.btnPhucHoiDDH.Id = 7;
            this.btnPhucHoiDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiDDH.ImageOptions.SvgImage")));
            this.btnPhucHoiDDH.Name = "btnPhucHoiDDH";
            this.btnPhucHoiDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiDDH_ItemClick);
            // 
            // btnThoatDDH
            // 
            this.btnThoatDDH.Caption = "Thoát";
            this.btnThoatDDH.Id = 11;
            this.btnThoatDDH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatDDH.ImageOptions.SvgImage")));
            this.btnThoatDDH.Name = "btnThoatDDH";
            this.btnThoatDDH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatDDH_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1260, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 679);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1260, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 628);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1260, 51);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 628);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
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
            // panelControl
            // 
            this.panelControl.Controls.Add(this.cmbChiNhanh);
            this.panelControl.Controls.Add(this.labelCmbChiNhanh);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 51);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1260, 50);
            this.panelControl.TabIndex = 9;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(110, 14);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(173, 24);
            this.cmbChiNhanh.TabIndex = 1;
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
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.bdsDDH;
            this.datHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.datHangGridControl.Location = new System.Drawing.Point(0, 101);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.MenuManager = this.barManager;
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(1260, 220);
            this.datHangGridControl.TabIndex = 10;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.datHangGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // panelNhapLieuDDH
            // 
            this.panelNhapLieuDDH.Controls.Add(mANVLabel);
            this.panelNhapLieuDDH.Controls.Add(this.MANVTextBox);
            this.panelNhapLieuDDH.Controls.Add(this.labelControl2);
            this.panelNhapLieuDDH.Controls.Add(this.cmbKho);
            this.panelNhapLieuDDH.Controls.Add(mAKHOLabel);
            this.panelNhapLieuDDH.Controls.Add(this.MAKHOTextEdit);
            this.panelNhapLieuDDH.Controls.Add(this.labelControl1);
            this.panelNhapLieuDDH.Controls.Add(this.cmbNV);
            this.panelNhapLieuDDH.Controls.Add(nhaCCLabel);
            this.panelNhapLieuDDH.Controls.Add(this.nhaCCTextEdit);
            this.panelNhapLieuDDH.Controls.Add(nGAYLabel);
            this.panelNhapLieuDDH.Controls.Add(this.nGAYDateEdit);
            this.panelNhapLieuDDH.Controls.Add(masoDDHLabel);
            this.panelNhapLieuDDH.Controls.Add(this.masoDDHTextEdit);
            this.panelNhapLieuDDH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieuDDH.Enabled = false;
            this.panelNhapLieuDDH.Location = new System.Drawing.Point(0, 321);
            this.panelNhapLieuDDH.Name = "panelNhapLieuDDH";
            this.panelNhapLieuDDH.Size = new System.Drawing.Size(491, 358);
            this.panelNhapLieuDDH.TabIndex = 15;
            this.panelNhapLieuDDH.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapLieuDDH_Paint);
            // 
            // MANVTextBox
            // 
            this.MANVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDDH, "MANV", true));
            this.MANVTextBox.Location = new System.Drawing.Point(347, 116);
            this.MANVTextBox.Name = "MANVTextBox";
            this.MANVTextBox.Size = new System.Drawing.Size(125, 23);
            this.MANVTextBox.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 177);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên kho: ";
            // 
            // cmbKho
            // 
            this.cmbKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDDH, "MAKHO", true));
            this.cmbKho.DataSource = this.bdsKho;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(99, 174);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(173, 24);
            this.cmbKho.TabIndex = 12;
            this.cmbKho.ValueMember = "MAKHO";
            this.cmbKho.SelectedIndexChanged += new System.EventHandler(this.cmbKho_SelectedIndexChanged);
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // MAKHOTextEdit
            // 
            this.MAKHOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MAKHO", true));
            this.MAKHOTextEdit.Location = new System.Drawing.Point(347, 174);
            this.MAKHOTextEdit.MenuManager = this.barManager;
            this.MAKHOTextEdit.Name = "MAKHOTextEdit";
            this.MAKHOTextEdit.Size = new System.Drawing.Size(125, 22);
            this.MAKHOTextEdit.TabIndex = 11;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 119);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Họ tên NV:";
            // 
            // cmbNV
            // 
            this.cmbNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsDDH, "MANV", true));
            this.cmbNV.DataSource = this.hoTenNVBindingSource;
            this.cmbNV.DisplayMember = "HOTEN";
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.Location = new System.Drawing.Point(99, 116);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(173, 24);
            this.cmbNV.TabIndex = 8;
            this.cmbNV.ValueMember = "MANV";
            this.cmbNV.SelectedIndexChanged += new System.EventHandler(this.cmbNV_SelectedIndexChanged);
            // 
            // hoTenNVBindingSource
            // 
            this.hoTenNVBindingSource.DataMember = "HoTenNV";
            this.hoTenNVBindingSource.DataSource = this.DS;
            // 
            // nhaCCTextEdit
            // 
            this.nhaCCTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NhaCC", true));
            this.nhaCCTextEdit.Location = new System.Drawing.Point(99, 66);
            this.nhaCCTextEdit.MenuManager = this.barManager;
            this.nhaCCTextEdit.Name = "nhaCCTextEdit";
            this.nhaCCTextEdit.Size = new System.Drawing.Size(373, 22);
            this.nhaCCTextEdit.TabIndex = 5;
            // 
            // nGAYDateEdit
            // 
            this.nGAYDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "NGAY", true));
            this.nGAYDateEdit.EditValue = null;
            this.nGAYDateEdit.Location = new System.Drawing.Point(347, 16);
            this.nGAYDateEdit.MenuManager = this.barManager;
            this.nGAYDateEdit.Name = "nGAYDateEdit";
            this.nGAYDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.nGAYDateEdit.Size = new System.Drawing.Size(125, 22);
            this.nGAYDateEdit.TabIndex = 3;
            // 
            // masoDDHTextEdit
            // 
            this.masoDDHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDDH, "MasoDDH", true));
            this.masoDDHTextEdit.Location = new System.Drawing.Point(99, 16);
            this.masoDDHTextEdit.MenuManager = this.barManager;
            this.masoDDHTextEdit.Name = "masoDDHTextEdit";
            this.masoDDHTextEdit.Size = new System.Drawing.Size(142, 22);
            this.masoDDHTextEdit.TabIndex = 1;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_DatHang";
            this.bdsCTDDH.DataSource = this.bdsDDH;
            // 
            // CTDDHTableAdapter
            // 
            this.CTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCTDDH,
            this.suaVT,
            this.btnGhiVatTu,
            this.phụcHồiToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.btnXoaVT});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(211, 176);
            // 
            // btnThemCTDDH
            // 
            this.btnThemCTDDH.Name = "btnThemCTDDH";
            this.btnThemCTDDH.Size = new System.Drawing.Size(210, 24);
            this.btnThemCTDDH.Text = "Thêm vật tư";
            this.btnThemCTDDH.Click += new System.EventHandler(this.btnThemCTDDH_Click);
            // 
            // suaVT
            // 
            this.suaVT.Name = "suaVT";
            this.suaVT.Size = new System.Drawing.Size(210, 24);
            this.suaVT.Text = "Sữa vật tư";
            this.suaVT.Click += new System.EventHandler(this.suaVT_Click);
            // 
            // btnGhiVatTu
            // 
            this.btnGhiVatTu.Name = "btnGhiVatTu";
            this.btnGhiVatTu.Size = new System.Drawing.Size(210, 24);
            this.btnGhiVatTu.Text = "Ghi vật tư";
            this.btnGhiVatTu.Click += new System.EventHandler(this.btnGhiVatTu_Click);
            // 
            // phụcHồiToolStripMenuItem
            // 
            this.phụcHồiToolStripMenuItem.Name = "phụcHồiToolStripMenuItem";
            this.phụcHồiToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.phụcHồiToolStripMenuItem.Text = "Phục hồi";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.reloadToolStripMenuItem.Text = "Reload";
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.Size = new System.Drawing.Size(210, 24);
            this.btnXoaVT.Text = "Xóa vật tư";
            this.btnXoaVT.Click += new System.EventHandler(this.btnXoaVT_Click);
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // panelNhapLieuCTDDH
            // 
            this.panelNhapLieuCTDDH.Controls.Add(this.cmbVT);
            this.panelNhapLieuCTDDH.Controls.Add(dONGIALabel);
            this.panelNhapLieuCTDDH.Controls.Add(this.dONGIATextEdit);
            this.panelNhapLieuCTDDH.Controls.Add(sOLUONGLabel);
            this.panelNhapLieuCTDDH.Controls.Add(this.sOLUONGTextEdit);
            this.panelNhapLieuCTDDH.Controls.Add(this.labelControl3);
            this.panelNhapLieuCTDDH.Controls.Add(mAVTLabel);
            this.panelNhapLieuCTDDH.Controls.Add(this.maVTTextEdit);
            this.panelNhapLieuCTDDH.Controls.Add(masoDDHLabel1);
            this.panelNhapLieuCTDDH.Controls.Add(this.maSoDDHCT);
            this.panelNhapLieuCTDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieuCTDDH.Enabled = false;
            this.panelNhapLieuCTDDH.Location = new System.Drawing.Point(491, 321);
            this.panelNhapLieuCTDDH.Name = "panelNhapLieuCTDDH";
            this.panelNhapLieuCTDDH.Size = new System.Drawing.Size(0, 358);
            this.panelNhapLieuCTDDH.TabIndex = 24;
            this.panelNhapLieuCTDDH.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapLieuCTDDH_Paint);
            // 
            // cmbVT
            // 
            this.cmbVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsCTDDH, "MAVT", true));
            this.cmbVT.DataSource = this.bdsVatTu;
            this.cmbVT.DisplayMember = "TENVT";
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(95, 62);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(173, 24);
            this.cmbVT.TabIndex = 10;
            this.cmbVT.ValueMember = "MAVT";
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // dONGIATextEdit
            // 
            this.dONGIATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "DONGIA", true));
            this.dONGIATextEdit.Location = new System.Drawing.Point(376, 118);
            this.dONGIATextEdit.MenuManager = this.barManager;
            this.dONGIATextEdit.Name = "dONGIATextEdit";
            this.dONGIATextEdit.Size = new System.Drawing.Size(151, 22);
            this.dONGIATextEdit.TabIndex = 9;
            // 
            // sOLUONGTextEdit
            // 
            this.sOLUONGTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "SOLUONG", true));
            this.sOLUONGTextEdit.Location = new System.Drawing.Point(95, 118);
            this.sOLUONGTextEdit.MenuManager = this.barManager;
            this.sOLUONGTextEdit.Name = "sOLUONGTextEdit";
            this.sOLUONGTextEdit.Size = new System.Drawing.Size(173, 22);
            this.sOLUONGTextEdit.TabIndex = 7;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 65);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 17);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tên vật tư:";
            // 
            // maVTTextEdit
            // 
            this.maVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MAVT", true));
            this.maVTTextEdit.Location = new System.Drawing.Point(376, 64);
            this.maVTTextEdit.MenuManager = this.barManager;
            this.maVTTextEdit.Name = "maVTTextEdit";
            this.maVTTextEdit.Size = new System.Drawing.Size(151, 22);
            this.maVTTextEdit.TabIndex = 3;
            // 
            // maSoDDHCT
            // 
            this.maSoDDHCT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTDDH, "MasoDDH", true));
            this.maSoDDHCT.Enabled = false;
            this.maSoDDHCT.Location = new System.Drawing.Point(95, 18);
            this.maSoDDHCT.MenuManager = this.barManager;
            this.maSoDDHCT.Name = "maSoDDHCT";
            this.maSoDDHCT.Size = new System.Drawing.Size(173, 22);
            this.maSoDDHCT.TabIndex = 1;
            // 
            // CTDDHDataGridView
            // 
            this.CTDDHDataGridView.AllowUserToAddRows = false;
            this.CTDDHDataGridView.AutoGenerateColumns = false;
            this.CTDDHDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTDDHDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTDDHDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.CTDDHDataGridView.ContextMenuStrip = this.contextMenuStrip;
            this.CTDDHDataGridView.DataSource = this.bdsCTDDH;
            this.CTDDHDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CTDDHDataGridView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.CTDDHDataGridView.Location = new System.Drawing.Point(390, 321);
            this.CTDDHDataGridView.Name = "CTDDHDataGridView";
            this.CTDDHDataGridView.RowHeadersWidth = 51;
            this.CTDDHDataGridView.RowTemplate.Height = 24;
            this.CTDDHDataGridView.Size = new System.Drawing.Size(870, 358);
            this.CTDDHDataGridView.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MasoDDH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MasoDDH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAVT";
            this.dataGridViewTextBoxColumn2.DataSource = this.bdsVatTu;
            this.dataGridViewTextBoxColumn2.DisplayMember = "TENVT";
            this.dataGridViewTextBoxColumn2.HeaderText = "MAVT";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "MAVT";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "SOLUONG";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "DONGIA";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // FormDDH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 699);
            this.Controls.Add(this.panelNhapLieuCTDDH);
            this.Controls.Add(this.CTDDHDataGridView);
            this.Controls.Add(this.panelNhapLieuDDH);
            this.Controls.Add(this.datHangGridControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormDDH";
            this.Text = "FormDDH";
            this.Load += new System.EventHandler(this.FormDDH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuDDH)).EndInit();
            this.panelNhapLieuDDH.ResumeLayout(false);
            this.panelNhapLieuDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MAKHOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTenNVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCCTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nGAYDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masoDDHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTDDH)).EndInit();
            this.panelNhapLieuCTDDH.ResumeLayout(false);
            this.panelNhapLieuCTDDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maSoDDHCT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTDDHDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemDDH;
        private DevExpress.XtraBars.BarButtonItem btnXoaDDH;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhDDH;
        private DevExpress.XtraBars.BarButtonItem btnGhiDDH;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiDDH;
        private DevExpress.XtraBars.BarButtonItem btnReloadDDH;
        private DevExpress.XtraBars.BarButtonItem btnThoatDDH;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnThoatNV;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsDDH;
        private DS DS;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuDDH;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DSTableAdapters.CTDDHTableAdapter CTDDHTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnSuaDDH;
        private DevExpress.XtraEditors.TextEdit nhaCCTextEdit;
        private DevExpress.XtraEditors.DateEdit nGAYDateEdit;
        private DevExpress.XtraEditors.TextEdit masoDDHTextEdit;
        private System.Windows.Forms.BindingSource hoTenNVBindingSource;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbNV;
        private DevExpress.XtraEditors.TextEdit MAKHOTextEdit;
        private System.Windows.Forms.BindingSource bdsKho;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbKho;
        private System.Windows.Forms.TextBox MANVTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem btnThemCTDDH;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdsPN;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVatTu;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuCTDDH;
        private System.Windows.Forms.DataGridView CTDDHDataGridView;
        private DevExpress.XtraEditors.TextEdit maSoDDHCT;
        private DevExpress.XtraEditors.TextEdit dONGIATextEdit;
        private DevExpress.XtraEditors.TextEdit sOLUONGTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit maVTTextEdit;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.ToolStripMenuItem phụcHồiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suaVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
    }
}