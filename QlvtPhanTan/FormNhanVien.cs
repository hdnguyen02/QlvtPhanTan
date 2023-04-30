
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        string maCN = "";

        int viTri = 0; //  phục vụ cho việc undo -> trước khi thêm mới 1 thằng dữ lại vị trí thằng đang đứng trước đó
        // tí nữa nhấp nút undo -> trả về vị trí đó 

        bool dangThemMoi = false;

        // Lưu danh sách lệnh -> phục vụ công việc undo 
        Stack stackLenh = new Stack();   // lưu danh sách các leenhjj 




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
            
            // tồn tại lỗi tại chỗ này. 
            this.maCN = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();  // vẫn có xác xuất lỗi 

       
            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh; 
            this.showAndHiddenBtn(); 

            //

        }

        // viêt hàm phân quyền  

        private void showAndHiddenBtn()  // có chức năng ẩn hiện các button
        {
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                this.btnThemNV.Enabled = false;
                this.btnXoaNV.Enabled = false;
                this.btnGhiNV.Enabled = false;
                this.btnPhucHoiNV.Enabled = false;
                this.btnReloadNV.Enabled = false;
            } 
            // nếu la role chi nhánh hoặc user.
            else
            {
                cmbChiNhanh.Enabled = false;
                this.btnThemNV.Enabled = true;
                this.btnXoaNV.Enabled = true; 
                this.btnReloadNV.Enabled = true; 
               
            }
            
            

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.viTri = bdsNhanVien.Position;   
            this.panelNhapLieuNV.Enabled = true; 
            bdsNhanVien.AddNew();
            maCNTextBox.Text = maCN;

            nhanVienGridControl.Enabled = false;   // truong hop them moi. 

            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = false; 
            btnGhiNV.Enabled = btnPhucHoiNV.Enabled = true;
        
            this.trangThaiXoaCheckEdit.Checked = false; 


            // có 2 khái niệm: gridController -> liên quan khi đưa dữ liệu vào, grid view -> liên quan đến format 

        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void textEditLuong_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControlAddNV_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)


        {

            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
            {
                Console.WriteLine("no loading"); 
                return;

            }
            int selectIndex = this.cmbChiNhanh.SelectedIndex;

            Program.servername = this.cmbChiNhanh.SelectedValue.ToString();
            Console.WriteLine(Program.servername); 

            if (selectIndex == Program.chiNhanh)  // Chi nhánh của tài khoản công ty.  
            {
                // khi đổi sang chi nhánh khác.  
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

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // có 2 trường hợp.
            // trường hợp người dùng thêm mới vào  


            // chuẩn hóa dữ liệu trênf này !

            // ghi dữ liệu vào 
            bdsNhanVien.EndEdit(); 


            /*DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);


            // lấy ra tất cả 
            *//*  String maNhanVien = *//*
            String maNV = drv["MANV"].ToString();
            String ho = drv["HO"].ToString();
            String ten = drv["TEN"].ToString();
            String diaChi = drv["DIACHI"].ToString();
            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);
            int luong = int.Parse(drv["LUONG"].ToString()); 
         





            // log tat ca ra 
            Console.WriteLine(maNV + " maNV");
            Console.WriteLine(ho + " ho");
            Console.WriteLine(ten + " ten");
            Console.WriteLine(diaChi + " diaChi");
            Console.WriteLine(ngaySinh.ToString() + "ngaySinh");
            Console.WriteLine(luong + " luong"); 

            if (this.dangThemMoi == true) {
         
                this.dangThemMoi = false;  //  đánh dấu không còn thêm mới. 

                // chưa tính tới bước hoàn tất -> bây giờ cứ thêm vào. 
                // DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);

                // thử in ra vị trí hiện tại đang đứng có phải là cái thằng đang thêm không 
              *//*  // thử lấy ra thông tin đã thêm 
                DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);*//*







            }*/
        }




        private void btnPhucHoiNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // giả sử trường hợp đang thêm vào đi 
            bdsNhanVien.CancelEdit();

            // gặp phải 2 trường hợp: thêm -> undo thêm, sữa -> undo sữa 

            if (btnThemNV.Enabled == false) bdsNhanVien.Position = viTri;

            panelNhapLieuNV.Enabled = false;
            nhanVienGridControl.Enabled = true;
           
            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = true;
            btnPhucHoiNV.Enabled = btnGhiNV.Enabled = false; 
        }

        private void btnHieuChinhNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhanVien.Position;
            panelNhapLieuNV.Enabled = true;
            nhanVienGridControl.Enabled = false;

            btnThemNV.Enabled = btnXoaNV.Enabled = btnHieuChinhNV.Enabled = btnReloadNV.Enabled = btnThoatNV.Enabled = false;
            btnPhucHoiNV.Enabled = btnGhiNV.Enabled = true; 

        

        }

        private void btnReloadNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // tải lại dữ liệu
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return; 
            }
        }

        private void btnXoaNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // ví dụ ta sẽ xóa đi 1 thằng thử đi. 
            // ví dụ xóa với tk nhân viên số 1 đi


           


   
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




        }
    }
}