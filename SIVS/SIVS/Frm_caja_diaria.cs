using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using CLASES;
namespace SIVS
{
    public partial class Frm_caja_diaria : Form
    {
        Ctrl_cajas_diarias adm = Ctrl_cajas_diarias.ClaseActiva();
        private static Frm_caja_diaria frmCaja;
        //LinearGradientBrush brocha;
        Ccaja_diaria ObjCajaDiaria;
        Cusuario oUsu;
        public static Frm_caja_diaria AbrirForm(Ccaja_diaria obj,Cusuario obju)
        {
            if ((frmCaja == null) || (frmCaja.IsDisposed))
            {
                frmCaja = new Frm_caja_diaria(obj,obju);
            }
            frmCaja.Focus();
            return frmCaja;
        }

        public Frm_caja_diaria(Ccaja_diaria obj,Cusuario obju)
        {
            InitializeComponent();
            ObjCajaDiaria = obj;
            oUsu = obju;
        }
        void ActualizarCobros()
        {
            bs_cobros.ResetBindings(true);
            bs_cobros.DataSource = ObjCajaDiaria.LISTACOBROS();
            dgrid_cobros.DataSource = bs_cobros;
            dgrid_cobros.ClearSelection();
            btn_ModificarCobro.Enabled = false;
            btn_EliminarCobro.Enabled = false;
            dgrid_cobros.Columns[3].Visible = false; 
            dgrid_cobros.Columns[2].Visible = false;
        }
        void ActualizarGastos()
        {
            bs_gastos.ResetBindings(true);
            bs_gastos.DataSource = ObjCajaDiaria.LISTAGASTOS();
            dgrid_gastos.DataSource = bs_gastos;
            dgrid_gastos.ClearSelection();
            btn_ModificarGasto.Enabled = false;
            btn_EliminarGasto.Enabled = false;
            dgrid_gastos.Columns[3].Visible = false;
            dgrid_gastos.Columns[2].Visible = false;
        }
        void Actualizarventas()
        {
            bs_ventas.ResetBindings(true);
            bs_ventas.DataSource = ObjCajaDiaria.LISTAVENTAS();
            dgrid_ventas.DataSource = bs_ventas;
            dgrid_ventas.Columns[2].Visible = false;
        }
        void Actuarlizarlabels()
        {
            lbl_Cobros.Text = ObjCajaDiaria.Cobros.ToString();
            lbl_EfecFinal.Text = ObjCajaDiaria.Efec_final.ToString();
            lbl_EfecInicial.Text = ObjCajaDiaria.Efec_inicial.ToString();
            lbl_Gastos.Text = ObjCajaDiaria.Gastos.ToString();
            lbl_Vefectivo.Text = ObjCajaDiaria.V_efectivo.ToString();
            lbl_Votros.Text = ObjCajaDiaria.V_otros.ToString();
            lbl_Vtotal.Text = ObjCajaDiaria.V_total.ToString();
            lbl_Ganancia.Text = ObjCajaDiaria.CalcularGanaciaSobreCosto().ToString();
        }
        private void btn_AgregarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Operacion frm = new Frm_Operacion(true, ObjCajaDiaria);
                frm.ShowDialog();
                ActualizarGastos();
                lbl_Gastos.Text = ObjCajaDiaria.Gastos.ToString();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_ModificarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Cgasto obj = (Cgasto)dgrid_gastos.CurrentRow.DataBoundItem;
                Cpersona opersona=null;
                if (adm.TieneCredito(obj))
                {
                    Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                    opersona = admcuentas.BuscarProveedor(obj);
                }
                Frm_Operacion frm = new Frm_Operacion(true, obj, ObjCajaDiaria, opersona);
                frm.ShowDialog();
                ActualizarGastos();
                lbl_Gastos.Text = ObjCajaDiaria.Gastos.ToString();
                lbl_EfecFinal.Text = ObjCajaDiaria.Efec_final.ToString();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_EliminarGasto_Click(object sender, EventArgs e)
        {
            try
            {
                Cgasto obj = (Cgasto)dgrid_gastos.CurrentRow.DataBoundItem;
                Frm_confirmacion frm = new Frm_confirmacion("Esta seguro que desea eliminar el gasto?", "Confirmación", "No", "Si");
                frm.ShowDialog();
                if (frm.RESPUESTA == "Si")
                {
                    if (adm.TieneCredito(obj))
                    {
                        frm = new Frm_confirmacion("El gasto tiene registros en una pago o credito en una cuenta corriente.\n El gasto se eliminara de la caja diaria pero no de la cuenta corriente.\n Quiere eliminarlo de todas formas?", "Referencias en una cuenta corriete", "No", "Si");
                        frm.ShowDialog();
                        if (frm.RESPUESTA == "Si")
                            adm.EliminarOperacion(obj, true, ObjCajaDiaria);
                    }
                    else
                    {
                        adm.EliminarOperacion(obj, false, ObjCajaDiaria);
                    }
                    ActualizarGastos();
                    lbl_Gastos.Text = ObjCajaDiaria.Gastos.ToString();
                    lbl_EfecFinal.Text = ObjCajaDiaria.Efec_final.ToString();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_AgregarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Operacion frm = new Frm_Operacion(false, ObjCajaDiaria);
                frm.ShowDialog();
                ActualizarCobros();
                lbl_Cobros.Text = ObjCajaDiaria.Cobros.ToString();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_ModificarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                Ccobro obj=(Ccobro)dgrid_cobros.CurrentRow.DataBoundItem;
                Cpersona opersona=null;
                if (adm.TieneDebito(obj))
                {
                    Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                    opersona = admcuentas.BuscarClienteUsuario(obj);
                }
                Frm_Operacion frm = new Frm_Operacion(false, obj, ObjCajaDiaria, opersona);
                frm.ShowDialog();
                ActualizarCobros();
                lbl_Cobros.Text = ObjCajaDiaria.Cobros.ToString();
                lbl_EfecFinal.Text = ObjCajaDiaria.Efec_final.ToString();

            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_EliminarCobro_Click(object sender, EventArgs e)
        {
            try
            {
                Ccobro obj = (Ccobro)dgrid_cobros.CurrentRow.DataBoundItem;
                Frm_confirmacion frm = new Frm_confirmacion("Esta seguro que desea eliminar el cobro?", "Confirmación", "No", "Si");
                frm.ShowDialog();
                if (frm.RESPUESTA == "Si")
                {
                    if (adm.TieneDebito(obj))
                    {
                        frm = new Frm_confirmacion("El cobro tiene registros en una recibo o debito en una cuenta corriente.\n El cobro se eliminara de la caja diaria pero no de la cuenta corriente.\n Quiere eliminarlo de todas formas?", "Referencias en una cuenta corriete", "No", "Si");
                        frm.ShowDialog();
                        if (frm.RESPUESTA == "Si")
                            adm.EliminarOperacion(obj, true, ObjCajaDiaria);
                    }
                    else
                    {
                        adm.EliminarOperacion(obj, false, ObjCajaDiaria);
                    }
                    ActualizarCobros();
                    lbl_Cobros.Text = ObjCajaDiaria.Cobros.ToString();
                    lbl_EfecFinal.Text = ObjCajaDiaria.Efec_final.ToString();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_caja_diaria_Load(object sender, EventArgs e)
        {
            try
            {
                if (oUsu.PERMISO().COBROS_y_PAGOS)
                {
                    if (!adm.CobrosYGastosCargados(ObjCajaDiaria))
                        adm.CargarGastosCobros(ObjCajaDiaria);
                    ActualizarCobros();
                    ActualizarGastos();
                }
                else
                {
                    p_gastos.Enabled = false;
                    p_cobros.Enabled = false;
                }
                Actualizarventas();
                Actuarlizarlabels();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_caja_diaria_Activated(object sender, EventArgs e)
        {
            lbl_EfecFinal.Text = ObjCajaDiaria.Efec_final.ToString();
        }

        private void dgrid_gastos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_gastos.SelectedRows.Count > 0)
            {
                btn_ModificarGasto.Enabled = true;
                btn_EliminarGasto.Enabled = true;
            }
            
         }

        private void dgrid_cobros_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_cobros.SelectedRows.Count > 0)
            {
                btn_ModificarCobro.Enabled = true;
                btn_EliminarCobro.Enabled = true;
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgrid_ventas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView dgrid = (DataGridView)sender;
                if (dgrid.SelectedRows.Count > 0)
                {
                    int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                    if (cal > e.Location.Y && e.Location.Y > 33)
                    {
                        Cventa oventa = (Cventa)dgrid_ventas.CurrentRow.DataBoundItem;
                        if (oventa.Items() == null || oventa.Items().Count == 0)
                        {
                            Ctrl_Ventas admventa = Ctrl_Ventas.ClaseActiva();
                            admventa.CargarItems(oventa, ObjCajaDiaria.ID);
                        }
                        string argumento = "Forma de pago : " + oventa.Pago.FormaPago + "\nDesc/Rec : $" + oventa.Pago.Descuento + "\nImporte : $ " + oventa.Pago.Importe;
                        if (oventa.Pago2 != null)
                            argumento = argumento + "\nForma de pago 2 : " + oventa.Pago2.FormaPago + "\nDesc/Rec : $" + oventa.Pago2.Descuento + "\nImporte : $ " + oventa.Pago2.Importe;
                        Frm_Items frmItems = new Frm_Items( argumento,oventa,ObjCajaDiaria,ObjCajaDiaria.Fecha);
                        frmItems.ShowDialog();
                        Actualizarventas(); 
                        Actuarlizarlabels();
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_caja_diaria_Shown(object sender, EventArgs e)
        {
            if (Ctrl_configuraciones.Devolver().Version < 2)
            {
                p_cobros.Enabled = false;
                p_gastos.Enabled = false;
            }
        }

        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //    e.Graphics.FillRectangle(brocha, e.ClipRectangle);
        //}

        
    }
}
