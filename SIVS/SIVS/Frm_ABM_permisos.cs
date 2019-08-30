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
    public partial class Frm_ABM_permisos : SIVS.Frm_ABM
    {
       
        Cpermiso objPermiso;
        Ctrl_permisos adm = Ctrl_permisos.ClaseActiva();
        static public Frm_ABM_permisos frm;
        bool controlado=false;
        bool SelectedChangeActivado = false;
        public static Frm_ABM_permisos AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_ABM_permisos();
            }
            frm.Focus();
            return frm;
        }

        public Frm_ABM_permisos()
        {
            adm.actualizar = true;
            InitializeComponent();
        }

        private void Frm_ABM_permisos_Load(object sender, EventArgs e)
        {
            if (adm.actualizar)
            {
                ActualizarGrilla();
                adm.actualizar = false;
            }
        }
        private void ActualizarGrilla()
        {
            bs_permisos.ResetBindings(true);
            bs_permisos.DataSource = adm.VerLista();
            dgrid_permisos.DataSource = bs_permisos;
            dgrid_permisos.Columns[0].Visible = false;
            dgrid_permisos.Columns[1].HeaderText = "Rol";
            dgrid_permisos.Columns[2].Visible = false;
            dgrid_permisos.Columns[3].Visible = false;
            dgrid_permisos.Columns[4].Visible = false;
            dgrid_permisos.Columns[5].Visible = false;
            dgrid_permisos.Columns[6].Visible = false;
            dgrid_permisos.Columns[7].Visible = false;
            dgrid_permisos.Columns[8].Visible = false;
            dgrid_permisos.Columns[9].Visible = false;
            dgrid_permisos.Columns[10].Visible = false;
            dgrid_permisos.Columns[11].Visible = false;
        }
        protected override void btn_Agregar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = false;
            pn_btnABM.Visible = false;
            pn_btnDerechos.Visible = true;
            txt_nombre.Enabled = true;
            txt_nombre.Clear();
            txt_nombre.Focus();
            objPermiso = null;
            
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = false;
            pn_btnABM.Visible = false;
            pn_btnDerechos.Visible = true;
            txt_nombre.Enabled = true;
            txt_nombre.Focus();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objPermiso = (Cpermiso)dgrid_permisos.CurrentRow.DataBoundItem;
                if (adm.EnUso(objPermiso))
                {
                    throw new Exception("El permiso esta en uso y no se puede borrar por la integridad de datos");
                }
                else
                {
                    adm.Eliminar(objPermiso);
                    ActualizarGrilla();
                    btn_Cancelar_Click(sender, e);
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
                if (objPermiso == null)
                {
                    objPermiso = new Cpermiso(txt_nombre.Text, cb_admUsuarios.Checked, cb_admUsuarios.Checked, cb_cobrosypagos.Checked, cb_admFormasPagos.Checked, cb_estadisticasytablero.Checked, cb_admClientes.Checked, cb_compras.Checked, cb_admArticulos.Checked, cb_admConfiguracion.Checked, cb_admCtasCtes.Checked);
                    adm.Agregar(objPermiso);
                }
                else
                {
                    objPermiso.Descripcion = txt_nombre.Text;
                    objPermiso.USUARIOS_Y_PERMISOS = cb_admUsuarios.Checked;                    
                    objPermiso.COBROS_y_PAGOS= cb_cobrosypagos.Checked;
                    objPermiso.FORMAS_DE_PAGO=cb_admFormasPagos.Checked;
                    objPermiso.ESTADISTICAS_Y_TABLERO_CONTROL = cb_estadisticasytablero.Checked;
                    objPermiso.CLIENTES=cb_admClientes.Checked;
                    objPermiso.COMPRAS=cb_compras.Checked;
                    objPermiso.ARTICULOS=cb_admArticulos.Checked;
                    objPermiso.CONFIGURACIONES=cb_admConfiguracion.Checked;
                    objPermiso.CTAS_CTES = cb_admCtasCtes.Checked;
                    objPermiso.PROVEEDORES = cb_admProveedores.Checked;
                    adm.Modificar(objPermiso);
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

        protected override void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = true;
            pn_btnDerechos.Visible = false;
            pn_btnABM.Visible = true;
        }

        private void dgrid_permisos_SelectionChanged(object sender, EventArgs e)
        {
            if (SelectedChangeActivado)
            {
                btn_Eliminar.Enabled = true;
                btn_Modificar.Enabled = true;
                txt_nombre.Enabled = true;
                objPermiso = (Cpermiso)dgrid_permisos.CurrentRow.DataBoundItem;
                txt_nombre.Text = objPermiso.Descripcion;
                cb_admUsuarios.Checked = objPermiso.USUARIOS_Y_PERMISOS;
                cb_cobrosypagos.Checked = objPermiso.COBROS_y_PAGOS;
                cb_admFormasPagos.Checked = objPermiso.FORMAS_DE_PAGO;
                cb_estadisticasytablero.Checked = objPermiso.ESTADISTICAS_Y_TABLERO_CONTROL;
                cb_admClientes.Checked = objPermiso.CLIENTES;
                cb_compras.Checked = objPermiso.COMPRAS;
                cb_admArticulos.Checked = objPermiso.ARTICULOS;
                cb_admConfiguracion.Checked = objPermiso.CONFIGURACIONES;
                cb_admCtasCtes.Checked = objPermiso.CTAS_CTES;
                cb_admProveedores.Checked = objPermiso.PROVEEDORES;
                txt_nombre.Enabled = false;
            }
        }

        private void Frm_ABM_permisos_Activated(object sender, EventArgs e)
        {
            dgrid_permisos.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }

        private void cb_todos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CheckBox CB = (CheckBox)sender;
                if (txt_nombre.Enabled)
                {
                    if (CB.Checked)
                    {
                        CB.ForeColor = Color.PaleGreen;
                        if (CB.Tag.ToString() == "1")
                        {
                            foreach (Control aux in pn_abm.Controls)
                            {
                                if (aux.Tag.ToString() == "2")
                                {
                                    CheckBox c = (CheckBox)aux;
                                    c.Checked = true;
                                }
                            }
                        }
                    }
                    else
                    {
                        CB.ForeColor = Color.WhiteSmoke;
                        if (CB.Tag.ToString() == "1")
                        {
                            foreach (Control aux in pn_abm.Controls)
                            {
                                if (aux.Tag.ToString() == "2")
                                {
                                    CheckBox c = (CheckBox)aux;
                                    c.Checked = false;
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (controlado)
                        controlado = false;
                    else
                    {
                        controlado = true;
                        CB.Checked = !CB.Checked;
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_ABM_permisos_Shown(object sender, EventArgs e)
        {
            SelectedChangeActivado = true;
            btn_Cancelar.PerformClick();
        }


    }
}
