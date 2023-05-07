
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
        public static string servername;
        public static string database = "QLVT_DATHANG";
        public static string loginName;   // khoi tao gia tri 
        public static string userName;
        public static string password;

        public static string loginNameType;  // login do người dùng nhập vào.
        public static string passwordType; // password do ngươi dùng nhập vào. 

        public static string remoteLogin = "HTKN";
        public static string remotePassword = "123456"; 


        public static string role;
        public static string hoTen;
        public static int chiNhanh; 
        
        
       
        
        public static string connectStrPublisher = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";Integrated Security=True";

        public static BindingSource bdsDspm = new BindingSource(); 
        public static FormMain formMain;   



       
        public static int KetNoi()
        {
            if (Program.connect != null && Program.connect.State == ConnectionState.Open) Program.connect.Close();
            try
            {
                Program.connectStr = "Data Source=" + Program.servername + ";Initial Catalog=" + Program.database + ";User ID=" +
                      Program.loginName + ";password=" + Program.password;
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
