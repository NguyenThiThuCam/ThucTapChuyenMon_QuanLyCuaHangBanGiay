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
    public partial class TK : Form
    {
        public TK()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
            string query = "select MONTH(NgayLap) as 'ThoiGian',Sum((CTSP.GiaBan *CTHD.SoLuongBan)) as 'ThanhTien'  from HoaDon HD,CTSP,CTHD group by MONTH(NgayLap)";
            DataTable data = clsConnect.Instance.exQuery(query);
            chart1.DataSource = data;
            chart1.Series["VND"].XValueMember = "ThoiGian";
            chart1.Series["VND"].YValueMembers = "ThanhTien";
        }
    }
}
