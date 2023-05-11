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
            this.panelNhapLieuKho.Enabled = true;
            maKhoTextEdit.Enabled = true;
            bdsKho.AddNew();
     
            khoGridControl.Enabled = false;
            btnThemKho.Enabled = btnXoaKho.Enabled = btnHieuChinhKho.Enabled = btnReloadKho.Enabled = btnThoatKho.Enabled = false;
            btnGhiKho.Enabled = btnPhucHoiKho.Enabled = true;
        }

        private void btnXoaKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // kiểm tra xem thằng kho này đã nằm trong chi tiết phiếu nào chưa. 
            if (bdsDH)
            {
                
            }
        }
    }
}