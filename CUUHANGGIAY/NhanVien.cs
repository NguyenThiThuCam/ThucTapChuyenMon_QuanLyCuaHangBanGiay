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
    public partial class NhanVien : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string camcam = @"Data Source=CAMCAM\SQLEXPRESS;Initial Catalog=CUAHANGGIAY;Integrated Security=True";
        SqlDataAdapter adapter= new SqlDataAdapter();
        DataTable table = new DataTable();
        void loadDuLieu()
        {
           
            command = connection.CreateCommand();
            command.CommandText = "select *from NhanVien";
            adapter.SelectCommand=command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;


        }
        

        public NhanVien()
        {
            InitializeComponent();
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNgaySinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttenNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(camcam);
            try
            {
                if (cbMaNV.Text != "" && txttenNV.Text != "" && txtNgaySinh.Text != "" && txtNgayvaolam.Text != "" && txtLuong.Text != "" && txtSDT.Text != "" && txtMail.Text != "")
                {
                    connection.Open();
                    string cc = " insert into  NhanVien  values('" + cbMaNV.Text + "','" + txttenNV.Text + "','" + txtNgaySinh.Text + "','" + txtNgayvaolam.Text + "'," +
                        "'" + txtLuong.Text + "','" + txtSDT.Text + "','" + txtMail.Text + "')";
                    SqlCommand command = new SqlCommand(cc, connection);
                    int kq = (int)command.ExecuteNonQuery();
                    if (kq > 0)
                    {
                        MessageBox.Show("Thêm thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        loadDuLieu();
                    }
                    else
                        MessageBox.Show(" Thêm thất bại.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    connection.Close();
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
            }catch(Exception ex)
            {

            }
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult tb;
            tb = MessageBox.Show("Bạn có muốn xoá hay không?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if (tb==DialogResult.OK)
            {
                SqlConnection connection = new SqlConnection(camcam);
                connection.Open();
                String cc = " delete from NhanVien where MaNV='"+ cbMaNV.Text + "'";
                SqlCommand command = new SqlCommand(cc, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công.");
                loadDuLieu();
                connection.Close();
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        void lammoi()
        {
            cbMaNV.Text = " ";
            
            txtMail.Text = " ";
            txtNgaySinh.Text = " ";
            txtNgayvaolam.Text = " ";
            txtSDT.Text = " ";
            txttenNV.Text = " ";
            txtMaTaiKhoan.Text =" ";
            txtLuong.Text = " ";
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(camcam);
            connection.Open();
            loadDuLieu();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            cbMaNV.Text = dgv.Rows[i].Cells[0].Value.ToString();
            txtNgaySinh.Text = dgv.Rows[i].Cells[2].Value.ToString();
            txtMaTaiKhoan.Text = dgv.Rows[i].Cells[7].Value.ToString();
            txttenNV.Text = dgv.Rows[i].Cells[1].Value.ToString();
            txtSDT.Text = dgv.Rows[i].Cells[5].Value.ToString();
            txtMail.Text= dgv.Rows[i].Cells[6].Value.ToString();
            txtNgayvaolam.Text = dgv.Rows[i].Cells[3].Value.ToString();
            txtLuong.Text = dgv.Rows[i].Cells[4].Value.ToString();
        }

        private void txtNgayvaolam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
