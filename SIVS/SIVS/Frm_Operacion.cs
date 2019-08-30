using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLASES;
using CONTROL;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Operacion : Form
    {
        bool Gasto;
        Coperacion Ooperacion;
        Cpersona Opersona;
        Ctrl_conceptos admconcep = Ctrl_conceptos.ClaseActiva();
        Cconcepto Oconcepto;
        Ctrl_cajas_diarias adm= Ctrl_cajas_diarias.ClaseActiva();
        Ccaja_diaria ObjCajaDiaria;
        bool buscar=false;

        public Frm_Operacion(bool gasto,Ccaja_diaria obj)
        {
            InitializeComponent();
            Gasto = gasto;
            ObjCajaDiaria = obj;
        }
        public Frm_Operacion(bool gasto,Coperacion cOp,Ccaja_diaria obj, Cpersona oper)
        {
            InitializeComponent();
            Gasto = gasto;
            Ooperacion=cOp;
            ObjCajaDiaria = obj;
            Opersona = oper;
        }
        
        private void Frm_Operacion_Load(object sender, EventArgs e)
        {
            Ctrl_formas_pagos admformas= Ctrl_formas_pagos.ClaseActiva();
            bs_FormasPagos.ResetBindings(true);
            bs_FormasPagos.DataSource= admformas.VerLista();
            cb_FormasPagos.DataSource=bs_FormasPagos;
            cb_FormasPagos.DisplayMember="Descripcion";
            cb_FormasPagos.Text = admformas.BuscarPorID(1).Descripcion;
            ActualizarConceptos();

            if (Gasto)
            {
                cb_registrar.Text = "Generar debito en cuenta";
                Ctrl_proveedores admprove = Ctrl_proveedores.ClaseActiva();
                if(admprove.VerLista().Count==0)
                    cb_registrar.Visible=false;
                if (Ooperacion == null)
                    this.Text = "Agregar gasto";
                else
                {
                    this.Text = "Modificar gasto";
                    cb_concepto.Text = ((Cgasto)Ooperacion).Concepto;
                    txt_importe.Text = Ooperacion.Importe.ToString();
                    if (Opersona != null)
                    {
                        cb_registrar.Visible = false;
                        lbl_persona.Text = Opersona.Nombre;
                    }
                }
            }
            else
            {
                cb_registrar.Text = "Generar recibo en cuenta";
                Ctrl_clientes admclien = Ctrl_clientes.ClaseActiva();
                if (admclien.VerClientesConCuentas().Count == 0)
                    cb_registrar.Visible = false;
                if (Ooperacion == null)
                {
                    this.Text = "Agregar Cobro";
                }
                else
                {
                    this.Text = "Modificar Cobro";
                    cb_concepto.Text = ((Ccobro)Ooperacion).Concepto;
                    txt_importe.Text = Ooperacion.Importe.ToString();
                    if (Opersona != null)
                    {
                        cb_registrar.Visible = false;
                        lbl_persona.Text = Opersona.Nombre;
                    }
                }
            }
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try{
                Oconcepto = (Cconcepto)cb_concepto.SelectedItem;
            if(Gasto){
                Cgasto obj = new Cgasto(Oconcepto, Convert.ToDecimal(txt_importe.Text), (Cforma_pago)cb_FormasPagos.SelectedValue);
                if(Ooperacion==null){
                    
                    if (obj.FORMAPAGO().Altera_caja)
                    {
                        if (ObjCajaDiaria.Efec_final >= obj.Importe)
                            adm.AgregarOperacion(obj, ObjCajaDiaria);
                        else
                            throw new Exception("No tiene suficiente plata en caja como para pagar ese gasto");
                    }
                    else
                    {
                        adm.AgregarOperacion(obj, ObjCajaDiaria);
                    }
                }
                else{
                    if (obj.FORMAPAGO().Altera_caja)
                    {
                        if (ObjCajaDiaria.Efec_final < (obj.Importe - Ooperacion.Importe))
                            throw new Exception("No tiene suficiente plata en caja como para pagar ese gasto");
                    }
                    adm.ModificarOperacion((Cgasto)Ooperacion, obj, ObjCajaDiaria);
                }
                if (cb_registrar.Checked)
                {
                    Ctrl_cuentas_corrientes admCuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                    Cpago_credito objcu = new Cpago_credito(obj.Concepto, obj.Importe, DateTime.Today, true);
                    Cproveedor objproveedor = ((Cproveedor)Opersona);
                    admCuentas.CargarAltasDebitosyCreditos(objproveedor.DevolverCuentaCorriente());
                    admCuentas.AgregarOperacion(objcu, objproveedor.DevolverCuentaCorriente());
                    admCuentas.AgregarReferiaEntreOperacion(objcu, obj);
                }
                else
                {
                    if (Opersona != null)
                    {
                        Cgasto ogasto = (Cgasto)Ooperacion;
                        if (obj.Importe != ogasto.Credito().Importe)
                        {
                            Ccuenta_corriente cuenta = Opersona.DevolverCuentaCorriente();
                            ogasto.Credito().Importe = obj.Importe;
                            cuenta.ModificarCredito(cuenta.BuscarCredito(ogasto.Credito().Numero), obj.Importe);
                            Ctrl_cuentas_corrientes admCuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                            admCuentas.ModificarOperacion(ogasto.Credito());
                        }
                    }
                }
            }
            else{
                Ccobro obj = new Ccobro(Oconcepto, Convert.ToDecimal(txt_importe.Text), (Cforma_pago)cb_FormasPagos.SelectedValue);
                if(Ooperacion==null)
                {
                    adm.AgregarOperacion(obj, ObjCajaDiaria);
                }
                else
                {
                    adm.ModificarOperacion((Ccobro)Ooperacion, obj, ObjCajaDiaria);
                }
                if (cb_registrar.Checked)
                {
                    Ctrl_cuentas_corrientes admCuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                    Crecibo_debito objc= new Crecibo_debito(obj.Concepto,obj.Importe,DateTime.Today,true);
                    Ccliente objcliente = ((Ccliente)Opersona);
                    admCuentas.CargarAltasDebitosyCreditos(objcliente.DevolverCuentaCorriente());
                    admCuentas.AgregarOperacion(objc, objcliente.DevolverCuentaCorriente());
                    admCuentas.AgregarReferiaEntreOperacion(objc, obj);
                }
                else
                {
                    if (Opersona != null)
                    {
                        Ccobro ocobro = (Ccobro)Ooperacion;
                        if (obj.Importe != ocobro.Debito().Importe)
                        {
                            Ccuenta_corriente cuenta = Opersona.DevolverCuentaCorriente();
                            ocobro.Debito().Importe = obj.Importe;
                            cuenta.ModificarDebito(cuenta.BuscarDebito(ocobro.Debito().Numero), obj.Importe);
                            Ctrl_cuentas_corrientes admCuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                            admCuentas.ModificarOperacion(ocobro.Debito());
                        }
                    }
                }
            }
            Close();
            }
            catch(Exception ex){
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Error", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void cb_registrar_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_registrar.Checked)
                {
                    BindingSource bs = new BindingSource();
                    List<int> ocultarcolumnas = new List<int>();
                    Frm_Eleccion frm;
                    if (Gasto)
                    {
                        Ctrl_proveedores admProvedores = Ctrl_proveedores.ClaseActiva();
                        if (admProvedores.VerLista().Count == 0)
                        {
                            throw new Exception("No hay proveedores cargados en el sistema");
                        }
                        bs.DataSource = admProvedores.VerLista();
                        for (int cont = 0; cont < 10; cont++)
                            ocultarcolumnas.Add(cont);
                        ocultarcolumnas.Remove(3);
                        frm = new Frm_Eleccion("Proveedores con cuentas", "el proveedor", bs, ocultarcolumnas, "");
                    }
                    else
                    {

                        Ctrl_clientes admClientes = Ctrl_clientes.ClaseActiva();
                        bs.DataSource = admClientes.VerClientesConCuentas();
                        for (int cont = 0; cont < 9; cont++)
                            ocultarcolumnas.Add(cont);
                        ocultarcolumnas.Remove(2);
                        frm = new Frm_Eleccion("Clientes con cuentas", "el cliente", bs, ocultarcolumnas, "");
                    }
                    frm.ShowDialog();
                    if (frm.ObjRespuesta != null)
                    {
                        Opersona = (Cpersona)frm.ObjRespuesta;
                        lbl_persona.Text = Opersona.Nombre;
                        lbl_persona.Visible = true;
                    }
                    else
                    {
                        cb_registrar.Checked = false;
                    }
                }
                else
                {
                    lbl_persona.Visible = false;
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                frm.ShowDialog();
            }

        }
        private void ActualizarConceptos()
        {
            bs_conceptos.ResetBindings(false);
            bs_conceptos.DataSource = admconcep.ListaParaCombo();
            cb_concepto.DataSource = bs_conceptos;
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void txt_concepto_KeyPress(object sender, KeyPressEventArgs e)
        {
                buscar = true;
        }

        private void cb_concepto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Operacion_Shown(object sender, EventArgs e)
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

        private void cb_concepto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (-1 == ((Cconcepto)cb_concepto.SelectedItem).ID)
                {
                    Frm_conceptos frm = new Frm_conceptos();
                    frm.ShowDialog();
                    if (frm.Guardar)
                    {
                        admconcep.Agregar(new Cconcepto(frm.Descripcion));
                        ActualizarConceptos();
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                frm.ShowDialog();
            }
        }

    }
}

