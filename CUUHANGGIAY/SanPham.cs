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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
            LoadDL();
            LoadCombobox();
            cbMaLoai.SelectedIndex = -1;
          
        }
        public void LoadDL()
        {
            string query = "select *from SanPham sp,LoaiSP lsp where sp.MaLoai=lsp.MaLoai";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvSP.AutoGenerateColumns = false;
            dgvSP.DataSource = data;

        } public void LoadCombobox(){
            string query = "select *from LoaiSP";
            DataTable data = clsConnect.Instance.exQuery(query);
            cbMaLoai.DataSource = data;
            cbMaLoai.ValueMember = "MaLoai";
           
            cbMaLoai.DisplayMember = "TenLoai";

        }

        private void lbMaKH_Click(object sender, EventArgs e)
        {

        }
        void lammoi()
        {
            cbTenSP.Text = " ";
            cbMaLoai.Text = " ";
            txtMaSP.Text = " ";
            

        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();

        }
        int x = 125, y = 4, a = 1;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = "insert into SanPham values('" + txtMaSP.Text + "',N'" + cbTenSP.Text + "','" + cbMaLoai.Text + "')";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    LoadCombobox();

                }
                catch
                {
                    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvSP.CurrentRow.Index;
            txtMaSP.Text=dgvSP.Rows[i].Cells[0].Value.ToString();
            cbTenSP.Text=dgvSP.Rows[i].Cells[1].Value.ToString();
            cbMaLoai.Text=dgvSP.Rows[i].Cells[3].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaSP.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = "update SanPham set TenSP=N'"+cbTenSP.Text+"', TenLoai=N'"+cbMaLoai.SelectedValue.ToString()+"' where MaSP='"+txtMaSP.Text+"' ";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    LoadCombobox();

                }
                catch
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(txtMaSP.Text=="")
            {
                MessageBox.Show("Vui lòng nhập dòng  cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                String query = "delete SanPham where MaSP='"+txtMaSP.Text+"'";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();
                LoadCombobox();

            }
            catch
            {
                MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        Random random = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                label1.Location = new Point(x, y);
                if(x>=852)
                    {
                    a = -1;
                    
                }
                if (x< 125)
                {
                    a = 1;
                   


                }
                

            }
            catch (Exception) { }
        }
    }
}
