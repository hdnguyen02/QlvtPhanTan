using System;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        

        public FormMain()
        {
            InitializeComponent();
        }

        public void HienThiKhiDangNhap()
        {
            this.toolStripStatusLabelMSNV.Text = "Mã Nhân viên: " + Program.userName;
            this.toolStripStatusLabelTen.Text = "Họ tên: " + Program.hoTen;
            this.toolStripStatusLabelRole.Text = "Nhóm: " + Program.role;
            this.ribbonPageNhapXuat.Visible = true; 
        }

        public void DangXuat()
        {

        }



        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void btnDangNhap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDangNhap));
            if (frm != null) frm.Activate();
            else
            {
                FormDangNhap f = new FormDangNhap();
                f.MdiParent = this;
                f.Show();
            }

        }

        private void btnTaoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormTaoTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                FormTaoTaiKhoan f = new FormTaoTaiKhoan();
                f.MdiParent = this; 
                f.Show();
            }
        }

        private void toolStripStatusLabelTen_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabelMSNV_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.loginName = "";
            Program.password = "";
            // ẩn đi các giao diện. 
            this.DangXuat();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnNhapXuatNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this;
                f.Show();
            }

        }
    }
}
