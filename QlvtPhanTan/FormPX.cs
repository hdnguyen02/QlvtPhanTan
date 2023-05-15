using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormPX : DevExpress.XtraEditors.XtraForm
    {
        bool dangThemMoi = false;
        int viTri; 
        public FormPX()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPX.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormPX_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;


            this.vattuTableAdapter.Connection.ConnectionString = Program.connectStr;


           

            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);

            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.khoTableAdapter.Fill(this.DS.Kho);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);


            this.CTPXTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.CTPXTableAdapter.Fill(this.DS.CTPX);


            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;  // chi nhánh mà nhân viên đó chọn vào.

            if (Program.role == "CONGTY")
            {

                btnThemPX.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = btnPhucHoi.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }

       

        private void cmbKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maKhoTextEdit.Text = cmbKho.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void cmbNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maNVTextEdit.Text = cmbNV.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
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

            this.vattuTableAdapter.Connection.ConnectionString = Program.connectStr;




            this.vattuTableAdapter.Fill(this.DS.Vattu);

            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);

            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.khoTableAdapter.Fill(this.DS.Kho);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);


            this.CTPXTableAdapter.Connection.ConnectionString = Program.connectStr;

            this.CTPXTableAdapter.Fill(this.DS.CTPX);
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose(); 
        }

        private void btnThemPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true;
            viTri = bdsPX.Position;
            bdsPX.AddNew();
 
           

            ngayDateEdit.DateTime = DateTime.Now;


            

          



            panelNhapLieuPX.Enabled = true;  // chỉ cho nó chọn các đơn hàng đó thôi. 

            phieuXuatGridControl.Enabled = false;
            btnThemPX.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            maPXTextEdit.Enabled = true;
            ngayDateEdit.Enabled = true;

        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép hiệu chỉnh", "", MessageBoxButtons.OK);
                return;
            }
            // bật cái panel lên 
            panelNhapLieuPX.Enabled = true; // tiếp cho phép hiệu chỉnh 
            phieuXuatGridControl.Enabled = false;
            btnThemPX.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnPhucHoi.Enabled = true;
            maPXTextEdit.Enabled = false;
            ngayDateEdit.Enabled = false;
          
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ngayDateEdit.DateTime > DateTime.Now)
            {
                MessageBox.Show("Ngày lập phiếu nhập không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }

            // kiem tra ho ten co ton tai chu so hay khong. 
            if (Regex.IsMatch(hOTENKHTextEdit.Text, @"^[A-Za-z ]+$") == false)
            {
                MessageBox.Show("Họ tên khách hàng chỉ có chữ cái và khoảng trắng", "", MessageBoxButtons.OK);
                return; 
            }

            try
            {

                if (dangThemMoi)
                {
                    dangThemMoi = false;
                    string strLenh = "declare @result int exec @result = spKiemTraMaPhieuXuat '" + maPXTextEdit.Text + "' select @result";

                    Program.myReader = Program.ExecSqlDataReader(strLenh);
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Mã phiếu xuất đã được sử dụng! Vui lòng chọn mã kho khác");
                    }

                }

                bdsPX.EndEdit();
                bdsPX.ResetCurrentItem();
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi phiếu xuất\n" + ex.Message, "", MessageBoxButtons.OK);
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                bdsPX.Position = viTri;
            }

            panelNhapLieuPX.Enabled = false;
            phieuXuatGridControl.Enabled = true;
            btnThemPX.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }
        

        // reload 2 bds. 

        private void reload()
        {
            try
            {
                viTri = bdsPX.Position;
                this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                this.CTPXTableAdapter.Fill(this.DS.CTPX);
                bdsPX.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }


        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload(); 
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ngayDateEdit.DateTime != DateTime.Now.Date)
            {
                MessageBox.Show("Không được phép hiệu chỉnh", "", MessageBoxButtons.OK);
                return;
            }

         


            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa phiếu xuất đã lập chi tiết phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực muốn xóa phiếu nhập này không ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                String msPXXoa = ((DataRowView)bdsPX[bdsPX.Position])["MAPX"].ToString();
                try
                {
                    bdsPX.RemoveCurrent();
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.phieuXuatTableAdapter.Update(this.DS.PhieuXuat);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa phiếu xuất. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
                    bdsPX.Position = bdsPX.Find("MAPX", msPXXoa);
                    return;
                }
            }

            if (bdsPX.Count == 0) btnXoa.Enabled = false;
        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi)
            {
                dangThemMoi = false;
                reload();
            }
            bdsPX.CancelEdit();
           

            panelNhapLieuPX.Enabled = false;
            phieuXuatGridControl.Enabled = true;

            btnThemPX.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnPhucHoi.Enabled = false;
        }
    }
}