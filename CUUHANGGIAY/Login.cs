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
            this.Hide();
            GuiMail back = new GuiMail();
            back.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        string User = "";

        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            
            string query = " select Banhang,quanli from TaiKhoan where TenTK like'" + txtUser.Text.Trim()+ "' and MatKhau like'" + TxtPassword.Text + "' ";
            Console.WriteLine(query);
             DataTable data = clsConnect.Instance.exQuery(query);
            
           if(data.Rows.Count>0)
            {
                bool ktbh = Boolean.Parse(data.Rows[0][0].ToString());
                bool kt = Boolean.Parse(data.Rows[0][1].ToString());
                User = txtUser.Text;
                MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f = new Form1();
                f.tentk = User;
                f.kt = kt;
                f.ktbh = ktbh;
                this.Hide();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }               
        }
    }
}
