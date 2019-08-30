using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLASES;
using C_DATOS;
namespace Reportes
{
    public partial class R_PreciosParaGondola : Form
    {
        List<Carticulo> _listaArticulos;
        public R_PreciosParaGondola(List<Carticulo> lista)
        {
            InitializeComponent();
            _listaArticulos = lista;
        }

        private void R_PreciosParaGondola_Load(object sender, EventArgs e)
        {

            DataTable tabla = new DataTable();
            tabla.Columns.Add("Descripcion", typeof(string));
            tabla.Columns.Add("Precio", typeof(decimal));
            decimal resultado = Convert.ToDecimal( _listaArticulos.Count )/ 3;
            int count = 0;
            while (count <resultado)
            {
                DataRow fila = tabla.NewRow();
                fila["Descripcion"] = _listaArticulos[count].Descripcion;
                fila["Precio"] = _listaArticulos[count].Precio;
                tabla.Rows.Add(fila);
                count++;
            }
            ArticulosBindingSource.DataSource = tabla;
            tabla = new DataTable();
            tabla.Columns.Add("Descripcion", typeof(string));
            tabla.Columns.Add("Precio", typeof(decimal));
            resultado += resultado;
            while (count <= resultado)
            {
                DataRow fila = tabla.NewRow();
                fila["Descripcion"] = _listaArticulos[count].Descripcion;
                fila["Precio"] = _listaArticulos[count].Precio;
                tabla.Rows.Add(fila);
                count++;
            }
            Articulos2BindingSource.DataSource = tabla;
            tabla = new DataTable();
            tabla.Columns.Add("Descripcion", typeof(string));
            tabla.Columns.Add("Precio", typeof(decimal));
            resultado += resultado;
            while (count <= resultado && count<_listaArticulos.Count)
            {
                DataRow fila = tabla.NewRow();
                fila["Descripcion"] = _listaArticulos[count].Descripcion;
                fila["Precio"] = _listaArticulos[count].Precio;
                tabla.Rows.Add(fila);
                count++;
            }
            Articulos3BindingSource.DataSource = tabla;
            this.reportViewer1.RefreshReport();
        }
    }
}
