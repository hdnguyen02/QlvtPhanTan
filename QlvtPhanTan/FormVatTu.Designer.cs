
namespace QlvtPhanTan
{
    partial class FormVatTu
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
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label tENVTLabel;
            System.Windows.Forms.Label dVTLabel;
            System.Windows.Forms.Label sOLUONGTONLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVatTu));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnHieuChinhVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnGhiVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnPhucHoiVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnReloadVT = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatVT = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnHieuChinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoatNV = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.DS = new QlvtPhanTan.DS();
            this.bdsVatTu = new System.Windows.Forms.BindingSource(this.components);
            this.vatTuTableAdapter = new QlvtPhanTan.DSTableAdapters.VattuTableAdapter();
            this.tableAdapterManager = new QlvtPhanTan.DSTableAdapters.TableAdapterManager();
            this.ctddhTableAdapter = new QlvtPhanTan.DSTableAdapters.CTDDHTableAdapter();
            this.ctpnTableAdapter = new QlvtPhanTan.DSTableAdapters.CTPNTableAdapter();
            this.ctpxTableAdapter = new QlvtPhanTan.DSTableAdapters.CTPXTableAdapter();
            this.vattuGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOLUONGTON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControlNhapLieuVatTu = new DevExpress.XtraEditors.PanelControl();
            this.sOLUONGTONTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.dVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tENVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.mAVTTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.bdsCTPN = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTPX = new System.Windows.Forms.BindingSource(this.components);
            this.bdsCTDDH = new System.Windows.Forms.BindingSource(this.components);
            mAVTLabel = new System.Windows.Forms.Label();
            tENVTLabel = new System.Windows.Forms.Label();
            dVTLabel = new System.Windows.Forms.Label();
            sOLUONGTONLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieuVatTu)).BeginInit();
            this.panelControlNhapLieuVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).BeginInit();
            this.SuspendLayout();
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(41, 25);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(72, 17);
            mAVTLabel.TabIndex = 0;
            mAVTLabel.Text = "Mã vật tư:";
            // 
            // tENVTLabel
            // 
            tENVTLabel.AutoSize = true;
            tENVTLabel.Location = new System.Drawing.Point(277, 26);
            tENVTLabel.Name = "tENVTLabel";
            tENVTLabel.Size = new System.Drawing.Size(78, 17);
            tENVTLabel.TabIndex = 2;
            tENVTLabel.Text = "Tên vật tư:";
            // 
            // dVTLabel
            // 
            dVTLabel.AutoSize = true;
            dVTLabel.Location = new System.Drawing.Point(542, 27);
            dVTLabel.Name = "dVTLabel";
            dVTLabel.Size = new System.Drawing.Size(80, 17);
            dVTLabel.TabIndex = 4;
            dVTLabel.Text = "Đơn vị tính:";
            // 
            // sOLUONGTONLabel
            // 
            sOLUONGTONLabel.AutoSize = true;
            sOLUONGTONLabel.Location = new System.Drawing.Point(835, 24);
            sOLUONGTONLabel.Name = "sOLUONGTONLabel";
            sOLUONGTONLabel.Size = new System.Drawing.Size(102, 17);
            sOLUONGTONLabel.TabIndex = 6;
            sOLUONGTONLabel.Text = "SOLUONGTON:";
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
            this.btnThemVT,
            this.btnHieuChinh,
            this.btnGhiVT,
            this.btnXoaVT,
            this.btnPhucHoiVT,
            this.btnReloadVT,
            this.btnThoatNV,
            this.btnHieuChinhVT,
            this.btnThoatVT});
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThemVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnXoaVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnHieuChinhVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnGhiVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnPhucHoiVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReloadVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnThoatVT, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnThemVT
            // 
            this.btnThemVT.Caption = "Thêm";
            this.btnThemVT.Id = 1;
            this.btnThemVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemVT.ImageOptions.SvgImage")));
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThemVT_ItemClick);
            // 
            // btnXoaVT
            // 
            this.btnXoaVT.Caption = "Xóa";
            this.btnXoaVT.Id = 6;
            this.btnXoaVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaVT.ImageOptions.SvgImage")));
            this.btnXoaVT.Name = "btnXoaVT";
            this.btnXoaVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoaVT_ItemClick);
            // 
            // btnHieuChinhVT
            // 
            this.btnHieuChinhVT.Caption = "Hiệu Chỉnh";
            this.btnHieuChinhVT.Id = 10;
            this.btnHieuChinhVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHieuChinhVT.ImageOptions.SvgImage")));
            this.btnHieuChinhVT.Name = "btnHieuChinhVT";
            this.btnHieuChinhVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHieuChinhVT_ItemClick);
            // 
            // btnGhiVT
            // 
            this.btnGhiVT.Caption = "Ghi";
            this.btnGhiVT.Enabled = false;
            this.btnGhiVT.Id = 3;
            this.btnGhiVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhiVT.ImageOptions.SvgImage")));
            this.btnGhiVT.Name = "btnGhiVT";
            this.btnGhiVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhiVT_ItemClick);
            // 
            // btnPhucHoiVT
            // 
            this.btnPhucHoiVT.Caption = "Phục hồi";
            this.btnPhucHoiVT.Enabled = false;
            this.btnPhucHoiVT.Id = 7;
            this.btnPhucHoiVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPhucHoiVT.ImageOptions.SvgImage")));
            this.btnPhucHoiVT.Name = "btnPhucHoiVT";
            this.btnPhucHoiVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPhucHoiVT_ItemClick);
            // 
            // btnReloadVT
            // 
            this.btnReloadVT.Caption = "Reload";
            this.btnReloadVT.Id = 8;
            this.btnReloadVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReloadVT.ImageOptions.SvgImage")));
            this.btnReloadVT.Name = "btnReloadVT";
            this.btnReloadVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReloadVT_ItemClick);
            // 
            // btnThoatVT
            // 
            this.btnThoatVT.Caption = "Thoát";
            this.btnThoatVT.Id = 11;
            this.btnThoatVT.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoatVT.ImageOptions.SvgImage")));
            this.btnThoatVT.Name = "btnThoatVT";
            this.btnThoatVT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoatVT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1234, 51);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 586);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1234, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 51);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 535);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1234, 51);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 535);
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
            // barButtonItem2
            // 
            this.barButtonItem2.Id = 0;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Thêm";
            this.barButtonItem3.Id = 1;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Xóa";
            this.barButtonItem4.Id = 6;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Hiệu Chỉnh";
            this.barButtonItem5.Id = 10;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Ghi";
            this.barButtonItem6.Enabled = false;
            this.barButtonItem6.Id = 3;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.Name = "barButtonItem6";
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Phục hồi";
            this.barButtonItem7.Enabled = false;
            this.barButtonItem7.Id = 7;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.Name = "barButtonItem7";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Reload";
            this.barButtonItem8.Id = 8;
            this.barButtonItem8.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem8.ImageOptions.SvgImage")));
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Thoát";
            this.barButtonItem9.Id = 9;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1234, 51);
            this.barDockControl4.Manager = null;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl4.Size = new System.Drawing.Size(0, 535);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsVatTu
            // 
            this.bdsVatTu.DataMember = "Vattu";
            this.bdsVatTu.DataSource = this.DS;
            // 
            // vatTuTableAdapter
            // 
            this.vatTuTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.ctddhTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.ctpnTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = this.ctpxTableAdapter;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QlvtPhanTan.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = this.vatTuTableAdapter;
            // 
            // ctddhTableAdapter
            // 
            this.ctddhTableAdapter.ClearBeforeFill = true;
            // 
            // ctpnTableAdapter
            // 
            this.ctpnTableAdapter.ClearBeforeFill = true;
            // 
            // ctpxTableAdapter
            // 
            this.ctpxTableAdapter.ClearBeforeFill = true;
            // 
            // vattuGridControl
            // 
            this.vattuGridControl.DataSource = this.bdsVatTu;
            this.vattuGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.vattuGridControl.Location = new System.Drawing.Point(0, 51);
            this.vattuGridControl.MainView = this.gridView1;
            this.vattuGridControl.MenuManager = this.barManager;
            this.vattuGridControl.Name = "vattuGridControl";
            this.vattuGridControl.Size = new System.Drawing.Size(1234, 220);
            this.vattuGridControl.TabIndex = 9;
            this.vattuGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.vattuGridControl.Click += new System.EventHandler(this.vattuGridControl_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAVT,
            this.TENVT,
            this.DVT,
            this.SOLUONGTON});
            this.gridView1.GridControl = this.vattuGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // MAVT
            // 
            this.MAVT.Caption = "Mã vật tư ";
            this.MAVT.FieldName = "MAVT";
            this.MAVT.MinWidth = 25;
            this.MAVT.Name = "MAVT";
            this.MAVT.Visible = true;
            this.MAVT.VisibleIndex = 0;
            this.MAVT.Width = 94;
            // 
            // TENVT
            // 
            this.TENVT.Caption = "Tên vật tư";
            this.TENVT.FieldName = "TENVT";
            this.TENVT.MinWidth = 25;
            this.TENVT.Name = "TENVT";
            this.TENVT.Visible = true;
            this.TENVT.VisibleIndex = 1;
            this.TENVT.Width = 94;
            // 
            // DVT
            // 
            this.DVT.Caption = "Đơn vị tính";
            this.DVT.FieldName = "DVT";
            this.DVT.MinWidth = 25;
            this.DVT.Name = "DVT";
            this.DVT.Visible = true;
            this.DVT.VisibleIndex = 2;
            this.DVT.Width = 94;
            // 
            // SOLUONGTON
            // 
            this.SOLUONGTON.FieldName = "SOLUONGTON";
            this.SOLUONGTON.MinWidth = 25;
            this.SOLUONGTON.Name = "SOLUONGTON";
            this.SOLUONGTON.OptionsEditForm.Caption = "Đô lượng tồn";
            this.SOLUONGTON.Visible = true;
            this.SOLUONGTON.VisibleIndex = 3;
            this.SOLUONGTON.Width = 94;
            // 
            // panelControlNhapLieuVatTu
            // 
            this.panelControlNhapLieuVatTu.Controls.Add(sOLUONGTONLabel);
            this.panelControlNhapLieuVatTu.Controls.Add(this.sOLUONGTONTextEdit);
            this.panelControlNhapLieuVatTu.Controls.Add(dVTLabel);
            this.panelControlNhapLieuVatTu.Controls.Add(this.dVTTextEdit);
            this.panelControlNhapLieuVatTu.Controls.Add(tENVTLabel);
            this.panelControlNhapLieuVatTu.Controls.Add(this.tENVTTextEdit);
            this.panelControlNhapLieuVatTu.Controls.Add(mAVTLabel);
            this.panelControlNhapLieuVatTu.Controls.Add(this.mAVTTextEdit);
            this.panelControlNhapLieuVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlNhapLieuVatTu.Enabled = false;
            this.panelControlNhapLieuVatTu.Location = new System.Drawing.Point(0, 271);
            this.panelControlNhapLieuVatTu.Name = "panelControlNhapLieuVatTu";
            this.panelControlNhapLieuVatTu.Size = new System.Drawing.Size(1234, 315);
            this.panelControlNhapLieuVatTu.TabIndex = 10;
            this.panelControlNhapLieuVatTu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControlNhapLieuVatTu_Paint);
            // 
            // sOLUONGTONTextEdit
            // 
            this.sOLUONGTONTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "SOLUONGTON", true));
            this.sOLUONGTONTextEdit.Location = new System.Drawing.Point(943, 21);
            this.sOLUONGTONTextEdit.MenuManager = this.barManager;
            this.sOLUONGTONTextEdit.Name = "sOLUONGTONTextEdit";
            this.sOLUONGTONTextEdit.Size = new System.Drawing.Size(125, 22);
            this.sOLUONGTONTextEdit.TabIndex = 7;
            // 
            // dVTTextEdit
            // 
            this.dVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "DVT", true));
            this.dVTTextEdit.Location = new System.Drawing.Point(628, 24);
            this.dVTTextEdit.MenuManager = this.barManager;
            this.dVTTextEdit.Name = "dVTTextEdit";
            this.dVTTextEdit.Size = new System.Drawing.Size(125, 22);
            this.dVTTextEdit.TabIndex = 5;
            // 
            // tENVTTextEdit
            // 
            this.tENVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "TENVT", true));
            this.tENVTTextEdit.Location = new System.Drawing.Point(361, 24);
            this.tENVTTextEdit.MenuManager = this.barManager;
            this.tENVTTextEdit.Name = "tENVTTextEdit";
            this.tENVTTextEdit.Size = new System.Drawing.Size(125, 22);
            this.tENVTTextEdit.TabIndex = 3;
            // 
            // mAVTTextEdit
            // 
            this.mAVTTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsVatTu, "MAVT", true));
            this.mAVTTextEdit.Location = new System.Drawing.Point(119, 24);
            this.mAVTTextEdit.MenuManager = this.barManager;
            this.mAVTTextEdit.Name = "mAVTTextEdit";
            this.mAVTTextEdit.Size = new System.Drawing.Size(125, 22);
            this.mAVTTextEdit.TabIndex = 1;
            // 
            // bdsCTPN
            // 
            this.bdsCTPN.DataMember = "FK_CTPN_VatTu";
            this.bdsCTPN.DataSource = this.bdsVatTu;
            // 
            // bdsCTPX
            // 
            this.bdsCTPX.DataMember = "FK_CTPX_VatTu";
            this.bdsCTPX.DataSource = this.bdsVatTu;
            // 
            // bdsCTDDH
            // 
            this.bdsCTDDH.DataMember = "FK_CTDDH_VatTu";
            this.bdsCTDDH.DataSource = this.bdsVatTu;
            // 
            // FormVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 606);
            this.Controls.Add(this.panelControlNhapLieuVatTu);
            this.Controls.Add(this.vattuGridControl);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormVatTu";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormVatTu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vattuGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlNhapLieuVatTu)).EndInit();
            this.panelControlNhapLieuVatTu.ResumeLayout(false);
            this.panelControlNhapLieuVatTu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sOLUONGTONTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tENVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mAVTTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsCTDDH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnThemVT;
        private DevExpress.XtraBars.BarButtonItem btnXoaVT;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinhVT;
        private DevExpress.XtraBars.BarButtonItem btnGhiVT;
        private DevExpress.XtraBars.BarButtonItem btnPhucHoiVT;
        private DevExpress.XtraBars.BarButtonItem btnReloadVT;
        private DevExpress.XtraBars.BarButtonItem btnThoatNV;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnHieuChinh;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.BarButtonItem btnThoatVT;
        private System.Windows.Forms.BindingSource bdsVatTu;
        private DS DS;
        private DSTableAdapters.VattuTableAdapter vatTuTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl vattuGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControlNhapLieuVatTu;
        private DevExpress.XtraEditors.TextEdit dVTTextEdit;
        private DevExpress.XtraEditors.TextEdit tENVTTextEdit;
        private DevExpress.XtraEditors.TextEdit mAVTTextEdit;
        private DevExpress.XtraGrid.Columns.GridColumn MAVT;
        private DevExpress.XtraGrid.Columns.GridColumn TENVT;
        private DevExpress.XtraGrid.Columns.GridColumn DVT;
        private DevExpress.XtraGrid.Columns.GridColumn SOLUONGTON;
        private DSTableAdapters.CTPNTableAdapter ctpnTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPN;
        private DSTableAdapters.CTPXTableAdapter ctpxTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTPX;
        private DSTableAdapters.CTDDHTableAdapter ctddhTableAdapter;
        private System.Windows.Forms.BindingSource bdsCTDDH;
        private DevExpress.XtraEditors.TextEdit sOLUONGTONTextEdit;
    }
}