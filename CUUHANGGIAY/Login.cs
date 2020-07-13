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


            //string query = " select *from TaiKhoan where MaTK='"  + "' and MatKhau='" + TxtPassword.Text + "' ";
           // DataTable data = clsConnect.Instance.exQuery(query);
            //if (txtUser.Text == "" || TxtPassword.Text == "")
            //{
            //    MessageBox.Show("Bạn vui lòng nhập đầy đủ thông");
            //}
            //else
            //{
            //    if (data.Rows.Count>0)
            //    {
            //        i = 2;
            //        MessageBox.Show("Cẩm Cẩm Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        Form1 f = new Form1();


            //        this.Hide();
            //        f.ShowDialog();

            //    }
            //}
            
                string query = " select TenTK, MatKhau from TaiKhoan";
                DataTable data = clsConnect.Instance.exQuery(query);
                //TaiKhoan tk = quanli.TAIKHOAN.FirstOrDefault(p => p.MATK.Trim() == txtTK.Text.Trim() && p.PASS.Trim() == txtPass.Text.Trim());
                //if (txtUser.Text != null)
                //{
                //    Form1 f = new Form1();
                //    this.Hide();
                //    this.Show();
                //    f.tentk = txtUser.Text;
                //    f.ShowDialog();
                //}
                //else
                //{
                //    MessageBox.Show("BẠN NHẬP SAI TK HOẶC MK", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                //}
            for(int i = 0; i < data.Rows.Count; i++)
            {
                if(data.Rows[i][0].Equals(txtUser.Text))
                {
                    Form1 f = new Form1();
                    this.Hide();
                    this.Show();
                    f.tentk = txtUser.Text;
                    f.ShowDialog();
                }
            }
            MessageBox.Show("Sai roi, ngao a");
                
        }

    }
}
