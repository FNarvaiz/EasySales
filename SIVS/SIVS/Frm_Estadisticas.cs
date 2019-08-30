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
    public partial class Frm_Estadisticas : Form
    {
        private static Frm_Estadisticas frm;
        Ctrl_tablero admEstadisticas = new Ctrl_tablero();
        

        public static Frm_Estadisticas AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Estadisticas();
            }
            frm.Focus();
            return frm;
        }
        
        public Frm_Estadisticas()
        {
            InitializeComponent();
        }

        private void Frm_Estadisticas_Load(object sender, EventArgs e)
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
            Height = 512;
            dtp_desde.Value = DateTime.Today.AddMonths(-1);

            dgrid_EstadisticasArt.DataSource = admEstadisticas.DevolverEstadisticas(dtp_desde.Value.ToShortDateString(), dtp_hasta.Value.ToShortDateString());
        }


        private void btn_mostrarReferencias_Click(object sender, EventArgs e)
        {
            if (Height < 621)
            {
                Height = 621;
                btn_mostrarReferencias.Text = "Ocultar Referencias";
            }
            else
            {
                Height = 512;
                btn_mostrarReferencias.Text = "Mostrar Referencias";
            }
        }

        private void dtp_hasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_hasta.Value < dtp_desde.Value)
            {
                dtp_hasta.Value = dtp_desde.Value;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            dgrid_EstadisticasArt.DataSource = admEstadisticas.DevolverEstadisticas(dtp_desde.Value.ToShortDateString(), dtp_hasta.Value.ToShortDateString());
        }
    }
}
