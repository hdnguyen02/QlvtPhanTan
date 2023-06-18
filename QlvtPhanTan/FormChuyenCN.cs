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
    public partial class FormChuyenCN : DevExpress.XtraEditors.XtraForm
    {
        public FormChuyenCN()
        {
            InitializeComponent();
        }

          private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void FormChuyenCN_Load(object sender, EventArgs e)
        {
            cmbCN.DataSource = Program.bdsDspm.DataSource; 
            cmbCN.DisplayMember = "TENCN";
            cmbCN.ValueMember = "TENSERVER";
            cmbCN.SelectedIndex = Program.chiNhanh;  // chi nhánh mà nhân viên đó chọn vào.

            // kiểm tra thằng chi nhánh hiện tại xem là chi nhánh nào. 




            
        }

        public delegate void MyDelegate(string chiNhanh);
        public MyDelegate CNTransfer;
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbCN.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                CNTransfer(cmbCN.SelectedIndex.ToString());
            }
            this.Dispose();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}