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
    public partial class Frm_Tablero_Control_CtasCtes : Form
    {
        private static Frm_Tablero_Control_CtasCtes frm;

        Ctrl_tablero admTablero = new Ctrl_tablero();

        public static Frm_Tablero_Control_CtasCtes AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_CtasCtes();
            }
            frm.Focus();
            return frm;
        }

        public Frm_Tablero_Control_CtasCtes()
        {
            InitializeComponent();
        }

        public void CargarLabelsClientes()
        {
            DataTable DT = admTablero.DevolverTotalesCtaCteClientes();

            if (DT.Rows[0][1].ToString() != "")
            {
                lbl_debitosClientes.Text = DT.Rows[0][1].ToString();
            }
            else
            {
                lbl_debitosClientes.Text = "000,00";
            }

            if (DT.Rows[0][0].ToString() != "")
            {
                lbl_creditosClientes.Text = DT.Rows[0][0].ToString();
            }
            else
            {
                lbl_creditosClientes.Text = "000,00";
            }

            lbl_saldoClientes.Text = (Convert.ToDecimal(lbl_debitosClientes.Text) + Convert.ToDecimal(lbl_creditosClientes.Text)).ToString();
        }

        public void CargarLabelsProveedores()
        {
            DataTable DT = admTablero.DevolverTotalesCtaCteProveedores();


            if (DT.Rows[0][1].ToString() != "")
            {
                lbl_debitosProveedores.Text = DT.Rows[0][1].ToString();
            }
            else
            {
                lbl_debitosProveedores.Text = "000,00";
            }

            if (DT.Rows[0][0].ToString() != "")
            {
                lbl_creditosProveedores.Text = DT.Rows[0][0].ToString();
            }
            else
            {
                lbl_creditosProveedores.Text = "000,00";
            }

            lbl_saldoProveedores.Text = (Convert.ToDecimal(lbl_creditosProveedores.Text) + Convert.ToDecimal(lbl_debitosProveedores.Text)).ToString();

        }

        public void CargarLabelsUsuarios()
        {
            DataTable DT = admTablero.DevolverSaldosUsuarios();

            if (DT.Rows[0][1].ToString() != "")
            {
                lbl_debitosUsuarios.Text = DT.Rows[0][1].ToString();
            }
            else
            {
                lbl_debitosUsuarios.Text = "000,00";
            }

            if (DT.Rows[0][0].ToString() != "")
            {
                lbl_creditosUsuarios.Text = DT.Rows[0][0].ToString();
            }
            else
            {
                lbl_creditosUsuarios.Text = "000,00";
            }

            lbl_saldoUsuarios.Text = (Convert.ToDecimal(lbl_creditosUsuarios.Text) + Convert.ToDecimal(lbl_debitosUsuarios.Text)).ToString();

        }

        public void CargarLabelsTotales()
        {
            DataTable DT = admTablero.DevolverSaldosTotales();

            if (DT.Rows[0][1].ToString() != "")
            {
                lbl_debitosTotal.Text = DT.Rows[0][1].ToString();
            }
            else
            {
                lbl_debitosTotal.Text = "000,00";
            }

            if (DT.Rows[0][0].ToString() != "")
            {
                lbl_creditosTotal.Text = DT.Rows[0][0].ToString();
            }
            else
            {
                lbl_creditosTotal.Text = "000,00";
            }

            lbl_saldoTotal.Text = (Convert.ToDecimal(lbl_creditosTotal.Text) + Convert.ToDecimal(lbl_debitosTotal.Text)).ToString();

        }

        private void Frm_Tablero_Control_CtasCtes_Load(object sender, EventArgs e)
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

            rb_vigentes.Checked = true;            
            CargarLabelsUsuarios();
            CargarLabelsClientes();
            CargarLabelsProveedores();
            CargarLabelsTotales();
        }

        private void rb_vigentes_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_vigentes.Checked)
            {
                dgrid_saldos.DataSource = admTablero.DevolverSaldosCuentasCorrientes(true);
            }
            else if (rb_NoVigentes.Checked)
            {
                dgrid_saldos.DataSource = admTablero.DevolverSaldosCuentasCorrientes(false);
            }
            else
            {
                dgrid_saldos.DataSource = admTablero.DevolverSaldosCuentasCorrientes();
            }
            dgrid_saldos.Columns[0].Visible = false;
        }
    }
}
