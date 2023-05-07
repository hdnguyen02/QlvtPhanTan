
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string maCN = "";
        int viTri = 0;
  
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

       
            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh; 
            this.showAndHiddenBtn();
        }

        private void showAndHiddenBtn()  // có chức năng ẩn hiện các button
        {
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true; 
                btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnGhiNV.Enabled = btnPhucHoiNV.Enabled = false;
            } 
            else 
            {
                cmbChiNhanh.Enabled = false;
            }
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.viTri = bdsNhanVien.Position;   
            this.panelNhapLieuNV.Enabled = true; 
            maNVTextBox.Enabled = true;
            bdsNhanVien.AddNew();
            maCNTextBox.Text = maCN;
            nhanVienGridControl.Enabled = false;  
            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = false; 
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = true;
            this.trangThaiXoaCheckEdit.Checked = false;
   
            
            
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }


        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView") return;
            int selectIndex = this.cmbChiNhanh.SelectedIndex;
            Program.servername = this.cmbChiNhanh.SelectedValue.ToString();
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



        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (btnThemNV.Enabled == false) // đang thêm nhân viên
            {
              
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
                    MessageBox.Show("Mã nhân viên đã được sử dụng", "", MessageBoxButtons.OK);
                    return;  // 
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
            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = true;
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
           
            btnThemNV.Enabled = btnXoaNV.Enabled = btnSuaNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = true;
            btnPhucHoiNV.Enabled = btnGhiNV.Enabled = false;
      
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
    }
}