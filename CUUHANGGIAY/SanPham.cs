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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void lbMaKH_Click(object sender, EventArgs e)
        {

        }
        void lammoi()
        {
            cbMaSP.Text = " ";
            cbMaLoai.Text = " ";
            txtTenSP.Text = " ";
            

        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();

        }
        int x = 125, y = 4, a = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if(x>=852)
                    {
                    a = -1;
                    
                }
                if (x< 125)
                {
                    a = 1;
                   


                }
                

            }
            catch (Exception) { }
        }
    }
}
