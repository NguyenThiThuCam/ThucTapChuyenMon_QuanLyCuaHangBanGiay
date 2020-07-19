﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUUHANGGIAY
{
    public partial class NhaCungCap : Form
    {
        public NhaCungCap()
        {
            InitializeComponent();
            LoadDL();
            LoadCombobox();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {

        }
        public void LoadDL()
        {
            string query = "select *from NhaCungCap";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvNCC.DataSource = data;
        }
        public void LoadCombobox()
        {
            string query = "select *from NhaCungCap ";
            DataTable data = clsConnect.Instance.exQuery(query);
            cbTenNCC.DataSource = data;
            cbTenNCC.ValueMember = "TenNCC";
                }
        void lammoi()
        {

            txtMaNCC.Text = "";
            txtMail.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            cbTenNCC.Text = "";

        }
        private void btnlammoi_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            lammoi();
        }

        private void dgvNCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        } 
        public bool kiemtra()
        {
            if (txtMaNCC.Text == "" || cbTenNCC.Text == "" || txtDiaChi.Text == "" || txtMail.Text == "" || txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông  tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
                return true;
        }
        public void them()
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (kiemtra())
            {
                MessageBox.Show("Vui lòng nhập thông  tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = "insert into NhaCungCap values('" + txtMaNCC.Text + "',N'" + cbTenNCC.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "','" + txtMail.Text + "')";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    LoadCombobox();
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
                        MessageBox.Show("Thêm mã trùng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                        throw ex;
                    }

                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaNCC.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string query = "update NhaCungCap set TenNCC=N'" + cbTenNCC.Text + "',DiaChiNCC=N'"+txtDiaChi.Text+"',SDTNCC='"+txtSDT.Text+"',GmailNCC='"+txtMail.Text+"' where MaNCC='"+txtMaNCC.Text+"'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDL();
                    LoadCombobox();
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
            if(txtMaNCC.Text=="")
            {
                MessageBox.Show("Vui lòng nhập dòng cần sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string query = "delete NhaCungCap where MaNCC='"+txtMaNCC.Text+"'";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();
                LoadCombobox();
                lammoi();

            }
            catch
            {
                MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void TimKiemMa()
        {
            string query = " select *from NhaCungCap where MaNCC like '%" + txtMaNCC.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvNCC.DataSource = data;
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

            string query = " select *from NhaCungCap where CONCAT( MaNCC,TenNCC,DiaChiNCC) like '%" + txtTimKiem.Text + "%'";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvNCC.DataSource = data;

        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            TimKiemTheoTextChan(txtTimKiem.Text);
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Vui lòng nhập dòng cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;

            }
            try
            {
                string query = "delete NhaCungCap where MaNCC='" +txtMaNCC.Text+ "'";
                DataTable data = clsConnect.Instance.exQuery(query);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDL();
            }

            catch
            {
                MessageBox.Show("Xóa thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvNCC.CurrentRow.Index;
            txtMaNCC.Text = dgvNCC.Rows[i].Cells[0].Value.ToString();
            cbTenNCC.Text = dgvNCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvNCC.Rows[i].Cells[2].Value.ToString();
            txtSDT.Text = dgvNCC.Rows[i].Cells[3].Value.ToString();
            txtMail.Text = dgvNCC.Rows[i].Cells[4].Value.ToString();

        }
    }
}
