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
            loadTKThang();
            loadTKNam();
        }
          
        void loadTKThang()
        {
                string query = "select MONTH(NgayLap) as 'ThoiGian',Sum((CTSP.GiaBan *CTHD.SoLuongBan)) as 'ThanhTien'  from HoaDon HD,CTSP,CTHD group by MONTH(NgayLap)";
                DataTable data = clsConnect.Instance.exQuery(query);
            chart1.DataSource = data;
            chart1.Series["VND"].XValueMember = "ThoiGian";
            chart1.Series["VND"].YValueMembers = "ThanhTien";


        }
        void loadTKNam()
        {
            string query = "select YEAR(NgayLap) as 'ThoiGian',Sum((CTSP.GiaBan *CTHD.SoLuongBan)) as 'ThanhTien'  from HoaDon HD,CTSP,CTHD group by YEAR(NgayLap)";
            DataTable data = clsConnect.Instance.exQuery(query);
            chart2.DataSource = data;
            chart2.Series["VND"].XValueMember = "ThoiGian";
            chart2.Series["VND"].YValueMembers = "ThanhTien";
        }
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
