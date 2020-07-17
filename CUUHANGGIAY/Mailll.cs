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
    public partial class Mailll : Form
    {
        Attachment attach = null;
        public Mailll()
        {
            InitializeComponent();
        }
        public void LoadDL()
        {
            string query = " select *from KhachHang";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvMail.DataSource = data;
        }
        private void Mailll_Load(object sender, EventArgs e)
        {
            LoadDL();
        }

        private void dgvMail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtFile.Text = dialog.FileName;
            }
        }
        void GuiMail(string from, string to, string subject, string message, Attachment file = null)
        {
            String txttendangnhap = "thucam1999@gmail.com";
            String txtpass = "31121999";
            MailMessage mess = new MailMessage(from, to, subject, message);
            if (attach != null)
            {
                mess.Attachments.Add(attach);

            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(txttendangnhap, txtpass);
            client.Send(mess);

        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            String txttendangnhap = "thucam1999@gmail.com";
            //String txtpass = "31121999";
            string txtsubject = " Cảm ơn bạn đã mua sản phẩm của  Cẩm Cẩm Shop ";
            string txtMessage = " Hóa Đơn của bạn";


            attach = null;
            try
            {
                FileInfo file = new FileInfo(txtFile.Text);
                attach = new Attachment(txtFile.Text);
            }
            catch
            {

            }

            GuiMail(txttendangnhap, txtTo.Text, txtsubject, txtMessage);
        }
        
        

        private void btnMailist_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvMail_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvMail.CurrentRow.Index;
            txtTo.Text = dgvMail.Rows[i].Cells[5].Value.ToString();
        }

        private void txtTo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
