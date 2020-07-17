namespace CUUHANGGIAY
{
    partial class InHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InHoaDon));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportChuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataReport = new CUUHANGGIAY.DataReport();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaElipse2 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaElipse3 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportChuanTableAdapter = new CUUHANGGIAY.DataReportTableAdapters.reportChuanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportChuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // reportChuanBindingSource
            // 
            this.reportChuanBindingSource.DataMember = "reportChuan";
            this.reportChuanBindingSource.DataSource = this.DataReport;
            // 
            // DataReport
            // 
            this.DataReport.DataSetName = "DataReport";
            this.DataReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 9;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaElipse2
            // 
            this.gunaElipse2.Radius = 9;
            this.gunaElipse2.TargetControl = this;
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
            this.btnBack.Location = new System.Drawing.Point(2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.LightSteelBlue;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(129, 42);
            this.btnBack.TabIndex = 14;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gunaElipse3
            // 
            this.gunaElipse3.Radius = 9;
            this.gunaElipse3.TargetControl = this;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportChuanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUUHANGGIAY.ReportHoaDon.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(24, 50);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(791, 419);
            this.reportViewer1.TabIndex = 15;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // reportChuanTableAdapter
            // 
            this.reportChuanTableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(827, 481);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InHoaDon";
            this.Text = "InHoaDon";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportChuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaElipse gunaElipse2;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaElipse gunaElipse3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource reportChuanBindingSource;
        private DataReport DataReport;
        private DataReportTableAdapters.reportChuanTableAdapter reportChuanTableAdapter;
    }
}