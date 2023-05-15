using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormKho : DevExpress.XtraEditors.XtraForm
    {

        int viTri;
        bool dangThemMoi;
        string macn; 
        public FormKho()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;

            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr; 
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);


            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;

            this.macn = ((DataRowView)bdsKho[0])["MACN"].ToString();  // vẫ

            // phân quyền 
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
                btnThem.Enabled = btnXoaKho.Enabled = btnHieuChinhKho.Enabled = btnGhiKho.Enabled = btnPhucHoiKho.Enabled = false;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }


        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dangThemMoi = true; 
            this.viTri = bdsKho.Position;
            
            bdsKho.AddNew();
            maCNTextEdit.Text = this.macn; 
     
            khoGridControl.Enabled = false;
            this.panelNhapLieuKho.Enabled = true;
            maKhoTextEdit.Enabled = true;
            btnThem.Enabled = btnXoaKho.Enabled = btnHieuChinhKho.Enabled = btnReloadKho.Enabled = btnThoatKho.Enabled = false;
            btnGhiKho.Enabled = btnPhucHoiKho.Enabled = true;
        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kiểm tra xem thằng kho này đã nằm trong chi tiết phiếu nào chưa. 
            if (bdsDH.Count > 0) 
            {
                MessageBox.Show("Không xóa kho đã lập phiếu đặt hàng", "", MessageBoxButtons.OK);
                return; 
            }
            if (bdsPN.Count > 0)
            {
                MessageBox.Show("Không xóa kho đã lập phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsPX.Count > 0)
            {
                MessageBox.Show("Không xóa kho đã lập phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có thực sự muốn xóa kho này ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maKhoXoa = ""; // lưu trữ mã nhân viên khi xóa
                try
                {
                    maKhoXoa = ((DataRowView)bdsKho[bdsKho.Position])["MAKHO"].ToString();
                    bdsKho.RemoveCurrent();
                    this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.khoTableAdapter.Update(this.DS.Kho);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa kho. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.DS.Kho);
                    bdsKho.Position = bdsKho.Find("MAKHO", maKhoXoa);
                    return;
                }
            }

            if (bdsKho.Count == 0) btnXoaKho.Enabled = false;

        }

        private void btnGhiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           

            // đã thỏa mãn, có thể ghi vào 
            try
            {
                if (dangThemMoi)
                {
                    dangThemMoi = false;

         
                    string strLenh = "DECLARE @return_value int EXEC @return_value = [dbo].[spkiemTraMaKho] @MAKHO = '" + maKhoTextEdit.Text + "' SELECT 'Return Value' = @return_value";
                    Program.myReader = Program.ExecSqlDataReader(strLenh);

                    // lấy ra giá trị. 
                    Program.myReader.Read();
                    int result = int.Parse(Program.myReader.GetValue(0).ToString());
                    Program.myReader.Close();

                    if (result == 1)
                    {
                        throw new Exception("Mã kho đã được sử dụng! Vui lòng chọn mã kho khác");
                    }

                }
                bdsKho.EndEdit();
                bdsKho.ResetCurrentItem();
                this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.khoTableAdapter.Update(this.DS.Kho);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi kho\n" + ex.Message, "", MessageBoxButtons.OK);
                this.khoTableAdapter.Fill(this.DS.Kho);
                bdsKho.Position = viTri;
    
            }
            panelNhapLieuKho.Enabled = false;
            khoGridControl.Enabled = true;
            btnThem.Enabled = btnXoaKho.Enabled = btnHieuChinhKho.Enabled = btnReloadKho.Enabled = btnThoatKho.Enabled = true;
            btnGhiKho.Enabled = btnPhucHoiKho.Enabled = false;


        }

        private void btnHieuChinhKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // không cho hiệu chỉnh mã 
            // không cho hiệu chỉnh chi nhánh.
            maKhoTextEdit.Enabled = false;
            viTri = bdsKho.Position;
            panelNhapLieuKho.Enabled = true;
            khoGridControl.Enabled = false;


            btnThem.Enabled = btnXoaKho.Enabled = btnHieuChinhKho.Enabled = btnReloadKho.Enabled = btnThoatKho.Enabled = false;
            btnGhiKho.Enabled = btnPhucHoiKho.Enabled = true;
        }

        private void reload ()
        {
            if (dangThemMoi == false)
            {
                viTri = bdsKho.Position;
            }
            
            try
            {
                this.khoTableAdapter.Fill(this.DS.Kho);
                bdsKho.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnReloadKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload(); 
        }

        private void btnPhucHoiKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi)
            {
                dangThemMoi = false; 
            }
            bdsKho.CancelEdit();
            if (dangThemMoi)  // đang thêm mới. 
            {
                dangThemMoi = false;
                reload();
                bdsKho.Position = viTri; 
            }

            panelNhapLieuKho.Enabled = false;
            khoGridControl.Enabled = true;


            btnThem.Enabled = btnXoaKho.Enabled = btnHieuChinhKho.Enabled = btnReloadKho.Enabled = btnThoatKho.Enabled = true;
            btnGhiKho.Enabled = btnPhucHoiKho.Enabled = false;
        }

        private void btnThoatKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose(); 
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            // sự kiện công ty rẽ chi nhánh 
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

            this.khoTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.khoTableAdapter.Fill(this.DS.Kho);

            this.datHangTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.datHangTableAdapter.Fill(this.DS.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
        }
    }
}