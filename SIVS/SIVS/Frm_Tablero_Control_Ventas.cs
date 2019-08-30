using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROL;
using CLASES;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Tablero_Control_Ventas : Form
    {
        private static Frm_Tablero_Control_Ventas frm;
        Ctrl_tablero admTablero = new Ctrl_tablero();
        Ctrl_formas_pagos admformas = Ctrl_formas_pagos.ClaseActiva();
        Ctrl_rubros admrubro = Ctrl_rubros.ClaseActiva();
        DataTable DT;        

        public static Frm_Tablero_Control_Ventas AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control_Ventas();
            }
            frm.Focus();
            return frm;
        }

        public Frm_Tablero_Control_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Tablero_Control_Ventas_Load(object sender, EventArgs e)
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

            dtp_cajas_desde.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);            

            DataTable DT2 = new DataTable();
            DT2 = admTablero.DevolverVentasBD();
            lbl_total_Dia.Text = DT2.Compute("SUM(Total)", "Fecha = '" + DateTime.Today.ToShortDateString() + "'").ToString();
            lbl_total_mes.Text = DT2.Compute("SUM(Total)", "Fecha >= '" + DateTime.Today.AddDays(-DateTime.Today.Day + 1).ToShortDateString() + "'").ToString();
            lbl_total_año.Text = DT2.Compute("SUM(Total)", "Fecha >= '" + (DateTime.Today.AddDays(-DateTime.Today.Day + 1)).AddMonths(-DateTime.Today.Month + 1) + "'").ToString();         
            ActualizarDgrid();
            ActualizarRubros();
            CargarLabelsVentas();            
            
        }

        private void ActualizarRubros()
        {
            bs_rubros.ResetBindings(false);
            bs_rubros.DataSource = admrubro.VerLista();
            cbb_Rubro.DataSource = bs_rubros;
            cbb_Rubro.DisplayMember = "Nombre";
        }

        public void CargarLabelsVentas()
        {
            decimal desc=0;
            decimal rec=0;
            decimal sub=0;

            foreach (DataRow DR in DT.Rows)
            {
                sub += Convert.ToDecimal(DR[2]);

                if (Convert.ToDecimal(DR[3]) > 0)
                {
                    rec += Convert.ToDecimal(DR[3]);                
                }
                else
                {
                    desc += Convert.ToDecimal(DR[3]);
                }
            }

            lbl_recargos.Text = rec.ToString();
            lbl_desc.Text = desc.ToString();
            lbl_Subtotal.Text = sub.ToString();
            lbl_Total.Text = ( sub + desc + rec).ToString();            
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {            
            ActualizarDgrid();
            CargarLabelsVentas();         
            
        }

        private void ActualizarDgrid()
        {
            try
            {
                DT = admTablero.DevolverVentasBD(dtp_cajas_desde.Value.ToShortDateString(), dtp_cajas_hasta.Value.ToShortDateString());
                dgrid_ventas.DataSource = DT;
                dgrid_pagos.DataSource = DT;
                dgrid_ventas.Columns[5].Visible = false;
                dgrid_ventas.Columns[6].Visible = false;
                lbl_costos.Text = DT.Compute("SUM(Costo)", "").ToString();
                lbl_utilidad.Text = DT.Compute("SUM(Utilidad)", "").ToString();
            }
            catch { }
        }

        private void dtp_cajas_desde_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_cajas_hasta.Value < dtp_cajas_desde.Value)
            {
                dtp_cajas_hasta.Value = dtp_cajas_desde.Value;
            }
        }

        private void Frm_Tablero_Control_Ventas_Resize(object sender, EventArgs e)
        {

        }

        private void p_busqueda_Paint(object sender, PaintEventArgs e)
        {

        }

        //private List<Cventa> DevolverLista()
        //{
        //    List<Cventa> lista = new List<Cventa>();
        //    DataTable DT = admTablero.DevolverVentas(dtp_cajas_desde.Value.ToShortDateString(), dtp_cajas_hasta.Value.ToShortDateString());

        //    if (DT.Rows.Count != 0)
        //    {
        //        Cpago pago;
        //        int idventa;
        //        int anterior = 0;
        //        Cventa oventa = new Cventa();

        //        foreach (DataRow DR in DT.Rows)
        //        {
        //            pago = new Cpago(admformas.BuscarPorID(Convert.ToInt32(DR[7])), Convert.ToDecimal(DR[8]), "", Convert.ToDecimal(DR[9]));
        //            idventa = Convert.ToInt32(DR[6]);
        //            if (anterior == idventa)
        //            {
        //                oventa.Pago2 = pago;
        //                oventa.DescRecargo += pago.Descuento;
        //            }
        //            else
        //            {
        //                oventa = new Cventa(idventa, Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[3]), pago.Descuento, pago);
        //                lista.Add(oventa);
        //            }
        //            anterior = idventa;
        //        }
        //    }
        //    return lista;
        //}

    }
}
