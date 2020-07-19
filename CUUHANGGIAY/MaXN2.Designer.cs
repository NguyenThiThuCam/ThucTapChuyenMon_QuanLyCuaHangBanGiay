namespace CUUHANGGIAY
{
    partial class MaXN2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaXN2));
            this.label1 = new System.Windows.Forms.Label();
            this.txtmaxn = new System.Windows.Forms.TextBox();
            this.btnSent = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xác nhận:";
            // 
            // txtmaxn
            // 
            this.txtmaxn.Location = new System.Drawing.Point(102, 30);
            this.txtmaxn.Name = "txtmaxn";
            this.txtmaxn.Size = new System.Drawing.Size(133, 20);
            this.txtmaxn.TabIndex = 1;
            this.txtmaxn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmaxn_KeyPress);
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
            this.btnSent.Location = new System.Drawing.Point(112, 80);
            this.btnSent.Name = "btnSent";
            this.btnSent.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnSent.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSent.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSent.OnHoverImage = null;
            this.btnSent.OnPressedColor = System.Drawing.Color.Black;
            this.btnSent.Size = new System.Drawing.Size(113, 42);
            this.btnSent.TabIndex = 10;
            this.btnSent.Text = "GỬI";
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
            // MaXN2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(322, 192);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtmaxn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaXN2";
            this.Text = "MaXN2";
            this.Load += new System.EventHandler(this.MaXN2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmaxn;
        private Guna.UI.WinForms.GunaButton btnSent;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
    }
}