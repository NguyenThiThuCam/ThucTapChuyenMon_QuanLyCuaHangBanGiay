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
            string query = "select hd.MaHD,sp.MaSP,sp.TenSP,nv.TenNV,ct.MauSac,ct.Size,ct.SoLuongBan,ct.ThanhTien,hd.TinhTrangHD,hd.NgayLap,kh.TenKH from HoaDon HD,CTHD ct,SanPham sp,NhanVien nv,KhachHang kh where HD.MaNV = nv.MaNV and hd.MaHD = ct.MaHD and sp.MaSP = ct.MaSP";
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

        }

        private void dgvCT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvCT.CurrentRow.Index;
            txtMaHD.Text = dgvCT.Rows[i].Cells[0].Value.ToString();
            txtMaSP.Text=dgvCT.Rows[i].Cells[1].Value.ToString();
            txtTenSP.Text= dgvCT.Rows[i].Cells[2].Value.ToString();
            txtTenNV.Text= dgvCT.Rows[i].Cells[3].Value.ToString();
            txtMaSac.Text= dgvCT.Rows[i].Cells[4].Value.ToString();
            txtSize.Text= dgvCT.Rows[i].Cells[5].Value.ToString();
            txtSoLuong.Text= dgvCT.Rows[i].Cells[6].Value.ToString();
            txtThanhTien.Text= dgvCT.Rows[i].Cells[7].Value.ToString();
            txtTinhTrang.Text= dgvCT.Rows[i].Cells[8].Value.ToString();
            datetimeNL.Text = dgvCT.Rows[i].Cells[9].Value.ToString();
            txtKH.Text= dgvCT.Rows[i].Cells[10].Value.ToString();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoaDon back = new HoaDon();
            back.Visible = true;
        }

        private void datetimeNL_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
