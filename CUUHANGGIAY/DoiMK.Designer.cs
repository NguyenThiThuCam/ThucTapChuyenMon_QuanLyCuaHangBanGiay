namespace CUUHANGGIAY
{
    partial class DoiMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoiMK));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtpassmoi = new System.Windows.Forms.TextBox();
            this.btnSent = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mật Khẩu Mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(143, 16);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(138, 20);
            this.txtpass.TabIndex = 2;
            // 
            // txtpassmoi
            // 
            this.txtpassmoi.Location = new System.Drawing.Point(143, 70);
            this.txtpassmoi.Name = "txtpassmoi";
            this.txtpassmoi.Size = new System.Drawing.Size(138, 20);
            this.txtpassmoi.TabIndex = 3;
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
            this.btnSent.Location = new System.Drawing.Point(112, 114);
            this.btnSent.Name = "btnSent";
            this.btnSent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSent.OnHoverImage = null;
            this.btnSent.OnPressedColor = System.Drawing.Color.Black;
            this.btnSent.Size = new System.Drawing.Size(113, 42);
            this.btnSent.TabIndex = 10;
            this.btnSent.Text = "LƯU";
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 9;
            this.gunaElipse1.TargetControl = this.btnSent;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this;
            // 
            // DoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(322, 192);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtpassmoi);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoiMK";
            this.Text = "DoiMK";
            this.Load += new System.EventHandler(this.DoiMK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtpassmoi;
        private Guna.UI.WinForms.GunaButton btnSent;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}