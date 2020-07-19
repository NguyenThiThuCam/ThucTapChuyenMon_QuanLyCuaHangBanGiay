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
    public partial class CTHD : Form
    {
        private String mahd;
        private String tennv;
        private String makh;
        private String ngay;
        private String tongtien;
        private String tinhtrang;

        public string Mahd { get => mahd; set => mahd = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Makh { get => makh; set => makh = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string Tongtien { get => tongtien; set => tongtien = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public CTHD()
        {
            InitializeComponent();

        }
        public CTHD(string mahd, string tennv, string makh, string ngay, string tongtien, string tinhtrang)
        {
            this.mahd = mahd;
            this.tennv = tennv;
            this.makh = makh;
            this.ngay = ngay;
            this.tongtien = tongtien;
            this.tinhtrang = tinhtrang;
            InitializeComponent();
        }
        public void LoadChiTietPN()
        {
            txtMaHD.Text = mahd;
           txtTenNV.Text = tennv;
           txtKH.Text = makh;
            Console.WriteLine(ngay);
           datetimeNL.Value = Convert.ToDateTime(ngay);
             txtThanhTien.Text = tongtien;
            txtTinhTrang.Text = tinhtrang;




        }
        public void LoadDL()
        {
            string a = "";
            if (txtTinhTrang.Checked)
            {
                a = "True";
            }
            else if (txtTinhTrang.Checked = false)
            {
                a = "False";
            }
            string query = "select sp.MaSP,sp.TenSP,ct.MauSac,ct.Size,ct.SoLuongBan from HoaDon HD,CTHD ct,SanPham sp,NhanVien nv,KhachHang kh where ct.mahd='" + mahd + "'and hd.mahd='"+mahd+"'and HD.MaNV=nv.MaNV and HD.MaKH=kh.MaKH";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvCT.DataSource = data;
            string query2 = "select sp.MaSP,sp.TenSP,ct.MauSac,ct.Size,ct.SoLuongBan from HoaDon HD,CTHD ct,SanPham sp,NhanVien nv,KhachHang kh where ct.mahd='" + mahd + "'";
            DataTable data2 = clsConnect.Instance.exQuery(query2);          
            if (data2.Rows.Count > 0)
            {
                txtMaSP.Text = data2.Rows[0].ItemArray[0].ToString();
                txtTenSP.Text = data2.Rows[0].ItemArray[1].ToString();
                txtMaSac.Text = data2.Rows[0].ItemArray[2].ToString();
                txtSize.Text = data2.Rows[0].ItemArray[3].ToString();
                txtSoLuong.Text = data2.Rows[0].ItemArray[4].ToString();


            }
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void CTHD_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadChiTietPN();
            LoadCombobox();
            LoadComboboxMaSP();
            LoadComboboxMauSac();

        }

        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void datetimeNL_ValueChanged(object sender, EventArgs e)
        {

        }
        public void LoadCombobox()
        {
            string query = "select *from SanPham";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtTenSP.DataSource = data;
            txtTenSP.ValueMember = "MaSP";

            txtTenSP.DisplayMember = "TenSP";
        }
        public void LoadComboboxMaSP()
        {
            string query = "select *from SanPham";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtMaSP.DataSource = data;
            txtMaSP.ValueMember = "MaSP";
            

            
        }
        public void LoadComboboxMauSac()
        {
            string query = "select *from CTSP";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtMaSac.DataSource = data;
            txtMaSac.ValueMember = "MauSac";
            txtSize.DataSource = data;
            txtSize.ValueMember = "Size";

        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {


        }

        private void dgvCT_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i;
            i = dgvCT.CurrentRow.Index;
            txtMaHD.Text = dgvCT.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text = dgvCT.Rows[i].Cells[1].Value.ToString();
            txtTenSP.Text = dgvCT.Rows[i].Cells[2].Value.ToString();
            txtTenNV.Text = dgvCT.Rows[i].Cells[3].Value.ToString();
            txtMaSac.Text = dgvCT.Rows[i].Cells[4].Value.ToString();
            txtSize.Text = dgvCT.Rows[i].Cells[5].Value.ToString();
            txtSoLuong.Text = dgvCT.Rows[i].Cells[6].Value.ToString();
            txtThanhTien.Text = dgvCT.Rows[i].Cells[7].Value.ToString();
            txtTinhTrang.Text = dgvCT.Rows[i].Cells[8].Value.ToString();
            datetimeNL.Text = dgvCT.Rows[i].Cells[9].Value.ToString();
            txtKH.Text = dgvCT.Rows[i].Cells[10].Value.ToString();
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Mời bạn nhập số", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Mời bạn nhập số", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void txtThanhTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Mời bạn nhập số", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }
    }
}

