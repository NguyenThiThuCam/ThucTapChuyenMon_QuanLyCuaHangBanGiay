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
       

        }
        public void LoadDL()
        {
            string query = " select sp.MaSP,sp.TenSP,sp.HinhAnh ,lsp.TenLoai from SanPham sp,LoaiSP lsp where sp.MaLoai=lsp.MaLoai";
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
        public void lammoi()
        {
            cbTenSP.Text = "";
            cbMaLoai.Text = "";
            txtMaSP.Text = "";
            pthinh.BackgroundImage = null;
           



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
        public bool kiemtra()
        {
            if (txtMaSP.Text == "" || cbTenSP.Text == "" || cbMaLoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            } else
            return true;
        }
        public void them()
        {
            if(kiemtra())
            {
                try
                {
                    string query = "insert into SanPham values('" + txtMaSP.Text + "',N'" + cbTenSP.Text + "','" + fileImage + "','" + cbMaLoai.SelectedValue.ToString() + "')";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    lammoi();


                } 
                catch (Exception ex)
                {
                    if (ex.GetType() == typeof(SqlException)) // Chỗ này nếu CSDL của bạn là Access thì ko phải là SqlException đâu nhé
                    {
                        if (ex.Message.Contains("PRIMARY KEY"))
                        {
                            MessageBox.Show("Mã sản phẩm đã tồn tại");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        throw ex;
                    }
                }
            }
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaSP.Enabled = true;

            them();
        }
        private string fileImage = "";

        private void dgvSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void moform(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
                txtMaSP.Enabled = true;
                if (txtMaSP.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {

                    try
                    {
                        string query = "update SanPham set TenSP=N'" + cbTenSP.Text + "', MaLoai=N'" + cbMaLoai.SelectedValue.ToString() + "',HinhAnh='" + fileImage + "' where MaSP='" + txtMaSP.Text + "' ";
                        DataTable data = clsConnect.Instance.exQuery(query);
                        MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDL();
                        lammoi();
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
                MessageBox.Show("Sản phẩm đã bán không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void TimKiemMa()
        {
            string query = " select *from SanPham where MaSP like N'%" + txtMaSP.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvSP.DataSource = data;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemMa();

        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDL();
            LoadCombobox();
        }
        public void TimKiemTheoTextChan(string valuatoFind)
        {
           
            string query = " select *from SanPham sp,LoaiSP lsp where sp.MaLoai=lsp.MaLoai and CONCAT(sp.MaSP,sp.TenSP) like '%"+valuatoFind+"%'";

            DataTable data = clsConnect.Instance.exQuery(query);
            dgvSP.DataSource = data;
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoTextChan(txtTimKiem.Text);
        }
       

        private void pthinh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (DialogResult.OK == dialog.ShowDialog())
            {
                dialog.Filter = "insert image(*)|*";
                fileImage = dialog.FileName;
                Image image = new Bitmap(fileImage);
                pthinh.BackgroundImage = image;

            }

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
           

            
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaSP.Enabled = false;
            int i;
            i = dgvSP.CurrentRow.Index;
            txtMaSP.Text = dgvSP.Rows[i].Cells[0].Value.ToString();
            cbTenSP.Text = dgvSP.Rows[i].Cells[1].Value.ToString();
            cbMaLoai.Text = dgvSP.Rows[i].Cells[3].Value.ToString();
            string image = dgvSP.Rows[i].Cells[2].Value.ToString();

            if (image != "")
            {
                Image imageb = new Bitmap(@image);
                pthinh.BackgroundImage = imageb;
                pthinh.SizeMode = PictureBoxSizeMode.StretchImage;
                fileImage = image;
            }
            else
            {
                pthinh.BackgroundImage = null;
                fileImage = "";
            }

        }

        private void dgvSP_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

          
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
