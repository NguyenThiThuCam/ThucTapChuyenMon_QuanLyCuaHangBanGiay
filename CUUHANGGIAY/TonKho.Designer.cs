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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetTKho = new CUUHANGGIAY.DataSetTKho();
            this.tonkhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tonkhoTableAdapter = new CUUHANGGIAY.DataSetTKhoTableAdapters.tonkhoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tonkhoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CUUHANGGIAY.ReportTK.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 455);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetTKho
            // 
            this.DataSetTKho.DataSetName = "DataSetTKho";
            this.DataSetTKho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tonkhoBindingSource
            // 
            this.tonkhoBindingSource.DataMember = "tonkho";
            this.tonkhoBindingSource.DataSource = this.DataSetTKho;
            // 
            // tonkhoTableAdapter
            // 
            this.tonkhoTableAdapter.ClearBeforeFill = true;
            // 
            // TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 455);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TonKho";
            this.Text = "TonKho";
            this.Load += new System.EventHandler(this.TonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetTKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tonkhoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tonkhoBindingSource;
        private DataSetTKho DataSetTKho;
        private DataSetTKhoTableAdapters.tonkhoTableAdapter tonkhoTableAdapter;
    }
}