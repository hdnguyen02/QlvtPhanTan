
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
            this.MANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColMaCN = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.btnHieuChinhNV = new DevExpress.XtraBars.BarButtonItem();
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
            labelLuong.Location = new System.Drawing.Point(187, 107);
            labelLuong.Name = "labelLuong";
            labelLuong.Size = new System.Drawing.Size(57, 17);
            labelLuong.TabIndex = 2;
            labelLuong.Text = "LUONG:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(247, 29);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(49, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "MACN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(56, 71);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(32, 17);
            hOLabel.TabIndex = 7;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(245, 71);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(38, 17);
            tENLabel.TabIndex = 8;
            tENLabel.Text = "TEN:";
            // 
            // sOCMNDLabel
            // 
            sOCMNDLabel.AutoSize = true;
            sOCMNDLabel.Location = new System.Drawing.Point(431, 68);
            sOCMNDLabel.Name = "sOCMNDLabel";
            sOCMNDLabel.Size = new System.Drawing.Size(69, 17);
            sOCMNDLabel.TabIndex = 10;
            sOCMNDLabel.Text = "SOCMND:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(671, 65);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(57, 17);
            dIACHILabel.TabIndex = 12;
            dIACHILabel.Text = "DIACHI:";
            // 
            // trangThaiXoaLabel
            // 
            trangThaiXoaLabel.AutoSize = true;
            trangThaiXoaLabel.Location = new System.Drawing.Point(56, 193);
            trangThaiXoaLabel.Name = "trangThaiXoaLabel";
            trangThaiXoaLabel.Size = new System.Drawing.Size(105, 17);
            trangThaiXoaLabel.TabIndex = 14;
            trangThaiXoaLabel.Text = "Trang Thai Xoa:";
            // 
            // nGAYSINHLabel
            // 
            nGAYSINHLabel.AutoSize = true;
            nGAYSINHLabel.Location = new System.Drawing.Point(288, 165);
            nGAYSINHLabel.Name = "nGAYSINHLabel";
            nGAYSINHLabel.Size = new System.Drawing.Size(77, 17);
            nGAYSINHLabel.TabIndex = 16;
            nGAYSINHLabel.Text = "NGAYSINH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(928, 46);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(48, 17);
            mANVLabel.TabIndex = 17;
            mANVLabel.Text = "MANV:";
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
            this.btnHieuChinhNV});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 11;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinhNV, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
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
            this.btnThemNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.Caption = "Xóa";
            this.btnXoaNV.Id = 6;
            this.btnXoaNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaNV_ItemClick);
            // 
            // btnGhiNV
            // 
            this.btnGhiNV.Caption = "Ghi";
            this.btnGhiNV.Enabled = false;
            this.btnGhiNV.Id = 3;
            this.btnGhiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhiNV.Name = "btnGhiNV";
            this.btnGhiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnPhucHoiNV
            // 
            this.btnPhucHoiNV.Caption = "Phục hồi";
            this.btnPhucHoiNV.Enabled = false;
            this.btnPhucHoiNV.Id = 7;
            this.btnPhucHoiNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoi.ImageOptions.SvgImage")));
            this.btnPhucHoiNV.Name = "btnPhucHoiNV";
            this.btnPhucHoiNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiNV_ItemClick);
            // 
            // btnReloadNV
            // 
            this.btnReloadNV.Caption = "Reload";
            this.btnReloadNV.Id = 8;
            this.btnReloadNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReloadNV.Name = "btnReloadNV";
            this.btnReloadNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadNV_ItemClick);
            // 
            // btnThoatNV
            // 
            this.btnThoatNV.Caption = "Thoát";
            this.btnThoatNV.Id = 9;
            this.btnThoatNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoatNV.Name = "btnThoatNV";
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
            // panelControl
            // 
            this.panelControl.Controls.Add(this.cmbChiNhanh);
            this.panelControl.Controls.Add(this.labelCmbChiNhanh);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 51);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1524, 50);
            this.panelControl.TabIndex = 4;
            this.panelControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl_Paint);
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Enabled = false;
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
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.nhanVienGridControl.Size = new System.Drawing.Size(1524, 242);
            this.nhanVienGridControl.TabIndex = 9;
            this.nhanVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MANV,
            this.HO,
            this.TEN,
            this.SOCMND,
            this.DIACHI,
            this.colNGAYSINH,
            this.LUONG,
            this.ColMaCN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.nhanVienGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // MANV
            // 
            this.MANV.Caption = "Mã nhân viên";
            this.MANV.FieldName = "MANV";
            this.MANV.MinWidth = 25;
            this.MANV.Name = "MANV";
            this.MANV.Visible = true;
            this.MANV.VisibleIndex = 0;
            this.MANV.Width = 94;
            // 
            // HO
            // 
            this.HO.Caption = "Họ";
            this.HO.FieldName = "HO";
            this.HO.MinWidth = 25;
            this.HO.Name = "HO";
            this.HO.Visible = true;
            this.HO.VisibleIndex = 1;
            this.HO.Width = 94;
            // 
            // TEN
            // 
            this.TEN.Caption = "Tên";
            this.TEN.FieldName = "TEN";
            this.TEN.MinWidth = 25;
            this.TEN.Name = "TEN";
            this.TEN.Visible = true;
            this.TEN.VisibleIndex = 2;
            this.TEN.Width = 94;
            // 
            // SOCMND
            // 
            this.SOCMND.Caption = "Số CMND";
            this.SOCMND.FieldName = "SOCMND";
            this.SOCMND.MinWidth = 25;
            this.SOCMND.Name = "SOCMND";
            this.SOCMND.Visible = true;
            this.SOCMND.VisibleIndex = 3;
            this.SOCMND.Width = 94;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MinWidth = 25;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 4;
            this.DIACHI.Width = 94;
            // 
            // colNGAYSINH
            // 
            this.colNGAYSINH.Caption = "Ngày sinh";
            this.colNGAYSINH.FieldName = "NGAYSINH";
            this.colNGAYSINH.MinWidth = 25;
            this.colNGAYSINH.Name = "colNGAYSINH";
            this.colNGAYSINH.Visible = true;
            this.colNGAYSINH.VisibleIndex = 5;
            this.colNGAYSINH.Width = 94;
            // 
            // LUONG
            // 
            this.LUONG.Caption = "Lương";
            this.LUONG.DisplayFormat.FormatString = "n0";
            this.LUONG.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LUONG.FieldName = "LUONG";
            this.LUONG.MinWidth = 25;
            this.LUONG.Name = "LUONG";
            this.LUONG.Visible = true;
            this.LUONG.VisibleIndex = 6;
            this.LUONG.Width = 94;
            // 
            // ColMaCN
            // 
            this.ColMaCN.Caption = "Mã chi nhánh";
            this.ColMaCN.FieldName = "MACN";
            this.ColMaCN.MinWidth = 25;
            this.ColMaCN.Name = "ColMaCN";
            this.ColMaCN.Visible = true;
            this.ColMaCN.VisibleIndex = 7;
            this.ColMaCN.Width = 94;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.MinWidth = 25;
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
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
            this.panelNhapLieuNV.Location = new System.Drawing.Point(0, 343);
            this.panelNhapLieuNV.Name = "panelNhapLieuNV";
            this.panelNhapLieuNV.Size = new System.Drawing.Size(1524, 347);
            this.panelNhapLieuNV.TabIndex = 10;
            this.panelNhapLieuNV.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlAddNV_Paint);
            // 
            // maNVTextBox
            // 
            this.maNVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "MANV", true));
            this.maNVTextBox.Location = new System.Drawing.Point(982, 43);
            this.maNVTextBox.Name = "maNVTextBox";
            this.maNVTextBox.Size = new System.Drawing.Size(100, 23);
            this.maNVTextBox.TabIndex = 18;
            // 
            // ngaySinhTextBox
            // 
            this.ngaySinhTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "NGAYSINH", true));
            this.ngaySinhTextBox.EditValue = null;
            this.ngaySinhTextBox.Location = new System.Drawing.Point(371, 162);
            this.ngaySinhTextBox.MenuManager = this.barManager;
            this.ngaySinhTextBox.Name = "ngaySinhTextBox";
            this.ngaySinhTextBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhTextBox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ngaySinhTextBox.Size = new System.Drawing.Size(125, 22);
            this.ngaySinhTextBox.TabIndex = 17;
            // 
            // trangThaiXoaCheckEdit
            // 
            this.trangThaiXoaCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "TrangThaiXoa", true));
            this.trangThaiXoaCheckEdit.Location = new System.Drawing.Point(741, 119);
            this.trangThaiXoaCheckEdit.MenuManager = this.barManager;
            this.trangThaiXoaCheckEdit.Name = "trangThaiXoaCheckEdit";
            this.trangThaiXoaCheckEdit.Properties.Caption = "";
            this.trangThaiXoaCheckEdit.Size = new System.Drawing.Size(94, 24);
            this.trangThaiXoaCheckEdit.TabIndex = 15;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "DIACHI", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(734, 62);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(100, 23);
            this.diaChiTextBox.TabIndex = 13;
            // 
            // soCMNDTextBox
            // 
            this.soCMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "SOCMND", true));
            this.soCMNDTextBox.Location = new System.Drawing.Point(506, 65);
            this.soCMNDTextBox.Name = "soCMNDTextBox";
            this.soCMNDTextBox.Size = new System.Drawing.Size(100, 23);
            this.soCMNDTextBox.TabIndex = 11;
            // 
            // tenTextBox
            // 
            this.tenTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "TEN", true));
            this.tenTextBox.Location = new System.Drawing.Point(289, 68);
            this.tenTextBox.Name = "tenTextBox";
            this.tenTextBox.Size = new System.Drawing.Size(100, 23);
            this.tenTextBox.TabIndex = 9;
            // 
            // hoTextBox
            // 
            this.hoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsNhanVien, "HO", true));
            this.hoTextBox.Location = new System.Drawing.Point(118, 71);
            this.hoTextBox.Name = "hoTextBox";
            this.hoTextBox.Size = new System.Drawing.Size(100, 23);
            this.hoTextBox.TabIndex = 8;
            // 
            // maCNTextBox
            // 
            this.maCNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "MACN", true));
            this.maCNTextBox.Enabled = false;
            this.maCNTextBox.Location = new System.Drawing.Point(311, 26);
            this.maCNTextBox.MenuManager = this.barManager;
            this.maCNTextBox.Name = "maCNTextBox";
            this.maCNTextBox.Size = new System.Drawing.Size(125, 22);
            this.maCNTextBox.TabIndex = 7;
            // 
            // luongTextBox
            // 
            this.luongTextBox.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsNhanVien, "LUONG", true));
            this.luongTextBox.Location = new System.Drawing.Point(250, 104);
            this.luongTextBox.MenuManager = this.barManager;
            this.luongTextBox.Name = "luongTextBox";
            this.luongTextBox.Properties.DisplayFormat.FormatString = "n0";
            this.luongTextBox.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.luongTextBox.Properties.EditFormat.FormatString = "n0";
            this.luongTextBox.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.luongTextBox.Size = new System.Drawing.Size(282, 22);
            this.luongTextBox.TabIndex = 3;
            this.luongTextBox.EditValueChanged += new System.EventHandler(this.textEditLuong_EditValueChanged);
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
            // btnHieuChinhNV
            // 
            this.btnHieuChinhNV.Caption = "Hiệu Chỉnh";
            this.btnHieuChinhNV.Id = 10;
            this.btnHieuChinhNV.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btnHieuChinhNV.Name = "btnHieuChinhNV";
            this.btnHieuChinhNV.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinhNV_ItemClick);
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
        private DevExpress.XtraGrid.Columns.GridColumn MANV;
        private DevExpress.XtraGrid.Columns.GridColumn HO;
        private DevExpress.XtraGrid.Columns.GridColumn TEN;
        private DevExpress.XtraGrid.Columns.GridColumn SOCMND;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn LUONG;
        private DevExpress.XtraGrid.Columns.GridColumn ColMaCN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
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
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhNV;
    }
}