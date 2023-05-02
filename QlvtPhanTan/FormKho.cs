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
            // TODO: This line of code loads data into the 'dS.Kho' table. You can move, or remove it, as needed.
         

        }
    }
}