using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Tablero_Control_Rubros : Form
    {
        private static Frm_Tablero_Control_Rubros frm;

        Ctrl_tablero admTablero = new Ctrl_tablero();
        Ctrl_rubros amdRubro = Ctrl_rubros.ClaseActiva();

        public Frm_Tablero_Control_Rubros()
        {
            InitializeComponent();
        }

        public static Frm_Tablero_Control_Rubros AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_Rubros();
            }
            frm.Focus();
            return frm;
        }

        private void Frm_Tablero_Control_Rubros_Load(object sender, EventArgs e)
        {
            dgrid_CantArtiPorRubro.DataSource = admTablero.DevolverCantidadDeArticulosVigentesPorRubro();
            lbl_CantRubros.Text= amdRubro.CantidadDeRubrosCanrgados().ToString();
        }

        private void btn_BuscarRubro_Click(object sender, EventArgs e)
        {
            dgrid_MontoVentasPorRubro.DataSource = admTablero.DevolverMontoDeVentasPorRubro(dtp_monto_desde.Value.ToShortDateString(), dtp_monto_hasta.Value.ToShortDateString());
        }

        private void Frm_Tablero_Control_Rubros_Shown(object sender, EventArgs e)
        {
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
