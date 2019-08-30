namespace Reportes
{
    partial class R_PreciosParaGondola
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ArticulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_NoTipado = new Reportes.DS_NoTipado();
            this.Articulos2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Articulos3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NoTipado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Articulos2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Articulos3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Articulos";
            reportDataSource1.Value = this.ArticulosBindingSource;
            reportDataSource2.Name = "Articulos2";
            reportDataSource2.Value = this.Articulos2BindingSource;
            reportDataSource3.Name = "Articulos3";
            reportDataSource3.Value = this.Articulos3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.preciosParaGondolas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(766, 478);
            this.reportViewer1.TabIndex = 6;
            // 
            // ArticulosBindingSource
            // 
            this.ArticulosBindingSource.DataMember = "Articulos";
            this.ArticulosBindingSource.DataSource = this.DS_NoTipado;
            // 
            // DS_NoTipado
            // 
            this.DS_NoTipado.DataSetName = "DS_NoTipado";
            this.DS_NoTipado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Articulos2BindingSource
            // 
            this.Articulos2BindingSource.DataMember = "Articulos2";
            this.Articulos2BindingSource.DataSource = this.DS_NoTipado;
            // 
            // Articulos3BindingSource
            // 
            this.Articulos3BindingSource.DataMember = "Articulos3";
            this.Articulos3BindingSource.DataSource = this.DS_NoTipado;
            // 
            // R_PreciosParaGondola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 478);
            this.Controls.Add(this.reportViewer1);
            this.Name = "R_PreciosParaGondola";
            this.Text = "R_PreciosParaGaleria";
            this.Load += new System.EventHandler(this.R_PreciosParaGondola_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ArticulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NoTipado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Articulos2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Articulos3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ArticulosBindingSource;
        private DS_NoTipado DS_NoTipado;
        private System.Windows.Forms.BindingSource Articulos2BindingSource;
        private System.Windows.Forms.BindingSource Articulos3BindingSource;

    }
}