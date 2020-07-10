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
    public partial class PhieuNhap : Form
    {
        public PhieuNhap()
        {
            InitializeComponent();
           
            cbTenNV.SelectedIndex = -1;
        }
        void lammoi()
        {
            txtMaPN.Text = " ";
            cbTenNV.Text = " ";
            CbNCC.Text = "";
            cbTinhTrang.Text = "";
            txtTongTien.Text = "";
        }
        public void LoadDL()
        {
            string query = "select *from PhieuNhap pn,NhanVien nv,NhaCungCap ncc where pn.MaNV=nv.MaNV and pn.MaNCC=ncc.MaNCC ";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvPN.AutoGenerateColumns = false;
            dgvPN.DataSource = data;
            
        } public void LoadComBobox()
        {
            string query = "select *from NhanVien";
            DataTable data = clsConnect.Instance.exQuery(query);
            cbTenNV.DataSource = data;
            cbTenNV.ValueMember = "MaNV";
            cbTenNV.DisplayMember = "TenNV";
        } 
        public void LoadComBoboxNCC()
        {
            string query = "select *from NhaCungCap ";
            DataTable data = clsConnect.Instance.exQuery(query);
            CbNCC.DataSource = data;
            CbNCC.ValueMember = "MaNCC";
            CbNCC.DisplayMember = "TenNCC";




        }

        public bool KiemTraMa(string MaPN)
        {
            string query = "select *from PhieuNhap";
            DataTable data = clsConnect.Instance.exQuery(query);
            int dem = 0;
            foreach(DataRow item in data.Rows)
            {
                dem++;
            }
            if (dem > 0)
                return true;
            return false;
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
           i= dgvPN.CurrentRow.Index;
            txtMaPN.Text = dgvPN.Rows[i].Cells[0].Value.ToString();
            DatetimeNS.Text =dgvPN.Rows[i].Cells[1].Value.ToString();
            txtTongTien.Text= dgvPN.Rows[i].Cells[2].Value.ToString();
           cbTinhTrang.Text= dgvPN.Rows[i].Cells[3].Value.ToString();
           CbNCC.Text= dgvPN.Rows[i].Cells[4].Value.ToString();
          cbTenNV.Text= dgvPN.Rows[i].Cells[5].Value.ToString();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = " insert into PhieuNhap values('"+txtMaPN.Text+"','"+DatetimeNS.Text+"','"+txtTongTien.Text+"',N'"+cbTinhTrang.Text+"',N'"+CbNCC.Text+"',N'"+cbTenNV.Text+"')";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK , MessageBoxIcon.Information);
                    LoadDL();
                    LoadComBobox();
                }
                catch
                {
                    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if ( txtMaPN.Text== "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try {

                    string query = " update PhieuNhap set MaNCC='" + CbNCC.Text + "', NgayLap='" + DatetimeNS.Text + "',MaNV='"+cbTenNV.Text+"',TinhTrang='"+cbTinhTrang.Text+"',TongTienNhap='"+txtTongTien.Text+"'where MaPN='"+txtMaPN.Text+"'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPN.Text == "")
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string query = " delete PhieuNhap where MaPN= '"+txtMaPN.Text+"'";
                DataTable data = clsConnect.Instance.exQuery(query);
                LoadDL();
                MessageBox.Show("Xóa thành công.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show("Xóa thất bại.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadComBobox();
            LoadComBoboxNCC();

        }
        public void TimKiemMa()
        {
            string query = " select *from PhieuNhap where MaPN like '%" + txtMaPN.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvPN.DataSource = data;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemMa();
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDL();
            LoadComBobox();
        }
        public void TimKiemTheoTextChan()
        {
            string query = " select *from PhieuNhap pn,NhanVien nv,NhaCungCap ncc where pn.MaNV=nv.MaNV and MaPN like '%" + txtTimKiem.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvPN.DataSource = data;

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoTextChan();
        }
    }
}
