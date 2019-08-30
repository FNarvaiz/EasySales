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
    public partial class Frm_ABM_usuarios : SIVS.Frm_ABM
    {
        Cusuario objUsuario;
        Ctrl_usuarios admUsuarios = Ctrl_usuarios.ClaseActiva();
        Ctrl_permisos admPermisos = Ctrl_permisos.ClaseActiva();
        Ctrl_localidades admLocalidades= Ctrl_localidades.ClaseActiva();
        bool primeravez=false;
        Cusuario UsuarioActivo;
        static public Frm_ABM_usuarios frm;

        public static Frm_ABM_usuarios AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_ABM_usuarios();
            }
            frm.UsuarioActivo = Form1.objusu;
            frm.Focus();
            return frm;
        }

        public Cusuario OBJUSUARIO
        {
            get
            {
                return objUsuario;
            }
        }
        public Frm_ABM_usuarios()
        {
            InitializeComponent();
        }
        public Frm_ABM_usuarios(bool primeraves)
        {
            InitializeComponent();
            primeravez = primeraves;
        }
        

        private void Frm_ABM_usuarios_Load(object sender, EventArgs e)
        {
            if (primeravez)
            {
                pbtn.Height = 45;
                gb_abm.Visible = false;
                pn_abm.Location= gb_abm.Location;
                p_contraseña.Location = new Point(gb_abm.Location.X, p_contraseña.Location.Y);
                Width = pn_abm.Width+10;
                btn_Agregar.Visible = false;
                btn_Eliminar.Visible = false;
                btn_Modificar.Visible = false;
                btn_VerBajas.Visible = false;
                btn_Reporte.Visible = false;
                btn_Salir.Visible = false;
                btn_Guardar.Location = btn_Modificar.Location;
                txt_nombre.Focus();
            }
            else
            {
                ActualizarGrilla();
                
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
                btn_Cancelar.PerformClick();
            }
            
            admPermisos.actualizar = true;
            admLocalidades.actualizar = true;
        }
        private void ActualizarGrilla()
        {
            bs_usuarios.ResetBindings(true);
            bs_usuarios.DataSource = admUsuarios.VerLista();
            dgrid_usuarios.DataSource = bs_usuarios;
            dgrid_usuarios.Columns[0].Visible = false;
            dgrid_usuarios.Columns[1].Visible = false;
            dgrid_usuarios.Columns[3].Visible = false;
            dgrid_usuarios.Columns[10].Visible = false;
        }

        private new void btn_Agregar_Click(object sender, EventArgs e)
        {
            
            txt_nombre.Focus();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            objUsuario = (Cusuario)dgrid_usuarios.CurrentRow.DataBoundItem;
            txt_nombre.Text = objUsuario.Nombre;
            txt_direccion.Text = objUsuario.Domicilio;
            txt_mail.Text = objUsuario.Email;
            txt_pass.Text = objUsuario.PASS;
            txt_cel.Text = objUsuario.Cel;
            txt_tel.Text = objUsuario.Tel;
            cb_localidades.Text = objUsuario.Localidad;
            cb_permisos.Text = (objUsuario.PERMISO()).Descripcion;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objUsuario = (Cusuario)dgrid_usuarios.CurrentRow.DataBoundItem;
                bool eliminar=true;
                string Argumento="";
                Ctrl_cuentas_corrientes admcuentas= Ctrl_cuentas_corrientes.ClaseActiva();
                if (admUsuarios.UnicoAdministrador(objUsuario))
                {
                    throw new Exception("No se puede eliminar el unico administrador que existe ya que se necesita al menos 1 para administrar el sistema");
                }
                else if(admcuentas.TieneCreditosODebitos(objUsuario.DevolverCuentaCorriente())){
                    eliminar=false;
                    Argumento="El usuario tiene debitos y creditos cargados y no se puede borrar por la integridad de datos.\nQuiere dar de baja?";
                }
                else if (admUsuarios.TieneVentas(objUsuario))
                {
                    Argumento = "El usuario esta en muchos registros de ventas y no se puede borrar por la integridad de datos.\nQuiere dar de baja?";
                    eliminar=false;
                }
                if (eliminar)
                {
                    admUsuarios.Eliminar(objUsuario);
                }
                else
                {
                    Frm_confirmacion formula = new Frm_confirmacion(Argumento, objUsuario.Nombre + " tiene referencias", "No", "Si");
                    formula.ShowDialog();
                    if (formula.RESPUESTA == "Si")
                        admUsuarios.DarBajaoAlta(objUsuario, false);
                    else
                        objUsuario = null;
                }
                if (objUsuario != null)
                {
                    ActualizarGrilla();
                    btn_Cancelar.PerformClick();
                    Frm_cuenta_corriente form = Frm_ABM_cuentas_corrientes.CuentaAbierta(objUsuario);
                    if (form != null)
                        form.Close();
                    objUsuario = null;
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
                if (objUsuario == null)
                {
                    Clocalidad objLoca=(Clocalidad)cb_localidades.SelectedItem;
                    Cpermiso objpermiso = (Cpermiso)cb_permisos.SelectedItem;
                    objUsuario = new Cusuario(txt_nombre.Text,txt_pass.Text,txt_direccion.Text,txt_tel.Text,txt_cel.Text,txt_mail.Text,objLoca,objpermiso);
                    admUsuarios.Agregar(objUsuario,true);
                }
                else
                {
                    bool CerrarBucle=false;
                    Frm_confirmacion FormPass = new Frm_confirmacion("Ingrese la contraseña :",UsuarioActivo.Nombre , "Aceptar", true,false);
                    while (!CerrarBucle )
                    {
                        FormPass.RESPUESTA = null;
                        FormPass.ShowDialog();
                        if (FormPass.RESPUESTA != null)
                        {
                            if (FormPass.NUMERO == UsuarioActivo.PASS)
                                CerrarBucle = true;
                        }
                        else
                            CerrarBucle = true;
                    }
                    if (FormPass.RESPUESTA != null)
                    {
                        if (objUsuario.PERMISO().ID == 1)
                        {
                            if (((Cpermiso)cb_permisos.SelectedItem).ID != 1)
                            {
                                if (admUsuarios.UnicoAdministrador(objUsuario))
                                    throw new Exception("Esta modificando los permisos del unico administrador,necesario para el sistema.\nAgregue otro administrador para modificar este o dejelo como el mismo.");
                            }
                        }
                        objUsuario.Nombre = txt_nombre.Text;
                        objUsuario.Cel = txt_cel.Text;
                        objUsuario.Domicilio = txt_direccion.Text;
                        objUsuario.Tel = txt_tel.Text;
                        objUsuario.LOCALIDAD((Clocalidad)cb_localidades.SelectedItem);
                        objUsuario.PERMISO((Cpermiso)cb_permisos.SelectedItem);
                        objUsuario.Email = txt_mail.Text;
                        objUsuario.PASS = txt_pass.Text;
                        admUsuarios.Modificar(objUsuario);
                    }
                }
                if (primeravez)
                {
                    Close();
                }
                else
                {
                    ActualizarGrilla();
                    btn_Cancelar.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Frm_ABM_usuarios_Activated(sender, e);
            txt_nombre.Clear();
            txt_cel.Clear();
            txt_direccion.Clear();
            txt_mail.Clear();
            txt_pass.Clear();
            txt_tel.Clear();
            objUsuario = null;
        }

        private void dgrid_usuarios_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void Frm_ABM_usuarios_Activated(object sender, EventArgs e)
        {
            if (admPermisos.actualizar)
            {
                bs_permisos.ResetBindings(true);
                bs_permisos.DataSource = admPermisos.VerLista();
                cb_permisos.DataSource = bs_permisos;
                cb_permisos.DisplayMember = "DESCRIPCION";
                admPermisos.actualizar = false;
                ActualizarGrilla();
            }
            if (admLocalidades.actualizar)
            {
                bs_localidades.ResetBindings(true);
                bs_localidades.DataSource = admLocalidades.VerLista();
                cb_localidades.DataSource = bs_localidades;
                cb_localidades.DisplayMember = "Nombre";
                admLocalidades.actualizar = false;
                ActualizarGrilla();
            }
            if (!primeravez)
            {
                dgrid_usuarios.ClearSelection();
                btn_Eliminar.Enabled = false;
                btn_Modificar.Enabled = false;
            }
        }

        private void lbl_localidad_Click(object sender, EventArgs e)
        {
            Frm_ABM_localidades frm = Frm_ABM_localidades.AbrirForm();
            frm.Show();
        }

        private void lbl_permisos_Click(object sender, EventArgs e)
        {
            Frm_ABM_permisos frm = new Frm_ABM_permisos();
            frm.ShowDialog();
        }

        private void btn_VerBajas_Click(object sender, EventArgs e)
        {
            admUsuarios.CargarBajas();
            BindingSource bs = new BindingSource();
            bs.DataSource = admUsuarios.VerListaBajas();
            if (bs.Count > 0)
            {
                List<int> columnasAocultar = new List<int>();
                for (int cont = 0; cont < 11; cont++)
                    columnasAocultar.Add(cont);
                columnasAocultar.Remove(2);
                columnasAocultar.Remove(4);
                Frm_Eleccion frm = new Frm_Eleccion("Usuarios dados de bajas", "el usuario", bs, columnasAocultar,"Doble click para dar de alta");
                frm.ShowDialog();
                if (frm.ObjRespuesta != null)
                {
                    admUsuarios.DarBajaoAlta((Cusuario)frm.ObjRespuesta, true);
                    ActualizarGrilla();
                }
            }
            else
            {
                Frm_confirmacion frm = new Frm_confirmacion("No hay usuarios dados de bajas!", "Bajas de usuarios", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void dgrid_usuarios_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                DataGridView dgrid = (DataGridView)sender;
                if (dgrid.SelectedRows.Count > 0)
                {
                    int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                    if (cal > e.Location.Y && e.Location.Y > 33)
                    {
                        Cusuario obj = (Cusuario)dgrid.CurrentRow.DataBoundItem;
                        Frm_confirmacion frm = new Frm_confirmacion("Nombre : " + obj.Nombre + "\nTel : " + obj.Tel + "\nCel : " + obj.Cel + "\nDirección : " + obj.Domicilio + "\nLocadidad : " + obj.Localidad+"\nPermiso : "+obj.Permiso, "Datos del usuario", "Aceptar");
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
            Reportes.R_Usuarios frm = new Reportes.R_Usuarios(true);
            frm.Show();
        }

        private void Frm_ABM_usuarios_Shown(object sender, EventArgs e)
        {
            admPermisos.actualizar = true;
            admLocalidades.actualizar = true;
            Frm_ABM_usuarios_Activated(sender, e);
        }

        private  void Frm_ABM_usuarios_KeyDown(object sender, KeyEventArgs e)
        {
            
                if (115 == e.KeyValue)//F5   REPORTE
                {
                    if (pn_btnABM.Visible && btn_Reporte.Enabled && btn_Reporte.Visible)
                        btn_Reporte.PerformClick();
                }
        }

    


    }
}
