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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int x = 1, y = 1;

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private int _img = 1;
        private void timer2_Tick(object sender, EventArgs e)
        {
            if(_img == 1)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h3;
                _img = 2;
            }
           else if (_img == 2)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h40;
                _img = 3;
            }
            else if(_img == 3)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h4;
                _img = 4;
            }
            else if (_img == 4)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h9;
                _img = 5;
            }
            else if (_img == 5)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h7;
                _img = 6;
            }
            else
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h3;
                _img = 2;
            }
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

        private void btnMail_Click(object sender, EventArgs e)
        {
         
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
