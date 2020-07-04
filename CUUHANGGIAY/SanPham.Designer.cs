namespace CUUHANGGIAY
{
    partial class SanPham
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            this.lbMaSP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.lbTenSP = new System.Windows.Forms.Label();
            this.txtTenSP = new Guna.UI.WinForms.GunaTextBox();
            this.laMaloai = new System.Windows.Forms.Label();
            this.cbMaLoai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSua = new Guna.UI.WinForms.GunaButton();
            this.btnXoa = new Guna.UI.WinForms.GunaButton();
            this.btnTimKiem = new Guna.UI.WinForms.GunaButton();
            this.btnlammoi = new Guna.UI.WinForms.GunaButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.lbThongtinKH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new Guna.UI.WinForms.GunaButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbMaSP
            // 
            this.lbMaSP.AutoSize = true;
            this.lbMaSP.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbMaSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaSP.Location = new System.Drawing.Point(163, 50);
            this.lbMaSP.Name = "lbMaSP";
            this.lbMaSP.Size = new System.Drawing.Size(84, 14);
            this.lbMaSP.TabIndex = 3;
            this.lbMaSP.Text = "Mã Sản Phẩm:";
            this.lbMaSP.Click += new System.EventHandler(this.lbMaKH_Click);
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
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(293, 43);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(121, 21);
            this.cbMaSP.TabIndex = 4;
            // 
            // lbTenSP
            // 
            this.lbTenSP.AutoSize = true;
            this.lbTenSP.BackColor = System.Drawing.Color.NavajoWhite;
            this.lbTenSP.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenSP.Location = new System.Drawing.Point(482, 43);
            this.lbTenSP.Name = "lbTenSP";
            this.lbTenSP.Size = new System.Drawing.Size(91, 14);
            this.lbTenSP.TabIndex = 5;
            this.lbTenSP.Text = "Tên Sản Phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.BaseColor = System.Drawing.Color.White;
            this.txtTenSP.BorderColor = System.Drawing.Color.Silver;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenSP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenSP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenSP.Location = new System.Drawing.Point(599, 39);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(160, 30);
            this.txtTenSP.TabIndex = 6;
            // 
            // laMaloai
            // 
            this.laMaloai.AutoSize = true;
            this.laMaloai.BackColor = System.Drawing.Color.NavajoWhite;
            this.laMaloai.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMaloai.Location = new System.Drawing.Point(163, 95);
            this.laMaloai.Name = "laMaloai";
            this.laMaloai.Size = new System.Drawing.Size(51, 14);
            this.laMaloai.TabIndex = 7;
            this.laMaloai.Text = "Mã Loại:";
            // 
            // cbMaLoai
            // 
            this.cbMaLoai.FormattingEnabled = true;
            this.cbMaLoai.Location = new System.Drawing.Point(293, 88);
            this.cbMaLoai.Name = "cbMaLoai";
            this.cbMaLoai.Size = new System.Drawing.Size(121, 21);
            this.cbMaLoai.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.NavajoWhite;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hình Sản Phẩm:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(586, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 156);
            this.panel1.TabIndex = 10;
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
            this.btnSua.Location = new System.Drawing.Point(0, 60);
            this.btnSua.Name = "btnSua";
            this.btnSua.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSua.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSua.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSua.OnHoverImage = null;
            this.btnSua.OnPressedColor = System.Drawing.Color.Black;
            this.btnSua.Size = new System.Drawing.Size(113, 42);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnXoa.Location = new System.Drawing.Point(0, 108);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnXoa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnXoa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnXoa.OnHoverImage = null;
            this.btnXoa.OnPressedColor = System.Drawing.Color.Black;
            this.btnXoa.Size = new System.Drawing.Size(113, 42);
            this.btnXoa.TabIndex = 22;
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
            this.btnTimKiem.Location = new System.Drawing.Point(0, 156);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTimKiem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTimKiem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTimKiem.OnHoverImage = null;
            this.btnTimKiem.OnPressedColor = System.Drawing.Color.Black;
            this.btnTimKiem.Size = new System.Drawing.Size(113, 42);
            this.btnTimKiem.TabIndex = 23;
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
            this.btnlammoi.Location = new System.Drawing.Point(0, 204);
            this.btnlammoi.Name = "btnlammoi";
            this.btnlammoi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnlammoi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnlammoi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnlammoi.OnHoverImage = null;
            this.btnlammoi.OnPressedColor = System.Drawing.Color.Black;
            this.btnlammoi.Size = new System.Drawing.Size(113, 42);
            this.btnlammoi.TabIndex = 24;
            this.btnlammoi.Text = "Làm Mới";
            this.btnlammoi.Click += new System.EventHandler(this.btnlammoi_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgvKH);
            this.panel2.Controls.Add(this.lbThongtinKH);
            this.panel2.Location = new System.Drawing.Point(1, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 241);
            this.panel2.TabIndex = 26;
            // 
            // dgvKH
            // 
            this.dgvKH.BackgroundColor = System.Drawing.Color.White;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Location = new System.Drawing.Point(0, 29);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.Size = new System.Drawing.Size(851, 217);
            this.dgvKH.TabIndex = 49;
            // 
            // lbThongtinKH
            // 
            this.lbThongtinKH.AutoSize = true;
            this.lbThongtinKH.BackColor = System.Drawing.Color.AliceBlue;
            this.lbThongtinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtinKH.Location = new System.Drawing.Point(2, 1);
            this.lbThongtinKH.Name = "lbThongtinKH";
            this.lbThongtinKH.Size = new System.Drawing.Size(148, 13);
            this.lbThongtinKH.TabIndex = 48;
            this.lbThongtinKH.Text = "THÔNG TIN  SẢN PHẨM";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(852, 37);
            this.panel3.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(292, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SẢN PHẨM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btnThem.Location = new System.Drawing.Point(0, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnThem.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThem.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThem.OnHoverImage = null;
            this.btnThem.OnPressedColor = System.Drawing.Color.Black;
            this.btnThem.Size = new System.Drawing.Size(113, 42);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 491);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnlammoi);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbMaLoai);
            this.Controls.Add(this.laMaloai);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.lbTenSP);
            this.Controls.Add(this.cbMaSP);
            this.Controls.Add(this.lbMaSP);
            this.Controls.Add(this.pictureBox1);
            this.Name = "SanPham";
            this.Text = "SanPham";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbMaSP;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label lbTenSP;
        private Guna.UI.WinForms.GunaTextBox txtTenSP;
        private System.Windows.Forms.Label laMaloai;
        private System.Windows.Forms.ComboBox cbMaLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaButton btnSua;
        private Guna.UI.WinForms.GunaButton btnXoa;
        private Guna.UI.WinForms.GunaButton btnTimKiem;
        private Guna.UI.WinForms.GunaButton btnlammoi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.Label lbThongtinKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnThem;
        private System.Windows.Forms.Timer timer1;
    }
}