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
    public partial class Frm_Tablero_Control_Gastos : Form
    {
        private static Frm_Tablero_Control_Gastos frm;
        Ctrl_tablero admTablero = new Ctrl_tablero();
        Ctrl_conceptos admconcep = Ctrl_conceptos.ClaseActiva();

        public Frm_Tablero_Control_Gastos()
        {
            InitializeComponent();
        }

        public static Frm_Tablero_Control_Gastos AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_Gastos();
            }
            frm.Focus();
            return frm;
        }

        private void Frm_Tablero_Control_Gastos_Load(object sender, EventArgs e)
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

            dtp_gastos_desde.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            dtp_cobros_desde.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);
            LlenarDatagridgastos();
            LlenarDatagridCobros();
            CargarConceptos();           

        }

        public void LlenarDatagridgastos()
        {
            DataTable DT = new DataTable();

            if (cb_FiltrarGastos.Checked)
            {
                DT = admTablero.DevolverGastos(dtp_gastos_desde.Value.ToShortDateString(),dtp_gastos_hasta.Value.ToShortDateString(),(Cconcepto)cbb_conceptosGastos.SelectedItem);
            }
            else
            {
                DT = admTablero.DevolverGastos(dtp_gastos_desde.Value.ToShortDateString(), dtp_gastos_hasta.Value.ToShortDateString());
            }

            dgrid_gastos.DataSource = DT;
            lbl_TotalGastos.Text = DT.Compute("SUM(Importe)", "").ToString();
        }

        public void LlenarDatagridCobros()
        {
            DataTable DT = new DataTable();

            if (cb_FiltrarCobros.Checked)
            {
                DT = admTablero.DevolverCobros(dtp_cobros_desde.Value.ToShortDateString(), dtp_cobros_hasta.Value.ToShortDateString(), (Cconcepto)cbb_conceptosCobros.SelectedItem);
            }
            else
            {
                DT = admTablero.DevolverCobros(dtp_cobros_desde.Value.ToShortDateString(), dtp_cobros_hasta.Value.ToShortDateString());
            }

            dgrid_cobros.DataSource = DT;
            lbl_TotalCobros.Text = DT.Compute("SUM(Importe)", "").ToString();
        }        

        private void CargarConceptos()
        {
            bs_conceptosGastos.ResetBindings(false);
            bs_conceptosGastos.DataSource = admconcep.VerLista();
            cbb_conceptosGastos.DataSource = bs_conceptosGastos;
            cbb_conceptosGastos.DisplayMember = "Concepto";

            bs_conceptosCobros.ResetBindings(false);
            bs_conceptosCobros.DataSource = admconcep.VerLista();
            cbb_conceptosCobros.DataSource = bs_conceptosCobros;
            cbb_conceptosCobros.DisplayMember = "Concepto";
        }        

        private void cb_FiltrarGastos_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_FiltrarGastos.Checked)
            {
                cbb_conceptosGastos.Enabled = true;
                lbl_Gastos.Visible = true;
            }
            else
            {
                cbb_conceptosGastos.Enabled = false;
                lbl_Gastos.Visible = false;
            }
        }

        private void cb_FiltrarCobros_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_FiltrarCobros.Checked)
            {
                cbb_conceptosCobros.Enabled = true;
                lbl_Cobros.Visible = true;
            }
            else
            {
                cbb_conceptosCobros.Enabled = false;
                lbl_Cobros.Visible = false;
            }
        }

        private void btn_BuscarGastos_Click(object sender, EventArgs e)
        {
            LlenarDatagridgastos();
        }

        private void dtp_gastos_desde_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_gastos_hasta.Value < dtp_gastos_desde.Value)
            {
                dtp_gastos_hasta.Value = dtp_gastos_desde.Value;
            }
        }

        private void dtp_gastos_hasta_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_gastos_hasta.Value < dtp_gastos_desde.Value)
            {
                dtp_gastos_desde.Value = dtp_gastos_hasta.Value;
            }
        }

        private void dtp_desde_Cobros_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_cobros_hasta.Value < dtp_cobros_desde.Value)
            {
                dtp_cobros_hasta.Value = dtp_cobros_desde.Value;
            }
        }

        private void dtp_hasta_Cobros_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_cobros_hasta.Value < dtp_cobros_desde.Value)
            {
                dtp_cobros_desde.Value = dtp_cobros_hasta.Value;
            }
        }

        private void btn_BuscarCobros_Click(object sender, EventArgs e)
        {
            LlenarDatagridCobros();
        }

    }
}
