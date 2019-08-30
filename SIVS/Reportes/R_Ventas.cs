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
    public partial class R_Ventas : Form
    {
        DateTime Dia;
        public R_Ventas(DateTime dia)
        {
            InitializeComponent();
            Dia = dia;
        }

        private void R_Ventas_Load(object sender, EventArgs e)
        {
            string dia = Dia.ToShortDateString();
            Microsoft.Reporting.WinForms.ReportParameter Descripcion= new Microsoft.Reporting.WinForms.ReportParameter("Fecha", dia);
            VentasBindingSource.DataSource = Cdatos_reportes.VentasDia(dia);
            reportViewer1.LocalReport.SetParameters(Descripcion);
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
