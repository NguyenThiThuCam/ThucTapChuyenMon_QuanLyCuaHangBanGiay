using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CUUHANGGIAY
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }
        private void load()
        {
            string query = " select hd.MaHD,MaSP,MauSac,Size,SoLuongBan,ThanhTien from CTHD ct,HoaDon hd where ct.MaHD=ct.MaHD";
            DataTable data = clsConnect.Instance.exQuery(query);
            CRInHoaDon rp = new CRInHoaDon();
            rp.SetDataSource(data);
            crystalReportViewer1.ReportSource = rp;
            
          
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            load();

        }
    }
}
