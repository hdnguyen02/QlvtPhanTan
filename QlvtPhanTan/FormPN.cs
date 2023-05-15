using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormPN : DevExpress.XtraEditors.XtraForm
    {

        int viTri;

        // tí nữa sữa thì sữa như nào. 
        // xóa thì - đi.
        bool dangThemMoi = false;

        DataTable vtpn; // khai báo để đây và sử dụng chung trong form.

        int slvtctddh; // sử dụng để chứa số lượng vật tư của chi tiết đơn đặt hàng 
        int slvtpnCu; // chứa số lượng vtpn cũ trước khi chưa chỉnh sữa. 

        public FormPN()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void FormPN_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.Vattu' table. You can move, or remove it, as needed.
           

            DS.EnforceConstraints = false;


            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);


            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr; 
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);

            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;  // chi nhánh mà nhân viên đó chọn vào.

            if (Program.role == "CONGTY")
            {

                btnThemPN.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else 
            {
                cmbChiNhanh.Enabled = false;
            }



        }

      

        private void CTPNDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // trước tiên cần kiểm tra xem phiếu nhập có được xóa hay không đã.  
            // khác ngày là không cho xóa 
            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép hiệu chỉnh", "", MessageBoxButtons.OK);
                return;
            }

            // xóa đi.

            // với thêm chi tiết hóa đơn cũng vậy. chỉ được quyền vào chi tiết hóa đơn trong ngày hôm đó thôi.  

            // thao tác xóa đi. trước tiên cần kiểm tra xem đã quá hạng ngày chưa. 

           
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu nhập đã lập chi tiết phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực muốn xóa phiếu nhập này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String msPNXoa = ((DataRowView)bdsPN[bdsPN.Position])["MAPN"].ToString();

                // xóa cái này không liên quan. 
                try
                {
                    bdsPN.RemoveCurrent();
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu nhập. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                    bdsPN.Position = bdsPN.Find("MAPN", msPNXoa);
                    return;
                }
            }

            if (bdsPN.Count == 0) btnXoa.Enabled = false;

        }

      

        private void btnThemPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            viTri = bdsPN.Position;
            bdsPN.AddNew();
            cmbMaSoDDH.Visible = true;
            masoDDHTextEdit.Visible = false;

            ngayDateEdit.DateTime = DateTime.Now; 

    
            string strlenh = "EXEC spDDHChuaLapPN";

            DataTable dt = Program.ExecSqlDataTable(strlenh);
         

            BindingSource bdsDDH = new BindingSource();
            bdsDDH.DataSource = dt;

            cmbMaSoDDH.DataSource = bdsDDH;
     
            cmbMaSoDDH.DisplayMember = "MasoDDH";
            cmbMaSoDDH.ValueMember = "MasoDDH";
            cmbMaSoDDH.SelectedIndex = -1; // không chọn mã số đơn hàng nào. 

      

            panelNhapLieuPN.Enabled = true;  // chỉ cho nó chọn các đơn hàng đó thôi. 

            phieuNhapGridControl.Enabled = false;
            btnThemPN.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            maPNTextEdit.Enabled = true;
            ngayDateEdit.Enabled = true;
            masoDDHTextEdit.Enabled = true;


        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maNVTextEdit.Text = cmbNhanVien.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maKhoTextEdit.Text = cmbKho.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ngayDateEdit.DateTime > DateTime.Now)
            {
                MessageBox.Show("Ngày lập phiếu nhập không hợp lệ", "", MessageBoxButtons.OK);
                return; 
            }
            
            try
            {

                if (dangThemMoi)
                {
                    dangThemMoi = false;
                    string strLenh = "declare @result int exec @result = spKiemTraMaPhieuNhap '" + maPNTextEdit.Text + "' select @result";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Mã phiếu xuất đã được sử dụng! Vui lòng chọn mã kho khác");
                    }

                }

                bdsPN.EndEdit();
                bdsPN.ResetCurrentItem();
                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.phieuNhapTableAdapter.Update(this.DS.PhieuNhap);

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi phiếu nhập\n" + ex.Message, "", MessageBoxButtons.OK);
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                bdsPN.Position = viTri;
            }

            panelNhapLieuPN.Enabled = false;
            phieuNhapGridControl.Enabled = true;
            btnThemPN.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void cmbMaSoDDH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
                {
                if (cmbMaSoDDH.SelectedValue.ToString() == "System.Data.DataRowView") return;
                masoDDHTextEdit.Text = cmbMaSoDDH.SelectedValue.ToString();
                    Console.WriteLine(masoDDHTextEdit.Text + " da gan duoc roi ne");
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
   
        }

  

        private void reloadBdsPN()
        {

            try
            {
                viTri = bdsPN.Position; 
                this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
                this.CTPNTableAdapter.Fill(this.DS.CTPN);  
                bdsPN.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }


        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // phục hồi không chính sữa edit gì hết. 
            if(dangThemMoi)
            {
                dangThemMoi = false; 
            }
            bdsPN.CancelEdit();
            if (btnThemPN.Enabled == false)
            {
                reloadBdsPN();
            }
         
            panelNhapLieuPN.Enabled = false;
            phieuNhapGridControl.Enabled = true;

            btnThemPN.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close(); 
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

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
            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.vattuTableAdapter.Fill(this.DS.Vattu);


            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            this.CTPNTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.CTPNTableAdapter.Fill(this.DS.CTPN);



        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép hiệu chỉnh","",MessageBoxButtons.OK);
                return; 
            }
            // bật cái panel lên 
            panelNhapLieuPN.Enabled = true; // tiếp cho phép hiệu chỉnh 
            phieuNhapGridControl.Enabled = false;
            btnThemPN.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            maPNTextEdit.Enabled = false;
            ngayDateEdit.Enabled = false;
            masoDDHTextEdit.Enabled = false; 
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reloadBdsPN(); 
        }

        private void btnThemVT_Click(object sender, EventArgs e)
        {
            // tại bước này tiến lấy ra các chi tiết vật tư. và trước tiên vẫn phải kiểm tra xem đơn hàng có phải của ngày hôm nay không đã 
            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép thao tác", "", MessageBoxButtons.OK);
                return;
            }

            dangThemMoi = true;
            cmbVT.Visible = true; 

            bdsCTPN.AddNew();
            maPN.Text = maPNTextEdit.Text; 

            panelNhapLieuCTPN.Enabled = true;
            maPN.Enabled = false;
            maPN.Text = maPNTextEdit.Text; 
           
            string strLenh = "EXEC spLayVTPN '" + maPN.Text + "'" + ",'" + masoDDHTextEdit.Text + "'";
            vtpn = Program.ExecSqlDataTable(strLenh);
            BindingSource bdsVTPN = new BindingSource();
            bdsVTPN.DataSource = vtpn;
            cmbVT.DataSource = bdsVTPN;
            cmbVT.DisplayMember = "TENVT";
            cmbVT.ValueMember = "MAVT";
            cmbVT.SelectedIndex = -1;

            // xóa tất cả. 
            donGiaTextEdit.Clear();
            SLTextEdit.Clear();
            maVTTextEdit.Clear(); 

            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = true;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = false;
            btnThemPN.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false; 


            
        }

        private void cmbVT_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cmbVT.SelectedValue.ToString() == "System.Data.DataRowView") return;

       
                DataRowCollection rows = vtpn.Rows;
                maVTTextEdit.Text = (string)rows[cmbVT.SelectedIndex]["MAVT"];
                int sl = (int)rows[cmbVT.SelectedIndex]["SOLUONG"];
                double donGia = (double)rows[cmbVT.SelectedIndex]["DONGIA"];
                SLTextEdit.Text = sl.ToString();
                donGiaTextEdit.Text = donGia.ToString();
            }
            catch(Exception ex) { Console.WriteLine(ex.Message); }
           
            // làm sao có thể lấy ra giá trị tương ứng. 

         


        }

        // viêt 1 hàm chuẩn hóa dữ liệu đầu vào.  
       


        private void btnGhiVT_Click(object sender, EventArgs e)
        {
            try
            {
                if (dangThemMoi)
                {
                    dangThemMoi = false;
                  
                    DataRowCollection rows = vtpn.Rows; 
                    int slctddh = (int)rows[cmbVT.SelectedIndex]["SOLUONG"];
                    int slpn = int.Parse(SLTextEdit.Text.ToString());
                    // so sánh tại chỗ này. 
                    if (slctddh < slpn)
                    {
                        throw new Exception("Số lượng vật tư phiếu nhập không được phép lớn hơn số lượng vật tư chi tiết đặt hàng");
                    }
                    string strLenh = "DECLARE @RESULT INT EXEC @RESULT = spNhapVT '" + maVTTextEdit.Text + "','" + slpn.ToString() + "' " + "SELECT 'result'=@RESULT"; ;
                    
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
      
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close(); 

                    if (result == 0)
                    {
                        throw new Exception("Sảy ra lỗi trong quá trình thêm cập nhập số lượng tồn");
                    }
               

                }
                else // trường hợp người dùng sữa. sử lý tại chỗ này. 
                {
                    // trước tiên cần kiểm tra xem số lượng vừa chỉnh sữa so với hiện tại thế nào
                 
                    int slvtpnSau = int.Parse(SLTextEdit.Text.ToString()); 
                    if (slvtctddh < slvtpnSau)
                    {
                        throw new Exception("Số lượng vật tư phiếu nhập không được phép lớn hơn số lượng vật tư chi tiết đặt hàng");
                    }

                    // in ra hết đi.
                    Console.WriteLine(slvtpnSau.ToString() + " slvtpnSau");
                    Console.WriteLine(slvtpnCu.ToString() + " slvtpnCu");

                    if (slvtpnSau > slvtpnCu)
                    {
                        // cộng thêm vào kho hàng.
                        int temp = slvtpnSau - slvtpnCu;

                        string strLenh = "DECLARE @RESULT INT EXEC @RESULT = spNhapVT '" + maVTTextEdit.Text + "','" + temp.ToString() + "' " + "SELECT 'result'=@RESULT"; ;
                        Console.WriteLine(strLenh);
                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        Program.myReader.Read();

                        int result = int.Parse(Program.myReader.GetValue(0).ToString());
                        Program.myReader.Close();

                        if (result == 0)
                        {
                            throw new Exception("Sảy ra lỗi trong quá trình thêm cập nhập số lượng tồn");
                        }




                    }
                    else if (slvtpnCu > slvtpnSau) // nhân viên đã giảm đi số lượng, 
                    {
                        // giải đi số lượng 
                        int temp = slvtpnCu - slvtpnSau;

                        string strLenh = "DECLARE @RESULT INT EXEC @RESULT = spXuatVT '" + maVTTextEdit.Text + "','" + temp.ToString() + "' " + "SELECT 'result'=@RESULT"; ;
                        Console.WriteLine(strLenh);
                        Program.myReader = Program.ExecSqlDataReader(strLenh);
                        Program.myReader.Read();

                        int result = int.Parse(Program.myReader.GetValue(0).ToString());
                        Program.myReader.Close();

                        if (result == 0)
                        {
                            throw new Exception("Sảy ra lỗi trong quá trình thêm cập nhập số lượng tồn");
                        }

                    }
                  


                }
                bdsCTPN.EndEdit();
                bdsCTPN.ResetCurrentItem();
                this.CTPNTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.CTPNTableAdapter.Update(this.DS.CTPN);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi chi tiết phiếu nhập\n" + ex.Message, "", MessageBoxButtons.OK);
                this.CTPNTableAdapter.Fill(this.DS.CTPN);
  
            }

            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = true;

            btnThemPN.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = true;
            panelNhapLieuCTPN.Enabled = false;
            cmbVT.Visible = false; 
        }

        private void btnSuaVT_Click(object sender, EventArgs e)
        {
            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép thao tác", "", MessageBoxButtons.OK);
                return;
            }

            panelNhapLieuCTPN.Enabled = true;

            this.slvtpnCu = int.Parse(SLTextEdit.Text.ToString());

            // lấy ra số lượng của thằng đó luôn.
            string strLenh = "EXEC spLaySoLuongVTCTDDH" + "'" + masoDDHTextEdit.Text.ToString() + "'" + ",'" + maVTTextEdit.Text.ToString() + "'";

            Program.myReader = Program.ExecSqlDataReader(strLenh);
            Program.myReader.Read();
            this.slvtctddh = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = true;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = false;
            btnThemPN.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = false;
        }

        private void btnPhucHoiVT_Click(object sender, EventArgs e)
        {
            bdsCTPN.CancelEdit();
            reloadBdsPN();
            panelNhapLieuCTPN.Enabled = false;
            CTPNDataGridView.Enabled = true;

            btnThemPN.Enabled = btnXoa.Enabled = btnSua.Enabled = btnReload.Enabled = true;

            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnSuaVT.Enabled = true;
        }

        private void btnXoaVT_Click(object sender, EventArgs e)
        {
            // trước tiên vẫn phải kiểm tra có còn trong này hay không. 

            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép thao tác", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thực muốn xóa chi tiết đơn phiếu nhập này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {

                // trước khi xóa cần cập nhập lại số lượng vật của vật tư đó 

                // xóa đi tức là xuất hàng đi. Nếu đơn hàng về 0. thì không thể nào xóa đi cái nhập này. việt xóa sẽ mâu thuẫn. 

                

                try
                {


                    string strLenh = "DECLARE @RESULT INT EXEC @RESULT = spXuatVT '" + maVTTextEdit.Text + "','" + SLTextEdit.Text.ToString() + "' " + "SELECT 'result'=@RESULT"; ;
                    Console.WriteLine(strLenh);
                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();

                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 0)
                    {
                        throw new Exception("Sảy ra lỗi trong quá trình thêm cập nhập số lượng tồn");
                    }

                    bdsCTPN.RemoveCurrent();
                    this.CTPNTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.CTPNTableAdapter.Update(this.DS.CTPN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa chi tiết phiếu nhập. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.CTPNTableAdapter.Fill(this.DS.CTPN);
                    return;
                }
            }
        }
    }
}