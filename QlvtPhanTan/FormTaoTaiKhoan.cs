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
    public partial class FormTaoTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public FormTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void FormTaoTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.HoTenNV' table. You can move, or remove it, as needed.

            this.DS.EnforceConstraints = false;

            this.hoTenNVTableAdapter.Connection.ConnectionString = Program.connectStr; 
            this.hoTenNVTableAdapter.Fill(this.DS.HoTenNV);

            hOTENComboBox.SelectedIndex = -1;

            // kiểm tra xem là role công ty hay là role chi nhánh 
            cmbRole.DataSource = null;
            if (Program.role == "CHINHANH")
            {
                // thêm vào 2 giá trị. 
               
                cmbRole.Items.Add("CHINHANH");
                cmbRole.Items.Add("USER");

                // không chọn gì hết 
              
            }
            else
            {
                cmbRole.Items.Add("CONGTY");
            }

            cmbRole.SelectedIndex = 0; // không chọn thằng nào hết.  




        }

        private void hOTENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                textEditUserName.Text = hOTENComboBox.SelectedValue.ToString();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            // thử log ra giá trị.  
            //if (cmbRole.SelectedValue.ToString() == "System.Data.DataRowView") return;

           /* object selectedObject = cmbRole.SelectedItem;

            // Kiểm tra và ép kiểu đối tượng sang kiểu mong muốn
            if (selectedObject != null)
            {
                Console.WriteLine(selectedObject.ToString()); 
                // Sử dụng giá trị đã lấy được
            }*/

        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            // kiểm tra xem người dùng đã chọn chưa. 
            // kiểm tra xem mọi giá tát cả đã được thỏa mãn chưa. 
            // và login name không được có khoản trắng. 
            textEditLoginName.Text = textEditLoginName.Text.Trim(); 

            if (textEditLoginName.Text == "") // chưa chọn role.
            {
                MessageBox.Show("Không được bỏ trống login name\n", "", MessageBoxButtons.OK);
                return; 
            }
            // trim nó luôn 
         

            if (textEditLoginName.Text.Contains(" "))
            {
                MessageBox.Show("login name không bao gồm khoản trắng\n", "", MessageBoxButtons.OK);
                return; 
            }
            if (textEditPassword.Text == "")
            {
                MessageBox.Show("password không được bỏ trống\n", "", MessageBoxButtons.OK);
                return;
            }
            if (textEditCfpw.Text == "")
            {
                MessageBox.Show("Confirm password không được bỏ trống\n", "", MessageBoxButtons.OK);
                return;
            }

            if (textEditPassword.Text.Contains(" "))
            {
                MessageBox.Show("password không bao gồm khoản trắng\n", "", MessageBoxButtons.OK);
                return;
            }

           

            // kiểm tra user Name. 
            if (textEditUserName.Text == "")
            {
                MessageBox.Show("chưa chọn username\n", "", MessageBoxButtons.OK);
                return;
            }
            // kiểm tra xem 2 khứa kia có khớp không 
            if (!textEditCfpw.Text.Equals(textEditPassword.Text))
            {
                MessageBox.Show("password và confirm password không bằng nhau\n", "", MessageBoxButtons.OK);
                return;
            }


           
           string strLenh = "exec spTaoTaiKhoan '" + textEditLoginName.Text + "','" + textEditPassword.Text + "','" + textEditUserName.Text + "','" + cmbRole.SelectedItem.ToString() + "'";
           if (Program.ExecSqlDataReader(strLenh) != null)
            {
                MessageBox.Show("Tạo tài khoản thành công\n", "", MessageBoxButtons.OK); 
                textEditLoginName.Text = "";
                textEditPassword.Text = "";
                hOTENComboBox.SelectedIndex = -1;
                textEditUserName.Text = ""; 

            } 

          
          

            
           

          





        }

        private void cmbRole_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose(); 
        }
    }
}