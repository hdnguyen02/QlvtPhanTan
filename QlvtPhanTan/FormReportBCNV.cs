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
    public partial class FormReportBCNV : DevExpress.XtraEditors.XtraForm
    {
        public FormReportBCNV()
        {
            InitializeComponent();
        }

        private void FormReportBCNV_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bdsDspm;
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.chiNhanh;  // chi nhánh mà nhân viên đó chọn vào.

            if (Program.role == "CONGTY")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

            DS.EnforceConstraints = false;


            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr; 
            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);


            // load cmb.  


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

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            // lựa chọn tham số và đưa vào.  

        }
    }
}