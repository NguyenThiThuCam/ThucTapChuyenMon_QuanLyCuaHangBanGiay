namespace CUUHANGGIAY
{
    partial class NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.label1 = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgaySinh = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.txtMaTaiKhoan = new Guna.UI.WinForms.GunaTextBox();
            this.lbMaTK = new System.Windows.Forms.Label();
            this.lbTenNV = new System.Windows.Forms.Label();
            this.lbSDT = new System.Windows.Forms.Label();
            this.txttenNV = new Guna.UI.WinForms.GunaTextBox();
            this.txtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.lbGmail = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI.WinForms.GunaTextBox();
            this.lbNgayVaoLam = new System.Windows.Forms.Label();
            this.txtNgayvaolam = new Guna.UI.WinForms.GunaTextBox();
            this.lbLuong = new System.Windows.Forms.Label();
            this.txtLuong = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.lbThongtinNV = new System.Windows.Forms.Label();
            this.txtNgaySinh = new Guna.UI.WinForms.GunaTextBox();
            this.btnlammoi = new Guna.UI.WinForms.GunaButton();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.AliceBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "NHÂN VIÊN";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Location = new System.Drawing.Point(12, 45);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(78, 13);
            this.lbMaNV.TabIndex = 28;
            this.lbMaNV.Text = "Mã Nhân Viên:";
            // 
            // lbNgaySinh
            // 
            this.lbNgaySinh.AutoSize = true;
            this.lbNgaySinh.Location = new System.Drawing.Point(12, 90);
            this.lbNgaySinh.Name = "lbNgaySinh";
            this.lbNgaySinh.Size = new System.Drawing.Size(59, 13);
            this.lbNgaySinh.TabIndex = 29;
            this.lbNgaySinh.Text = "Ngày Sinh:";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(106, 37);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(160, 21);
            this.cbMaNV.TabIndex = 30;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // txtMaTaiKhoan
            // 
            this.txtMaTaiKhoan.BaseColor = System.Drawing.Color.White;
            this.txtMaTaiKhoan.BorderColor = System.Drawing.Color.Silver;
            this.txtMaTaiKhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaTaiKhoan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaTaiKhoan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaTaiKhoan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaTaiKhoan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaTaiKhoan.Location = new System.Drawing.Point(106, 141);
            this.txtMaTaiKhoan.Name = "txtMaTaiKhoan";
            this.txtMaTaiKhoan.PasswordChar = '\0';
            this.txtMaTaiKhoan.SelectedText = "";
            this.txtMaTaiKhoan.Size = new System.Drawing.Size(160, 26);
            this.txtMaTaiKhoan.TabIndex = 32;
            this.txtMaTaiKhoan.TextChanged += new System.EventHandler(this.txtTenTaiKhoan_TextChanged);
            // 
            // lbMaTK
            // 
            this.lbMaTK.AutoSize = true;
            this.lbMaTK.Location = new System.Drawing.Point(9, 144);
            this.lbMaTK.Name = "lbMaTK";
            this.lbMaTK.Size = new System.Drawing.Size(77, 13);
            this.lbMaTK.TabIndex = 33;
            this.lbMaTK.Text = "Mã Tài Khoản:";
            // 
            // lbTenNV
            // 
            this.lbTenNV.AutoSize = true;
            this.lbTenNV.Location = new System.Drawing.Point(294, 45);
            this.lbTenNV.Name = "lbTenNV";
            this.lbTenNV.Size = new System.Drawing.Size(82, 13);
            this.lbTenNV.TabIndex = 34;
            this.lbTenNV.Text = "Tên Nhân Viên:";
            // 
            // lbSDT
            // 
            this.lbSDT.AutoSize = true;
            this.lbSDT.Location = new System.Drawing.Point(294, 90);
            this.lbSDT.Name = "lbSDT";
            this.lbSDT.Size = new System.Drawing.Size(78, 13);
            this.lbSDT.TabIndex = 35;
            this.lbSDT.Text = "Số Điện Thoại:";
            // 
            // txttenNV
            // 
            this.txttenNV.BaseColor = System.Drawing.Color.White;
            this.txttenNV.BorderColor = System.Drawing.Color.Silver;
            this.txttenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenNV.FocusedBaseColor = System.Drawing.Color.White;
            this.txttenNV.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txttenNV.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txttenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txttenNV.Location = new System.Drawing.Point(391, 32);
            this.txttenNV.Name = "txttenNV";
            this.txttenNV.PasswordChar = '\0';
            this.txttenNV.SelectedText = "";
            this.txttenNV.Size = new System.Drawing.Size(160, 26);
            this.txttenNV.TabIndex = 36;
            this.txttenNV.TextChanged += new System.EventHandler(this.txttenNV_TextChanged);
            // 
            // txtSDT
            // 
            this.txtSDT.BaseColor = System.Drawing.Color.White;
            this.txtSDT.BorderColor = System.Drawing.Color.Silver;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(391, 77);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(160, 26);
            this.txtSDT.TabIndex = 37;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            // 
            // lbGmail
            // 
            this.lbGmail.AutoSize = true;
            this.lbGmail.Location = new System.Drawing.Point(573, 45);
            this.lbGmail.Name = "lbGmail";
            this.lbGmail.Size = new System.Drawing.Size(36, 13);
            this.lbGmail.TabIndex = 40;
            this.lbGmail.Text = "Gmail:";
            // 
            // txtMail
            // 
            this.txtMail.BaseColor = System.Drawing.Color.White;
            this.txtMail.BorderColor = System.Drawing.Color.Silver;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMail.Location = new System.Drawing.Point(664, 32);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(160, 26);
            this.txtMail.TabIndex = 41;
            // 
            // lbNgayVaoLam
            // 
            this.lbNgayVaoLam.AutoSize = true;
            this.lbNgayVaoLam.Location = new System.Drawing.Point(573, 90);
            this.lbNgayVaoLam.Name = "lbNgayVaoLam";
            this.lbNgayVaoLam.Size = new System.Drawing.Size(80, 13);
            this.lbNgayVaoLam.TabIndex = 42;
            this.lbNgayVaoLam.Text = "Ngày Vào Làm:";
            // 
            // txtNgayvaolam
            // 
            this.txtNgayvaolam.BaseColor = System.Drawing.Color.White;
            this.txtNgayvaolam.BorderColor = System.Drawing.Color.Silver;
            this.txtNgayvaolam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgayvaolam.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNgayvaolam.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNgayvaolam.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNgayvaolam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgayvaolam.Location = new System.Drawing.Point(664, 77);
            this.txtNgayvaolam.Name = "txtNgayvaolam";
            this.txtNgayvaolam.PasswordChar = '\0';
            this.txtNgayvaolam.SelectedText = "";
            this.txtNgayvaolam.Size = new System.Drawing.Size(160, 26);
            this.txtNgayvaolam.TabIndex = 43;
            this.txtNgayvaolam.TextChanged += new System.EventHandler(this.txtNgayvaolam_TextChanged);
            // 
            // lbLuong
            // 
            this.lbLuong.AutoSize = true;
            this.lbLuong.Location = new System.Drawing.Point(294, 144);
            this.lbLuong.Name = "lbLuong";
            this.lbLuong.Size = new System.Drawing.Size(40, 13);
            this.lbLuong.TabIndex = 44;
            this.lbLuong.Text = "Lương:";
            // 
            // txtLuong
            // 
            this.txtLuong.BaseColor = System.Drawing.Color.White;
            this.txtLuong.BorderColor = System.Drawing.Color.Silver;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLuong.Location = new System.Drawing.Point(391, 131);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(160, 26);
            this.txtLuong.TabIndex = 45;
            this.txtLuong.TextChanged += new System.EventHandler(this.txtLuong_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Location = new System.Drawing.Point(0, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(852, 254);
            this.panel1.TabIndex = 47;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(0, 67);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(852, 187);
            this.dgv.TabIndex = 0;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // lbThongtinNV
            // 
            this.lbThongtinNV.AutoSize = true;
            this.lbThongtinNV.BackColor = System.Drawing.Color.AliceBlue;
            this.lbThongtinNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtinNV.Location = new System.Drawing.Point(3, 233);
            this.lbThongtinNV.Name = "lbThongtinNV";
            this.lbThongtinNV.Size = new System.Drawing.Size(148, 13);
            this.lbThongtinNV.TabIndex = 47;
            this.lbThongtinNV.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.BaseColor = System.Drawing.Color.White;
            this.txtNgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.txtNgaySinh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNgaySinh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNgaySinh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNgaySinh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNgaySinh.Location = new System.Drawing.Point(106, 90);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.PasswordChar = '\0';
            this.txtNgaySinh.SelectedText = "";
            this.txtNgaySinh.Size = new System.Drawing.Size(160, 26);
            this.txtNgaySinh.TabIndex = 48;
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
            this.btnlammoi.Location = new System.Drawing.Point(608, 179);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnlammoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnlammoi.OnHoverImage = null;
            this.btnlammoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnlammoi.Size = new System.Drawing.Size(113, 42);
            this.btnlammoi.TabIndex = 23;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(461, 179);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(113, 42);
            this.btnTimKiem.TabIndex = 22;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(317, 179);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(113, 42);
            this.btnXoa.TabIndex = 21;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(172, 179);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(113, 42);
            this.btnSua.TabIndex = 20;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(23, 179);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(113, 42);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 491);
            this.Controls.Add(this.txtNgaySinh);
            this.Controls.Add(this.lbThongtinNV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.lbLuong);
            this.Controls.Add(this.txtNgayvaolam);
            this.Controls.Add(this.lbNgayVaoLam);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.lbGmail);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txttenNV);
            this.Controls.Add(this.lbSDT);
            this.Controls.Add(this.lbTenNV);
            this.Controls.Add(this.lbMaTK);
            this.Controls.Add(this.txtMaTaiKhoan);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.lbNgaySinh);
            this.Controls.Add(this.lbMaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnThem;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaButton btnlammoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgaySinh;
        private System.Windows.Forms.ComboBox cbMaNV;
        private Guna.UI.WinForms.GunaTextBox txtMaTaiKhoan;
        private System.Windows.Forms.Label lbMaTK;
        private System.Windows.Forms.Label lbTenNV;
        private System.Windows.Forms.Label lbSDT;
        private Guna.UI.WinForms.GunaTextBox txttenNV;
        private Guna.UI.WinForms.GunaTextBox txtSDT;
        private System.Windows.Forms.Label lbGmail;
        private Guna.UI.WinForms.GunaTextBox txtMail;
        private System.Windows.Forms.Label lbNgayVaoLam;
        private Guna.UI.WinForms.GunaTextBox txtNgayvaolam;
        private System.Windows.Forms.Label lbLuong;
        private Guna.UI.WinForms.GunaTextBox txtLuong;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label lbThongtinNV;
        private Guna.UI.WinForms.GunaTextBox txtNgaySinh;
    }
}