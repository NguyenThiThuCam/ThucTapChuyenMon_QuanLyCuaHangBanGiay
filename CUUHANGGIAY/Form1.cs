using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace CUUHANGGIAY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public int r;
        private void Form1_Load(object sender, EventArgs e)
        {
            loadform(new Logo());
            timer3.Start();
            Login login = new Login();
            r = login.i;
            MessageBox.Show(r.ToString());
           
          




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int x = 1, y = 1;

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

       
        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Visible = true;
                
        }
        int c = 25, d = 29, a = 1;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btninsta_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/cam.thu.376695  ");
        }

        private void btninsta_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://www.instagram.com/thucam3112/?hl=vi");

        }
        // Hàm gọi form !
        private void loadform(object formload)
        {
            if (this.pnMain.Controls.Count > 0)
                this.pnMain.Controls.RemoveAt(0);
            Form fh = formload as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnMain.Controls.Add(fh);
            this.pnMain.Tag = fh;
            fh.Opacity = 0;
            fh.Show();
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            // load form lên panel Main  
            loadform(new Logo());
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            loadform(new SanPham());
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnHD_Click(object sender, EventArgs e)
        {
            loadform(new HoaDon());
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
           
            if (r == 2)
            {
                loadform(new NhaCungCap());

            }
           

       
               
        }

        private void btnPN_Click(object sender, EventArgs e)
        {
            loadform(new PhieuNhap());
        }

        private void btnKH_Click(object sender, EventArgs e)
        {
            loadform(new KhachHang());
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            loadform(new DanhMuc());
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            if(r==2)
            {
                loadform(new NhanVien());

            }
                     
        }

        private void lbMenu_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int i;
        private void timer3_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString();

        }

        private void time_Click(object sender, EventArgs e)
        {
          

           
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnMail_Click(object sender, EventArgs e)
        {
            Mailll f = new Mailll();
            this.Hide();
            f.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {
                c += a;
                label1.Location = new Point(c, d);
                if (c >= 868)
                {
                    a = -1;

                }
                if (c < 25)
                {
                    a = 1;



                }


            }
            catch (Exception) { }
        }
    }
}
