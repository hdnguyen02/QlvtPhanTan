
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QlvtPhanTan
{
    static class Program
    {

        
        public static SqlConnection connect = new SqlConnection();

        public static string connectStr;
        

        public static SqlDataAdapter da;
        public static SqlDataReader myReader;
        public static string servername = "DESKTOP-JNU1A1J";
        public static string servername1 = "DESKTOP-JNU1A1J\\MSSQLSERVER01";
        public static string servername2 = "DESKTOP-JNU1A1J\\MSSQLSERVER02";
        public static string username;
        public static string password;
        public static string passworDN;


        public static string database = "QLVT_DATHANG";
        public static string mLogin;
        public static string mLoginDN;
        public static string mGroup;
        public static string mHoten;
        public static int mChiNhanh = 0;
        public static string connectStrPublisher = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";Integrated Security=True";

        public static BindingSource bdsDspm = new BindingSource(); 
        public static FormMain formMain;   



       
        public static int KetNoi()
        {
            if (Program.connect != null && Program.connect.State == ConnectionState.Open) Program.connect.Close();
            try
            {
                Program.connectStr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.mLogin + ";password=" + Program.password;
                Program.connect.ConnectionString = Program.connectStr;
                Program.connect.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh,Program.connect);
          
            sqlcmd.CommandType = CommandType.Text;

            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); 
                return myreader;
            }
            catch (SqlException ex)
            {
                Program.connect.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String strLenh)
        {
            DataTable dt = new DataTable(); 
            if (Program.connect.State == ConnectionState.Closed) Program.connect.Open();
            SqlDataAdapter da = new SqlDataAdapter(strLenh, Program.connect);
            da.Fill(dt);
            Program.connect.Close();
            return dt;
        }


        public static int ExecSqlNonQuery(String strLenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strLenh,connect);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; // 10 phút


            if (connect.State == ConnectionState.Closed) { 
                connect.Open(); }
            try
            {

                Sqlcmd.ExecuteNonQuery(); 
                connect.Close(); 
                return 1;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
                return ex.State; 
            }
        }
        public static void SetEnableOfButton(Form frm, Boolean Active)
        {

            foreach (Control ctl in frm.Controls)
                if ((ctl) is Button)
                    ctl.Enabled = Active;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]


        
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain(); 

            Application.Run(formMain);
        }
    }
}
