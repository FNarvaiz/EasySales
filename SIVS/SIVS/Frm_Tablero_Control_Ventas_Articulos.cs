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
    public partial class Frm_Tablero_Control_Ventas_Articulos : Form
    {
        private static Frm_Tablero_Control_Ventas_Articulos frm;
        Ctrl_tablero admTablero = new Ctrl_tablero();
        Ctrl_rubros admrubro = Ctrl_rubros.ClaseActiva();
        DataTable DT;

        public static Frm_Tablero_Control_Ventas_Articulos AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_Ventas_Articulos();
            }
            frm.Focus();
            return frm;
        }
        public Frm_Tablero_Control_Ventas_Articulos()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                    DT = admTablero.DevolverVentasArticulosBD(dtp_cajas_desde.Value.ToShortDateString(), dtp_cajas_hasta.Value.ToShortDateString(), cb_FiltrarRubro.Checked, (Crubro)cbb_Rubro.SelectedItem);
                    dgrid_ventas.DataSource = DT;
            }
            catch { }
        }
        private void ActualizarRubros()
        {
            bs_rubros.ResetBindings(false);
            bs_rubros.DataSource = admrubro.VerLista();
            cbb_Rubro.DataSource = bs_rubros;
            cbb_Rubro.DisplayMember = "Nombre";
        }

        private void Frm_Tablero_Control_Ventas_Articulos_Shown(object sender, EventArgs e)
        {
            ActualizarRubros();
            if (bs_rubros.Count > 0)
            {
                cbb_Rubro.Enabled = true;
                cb_FiltrarRubro.Enabled = true;
            }
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
    }
}
