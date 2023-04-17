/*using DevExpress.XtraEditors;*/
using System;
/*using System.Collections.Generic;
using System.ComponentModel;*/
using System.Data;
/*using System.Drawing;*/
/*using System.Linq;
using System.Text;
using System.Threading.Tasks;*/
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormNhanVien : DevExpress.XtraEditors.XtraForm
    {
        private String macn; 

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

            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);     this.phieuXuatTableAdapter.Fill(this.DS.PhieuXuat);
            this.datHangTableAdapter.Fill(this.DS.DatHang);
            this.phieuNhapTableAdapter.Fill(this.DS.PhieuNhap);
            // macn = ((DataRowView)this.bdsNhanVien[0])["maChiNhanh"].ToString();
            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;  
            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true; 
                // bật tắt nút lệnh theo phân quyền. 
            }

        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

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
    }
}