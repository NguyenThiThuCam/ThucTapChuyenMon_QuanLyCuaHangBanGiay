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
    public partial class CTSP : Form
    {
        private String ma;
        private String tenSp;
        private String tenLoai;
      

        public string Ma { get => ma; set => ma = value; }
        public string TenSp { get => tenSp; set => tenSp = value; }
        public string TenLoai1 { get => tenLoai; set => tenLoai = value; }
       

        public CTSP()
        {
            InitializeComponent();
        }
        public CTSP(String ma,String tenSP,String tenLoai)
        {
            this.ma = ma;
            this.tenSp = tenSP;
            this.tenLoai = tenLoai;
           
            InitializeComponent();
        }

        //public void LoadDL()
        //{
        //    string query = "select sp.MaSP,sp.TenSP,lsp.TenLoai,ct.MauSac,ct.Size,ct.GiaBan,ct.SoLuongTon from CTSP ct,SanPham sp,LoaiSP lsp where sp.MaLoai=lsp.MaLoai ";
        //    DataTable data = clsConnect.Instance.exQuery(query);
        //    dgvCTSP.DataSource = data;
        //}
        public void LoadDL()
        {
            string query = "select sp.MaSP,lsp.TenLoai,sp.TenSP,ct.MauSac,ct.Size,ct.GiaBan,ct.SoLuongTon from SanPham sp,CTSP ct,LoaiSP lsp where sp.MaSP='"+ma+"' and ct.masp='"+ma+"' and sp.MaLoai=lsp.MaLoai";
            DataTable data = clsConnect.Instance.exQuery(query);
            dgvCTSP.DataSource = data;


            string query2 = "select MauSac,Size,GiaBan,SoLuongTon from CTSP where masp='"+ma+"'";
            Console.WriteLine(query2);
            DataTable data2 = clsConnect.Instance.exQuery(query2);
            if(data2.Rows.Count>0)
            {
                txtMauSac.Text = data2.Rows[0].ItemArray[0].ToString();
                txtSize.Text = data2.Rows[0].ItemArray[1].ToString();
                txtGiaBan.Text = data2.Rows[0].ItemArray[2].ToString();
                txtTonKho.Text = data2.Rows[0].ItemArray[3].ToString();
            }
        }
        
        public void LoadChiTietSP()
        {
            txtMaSP.Text = ma;
            txtTenSP.Text = TenSp;
            txtTenLoaiSP.Text = tenLoai;
           

           


        }
        public void LoadCombobox()
        {
            string query = "select *from LoaiSP";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtTenLoaiSP.DataSource = data;
            txtTenLoaiSP.ValueMember = "MaLoai";

            txtTenLoaiSP.DisplayMember = "TenLoai";
        }
        public void LoadComboboxTenSP()
        {
            string query = "select *from SanPham";
            DataTable data = clsConnect.Instance.exQuery(query);
            txtTenSP.DataSource = data;
            txtTenSP.ValueMember = "MaSP";
            txtTenSP.DisplayMember = "TenSP";
        }
      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dgvCTSP.CurrentRow.Index;
            txtMaSP.Text = dgvCTSP.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvCTSP.Rows[i].Cells[2].Value.ToString();
            txtTenLoaiSP.Text = dgvCTSP.Rows[i].Cells[1].Value.ToString();
            txtMauSac.Text = dgvCTSP.Rows[i].Cells[3].Value.ToString();
            txtSize.Text = dgvCTSP.Rows[i].Cells[4].Value.ToString();
            txtGiaBan.Text = dgvCTSP.Rows[i].Cells[5].Value.ToString();
            txtTonKho.Text =  dgvCTSP.Rows[i].Cells[6].Value.ToString();


        }

        private void CTSP_Load(object sender, EventArgs e)
        {
            LoadDL();
            LoadCombobox();
            LoadComboboxTenSP();
            LoadChiTietSP();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //if (txtMaSP.Text == "")
            //{
            //    MessageBox.Show("Vui lòng nhập thông tin cần thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    //try
            //    //{
            //        string query = "insert into SanPham values('" + txtMaSP.Text + "','" +txtTenSP.Text + "','" + txtTenLoaiSP.SelectedValue.ToString() + "','" + txtMauSac.Text + "','"+txtSize.Text+"','"+txtGiaBan.Text+"','"+txtTonKho.Text+"')";
            //        DataTable data = clsConnect.Instance.exQuery(query);
            //        MessageBox.Show("Thêm thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        LoadDL();


                //}
                //catch
                //{
                //    MessageBox.Show("Thêm thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //}
            //}
        }

        private void txtTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                try
                {
                    string query = "update  CTSP set MauSac=N'"+txtMauSac.Text+"',Size='"+txtSize.Text+"',GiaBan='"+txtGiaBan.Text+"'   where MASP='" + ma + "'";
                    DataTable data = clsConnect.Instance.exQuery(query);
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDL();
                   
                }
                catch
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

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

        private void txtTonKho_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
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
