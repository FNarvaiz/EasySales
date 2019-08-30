using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASES;
using CONTROL;
namespace SIVS
{
    public partial class Frm_ABM_localidades : SIVS.Frm_ABM
    {
        Clocalidad objLocalidad;
        Ctrl_localidades adm = Ctrl_localidades.ClaseActiva();        
        private static Frm_ABM_localidades frmLocalidad;

        public static Frm_ABM_localidades AbrirForm()
        {
            if ((frmLocalidad == null) || (frmLocalidad.IsDisposed))
            {
                frmLocalidad = new Frm_ABM_localidades();
            }
            frmLocalidad.Focus();
            return frmLocalidad;
        }

        public Frm_ABM_localidades()
        {
            InitializeComponent();
            adm.actualizar = true;
        }

        private void Frm_ABM_localidades_Load(object sender, EventArgs e)
        {
            if (adm.actualizar)
            {
                adm.actualizar = false;
                ActualizarGrilla();
            }
            //this.CurrentAutoScaleDimensions = new SizeF(Width, height);
            //this.CurrentAutoScaleDimensions = new SizeF(Width, Height);
            //this.Scale(AutoScaleFactor);
            
        }

        private void ActualizarGrilla()
        {
            bs_localidades.ResetBindings(false);
            bs_localidades.DataSource =adm.VerLista();
            dgrid_localidades.DataSource = bs_localidades;
            dgrid_localidades.Columns[0].Visible = false;
        }

        private new void btn_Agregar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = false;
            txt_nombre.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            objLocalidad = (Clocalidad)dgrid_localidades.CurrentRow.DataBoundItem;
            txt_nombre.Text = objLocalidad.Nombre;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objLocalidad= (Clocalidad) dgrid_localidades.CurrentRow.DataBoundItem;
                Frm_confirmacion frmconfirma = new Frm_confirmacion("Seguro que quiere eliminar la localidad " + objLocalidad.Nombre + " ?", "Eliminar localidad ", "No", "Si");
                frmconfirma.ShowDialog();
                if (frmconfirma.RESPUESTA == "Si")
                {
                    if (adm.EnUso(objLocalidad))
                    {
                        frmconfirma = new Frm_confirmacion("La localidad esta en uso y no se puede borrar por la \nintegridad de datos a menos q la reemplase por otra. \nQuiere reemplsarla por otra localidad?", "Eliminar localidad", "Cancelar", "Reemplazar");
                        frmconfirma.ShowDialog();
                        if (frmconfirma.RESPUESTA == "Reemplazar")
                        {
                            Frm_Eleccion frmeleccion = new Frm_Eleccion("Localidad reemplazante", bs_localidades);
                            frmeleccion.ShowDialog();
                            if (frmeleccion.ObjRespuesta != null)
                            {
                                Clocalidad objreemplanzante = (Clocalidad)frmeleccion.ObjRespuesta;
                                if (objreemplanzante != objLocalidad)
                                {
                                    adm.Reemplazar(objLocalidad, objreemplanzante);
                                    adm.Eliminar(objLocalidad);
                                    objLocalidad.ID = objreemplanzante.ID;
                                    objLocalidad.Nombre = objreemplanzante.Nombre;
                                    ActualizarGrilla();
                                }
                            }
                        }
                    }
                    else
                    {
                        adm.Eliminar(objLocalidad);
                        ActualizarGrilla();
                    }
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
                if (objLocalidad == null)
                {
                    objLocalidad = new Clocalidad(txt_nombre.Text);
                    adm.Agregar(objLocalidad);
                }
                else
                {
                    objLocalidad.Nombre = txt_nombre.Text;
                    adm.Modificar(objLocalidad);
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
           
            Frm_ABM_localidades_Activated(sender, e);
            txt_nombre.Clear();
            objLocalidad = null;
        }

        private void Frm_ABM_localidades_Activated(object sender, EventArgs e)
        {
            dgrid_localidades.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void dgrid_localidades_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
                btn_Guardar_Click(sender,e);
        }

        private void Frm_ABM_localidades_Shown(object sender, EventArgs e)
        {
            btn_Cancelar.PerformClick();
        }       
                
    }
}
