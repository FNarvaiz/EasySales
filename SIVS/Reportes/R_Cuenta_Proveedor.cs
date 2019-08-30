using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;
using C_DATOS;
namespace Reportes
{
    public partial class R_Cuenta_Proveedor : Form
    {
        Cpersona oPersona;
        public R_Cuenta_Proveedor(Cpersona oper)
        {
            InitializeComponent();
            oPersona = oper;
        }

        private void R_Cuenta_Proveedor_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter Nombre = new Microsoft.Reporting.WinForms.ReportParameter("Nombre", oPersona.Nombre);
            Microsoft.Reporting.WinForms.ReportParameter Saldo = new Microsoft.Reporting.WinForms.ReportParameter("Saldo", oPersona.DevolverCuentaCorriente().Saldo.ToString());
            Microsoft.Reporting.WinForms.ReportParameter Direccion = new Microsoft.Reporting.WinForms.ReportParameter("Direccion", oPersona.Domicilio);
            Microsoft.Reporting.WinForms.ReportParameter Particular = new Microsoft.Reporting.WinForms.ReportParameter("Particular", oPersona.Tel);
            Microsoft.Reporting.WinForms.ReportParameter Celular = new Microsoft.Reporting.WinForms.ReportParameter("Celular", oPersona.Cel);
            Microsoft.Reporting.WinForms.ReportParameter CUIT = new Microsoft.Reporting.WinForms.ReportParameter("CUIT", ((Cproveedor)oPersona).CUIT);
            reportViewer1.LocalReport.SetParameters(CUIT);
            reportViewer1.LocalReport.SetParameters(Nombre);
            reportViewer1.LocalReport.SetParameters(Direccion);
            reportViewer1.LocalReport.SetParameters(Saldo);
            reportViewer1.LocalReport.SetParameters(Particular);
            reportViewer1.LocalReport.SetParameters(Celular);
            CreditosBindingSource.DataSource =Cdatos_reportes.DevolverCreditos(oPersona.DevolverCuentaCorriente());
            DebitosBindingSource.DataSource = Cdatos_reportes.DevolverDebitos(oPersona.DevolverCuentaCorriente());
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
