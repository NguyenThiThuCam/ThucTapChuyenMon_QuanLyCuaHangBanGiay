namespace CUUHANGGIAY
{
    partial class TonKho
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tonkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetTonKho = new CUUHANGGIAY.DataSetTonKho();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportChuanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataReport = new CUUHANGGIAY.DataReport();
            this.reportChuanTableAdapter = new CUUHANGGIAY.DataReportTableAdapters.reportChuanTableAdapter();
            this.tonkhoTableAdapter = new CUUHANGGIAY.DataSetTonKhoTableAdapters.tonkhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChuanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tonkhoBindingSource
            // 
            this.tonkhoBindingSource.DataMember = "tonkho";
            this.tonkhoBindingSource.DataSource = this.DataSetTonKho;
            // 
            // DataSetTonKho
            // 
            this.DataSetTonKho.DataSetName = "DataSetTonKho";
            this.DataSetTonKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.tonkhoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUUHANGGIAY.ReportTonKho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(836, 452);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
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
            // reportChuanTableAdapter
            // 
            this.reportChuanTableAdapter.ClearBeforeFill = true;
            // 
            // tonkhoTableAdapter
            // 
            this.tonkhoTableAdapter.ClearBeforeFill = true;
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(836, 452);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TonKho";
            this.Text = "TonKho";
            this.Load += new System.EventHandler(this.TonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportChuanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource reportChuanBindingSource;
        private DataReport DataReport;
        private DataReportTableAdapters.reportChuanTableAdapter reportChuanTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tonkhoBindingSource;
        private DataSetTonKho DataSetTonKho;
        private DataSetTonKhoTableAdapters.tonkhoTableAdapter tonkhoTableAdapter;
    }
}