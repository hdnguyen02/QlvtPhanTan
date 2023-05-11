
namespace QlvtPhanTan
{
    partial class FormNhanVien
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
            System.Windows.Forms.Label labelLuong;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sOCMNDLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label trangThaiXoaLabel;
            System.Windows.Forms.Label nGAYSINHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnSuaNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadNV = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatNV = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinhDDH = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelCmbChiNhanh = new System.Windows.Forms.Label();
            this.virtualServerModeSource1 = new DevExpress.Data.VirtualServerModeSource(this.components);
            this.DS = new QlvtPhanTan.DS();
            this.bdsNhanVien = new System.Windows.Forms.BindingSource(this.components);
            this.nhanVienTableAdapter = new QlvtPhanTan.DSTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.nhanVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuNV = new DevExpress.XtraEditors.PanelControl();
            this.maNVTextBox = new System.Windows.Forms.TextBox();
            this.ngaySinhTextBox = new DevExpress.XtraEditors.DateEdit();
            this.trangThaiXoaCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.soCMNDTextBox = new System.Windows.Forms.TextBox();
            this.tenTextBox = new System.Windows.Forms.TextBox();
            this.hoTextBox = new System.Windows.Forms.TextBox();
            this.maCNTextBox = new DevExpress.XtraEditors.TextEdit();
            this.luongTextBox = new DevExpress.XtraEditors.TextEdit();
            this.bdsPhieuXuat = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QlvtPhanTan.DSTableAdapters.DatHangTableAdapter();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuXuatTableAdapter();
            labelLuong = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sOCMNDLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            trangThaiXoaLabel = new System.Windows.Forms.Label();
            nGAYSINHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuNV)).BeginInit();
            this.panelNhapLieuNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhTextBox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiXoaCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongTextBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLuong
            // 
            labelLuong.AutoSize = true;
            labelLuong.Location = new System.Drawing.Point(388, 84);
            labelLuong.Name = "labelLuong";
            labelLuong.Size = new System.Drawing.Size(53, 17);
            labelLuong.TabIndex = 2;
            labelLuong.Text = "Lương:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(55, 26);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(94, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(522, 26);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 7;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(795, 27);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 8;
            tENLabel.Text = "Tên:";
            // 
            // sOCMNDLabel
            // 
            sOCMNDLabel.AutoSize = true;
            sOCMNDLabel.Location = new System.Drawing.Point(988, 27);
            sOCMNDLabel.Name = "sOCMNDLabel";
            sOCMNDLabel.Size = new System.Drawing.Size(71, 17);
            sOCMNDLabel.TabIndex = 10;
            sOCMNDLabel.Text = "Số CMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(51, 87);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(53, 17);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(1036, 84);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(106, 17);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trạng thái xóa: ";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(688, 84);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(73, 17);
            nGAYSINHLabel.TabIndex = 16;
            nGAYSINHLabel.Text = "Ngày sinh:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(276, 27);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(94, 17);
            mANVLabel.TabIndex = 17;
            mANVLabel.Text = "Mã nhân viên:";
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
            this.btnThemNV,
            this.btnHieuChinh,
            this.btnGhiNV,
            this.btnXoaNV,
            this.btnPhucHoiNV,
            this.btnReloadNV,
            this.btnThoatNV,
            this.btnHieuChinhDDH,
            this.btnSuaNV});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSuaNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemNV
            // 
            this.btnThemNV.Caption = "Thêm";
            this.btnThemNV.Id = 1;
            this.btnThemNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemNV.ImageOptions.SvgImage")));
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa";
            this.btnXoaNV.Id = 6;
            this.btnXoaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaNV.ImageOptions.SvgImage")));
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNV_ItemClick);
            // 
            // btnSuaNV
            // 
            this.btnSuaNV.Caption = "Sữa";
            this.btnSuaNV.Id = 11;
            this.btnSuaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSuaNV.ImageOptions.SvgImage")));
            this.btnSuaNV.Name = "btnSuaNV";
            this.btnSuaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSuaNV_ItemClick);
            // 
            // btnGhiNV
            // 
            this.btnGhiNV.Caption = "Ghi";
            this.btnGhiNV.Enabled = false;
            this.btnGhiNV.Id = 3;
            this.btnGhiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiNV.ImageOptions.SvgImage")));
            this.btnGhiNV.Name = "btnGhiNV";
            this.btnGhiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoiNV
            // 
            this.btnPhucHoiNV.Caption = "Phục hồi";
            this.btnPhucHoiNV.Enabled = false;
            this.btnPhucHoiNV.Id = 7;
            this.btnPhucHoiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiNV.ImageOptions.SvgImage")));
            this.btnPhucHoiNV.Name = "btnPhucHoiNV";
            this.btnPhucHoiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiNV_ItemClick);
            // 
            // btnReloadNV
            // 
            this.btnReloadNV.Caption = "Reload";
            this.btnReloadNV.Id = 8;
            this.btnReloadNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReloadNV.ImageOptions.SvgImage")));
            this.btnReloadNV.Name = "btnReloadNV";
            this.btnReloadNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadNV_ItemClick);
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.Caption = "Thoát";
            this.btnThoatNV.Id = 9;
            this.btnThoatNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatNV.ImageOptions.SvgImage")));
            this.btnThoatNV.Name = "btnThoatNV";
            this.btnThoatNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatNV_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1524, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 690);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1524, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 639);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1524, 51);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 639);
            // 
            // btnHieuChinh
            // 
            this.btnHieuChinh.Caption = "Hiệu chỉnh";
            this.btnHieuChinh.Id = 2;
            this.btnHieuChinh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinh.ImageOptions.SvgImage")));
            this.btnHieuChinh.Name = "btnHieuChinh";
            // 
            // btnHieuChinhDDH
            // 
            this.btnHieuChinhDDH.Id = 12;
            this.btnHieuChinhDDH.Name = "btnHieuChinhDDH";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.cmbChiNhanh);
            this.panelControl.Controls.Add(this.labelCmbChiNhanh);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 51);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1524, 50);
            this.panelControl.TabIndex = 4;
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
            // bdsNhanVien
            // 
            this.bdsNhanVien.DataMember = "NhanVien";
            this.bdsNhanVien.DataSource = this.DS;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // nhanVienGridControl
            // 
            this.nhanVienGridControl.DataSource = this.bdsNhanVien;
            this.nhanVienGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.nhanVienGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.nhanVienGridControl.Location = new System.Drawing.Point(0, 101);
            this.nhanVienGridControl.MainView = this.gridView1;
            this.nhanVienGridControl.MenuManager = this.barManager;
            this.nhanVienGridControl.Name = "nhanVienGridControl";
            this.nhanVienGridControl.Size = new System.Drawing.Size(1524, 446);
            this.nhanVienGridControl.TabIndex = 9;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colSOCMND,
            this.colDIACHI,
            this.colNGAYSINH,
            this.colLUONG,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            this.colMANV.Width = 94;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 94;
            // 
            // colSOCMND
            // 
            this.colSOCMND.FieldName = "SOCMND";
            this.colSOCMND.MinWidth = 25;
            this.colSOCMND.Name = "colSOCMND";
            this.colSOCMND.Visible = true;
            this.colSOCMND.VisibleIndex = 3;
            this.colSOCMND.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 4;
            this.colDIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // colLUONG
            // 
            this.colLUONG.FieldName = "LUONG";
            this.colLUONG.MinWidth = 25;
            this.colLUONG.Name = "colLUONG";
            this.colLUONG.Visible = true;
            this.colLUONG.VisibleIndex = 6;
            this.colLUONG.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            this.colMACN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 8;
            this.colTrangThaiXoa.Width = 94;
            // 
            // panelNhapLieuNV
            // 
            this.panelNhapLieuNV.Controls.Add(mANVLabel);
            this.panelNhapLieuNV.Controls.Add(this.maNVTextBox);
            this.panelNhapLieuNV.Controls.Add(nGAYSINHLabel);
            this.panelNhapLieuNV.Controls.Add(this.ngaySinhTextBox);
            this.panelNhapLieuNV.Controls.Add(trangThaiXoaLabel);
            this.panelNhapLieuNV.Controls.Add(this.trangThaiXoaCheckEdit);
            this.panelNhapLieuNV.Controls.Add(dIACHILabel);
            this.panelNhapLieuNV.Controls.Add(this.diaChiTextBox);
            this.panelNhapLieuNV.Controls.Add(sOCMNDLabel);
            this.panelNhapLieuNV.Controls.Add(this.soCMNDTextBox);
            this.panelNhapLieuNV.Controls.Add(tENLabel);
            this.panelNhapLieuNV.Controls.Add(this.tenTextBox);
            this.panelNhapLieuNV.Controls.Add(hOLabel);
            this.panelNhapLieuNV.Controls.Add(this.hoTextBox);
            this.panelNhapLieuNV.Controls.Add(mACNLabel);
            this.panelNhapLieuNV.Controls.Add(this.maCNTextBox);
            this.panelNhapLieuNV.Controls.Add(labelLuong);
            this.panelNhapLieuNV.Controls.Add(this.luongTextBox);
            this.panelNhapLieuNV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieuNV.Enabled = false;
            this.panelNhapLieuNV.Location = new System.Drawing.Point(0, 547);
            this.panelNhapLieuNV.Name = "panelNhapLieuNV";
            this.panelNhapLieuNV.Size = new System.Drawing.Size(1524, 143);
            this.panelNhapLieuNV.TabIndex = 10;
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.maNVTextBox.Location = new System.Drawing.Point(376, 24);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(100, 23);
            this.maNVTextBox.TabIndex = 18;
            // 
            // ngaySinhTextBox
            // 
            this.ngaySinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NGAYSINH", true));
            this.ngaySinhTextBox.EditValue = null;
            this.ngaySinhTextBox.Location = new System.Drawing.Point(766, 82);
            this.ngaySinhTextBox.MenuManager = this.barManager;
            this.ngaySinhTextBox.Name = "ngaySinhTextBox";
            this.ngaySinhTextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhTextBox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhTextBox.Size = new System.Drawing.Size(152, 22);
            this.ngaySinhTextBox.TabIndex = 17;
            // 
            // trangThaiXoaCheckEdit
            // 
            this.trangThaiXoaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "TrangThaiXoa", true));
            this.trangThaiXoaCheckEdit.Location = new System.Drawing.Point(1148, 81);
            this.trangThaiXoaCheckEdit.MenuManager = this.barManager;
            this.trangThaiXoaCheckEdit.Name = "trangThaiXoaCheckEdit";
            this.trangThaiXoaCheckEdit.Properties.Caption = "";
            this.trangThaiXoaCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.trangThaiXoaCheckEdit.Size = new System.Drawing.Size(68, 24);
            this.trangThaiXoaCheckEdit.TabIndex = 15;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DIACHI", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(110, 84);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(186, 23);
            this.diaChiTextBox.TabIndex = 13;
            // 
            // soCMNDTextBox
            // 
            this.soCMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "SOCMND", true));
            this.soCMNDTextBox.Location = new System.Drawing.Point(1065, 24);
            this.soCMNDTextBox.Name = "soCMNDTextBox";
            this.soCMNDTextBox.Size = new System.Drawing.Size(100, 23);
            this.soCMNDTextBox.TabIndex = 11;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TEN", true));
            this.tenTextBox.Location = new System.Drawing.Point(837, 24);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(100, 23);
            this.tenTextBox.TabIndex = 9;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "HO", true));
            this.hoTextBox.Location = new System.Drawing.Point(558, 24);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(194, 23);
            this.hoTextBox.TabIndex = 8;
            // 
            // maCNTextBox
            // 
            this.maCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "MACN", true));
            this.maCNTextBox.Enabled = false;
            this.maCNTextBox.Location = new System.Drawing.Point(155, 24);
            this.maCNTextBox.MenuManager = this.barManager;
            this.maCNTextBox.Name = "maCNTextBox";
            this.maCNTextBox.Size = new System.Drawing.Size(78, 22);
            this.maCNTextBox.TabIndex = 7;
            // 
            // luongTextBox
            // 
            this.luongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "LUONG", true));
            this.luongTextBox.Location = new System.Drawing.Point(447, 83);
            this.luongTextBox.MenuManager = this.barManager;
            this.luongTextBox.Name = "luongTextBox";
            this.luongTextBox.Properties.DisplayFormat.FormatString = "n0";
            this.luongTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.luongTextBox.Properties.EditFormat.FormatString = "n0";
            this.luongTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.luongTextBox.Size = new System.Drawing.Size(158, 22);
            this.luongTextBox.TabIndex = 3;
            // 
            // bdsPhieuXuat
            // 
            this.bdsPhieuXuat.DataMember = "FK_PX_NhanVien";
            this.bdsPhieuXuat.DataSource = this.bdsNhanVien;
            // 
            // bdsDatHang
            // 
            this.bdsDatHang.DataMember = "FK_DatHang_NhanVien";
            this.bdsDatHang.DataSource = this.bdsNhanVien;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_NhanVien1";
            this.bdsPhieuNhap.DataSource = this.bdsNhanVien;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // FormNhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 710);
            this.Controls.Add(this.panelNhapLieuNV);
            this.Controls.Add(this.nhanVienGridControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNhanVien";
            this.Text = "Nhân viên";
            this.Load += new System.EventHandler(this.FormNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.virtualServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuNV)).EndInit();
            this.panelNhapLieuNV.ResumeLayout(false);
            this.panelNhapLieuNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhTextBox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ngaySinhTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trangThaiXoaCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maCNTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luongTextBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemNV;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
        private DevExpress.Data.VirtualServerModeSource virtualServerModeSource1;
        private System.Windows.Forms.BindingSource bdsNhanVien;
        private DS DS;
        private DSTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl nhanVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuNV;
        private DevExpress.XtraEditors.TextEdit luongTextBox;
        private System.Windows.Forms.BindingSource bdsDatHang;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsPhieuXuat;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private DevExpress.XtraEditors.TextEdit maCNTextBox;
        private DevExpress.XtraEditors.CheckEdit trangThaiXoaCheckEdit;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox soCMNDTextBox;
        private System.Windows.Forms.TextBox tenTextBox;
        private System.Windows.Forms.TextBox hoTextBox;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarButtonItem btnGhiNV;
        private DevExpress.XtraBars.BarButtonItem btnXoaNV;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiNV;
        private DevExpress.XtraBars.BarButtonItem btnReloadNV;
        private DevExpress.XtraEditors.DateEdit ngaySinhTextBox;
        private System.Windows.Forms.TextBox maNVTextBox;
        private DevExpress.XtraBars.BarButtonItem btnThoatNV;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhDDH;
        private DevExpress.XtraBars.BarButtonItem btnSuaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn colLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
    }
}