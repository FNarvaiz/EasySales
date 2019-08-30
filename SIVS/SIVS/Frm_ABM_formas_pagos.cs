using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using CLASES;

namespace SIVS
{
    public partial class Frm_ABM_formas_pagos : SIVS.Frm_ABM
    {
        static public Frm_ABM_formas_pagos frm;
        Ctrl_formas_pagos adm = Ctrl_formas_pagos.ClaseActiva();
        Cforma_pago objFormapago;

        public static Frm_ABM_formas_pagos AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_ABM_formas_pagos();
            }
            frm.Focus();
            return frm;
        }
        
        public Frm_ABM_formas_pagos()
        {
            InitializeComponent();
        }

        private void Frm_ABM_formas_pagos_Load(object sender, EventArgs e)
        {
         
                ActualizarGrilla();
                //dgrid_FPagos.DataSource = adm.VerLista();
            
         

        }
        private void ActualizarGrilla()
        {
            bs_pagos.ResetBindings(true);
            bs_pagos.DataSource = adm.VerLista();
            dgrid_FPagos.DataSource = bs_pagos;
            dgrid_FPagos.Columns[0].Visible = false;
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objFormapago == null)
                {
                    adm.Agregar(new Cforma_pago(txt_Descripcion.Text, rb_descuento.Checked, rb_Recargo.Checked, cb_AlteraCaja.Checked, Convert.ToDecimal(txt_Porcentaje.Text),cb_autorizacion.Checked));
                }
                else
                {
                    objFormapago.Descripcion = txt_Descripcion.Text;
                    objFormapago.Porcentaje = Convert.ToDecimal(txt_Porcentaje.Text);
                    objFormapago.Descuento = rb_descuento.Checked;
                    objFormapago.Recargo = rb_Recargo.Checked;
                    objFormapago.Altera_caja = cb_AlteraCaja.Checked;
                    objFormapago.Autorizacion = cb_autorizacion.Checked;
                    adm.Modificar(objFormapago);
                    
                }
                ActualizarGrilla();
                //dgrid_FPagos.DataSource = adm.VerLista();
                //dgrid_FPagos.Refresh();
                btn_Cancelar.PerformClick();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgrid_FPagos_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void Frm_ABM_formas_pagos_Activated(object sender, EventArgs e)
        {
            dgrid_FPagos.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private new void btn_Agregar_Click(object sender, EventArgs e)
        {
            txt_Descripcion.Focus();
            
        }

        private new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_formas_pagos_Activated(sender, e);
            txt_Descripcion.Clear();
            txt_Porcentaje.Clear();
            txt_Descripcion.Enabled = true;
            objFormapago = null;
            
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            objFormapago= (Cforma_pago)dgrid_FPagos.CurrentRow.DataBoundItem;
            if (objFormapago.ID == 1 || objFormapago.ID == 2)
                txt_Descripcion.Enabled=false;
            txt_Descripcion.Text= objFormapago.Descripcion;
            txt_Porcentaje.Text= objFormapago.Porcentaje.ToString();
            cb_AlteraCaja.Checked= objFormapago.Altera_caja;
            rb_descuento.Checked= objFormapago.Descuento;
            rb_Recargo.Checked = objFormapago.Recargo;
            cb_autorizacion.Checked = objFormapago.Autorizacion;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objFormapago = (Cforma_pago)dgrid_FPagos.CurrentRow.DataBoundItem;
                if (adm.EnUso(objFormapago))
                {
                    Frm_confirmacion frm = new Frm_confirmacion("La forma de pago esta en ventas,compras,gastos o cobros. No se puede borrar por la integridad de estos datos.", "Referencias de la forma de pago", "Aceptar");
                    frm.ShowDialog();
                    //Frm_confirmacion frm = new Frm_confirmacion("La forma de pago esta en ventas,compras,gastos o cobros. \nQuiere borrar todos estos en los que se encuentra? \nQuiere reemplasar la forma de pago por otra en todos estos?", "Confirmacion", "Cancelar", "Reemplazar", "Borrar");
                    //frm.ShowDialog();
                    //DialogResult resultado = new DialogResult();
                    //resultado = (MessageBox.Show("La forma de pago esta en ventas,compras,gastos o cobros, quiere borrar todos estos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
                    //if (resultado == DialogResult.Yes)
                    //    if(frm.RESPUESTA=="Borrar")
                    //    {
                    //        Cdatos_cilindros.EliminarCilindro(ocili);
                    //        Frm_ABM_Cilindros_Activated(sender, e);
                    //    }
                    //    else if(frm.RESPUESTA=="Reemplasar"){
                    //        frm = new Frm_confirmacion("Elija la fomra de pago por la q quiere reemplazarlo","Reemplazar",
                    //        adm.CambiarReferenciasDe(
                    //    }
                    //}
                }
                else
                {
                    adm.Eliminar(objFormapago);
                    ActualizarGrilla();
                }
                btn_Cancelar.PerformClick();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void rb_Recargo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Recargo.Checked)
            {
                rb_descuento.Checked = false;
                txt_Porcentaje.Enabled = true;
            }
            else
            {
                if (!rb_descuento.Checked)
                {
                    txt_Porcentaje.Enabled = false;
                    txt_Porcentaje.Text = "0";
                }
            }

        }

        private void rb_descuento_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_descuento.Checked)
            {
                rb_Recargo.Checked = false;
                txt_Porcentaje.Enabled = true;
            }
            else
            {
                if (!rb_Recargo.Checked)
                {
                    txt_Porcentaje.Enabled = false;
                    txt_Porcentaje.Text = "0";
                }
            }
        }

        private void txt_Porcentaje_TextChanged(object sender, EventArgs e)
        {
            if(Convert.ToDecimal(txt_Porcentaje.Text)>=100)
                txt_Porcentaje.Text="99,99";
           
        }

        private void Frm_ABM_formas_pagos_Shown(object sender, EventArgs e)
        {
            btn_Cancelar.PerformClick();
        }
    }
}
