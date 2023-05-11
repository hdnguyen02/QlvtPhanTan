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
    public partial class FormVatTu : DevExpress.XtraEditors.XtraForm
    {

        int viTri;

        public FormVatTu()
        {
            InitializeComponent();
        }

        

        private void FormVatTu_Load(object sender, EventArgs e)
        {

            DS.EnforceConstraints = false;


            this.vatTuTableAdapter.Connection.ConnectionString = Program.connectStr; 
            this.vatTuTableAdapter.Fill(this.DS.Vattu);

            this.ctddhTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.ctddhTableAdapter.Fill(this.DS.CTDDH);

            this.ctpxTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.ctpxTableAdapter.Fill(this.DS.CTPX);

            this.ctpnTableAdapter.Connection.ConnectionString = Program.connectStr;
            this.ctpnTableAdapter.Fill(this.DS.CTPN);


            if (Program.role == "CONGTY")
            {
                btnThemVT.Enabled = btnXoaVT.Enabled = btnHieuChinhVT.Enabled = btnGhiVT.Enabled = btnPhucHoiVT.Enabled = false;
            }


        }

        private void btnThoatVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close(); 

        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 
        private void panelControlNhapLieuVatTu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vattuGridControl_Click(object sender, EventArgs e)
        {

        }



        // viết 1 sp kiểm tra xem có tồn tại hay mã vật tư hay chưa, 

     

        private void btnThemVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          
            this.viTri = bdsVatTu.Position;
            this.panelControlNhapLieuVatTu.Enabled = true;
            mAVTTextEdit.Enabled = true;
            bdsVatTu.AddNew();
 
            vattuGridControl.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnHieuChinhVT.Enabled = btnReloadVT.Enabled = btnThoatVT.Enabled = false;
            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = true;
        }

        private void btnGhiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* if (dangThemMoi)
             {
                 dangThemMoi = false; 
                 // kiểm tra xem mã vật tư đã tồn tại hay chưa. 

             }*/

            // ghi lại. 
            try
            {
                bdsVatTu.EndEdit();
                bdsVatTu.ResetCurrentItem();
                this.vatTuTableAdapter.Connection.ConnectionString = Program.connectStr;
                this.vatTuTableAdapter.Update(this.DS.Vattu);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Ghi vật tư\n" + ex.Message, "", MessageBoxButtons.OK);
                this.vatTuTableAdapter.Fill(this.DS.Vattu);
                bdsVatTu.Position = viTri;
     
            }
            panelControlNhapLieuVatTu.Enabled = false;
            vattuGridControl.Enabled = true;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnHieuChinhVT.Enabled = btnReloadVT.Enabled = btnThoatVT.Enabled = true;
            btnPhucHoiVT.Enabled = btnGhiVT.Enabled = false;
        }

        private void btnHieuChinhVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mAVTTextEdit.Enabled = false; // không cho phép sữa. 

            this.viTri = bdsVatTu.Position;
            this.panelControlNhapLieuVatTu.Enabled = true;
     
      

            vattuGridControl.Enabled = false;
            btnThemVT.Enabled = btnXoaVT.Enabled = btnHieuChinhVT.Enabled = btnReloadVT.Enabled = btnThoatVT.Enabled = false;
            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = true;
        }



        private void btnPhucHoiVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsVatTu.CancelEdit();
            reload(); 

            panelControlNhapLieuVatTu.Enabled = false;
            vattuGridControl.Enabled = true;

            btnThemVT.Enabled = btnXoaVT.Enabled = btnHieuChinhVT.Enabled = btnReloadVT.Enabled = btnThoatVT.Enabled = true;
            btnGhiVT.Enabled = btnPhucHoiVT.Enabled = false;
        }


        void reload()
        {
            viTri = bdsVatTu.Position;
            try
            {
                this.vatTuTableAdapter.Fill(this.DS.Vattu);
                bdsVatTu.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
            }
        }

        private void btnReloadVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload(); 
        }


        // không được quyền xóa.

        private void btnXoaVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reload(); 
            if (bdsCTDDH.Count > 0)
            {
                // viết 1 hàm tiện ích show ra lỗi đi.  
                MessageBox.Show("Không thể xóa vật tư đã lập chi tiết đơn đặt hàng", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư đã lập chi tiết đơn phiếu nhập", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư đã lập phiếu xuất", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thực muốn xóa vật tư ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string maXoa = "";
                try
                {
                    maXoa = ((DataRowView)bdsVatTu[bdsVatTu.Position])["MAVT"].ToString();
                    bdsVatTu.RemoveCurrent();
                    this.vatTuTableAdapter.Connection.ConnectionString = Program.connectStr;
                    this.vatTuTableAdapter.Update(this.DS.Vattu);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân nhân viên. Bạn hãy xóa lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.vatTuTableAdapter.Fill(this.DS.Vattu);
                    bdsVatTu.Position = bdsVatTu.Find("MAVR", maXoa);
                    return;
                }
            }

            if (bdsVatTu.Count == 0) btnXoaVT.Enabled = false;
        }
    }
}