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
    public partial class Frm_ABM_rubros : SIVS.Frm_ABM
    {
        public Frm_ABM_rubros()
        {
            InitializeComponent();
            adm.actualizar = true;
        }

        Crubro objRubro;
        Ctrl_rubros adm = Ctrl_rubros.ClaseActiva();
        
        private static Frm_ABM_rubros frmRubro;

        public static Frm_ABM_rubros AbrirForm()
        {
            if ((frmRubro == null) || (frmRubro.IsDisposed))
            {
                frmRubro = new Frm_ABM_rubros();
            }
            frmRubro.Focus();
            return frmRubro;
        }

        private void Frm_ABM_rubros_Load(object sender, EventArgs e)
        {
            if (adm.actualizar)
            {
                adm.actualizar = false;
                ActualizarGrilla();
            }
            
        }
        private void ActualizarGrilla()
        {
            bs_rubros.ResetBindings(false);
            bs_rubros.DataSource =adm.VerLista();
            dgrid_rubros.DataSource = bs_rubros;
            dgrid_rubros.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgrid_rubros.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private new void btn_Agregar_Click(object sender, EventArgs e)
        {
           
            txt_numero.Enabled = true;
            txt_nombre.Focus();
            txt_numero.Text = (adm.VerLista()[0].Nro + 1).ToString();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar_Click(sender, e);
            objRubro = (Crubro)dgrid_rubros.CurrentRow.DataBoundItem;
            txt_nombre.Text = objRubro.Nombre;
            txt_numero.Text = objRubro.Nro.ToString();
            txt_numero.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objRubro= (Crubro) dgrid_rubros.CurrentRow.DataBoundItem;
                if (adm.EnUso(objRubro))
                {
                    Frm_confirmacion frmconfirma = new Frm_confirmacion("El rubro esta en uso y no se puede borrar por la \nintegridad de datos a menos q la reemplase por otra. \nQuiere reemplsarla por otro rubro?", "Eliminar rubro", "Cancelar", "Reemplazar");
                    frmconfirma.ShowDialog();
                    if (frmconfirma.RESPUESTA == "Reemplazar")
                    {
                        Frm_Eleccion frmeleccion = new Frm_Eleccion("Rubro reemplazante", bs_rubros);
                        frmeleccion.ShowDialog();
                        if (frmeleccion.ObjRespuesta != null)
                        {
                            Crubro objreemplanzante = (Crubro)frmeleccion.ObjRespuesta;
                            if (objreemplanzante != objRubro)
                            {
                                adm.Reemplazar(objRubro, objreemplanzante);
                                adm.Eliminar(objRubro);
                                ActualizarGrilla();
                            }
                        }
                    }
                }
                else
                {
                    adm.Eliminar(objRubro);
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objRubro == null)
                {
                    objRubro = new Crubro(txt_numero.Text, txt_nombre.Text);
                    if (adm.BuscarPorID(objRubro.Nro) != null)
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("El número de rubro ya existe, no puede estar duplicado.", "Número de rubro existente", "Aceptar");
                        frm.ShowDialog();
                        objRubro = null;
                    }
                    else
                        adm.Agregar(objRubro);
                }
                else
                {
                    adm.Modificar(new Crubro(txt_numero.Text, txt_nombre.Text), objRubro);
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

        private new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_rubros_Activated(sender, e);
            txt_nombre.Clear();
            txt_numero.Clear();
            objRubro = null;
        }

        private void Frm_ABM_rubros_Activated(object sender, EventArgs e)
        {
            dgrid_rubros.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void dgrid_rubros_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void txt_cantAlta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                btn_Guardar_Click(sender, e);
        }

        private void Frm_ABM_rubros_Shown(object sender, EventArgs e)
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
                Dispose(true);
                Close();
            }
            else
            {
                btn_Cancelar.PerformClick();
            }
        }

    }
}
