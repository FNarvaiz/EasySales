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
    public partial class Frm_ABM_clientes : SIVS.Frm_ABM
    {
        Ccliente objCliente;
        Ctrl_clientes admClientes = Ctrl_clientes.ClaseActiva();
        Ctrl_localidades admLocalidades = Ctrl_localidades.ClaseActiva();
        Ctrl_cuentas_corrientes admCuentas = Ctrl_cuentas_corrientes.ClaseActiva();
        private static Frm_ABM_clientes frmCliente;

        public static Frm_ABM_clientes AbrirForm()
        {
            if ((frmCliente == null) || (frmCliente.IsDisposed))
            {
                frmCliente = new Frm_ABM_clientes();
            }
            frmCliente.Focus();
            return frmCliente;
        }
        public Frm_ABM_clientes()
        {
            InitializeComponent();
        }
        private void Frm_ABM_clientes_Load(object sender, EventArgs e)
        {
                ActualizarGrilla();
                admLocalidades.actualizar = true;
        }
        private void ActualizarGrilla()
        {
            bs_clientes.ResetBindings(true);
            bs_clientes.DataSource = admClientes.VerLista();
            dgrid_clientes.DataSource = bs_clientes;
            dgrid_clientes.Columns[0].Visible = false;
            dgrid_clientes.Columns[1].Visible = false;
            dgrid_clientes.Columns[8].Visible = false;
        }

        private new void btn_Agregar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = false;
            txt_nombre.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar_Click(sender, e);
            objCliente = (Ccliente)dgrid_clientes.CurrentRow.DataBoundItem;
            txt_nombre.Text = objCliente.Nombre;
            txt_direccion.Text = objCliente.Domicilio;
            txt_mail.Text = objCliente.Email;
            txt_cel.Text = objCliente.Cel;
            txt_tel.Text = objCliente.Tel;
            cb_localidades.Text = objCliente.Localidad;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objCliente = (Ccliente)dgrid_clientes.CurrentRow.DataBoundItem;
                if (admCuentas.TieneCreditosODebitos(objCliente.DevolverCuentaCorriente()))
                {
                    Frm_confirmacion frm = new Frm_confirmacion("El cliente tiene creditos o debitos cargados,y no se puede borrar por la integridad de datos.\n Quiere darle de baja?", "Registros del cliente", "No", "Si");
                    frm.ShowDialog();
                    if (frm.RESPUESTA == "Si")
                    {
                        admClientes.DarBaja(objCliente);
                        ActualizarGrilla();
                        Frm_cuenta_corriente form = Frm_ABM_cuentas_corrientes.CuentaAbierta(objCliente);
                        if (form != null)
                            form.Close();
                        Frm_ABM_clientes_Activated(sender, e);
                    }
                }
                else
                {
                    Frm_confirmacion frm = new Frm_confirmacion("Esta seguro que quiere eliminar el registro de "+objCliente.Nombre+" ?", "Eliminación del cliente", "No", "Si");
                    frm.ShowDialog();
                    if (frm.RESPUESTA == "Si")
                    {
                        admClientes.Eliminar(objCliente);
                        ActualizarGrilla();
                        Frm_cuenta_corriente form = Frm_ABM_cuentas_corrientes.CuentaAbierta(objCliente);
                        if (form != null)
                            form.Close();
                        Frm_ABM_clientes_Activated(sender, e);
                    }
                }
                objCliente = null;
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Guardar()
        {
            if (objCliente == null)
            {
                Clocalidad objLoca = (Clocalidad)cb_localidades.SelectedItem;
                objCliente = new Ccliente(txt_nombre.Text, txt_direccion.Text, txt_tel.Text, txt_cel.Text, txt_mail.Text, objLoca);
                admClientes.Agregar(objCliente, true);
            }
            else
            {
                objCliente.Nombre = txt_nombre.Text;
                objCliente.Cel = txt_cel.Text;
                objCliente.Domicilio = txt_direccion.Text;
                objCliente.Tel = txt_tel.Text;
                objCliente.LOCALIDAD((Clocalidad)cb_localidades.SelectedItem);
                objCliente.Email = txt_mail.Text;
                admClientes.Modificar(objCliente);
            }
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                ActualizarGrilla();
                btn_Cancelar.PerformClick();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_GuardarMas_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                ActualizarGrilla();
                Frm_ABM_clientes_Activated(sender, e);
                txt_cel.Clear();
                txt_direccion.Clear();
                txt_mail.Clear();
                txt_tel.Clear();
                txt_nombre.Clear();
                objCliente = null;
                txt_nombre.Focus();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = true;
            Frm_ABM_clientes_Activated(sender, e);
            txt_cel.Clear();
            txt_direccion.Clear();
            txt_mail.Clear();
            txt_tel.Clear();
            txt_nombre.Clear();
            objCliente = null;
        }


        private void dgrid_clientes_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void Frm_ABM_clientes_Activated(object sender, EventArgs e)
        {

            if (admLocalidades.actualizar)
            {
                bs_localidades.ResetBindings(true);
                bs_localidades.DataSource = admLocalidades.VerLista();
                cb_localidades.DataSource = bs_localidades;
                cb_localidades.DisplayMember = "Nombre";
                admLocalidades.actualizar = false;
                ActualizarGrilla();
            }
            dgrid_clientes.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }
        private void lbl_localidad_Click(object sender, EventArgs e)
        {
            Frm_ABM_localidades frm = Frm_ABM_localidades.AbrirForm();
            frm.Show();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            if (txt_busqueda.Text == "")
            {
                ActualizarGrilla();
            }
            else
            {
                bs_clientes.ResetBindings(false);
                bs_clientes.DataSource = admClientes.BuscarPorNombre(txt_busqueda.Text);
                dgrid_clientes.DataSource = bs_clientes;
            }
        }

        private void btn_VerBajas_Click(object sender, EventArgs e)
        {
            admClientes.CargarBajas();
            BindingSource bs = new BindingSource();
            bs.DataSource = admClientes.VerBajas();
            if (bs.Count > 0)
            {
                List<int> columnasAocultar = new List<int>();
                for (int cont = 0; cont < 9; cont++)
                    columnasAocultar.Add(cont);
                columnasAocultar.Remove(2);
                Frm_Eleccion frm = new Frm_Eleccion("Usuarios dados de bajas", "el usuario", bs, columnasAocultar,"Doble click para dar de alta.");
                frm.ShowDialog();
                if (frm.ObjRespuesta != null)
                {
                    admClientes.DarAlta((Ccliente)frm.ObjRespuesta);
                    ActualizarGrilla();
                }
            }
            else
            {
                Frm_confirmacion frm = new Frm_confirmacion("No hay clientes dados de bajas!", "Bajas de clientes", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void dgrid_clientes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView dgrid = (DataGridView)sender;
                if (dgrid.SelectedRows.Count > 0)
                {
                    int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                    if (cal > e.Location.Y && e.Location.Y > 33)
                    {
                        Cpersona obj= (Cpersona) dgrid.CurrentRow.DataBoundItem;
                        Frm_confirmacion frm = new Frm_confirmacion("Nombre : "+obj.Nombre+"\nTel : "+obj.Tel+"\nCel : "+obj.Cel+"\nDirección : "+ obj.Domicilio+"\nLocadidad : "+obj.Localidad, "Datos del cliente", "Aceptar");
                        frm.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Reportes.R_Clientes frm = new Reportes.R_Clientes(true);
            frm.Show();
        }

        private void Frm_ABM_clientes_Shown(object sender, EventArgs e)
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
            else
            {
                btn_Cancelar.PerformClick();
            }
        }

        private void dgrid_clientes_Resize(object sender, EventArgs e)
        {
            if (dgrid_clientes.Width > dgrid_clientes.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed))
                dgrid_clientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            else
                dgrid_clientes.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private  void Frm_ABM_clientes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 114 && e.KeyValue < 117)
            {

                if (115 == e.KeyValue)//F5   REPORTE
                {
                    if (pn_btnABM.Visible && btn_Reporte.Enabled && btn_Reporte.Visible)
                        btn_Reporte.PerformClick();
                }
                else if (116 == e.KeyValue)//F6   GUARDAR MAS
                {

                    if (pn_btnDerechos.Visible && btn_GuardarMas.Enabled && btn_GuardarMas.Visible)
                        btn_GuardarMas.PerformClick();
                }
            }
        }

        
        
    }
}
