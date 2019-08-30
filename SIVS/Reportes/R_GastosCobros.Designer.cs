namespace Reportes
{
    partial class R_GastosCobros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(R_GastosCobros));
            this.bs_cobros = new System.Windows.Forms.BindingSource(this.components);
            this.DS_NoTipado = new Reportes.DS_NoTipado();
            this.bs_gastos = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NoTipado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gastos)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_cobros
            // 
            this.bs_cobros.DataMember = "Cobros";
            this.bs_cobros.DataSource = this.DS_NoTipado;
            // 
            // DS_NoTipado
            // 
            this.DS_NoTipado.DataSetName = "DS_NoTipado";
            this.DS_NoTipado.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bs_gastos
            // 
            this.bs_gastos.DataMember = "Gastos";
            this.bs_gastos.DataSource = this.DS_NoTipado;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Cobros";
            reportDataSource1.Value = this.bs_cobros;
            reportDataSource2.Name = "Gastos";
            reportDataSource2.Value = this.bs_gastos;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Reportes.Inf_GastosCobros.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(562, 438);
            this.reportViewer1.TabIndex = 6;
            // 
            // R_GastosCobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 438);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "R_GastosCobros";
            this.Text = "Reporte de cajas diarias";
            this.Shown += new System.EventHandler(this.R_GastosCobros_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bs_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_NoTipado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gastos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DS_NoTipado DS_NoTipado;
        private System.Windows.Forms.BindingSource bs_cobros;
        private System.Windows.Forms.BindingSource bs_gastos;
    }
}