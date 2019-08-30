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
    public partial class Frm_ABM_cajas : SIVS.Frm_ABM
    {
        Ccaja objCaja;
        Ctrl_cajas adm = new Ctrl_cajas();

        private static Frm_ABM_cajas frmCaja;

        public static Frm_ABM_cajas AbrirForm()
        {
            if ((frmCaja == null) || (frmCaja.IsDisposed))
            {
                frmCaja = new Frm_ABM_cajas();
            }
            frmCaja.Show();
            return frmCaja;
        }
        public Frm_ABM_cajas()
        {
            InitializeComponent();
        }
        private void Frm_ABM_cajas_Load(object sender, EventArgs e)
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
            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            bs_cajas.ResetBindings(true);
            bs_cajas.DataSource = adm.VerLista();
            dgrid_Cajas.DataSource = bs_cajas;
        }
        private new void btn_Agregar_Click(object sender, EventArgs e)
        {
            txt_numero.Focus();
            
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            objCaja = (Ccaja)dgrid_Cajas.CurrentRow.DataBoundItem;
            txt_numero.Text = objCaja.Numero.ToString();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objCaja = (Ccaja)dgrid_Cajas.CurrentRow.DataBoundItem;
                if (adm.TieneReferencias(objCaja))
                {
                    Frm_confirmacion frmconfirma = new Frm_confirmacion("La caja esta en uso en muchos registros. No se puede borrar \npor la integridad de los datos. ", "Referencia en datos", "Aceptar");
                    frmconfirma.ShowDialog();
                }
                else
                {
                    adm.Eliminar(objCaja);
                    ActualizarGrilla();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objCaja == null)
                {
                    objCaja = new Ccaja(Convert.ToInt32(txt_numero.Text));
                    if(adm.Existe(objCaja))
                        throw new Exception("El numero de caja ya exite.\nPor favor ingrese un numero de caja distinto.");
                    adm.Agregar(objCaja);
                }
                else
                {
                    Ccaja obj= new Ccaja( Convert.ToInt32(txt_numero.Text));
                    if (adm.Existe(obj))
                        throw new Exception("El numero de caja ya exite.\nPor favor ingrese un numero de caja distinto.");
                    adm.Modificar(objCaja,obj);
                }
                ActualizarGrilla();
                btn_Cancelar.PerformClick();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private  new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_cajas_Activated(sender, e);
            txt_numero.Clear();
            objCaja = null;
        }
        private void Frm_ABM_cajas_Activated(object sender, EventArgs e)
        {
            dgrid_Cajas.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }
        private void dgrid_Cajas_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

    }
}
