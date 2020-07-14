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
            //string query = " select hd.MaHD,MaSP,MauSac,Size,SoLuongBan,ThanhTien,MaNV,MaKH from CTHD ct,HoaDon hd where ct.MaHD=ct.MaHD";
            //DataTable data = clsConnect.Instance.exQuery(query);
            //CRInHoaDon rp = new CRInHoaDon();
            //rp.SetDataSource(data);
            //crystalReportViewer1.ReportSource = rp;
            
          
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataReport.reportChuan' table. You can move, or remove it, as needed.
            this.reportChuanTableAdapter.Fill(this.DataReport.reportChuan, HoaDon.mahd);
            

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //TruyenDLcs.MaHD = txtKH.Text;
            //if (txtKH.Text == "")
            //{
            //    MessageBox.Show(" Nhập Mã Khách Hàng.");
            //}
            //else
            //{
            //    string query = " select hd.MaHD,MaSP,MauSac,Size,SoLuongBan,ThanhTien,MaNV,MaKH from CTHD ct,HoaDon hd where ct.MaHD=ct.MaHD and hd.MaHD='" + TruyenDLcs.MaHD + "'";
            //    DataTable data = clsConnect.Instance.exQuery(query);
            //    CRInHoaDon rp = new CRInHoaDon();
            //    rp.SetDataSource(data);
            //    crystalReportViewer1.ReportSource = rp;


            //}
        }
       
        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            
           
        }

        private void txtKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
