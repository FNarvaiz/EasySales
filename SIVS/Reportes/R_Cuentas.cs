using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_DATOS;
namespace Reportes
{
    public partial class R_Cuentas : Form
    {
        bool Alta;
        int tagIndicador;
        public R_Cuentas(int tag ,bool altas)
        {
            InitializeComponent();
            Alta = altas;
            tagIndicador = tag;
        }

        private void R_CuentasProveedores_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter Personas;
            if (tagIndicador == 1)
            {
                Personas = new Microsoft.Reporting.WinForms.ReportParameter("Personas", "clientes");
                CuentasCorrientesBindingSource.DataSource = Cdatos_reportes.CuentasClientes(Alta);
            }
            else if (tagIndicador == 2)
            {
                Personas = new Microsoft.Reporting.WinForms.ReportParameter("Personas", "proveedores");
                CuentasCorrientesBindingSource.DataSource = Cdatos_reportes.CuentasProveedores(Alta);
            }
            else
            {
                Personas = new Microsoft.Reporting.WinForms.ReportParameter("Personas", "Usuarios");
                CuentasCorrientesBindingSource.DataSource = Cdatos_reportes.CuentasUsuarios(Alta);
            }
            reportViewer1.LocalReport.SetParameters(Personas);
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
