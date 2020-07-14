using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;
using System.Threading;

namespace CUUHANGGIAY
{
    public partial class GuiMail : Form
    {
        public GuiMail()
        {
            InitializeComponent();
        }
        Random randomma = new Random();
        int maxn = 0;
        private void btnSent_Click(object sender, EventArgs e)
        {

            if (txtGmail.Text=="")

            {
                MessageBox.Show("Bạn chưa nhập mail.");
                return;

            }
            string query = " select MaTK from TaiKhoan where TenTK like '" + txtTK.Text + "' ";
            DataTable data = clsConnect.Instance.exQuery(query);
            if (data.Rows.Count>0) {
                string matk = data.Rows[0][0].ToString();
                string query2 = " select gmailNV from nhanvien where MaTK like '" + matk + "' ";
                DataTable data2 = clsConnect.Instance.exQuery(query2);
                if (data2.Rows.Count>0)
                {
                    string gmail = data2.Rows[0][0].ToString();
                    Console.WriteLine(gmail);
                    if(gmail.Equals(txtGmail.Text))
                    {
                        String txttendangnhap = "thucam1999@gmail.com";
                        String txtmk = "31121999";

                        string email = txtGmail.Text;
                        maxn = randomma.Next(1000, 9999);
                        MailMessage mail = new MailMessage(txttendangnhap, email, "Mã xác nhận", maxn.ToString());
                        mail.IsBodyHtml = true;
                        SmtpClient client = new SmtpClient("smtp.gmail.com");
                        client.Host = "smtp.gmail.com";
                        client.UseDefaultCredentials = false;
                        client.Port = 587;
                        client.Credentials = new System.Net.NetworkCredential(txttendangnhap, txtmk);
                        client.EnableSsl = true;
                        client.Send(mail);
                        MaXN2 ma = new MaXN2();
                        ma.matk = matk;
                        ma.otp = maxn;
                        ma.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Gmail không đúng");
                    }

                
            }

            }
            else
            {
                MessageBox.Show("Tên Tài Khoản Không Đúng");
            }




        }

        private void GuiMail_Load(object sender, EventArgs e)
        {

        }
    }
}
