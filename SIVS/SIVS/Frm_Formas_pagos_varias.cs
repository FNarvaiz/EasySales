using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASES;
using CONTROL;

namespace SIVS
{
    public partial class Frm_Formas_pagos_varias : Form
    {
        Ctrl_clientes admclientes = Ctrl_clientes.ClaseActiva();
        Ctrl_formas_pagos admformaspagos = Ctrl_formas_pagos.ClaseActiva();
        Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
        bool cambiar = true;
        
        string Sub;
        List<Cpago> _listapagos = new List<Cpago>();
        Cpago oPago1 = new Cpago();
        Cpago oPago2 = new Cpago();

        public List<Cpago> PAGOS
        {
            set
            {
                _listapagos = value;
            }
            get 
            {
                return _listapagos;
            }
        }        

        public Frm_Formas_pagos_varias(string subtotal)
        {            
            InitializeComponent();
            Sub = subtotal;
        }

        private void Frm_Formas_pagos_varias_Load(object sender, EventArgs e)
        {
            pbtn.Hide();
            lbl_Subtotal.Text = Sub;
            bs_FormasDePago.ResetBindings(false);
            admformaspagos.CargarLista();
            bs_FormasDePago.DataSource = admformaspagos.VerLista();
            bs_formasDePago2.DataSource = admformaspagos.VerLista();
            cbb_FormaPago1.DataSource = bs_FormasDePago;
            cbb_FormaPago1.DisplayMember = "Descripcion";
            cbb_FormaPago2.DataSource = bs_formasDePago2;
            cbb_FormaPago2.DisplayMember = "Descripcion";
            cbb_FormaPago1.Text = "Contado";
            txt_subtotalFP1.Text = Sub;
            ActualizarCuentas();
            CalcularDescuentos();
        }
        
        
        private void ActualizarCuentas()
        {                      
            bs_CuentasClientes.ResetBindings(false);
            bs_CuentasClientes.DataSource = admcuentas.DevolverClienteUsuarios();
            cbb_CuentasClientes1.DataSource = bs_CuentasClientes;
            cbb_CuentasClientes1.DisplayMember = "Nombre";

            bs_CuentasClientes2.ResetBindings(false);
            bs_CuentasClientes2.DataSource = admcuentas.DevolverClienteUsuarios();
            cbb_CuentasClientes2.DataSource = bs_CuentasClientes2;
            cbb_CuentasClientes2.DisplayMember = "Nombre";
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            cambiar = true;
            txt_subtotalFP1.Text = (Convert.ToDecimal(lbl_Subtotal.Text) / 2).ToString();            
        }

        private void txt_subtotalFP1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cambiar)
                {
                    if (txt_subtotalFP1.Text == "")
                        txt_subtotalFP1.Text = lbl_Subtotal.Text;

                    cambiar = false;
                    if (Convert.ToDecimal(txt_subtotalFP1.Text) <= Convert.ToDecimal(lbl_Subtotal.Text))
                    {
                        txt_subtotalFP2.Text = ((Convert.ToDecimal(lbl_Subtotal.Text)) - (Convert.ToDecimal(txt_subtotalFP1.Text))).ToString();
                    }
                    else
                    {
                        if (txt_subtotalFP1.Text == "0")
                        {
                            txt_subtotalFP2.Text = lbl_Subtotal.Text;
                        }
                        else
                        {
                            txt_subtotalFP1.Text = lbl_Subtotal.Text;
                            txt_subtotalFP2.Text = "0";
                        }
                    }
                    CalcularDescuentos();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void CalcularDescuentos()
        {
            try
            {
                lbl_subtotalFP1.Text = txt_subtotalFP1.Text;
                lbl_subtotalFP2.Text = txt_subtotalFP2.Text;


                if (((Cforma_pago)cbb_FormaPago1.SelectedItem).Descuento)
                {
                    lbl_descFP1.Text = ((Convert.ToDecimal(txt_subtotalFP1.Text)) * (((Cforma_pago)cbb_FormaPago1.SelectedItem).Porcentaje / -100)).ToString();

                }
                else
                {
                    lbl_descFP1.Text = ((Convert.ToDecimal(txt_subtotalFP1.Text)) * (((Cforma_pago)cbb_FormaPago1.SelectedItem).Porcentaje / 100)).ToString();
                }

                if (((Cforma_pago)cbb_FormaPago2.SelectedItem).Descuento)
                {
                    lbl_descFP2.Text = ((Convert.ToDecimal(txt_subtotalFP2.Text)) * (((Cforma_pago)cbb_FormaPago2.SelectedItem).Porcentaje / -100)).ToString();

                }
                else
                {
                    lbl_descFP2.Text = ((Convert.ToDecimal(txt_subtotalFP2.Text)) * (((Cforma_pago)cbb_FormaPago2.SelectedItem).Porcentaje / 100)).ToString();
                }

                lbl_totalFP1.Text = (Convert.ToDecimal(lbl_subtotalFP1.Text) + Convert.ToDecimal(lbl_descFP1.Text)).ToString();               
                lbl_totalFP2.Text = (Convert.ToDecimal(lbl_subtotalFP2.Text) + Convert.ToDecimal(lbl_descFP2.Text)).ToString();

                lbl_desc.Text = (Convert.ToDecimal(lbl_descFP1.Text) + Convert.ToDecimal(lbl_descFP2.Text)).ToString();
                lbl_Total.Text = (Convert.ToDecimal(lbl_Subtotal.Text) + Convert.ToDecimal(lbl_desc.Text)).ToString();
            }
            catch
            { }
        }             
        private bool FormasPagosIguales(){
            if (((Cforma_pago)cbb_FormaPago1.SelectedItem) == ((Cforma_pago)cbb_FormaPago2.SelectedItem))
                return true;
            else
                return false;
        }
        private void cbb_FormaPago1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_FormaPago1.Items.Count > 1)
                {
                    Cforma_pago forma=(Cforma_pago)cbb_FormaPago1.SelectedItem;
                    if (!FormasPagosIguales())
                    {

                        if (forma.ID == 2)
                        {
                            gb_cuentacorriente.Visible = true;

                            if (cbb_CuentasClientes1.Items.Count == 0)
                                ActualizarCuentas();

                            if (cbb_CuentasClientes1.Items.Count == 0)
                                cbb_CuentasClientes1.Enabled = false;
                            else
                                cbb_CuentasClientes1.Enabled = true;
                        }
                        else
                            gb_cuentacorriente.Visible = false;
                        pn_codigo1.Visible = forma.Autorizacion;
                        CalcularDescuentos();
                    }
                    else
                    {
                        if (forma.ID == 2)
                            cbb_FormaPago1.Text = admformaspagos.BuscarPorID(1).Descripcion;
                        else
                            cbb_FormaPago1.Text = admformaspagos.BuscarPorID(2).Descripcion;
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void cbb_FormaPago2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_FormaPago2.Items.Count > 1)
                {
                    Cforma_pago forma = (Cforma_pago)cbb_FormaPago2.SelectedItem;
                    if (!FormasPagosIguales())
                    {

                        if (forma.ID == 2)
                        {
                            gb_cuentacorriente2.Visible = true;

                            if (cbb_CuentasClientes2.Items.Count == 0)
                                ActualizarCuentas();

                            if (cbb_CuentasClientes2.Items.Count == 0)
                                cbb_CuentasClientes2.Enabled = false;
                            else
                                cbb_CuentasClientes2.Enabled = true;
                        }
                        else
                            gb_cuentacorriente2.Visible = false;

                        pn_codigo2.Visible = forma.Autorizacion;
                        CalcularDescuentos();
                    }
                    else
                    {
                        if (forma.ID == 2)
                            cbb_FormaPago2.Text = admformaspagos.BuscarPorID(1).Descripcion;
                        else
                            cbb_FormaPago2.Text = admformaspagos.BuscarPorID(2).Descripcion;
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void cbb_CuentasClientes1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_CuentasClientes1.Items.Count > 0)
            {
                bs_CuentasClientes2.ResetBindings(false);
                bs_CuentasClientes2.DataSource = admcuentas.DevolverClienteUsuarios();
                cbb_CuentasClientes2.DisplayMember = "Nombre";
                bs_CuentasClientes2.Remove((Cpersona)cbb_CuentasClientes1.SelectedItem);
                cbb_CuentasClientes2.DataSource = bs_CuentasClientes2;
            }
        }       

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llenarLista(Cpago Pago1, Cpago Pago2)
        {
            
            _listapagos.Clear();
            _listapagos.Add(Pago1);
            _listapagos.Add(Pago2);
        }
        
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (((Cforma_pago)cbb_FormaPago1.SelectedItem).ID==2)
            {
                oPago1.Cod_Autorizacion = txt_codAutorizacion1.Text;
                oPago1.Descuento = Convert.ToDecimal(lbl_descFP1.Text);
                oPago1.FormaPago = (Cforma_pago)cbb_FormaPago1.SelectedItem;
                oPago1.Importe = Convert.ToDecimal(lbl_totalFP1.Text);                
                oPago1.Persona = (Cpersona)cbb_CuentasClientes1.SelectedItem;
                
            }
            else
            {
                oPago1.Cod_Autorizacion = txt_codAutorizacion1.Text;
                oPago1.Descuento = Convert.ToDecimal(lbl_descFP1.Text);
                oPago1.FormaPago = (Cforma_pago)cbb_FormaPago1.SelectedItem;
                oPago1.Importe = Convert.ToDecimal(lbl_totalFP1.Text);
            }

            if (((Cforma_pago)cbb_FormaPago2.SelectedItem).ID == 2)
            {
                oPago2.Cod_Autorizacion = txt_codAutorizacion2.Text;
                oPago2.Descuento = Convert.ToDecimal(lbl_descFP2.Text);
                oPago2.FormaPago = (Cforma_pago)cbb_FormaPago2.SelectedItem;
                oPago2.Importe = Convert.ToDecimal(lbl_totalFP2.Text);
                oPago2.Persona = (Cpersona)cbb_CuentasClientes2.SelectedItem;
                
            }
            else
            {
                oPago2.Cod_Autorizacion = txt_codAutorizacion2.Text;
                oPago2.Descuento = Convert.ToDecimal(lbl_descFP2.Text);
                oPago2.FormaPago = (Cforma_pago)cbb_FormaPago2.SelectedItem;
                oPago2.Importe = Convert.ToDecimal(lbl_totalFP2.Text);
            }

            llenarLista(oPago1,oPago2);
            Close();
        }

        private void txt_subtotalFP_KeyPress(object sender, KeyPressEventArgs e)
        {
            cambiar = true;
        }

        private void txt_subtotalFP2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cambiar)
                {
                    if (txt_subtotalFP2.Text == "")
                        txt_subtotalFP2.Text = lbl_Subtotal.Text;

                    cambiar = false;
                    if (Convert.ToDecimal(txt_subtotalFP2.Text) <= Convert.ToDecimal(lbl_subtotalFP2.Text))
                    {
                        txt_subtotalFP1.Text = ((Convert.ToDecimal(lbl_Subtotal.Text)) - (Convert.ToDecimal(txt_subtotalFP2.Text))).ToString();
                    }
                    else
                    {
                        if (txt_subtotalFP2.Text == "0")
                        {
                            txt_subtotalFP1.Text = lbl_Subtotal.Text;
                        }
                        else
                        {
                            txt_subtotalFP2.Text = lbl_Subtotal.Text;
                            txt_subtotalFP1.Text = "0";
                        }
                    }
                    CalcularDescuentos();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }           
    }
}
