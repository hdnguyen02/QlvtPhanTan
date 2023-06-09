﻿using DevExpress.XtraReports.UI;
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

       
            this.btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

            this.ribbonPageNhapXuat.Visible = true; 
            if (Program.role == "CONGTY")
            {
               btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
                this.ribbonPageBaoCao.Visible = true;
            }
            else if (Program.role == "CHINHANH")
            {
                btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                this.ribbonPageBaoCao.Visible = true; 
            }
            else
            {
                
                // ẩn đi nút tạo tk. 
                this.btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
                this.ribbonPageBaoCao.Visible = false;
            }
            
            
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
                // XET MK VA PASSWORK. 
                f.textEditTenDangNhap.Text = "tt";
                f.textEditMatKhau.Text = "123456"; 

                f.MdiParent = this;
                f.Show();
                f.btnDangNhap_Click(null, null); 
                
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
            Console.WriteLine("nhap vao dang xuat");
            Program.loginName = "";
            Program.password = "";
            Program.connectStr = "";  // xóa đi. 

            this.btnDangXuat.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ribbonPageNhapXuat.Visible = false;
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }

            if (Program.role == "CONGTY"  || Program.role == "CHINHANH")
            {
                this.btnTaoTaiKhoan.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
               
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // khi load len cho no dang nhap luon. 
            
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

        private void btnNhapXuatVatTu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormVatTu));
            if (frm != null) frm.Activate();
            else
            {
                FormVatTu f = new FormVatTu();
                f.MdiParent = this;
                f.Show();
            }
        }



        private void btnKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormKho));
            if (frm != null) frm.Activate();
            else
            {
                FormKho f = new FormKho();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDDH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormDDH));
            if (frm != null) frm.Activate();
            else
            {
                FormDDH f = new FormDDH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPN));
            if (frm != null) frm.Activate();
            else
            {
                FormPN f = new FormPN();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void ntnPX_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormPX));
            if (frm != null) frm.Activate();
            else
            {
                FormPX f = new FormPX();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCaoNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormReportNV));
            if (frm != null) frm.Activate();
            else
            {
                FormReportNV f = new FormReportNV();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBaoCaoVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // tạo báo cáo tại đây luôn. không cần chọn chi nhánh -> vì vật tư là nhân bản. 
            ReportVatTu rpVT = new ReportVatTu();
            ReportPrintTool print = new ReportPrintTool(rpVT);
            print.ShowPreviewDialog();
        }

        private void btnDDHChuaPN_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormReportDDH));
            if (frm != null) frm.Activate();
            else
            {
                FormReportDDH f = new FormReportDDH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnBCNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(FormReportBCNV));
            if (frm != null) frm.Activate();
            else
            {
                FormReportBCNV f = new FormReportBCNV();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
