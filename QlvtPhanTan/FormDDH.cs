using System;
using System.Data;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormDDH : DevExpress.XtraEditors.XtraForm
    {
        int viTri;
        bool dangThemMoi = false; 

        public FormDDH()
        {
            InitializeComponent();


        }

        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDDH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormDDH_Load(object sender, EventArgs e)
        {


            DS.EnforceConstraints = false;
            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);
            this.khoTableAdapter.Fill(this.DS.Kho);
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);


            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;  // chi nhánh mà nhân viên đó chọn vào.

            if (Program.role == "CONGTY")
            {
  
                btnThemDDH.Enabled = btnXoaDDH.Enabled = btnHieuChinhDDH.Enabled = btnGhiDDH.Enabled = btnPhucHoiDDH.Enabled = false;
            }
            else // với nhân viên hoặc chi nhánh được toàn quyền trên này. nhưng không được log sang chi nhánh khác. 
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void btnSuaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDDH.Position;
            panelNhapLieuDDH.Enabled = true;
            datHangGridControl.Enabled = false;
            masoDDHTextEdit.Enabled = false;   // sau khi bấm ghi -> hoàn tất thì sữa lại thành true. 

            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = btnReloadDDH.Enabled = btnThoatNV.Enabled = false;
            btnPhucHoiDDH.Enabled = btnGhiDDH.Enabled = true;
        }




        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MANVTextBox.Text = cmbNV.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                MAKHOTextEdit.Text = cmbKho.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

        }

        private void btnThemCTDDH_Click(object sender, EventArgs e)
        {
            btnReloadDDH.Enabled = btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = false;
            panelNhapLieuCTDDH.Enabled = true;

            bdsCTDDH.AddNew();
            maSoDDHCT.Text = masoDDHTextEdit.Text;

            btnThemCTDDH.Enabled = btnXoaVT.Enabled = suaVT.Enabled = false;
            btnGhiVatTu.Enabled = btnPhucHoiVT.Enabled = true;



        }

        private void btnThemDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true; 
            masoDDHTextEdit.Enabled = true;
            viTri = bdsDDH.Position;
            this.panelNhapLieuDDH.Enabled = true;
            bdsDDH.AddNew();
            nGAYDateEdit.DateTime = DateTime.Now; 
            datHangGridControl.Enabled = false;
            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = btnReloadDDH.Enabled = btnThoatDDH.Enabled = false;
            btnPhucHoiDDH.Enabled = btnGhiDDH.Enabled = true;
        }

        private void btnPhucHoiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi)
            {
                dangThemMoi = false;
            }
            bdsDDH.CancelEdit();
            if (btnThemDDH.Enabled == false) {
                reloadBdsDDH();
            }
            else masoDDHTextEdit.Enabled = true;


            panelNhapLieuDDH.Enabled = false;
            datHangGridControl.Enabled = true;

            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = btnReloadDDH.Enabled = btnThoatDDH.Enabled = true;
            btnPhucHoiDDH.Enabled = btnGhiDDH.Enabled = false;
        }

        private void btnThoatDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }


        private void reloadBdsDDH()
        {

            try
            {
                viTri = bdsDDH.Position;
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
                bdsDDH.Position = viTri;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnReloadDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reloadBdsDDH();
        }

        private void btnGhiDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // bắc ngoài lệ
            if (nGAYDateEdit.DateTime > DateTime.Now)
            {
                MessageBox.Show("Ngày lập đơn không hợp lệ", "", MessageBoxButtons.OK);
                return; 
            }

            
            try
            { 
                if (dangThemMoi)
                {
                    dangThemMoi = false;
                    string strLenh = "declare @result int exec @result = spKiemTraMaDonDatHang '" + masoDDHTextEdit.Text + "' select @result";
             
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Mã đơn đặt hàng đã được sử dụng! Vui lòng chọn mã kho khác");
                    }

                }

                bdsDDH.EndEdit();
                bdsDDH.ResetCurrentItem();
                this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.datHangTableAdapter.Update(this.DS.DatHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi đơn đặt hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                this.datHangTableAdapter.Fill(this.DS.DatHang);
                bdsDDH.Position = viTri;
            }
            masoDDHTextEdit.Enabled = true;
            panelNhapLieuDDH.Enabled = false;
            datHangGridControl.Enabled = true;
            btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = btnReloadDDH.Enabled = btnThoatDDH.Enabled = true;
            btnPhucHoiDDH.Enabled = btnGhiDDH.Enabled = false;
        }


        private void btnXoaDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // một ddh được xóa khi chưa có phiếu nhập và chưa tạo phiếu nhập 
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa đơn đặt hàng đã lập chi tiết đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực muốn xóa đơn đặt hàng này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String maDDHXoa = ((DataRowView)bdsDDH[bdsDDH.Position])["MaSoDDH"].ToString();
                try
                {
                    bdsDDH.RemoveCurrent();
                    this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.datHangTableAdapter.Update(this.DS.DatHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa hóa đơn. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.datHangTableAdapter.Fill(this.DS.DatHang);
                    bdsDDH.Position = bdsDDH.Find("MaSoDDH", maDDHXoa);
                    return;
                }
            }

            if (bdsDDH.Count == 0) btnXoaDDH.Enabled = false;

        }

        private void btnGhiVatTu_Click(object sender, EventArgs e)
        {


            try
            {
                bdsCTDDH.EndEdit();
                bdsCTDDH.ResetCurrentItem();
                this.CTDDHTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.CTDDHTableAdapter.Update(this.DS.CTDDH);



            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi chi tiết đơn đặt hàng\n" + ex.Message, "", MessageBoxButtons.OK);
                this.CTDDHTableAdapter.Fill(this.DS.CTDDH);
            }

            panelNhapLieuCTDDH.Enabled = false;
            btnThemCTDDH.Enabled = btnXoaVT.Enabled = suaVT.Enabled = true;
            btnGhiVatTu.Enabled = btnPhucHoiVT.Enabled = false;
            btnReloadDDH.Enabled = btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = true;

        }

        private void panelNhapLieuDDH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNhapLieuCTDDH_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbVT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maVTTextEdit.Text = cmbVT.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void mAVTLabel_Click(object sender, EventArgs e)
        {

        }

        private void nhaCCLabel_Click(object sender, EventArgs e)
        {

        }


        private void suaVT_Click(object sender, EventArgs e)
        {
            if (DDHDaLapPhieuNhap())  // nếu đã lập phiếu nhập rồi thì không chỉnh sữa hay xóa gì cả. 
            {
                MessageBox.Show("Không thao tác với đơn hàng đã lập phiếu nhập\n", "", MessageBoxButtons.OK);
                return;
            }
            panelNhapLieuCTDDH.Enabled = true;
            btnReloadDDH.Enabled = btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = false;

            btnThemCTDDH.Enabled = btnXoaVT.Enabled = suaVT.Enabled = false;
            btnGhiVatTu.Enabled = btnPhucHoiVT.Enabled = true;
        }

        private bool DDHDaLapPhieuNhap()
        {
            if (bdsPN.Count != 0) // đã lập phiếu nhập rồi. 
            {
                return true;
            }
            return false;
        }



        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            // xóa đi vật tư đang đứng hiện tại. 
            // thống nhất như này. trước khi sữa - thêm - xóa 1 cái gì đó trên phiếu nhập 
            // nếu như đơn hàng này đã lập phiếu nhập. 
            // viết 1 hàm kiểm tra xem đã lập phiếu nhập chưa 
            if (DDHDaLapPhieuNhap())  // nếu đã lập phiếu nhập rồi thì không chỉnh sữa hay xóa gì cả. 
            {
                MessageBox.Show("Không chỉnh sữa với đơn hàng đã lập phiếu nhập\n", "", MessageBoxButtons.OK);
                return;
            }

            // nếu không ấy thì xóa. 
            if (MessageBox.Show("Bạn có thực muốn xóa chi tiết đơn đặt hàng này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsCTDDH.RemoveCurrent();
                    this.CTDDHTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.CTDDHTableAdapter.Update(this.DS.CTDDH);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết đơn đặt hàng. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

                    return;
                }
            }

        }  

        private void btnPhucHoiVT_Click(object sender, EventArgs e)
        {
            bdsCTDDH.CancelEdit();
            reloadBdsDDH();
            panelNhapLieuCTDDH.Enabled = false;
            CTDDHDataGridView.Enabled = true;

            btnThemCTDDH.Enabled = btnXoaVT.Enabled = suaVT.Enabled = true;
            btnGhiVatTu.Enabled = btnPhucHoiVT.Enabled = false;

            btnReloadDDH.Enabled = btnThemDDH.Enabled = btnXoaDDH.Enabled = btnSuaDDH.Enabled = true;
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  rẻ sang server khác. 
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            int selectIndex = this.cmbChiNhanh.SelectedIndex;
            Program.servername = this.cmbChiNhanh.SelectedValue.ToString();


            if (selectIndex == Program.chiNhanh)
            {
                Program.loginName = Program.loginNameType;
                Program.password = Program.passwordType;
            }

            else // người dùng chọn sang chi nhánh khác. 
            {
                Program.loginName = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CTDDHTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.vattuTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);
            this.khoTableAdapter.Fill(this.DS.Kho);
            this.vattuTableAdapter.Fill(this.DS.Vattu);
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.CTDDHTableAdapter.Fill(this.DS.CTDDH);

            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);


        }
    }
}