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
    public partial class MaXN2 : Form
    {
        public string matk;
        public int otp;
        public MaXN2()
        {
            InitializeComponent();
        }

        private void MaXN2_Load(object sender, EventArgs e)
        {
           

        }

        private void btnSent_Click(object sender, EventArgs e)
        {
           if(int.Parse(txtmaxn.Text)==otp)
            {
                DoiMK doiMK = new DoiMK();
                doiMK.matk = matk;
                doiMK.ShowDialog();
            }
            else
            {
                MessageBox.Show("ma otp khong dung");
            }
        }
    }
}
