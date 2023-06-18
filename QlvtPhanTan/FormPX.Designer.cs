
namespace QlvtPhanTan
{
    partial class FormPX
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
            System.Windows.Forms.Label mAPXLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label hOTENKHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPXLabel1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPX));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnThemPX = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuXuatTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.CTPXTableAdapter = new QlvtPhanTan.DSTableAdapters.CTPXTableAdapter();
            this.khoTableAdapter = new QlvtPhanTan.DSTableAdapters.KhoTableAdapter();
            this.vattuTableAdapter = new QlvtPhanTan.DSTableAdapters.VattuTableAdapter();
            this.phieuXuatGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTENKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuPX = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKho = new System.Windows.Forms.ComboBox();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbNV = new System.Windows.Forms.ComboBox();
            this.bdsNV = new System.Windows.Forms.BindingSource(this.components);
            this.maKhoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maNVTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hOTENKHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ngayDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.maPX = new DevExpress.XtraEditors.TextEdit();
            this.panelNhapLieuCTPX = new DevExpress.XtraEditors.PanelControl();
            this.maVT = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.dONGIATextEdit = new DevExpress.XtraEditors.TextEdit();
            this.soLuongVT = new DevExpress.XtraEditors.TextEdit();
            this.mAPXTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoTenNVTableAdapter = new QlvtPhanTan.DSTableAdapters.HoTenNVTableAdapter();
            this.CTPXDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnThemVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnXoaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSuaVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGhiVT = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPH = new System.Windows.Forms.ToolStripMenuItem();
            mAPXLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            hOTENKHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPXLabel1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuPX)).BeginInit();
            this.panelNhapLieuPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENKHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTPX)).BeginInit();
            this.panelNhapLieuCTPX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIATextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPXTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPXDataGridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAPXLabel
            // 
            mAPXLabel.AutoSize = true;
            mAPXLabel.Location = new System.Drawing.Point(20, 37);
            mAPXLabel.Name = "mAPXLabel";
            mAPXLabel.Size = new System.Drawing.Size(47, 17);
            mAPXLabel.TabIndex = 0;
            mAPXLabel.Text = "MAPX:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(202, 37);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(47, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // hOTENKHLabel
            // 
            hOTENKHLabel.AutoSize = true;
            hOTENKHLabel.Location = new System.Drawing.Point(-7, 85);
            hOTENKHLabel.Name = "hOTENKHLabel";
            hOTENKHLabel.Size = new System.Drawing.Size(74, 17);
            hOTENKHLabel.TabIndex = 4;
            hOTENKHLabel.Text = "HOTENKH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(210, 147);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(200, 200);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(58, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPXLabel1
            // 
            mAPXLabel1.AutoSize = true;
            mAPXLabel1.Location = new System.Drawing.Point(37, 72);
            mAPXLabel1.Name = "mAPXLabel1";
            mAPXLabel1.Size = new System.Drawing.Size(47, 17);
            mAPXLabel1.TabIndex = 0;
            mAPXLabel1.Text = "MAPX:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 145);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(73, 17);
            label2.TabIndex = 10;
            label2.Text = "Tên vật tư";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(283, 147);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(47, 17);
            mAVTLabel.TabIndex = 11;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(10, 217);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(75, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(267, 222);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(63, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
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
            this.btnThemPX,
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemPX, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoat, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // btnThemPX
            // 
            this.btnThemPX.Caption = "Thêm";
            this.btnThemPX.Id = 13;
            this.btnThemPX.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPX.ImageOptions.SvgImage")));
            this.btnThemPX.Name = "btnThemPX";
            this.btnThemPX.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemPX_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1940, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 807);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1940, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 756);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1940, 51);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 756);
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
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1940, 50);
            this.panelControl.TabIndex = 11;
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "PhieuXuat";
            this.bdsPX.DataSource = this.DS;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = this.CTPXTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vattuTableAdapter;
            // 
            // CTPXTableAdapter
            // 
            this.CTPXTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatGridControl
            // 
            this.phieuXuatGridControl.DataSource = this.bdsPX;
            this.phieuXuatGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.phieuXuatGridControl.Location = new System.Drawing.Point(0, 101);
            this.phieuXuatGridControl.MainView = this.gridView1;
            this.phieuXuatGridControl.MenuManager = this.barManager;
            this.phieuXuatGridControl.Name = "phieuXuatGridControl";
            this.phieuXuatGridControl.Size = new System.Drawing.Size(1940, 220);
            this.phieuXuatGridControl.TabIndex = 12;
            this.phieuXuatGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPX,
            this.colNGAY,
            this.colHOTENKH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.phieuXuatGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMAPX
            // 
            this.colMAPX.FieldName = "MAPX";
            this.colMAPX.MinWidth = 25;
            this.colMAPX.Name = "colMAPX";
            this.colMAPX.Visible = true;
            this.colMAPX.VisibleIndex = 0;
            this.colMAPX.Width = 94;
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
            // colHOTENKH
            // 
            this.colHOTENKH.FieldName = "HOTENKH";
            this.colHOTENKH.MinWidth = 25;
            this.colHOTENKH.Name = "colHOTENKH";
            this.colHOTENKH.Visible = true;
            this.colHOTENKH.VisibleIndex = 2;
            this.colHOTENKH.Width = 94;
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
            // panelNhapLieuPX
            // 
            this.panelNhapLieuPX.Controls.Add(this.labelControl2);
            this.panelNhapLieuPX.Controls.Add(this.cmbKho);
            this.panelNhapLieuPX.Controls.Add(this.labelControl1);
            this.panelNhapLieuPX.Controls.Add(this.cmbNV);
            this.panelNhapLieuPX.Controls.Add(mAKHOLabel);
            this.panelNhapLieuPX.Controls.Add(this.maKhoTextEdit);
            this.panelNhapLieuPX.Controls.Add(mANVLabel);
            this.panelNhapLieuPX.Controls.Add(this.maNVTextEdit);
            this.panelNhapLieuPX.Controls.Add(hOTENKHLabel);
            this.panelNhapLieuPX.Controls.Add(this.hOTENKHTextEdit);
            this.panelNhapLieuPX.Controls.Add(nGAYLabel);
            this.panelNhapLieuPX.Controls.Add(this.ngayDateEdit);
            this.panelNhapLieuPX.Controls.Add(mAPXLabel);
            this.panelNhapLieuPX.Controls.Add(this.maPX);
            this.panelNhapLieuPX.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNhapLieuPX.Enabled = false;
            this.panelNhapLieuPX.Location = new System.Drawing.Point(0, 321);
            this.panelNhapLieuPX.Name = "panelNhapLieuPX";
            this.panelNhapLieuPX.Size = new System.Drawing.Size(500, 486);
            this.panelNhapLieuPX.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(23, 208);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 16);
            this.labelControl2.TabIndex = 13;
            this.labelControl2.Text = "Tên kho";
            // 
            // cmbKho
            // 
            this.cmbKho.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MAKHO", true));
            this.cmbKho.DataSource = this.bdsKho;
            this.cmbKho.DisplayMember = "TENKHO";
            this.cmbKho.FormattingEnabled = true;
            this.cmbKho.Location = new System.Drawing.Point(73, 205);
            this.cmbKho.Name = "cmbKho";
            this.cmbKho.Size = new System.Drawing.Size(121, 24);
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
            this.labelControl1.Location = new System.Drawing.Point(7, 145);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(62, 17);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Họ tên NV";
            // 
            // cmbNV
            // 
            this.cmbNV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsPX, "MANV", true));
            this.cmbNV.DataSource = this.bdsNV;
            this.cmbNV.DisplayMember = "HOTEN";
            this.cmbNV.FormattingEnabled = true;
            this.cmbNV.Location = new System.Drawing.Point(75, 142);
            this.cmbNV.Name = "cmbNV";
            this.cmbNV.Size = new System.Drawing.Size(121, 24);
            this.cmbNV.TabIndex = 10;
            this.cmbNV.ValueMember = "MANV";
            this.cmbNV.SelectedIndexChanged += new System.EventHandler(this.cmbNV_SelectedIndexChanged);
            // 
            // bdsNV
            // 
            this.bdsNV.DataMember = "HoTenNV";
            this.bdsNV.DataSource = this.DS;
            // 
            // maKhoTextEdit
            // 
            this.maKhoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAKHO", true));
            this.maKhoTextEdit.Enabled = false;
            this.maKhoTextEdit.Location = new System.Drawing.Point(264, 197);
            this.maKhoTextEdit.MenuManager = this.barManager;
            this.maKhoTextEdit.Name = "maKhoTextEdit";
            this.maKhoTextEdit.Size = new System.Drawing.Size(125, 22);
            this.maKhoTextEdit.TabIndex = 9;
            // 
            // maNVTextEdit
            // 
            this.maNVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MANV", true));
            this.maNVTextEdit.Enabled = false;
            this.maNVTextEdit.Location = new System.Drawing.Point(264, 144);
            this.maNVTextEdit.MenuManager = this.barManager;
            this.maNVTextEdit.Name = "maNVTextEdit";
            this.maNVTextEdit.Size = new System.Drawing.Size(125, 22);
            this.maNVTextEdit.TabIndex = 7;
            // 
            // hOTENKHTextEdit
            // 
            this.hOTENKHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "HOTENKH", true));
            this.hOTENKHTextEdit.Location = new System.Drawing.Point(90, 80);
            this.hOTENKHTextEdit.MenuManager = this.barManager;
            this.hOTENKHTextEdit.Name = "hOTENKHTextEdit";
            this.hOTENKHTextEdit.Size = new System.Drawing.Size(290, 22);
            this.hOTENKHTextEdit.TabIndex = 5;
            // 
            // ngayDateEdit
            // 
            this.ngayDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "NGAY", true));
            this.ngayDateEdit.EditValue = null;
            this.ngayDateEdit.Location = new System.Drawing.Point(255, 34);
            this.ngayDateEdit.MenuManager = this.barManager;
            this.ngayDateEdit.Name = "ngayDateEdit";
            this.ngayDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngayDateEdit.Size = new System.Drawing.Size(125, 22);
            this.ngayDateEdit.TabIndex = 3;
            // 
            // maPX
            // 
            this.maPX.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPX, "MAPX", true));
            this.maPX.Location = new System.Drawing.Point(73, 34);
            this.maPX.MenuManager = this.barManager;
            this.maPX.Name = "maPX";
            this.maPX.Size = new System.Drawing.Size(125, 22);
            this.maPX.TabIndex = 1;
            // 
            // panelNhapLieuCTPX
            // 
            this.panelNhapLieuCTPX.Controls.Add(mAVTLabel);
            this.panelNhapLieuCTPX.Controls.Add(this.maVT);
            this.panelNhapLieuCTPX.Controls.Add(label2);
            this.panelNhapLieuCTPX.Controls.Add(this.cmbVT);
            this.panelNhapLieuCTPX.Controls.Add(dONGIALabel);
            this.panelNhapLieuCTPX.Controls.Add(this.dONGIATextEdit);
            this.panelNhapLieuCTPX.Controls.Add(sOLUONGLabel);
            this.panelNhapLieuCTPX.Controls.Add(this.soLuongVT);
            this.panelNhapLieuCTPX.Controls.Add(mAPXLabel1);
            this.panelNhapLieuCTPX.Controls.Add(this.mAPXTextEdit);
            this.panelNhapLieuCTPX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieuCTPX.Enabled = false;
            this.panelNhapLieuCTPX.Location = new System.Drawing.Point(500, 321);
            this.panelNhapLieuCTPX.Name = "panelNhapLieuCTPX";
            this.panelNhapLieuCTPX.Size = new System.Drawing.Size(1440, 486);
            this.panelNhapLieuCTPX.TabIndex = 14;
            this.panelNhapLieuCTPX.Paint += new System.Windows.Forms.PaintEventHandler(this.panelNhapLieuCTPX_Paint);
            // 
            // maVT
            // 
            this.maVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "MAVT", true));
            this.maVT.Enabled = false;
            this.maVT.Location = new System.Drawing.Point(336, 144);
            this.maVT.MenuManager = this.barManager;
            this.maVT.Name = "maVT";
            this.maVT.Size = new System.Drawing.Size(125, 22);
            this.maVT.TabIndex = 12;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_PX";
            this.bdsCTPX.DataSource = this.bdsPX;
            // 
            // cmbVT
            // 
            this.cmbVT.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsCTPX, "MAVT", true));
            this.cmbVT.DataSource = this.bdsVatTu;
            this.cmbVT.DisplayMember = "TENVT";
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(95, 142);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(121, 24);
            this.cmbVT.TabIndex = 8;
            this.cmbVT.ValueMember = "MAVT";
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // dONGIATextEdit
            // 
            this.dONGIATextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "DONGIA", true));
            this.dONGIATextEdit.Location = new System.Drawing.Point(336, 219);
            this.dONGIATextEdit.MenuManager = this.barManager;
            this.dONGIATextEdit.Name = "dONGIATextEdit";
            this.dONGIATextEdit.Size = new System.Drawing.Size(125, 22);
            this.dONGIATextEdit.TabIndex = 7;
            // 
            // soLuongVT
            // 
            this.soLuongVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "SOLUONG", true));
            this.soLuongVT.Location = new System.Drawing.Point(91, 214);
            this.soLuongVT.MenuManager = this.barManager;
            this.soLuongVT.Name = "soLuongVT";
            this.soLuongVT.Size = new System.Drawing.Size(125, 22);
            this.soLuongVT.TabIndex = 5;
            // 
            // mAPXTextEdit
            // 
            this.mAPXTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsCTPX, "MAPX", true));
            this.mAPXTextEdit.Location = new System.Drawing.Point(90, 69);
            this.mAPXTextEdit.MenuManager = this.barManager;
            this.mAPXTextEdit.Name = "mAPXTextEdit";
            this.mAPXTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mAPXTextEdit.TabIndex = 1;
            // 
            // hoTenNVTableAdapter
            // 
            this.hoTenNVTableAdapter.ClearBeforeFill = true;
            // 
            // CTPXDataGridView
            // 
            this.CTPXDataGridView.AllowUserToAddRows = false;
            this.CTPXDataGridView.AutoGenerateColumns = false;
            this.CTPXDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CTPXDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CTPXDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.CTPXDataGridView.ContextMenuStrip = this.contextMenuStrip1;
            this.CTPXDataGridView.DataSource = this.bdsCTPX;
            this.CTPXDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.CTPXDataGridView.Location = new System.Drawing.Point(1140, 321);
            this.CTPXDataGridView.Name = "CTPXDataGridView";
            this.CTPXDataGridView.RowHeadersWidth = 51;
            this.CTPXDataGridView.RowTemplate.Height = 24;
            this.CTPXDataGridView.Size = new System.Drawing.Size(800, 486);
            this.CTPXDataGridView.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAPX";
            this.dataGridViewTextBoxColumn1.HeaderText = "MAPX";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemVT,
            this.btnXoaVT,
            this.btnSuaVT,
            this.btnGhiVT,
            this.btnPH});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 152);
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
            this.btnXoaVT.Size = new System.Drawing.Size(210, 24);
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
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.Size = new System.Drawing.Size(157, 24);
            this.btnGhiVT.Text = "Ghi";
            this.btnGhiVT.Click += new System.EventHandler(this.btnGhiVT_Click);
            // 
            // btnPH
            // 
            this.btnPH.Name = "btnPH";
            this.btnPH.Size = new System.Drawing.Size(157, 24);
            this.btnPH.Text = "Phục hồi";
            // 
            // FormPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1940, 827);
            this.Controls.Add(this.CTPXDataGridView);
            this.Controls.Add(this.panelNhapLieuCTPX);
            this.Controls.Add(this.panelNhapLieuPX);
            this.Controls.Add(this.phieuXuatGridControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormPX";
            this.Text = "FormPX";
            this.Load += new System.EventHandler(this.FormPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuXuatGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuPX)).EndInit();
            this.panelNhapLieuPX.ResumeLayout(false);
            this.panelNhapLieuPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maNVTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOTENKHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngayDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maPX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuCTPX)).EndInit();
            this.panelNhapLieuCTPX.ResumeLayout(false);
            this.panelNhapLieuCTPX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONGIATextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soLuongVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAPXTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTPXDataGridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem btnThemPX;
        private DevExpress.XtraBars.BarButtonItem btnXoa;
        private DevExpress.XtraBars.BarButtonItem btnSua;
        private DevExpress.XtraBars.BarButtonItem btnGhi;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoi;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        private DevExpress.XtraBars.BarButtonItem btnThoatNV;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhDDH;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsPX;
        private DS DS;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl phieuXuatGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPX;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTENKH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuCTPX;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuPX;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ComboBox cmbKho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cmbNV;
        private DevExpress.XtraEditors.TextEdit maKhoTextEdit;
        private DevExpress.XtraEditors.TextEdit maNVTextEdit;
        private DevExpress.XtraEditors.TextEdit hOTENKHTextEdit;
        private DevExpress.XtraEditors.DateEdit ngayDateEdit;
        private DevExpress.XtraEditors.TextEdit maPX;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource bdsKho;
        private System.Windows.Forms.BindingSource bdsNV;
        private DSTableAdapters.HoTenNVTableAdapter hoTenNVTableAdapter;
        private DSTableAdapters.CTPXTableAdapter CTPXTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private System.Windows.Forms.DataGridView CTPXDataGridView;
        private System.Windows.Forms.ComboBox cmbVT;
        private DevExpress.XtraEditors.TextEdit mAPXTextEdit;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DevExpress.XtraEditors.TextEdit maVT;
        private DevExpress.XtraEditors.TextEdit dONGIATextEdit;
        private DevExpress.XtraEditors.TextEdit soLuongVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnThemVT;
        private System.Windows.Forms.ToolStripMenuItem btnSuaVT;
        private System.Windows.Forms.ToolStripMenuItem btnXoaVT;
        private System.Windows.Forms.ToolStripMenuItem btnGhiVT;
        private System.Windows.Forms.ToolStripMenuItem btnPH;
    }
}