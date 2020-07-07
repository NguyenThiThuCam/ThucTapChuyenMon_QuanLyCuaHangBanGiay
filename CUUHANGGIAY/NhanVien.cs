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
        
        
        

        public NhanVien()
        {
            InitializeComponent();
            LoadDL();
            LoadComBobox();
            txtMaTaiKhoan.SelectedIndex = -1;
        }
        public void LoadDL()
        {
            string query = "select * from NhanVien nv,TaiKhoan tk where nv.MaTK=tk.MaTK ";

            DataTable data = clsConnect.Instance.exQuery(query);
            dgv.AutoGenerateColumns = false;

            dgv.DataSource = data;
            
          
        }
        public void LoadComBobox()
        {
            string query = " select * from TaiKhoan";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtMaTaiKhoan.DataSource = data;
            txtMaTaiKhoan.ValueMember = "MaTK";
            txtMaTaiKhoan.DisplayMember = "TenTK";

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
        public bool KiemTraMa(string MaNV)
        {
            string query = "select* from NhanVien";
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
            if (txtmnv.Text == "" || txttenNV.Text == "")
            {
                MessageBox.Show(" Vui long nhap day du thong tin");

            }
            else
            {
                //if (KiemTraMa(txtmnv.Text) == true)
                //{
                //    MessageBox.Show(" Ma da trung");
                //    return;
                //}
               try
               {
                    string query = " insert into NhanVien values('" + txtmnv.Text + "',N'" + txttenNV.Text + "','" + txtNgaySinh.Text + "','" + txtNgayvaolam.Text + "','" + txtLuong.Text + "','" + txtSDT.Text + "','" + txtMail.Text + "','" + txtMaTaiKhoan.SelectedValue.ToString()+ "')";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show(" Them thanh cong");
               

                    LoadDL();
                lammoi();

                  }
               catch
               {
                   MessageBox.Show(" Them That bai");
               }
            }
            
           
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmnv.Text==" ")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string query = "update NhanVien set TenNV=N'" + txttenNV.Text + "',NgaySinh='" + txtNgaySinh.Text + "',NgayVaoLam='" + txtNgayvaolam.Text + "',Luong='" + txtLuong.Text + "',SDTNV='" + txtSDT.Text + "',GmailNV='" + txtMail.Text + "' where MANV='"+txtmnv.Text+"'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDL();
                    lammoi();
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmnv.Text=="") {
                MessageBox.Show("Vui lòng chọn dòng xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
                }
            try
            {
                string query = "delete NhanVien where MaNV='" + txtmnv.Text + "'";
                DataTable data = clsConnect.Instance.exQuery(query);
                
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();
                lammoi();
            }
            catch {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
        void lammoi()
        {
            txtmnv.Text = " ";
            
            txtMail.Text = " ";
            //txtNgaySinh.Text = " ";
            //txtNgayvaolam.Text = " ";
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
            

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgv.CurrentRow.Index;
            txtmnv.Text = dgv.Rows[i].Cells[0].Value.ToString();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtMaTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
