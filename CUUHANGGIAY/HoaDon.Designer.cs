namespace CUUHANGGIAY
{
    partial class HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.lbMaHD = new System.Windows.Forms.Label();
            this.laNgayLap = new System.Windows.Forms.Label();
            this.lbMaKH = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbTonTien = new System.Windows.Forms.Label();
            this.lbTinhtrang = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbMaHD = new System.Windows.Forms.ComboBox();
            this.txtTinhTrang = new Guna.UI.WinForms.GunaTextBox();
            this.txtTongTien = new Guna.UI.WinForms.GunaTextBox();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.btnlammoi = new Guna.UI.WinForms.GunaButton();
            this.txtNgayLap = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.lbThongtinKH = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbMaHD.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(170, 56);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(81, 14);
            this.lbMaHD.TabIndex = 4;
            this.lbMaHD.Text = "Mã Hóa Đơn :";
            // 
            // laNgayLap
            // 
            this.laNgayLap.AutoSize = true;
            this.laNgayLap.BackColor = System.Drawing.Color.NavajoWhite;
            this.laNgayLap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNgayLap.Location = new System.Drawing.Point(519, 52);
            this.laNgayLap.Name = "laNgayLap";
            this.laNgayLap.Size = new System.Drawing.Size(61, 14);
            this.laNgayLap.TabIndex = 8;
            this.laNgayLap.Text = "Ngày Lập:";
            // 
            // lbMaKH
            // 
            this.lbMaKH.AutoSize = true;
            this.lbMaKH.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbMaKH.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaKH.Location = new System.Drawing.Point(170, 171);
            this.lbMaKH.Name = "lbMaKH";
            this.lbMaKH.Size = new System.Drawing.Size(95, 14);
            this.lbMaKH.TabIndex = 9;
            this.lbMaKH.Text = "Mã Khách Hàng:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbMaNV.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(170, 109);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(86, 14);
            this.lbMaNV.TabIndex = 10;
            this.lbMaNV.Text = "Mã Nhân Viên:";
            // 
            // lbTonTien
            // 
            this.lbTonTien.AutoSize = true;
            this.lbTonTien.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbTonTien.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTonTien.Location = new System.Drawing.Point(519, 125);
            this.lbTonTien.Name = "lbTonTien";
            this.lbTonTien.Size = new System.Drawing.Size(68, 14);
            this.lbTonTien.TabIndex = 11;
            this.lbTonTien.Text = "Tổng Tiền:";
            // 
            // lbTinhtrang
            // 
            this.lbTinhtrang.AutoSize = true;
            this.lbTinhtrang.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbTinhtrang.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTinhtrang.Location = new System.Drawing.Point(519, 178);
            this.lbTinhtrang.Name = "lbTinhtrang";
            this.lbTinhtrang.Size = new System.Drawing.Size(71, 14);
            this.lbTinhtrang.TabIndex = 12;
            this.lbTinhtrang.Text = "Tình Trạng:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCoral;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(275, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 36);
            this.label5.TabIndex = 13;
            this.label5.Text = "KHÁCH HÀNG";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(279, 169);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(121, 21);
            this.cbMaKH.TabIndex = 14;
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(279, 102);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(121, 21);
            this.cbMaNV.TabIndex = 15;
            // 
            // cbMaHD
            // 
            this.cbMaHD.FormattingEnabled = true;
            this.cbMaHD.Location = new System.Drawing.Point(279, 54);
            this.cbMaHD.Name = "cbMaHD";
            this.cbMaHD.Size = new System.Drawing.Size(121, 21);
            this.cbMaHD.TabIndex = 16;
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BaseColor = System.Drawing.Color.White;
            this.txtTinhTrang.BorderColor = System.Drawing.Color.Silver;
            this.txtTinhTrang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTinhTrang.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTinhTrang.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTinhTrang.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTinhTrang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTinhTrang.Location = new System.Drawing.Point(605, 171);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.PasswordChar = '\0';
            this.txtTinhTrang.SelectedText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(160, 30);
            this.txtTinhTrang.TabIndex = 17;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BaseColor = System.Drawing.Color.White;
            this.txtTongTien.BorderColor = System.Drawing.Color.Silver;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTongTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongTien.Location = new System.Drawing.Point(605, 109);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(160, 30);
            this.txtTongTien.TabIndex = 18;
            // 
            // btnThem
            // 
            this.btnThem.AnimationHoverSpeed = 0.07F;
            this.btnThem.AnimationSpeed = 0.03F;
            this.btnThem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(118)))), ((int)(((byte)(95)))));
            this.btnThem.BorderColor = System.Drawing.Color.Black;
            this.btnThem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThem.FocusedColor = System.Drawing.Color.Empty;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThem.Location = new System.Drawing.Point(1, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(113, 42);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            // 
            // btnSua
            // 
            this.btnSua.AnimationHoverSpeed = 0.07F;
            this.btnSua.AnimationSpeed = 0.03F;
            this.btnSua.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(118)))), ((int)(((byte)(95)))));
            this.btnSua.BorderColor = System.Drawing.Color.Black;
            this.btnSua.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSua.FocusedColor = System.Drawing.Color.Empty;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSua.Location = new System.Drawing.Point(1, 55);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(113, 42);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            // 
            // btnXoa
            // 
            this.btnXoa.AnimationHoverSpeed = 0.07F;
            this.btnXoa.AnimationSpeed = 0.03F;
            this.btnXoa.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(118)))), ((int)(((byte)(95)))));
            this.btnXoa.BorderColor = System.Drawing.Color.Black;
            this.btnXoa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnXoa.FocusedColor = System.Drawing.Color.Empty;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnXoa.Location = new System.Drawing.Point(1, 105);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(113, 42);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AnimationHoverSpeed = 0.07F;
            this.btnTimKiem.AnimationSpeed = 0.03F;
            this.btnTimKiem.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(118)))), ((int)(((byte)(95)))));
            this.btnTimKiem.BorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTimKiem.FocusedColor = System.Drawing.Color.Empty;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTimKiem.Location = new System.Drawing.Point(1, 153);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(113, 42);
            this.btnTimKiem.TabIndex = 24;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnlammoi
            // 
            this.btnlammoi.AnimationHoverSpeed = 0.07F;
            this.btnlammoi.AnimationSpeed = 0.03F;
            this.btnlammoi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(118)))), ((int)(((byte)(95)))));
            this.btnlammoi.BorderColor = System.Drawing.Color.Black;
            this.btnlammoi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlammoi.FocusedColor = System.Drawing.Color.Empty;
            this.btnlammoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnlammoi.ForeColor = System.Drawing.Color.White;
            this.btnlammoi.Image = ((System.Drawing.Image)(resources.GetObject("btnlammoi.Image")));
            this.btnlammoi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnlammoi.Location = new System.Drawing.Point(1, 202);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnlammoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnlammoi.OnHoverImage = null;
            this.btnlammoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnlammoi.Size = new System.Drawing.Size(113, 42);
            this.btnlammoi.TabIndex = 25;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // txtNgayLap
            // 
            this.txtNgayLap.BaseColor = System.Drawing.Color.White;
            this.txtNgayLap.BorderColor = System.Drawing.Color.Silver;
            this.txtNgayLap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayLap.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNgayLap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNgayLap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayLap.Location = new System.Drawing.Point(605, 45);
            this.txtNgayLap.Name = "txtNgayLap";
            this.txtNgayLap.PasswordChar = '\0';
            this.txtNgayLap.SelectedText = "";
            this.txtNgayLap.Size = new System.Drawing.Size(160, 30);
            this.txtNgayLap.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dgvKH);
            this.panel1.Controls.Add(this.lbThongtinKH);
            this.panel1.Location = new System.Drawing.Point(-5, 250);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 204);
            this.panel1.TabIndex = 27;
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(-3, 17);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(846, 180);
            this.dgvKH.TabIndex = 49;
            // 
            // lbThongtinKH
            // 
            this.lbThongtinKH.AutoSize = true;
            this.lbThongtinKH.BackColor = System.Drawing.Color.AliceBlue;
            this.lbThongtinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtinKH.Location = new System.Drawing.Point(2, 1);
            this.lbThongtinKH.Name = "lbThongtinKH";
            this.lbThongtinKH.Size = new System.Drawing.Size(165, 13);
            this.lbThongtinKH.TabIndex = 48;
            this.lbThongtinKH.Text = "THÔNG TIN  KHÁCH HÀNG";
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(835, 447);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNgayLap);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.cbMaHD);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTinhtrang);
            this.Controls.Add(this.lbTonTien);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.lbMaKH);
            this.Controls.Add(this.laNgayLap);
            this.Controls.Add(this.lbMaHD);
            this.Name = "HoaDon";
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label laNgayLap;
        private System.Windows.Forms.Label lbMaKH;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbTonTien;
        private System.Windows.Forms.Label lbTinhtrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaHD;
        private Guna.UI.WinForms.GunaTextBox txtTinhTrang;
        private Guna.UI.WinForms.GunaTextBox txtTongTien;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaButton btnlammoi;
        private Guna.UI.WinForms.GunaTextBox txtNgayLap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label lbThongtinKH;
    }
}