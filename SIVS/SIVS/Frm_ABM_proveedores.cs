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
    public partial class Frm_ABM_proveedores : SIVS.Frm_ABM
    {
        Ctrl_localidades admLocalidades = Ctrl_localidades.ClaseActiva();
        Ctrl_proveedores admProveedores = Ctrl_proveedores.ClaseActiva();
        Ctrl_cuentas_corrientes admCuentas = Ctrl_cuentas_corrientes.ClaseActiva();
        Cproveedor objProveedor;
        private static Frm_ABM_proveedores frmProveedor;

        public static Frm_ABM_proveedores AbrirForm()
        {
            if ((frmProveedor == null) || (frmProveedor.IsDisposed))
            {
                frmProveedor = new Frm_ABM_proveedores();
            }
            frmProveedor.Focus();
            return frmProveedor;
        }
        public Frm_ABM_proveedores()
        {
            InitializeComponent();
        }
        private void Frm_ABM_proveedores_Load(object sender, EventArgs e)
        {
            
                ActualizarGrilla();
                admLocalidades.actualizar = true;
                Width = 502;
        }
        private void ActualizarGrilla()
        {
            bs_proveedores.ResetBindings(true);
            bs_proveedores.DataSource = admProveedores.VerLista();
            dgrid_proveedores.DataSource = bs_proveedores;
            dgrid_proveedores.Columns[0].Visible = false;
            dgrid_proveedores.Columns[2].Visible = false;
            dgrid_proveedores.Columns[9].Visible = false;
        }
        private void Guardar()
        {
            if (objProveedor == null)
            {
                Clocalidad objLoca = (Clocalidad)cb_localidades.SelectedItem;
                objProveedor = new Cproveedor(txt_nombre.Text, txt_direccion.Text, txt_tel.Text, txt_cel.Text, txt_mail.Text, txt_cuit.Text, objLoca);
                admProveedores.Agregar(objProveedor, true);
            }
            else
            {
                objProveedor.Nombre = txt_nombre.Text;
                objProveedor.Cel = txt_cel.Text;
                objProveedor.Domicilio = txt_direccion.Text;
                objProveedor.Tel = txt_tel.Text;
                objProveedor.LOCALIDAD((Clocalidad)cb_localidades.SelectedItem);
                objProveedor.Email = txt_mail.Text;
                objProveedor.CUIT = txt_cuit.Text;
                admProveedores.Modificar(objProveedor);
            }
        }
        private new  void btn_Agregar_Click(object sender, EventArgs e)
        {
            txt_nombre.Focus();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            objProveedor = (Cproveedor)dgrid_proveedores.CurrentRow.DataBoundItem;
            txt_nombre.Text = objProveedor.Nombre;
            txt_direccion.Text = objProveedor.Domicilio;
            txt_mail.Text = objProveedor.Email;
            txt_cel.Text = objProveedor.Cel;
            txt_tel.Text = objProveedor.Tel;
            cb_localidades.Text = objProveedor.Localidad;
            txt_cuit.Text = objProveedor.CUIT;
            lbl_añadirCtaBancaria.Visible = true;
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objProveedor = (Cproveedor)dgrid_proveedores.CurrentRow.DataBoundItem;
                if (admCuentas.TieneCreditosODebitos(objProveedor.DevolverCuentaCorriente()))
                {
                    Frm_confirmacion frm = new Frm_confirmacion("El proveedor tiene creditos o debitos cargados,y no se puede borrar por la integridad de datos.\n Quiere darle de baja?", "Registros del proveedor", "No", "Si");
                    frm.ShowDialog();
                    if (frm.RESPUESTA == "Si")
                    {
                        admProveedores.DarBaja(objProveedor);
                        ActualizarGrilla();
                        Frm_cuenta_corriente form = Frm_ABM_cuentas_corrientes.CuentaAbierta(objProveedor);
                        if (form != null)
                            form.Close();
                        Frm_ABM_proveedores_Activated(sender, e);
                    }
                }
                else
                {
                    admProveedores.Eliminar(objProveedor);
                    ActualizarGrilla();
                    Frm_cuenta_corriente form = Frm_ABM_cuentas_corrientes.CuentaAbierta(objProveedor);
                    if (form != null)
                        form.Close();
                    Frm_ABM_proveedores_Activated(sender, e);
                }
                objProveedor = null;
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
                lbl_añadirCtaBancaria.Visible = false;
                Guardar();
                ActualizarGrilla();
                btn_Cancelar_Click(sender, e);
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
                Frm_ABM_proveedores_Activated(sender, e);
                txt_cel.Clear();
                txt_direccion.Clear();
                txt_mail.Clear();
                txt_tel.Clear();
                txt_nombre.Clear();
                txt_cuit.Clear();
                objProveedor = null;
                lbl_añadirCtaBancaria.Visible = false;
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
            Frm_ABM_proveedores_Activated(sender, e);
            txt_cel.Clear();
            txt_direccion.Clear();
            txt_mail.Clear();
            txt_tel.Clear();
            txt_nombre.Clear();
            txt_cuit.Clear();
            lbl_añadirCtaBancaria.Visible = false;
            objProveedor = null;
        }
        private void dgrid_proveedores_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            btn_CuentasBancarias.Enabled = true;

        }
        private void Frm_ABM_proveedores_Activated(object sender, EventArgs e)
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
            dgrid_proveedores.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_CuentasBancarias.Enabled = false;
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
                bs_proveedores.ResetBindings(false);
                bs_proveedores.DataSource = admProveedores.BuscarPorNombre(txt_busqueda.Text);
                dgrid_proveedores.DataSource = bs_proveedores;
            }
        }
        private void btn_VerBajas_Click(object sender, EventArgs e)
        {
            admProveedores.CargarBajas();
            BindingSource bs= new BindingSource();
            bs.DataSource = admProveedores.VerBajas();
            if (bs.Count > 0)
            {
                List<int> columnasAocultar = new List<int>();
                for (int cont = 0; cont < 10; cont++)
                    columnasAocultar.Add(cont);
                columnasAocultar.Remove(3);
                Frm_Eleccion frm = new Frm_Eleccion("Proveedores dados de bajas", "el proveedor", bs, columnasAocultar,"Doble click para dar de alta");
                frm.ShowDialog();
                if (frm.ObjRespuesta != null)
                {
                    admProveedores.DarAlta(((Cproveedor)frm.ObjRespuesta));
                    ActualizarGrilla();
                }
            }
            else
            {
                Frm_confirmacion frm = new Frm_confirmacion("No hay proveedores dados de bajas!", "Bajas de proveedores", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void dgrid_proveedores_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView dgrid = (DataGridView)sender;
                if (dgrid.SelectedRows.Count > 0)
                {
                    int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                    if (cal > e.Location.Y && e.Location.Y > 33)
                    {
                        Cproveedor obj = (Cproveedor)dgrid.CurrentRow.DataBoundItem;
                        Frm_confirmacion frm = new Frm_confirmacion("Nombre : " + obj.Nombre + "\nCUIT : "+obj.CUIT+ "\nTel : " + obj.Tel + "\nCel : " + obj.Cel + "\nDirección : " + obj.Domicilio + "\nLocadidad : " + obj.Localidad, "Datos del proveedor", "Aceptar");
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
            Reportes.R_Proveedores frm = new Reportes.R_Proveedores(true);
            frm.Show();
        }

        private void gb_abm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_ABM_proveedores_Shown(object sender, EventArgs e)
        {
            btn_Cancelar.PerformClick();
        }

        private void dgrid_proveedores_Resize(object sender, EventArgs e)
        {
            if (dgrid_proveedores.Width > dgrid_proveedores.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed))
                dgrid_proveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            else
                dgrid_proveedores.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void Frm_ABM_proveedores_KeyDown(object sender, KeyEventArgs e)
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

        private void lbl_añadirCtaBancaria_Click(object sender, EventArgs e)
        {
            Frm_ABM_cuentas_bancarias frm = Frm_ABM_cuentas_bancarias.AbrirForm(objProveedor);
            frm.Show();
            //Frm_confirmacion frm = new Frm_confirmacion("Esta función aún no se encuentra disponible. Disculpe las molestias, estamos trabajando para mejorar Easysales Market.", "Función no disponible", "Aceptar");
            //frm.ShowDialog();
        }

        private void btn_CuentasBancarias_Click(object sender, EventArgs e)
        {
            Frm_ABM_cuentas_bancarias frm = Frm_ABM_cuentas_bancarias.AbrirForm((Cproveedor)dgrid_proveedores.CurrentRow.DataBoundItem);
            frm.Show();
        }

    }
}
