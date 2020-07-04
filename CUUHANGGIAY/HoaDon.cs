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
    public partial class HoaDon : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string camcam = @"Data Source=CAMCAM\SQLEXPRESS;Initial Catalog=CUAHANGGIAY;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadDuLieu()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from HoaDon";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKH.DataSource = table;
        }
        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            connection = new SqlConnection(camcam);
            connection.Open();
            loadDuLieu();
        }
        void lammoi()
        {
            cbMaHD.Text = " ";
            cbMaKH.Text = " ";
            cbMaNV.Text = " ";
            txtNgayLap.Text = " ";
            txtTongTien.Text = " ";
            txtTinhTrang.Text = " ";
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }
    }
}
