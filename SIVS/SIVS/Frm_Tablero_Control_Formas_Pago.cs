using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;
using CONTROL;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Tablero_Control_Formas_Pago : Form
    {
        private static Frm_Tablero_Control_Formas_Pago frm;
        Ctrl_tablero admTablero = new Ctrl_tablero();

        public Frm_Tablero_Control_Formas_Pago()
        {
            InitializeComponent();
        }

        public static Frm_Tablero_Control_Formas_Pago AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_Formas_Pago();
            }
            frm.Focus();
            return frm;
        }

        private void Frm_Tablero_Control_Formas_Pago_Load(object sender, EventArgs e)
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

            dtp_formaPago_desde.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            LlenarDatagridRankFormaPago();
            dgrid_RankFormasPago.Columns[0].Visible = false;          
        }

        public void LlenarDatagridRankFormaPago()
        {
            dgrid_RankFormasPago.DataSource = admTablero.DevolverRankFormasPago(dtp_formaPago_desde.Value.ToShortDateString(), dtp_formaPago_hasta.Value.ToShortDateString());

        }

        private void dtp_formaPago_hasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_formaPago_hasta.Value < dtp_formaPago_desde.Value)
            {
                dtp_formaPago_hasta.Value = dtp_formaPago_desde.Value;
            }

            LlenarDatagridRankFormaPago();
        }       

        
    }
}
