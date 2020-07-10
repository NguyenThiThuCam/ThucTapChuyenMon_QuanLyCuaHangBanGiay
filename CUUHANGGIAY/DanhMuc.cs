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
    public partial class DanhMuc : Form
    {
        public DanhMuc()
        {
            InitializeComponent();
            LoadDL();
            LoadCombox();
        }
        public void LoadDL()
        {
            string query = " select *from LoaiSp";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvDM.DataSource = data;
        } public void LoadCombox()
        {
            string query = "select *from LoaiSP";
            DataTable data = clsConnect.Instance.exQuery(query);
            cbLoaigiay.DataSource = data;
            cbLoaigiay.ValueMember = "TenLoai";
        }public bool KiemTraMa(string MaLoai)
        {

            string query = " select *from LoaiSP";
            DataTable data = clsConnect.Instance.exQuery(query);
            int dem = 0;
            foreach(DataRow item in data.Rows)
            {
                dem++;
            } if(dem>0)
            {
                return true;
            }
            return false;
        }

        private void lbMaKH_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = " update LoaiSP set TenLoai=N'" + cbLoaigiay.Text + "'where MaLoai='" +txtmaloai.Text + "'";
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
        void lammoi()
        {
            txtmaloai.Text = "";
            cbLoaigiay.Text = "";
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            lammoi();
        }

        private void dgvDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvDM.CurrentRow.Index;
            txtmaloai.Text = dgvDM.Rows[i].Cells[0].Value.ToString();
            cbLoaigiay.Text = dgvDM.Rows[i].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text == "" ||cbLoaigiay.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = " insert into LoaiSP values('" + txtmaloai.Text + "' ,N'"+cbLoaigiay.Text+"')";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    LoadCombox();

                }
                catch
                {
                    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
              
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtmaloai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dòng cần xóa.","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string query = " delete LoaiSP where MaLoai='" + txtmaloai.Text + "'";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();
                LoadCombox();
            }
            catch
            {
                MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public void TimKiemMa()
        {
            string query = " select *from LoaiSP where MaLoai like '%"+txtmaloai.Text+"%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvDM.DataSource = data;
        }
       
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            TimKiemMa();              
       
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            LoadDL();
            LoadCombox();
        }
        public void TimKiemTheoTextChan()
        {

            string query = " select *from LoaiSP where MaLoai like '%" + txtTimKiem.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvDM.DataSource = data;

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoTextChan();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
