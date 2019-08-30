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
    public partial class Frm_ABM_bancos : SIVS.Frm_ABM
    {
        Cbanco obj;
        Ctrl_bancos adm = Ctrl_bancos.ClaseActiva();
        private static Frm_ABM_bancos frm;      
        
        public Frm_ABM_bancos()
        {
            InitializeComponent();
        }

        public static Frm_ABM_bancos AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_ABM_bancos();
            }
            frm.Focus();
            return frm;
        }

        private void ActualizarGrilla()
        {
            bs_bancos.ResetBindings(false);
            bs_bancos.DataSource = adm.VerLista();
            dgrid_bancos.DataSource = bs_bancos;
            dgrid_bancos.Columns[0].Visible = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (obj == null)
                {
                    obj = new Cbanco(txt_nombre.Text);
                    adm.Agregar(obj);
                }
                else 
                {
                    obj.NOMBRE = txt_nombre.Text;
                    //MODIFCAR
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

        private void Frm_ABM_bancos_Activated(object sender, EventArgs e)
        {
            dgrid_bancos.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            obj = (Cbanco)dgrid_bancos.CurrentRow.DataBoundItem;
            txt_nombre.Text = obj.NOMBRE;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                obj = (Cbanco)dgrid_bancos.CurrentRow.DataBoundItem;
                Frm_confirmacion frmconfirma = new Frm_confirmacion("¿Seguro que quiere eliminar el banco " + obj.NOMBRE + " ?", "Eliminar banco ", "No", "Si");
                frmconfirma.ShowDialog();
                if (frmconfirma.RESPUESTA == "Si")
                {
                    if (adm.EnUso(obj))
                    {
                        frmconfirma = new Frm_confirmacion("El banco seleccionado esta en uso y no se puede borrar por la \nintegridad de datos a menos q la reemplase por otro. \nQuiere reemplazarlo por otro banco?", "Eliminar banco", "Cancelar", "Reemplazar");
                        frmconfirma.ShowDialog();
                        if (frmconfirma.RESPUESTA == "Reemplazar")
                        {
                            Frm_Eleccion frmeleccion = new Frm_Eleccion("Banco reemplazante", bs_bancos);
                            frmeleccion.ShowDialog();
                            if (frmeleccion.ObjRespuesta != null)
                            {
                                Cbanco objreemplanzante = (Cbanco)frmeleccion.ObjRespuesta;
                                if (objreemplanzante != obj)
                                {
                                    adm.Reemplazar(obj, objreemplanzante);
                                    adm.Eliminar(obj);
                                    obj.ID = objreemplanzante.ID;
                                    obj.NOMBRE = objreemplanzante.NOMBRE;
                                    ActualizarGrilla();
                                }
                            }
                        }
                    }
                    else
                    {
                        adm.Eliminar(obj);
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

        private void Frm_ABM_bancos_Shown(object sender, EventArgs e)
        {
            btn_Cancelar.PerformClick();
        }

        private void Frm_ABM_bancos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                btn_Guardar_Click(sender, e);
        }

        private void dgrid_bancos_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            gb_abm.Enabled = false;
            txt_nombre.Focus();
        }

        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            Frm_ABM_bancos_Activated(sender, e);
            ActualizarGrilla();
            txt_nombre.Clear();
            obj = null;
        }
    }
}
