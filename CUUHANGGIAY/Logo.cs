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
    public partial class Logo : Form
    {
        public Logo()
        {
            InitializeComponent();
        }
        int _img = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_img == 1)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h3;
                _img = 2;
            }
            else if (_img == 2)
            {
                pictureBox1.Image = CUUHANGGIAY.Properties.Resources.h40;
                _img = 3;
            }
            else if (_img == 3)
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
    }
}
