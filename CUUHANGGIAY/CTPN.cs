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
    public partial class CTPN : Form
        
    {
        private String mapn;
        private String tennv;
        private String tenncc;
        private String ngay;
        private String thanhtien;
        private String tinhtrang;

        public string Mapn { get => mapn; set => mapn = value; }
        public string Tennv { get => tennv; set => tennv = value; }
        public string Tenncc { get => tenncc; set => tenncc = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string Thanhtien { get => thanhtien; set => thanhtien = value; }
        public string Tinhtrang { get => tinhtrang; set => tinhtrang = value; }

        public CTPN()
        {
            InitializeComponent();
        }
        public CTPN(string mapn,string tennv,string tenncc,string ngay,string thanhtien,string tinhtrang)
        {
            this.mapn = mapn;
            this.tennv = tennv;
            this.tenncc = tenncc;
            this.ngay = ngay;
            this.thanhtien = thanhtien;
            this.tinhtrang = tinhtrang;
            InitializeComponent();
        }
        public void LoadDL()
        {
            string query = "select pn.MaPN,ncc.TenNCC,nv.TenNV,ct.MaSP,sp.TenSP,ct.MauSac,ct.Size,ct.SoLuongNhap,pn.NgayLap,ct.ThanhTien,pn.TinhTrang from NhaCungCap ncc,CTPN ct,SanPham sp,NhanVien nv,PhieuNhap pn where pn.MaNV = nv.MaNV and pn.MaPN = ct.MaPN and sp.MaSP = ct.MaSP and pn.MaNCC = ncc.MaNCC";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvCTPN.DataSource = data;
            string query2 = "select ct.MaSP,sp.TenSP,ct.MauSac,ct.Size,ct.SoLuongNhap from CTPN ct,SanPham sp where ct.mapn='" + mapn + "'";
            Console.WriteLine(query2);
            DataTable data2 = clsConnect.Instance.exQuery(query2);
            if (data2.Rows.Count > 0)
            {
                txtMaSP.Text = data2.Rows[0].ItemArray[0].ToString();
                txtTenSP.Text = data2.Rows[0].ItemArray[1].ToString();
                txtMauSac.Text = data2.Rows[0].ItemArray[2].ToString();
                txtSize.Text = data2.Rows[0].ItemArray[3].ToString();
                txtSoLuong.Text = data2.Rows[0].ItemArray[4].ToString();
               
               
            }
        }
        public void LoadChiTietPN()
        {
            txtMaPN.Text = mapn;
            cbTenNV.Text = tennv;
            cbTenNCC.Text = tenncc;
            Console.WriteLine(ngay);
            dateTimeNL.Value = Convert.ToDateTime(ngay);
            txtThanhTien.Text = thanhtien;
            txtTinhTrang.Text = tinhtrang;




        }
        private void CTPN_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadChiTietPN();
        }

        private void dgvCTPN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvCTPN.CurrentRow.Index;
            txtMaPN.Text=dgvCTPN.Rows[i].Cells[0].Value.ToString();
            cbTenNCC.Text=dgvCTPN.Rows[i].Cells[1].Value.ToString();
            cbTenNV.Text = dgvCTPN.Rows[i].Cells[2].Value.ToString();
            txtMaSP.Text = dgvCTPN.Rows[i].Cells[3].Value.ToString();
            txtTenSP.Text = dgvCTPN.Rows[i].Cells[4].Value.ToString();
            txtMauSac.Text = dgvCTPN.Rows[i].Cells[5].Value.ToString();
            txtSize.Text = dgvCTPN.Rows[i].Cells[6].Value.ToString();
            txtSoLuong.Text = dgvCTPN.Rows[i].Cells[7].Value.ToString();
            dateTimeNL.Text = dgvCTPN.Rows[i].Cells[8].Value.ToString();
            txtThanhTien.Text = dgvCTPN.Rows[i].Cells[9].Value.ToString();
            txtTinhTrang.Text = dgvCTPN.Rows[i].Cells[10].Value.ToString();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
