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
    public partial class Mail : Form
    {
        Attachment attach = null;
        void GuiMail()
        {
            string tendangnhap = "thucam1999@gmail.com";
            string matkhau= "31121999";
            MailMessage mess = new MailMessage();
            if( attach!=null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(tendangnhap, matkhau);
            client.Send(mess);

        }
        public void LoadDL()
        {
            string query = " select *from KhachHang";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvMail.DataSource = data;
        }
        public Mail()
        {
            InitializeComponent();
            LoadDL();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtMail.Text = dialog.FileName;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }

        private void btnSent_Click(object sender, EventArgs e)

        {
            GuiMail();
            Thread thread = new Thread(() =>
            {
                attach = null;
                try
                {
                    FileInfo file = new FileInfo(txtFile.Text);
                    attach = new Attachment(txtFile.Text);


                }
                catch
                {

                }
                StreamReader sr = new StreamReader(txtMail.Text);
                string email;
                while((email=sr.ReadLine())!=null)
                {
                    GuiMail();

                }sr.Close();

            }
                );
            thread.Start();
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 back = new Form1();
            back.Visible = true;
        }

        private void dgvMail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
    }
}
