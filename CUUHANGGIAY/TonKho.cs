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
    public partial class TonKho : Form
    {
        public TonKho()
        {
            InitializeComponent();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetTKho.tonkho' table. You can move, or remove it, as needed.
            this.tonkhoTableAdapter.Fill(this.DataSetTKho.tonkho);

            this.reportViewer1.RefreshReport();
        }
    }
}
