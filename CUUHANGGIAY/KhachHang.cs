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
    public partial class KhachHang : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string camcam = @"Data Source=CAMCAM\SQLEXPRESS;Initial Catalog=CUAHANGGIAY;Integrated Security=True";
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadDuLieu()
        {
            command = connection.CreateCommand();
            command.CommandText = " select * from KhachHang";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgvKH.DataSource = table;
        }
        public KhachHang()
        {
            InitializeComponent();
        }
        void lammoi()
        {
            cbMaKH.Text = " ";
            txtTenKH.Text = " ";
            txtSDT.Text = " ";
            txtNgaySinh.Text = " ";
            txtGmail.Text = " ";
            txtDiaChi.Text = " ";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(camcam);
            connection.Open();
            loadDuLieu();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            cbMaKH.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            txtNgaySinh.Text= dgvKH.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text= dgvKH.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text= dgvKH.Rows[i].Cells[4].Value.ToString();
            txtGmail.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
