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
    public partial class R_CajasDiarias : Form
    {
        DateTime Inicio;
        DateTime Fin;
        public R_CajasDiarias(DateTime inicio,DateTime fin)
        {
            InitializeComponent();
            Inicio = inicio;
            Fin = fin;
        }

        private void R_CajasDiarias_Load(object sender, EventArgs e)
        {
            string fecha1=Inicio.ToShortDateString();
            string fecha2=Fin.ToShortDateString();
            Microsoft.Reporting.WinForms.ReportParameter FechaIncio = new Microsoft.Reporting.WinForms.ReportParameter("FechaInicio", fecha1);
            Microsoft.Reporting.WinForms.ReportParameter FechaFin = new Microsoft.Reporting.WinForms.ReportParameter("FechaFin", fecha2);
            CajasDiariasBindingSource.DataSource = Cdatos_cajas_diarias.Devolver(fecha1, fecha2);
            reportViewer1.LocalReport.SetParameters(FechaIncio);
            reportViewer1.LocalReport.SetParameters(FechaFin);
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
