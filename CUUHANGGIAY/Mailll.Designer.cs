namespace CUUHANGGIAY
{
    partial class Mailll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mailll));
            this.txtFile = new Guna.UI.WinForms.GunaTextBox();
            this.txtTo = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse4 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse5 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMail = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GmailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbThongtinHD = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.btnSent = new Guna.UI.WinForms.GunaButton();
            this.btnAttach = new Guna.UI.WinForms.GunaButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.BaseColor = System.Drawing.Color.White;
            this.txtFile.BorderColor = System.Drawing.Color.Silver;
            this.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFile.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFile.FocusedBorderColor = System.Drawing.Color.White;
            this.txtFile.FocusedForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFile.Location = new System.Drawing.Point(98, 47);
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.SelectedText = "";
            this.txtFile.Size = new System.Drawing.Size(160, 30);
            this.txtFile.TabIndex = 4;
            this.txtFile.Text = "File";
            // 
            // txtTo
            // 
            this.txtTo.BaseColor = System.Drawing.Color.White;
            this.txtTo.BorderColor = System.Drawing.Color.Silver;
            this.txtTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTo.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTo.FocusedBorderColor = System.Drawing.Color.White;
            this.txtTo.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTo.Location = new System.Drawing.Point(98, 130);
            this.txtTo.Name = "txtTo";
            this.txtTo.PasswordChar = '\0';
            this.txtTo.SelectedText = "";
            this.txtTo.Size = new System.Drawing.Size(160, 30);
            this.txtTo.TabIndex = 6;
            this.txtTo.Text = "Mail";
            this.txtTo.TextChanged += new System.EventHandler(this.txtTo_TextChanged);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 9;
            this.gunaElipse1.TargetControl = this.btnAttach;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this.btnSent;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 9;
            this.gunaElipse3.TargetControl = this.txtFile;
            // 
            // gunaElipse4
            // 
            this.gunaElipse4.Radius = 9;
            this.gunaElipse4.TargetControl = this.txtTo;
            // 
            // gunaElipse5
            // 
            this.gunaElipse5.Radius = 9;
            this.gunaElipse5.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.dgvMail);
            this.panel1.Controls.Add(this.lbThongtinHD);
            this.panel1.Location = new System.Drawing.Point(-2, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 150);
            this.panel1.TabIndex = 14;
            // 
            // dgvMail
            // 
            this.dgvMail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.NgaySinh,
            this.SDT,
            this.DiaChi,
            this.GmailKH});
            this.dgvMail.Location = new System.Drawing.Point(0, 27);
            this.dgvMail.Name = "dgvMail";
            this.dgvMail.Size = new System.Drawing.Size(634, 124);
            this.dgvMail.TabIndex = 50;
            this.dgvMail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMail_CellContentClick_1);
            // 
            // MaKH
            // 
            this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.Name = "MaKH";
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên KH";
            this.TenKH.Name = "TenKH";
            // 
            // NgaySinh
            // 
            this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // SDT
            // 
            this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT KH";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ KH";
            this.DiaChi.Name = "DiaChi";
            // 
            // GmailKH
            // 
            this.GmailKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GmailKH.DataPropertyName = "GmailKH";
            this.GmailKH.HeaderText = "GmailKH";
            this.GmailKH.Name = "GmailKH";
            // 
            // lbThongtinHD
            // 
            this.lbThongtinHD.AutoSize = true;
            this.lbThongtinHD.BackColor = System.Drawing.Color.CadetBlue;
            this.lbThongtinHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongtinHD.Location = new System.Drawing.Point(3, -1);
            this.lbThongtinHD.Name = "lbThongtinHD";
            this.lbThongtinHD.Size = new System.Drawing.Size(165, 13);
            this.lbThongtinHD.TabIndex = 49;
            this.lbThongtinHD.Text = "THÔNG TIN  KHÁCH HÀNG";
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.BaseColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBack.Location = new System.Drawing.Point(-2, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(129, 42);
            this.btnBack.TabIndex = 13;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSent
            // 
            this.btnSent.AnimationHoverSpeed = 0.07F;
            this.btnSent.AnimationSpeed = 0.03F;
            this.btnSent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSent.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSent.BorderColor = System.Drawing.Color.Black;
            this.btnSent.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSent.FocusedColor = System.Drawing.Color.Empty;
            this.btnSent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSent.ForeColor = System.Drawing.Color.Black;
            this.btnSent.Image = ((System.Drawing.Image)(resources.GetObject("btnSent.Image")));
            this.btnSent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSent.Location = new System.Drawing.Point(307, 118);
            this.btnSent.Name = "btnSent";
            this.btnSent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSent.OnHoverImage = null;
            this.btnSent.OnPressedColor = System.Drawing.Color.Black;
            this.btnSent.Size = new System.Drawing.Size(113, 42);
            this.btnSent.TabIndex = 8;
            this.btnSent.Text = "SENT";
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // btnAttach
            // 
            this.btnAttach.AnimationHoverSpeed = 0.07F;
            this.btnAttach.AnimationSpeed = 0.03F;
            this.btnAttach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAttach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAttach.BorderColor = System.Drawing.Color.Black;
            this.btnAttach.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAttach.FocusedColor = System.Drawing.Color.Empty;
            this.btnAttach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAttach.ForeColor = System.Drawing.Color.Black;
            this.btnAttach.Image = ((System.Drawing.Image)(resources.GetObject("btnAttach.Image")));
            this.btnAttach.ImageSize = new System.Drawing.Size(40, 40);
            this.btnAttach.Location = new System.Drawing.Point(307, 47);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAttach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAttach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAttach.OnHoverImage = null;
            this.btnAttach.OnPressedColor = System.Drawing.Color.Black;
            this.btnAttach.Size = new System.Drawing.Size(113, 42);
            this.btnAttach.TabIndex = 5;
            this.btnAttach.Text = "Attach";
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
            // 
            // Mailll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(636, 353);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtTo);
            this.Controls.Add(this.btnAttach);
            this.Controls.Add(this.txtFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mailll";
            this.Text = "Mailll";
            this.Load += new System.EventHandler(this.Mailll_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox txtFile;
        private Guna.UI.WinForms.GunaButton btnAttach;
        private Guna.UI.WinForms.GunaTextBox txtTo;
        private Guna.UI.WinForms.GunaButton btnSent;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Guna.UI.WinForms.GunaElipse gunaElipse4;
        private Guna.UI.WinForms.GunaElipse gunaElipse5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMail;
        private System.Windows.Forms.Label lbThongtinHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GmailKH;
    }
}