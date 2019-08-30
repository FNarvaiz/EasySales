using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using CLASES;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_ABM_configuraciones : SIVS.Frm_ABM
    {
        Cconfiguracion obj;
        public Frm_ABM_configuraciones(Cconfiguracion objconf)
        {
            obj = objconf;
            InitializeComponent();
        }

        

        private void cb_Comisiones_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Comisiones.Checked)
            {
                txt_porcentaje.Enabled = true;
            }
            else
            {
                txt_porcentaje.Enabled = false;
                txt_porcentaje.Text = "0";
            }
        }

        private void rb_Xventa_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Xventa.Checked)
            {
                pn_comisiones.Enabled = true;
                
            }
            else
            {
                pn_comisiones.Enabled = false;
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try{
            obj.PedirPass= cb_pedirpassword.Checked;
            obj.MultiCaja= cb_multicaja.Checked;
            obj.MultiUsuario= cb_multiusuario.Checked;
            obj.PorVenta= rb_Xventa.Checked;
            obj.PorComisiones= cb_Comisiones.Checked;
            obj.PorcComision= Convert.ToDecimal(txt_porcentaje.Text);
            obj.Facturacion = rb_habilitarImpresora.Checked;
            obj.Epson_Samsung= rb_Epson.Checked;
            obj.ExistenciaPorCompras = rb_Xcompras.Checked;
            obj.Puerto = Convert.ToInt32(txt_puerto.Text);
            obj.IVA = Convert.ToDecimal(txt_iva.Text);
            obj.NombreLogico = txt_nomLogico.Text;
            if (obj.Epson_Samsung)
                obj.Modelo = cb_ModelEpson.SelectedIndex;
            else
                obj.Modelo = cb_ModelHasar.SelectedIndex;
            if (rb_ForAdi.Checked)
            {
                obj.OrdenPrioridad = true;
                obj.DescuentoFormaPago = true;
            }
            else if (rb_AdiFor.Checked)
            {
                obj.OrdenPrioridad = true;
                obj.DescuentoFormaPago = false;
                
            }
            else if (rb_DescRec.Checked)
            {
                obj.OrdenPrioridad = false;
                obj.DescuentoFormaPago = true;
            }
            else
            {
                obj.OrdenPrioridad = false;
                obj.DescuentoFormaPago = false;
            }
            Ctrl_configuraciones.Modificar(obj);

            Close();
            }
            catch(Exception ex){
                Frm_confirmacion form= new Frm_confirmacion(ex.Message,"Datos incorrectos","Aceptar");
                form.ShowDialog();
            }
        }

        private void Frm_ABM_configuraciones_Load(object sender, EventArgs e)
        {
            if (obj.Facturacion)
            {
                rb_desabilitarImpresora.Checked = false;
                rb_habilitarImpresora.Checked = true;
            }
            else
            {
                rb_desabilitarImpresora.Checked = true;
                rb_habilitarImpresora.Checked = false;
            }
            txt_puerto.Text = obj.Puerto.ToString();
            if (obj.Epson_Samsung)
            {
                cb_ModelEpson.Text = cb_ModelEpson.Items[obj.Modelo].ToString();
                rb_Epson.Checked = true;
                rb_Hasar.Checked = false;
            }
            else
            {
                cb_ModelHasar.Text = cb_ModelHasar.Items[obj.Modelo].ToString();
                rb_Epson.Checked = false;
                rb_Hasar.Checked = true;
            }
            if (obj.PorVenta)
            {
                rb_Xcaja_diaria.Checked = false;
                rb_Xventa.Checked = true;
                cb_Comisiones.Checked = obj.PorComisiones;
                txt_porcentaje.Text = obj.PorcComision.ToString();
            }
            txt_nomLogico.Text = obj.NombreLogico;
            cb_multicaja.Checked = obj.MultiCaja;
            cb_multiusuario.Checked = obj.MultiUsuario;
            cb_pedirpassword.Checked = obj.PedirPass;
            txt_iva.Text = obj.IVA.ToString();
            if (obj.OrdenPrioridad)
            {
                if (obj.DescuentoFormaPago)
                    rb_ForAdi.Checked = true;
                else
                    rb_AdiFor.Checked = true;
            }
            else
            {
                if (obj.DescuentoFormaPago)
                        rb_DescRec.Checked = true;
                    else
                        rb_RecDesc.Checked = true;
                
            }
            if (obj.ExistenciaPorCompras)
            {
                rb_Xcompras.Checked = true;
                rb_formulario.Checked = false;
            }
            else
            {
                rb_Xcompras.Checked = false;
                rb_formulario.Checked = true;
            }
        }

        private void rb_habilitarImpresora_CheckedChanged(object sender, EventArgs e)
        {
            p_configimpr.Enabled = rb_habilitarImpresora.Checked;
        }

        private void Frm_ABM_configuraciones_Shown(object sender, EventArgs e)
        {
            if (Form1.objConf.Version < 2)
            {
                
                pn_abm.Enabled = false;
                gb_abm.Enabled = false;
                cb_multiusuario.Enabled = false;
                cb_multicaja.Enabled = false;
            }
            pn_comisiones.Enabled = false;
            
        }

        private void rb_formulario_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_formulario.Checked)
            {
                Frm_confirmacion frm = new Frm_confirmacion("ADVERTENCIA!!!\n\nSi elige modificar el stock mediante esta opción quedarán inconsistentes los datos contables de los artículos, tales como: Costos ponderados, unidades compradas, márgenes brutos, utilidades netas y costos totales.\nEsto significa que una vez modificada la existencia de un artículo no podrá volver atrás la acción.\n¿Desea seleccionar esta opción de todas maneras?\n\nSi no está seguro póngase en contacto con EasySoft Grupo Tecnológico.", "Advertencia", "No", "Si", "Contácto");
                frm.ShowDialog();
                if (frm.RESPUESTA != null)
                {
                    if (frm.RESPUESTA == "No")
                    {
                        rb_formulario.Checked = false;
                        rb_Xcompras.Checked = true;
                    }
                    else if (frm.RESPUESTA == "Contácto")
                    {
                        Process.Start("www.facebook.com/easysoftgt");
                        rb_formulario.Checked = false;
                        rb_Xcompras.Checked = true;
                    }
                }
            }
        }

        protected void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    
    }
}
