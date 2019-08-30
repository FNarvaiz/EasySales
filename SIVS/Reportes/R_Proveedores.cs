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
    public partial class R_Proveedores : Form
    {
        bool altas;
        public R_Proveedores(bool Altas)
        {
            InitializeComponent();
            altas = Altas;
        }

        private void R_Proveedores_Load(object sender, EventArgs e)
        {
            ProveedoresBindingSource.DataSource = Cdatos_reportes.Proveedores(altas);
            System.Drawing.Printing.PageSettings page = new System.Drawing.Printing.PageSettings();
            page.Margins = new System.Drawing.Printing.Margins(50, 50, 50, 50);
            reportViewer1.SetPageSettings(page);
            this.reportViewer1.RefreshReport();
        }
    }
}
