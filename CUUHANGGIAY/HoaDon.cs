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
            checkBox1.Checked = false;
        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaHD.Enabled = true;
            lammoi();
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
                MessageBox.Show("Thêm thành công","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
                string a = "";
                if (checkBox1.Checked)
                {
                    a = "True";
                }
                else if (checkBox1.Checked = false)
                {
                    a = "False";
                }
                try
                {
                    string query = "update HoaDon set NgayLap='"+txtNgayLap.Text+"',TongTien='"+txtTongTien.Text+"',TinhTrangHD=N'"+a+"',MaKH='"+txtMaKH.SelectedValue.ToString()+"',MaNV=N'"+cbTenNV.SelectedValue.ToString()+"' where MaHD='"+txtMaHD.Text+"'";
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

        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHD.Enabled = false;
            int i;

            i = dgvHD.CurrentRow.Index;
            txtMaHD.Text = dgvHD.Rows[i].Cells[0].Value.ToString();

            txtNgayLap.Text = dgvHD.Rows[i].Cells[1].Value.ToString();
            txtTongTien.Text = dgvHD.Rows[i].Cells[2].Value.ToString();
            checkBox1.Checked = Convert.ToBoolean(dgvHD.Rows[i].Cells[3].Value);
            cbTenNV.Text = dgvHD.Rows[i].Cells[4].Value.ToString();
            txtMaKH.Text = dgvHD.Rows[i].Cells[5].Value.ToString();
            if (dgvHD.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                CTHD cthd = new CTHD(txtMaHD.Text, cbTenNV.Text, txtMaKH.Text, txtNgayLap.Text, txtTongTien.Text, checkBox1.Checked.ToString());


                cthd.ShowDialog();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTongTien_KeyPress(object sender, KeyPressEventArgs e)
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

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            //// Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Danh sách hóa đơn";
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã hóa đơn";
            worksheet.Cells[3, 3] = "Ngày lập";
            worksheet.Cells[3, 4] = "Tổng tiền";
            worksheet.Cells[3, 5] = "Tên nhân viên";
            worksheet.Cells[3, 6] = "Tên khách hàng";

            for (int i = 0; i < dgvHD.RowCount-1; i++)
            {
                //    for (int i = 0; i < dgvHD.RowCount - 1; i++)
                //    {
                worksheet.Cells[i + 4, 1] = i + 1;
                worksheet.Cells[i + 4, 2] = dgvHD.Rows[i].Cells["mahoadon"].Value;
                //Console.WriteLine(dgvHD.Rows[i].Cells["mahoadon"].Value);
                worksheet.Cells[i + 4, 3] = dgvHD.Rows[i].Cells["NgayLap"].Value;
                worksheet.Cells[i + 4, 4] = dgvHD.Rows[i].Cells["TongTien"].Value;
                worksheet.Cells[i + 4, 5] = dgvHD.Rows[i].Cells["TenNV"].Value;
                worksheet.Cells[i + 4, 6] = dgvHD.Rows[i].Cells["TenKH"].Value;
                //        worksheet.Cells[i + 4, 7] = dgvHD.Rows[i].Cells["DONGIA"].Value;
                //        worksheet.Cells[i + 4, 8] = dgvHD.Rows[i].Cells["thanhtien"].Value;
                //        worksheet.Cells[i + 4, 9] = dgvHD.Rows[i].Cells["MAGIOVANG"].Value;
                //        worksheet.Cells[i + 4, 10] = dgvHD.Rows[i].Cells["NGAYLAPHD"].Value;
                //    }
                worksheet.Range["A1", "F1000"].Font.Name = "Times New Roman";
                worksheet.Range["A1", "F1"].Font.Size = 24;
                worksheet.Range["A3", "F100"].Font.Size = 11;
                worksheet.Range["A1", "F1"].MergeCells = true;
                worksheet.Range["A1", "F1"].Font.Bold = true;
                worksheet.Range["A3", "F3"].Font.Bold = true;
                //    //// dinh dạng text
                    worksheet.Range["A1", "F1"].HorizontalAlignment = 3;
                    worksheet.Range["A3", "F3"].HorizontalAlignment = 3;
                //    worksheet.Cells[dgvHD.RowCount + 4, 7] = "Tổng tiền";
                //    worksheet.Cells[dgvHD.RowCount + 4, 8] = txtTT.Text.ToString();

                //for (int j = 0; j < 5; j++)
                //{
                //    worksheet.Cells[i + 4, 1] = i + 1;
                //    worksheet.Cells[i + 4, j + 2] = dgvHD.Rows[i].Cells[j].Value;
                //}
            }
            //int dem = dgv_lich.Rows.Count;
            ////dinh dạng trang
            //worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            //worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            //worksheet.PageSetup.LeftMargin = 0;
            //worksheet.PageSetup.RightMargin = 0;
            //worksheet.PageSetup.TopMargin = 0;
            //worksheet.PageSetup.BottomMargin = 0;
            ////dinh dạng cot
            worksheet.Range["A1"].ColumnWidth = 6;
            worksheet.Range["B1"].ColumnWidth = 10;
            worksheet.Range["C1"].ColumnWidth = 15;
            worksheet.Range["D1"].ColumnWidth = 15;
            worksheet.Range["E1"].ColumnWidth = 20;
            worksheet.Range["F1"].ColumnWidth = 20;
            //worksheet.Range["G1"].ColumnWidth = 10.5;
            //worksheet.Range["H1"].ColumnWidth = 11;
            //worksheet.Range["I1"].ColumnWidth = 11;
            //worksheet.Range["J1"].ColumnWidth = 11;
            //// dinh dang chữ
            worksheet.Range["A1", "F1000"].Font.Name = "Times New Roman";
            worksheet.Range["A1", "F1"].Font.Size = 24;
            worksheet.Range["A3", "F100"].Font.Size = 11;
            worksheet.Range["A1", "F1"].MergeCells = true;
            worksheet.Range["A1", "F1"].Font.Bold = true;
            worksheet.Range["A3", "F3"].Font.Bold = true;
            //// kẻ bảng
           // worksheet.Range["A3", "F" + (dem + 3)].Borders.LineStyle = 1;
            //// dinh dạng text
            //worksheet.Range["A1", "I1"].HorizontalAlignment = 3;
            //worksheet.Range["A3", "I3"].HorizontalAlignment = 3;
            //worksheet.Range["A4", "A" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["D4", "D" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["E4", "E" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["F4", "F" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["G4", "G" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["H4", "H" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["I4", "I" + (dem + 4)].HorizontalAlignment = 3;
            //worksheet.Range["j4", "J" + (dem + 4)].HorizontalAlignment = 3;
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

           
        }

        private void gunaButton2_Click_1(object sender, EventArgs e)
        {
            KhachHang back = new KhachHang();
            back.Visible = true;
        }

        private void gunaButton2_Click_2(object sender, EventArgs e)
        {
            

            KhachHang back = new KhachHang();
            back.Visible = true;
        }
    }
}
