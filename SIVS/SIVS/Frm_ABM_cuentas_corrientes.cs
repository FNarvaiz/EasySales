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
    public partial class Frm_ABM_cuentas_corrientes : SIVS.Frm_ABM
    {
        Ctrl_cuentas_corrientes adm = Ctrl_cuentas_corrientes.ClaseActiva();
        Ccaja_diaria ObjCajaDiaria;
        int tag;
        static List<Frm_ABM_cuentas_corrientes> FormulariosDeCuentas = new List<Frm_ABM_cuentas_corrientes>();
        static  List<Frm_cuenta_corriente> FormulariosAbiertos = new List<Frm_cuenta_corriente>();
        static public void SacarDeLista(Frm_cuenta_corriente form)
        {
            FormulariosAbiertos.Remove(form);
        }
        static public Frm_cuenta_corriente CuentaAbierta(Cpersona oPersona)
        {
            foreach (Frm_cuenta_corriente aux in FormulariosAbiertos)
            {
                if (aux.Persona.ID == oPersona.ID)
                    return aux;
            }
            return null;
        }
        public static Frm_ABM_cuentas_corrientes AbrirForm(Ccaja_diaria obj,int tag)
        {
            Frm_ABM_cuentas_corrientes form=null;
            foreach (Frm_ABM_cuentas_corrientes aux in FormulariosDeCuentas)
            {
                if (aux.tag == tag)
                    form = aux;
            }
            if ((form == null) || (form.IsDisposed))
            {
                form = new Frm_ABM_cuentas_corrientes(obj,tag);
            }
            FormulariosDeCuentas.Add(form);
            form.Focus();
            return form;
        }
        public Frm_ABM_cuentas_corrientes(Ccaja_diaria obj,int TAG)
        {
            InitializeComponent();
            ObjCajaDiaria = obj;
            tag=TAG;
            if (tag == 1)
            {
                lbl_Definicion.Text = "Clientes :";
                btn_Eliminar.Text = " Nuevo cliente";
            }
            else if (tag == 2)
            {
                lbl_Definicion.Text = "Proveedores :";
                btn_Eliminar.Text = " Nuevo proveedor";
            }
            else
            {
                lbl_Definicion.Text = "Usuarios :";
                btn_Eliminar.Text = " Nuevo usuario";
            }

        }
        private void Frm_ABM_cuentas_corrientes_Load(object sender, EventArgs e)
        {
        }
        private void ActualizarGrilla()
        {
            bs_personas.ResetBindings(true);
            List<int> columnasinvisibles = new List<int>();
            columnasinvisibles.Add(0);
            columnasinvisibles.Add(1);
            columnasinvisibles.Add(5);
            columnasinvisibles.Add(6);
            columnasinvisibles.Add(7);
            if(tag==1){
                Ctrl_clientes admclientes= Ctrl_clientes.ClaseActiva();
                bs_personas.DataSource= admclientes.VerLista();
                columnasinvisibles.Add(3);
                columnasinvisibles.Add(4);
            }
            else if(tag==2){
                Ctrl_proveedores admproveedores= Ctrl_proveedores.ClaseActiva();
                bs_personas.DataSource= admproveedores.VerLista();
                columnasinvisibles.Add(4);
                columnasinvisibles.Add(2);
                columnasinvisibles.Add(8);
            }
            else{
                Ctrl_usuarios admusuarios= Ctrl_usuarios.ClaseActiva();
                bs_personas.DataSource= admusuarios.VerLista();
                columnasinvisibles.Add(3);
                columnasinvisibles.Add(2);
                columnasinvisibles.Add(8);
                columnasinvisibles.Add(9);
            }
            dgrid_personas.DataSource = bs_personas;
            dgrid_personas.ClearSelection();
            foreach (int x in columnasinvisibles)
            {
                dgrid_personas.Columns[x].Visible = false;
            }
            
        }
        private void dgrid_personas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_personas.SelectedRows.Count > 0)
            {
                dgrid_personas.ClearSelection();
                btn_Eliminar.Enabled = true;
                btn_Modificar.Enabled = true;
            }
        }
        
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            Cpersona oPersona;
            if (dgrid_personas.SelectedRows.Count > 0)
            {

                oPersona = (Cpersona)dgrid_personas.CurrentRow.DataBoundItem;
                Frm_cuenta_corriente frm;
                frm = CuentaAbierta(oPersona);
                if (frm != null)
                    frm.Focus();
                else
                {
                    if(tag==1){
                        Ccliente objcliente = (Ccliente)oPersona;
                        adm.CargarAltasDebitosyCreditos(objcliente.DevolverCuentaCorriente());
                        adm.CargarCreditosdeDebitos(objcliente.DevolverCuentaCorriente());
                        frm = new Frm_cuenta_corriente(objcliente, ObjCajaDiaria);
                        frm.Show();
                    }
                    else if(tag==2){

                        Cproveedor objproveedor = (Cproveedor)oPersona;
                        adm.CargarAltasDebitosyCreditos(objproveedor.DevolverCuentaCorriente());
                        adm.CargarRecibosDePagos(objproveedor.DevolverCuentaCorriente());
                        frm = new Frm_cuenta_corriente(objproveedor, ObjCajaDiaria);
                        frm.Show();
                    }
                    else{
                        Cusuario objusuario = (Cusuario)oPersona;
                        adm.CargarAltasDebitosyCreditos(objusuario.DevolverCuentaCorriente());
                        adm.CargarCreditosdeDebitos(objusuario.DevolverCuentaCorriente());
                        frm = new Frm_cuenta_corriente(objusuario, ObjCajaDiaria);
                        frm.Show();
                    }
                    FormulariosAbiertos.Add(frm);
                }
            }
        }
        private void dgrid_personas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                DataGridView dgrid = (DataGridView)sender;
                //MessageBox.Show(e.Location.Y.ToString() + " " + (dgrid.Rows[0].Height).ToString());
                if (dgrid.SelectedRows.Count > 0)
                {
                    int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                    if (cal > e.Location.Y && e.Location.Y > 33)
                    {
                        btn_Modificar_Click(sender, e);
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_ABM_cuentas_corrientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormulariosDeCuentas.Remove(this);
        }

        protected override void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                Reportes.R_Cuentas frm = new Reportes.R_Cuentas(tag,true);
                frm.Show();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (tag == 1)
            {
                Frm_ABM_clientes frm = Frm_ABM_clientes.AbrirForm();
                frm.ShowDialog();
            }
            else if (tag == 2)
            {
                Frm_ABM_proveedores frm = Frm_ABM_proveedores.AbrirForm();
                frm.ShowDialog();
            }
            else
            {
                Frm_ABM_usuarios frm = Frm_ABM_usuarios.AbrirForm();
                frm.ShowDialog();
            }
            ActualizarGrilla();
        }

        private void Frm_ABM_cuentas_corrientes_Shown(object sender, EventArgs e)
        {
            if (tag > 1)
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
            }
        }

        private void Frm_ABM_cuentas_corrientes_Activated(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

    }
}
