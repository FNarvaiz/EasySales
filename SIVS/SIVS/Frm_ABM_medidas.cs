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
    public partial class Frm_ABM_medidas : SIVS.Frm_ABM
    {
        public Frm_ABM_medidas()
        {
            InitializeComponent();
            adm.actualizar = true;
        }

        Cmedida oMedida;
        Ctrl_medidas adm = Ctrl_medidas.ClaseActiva();
        
        private static Frm_ABM_medidas frmMedida;

        public static Frm_ABM_medidas AbrirForm()
        {
            if ((frmMedida == null) || (frmMedida.IsDisposed))
            {
                frmMedida = new Frm_ABM_medidas();
            }
            frmMedida.Focus();
            return frmMedida;
        }

        private void Frm_ABM_medidas_Load(object sender, EventArgs e)
        {
            if (adm.actualizar)
            {
                adm.actualizar = false;
                ActualizarGrilla();
                Width = 490;
            }
            
        }
        private void ActualizarGrilla()
        {
            bs_medidas.ResetBindings(false);
            bs_medidas.DataSource =adm.VerLista();
            dgrid_medidas.DataSource = bs_medidas;
            dgrid_medidas.Columns[0].Visible = false;
            //dgrid_medidas.Columns[2].Width = 100;
        }
        private new  void btn_Agregar_Click(object sender, EventArgs e)
        {
            txt_nombre.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            
            oMedida = (Cmedida)dgrid_medidas.CurrentRow.DataBoundItem;
            txt_nombre.Text = oMedida.Nombre;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                oMedida= (Cmedida) dgrid_medidas.CurrentRow.DataBoundItem;
                if (adm.EnUso(oMedida))
                {
                    Frm_confirmacion frmconfirma = new Frm_confirmacion("La medida esta en uso y no se puede borrar por la integridad de datos a menos q la reemplase por otra. \nQuiere reemplsarla por otra medida?", "Eliminar medida", "Cancelar", "Reemplazar");
                    frmconfirma.ShowDialog();
                    if (frmconfirma.RESPUESTA == "Reemplazar")
                    {
                        Frm_Eleccion frmeleccion = new Frm_Eleccion("Medida reemplazante", bs_medidas);
                        frmeleccion.ShowDialog();
                        if (frmeleccion.ObjRespuesta != null)
                        {
                            Cmedida objreemplanzante = (Cmedida)frmeleccion.ObjRespuesta;
                            if (objreemplanzante != oMedida)
                            {
                                adm.Reemplazar(oMedida, objreemplanzante);
                                adm.Eliminar(oMedida);
                                ActualizarGrilla();
                            }
                        }
                    }
                }
                else
                {
                    adm.Eliminar(oMedida);
                    ActualizarGrilla();
                }
                btn_Cancelar_Click(sender, e);
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
                if (oMedida == null)
                {
                    oMedida = new Cmedida(txt_nombre.Text,cb_entero.Checked);
                    adm.Agregar(oMedida);
                }
                else
                {
                    adm.Modificar(new Cmedida(oMedida.ID,txt_nombre.Text,oMedida.Entero), oMedida );
                }
                ActualizarGrilla();
                btn_Cancelar_Click(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_medidas_Activated(sender, e);
            txt_nombre.Clear();
            oMedida = null;
        }

        private void Frm_ABM_medidas_Activated(object sender, EventArgs e)
        {
            dgrid_medidas.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void dgrid_medidas_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void Frm_ABM_medidas_Shown(object sender, EventArgs e)
        {
            btn_Cancelar.PerformClick();
        }


    }
}
