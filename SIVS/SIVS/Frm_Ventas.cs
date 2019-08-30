using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASES;
using CONTROL;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Ventas : SIVS.Frm_ABM
    {
        Ctrl_cajas_diarias admCajasDiarias = Ctrl_cajas_diarias.ClaseActiva();
        static Frm_Ventas frm;

        public static Frm_Ventas AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Ventas();
            }
            frm.Focus();
            return frm;
        }

        public Frm_Ventas()
        {
            InitializeComponent();
        }

        private void Frm_Ventas_Load(object sender, EventArgs e)
        {
            dtp_desde.Value = DateTime.Today.AddDays(-DateTime.Today.Day + 1);                      
        }

        private void dtp_desde_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtp_desde.Value <= DateTime.Today)
                {
                    bs_CajasDiarias.ResetBindings(false);
                    bs_CajasDiarias.DataSource = admCajasDiarias.DevolverCajas(dtp_desde.Value,dtp_hasta.Value);
                    dgrid_CajasDiarias.DataSource = bs_CajasDiarias;
                    dgrid_CajasDiarias.Columns[0].Visible = false;
                }
                else
                {
                    Frm_confirmacion frm = new Frm_confirmacion("La fecha no puede ser posterior al día actual.", "Fecha incorrecta", "Aceptar");
                    frm.ShowDialog();
                }
            }
            catch(Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Error al devolver datos", "Aceptar");
                frm.ShowDialog();
            }
            
        }

        private void dgrid_CajasDiarias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_CajasDiarias.Rows.Count > 0)
            {
                bs_Ventas.ResetBindings(false);
                Ccaja_diaria oCaja = (Ccaja_diaria)dgrid_CajasDiarias.CurrentRow.DataBoundItem;
                admCajasDiarias.CargarVentasSinCalcular(oCaja);
                bs_Ventas.DataSource = oCaja.LISTAVENTAS();
                dgrid_Ventas.DataSource = bs_Ventas;
                dgrid_Ventas.Columns[2].Visible = false;
            }
        }

      
        private void dgrid_Ventas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView dgrid = (DataGridView)sender;
                if (dgrid.SelectedRows.Count > 0)
                {
                    int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                    if (cal > e.Location.Y && e.Location.Y > 33)
                    {
                        Cventa oventa = (Cventa)dgrid_Ventas.CurrentRow.DataBoundItem;
                        Ccaja_diaria oCaja = (Ccaja_diaria)dgrid_CajasDiarias.CurrentRow.DataBoundItem;
                        if (oventa.Items() == null || oventa.Items().Count == 0)
                        {
                            Ctrl_Ventas admventa = Ctrl_Ventas.ClaseActiva();
                            admventa.CargarItems(oventa, oCaja.ID);
                        }
                        string argumento = "Forma de pago : " + oventa.Pago.FormaPago + "\nDesc/Rec : $" + oventa.Pago.Descuento + "\nImporte : $ " + oventa.Pago.Importe;
                        if(oventa.Pago2!=null)
                            argumento = argumento + "\nForma de pago 2 : " + oventa.Pago2.FormaPago + "\nDesc/Rec : $" + oventa.Pago2.Descuento + "\nImporte : $ " + oventa.Pago2.Importe;
                        
                        Frm_Items frmItems = new Frm_Items( argumento,oventa,oCaja,oCaja.Fecha);
                        frmItems.ShowDialog();
                        bs_Ventas.ResetBindings(false);
                        bs_Ventas.DataSource = oCaja.LISTAVENTAS();
                        dgrid_Ventas.DataSource = bs_Ventas;
                        dgrid_Ventas.Columns[2].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        protected override void btn_Agregar_Click(object sender, EventArgs e)
        {
            if(dgrid_CajasDiarias.SelectedRows.Count>0){
                Reportes.R_Ventas frm = new Reportes.R_Ventas(((Ccaja_diaria)dgrid_CajasDiarias.CurrentRow.DataBoundItem).Fecha);
                frm.Show();
            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Reportes.R_CajasDiarias frm = new Reportes.R_CajasDiarias(dtp_desde.Value, dtp_hasta.Value);
            frm.Show();
        }

        private void Frm_Ventas_Shown(object sender, EventArgs e)
        {
            if (Form1.objConf.Version < 1)
            {
                Frm_confirmacion frm = new Frm_confirmacion("Esta opción se encuentra disponible a partir de la versión Basic, contáctenos a traves de nuestra página y/o facebook para ser Basic!", "Función no disponible", "Aceptar", "Ir a la página");
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

        private void buttonImages1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Reportes.R_GastosCobros frm = new Reportes.R_GastosCobros(dtp_desde.Value, dtp_hasta.Value);
            frm.Show();
        }
    }
}
