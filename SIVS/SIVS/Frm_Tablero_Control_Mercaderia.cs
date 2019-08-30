using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using CLASES;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Tablero_Control_Mercaderia : Form
    {
        static Frm_Tablero_Control_Mercaderia frm;
        cActivoMercaderia _mercaderias;
        public Frm_Tablero_Control_Mercaderia()
        {
            InitializeComponent();
        }
        public static Frm_Tablero_Control_Mercaderia AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_Mercaderia();
                Ctrl_articulos ctrl = Ctrl_articulos.ClaseActiva();
                frm._mercaderias = ctrl.TraerMercaderia();
            }
            frm.Focus();
            return frm;
        }

        private void Frm_ctrlMercaderia_Load(object sender, EventArgs e)
        {

        }

        private void Frm_ctrlMercaderia_Shown(object sender, EventArgs e)
        {
            bs_mercaderias.DataSource = _mercaderias.Lista;
            dgrid_objetos.DataSource = bs_mercaderias;
            lbl_activoAlCosto.Text = _mercaderias.TotalAlCosto.ToString();
            lbl_activoAlPrecio.Text = _mercaderias.TotalAlPrecio.ToString();
            lbl_utilidad.Text = _mercaderias.TotalUltilidad.ToString();
            if (Form1.objConf.Version < 2)
            {
                Frm_confirmacion frm = new Frm_confirmacion("Esta opción se encuentra disponible a partir de la versión PRO, contáctenos a traves de nuestra página y/o facebook para ser PRO!", "Función no disponible", "Aceptar", "Ir a la página");
                frm.ShowDialog();
                if (frm.RESPUESTA != null)
                {
                    if (frm.RESPUESTA == "Ir a la página")
                    {
                        Process.Start("www.facebook.com/easysoftgt");
                    }
                }
                Close();
            }
        }

        private void dgrid_objetos_Resize(object sender, EventArgs e)
        {

            if (dgrid_objetos.Width > dgrid_objetos.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed))
                dgrid_objetos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            else
                dgrid_objetos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void dgrid_objetos_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn columna = dgrid_objetos.Columns[e.ColumnIndex];
            _mercaderias.OrdenarPor(columna.HeaderText);
            bs_mercaderias.DataSource = _mercaderias.Lista;
            dgrid_objetos.DataSource = bs_mercaderias;
        }

        private void dgrid_objetos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dgrid_objetos.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }
    }
}
