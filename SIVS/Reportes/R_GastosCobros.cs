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
    public partial class R_GastosCobros : Form
    {
        DateTime Inicio;
        DateTime Fin;
        public R_GastosCobros(DateTime inicio,DateTime fin)
        {
            InitializeComponent();
            Inicio = inicio;
            Fin = fin;
        }


        private void R_GastosCobros_Shown(object sender, EventArgs e)
        {
            string fecha1 = Inicio.ToShortDateString();
            string fecha2 = Fin.ToShortDateString();
            Microsoft.Reporting.WinForms.ReportParameter FechaIncio = new Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", fecha1);
            Microsoft.Reporting.WinForms.ReportParameter FechaFin = new Microsoft.Reporting.WinForms.ReportParameter("FechaFin", fecha2);
            bs_cobros.DataSource = Cdatos_cajas_diarias.DevolverCobros(fecha1, fecha2);
            bs_gastos.DataSource = Cdatos_cajas_diarias.DevolverGastos(fecha1, fecha2);
            reportViewer1.LocalReport.SetParameters(FechaIncio);
            reportViewer1.LocalReport.SetParameters(FechaFin);
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
