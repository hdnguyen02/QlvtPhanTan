
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string maCN = "";
        int viTri = 0;
        bool dangThemMoi = false;
  
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);     
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            
            this.maCN = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();  // vẫn có xác xuất lỗi 

       
            cmbCN.DataSource = Program.bdsDspm;
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.chiNhanh; 
            this.showAndHiddenBtn();
        }

        private void showAndHiddenBtn()  // có chức năng ẩn hiện các button
        {
            if (Program.role == "CONGTY")
            {
                cmbCN.Enabled = true; 
                btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnGhiNV.Enabled = btnPhucHoiNV.Enabled = false;
            } 
            else if (Program.role == "CHINHANH")
            {
                cmbCN.Enabled = false;
                btnChuyenCN.Visibility = DevExpress.XtraBars.BarItemVisibility.Always; 
            }
            else  // role USER
            {
                cmbCN.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true; 
            this.viTri = bdsNhanVien.Position;   
            this.panelNhapLieuNV.Enabled = true; 
            maNVTextBox.Enabled = true;
            bdsNhanVien.AddNew();
            maCNTextBox.Text = maCN;
            nhanVienGridControl.Enabled = false;  
            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = btnChuyenCN.Enabled = false; 
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = true;
            this.trangThaiXoaCheckEdit.Checked = false;
   
            
            
        }




        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(dauVaoHopLe() == false){
                return;
            }

            if (dangThemMoi) // đang thêm nhân viên. lúc đó thằng đó cũng thêm nhân viên. 
            {
                dangThemMoi = false; 
                String cauTruyVan =
                    "DECLARE @result int " +
                    "EXEC @result = [dbo].[spTraCuuMaNhanVien] '" +
                     maNVTextBox.Text + "' " + "SELECT 'Value' = @result";
                SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.connect);

               try
               {
                    Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kiểm tra mã nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                    
                }
                Program.myReader.Read();
                int result = int.Parse(Program.myReader.GetValue(0). ToString());
                Program.myReader.Close();
                if (result == 1)
                {
                    dangThemMoi = true;
                    MessageBox.Show("Mã nhân viên đã được sử dụng", "", MessageBoxButtons.OK);
                    return;  
                }

    
            }
            try
            {
                bdsNhanVien.EndEdit();
                bdsNhanVien.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien); 
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi Ghi nhân viên\n" + ex.Message, "", MessageBoxButtons.OK);
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                bdsNhanVien.Position = viTri;
            }
            panelNhapLieuNV.Enabled = false;
            nhanVienGridControl.Enabled = true;
            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = btnChuyenCN.Enabled = true;
            btnPhucHoiNV.Enabled = btnGhiNV.Enabled = false; 
        }

        // viết 1 hàm reload dùng ở 2 nơi 
        private void reloadBdsNhanvien()
        {
            viTri = bdsNhanVien.Position;
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                bdsNhanVien.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }


        private void btnPhucHoiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        { 
            bdsNhanVien.CancelEdit();
            if (btnThemNV.Enabled == false)  // đang thêm mới. 
            {
                bdsNhanVien.Position = viTri;
     
                reloadBdsNhanvien(); 
            } 

            panelNhapLieuNV.Enabled = false;
            nhanVienGridControl.Enabled = true;
           
            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = btnChuyenCN.Enabled = true;
            btnPhucHoiNV.Enabled = btnGhiNV.Enabled = false;
      
        }


        private bool dauVaoHopLe()
        {
            if (Regex.IsMatch(hoTextBox.Text, @"^[\p{L} ]+$") == false)
            {
                MessageBox.Show("Họ nhân viên chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                return false;
            }
            if (Regex.IsMatch(tenTextBox.Text, @"^[\p{L} ]+$") == false)
            {
                MessageBox.Show("Tên nhân viên chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                return false;
            }
            if (Regex.IsMatch(soCMNDTextBox.Text, @"^\d+$") == false){
                MessageBox.Show("Số cmnd chỉ bao gồm số", "", MessageBoxButtons.OK);
                return false;
            }
            // ngày sinh bé hơn ngày hiện tại 
            if (ngaySinhTextBox.DateTime >= DateTime.Now.Date)
            {
                MessageBox.Show("Ngày sinh không hợp lệ", "", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }



        private void btnReloadNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maNVTextBox.Enabled = true;
            reloadBdsNhanvien(); 
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDatHang.Count > 0)
            {
                // viết 1 hàm tiện ích show ra lỗi đi.  
                MessageBox.Show("Không thể xóa nhân viên vì đã lập đơn đặt hàng", "", MessageBoxButtons.OK);
                return; 
            }
            if (bdsPhieuNhap.Count > 0) {
                MessageBox.Show("Không thể xóa nhân viên vì đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên vì đã lập phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực muốn xóa nhân viên này ?","Xác nhận",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Int32 maNVXoa = 0;   // lưu trữ mã nhân viên khi xóa
                try
                {
                    maNVXoa = int.Parse(((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString());
                    bdsNhanVien.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr; 
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien); 
                } 
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNhanVien.Position = bdsNhanVien.Find("MANV", maNVXoa);
                    return; 
                }
            }

            if (bdsNhanVien.Count == 0) btnXoaNV.Enabled = false; 
        }

        private void btnThoatNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose(); 
        }

        private void btnSuaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            maNVTextBox.Enabled = false; 
            viTri = bdsNhanVien.Position;
            panelNhapLieuNV.Enabled = true;
            nhanVienGridControl.Enabled = false;
   

            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = false;
            btnPhucHoiNV.Enabled = btnGhiNV.Enabled = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView") return;
            int selectIndex = this.cmbCN.SelectedIndex;
            Program.servername = this.cmbCN.SelectedValue.ToString();
            Console.WriteLine(Program.servername);

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
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
        }


        public void chuyenChiNhanh(String chiNhanh)
        {
    
            if (Program.chiNhanh.Equals(chiNhanh))
            {
                MessageBox.Show("Hãy chọn chi nhánh khác chi nhánh bạn đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            String maChiNhanhMoi = "";
            int viTriHienTai = bdsNhanVien.Position;
            String maNhanVien = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();

            if (chiNhanh.Equals("1"))
            {

                maChiNhanhMoi = "CN2";
            }
            else if (chiNhanh.Equals("0"))
            {
                maChiNhanhMoi = "CN1";
            }
            else
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
          
            String cauTruyVan = "EXEC sp_ChuyenChiNhanh " + maNhanVien + ",'" + maChiNhanhMoi + "'";
            Console.WriteLine(cauTruyVan); 
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);
                Program.myReader.Close();
                    
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }

            this.reloadBdsNhanvien(); 


        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnChuyenCN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
            int viTriHienTai = bdsNhanVien.Position;
            
            string maNhanVien = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MANV"].ToString();
            bool trangThaiXoa = bool.Parse(((DataRowView)(bdsNhanVien[viTriHienTai]))["TrangThaiXoa"].ToString());

        



            if (maNhanVien == Program.userName)
            {
                MessageBox.Show("Không thể chuyển chính người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

 
           if (trangThaiXoa == true)
            {
                MessageBox.Show("Nhân viên này không có ở chi nhánh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form f = this.CheckExists(typeof(FormChuyenCN));
            if (f != null)
            {
                f.Activate();
            }
            FormChuyenCN form = new FormChuyenCN();
            form.Show();


            form.CNTransfer = new FormChuyenCN.MyDelegate(chuyenChiNhanh);


            this.btnPhucHoiNV.Enabled = true;
        }
    }
}