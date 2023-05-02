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
        public FormVatTu()
        {
            InitializeComponent();
        }

        


        // table apdapter 

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

       
    }
}