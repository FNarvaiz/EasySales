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
using CLASES;
namespace Reportes
{
    public partial class R_Venta : Form
    {
        int id_Caja_diaria;
        DateTime _Fecha;
        Cventa oVenta;
        public R_Venta(int idCajaDiaria, Cventa O_Venta,DateTime fecha)
        {
            InitializeComponent();
            id_Caja_diaria = idCajaDiaria;
            oVenta = O_Venta;
            _Fecha = fecha;
        }

        private void R_Venta_Load(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter Fecha = new Microsoft.Reporting.WinForms.ReportParameter("Fecha", _Fecha.ToShortDateString());
            Microsoft.Reporting.WinForms.ReportParameter NumeroVenta = new Microsoft.Reporting.WinForms.ReportParameter("NumeroVenta", oVenta.ID.ToString());
            Microsoft.Reporting.WinForms.ReportParameter NumCaja = new Microsoft.Reporting.WinForms.ReportParameter("NumCaja", id_Caja_diaria.ToString());
            Microsoft.Reporting.WinForms.ReportParameter Subtotal = new Microsoft.Reporting.WinForms.ReportParameter("Subtotal", oVenta.Subtotal.ToString());
            Microsoft.Reporting.WinForms.ReportParameter Descuento = new Microsoft.Reporting.WinForms.ReportParameter("Descuento", oVenta.DescRecargo.ToString());
            Microsoft.Reporting.WinForms.ReportParameter Total = new Microsoft.Reporting.WinForms.ReportParameter("Total", oVenta.Total.ToString());
            Microsoft.Reporting.WinForms.ReportParameter FormaDePago = new Microsoft.Reporting.WinForms.ReportParameter("FormaDePago", oVenta.Pago.FormaPago.Descripcion);
            reportViewer1.LocalReport.SetParameters(FormaDePago);
            reportViewer1.LocalReport.SetParameters(Fecha);
            reportViewer1.LocalReport.SetParameters(NumeroVenta);
            reportViewer1.LocalReport.SetParameters(NumCaja);
            reportViewer1.LocalReport.SetParameters(Subtotal);
            reportViewer1.LocalReport.SetParameters(Descuento);
            reportViewer1.LocalReport.SetParameters(Total);
            ItemsBindingSource.DataSource = Cdatos_ventas.DevolverItemsVenta(oVenta, id_Caja_diaria);
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            /*System.Drawing.Printing.PaperSize size = new System.Drawing.Printing.PaperSize();
            size.RawKind = (int)System.Drawing.Printing.PaperKind.A5; ;
            page.PaperSize = size;*/
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
