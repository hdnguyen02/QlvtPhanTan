
namespace QlvtPhanTan
{
    partial class FormKho
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
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label tENKHOLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label mACNLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKho));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinhKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatKho = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.labelCmbChiNhanh = new System.Windows.Forms.Label();
            this.DS = new QlvtPhanTan.DS();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QlvtPhanTan.DSTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.datHangTableAdapter = new QlvtPhanTan.DSTableAdapters.DatHangTableAdapter();
            this.phieuNhapTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuNhapTableAdapter();
            this.phieuXuatTableAdapter = new QlvtPhanTan.DSTableAdapters.PhieuXuatTableAdapter();
            this.khoGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieuKho = new DevExpress.XtraEditors.PanelControl();
            this.mACNTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dIACHITextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENKHOTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maKhoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsDH = new System.Windows.Forms.BindingSource(this.components);
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            mAKHOLabel = new System.Windows.Forms.Label();
            tENKHOLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).BeginInit();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuKho)).BeginInit();
            this.panelNhapLieuKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHOTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(46, 50);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(57, 17);
            mAKHOLabel.TabIndex = 0;
            mAKHOLabel.Text = "Mã kho:";
            // 
            // tENKHOLabel
            // 
            tENKHOLabel.AutoSize = true;
            tENKHOLabel.Location = new System.Drawing.Point(298, 50);
            tENKHOLabel.Name = "tENKHOLabel";
            tENKHOLabel.Size = new System.Drawing.Size(63, 17);
            tENKHOLabel.TabIndex = 2;
            tENKHOLabel.Text = "Tên kho:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(564, 48);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(53, 17);
            dIACHILabel.TabIndex = 4;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(805, 48);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(94, 17);
            mACNLabel.TabIndex = 6;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 51);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1118, 0);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 51);
            this.barDockControl1.Manager = null;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(1118, 0);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.btnThemKho,
            this.btnHieuChinh,
            this.btnGhiKho,
            this.btnXoaKho,
            this.btnPhucHoiKho,
            this.btnReloadKho,
            this.btnThoatKho,
            this.btnHieuChinhKho,
            this.btnThem});
            this.barManager.MainMenu = this.bar2;
            this.barManager.MaxItemId = 12;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinhKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatKho, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemKho
            // 
            this.btnThemKho.Caption = "Thêm";
            this.btnThemKho.Id = 1;
            this.btnThemKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemKho.ImageOptions.SvgImage")));
            this.btnThemKho.Name = "btnThemKho";
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.Caption = "Xóa";
            this.btnXoaKho.Id = 6;
            this.btnXoaKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaKho.ImageOptions.SvgImage")));
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaKho_ItemClick);
            // 
            // btnHieuChinhKho
            // 
            this.btnHieuChinhKho.Caption = "Hiệu Chỉnh";
            this.btnHieuChinhKho.Id = 10;
            this.btnHieuChinhKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinhKho.ImageOptions.SvgImage")));
            this.btnHieuChinhKho.Name = "btnHieuChinhKho";
            // 
            // btnGhiKho
            // 
            this.btnGhiKho.Caption = "Ghi";
            this.btnGhiKho.Enabled = false;
            this.btnGhiKho.Id = 3;
            this.btnGhiKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiKho.ImageOptions.SvgImage")));
            this.btnGhiKho.Name = "btnGhiKho";
            // 
            // btnPhucHoiKho
            // 
            this.btnPhucHoiKho.Caption = "Phục hồi";
            this.btnPhucHoiKho.Enabled = false;
            this.btnPhucHoiKho.Id = 7;
            this.btnPhucHoiKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiKho.ImageOptions.SvgImage")));
            this.btnPhucHoiKho.Name = "btnPhucHoiKho";
            // 
            // btnReloadKho
            // 
            this.btnReloadKho.Caption = "Reload";
            this.btnReloadKho.Id = 8;
            this.btnReloadKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReloadKho.ImageOptions.SvgImage")));
            this.btnReloadKho.Name = "btnReloadKho";
            // 
            // btnThoatKho
            // 
            this.btnThoatKho.Caption = "Thoát";
            this.btnThoatKho.Id = 9;
            this.btnThoatKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatKho.ImageOptions.SvgImage")));
            this.btnThoatKho.Name = "btnThoatKho";
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
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl2.Location = new System.Drawing.Point(0, 0);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl2.Size = new System.Drawing.Size(1118, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 626);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1118, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 575);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1118, 51);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 575);
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
            this.panelControl.Size = new System.Drawing.Size(1118, 50);
            this.panelControl.TabIndex = 8;
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
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.DS;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = this.phieuXuatTableAdapter;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // khoGridControl
            // 
            this.khoGridControl.DataSource = this.bdsKho;
            this.khoGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khoGridControl.Location = new System.Drawing.Point(0, 101);
            this.khoGridControl.MainView = this.gridView1;
            this.khoGridControl.MenuManager = this.barManager;
            this.khoGridControl.Name = "khoGridControl";
            this.khoGridControl.Size = new System.Drawing.Size(1118, 220);
            this.khoGridControl.TabIndex = 9;
            this.khoGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAKHO,
            this.TENKHO,
            this.DIACHI,
            this.MACN});
            this.gridView1.GridControl = this.khoGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // MAKHO
            // 
            this.MAKHO.Caption = "Mã kho";
            this.MAKHO.FieldName = "MAKHO";
            this.MAKHO.MinWidth = 25;
            this.MAKHO.Name = "MAKHO";
            this.MAKHO.Visible = true;
            this.MAKHO.VisibleIndex = 0;
            this.MAKHO.Width = 94;
            // 
            // TENKHO
            // 
            this.TENKHO.Caption = "Tên kho";
            this.TENKHO.FieldName = "TENKHO";
            this.TENKHO.MinWidth = 25;
            this.TENKHO.Name = "TENKHO";
            this.TENKHO.Visible = true;
            this.TENKHO.VisibleIndex = 1;
            this.TENKHO.Width = 94;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MinWidth = 25;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Visible = true;
            this.DIACHI.VisibleIndex = 2;
            this.DIACHI.Width = 94;
            // 
            // MACN
            // 
            this.MACN.Caption = "Mã chi nhánh";
            this.MACN.FieldName = "MACN";
            this.MACN.MinWidth = 25;
            this.MACN.Name = "MACN";
            this.MACN.Visible = true;
            this.MACN.VisibleIndex = 3;
            this.MACN.Width = 94;
            // 
            // panelNhapLieuKho
            // 
            this.panelNhapLieuKho.Controls.Add(mACNLabel);
            this.panelNhapLieuKho.Controls.Add(this.mACNTextEdit);
            this.panelNhapLieuKho.Controls.Add(dIACHILabel);
            this.panelNhapLieuKho.Controls.Add(this.dIACHITextEdit);
            this.panelNhapLieuKho.Controls.Add(tENKHOLabel);
            this.panelNhapLieuKho.Controls.Add(this.tENKHOTextEdit);
            this.panelNhapLieuKho.Controls.Add(mAKHOLabel);
            this.panelNhapLieuKho.Controls.Add(this.maKhoTextEdit);
            this.panelNhapLieuKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieuKho.Enabled = false;
            this.panelNhapLieuKho.Location = new System.Drawing.Point(0, 321);
            this.panelNhapLieuKho.Name = "panelNhapLieuKho";
            this.panelNhapLieuKho.Size = new System.Drawing.Size(1118, 305);
            this.panelNhapLieuKho.TabIndex = 10;
            // 
            // mACNTextEdit
            // 
            this.mACNTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "MACN", true));
            this.mACNTextEdit.Location = new System.Drawing.Point(900, 45);
            this.mACNTextEdit.MenuManager = this.barManager;
            this.mACNTextEdit.Name = "mACNTextEdit";
            this.mACNTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mACNTextEdit.TabIndex = 7;
            // 
            // dIACHITextEdit
            // 
            this.dIACHITextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "DIACHI", true));
            this.dIACHITextEdit.Location = new System.Drawing.Point(627, 45);
            this.dIACHITextEdit.MenuManager = this.barManager;
            this.dIACHITextEdit.Name = "dIACHITextEdit";
            this.dIACHITextEdit.Size = new System.Drawing.Size(125, 22);
            this.dIACHITextEdit.TabIndex = 5;
            // 
            // tENKHOTextEdit
            // 
            this.tENKHOTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "TENKHO", true));
            this.tENKHOTextEdit.Location = new System.Drawing.Point(369, 47);
            this.tENKHOTextEdit.MenuManager = this.barManager;
            this.tENKHOTextEdit.Name = "tENKHOTextEdit";
            this.tENKHOTextEdit.Size = new System.Drawing.Size(125, 22);
            this.tENKHOTextEdit.TabIndex = 3;
            // 
            // maKhoTextEdit
            // 
            this.maKhoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "MAKHO", true));
            this.maKhoTextEdit.Location = new System.Drawing.Point(110, 47);
            this.maKhoTextEdit.MenuManager = this.barManager;
            this.maKhoTextEdit.Name = "maKhoTextEdit";
            this.maKhoTextEdit.Size = new System.Drawing.Size(125, 22);
            this.maKhoTextEdit.TabIndex = 1;
            // 
            // bdsPX
            // 
            this.bdsPX.DataMember = "FK_PhieuXuat_Kho";
            this.bdsPX.DataSource = this.bdsKho;
            // 
            // bdsPN
            // 
            this.bdsPN.DataMember = "FK_PhieuNhap_Kho";
            this.bdsPN.DataSource = this.bdsKho;
            // 
            // bdsDH
            // 
            this.bdsDH.DataMember = "FK_DatHang_Kho";
            this.bdsDH.DataSource = this.bdsKho;
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Id = 11;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // FormKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 646);
            this.Controls.Add(this.panelNhapLieuKho);
            this.Controls.Add(this.khoGridControl);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl2);
            this.Name = "FormKho";
            this.Text = "FormKho";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieuKho)).EndInit();
            this.panelNhapLieuKho.ResumeLayout(false);
            this.panelNhapLieuKho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mACNTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIACHITextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENKHOTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maKhoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemKho;
        private DevExpress.XtraBars.BarButtonItem btnXoaKho;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhKho;
        private DevExpress.XtraBars.BarButtonItem btnGhiKho;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiKho;
        private DevExpress.XtraBars.BarButtonItem btnReloadKho;
        private DevExpress.XtraBars.BarButtonItem btnThoatKho;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraEditors.PanelControl panelControl;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label labelCmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsKho;
        private DS DS;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelNhapLieuKho;
        private DevExpress.XtraGrid.GridControl khoGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn MAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn TENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn MACN;
        private DevExpress.XtraEditors.TextEdit mACNTextEdit;
        private DevExpress.XtraEditors.TextEdit dIACHITextEdit;
        private DevExpress.XtraEditors.TextEdit tENKHOTextEdit;
        private DevExpress.XtraEditors.TextEdit maKhoTextEdit;
        private DSTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource bdsPX;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsPN;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.BindingSource bdsDH;
        private DevExpress.XtraBars.BarButtonItem btnThem;
    }
}