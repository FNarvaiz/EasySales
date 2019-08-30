namespace Reportes
{
    partial class R_CajasDiarias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_CajasDiarias));
            this.CajasDiariasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_NoTipado = new Reportes.DS_NoTipado();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.CajasDiariasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NoTipado)).BeginInit();
            this.SuspendLayout();
            // 
            // CajasDiariasBindingSource
            // 
            this.CajasDiariasBindingSource.DataMember = "CajasDiarias";
            this.CajasDiariasBindingSource.DataSource = this.DS_NoTipado;
            // 
            // DS_NoTipado
            // 
            this.DS_NoTipado.DataSetName = "DS_NoTipado";
            this.DS_NoTipado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CajaDiaria";
            reportDataSource1.Value = this.CajasDiariasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Inf_CajasDiarias.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(562, 438);
            this.reportViewer1.TabIndex = 6;
            // 
            // R_CajasDiarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 438);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "R_CajasDiarias";
            this.Text = "Reporte de cajas diarias";
            this.Load += new System.EventHandler(this.R_CajasDiarias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CajasDiariasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NoTipado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource CajasDiariasBindingSource;
        private DS_NoTipado DS_NoTipado;
    }
}