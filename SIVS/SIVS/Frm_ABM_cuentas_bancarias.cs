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
    public partial class Frm_ABM_cuentas_bancarias : SIVS.Frm_ABM
    {
        static Frm_ABM_cuentas_bancarias frm;
        Ctrl_cuentas_bancarias admCuentasBancarias = Ctrl_cuentas_bancarias.ClaseActiva();
        Ctrl_bancos admBancos = Ctrl_bancos.ClaseActiva();
        public Cpersona opersona;
        public Ccuenta_bancaria oCuentaBancaria;     

        public Frm_ABM_cuentas_bancarias()
        {
            InitializeComponent();
        }
        public static Frm_ABM_cuentas_bancarias AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_ABM_cuentas_bancarias();
            }
            frm.Focus();
            return frm;
        }
        public static Frm_ABM_cuentas_bancarias AbrirForm(Cpersona obj)
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_ABM_cuentas_bancarias();
                frm.opersona = obj;
            }
            frm.Focus();
            return frm;
        }
        private void lbl_banco_Click(object sender, EventArgs e)
        {
            Frm_ABM_bancos frm = Frm_ABM_bancos.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void Frm_ABM_cuentas_bancarias_Load(object sender, EventArgs e)
        {
            btn_Modificar.Visible = false;
            btn_Cancelar.PerformClick();
            Text = "Lista de cuentas bancarias de " + opersona.Nombre;
            pn_busqueda.Visible = false;

            bs_bancos.ResetBindings(false);
            bs_bancos.DataSource = admBancos.VerLista();
            bs_bancos.Sort = "Nombre ASC";
            cbb_banco.DataSource = bs_bancos;
            cbb_banco.DisplayMember = "Nombre";

            ActualizarGrilla();
        }
        private void ActualizarGrilla()
        {
            bs_cuentasBancarias.ResetBindings(true);
            bs_cuentasBancarias.DataSource = admCuentasBancarias.DevolverCuentasBancarias(opersona);
            dgrid_cuentasBancarias.DataSource = bs_cuentasBancarias.DataSource;
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Ccuenta_bancaria oCuentaBancariaNueva = new Ccuenta_bancaria(txt_cbu.Text, opersona, txt_titular.Text, txt_tipoCuenta.Text, txt_nroCuenta.Text, (Cbanco)cbb_banco.SelectedItem);
            admCuentasBancarias.Agregar(oCuentaBancariaNueva);
            btn_Cancelar.PerformClick();
            ActualizarGrilla();
           
        }
        private void Frm_ABM_cuentas_bancarias_ResizeEnd(object sender, EventArgs e)
        {
            if (dgrid_cuentasBancarias.Width > dgrid_cuentasBancarias.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed))
                dgrid_cuentasBancarias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            else
                dgrid_cuentasBancarias.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void Frm_ABM_cuentas_bancarias_Activated(object sender, EventArgs e)
        {
            dgrid_cuentasBancarias.ClearSelection();
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
        }
        private void dgrid_cuentasBancarias_SelectionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_cuentasBancarias.SelectedRows.Count > 0)
                {
                    //Ccuenta_bancaria obj = (Ccuenta_bancaria)dgrid_cuentasBancarias.CurrentRow.DataBoundItem; NO LO PUEDE CASTEAR
                    
                    Frm_confirmacion frm = new Frm_confirmacion("¿Está seguro que desea eliminar la siguiente cuenta bancaria ? \n "
                + "Titular: " +  dgrid_cuentasBancarias.CurrentRow.Cells[0].Value.ToString() 
                +" \n CBU: "+ dgrid_cuentasBancarias.CurrentRow.Cells[1].Value.ToString(), "/n Eliminación de cuenta bancaria", "No", "Si");

                    frm.ShowDialog();

                    if (frm.RESPUESTA == "Si")
                    {
                        admCuentasBancarias.Eliminar(dgrid_cuentasBancarias.CurrentRow.Cells[1].Value.ToString());
                        //adm.Eliminar((Carticulo)dgrid_cuentasBancarias.CurrentRow.DataBoundItem);                        
                    }
                    ActualizarGrilla();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            //dgrid_cuentasBancarias.CurrentRow.Cells[1].Value.ToString();
            //oCuentaBancaria = admCuentasBancarias.
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            
        }

    }
}
