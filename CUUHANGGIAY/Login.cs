using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CUUHANGGIAY
{
    public partial class Login : Form
    {
       
       
        public Login()
        {
            InitializeComponent();
        }
        public int i;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
        //    SqlConnection camcam = new SqlConnection(@"Data Source = CAMCAM\SQLEXPRESS; Initial Catalog = CUAHANGGIAY; Integrated Security = True");
        //    try
        //    {
        //        camcam.Open();
        //        string TK = txtUser.Text;
        //        string MK = TxtPassword.Text;
        //        string Sql = " select *from TaiKhoan where TenTK= '" + TK + "' and MatKhau='" + MK + "'";
        //        SqlCommand command = new SqlCommand(Sql, camcam);
        //        SqlDataReader data = command.ExecuteReader();
        //        if (data.Read() == true)
        //        {
        //            MessageBox.Show("Đăng nhập thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        //            Form1 f = new Form1();
        //            this.Hide();
        //            f.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show("Sai mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
               
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Lỗi kết nối.");
            if(txtUser.Text==""|| TxtPassword.Text=="")
            {
                MessageBox.Show("Bạn vui lòng nhập đầy đủ thông");
            }
            else
            {
                if(txtUser.Text=="CamCam" && TxtPassword.Text=="2222")
                {
                    i = 2;
                    MessageBox.Show("Cẩm Cẩm Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Form1 f = new Form1();
                  
                    
                                this.Hide();
                                f.ShowDialog();

                }
                else if(txtUser.Text=="HienNguyen"|| TxtPassword.Text=="3333")
                {
                    i = 3;
                    MessageBox.Show(" Hiển Hiển Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 f = new Form1();
                   
                    this.Hide();
                    f.ShowDialog();

                }
                
            }
        }

    }
}
