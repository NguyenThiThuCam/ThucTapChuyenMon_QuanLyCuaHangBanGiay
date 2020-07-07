namespace CUUHANGGIAY
{
    partial class Mail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            this.btnMailist = new Guna.UI.WinForms.GunaButton();
            this.btnAttach = new Guna.UI.WinForms.GunaButton();
            this.btnSent = new Guna.UI.WinForms.GunaButton();
            this.txtFile = new Guna.UI.WinForms.GunaTextBox();
            this.txtMail = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFile = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvMail = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GmailKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMailist
            // 
            this.btnMailist.AnimationHoverSpeed = 0.07F;
            this.btnMailist.AnimationSpeed = 0.03F;
            this.btnMailist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMailist.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMailist.BorderColor = System.Drawing.Color.Black;
            this.btnMailist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMailist.FocusedColor = System.Drawing.Color.Empty;
            this.btnMailist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMailist.ForeColor = System.Drawing.Color.Black;
            this.btnMailist.Image = ((System.Drawing.Image)(resources.GetObject("btnMailist.Image")));
            this.btnMailist.ImageSize = new System.Drawing.Size(30, 30);
            this.btnMailist.Location = new System.Drawing.Point(287, 119);
            this.btnMailist.Name = "btnMailist";
            this.btnMailist.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnMailist.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMailist.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMailist.OnHoverImage = null;
            this.btnMailist.OnPressedColor = System.Drawing.Color.Black;
            this.btnMailist.Size = new System.Drawing.Size(113, 42);
            this.btnMailist.TabIndex = 1;
            this.btnMailist.Text = "Mail list";
            this.btnMailist.Click += new System.EventHandler(this.gunaButton2_Click);
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
            this.btnAttach.Location = new System.Drawing.Point(287, 55);
            this.btnAttach.Name = "btnAttach";
            this.btnAttach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAttach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAttach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAttach.OnHoverImage = null;
            this.btnAttach.OnPressedColor = System.Drawing.Color.Black;
            this.btnAttach.Size = new System.Drawing.Size(113, 42);
            this.btnAttach.TabIndex = 0;
            this.btnAttach.Text = "Attach";
            this.btnAttach.Click += new System.EventHandler(this.btnAttach_Click);
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
            this.btnSent.Location = new System.Drawing.Point(166, 183);
            this.btnSent.Name = "btnSent";
            this.btnSent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSent.OnHoverImage = null;
            this.btnSent.OnPressedColor = System.Drawing.Color.Black;
            this.btnSent.Size = new System.Drawing.Size(113, 42);
            this.btnSent.TabIndex = 2;
            this.btnSent.Text = "SENT";
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // txtFile
            // 
            this.txtFile.BaseColor = System.Drawing.Color.White;
            this.txtFile.BorderColor = System.Drawing.Color.Silver;
            this.txtFile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFile.FocusedBaseColor = System.Drawing.Color.White;
            this.txtFile.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFile.FocusedForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFile.Location = new System.Drawing.Point(47, 47);
            this.txtFile.Name = "txtFile";
            this.txtFile.PasswordChar = '\0';
            this.txtFile.SelectedText = "";
            this.txtFile.Size = new System.Drawing.Size(160, 30);
            this.txtFile.TabIndex = 3;
            this.txtFile.Text = "File";
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
            this.txtMail.Location = new System.Drawing.Point(47, 110);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(160, 30);
            this.txtMail.TabIndex = 4;
            this.txtMail.Text = "Mail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gmail:";
            // 
            // lbFile
            // 
            this.lbFile.AutoSize = true;
            this.lbFile.Location = new System.Drawing.Point(3, 55);
            this.lbFile.Name = "lbFile";
            this.lbFile.Size = new System.Drawing.Size(26, 13);
            this.lbFile.TabIndex = 6;
            this.lbFile.Text = "File:";
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
            this.btnBack.Location = new System.Drawing.Point(3, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(129, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvMail);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 247);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 203);
            this.panel1.TabIndex = 8;
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
            this.dgvMail.Location = new System.Drawing.Point(0, 50);
            this.dgvMail.Name = "dgvMail";
            this.dgvMail.Size = new System.Drawing.Size(660, 150);
            this.dgvMail.TabIndex = 1;
            this.dgvMail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMail_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 9;
            this.gunaElipse1.TargetControl = this.btnMailist;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this.btnAttach;
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 9;
            this.gunaElipse3.TargetControl = this.btnSent;
            // 
            // MaKH
            // 
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
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT KH";
            this.SDT.Name = "SDT";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.Name = "DiaChi";
            // 
            // GmailKH
            // 
            this.GmailKH.DataPropertyName = "GmailKH";
            this.GmailKH.HeaderText = "Gmail KH";
            this.GmailKH.Name = "GmailKH";
            // 
            // Mail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.btnMailist);
            this.Controls.Add(this.btnAttach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mail";
            this.Text = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAttach;
        private Guna.UI.WinForms.GunaButton btnMailist;
        private Guna.UI.WinForms.GunaButton btnSent;
        private Guna.UI.WinForms.GunaTextBox txtFile;
        private Guna.UI.WinForms.GunaTextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFile;
        private Guna.UI.WinForms.GunaButton btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvMail;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GmailKH;
    }
}