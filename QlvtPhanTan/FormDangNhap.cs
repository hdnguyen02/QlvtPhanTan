using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {

        private SqlConnection connectPublisher = new SqlConnection();

        public int KetNoiPublisher()
        {
            if (connectPublisher != null && connectPublisher.State == ConnectionState.Open)
            {
                connectPublisher.Close();
            }
            try
            {
                connectPublisher.ConnectionString = Program.connectStrPublisher;
                connectPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }


        private void layDspm(string cmd)
        {
           
            if (connectPublisher.State == ConnectionState.Closed)
            {
                connectPublisher.Open(); 
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connectPublisher); // connectPublisher: đã kết nối thành công trước đó
            da.Fill(dt); // dt: dataTable: chứa table view
            connectPublisher.Close();  
            Program.bdsDspm.DataSource = dt;
            // liên kết số liệu với cmb 
            comboBoxChiNhanh.DataSource = Program.bdsDspm; // chứa danh sách dữ liệu liên kết
            comboBoxChiNhanh.DisplayMember = "TENCN";  // tên hiển thị
            comboBoxChiNhanh.ValueMember = "TENSERVER"; // value khi chọn tương ứng với ten hiển thị
        }



        public FormDangNhap()
        {
            InitializeComponent();
        }


        // phương thức sẽ chạy khi form được load
        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            if (this.KetNoiPublisher() == 0) return;
            layDspm("SELECT * FROM V_DS_PHANMANH");
            comboBoxChiNhanh.SelectedIndex = 1;
            comboBoxChiNhanh.SelectedIndex = 0;
        }

        // khi người dùng đăng nhập vào.
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (this.textEditTenDangNhap.Text.Trim() == "" || this.textEditMatKhau.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được bỏ trống","", MessageBoxButtons.OK);
                return; 
            }
            Program.mLogin = this.textEditTenDangNhap.Text.Trim();
            Program.password = this.textEditMatKhau.Text.Trim();

           
            if (Program.KetNoi() == 0) return;


            // đoạn code phía trên dùng để kết nối về server.

            Program.mChiNhanh = comboBoxChiNhanh.SelectedIndex;
            Program.mLoginDN = Program.mLogin; 
            Program.passworDN = Program.password; 


            // lấy ra mã nhân viên, họ tên và nhóm 
            string strLenh = "EXEC SP_DANGNHAP '" + Program.mLogin + "'";
            Program.myReader = Program.ExecSqlDataReader(strLenh);

            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.username = Program.myReader.GetString(0);
            if (Convert.IsDBNull(Program.username))
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác", "Thông Báo", MessageBoxButtons.OK);
            }

            Program.mHoten = Program.myReader.GetString(1);
            Program.mGroup = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.connect.Close();

            Program.formMain.toolStripStatusLabelMSNV.Text = "Mã Nhân viên: " + Program.username;
            Program.formMain.toolStripStatusLabelTen.Text = "Họ tên: " + Program.mHoten;

            Program.formMain.toolStripStatusLabelRole.Text = "Nhóm: " + Program.mGroup;



        }

        private void groupControlThongTinDangNhap_Paint(object sender, PaintEventArgs e)
        {

        }


        // SelectedIndexChanged: sự kiện xảy ra khi thay đổi giá trị. 
        private void comboBoxChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.servername = comboBoxChiNhanh.SelectedValue.ToString(); 
            }
            catch(Exception) {}
        }

        private void labelControlTenDangNhap_Click(object sender, EventArgs e)
        {

        }
    }
}