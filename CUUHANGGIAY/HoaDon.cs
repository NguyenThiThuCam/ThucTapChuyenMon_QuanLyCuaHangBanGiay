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
        private string strConn = @"Data Source=CAMCAM\SQLEXPRESS;Initial Catalog=CUAHANGGIAY;Integrated Security=True";
        public HoaDon()
        {
            InitializeComponent();
           
            cbTenNV.SelectedIndex = -1;

        }
        public void LoadDL()
        {
            string query = " select* from HoaDon hd, NhanVien nv,KhachHang kh  where hd.MaNV = nv.MaNV and hd.MaKH = kh.MaKH";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvHD.AutoGenerateColumns = false;
            dgvHD.DataSource = data;
        } public void LoadComBoBox()
        {
            string query = " select * from NhanVien ";
            DataTable data = clsConnect.Instance.exQuery(query);
            cbTenNV.DataSource = data;
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DisplayMember = "TenNV";

        }
        public void loadkh()
        {
            string query = " select *from KhachHang";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtMaKH.DataSource = data;
            txtMaKH.ValueMember = "MaKH";
            txtMaKH.DisplayMember="TenKH";

        }
       

        private void HoaDon_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadComBoBox();
            loadkh();

        }
        void lammoi()
        {
            txtMaHD.Text = " ";
            txtMaKH.Text = " ";
            cbTenNV.Text = " ";
            DateTime d = DateTime.Now;
            txtNgayLap.Text = d.ToString();
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
            txtTinhTrang.Text=dgvHD.Rows[i].Cells[3].Value.ToString();

            cbTenNV.Text=dgvHD.Rows[i].Cells[4].Value.ToString();
           txtMaKH.Text=dgvHD.Rows[i].Cells[5].Value.ToString();
            if (dgvHD.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                CTHD cthd = new CTHD(txtMaHD.Text, cbTenNV.Text,txtMaKH.Text,txtNgayLap.Text,txtTongTien.Text, txtTinhTrang.Text);

                
                cthd.ShowDialog();
            }

        }
        private void moform(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            string querry = "insert into hoadon values(@ngaylap,@tongtien,@tinhtranghd,@manv,@makh)";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand command = new SqlCommand(querry, conn);
           
            command.Parameters.AddWithValue("@ngaylap", txtNgayLap.Value.ToString("yyyy/MM/dd"));
           
            command.Parameters.AddWithValue("@tongtien", 0);
            command.Parameters.AddWithValue("@tinhtranghd", false);
            command.Parameters.AddWithValue("@manv", cbTenNV.SelectedValue.ToString());
            command.Parameters.AddWithValue("@makh", txtMaKH.SelectedValue.ToString());
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                HoaDon_Load(sender, e);
                MessageBox.Show("thêm thanh cong");
            }
            conn.Close();
       
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
                string query = "delete HoaDon where MaHD='"+txtMaHD.Text+"'";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();

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
                    string query = "update HoaDon set NgayLap='"+txtNgayLap.Text+"',TongTien='"+txtTongTien.Text+"',TinhTrangHD=N'"+txtTinhTrang.Text+"',MaKH='"+txtMaKH.SelectedValue.ToString()+"',MaNV=N'"+cbTenNV.SelectedValue.ToString()+"' where MaHD='"+txtMaHD.Text+"'";
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
        public void TimKiemMa()
        {
            string query = " select *from HoaDon where MaHD like '%" + txtMaHD.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvHD.DataSource = data;
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemMa();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDL();
            LoadComBoBox();
    
        }
        public void TimKiemTheoTextChan( )
        {

            //string query = " select * from HoaDon where like TenNV '%" + txtTimKiem.Text + "%' ";
            //DataTable data = clsConnect.Instance.exQuery(query);
            //cbTenNV.DataSource = data;
            //cbTenNV.ValueMember = "MaNV";
            //cbTenNV.DisplayMember = "TenNV";

            string query = " select* from HoaDon hd, NhanVien nv,KhachHang kh  where hd.MaNV = nv.MaNV and hd.MaKH = kh.MaKH and  nv.tenNv like N'%" + txtTimKiem.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvHD.DataSource = data;



        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            
            TimKiemTheoTextChan();
           
        }

        private void txtNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }
        public static int mahd;
        private void IN_Click(object sender, EventArgs e)
        {
            try { mahd = Convert.ToInt32(txtMaHD.Text.Trim()); }
            catch { }
            
            
            InHoaDon back = new InHoaDon();
            back.Visible = true;

           
        }
      
    }
}
