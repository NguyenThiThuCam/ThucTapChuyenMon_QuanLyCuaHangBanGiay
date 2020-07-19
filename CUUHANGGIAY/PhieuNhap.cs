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
         private string strConn = @"Data Source=CAMCAM\SQLEXPRESS;Initial Catalog=CUAHANGGIAY;Integrated Security=True";
        public PhieuNhap()
        {
            InitializeComponent();
           
            cbTenNV.SelectedIndex = -1;
        }
        void lammoi()
        {
            txtMaPN.Text = " ";
            cbTenNV.Text = " ";
            DateTime d = DateTime.Now;
            dateTimeNL.Text = d.ToString();
           
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
            txtMaPN.Enabled = true;
            lammoi();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           


            if (dgvPN.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                CTPN ctpn = new CTPN(txtMaPN.Text, CbNCC.Text, cbTenNV.Text, dateTimeNL.Text, txtTongTien.Text,cbTinhTrang.Text);

                
                ctpn.ShowDialog();
            }
        }
        private void moform(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string querry = "insert into PhieuNhap values(@ngaylap,@tongtiennhap,@tinhtrang,@mancc,@manv)";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand command = new SqlCommand(querry, conn);

            command.Parameters.AddWithValue("@ngaylap", dateTimeNL.Value.ToString("yyyy/MM/dd"));

            command.Parameters.AddWithValue("@tongtiennhap", 0);
            command.Parameters.AddWithValue("@tinhtrang", false);
            command.Parameters.AddWithValue("@mancc", CbNCC.SelectedValue.ToString());
            command.Parameters.AddWithValue("@manv", cbTenNV.SelectedValue.ToString());
           
            int a = command.ExecuteNonQuery();
            if (a > 0)
            {
                PhieuNhap_Load(sender, e);
                MessageBox.Show("thêm thanh cong");
            }
            conn.Close();
            //if (txtMaPN.Text=="")
            //{
            //    MessageBox.Show("Vui lòng nhập thông tin cần thêm.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}
            //else
            //{
            //    try
            //    {
            //        string query = " insert into PhieuNhap values('"+txtMaPN.Text+"','"+dateTimeNL.Text+"','"+txtTongTien.Text+"',N'"+cbTinhTrang.Text+"',N'"+CbNCC.Text+"',N'"+cbTenNV.Text+"')";
            //        DataTable data = clsConnect.Instance.exQuery(query);
            //        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK , MessageBoxIcon.Information);
            //        LoadDL();
            //        LoadComBobox();
            //    }
            //    catch
            //    {
            //        MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    }

            //}
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

                    string query = " update PhieuNhap set NgayLap='" + dateTimeNL.Text + "',TongTienNhap='" + txtTongTien.Text + "',TinhTrang='" + cbTinhTrang.Text + "' ,MaNCC='" + CbNCC.SelectedValue.ToString() + "',MaNV='"+cbTenNV.SelectedValue.ToString() + "'where MaPN='"+txtMaPN.Text+"'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    lammoi();
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
                lammoi();

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
            
        }
        public void TimKiemTheoTextChan( string valuatoFind)
        {
            string query = " select *from PhieuNhap pn,NhanVien nv,NhaCungCap ncc where pn.MaNV=nv.MaNV and CONCAT( MaPN,nv.TenNV,ncc.TenNCC) like '%" + valuatoFind + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvPN.DataSource = data;

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoTextChan(txtTimKiem.Text);
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
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

        private void dgvPN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaPN.Enabled = false;
            int i;
            i = dgvPN.CurrentRow.Index;
            txtMaPN.Text = dgvPN.Rows[i].Cells[0].Value.ToString();
            dateTimeNL.Text = dgvPN.Rows[i].Cells[1].Value.ToString();
            txtTongTien.Text = dgvPN.Rows[i].Cells[2].Value.ToString();
            cbTinhTrang.Text = dgvPN.Rows[i].Cells[3].Value.ToString();
            CbNCC.Text = dgvPN.Rows[i].Cells[4].Value.ToString();
            cbTenNV.Text = dgvPN.Rows[i].Cells[5].Value.ToString();

        }
    }
}
