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
    public partial class R_Articulos : Form
    {
        int tagIndicador;
        public R_Articulos(int tag )
        {
            InitializeComponent();
            tagIndicador = tag;
        }

        private void R_Articulos_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter Descripcion;
            if (tagIndicador == 1)
            {
                Descripcion = new Microsoft.Reporting.WinForms.ReportParameter("Descripcion", "Stock Bajo");
                System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
                page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
                reportViewer1.SetPageSettings(page);
                ArticulosBindingSource.DataSource = Cdatos_reportes.StockBajo();
            }
            else if (tagIndicador == 2)
            {
                Descripcion = new Microsoft.Reporting.WinForms.ReportParameter("Descripcion", "Stock medio");
                ArticulosBindingSource.DataSource = Cdatos_reportes.StockMedio();
            }
            else if (tagIndicador == 3)
            {
                Descripcion = new Microsoft.Reporting.WinForms.ReportParameter("Descripcion", "Stock Alto");
                ArticulosBindingSource.DataSource = Cdatos_reportes.StockAlto();
            }
            else
            {
                Descripcion = new Microsoft.Reporting.WinForms.ReportParameter("Descripcion", "Stock Todos");
                ArticulosBindingSource.DataSource = Cdatos_reportes.StockTodos();
            }
            reportViewer1.LocalReport.SetParameters(Descripcion);
            this.reportViewer1.RefreshReport();
        }
    }
}
