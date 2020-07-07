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


        public KhachHang()
        {
            InitializeComponent();
            LoadDL();
        }
        void lammoi()
        {
            cbMaKH.Text = " ";
            txtTenKH.Text = " ";
            txtSDT.Text = " ";
         //   txtNgaySinh.Text = " ";
            txtGmail.Text = " ";
            txtDiaChi.Text = " ";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }
        public void LoadDL()
        {
            string query = " select * from KhachHang";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvKH.DataSource = data;
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvKH.CurrentRow.Index;
            cbMaKH.Text = dgvKH.Rows[i].Cells[0].Value.ToString();
            txtTenKH.Text = dgvKH.Rows[i].Cells[1].Value.ToString();
            txtNgaySinh.Text = dgvKH.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvKH.Rows[i].Cells[3].Value.ToString();
            txtDiaChi.Text = dgvKH.Rows[i].Cells[4].Value.ToString();
            txtGmail.Text = dgvKH.Rows[i].Cells[5].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        public bool KiemTraMa(string MaKH)
        {
            string query = "select* from KhachHang";
            DataTable data = clsConnect.Instance.exQuery(query);
            int dem = 0;
            foreach (DataRow item in data.Rows)
            {
                dem++;

            }
            if (dem > 0)
                return true;
            return false;
        }

        private void btnThem_Click(object sender, EventArgs e)

        {
            if (cbMaKH.Text == ""||txtTenKH.Text=="" )
            {
                MessageBox.Show(" Vui lòng nhập thông tin đầy đủ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                //if (KiemTraMa(cbMaKH.Text) == true)
                //{
                //    MessageBox.Show(" trung ma");
                //    return;
                //}
               
                try
                    {
                        string query = " insert into KhachHang values('" + cbMaKH.Text + "',N'" + txtTenKH.Text + "','" + txtNgaySinh.Text + "',N'" + txtSDT.Text + "',N'" + txtDiaChi.Text + "','" + txtGmail.Text + "')";
                        DataTable data = clsConnect.Instance.exQuery(query);
                        MessageBox.Show(" Thêm Thành Công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        LoadDL();
                    }
                catch
                    {
                        MessageBox.Show(" Thêm thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }               
               
            }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cbMaKH.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập thông tin cần sửa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else

            {
                try
                {
                    string query = " update KhachHang set TenKH=N'" + txtTenKH.Text + "',NgaySinh='" + txtNgaySinh.Text + "',SDT='" + txtSDT.Text + "',DiaChi=N'" + txtDiaChi.Text + "',GmailKH='" + txtGmail.Text + "' where MaKH='" + cbMaKH.Text + "'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show(" Sửa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LoadDL();

                }
                catch
                {
                    MessageBox.Show(" Sửa thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
               
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cbMaKH.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng xóa","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                string query = " delete KhachHang where MaKH='" + cbMaKH.Text + "'";
                DataTable data = clsConnect.Instance.exQuery(query);
               
                MessageBox.Show(" Xóa thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDL();
                
            }
            catch
            {
                MessageBox.Show(" Xóa thất bại","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
           






        }

        private void txtNgaySinh_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }
