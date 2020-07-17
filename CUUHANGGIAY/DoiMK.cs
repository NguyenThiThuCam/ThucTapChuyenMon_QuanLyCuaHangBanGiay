using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUUHANGGIAY
{
    public partial class DoiMK : Form
    {
        public string matk;
        public DoiMK()
        {
            InitializeComponent();
        }

        private void DoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            if (txtpass.Text == "" || txtpassmoi.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtpass.Text != txtpassmoi.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if(txtpass.Text.Equals(txtpassmoi.Text))
            {
                string query = " update taikhoan set matkhau='"+txtpassmoi.Text+"' where MaTK like '" + matk + "' ";
                int data = clsConnect.Instance.updateTaiKhoan(query);
                if(data>0)
                    MessageBox.Show("Đổi mật khẩu thành công.","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Hide();
                Login back = new Login();
                back.Visible = true;
            }
           
            else
            {
                MessageBox.Show("Mật khẩu chưa trùng.","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
    }
}
