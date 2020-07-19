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
    public partial class Thongke : Form
    {
        public Thongke()
        {
            InitializeComponent();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Thongke_Load(object sender, EventArgs e)
        {
            loadTKNam();
            loadTKThang();
            loadTKquy();


        }

        void loadTKThang()
        {
            string query = "select MONTH(NgayLap) as 'ThoiGian',Sum((CTSP.GiaBan *CTHD.SoLuongBan)) as 'ThanhTien'  from HoaDon HD,CTSP,CTHD group by MONTH(NgayLap)";
            DataTable data = clsConnect.Instance.exQuery(query);
            chartTK.DataSource = data;
            chartTK.Series["VND"].XValueMember = "ThoiGian";
            chartTK.Series["VND"].YValueMembers = "ThanhTien";


        }
        void loadTKNam()
        {
            string query1 = "select YEAR(NgayLap) as 'ThoiGian',Sum((CTSP.GiaBan *CTHD.SoLuongBan)) as 'ThanhTien'  from HoaDon HD,CTSP,CTHD group by YEAR(NgayLap)";
            DataTable data1 = clsConnect.Instance.exQuery(query1);
            chart1.DataSource = data1;
            chart1.Series["VND"].XValueMember = "ThoiGian";
            chart1.Series["VND"].YValueMembers = "ThanhTien";
        }
        void loadTKquy()
        {
            string query = "select datepart (q, NgayLap) as 'quy',SUM((TongTien)) as 'ThanhTien'  from HoaDon HD group by datepart (q, NgayLap)";
            DataTable data = clsConnect.Instance.exQuery(query);
            chart2.DataSource = data;
            chart2.Series["VND"].XValueMember = "quy";
            chart2.Series["VND"].YValueMembers = "ThanhTien";


        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
           

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton1_Click_1(object sender, EventArgs e)
        {
   
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            loadTKNam();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            loadTKThang();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadTKThang();
        }

        private void chartTK_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_2(object sender, EventArgs e)
        {

        }
    }
}
