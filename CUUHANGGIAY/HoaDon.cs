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
      
        public HoaDon()
        {
            InitializeComponent();
            LoadDL();
            LoadComBoBox();
            cbTenNV.SelectedIndex = -1;

        }
        public void LoadDL()
        {
            string query = " select *from HoaDon hd, NhanVien nv where hd.MaNV=hd.MaNV and MaHD='"+txtMaHD.Text+"' ";
            DataTable data = clsConnect.Instance.exQuery(query);
          //  dgvHD.AutoGenerateColumns = false;
            dgvHD.DataSource = data;
        } public void LoadComBoBox()
        {
            string query = " select * from NhanVien ";
            DataTable data = clsConnect.Instance.exQuery(query);
            cbTenNV.DataSource = data;
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DisplayMember = "TenNV";
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {

            
        }
        void lammoi()
        {
            txtMaHD.Text = " ";
            txtMaKH.Text = " ";
            cbTenNV.Text = " ";
            txtNgayLap.Text = " ";
            txtTongTien.Text = " ";
            txtTinhTrang.Text = " ";
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvHD.CurrentRow.Index;
            txtMaHD.Text=dgvHD.Rows[i].Cells[0].Value.ToString();
            txtNgayLap.Text=dgvHD.Rows[i].Cells[1].Value.ToString();
            txtTongTien.Text=dgvHD.Rows[i].Cells[2].Value.ToString();
            
            cbTenNV.Text=dgvHD.Rows[i].Cells[4].Value.ToString();
           txtMaKH.Text=dgvHD.Rows[i].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
           // try
           // {
                string query = "insert into HoaDon values('"+cbTenNV.SelectedValue.ToString()+"','"+txtMaKH.Text+"','"+txtNgayLap.Text+"','"+txtTongTien.Text+"','"+txtTinhTrang.Text+"')";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Thêm thành công","Thông báo" ,MessageBoxButtons.OK,MessageBoxIcon.Information);
                LoadDL();
              
         //   }
            //catch
            //{
            //    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text=="")
            {
                MessageBox.Show("Vui lòng nhập dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string query = "delete HoaDon set MaHD='"+txtMaHD.Text+"'";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();
                LoadComBoBox();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaHD.Text=="")
            { MessageBox.Show("Vui lòng nhập thông tin cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = "update HoaDon set NgayLap='"+txtNgayLap.Text+"',TongTien='"+txtTongTien.Text+"',TinhTrangHD=N'"+txtTinhTrang.Text+"',MaKH='"+txtMaKH.Text+"',TenKH=N'"+cbTenNV.Text+"' where MaHD='"+txtMaHD.Text+"'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công", "Thông bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    LoadComBoBox();
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }
    }
}
