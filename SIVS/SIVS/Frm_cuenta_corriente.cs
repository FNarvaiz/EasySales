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
    public partial class Frm_cuenta_corriente : SIVS.Frm_ABM
    {
        Ctrl_cuentas_corrientes adm = Ctrl_cuentas_corrientes.ClaseActiva();
        Ctrl_cajas_diarias admcaja = Ctrl_cajas_diarias.ClaseActiva();
        Ctrl_formas_pagos admforma = Ctrl_formas_pagos.ClaseActiva();
        Ccuenta_corriente objcuenta;
        Coperacion objoperacion;
        Cpersona objpersona;
        Ccaja_diaria ObjCajaDiaria;
        Cforma_pago forma;
        bool vertodos=false;
        bool proveedor = false;
        bool ModoModificacion = false;
        decimal ApagarDelprimero;
        decimal total;
        List<Crecibo_debito> LRecibos = new List<Crecibo_debito>();
        List<Cpago_credito> LCreditos = new List<Cpago_credito>();
        public Cpersona Persona
        {
            get
            {
                return objpersona;
            }
        }
        private void LimpiarSeleccionados()
        {
            Color ocolor = Color.FromArgb(64, 64, 64);
            if (LCreditos.Count > 0)
            {
                LCreditos.Clear();
                foreach (DataGridViewRow aux in dgrid_Creditos.Rows)
                {
                    aux.Cells["Concepto"].Style.BackColor = ocolor;
                    aux.Cells["Importe"].Style.BackColor = ocolor;
                }
                txt_concepto.Clear();
                txt_importe.Enabled = true;
                txt_importe.Clear();
            }
            if (LRecibos.Count > 0)
            {
                LRecibos.Clear();
                foreach (DataGridViewRow aux in dgrid_Debitos.Rows)
                {
                    aux.Cells["Concepto"].Style.BackColor = ocolor;
                    aux.Cells["Importe"].Style.BackColor = ocolor;
                }
                txt_concepto.Clear();
                txt_importe.Enabled = true;
                txt_importe.Clear();
            }
        }
        private void SeleccionarTodos()
        {
            txt_concepto.Text = "Liquidación de ";
            if (proveedor)
            {
                rb_debito.Checked = false;
                rb_credito.Checked = true;
                foreach (DataGridViewRow fila in dgrid_Debitos.Rows)
                {
                    
                    Crecibo_debito obj= (Crecibo_debito)fila.DataBoundItem;
                    decimal pagado = 0;
                    foreach (Cpago_credito auxcredito in objcuenta.Creditos)
                    {
                        if (auxcredito.Recibos() != null)
                        {
                            if (auxcredito.Recibos().Contains(obj))
                                pagado += auxcredito.Importe;
                        }
                    }
                    fila.Cells["Concepto"].Style.BackColor = Color.FromArgb(240, 194, 70);
                    fila.Cells["Importe"].Style.BackColor = Color.FromArgb(240, 194, 70);
                    txt_concepto.Text = txt_concepto.Text + obj.Concepto + ", ";
                    if (LRecibos.Count < 1)
                    {
                        txt_importe.Text = "0";
                        ApagarDelprimero = obj.Importe - pagado;
                    }
                    else if (LRecibos.Count == 1)
                    {
                        txt_importe.Text = ApagarDelprimero.ToString();
                        txt_importe.Enabled = false;
                    }
                    txt_importe.Text = (Convert.ToDecimal(txt_importe.Text) + (obj.Importe - pagado)).ToString();
                    LRecibos.Add(obj);
                }
            }
            else
            {
                decimal total = 0;
                rb_debito.Checked = true;
                rb_credito.Checked = false;
                foreach (DataGridViewRow fila in dgrid_Creditos.Rows)
                {

                    Cpago_credito auxcred= (Cpago_credito)fila.DataBoundItem;
                    decimal pagado = 0;
                    foreach (Crecibo_debito auxdebito in objcuenta.Debitos)
                    {
                        if (auxdebito.Creditos() != null)
                        {
                            if (auxdebito.Creditos().Contains(auxcred))
                                pagado += auxdebito.Importe;
                        }
                    }
                    fila.Cells["Concepto"].Style.BackColor = Color.FromArgb(240, 194, 70);
                    fila.Cells["Importe"].Style.BackColor = Color.FromArgb(240, 194, 70);
                    txt_concepto.Text = txt_concepto.Text + auxcred.Concepto + ", ";
                    if (LCreditos.Count < 1)
                    {
                        txt_importe.Text = "0";
                        ApagarDelprimero = auxcred.Importe-pagado;
                    }
                    else if (LCreditos.Count == 1)
                    {
                        total= ApagarDelprimero;
                        txt_importe.Enabled = false;
                    }
                    total += (auxcred.Importe - pagado);
                    LCreditos.Add(auxcred);
                }
                txt_importe.Text = total.ToString();
            }
        }
        public Frm_cuenta_corriente(Ccliente obj,Ccaja_diaria ocaja)
        {
            InitializeComponent();
            Text = Text + obj.Nombre;
            L_descripcion.Text = "Apellido y Nombre :" + obj.Nombre + "\nDomicilio : " + obj.Domicilio + "\nLocalidad : " + obj.Localidad + "\nMail : " + obj.Email + "\nTel :" + obj.Tel + "\nCel :" + obj.Cel;
            lbl_saldo.Text = obj.Saldo.ToString();
            objcuenta = obj.DevolverCuentaCorriente();
            objpersona=obj;
            ObjCajaDiaria=ocaja;
        }
        public Frm_cuenta_corriente(Cusuario obj, Ccaja_diaria ocaja)
        {
            InitializeComponent();
            Text = Text + obj.Nombre;
            L_descripcion.Text = "Apellido y Nombre :" + obj.Nombre + "\nDomicilio : " + obj.Domicilio + "\nLocalidad : " + obj.Localidad + "\nMail : " + obj.Email + "\nTel :" + obj.Tel + "\nCel :" + obj.Cel;
            lbl_saldo.Text = obj.Saldo.ToString();
            objcuenta = obj.DevolverCuentaCorriente();
            objpersona = obj;
            ObjCajaDiaria = ocaja;
        }
        public Frm_cuenta_corriente(Cproveedor obj, Ccaja_diaria ocaja)
        {
            InitializeComponent();
            Text = Text + obj.Nombre;
            L_descripcion.Text = "CUIT : " + obj.CUIT + "\nApellido y Nombre : " + obj.Nombre + "\nDomicilio : " + obj.Domicilio + "\nLocalidad : " + obj.Localidad + "\nMail : " + obj.Email + "\nTel :" + obj.Tel + "\nCel :" + obj.Cel;
            lbl_saldo.Text = obj.Saldo.ToString();
            objcuenta = obj.DevolverCuentaCorriente();
            lbl_creditos.Text = "DEBITOS";
            lbl_debito.Text = "CREDITOS";
            rb_credito.Text = "Debito";
            rb_debito.Text = "Credito";
            btn_Agregar.Text = "      Agregar debito";
            btn_AgregarDebito.Text = "      Agregar Credito";
            btn_actualizarSaldo.Visible = false;
            objpersona= obj;
            proveedor = true;
            ObjCajaDiaria = ocaja;
        }
        private void Frm_cuenta_corriente_Load(object sender, EventArgs e)
        {
            if (Width != 841)
            {
                ActualizarGrillaCreditos();
                ActualizarGrillaDebitos();
                Width = 841;
            }

        }
        private void Frm_cuenta_corriente_Activated(object sender, EventArgs e)
        {
            dgrid_Creditos.ClearSelection();
            dgrid_Debitos.ClearSelection();
            L_Incial.Text = "0";
            btn_Eliminar.Enabled = false;
            btn_Modificar.Enabled = false;
            btn_DarBaja.Enabled = false;
            lbl_saldo.Text = objcuenta.Saldo.ToString();
        }
        private void Frm_cuenta_corriente_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (vertodos)
                {
                    adm.SacarBajas(objcuenta);
                }
                adm.Modificar(objcuenta);
                Frm_ABM_cuentas_corrientes.SacarDeLista(this);
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        // GRILLAS!!!
        private void ActualizarGrillaDebitos()
        {
            bs_debitos.ResetBindings(true);
            bs_debitos.DataSource = objcuenta.Debitos;
            dgrid_Debitos.DataSource = bs_debitos;
            dgrid_Debitos.Columns[1].Visible = false;
            dgrid_Debitos.Columns[2].Visible = false;
        }
        private void ActualizarGrillaCreditos()
        {
            bs_creditos.ResetBindings(true);
            bs_creditos.DataSource = objcuenta.Creditos;
            dgrid_Creditos.DataSource = bs_creditos;
            dgrid_Creditos.Columns[1].Visible = false;
            dgrid_Creditos.Columns[2].Visible = false;
        }
        private void Expandido()
        {
            gb_abm.Enabled = false;
            pn_btnABM.Visible = false;
            p_derecho.Visible = true;
            pn_btnDerechos.Visible = true;
            ModoModificacion = true;
            txt_dia.Text = DateTime.Today.ToShortDateString();
            txt_concepto.Focus();
            dgrid_Creditos.ClearSelection();
            dgrid_Debitos.ClearSelection();
            L_Incial.Text = "0";
        }
        // BOTONES!!!!
        protected override void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (vertodos)
                btn_VerTodo_Click(sender, e);
            Expandido();
            cb_afecta_caja_CheckedChanged(sender, e);
                Button agregar = (Button)sender;

                if (Convert.ToInt32(agregar.Tag) == 1)
                {
                    rb_credito.Checked = true;
                    rb_debito.Checked = false;
                }
                else
                {
                    rb_credito.Checked = false;
                    rb_debito.Checked = true;
                }
                rb_credito_CheckedChanged(sender, e);
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (objoperacion == null)
                {
                    Ctrl_conceptos admconceptos = Ctrl_conceptos.ClaseActiva();
                    if (rb_credito.Checked)
                    {
                        Cpago_credito objcredi= new Cpago_credito(txt_concepto.Text, Convert.ToDecimal(txt_importe.Text), DateTime.Today,true);
                        adm.AgregarOperacion(objcredi, objcuenta);
                        if (proveedor)
                        {
                            if (LRecibos.Count > 0)
                            {
                                bool darbaja = false;
                                if (LRecibos.Count > 1 || ApagarDelprimero == objcredi.Importe)
                                {
                                    adm.DarBajaoAlta(objcredi, objcuenta, false);
                                    darbaja = true;
                                }
                                objcredi.InstanciaRecibos();
                                int seguidor;
                                int tope;
                                Cpago_credito auxCredito;
                                foreach (Crecibo_debito auxDebito in LRecibos)
                                {
                                    adm.AgregarReferiaEntreOperacion(objcredi, auxDebito);
                                    objcredi.AgregarRecibo(auxDebito);
                                    if (darbaja)
                                    {
                                        adm.DarBajaoAlta(auxDebito, objcuenta, false);
                                        seguidor = 0;
                                        tope = objcuenta.Creditos.Count;
                                        while (seguidor < tope)
                                        {
                                            auxCredito = objcuenta.Creditos[seguidor];
                                            if (auxCredito.Recibos() != null)
                                            {
                                                if (auxCredito.Recibos().Contains(auxDebito))
                                                {
                                                    adm.DarBajaoAlta(auxCredito, objcuenta, false);
                                                    tope--;
                                                    seguidor--;
                                                }
                                            }
                                            seguidor++;
                                        }
                                    }
                                }
                            }
                        }
                        if (cb_afecta_caja.Checked)
                        {
                            Cgasto objgasto= new Cgasto(admconceptos.BuscarPorID(1), objcredi.Importe,forma);
                            admcaja.AgregarOperacion(objgasto, ObjCajaDiaria);
                            adm.AgregarReferiaEntreOperacion(objcredi, objgasto);
                        }
                    }
                    else
                    {
                        Crecibo_debito objdebito=new Crecibo_debito(txt_concepto.Text, Convert.ToDecimal(txt_importe.Text), DateTime.Today,true);
                        adm.AgregarOperacion(objdebito, objcuenta);
                        if (!proveedor)
                        {
                            if (LCreditos.Count > 0)
                            {
                                bool darbaja = false;
                                if (LCreditos.Count > 1 || ApagarDelprimero == objdebito.Importe)
                                {
                                    adm.DarBajaoAlta(objdebito, objcuenta, false);
                                    darbaja = true;
                                }
                                objdebito.InstanciaCreditos();
                                int seguidor;
                                int tope;
                                Crecibo_debito auxDebito;
                                foreach (Cpago_credito auxCredito in LCreditos)
                                {
                                    adm.AgregarReferiaEntreOperacion(auxCredito, objdebito);
                                    objdebito.AgregarCreditos(auxCredito);
                                    
                                    if (darbaja)
                                    {
                                        adm.DarBajaoAlta(auxCredito, objcuenta, false);
                                        seguidor = 0;
                                        tope = objcuenta.Debitos.Count;
                                        while(seguidor<tope)
                                        {
                                            auxDebito = objcuenta.Debitos[seguidor];
                                            if (auxDebito.Creditos() != null)
                                            {
                                                if (auxDebito.Creditos().Contains(auxCredito))
                                                {
                                                    adm.DarBajaoAlta(auxDebito, objcuenta, false);
                                                    tope--;
                                                    seguidor--;
                                                }
                                            }
                                            seguidor++;
                                        }
                                    }
                                }
                            }
                        }
                        if (cb_afecta_caja.Checked)
                        {
                            Ccobro objcobro= new Ccobro(admconceptos.BuscarPorID(2), objdebito.Importe, forma);
                            admcaja.AgregarOperacion(objcobro,ObjCajaDiaria);
                            adm.AgregarReferiaEntreOperacion(objdebito, objcobro);
                        }
                    }
                }
                else
                {
                    if (rb_credito.Checked)
                    {
                        Cpago_credito objcredito = (Cpago_credito)objoperacion;
                        objcredito.Concepto = txt_concepto.Text;
                        adm.ModificarOperacion(new Cpago_credito(objoperacion.Numero, txt_concepto.Text, Convert.ToDecimal(txt_importe.Text), Convert.ToDateTime(txt_dia.Text),objcredito.AltaOp()));
                        objcuenta.ModificarCredito(objcredito, Convert.ToDecimal(txt_importe.Text));
                    }
                    else
                    {
                        Crecibo_debito objdebito= (Crecibo_debito)objoperacion;
                        objdebito.Concepto = txt_concepto.Text;
                        adm.ModificarOperacion(new Crecibo_debito(objoperacion.Numero, txt_concepto.Text, Convert.ToDecimal(txt_importe.Text), Convert.ToDateTime(txt_dia.Text),objdebito.AltaOp()));
                        objcuenta.ModificarDebito(objdebito, Convert.ToDecimal(txt_importe.Text));
                    }
                    
                }
                ActualizarGrillaCreditos();
                ActualizarGrillaDebitos();
                lbl_saldo.Text = objcuenta.Saldo.ToString();
                btn_Cancelar_Click(sender, e);
                adm.Modificar(objcuenta);
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
            p_derecho.Visible = false;
            pn_btnABM.Visible = true;
            ModoModificacion = false;
            Frm_cuenta_corriente_Activated(sender, e);
            txt_concepto.Clear();
            txt_importe.Clear();
            txt_importe.Enabled = true;
            objoperacion  = null;
            cb_afecta_caja.Hide();
            dgrid_Creditos.Enabled = true;
            dgrid_Debitos.Enabled = true;
            LimpiarSeleccionados();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            if (dgrid_Creditos.SelectedRows.Count == 0)
            {
                Crecibo_debito odebito  = (Crecibo_debito)dgrid_Debitos.CurrentRow.DataBoundItem;
                txt_concepto.Text = odebito.Concepto;
                objoperacion = odebito;
                    rb_credito.Checked = false;
                    rb_debito.Checked = true;
            }
            else
            {
                Cpago_credito ocredito = (Cpago_credito)dgrid_Creditos.CurrentRow.DataBoundItem;
                txt_concepto.Text = ocredito.Concepto;
                objoperacion = ocredito;
                    rb_debito.Checked = false;
                    rb_credito.Checked = true;
            }
            Expandido();
            cb_afecta_caja_CheckedChanged(sender, e);
            txt_dia.Text = objoperacion.Fecha.ToShortDateString();
            txt_importe.Text = objoperacion.Importe.ToString();
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_Creditos.SelectedRows.Count == 0)
                {
                    Crecibo_debito obj = (Crecibo_debito)dgrid_Debitos.CurrentRow.DataBoundItem;
                    bool TieneCobro= adm.TieneCobro(obj);
                    if (TieneCobro)
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("El Recibo/Debito hace referencia a un cobro existente.\nEste cobro no se borrara por integridad de la caja diaria en la que está./nQuiere continuar?", "Referencia hacia un cobro", "No", "Si");
                        frm.ShowDialog();
                        if (frm.RESPUESTA == "Si")
                        {
                            adm.EliminarOperacion(obj, TieneCobro, objcuenta);
                            ActualizarGrillaDebitos();
                            lbl_saldo.Text = objcuenta.Saldo.ToString();
                        }
                    }
                    else
                    {
                        adm.EliminarOperacion(obj, TieneCobro, objcuenta);
                        ActualizarGrillaDebitos();
                        lbl_saldo.Text = objcuenta.Saldo.ToString();
                    }
                }
                else
                {
                    Cpago_credito obj = (Cpago_credito)dgrid_Creditos.CurrentRow.DataBoundItem;
                    bool TieneGasto = adm.TieneGasto(obj);
                    if (TieneGasto)
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("El Pago/Credito hace referencia a un gasto existente.\nEste gasto no se borrara por integridad de la caja diaria en la que está./nQuiere continuar?", "Referencia hacia un gasto", "No", "Si");
                        frm.ShowDialog();
                        if (frm.RESPUESTA == "Si")
                        {
                            adm.EliminarOperacion(obj, TieneGasto, objcuenta);
                            ActualizarGrillaCreditos();
                            lbl_saldo.Text = objcuenta.Saldo.ToString();
                        }
                    }
                    else
                    {
                        adm.EliminarOperacion(obj, TieneGasto, objcuenta);
                        ActualizarGrillaCreditos();
                        lbl_saldo.Text = objcuenta.Saldo.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_DarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_Creditos.SelectedRows.Count == 0)
                {
                    adm.DarBajaoAlta(((Crecibo_debito)dgrid_Debitos.CurrentRow.DataBoundItem), objcuenta, vertodos);
                    ActualizarGrillaDebitos();
                }
                else
                {
                    adm.DarBajaoAlta(((Cpago_credito)dgrid_Creditos.CurrentRow.DataBoundItem), objcuenta, vertodos);
                    ActualizarGrillaCreditos();
                }
                lbl_saldo.Text = objcuenta.Saldo.ToString();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_VerTodo_Click(object sender, EventArgs e)
        {
            try
            {
                if (vertodos)
                {
                    adm.SacarBajas(objcuenta);
                    btn_DarBajaTodos.Visible = true;
                    btn_DarBaja.Text = "   Dar de baja";
                    btn_VerTodo.Text = "Ver Todos";
                    vertodos = false;
                }
                else
                {
                    adm.CargarBajasDebitosyCreditos(objcuenta);
                    btn_VerTodo.Text = "Ver actuales";
                    btn_DarBaja.Text = "  Dar de alta";
                    btn_DarBajaTodos.Visible = false;
                    vertodos = true;
                }
                ActualizarGrillaCreditos();
                ActualizarGrillaDebitos();
                Frm_cuenta_corriente_Activated(sender, e);
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }

        }
        private void btn_DarBajaTodos_Click(object sender, EventArgs e)
        {
            if (objcuenta.Creditos.Count == 0 && objcuenta.Debitos.Count == 0)
            {
                Frm_confirmacion frm = new Frm_confirmacion("No hay debitos o creditos para dar de baja", "Sin operaciones en la cuenta", "Aceptar");
                frm.ShowDialog();
            }
            else
            {
                adm.DarTodasDeBaja(objcuenta);
                ActualizarGrillaCreditos();
                ActualizarGrillaDebitos();
                Frm_cuenta_corriente_Activated(sender, e);
            }
        }
        private void lbl_saldo_TextChanged(object sender, EventArgs e)
        {
            decimal saldo = Convert.ToDecimal(lbl_saldo.Text);
            if(saldo<0)
                lbl_saldo.ForeColor = Color.FromArgb(255, 79, 79);
            else
                lbl_saldo.ForeColor = Color.FromArgb(73, 216, 69);
        }

        private void rb_credito_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_credito.Checked)
                if (proveedor)
                {
                    cb_afecta_caja.Text = "Generar gasto en caja";
                    cb_afecta_caja.Show();
                    dgrid_Creditos.Enabled = false;
                    dgrid_Debitos.Enabled = true;
                }
                else
                {
                    cb_afecta_caja.Hide();
                    dgrid_Creditos.Enabled = false;
                    dgrid_Debitos.Enabled = false;
                    LimpiarSeleccionados();
                }
            else
            {
                if (!proveedor)
                {
                    dgrid_Creditos.Enabled = true;
                    dgrid_Debitos.Enabled = false;
                    cb_afecta_caja.Text = "Generar cobro en caja";
                    cb_afecta_caja.Show();
                }
                else
                {
                    cb_afecta_caja.Hide();
                    dgrid_Creditos.Enabled = false;
                    dgrid_Debitos.Enabled = false;
                    LimpiarSeleccionados();
                }
            }
        }

        private void cb_afecta_caja_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cb_afecta_caja.Checked)
            {

                if (ObjCajaDiaria == null)
                {
                    cb_afecta_caja.Checked = false;
                    tt_general.Show("Debe abrir una caja para registrar la operacion", pn_abm, cb_afecta_caja.Location.X, cb_afecta_caja.Location.Y - 30, 3000);
                }
                else
                {
                    bs_formas.ResetBindings(false);
                    bs_formas.DataSource= admforma.VerLista();
                    bs_formas.Remove(admforma.BuscarPorID(2));
                    List<int> columnas= new List<int>();
                    columnas.Add(0);columnas.Add(2);columnas.Add(3);columnas.Add(4);columnas.Add(5);
                    Frm_Eleccion frm= new Frm_Eleccion("Forma de pago","la forma de pago",bs_formas,columnas,"");
                    frm.ShowDialog();
                    if (frm.ObjRespuesta == null)
                        forma = admforma.BuscarPorID(1);
                    else
                        forma = (Cforma_pago)frm.ObjRespuesta;
                    lbl_formaPago.Text = forma.Descripcion;
                }
            }
            lbl_formaPago.Visible = cb_afecta_caja.Checked;
        }
        private void dgrid_Creditos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_Creditos.SelectedRows.Count > 0)
            {
                Cpago_credito objcred = ((Cpago_credito)dgrid_Creditos.CurrentRow.DataBoundItem);
                if (!proveedor)
                {
                    decimal pagado = 0;
                    foreach (Crecibo_debito aux in objcuenta.Debitos)
                    {
                        if (aux.Creditos() != null)
                       {
                            if (aux.Creditos().Contains(objcred))
                                pagado += aux.Importe;
                        }
                    }
                    L_Incial.Text = objcred.Importe.ToString();
                    L_Pagado.Text = pagado.ToString();
                    L_APagar.Text = (objcred.Importe - pagado).ToString();
                }
                if (ModoModificacion)
                {
                    if (LCreditos.Contains(objcred))
                    {
                        dgrid_Creditos.CurrentRow.Cells["Concepto"].Style.BackColor = Color.FromArgb(64, 64, 64);
                        dgrid_Creditos.CurrentRow.Cells["Importe"].Style.BackColor = Color.FromArgb(64, 64, 64);
                        txt_concepto.Text = txt_concepto.Text.Replace( objcred.Concepto+", ", "");
                        if (LCreditos.Count == 2)
                            txt_importe.Enabled = true;
                        total -= Convert.ToDecimal(L_APagar.Text);
                        txt_importe.Text = total.ToString();
                        LCreditos.Remove(objcred);
                    }
                    else
                    {
                        dgrid_Creditos.CurrentRow.Cells["Concepto"].Style.BackColor = Color.FromArgb(240, 194, 70);
                        dgrid_Creditos.CurrentRow.Cells["Importe"].Style.BackColor = Color.FromArgb(240, 194, 70);
                        txt_concepto.Text = txt_concepto.Text + objcred.Concepto+", " ;
                        if (LCreditos.Count < 1)
                        {
                            total =Convert.ToDecimal(L_APagar.Text);
                            ApagarDelprimero = total;
                        }
                        else if (LCreditos.Count == 1)
                        {
                            txt_importe.Enabled = false;
                            total += Convert.ToDecimal(L_APagar.Text);
                        }
                        else
                        {
                            total += Convert.ToDecimal(L_APagar.Text);
                        }
                        LCreditos.Add(objcred);
                        txt_importe.Text = total.ToString();
                    }
                    dgrid_Creditos.ClearSelection();
                }
                else
                {
                    dgrid_Debitos.ClearSelection();
                    btn_Eliminar.Enabled = true;
                    btn_Modificar.Enabled = true;   
                    if (vertodos)
                        if (!objcred.AltaOp())
                            btn_DarBaja.Enabled = true;
                        else
                            btn_DarBaja.Enabled = false;
                    else
                    {
                        btn_DarBaja.Enabled = true;
                    }
                }

            }
        }
        private void dgrid_Debitos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_Debitos.SelectedRows.Count > 0)
            {
                Crecibo_debito obj = ((Crecibo_debito)dgrid_Debitos.CurrentRow.DataBoundItem);
                if (proveedor)
                {
                    decimal pagado = 0;
                    foreach (Cpago_credito aux in objcuenta.Creditos)
                    {
                        if (aux.Recibos() != null)
                        {
                            if (aux.Recibos().Contains(obj))
                                pagado += aux.Importe;
                        }
                    }
                    L_Incial.Text = obj.Importe.ToString();
                    L_Pagado.Text = pagado.ToString();
                    L_APagar.Text = (obj.Importe - pagado).ToString();
                }
                if (ModoModificacion)
                {   
                    if (LRecibos.Contains(obj))
                    {
                        dgrid_Debitos.CurrentRow.Cells["Concepto"].Style.BackColor = Color.FromArgb(64, 64, 64);
                        dgrid_Debitos.CurrentRow.Cells["Importe"].Style.BackColor = Color.FromArgb(64, 64, 64);
                        txt_concepto.Text = txt_concepto.Text.Replace(obj.Concepto+", ", "");
                        if (LRecibos.Count == 2)
                            txt_importe.Enabled = true;
                        txt_importe.Text = (Convert.ToDecimal(txt_importe.Text) - Convert.ToDecimal(L_APagar.Text)).ToString();
                        LRecibos.Remove(obj);
                    }
                    else
                    {
                        dgrid_Debitos.CurrentRow.Cells["Concepto"].Style.BackColor = Color.FromArgb(240, 194, 70);
                        dgrid_Debitos.CurrentRow.Cells["Importe"].Style.BackColor = Color.FromArgb(240, 194, 70);
                        txt_concepto.Text = txt_concepto.Text + obj.Concepto+", ";
                        if (LRecibos.Count < 1)
                        {
                            txt_importe.Text = "0";
                            ApagarDelprimero = Convert.ToDecimal(L_APagar.Text);
                        }
                        else if (LRecibos.Count == 1)
                        {
                            txt_importe.Text = ApagarDelprimero.ToString();
                            txt_importe.Enabled = false;
                        }
                        txt_importe.Text = (Convert.ToDecimal(txt_importe.Text) + Convert.ToDecimal(L_APagar.Text)).ToString();
                        LRecibos.Add(obj);
                    }
                    dgrid_Debitos.ClearSelection();
                }
                else
                {
                
                    dgrid_Creditos.ClearSelection();
                    btn_Eliminar.Enabled = true;
                    btn_Modificar.Enabled = true;
                    if (vertodos)
                        if (!obj.AltaOp())
                            btn_DarBaja.Enabled = true;
                        else
                            btn_DarBaja.Enabled = false;
                    else
                    {
                        btn_DarBaja.Enabled = true;
                    }
                    
                }
            }
        }
        private void dgrid_Creditos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
               
                if (dgrid_Creditos.SelectedRows.Count > 0 && !proveedor)
                {
                    int cal = (dgrid_Creditos.Rows[0].Height * (dgrid_Creditos.Rows.Count)) + 28;
                    if (cal > e.Location.Y && e.Location.Y > 28)
                    {
                        Cpago_credito ocredito = (Cpago_credito)dgrid_Creditos.CurrentRow.DataBoundItem;
                        Cventa oVenta= ocredito.Venta();
                        if (oVenta != null)
                        {
                            if (oVenta.Items().Count==0)
                            {
                                Ctrl_Ventas admventa = Ctrl_Ventas.ClaseActiva();
                                admventa.CargarItems(oVenta, ocredito.ID_Caja_Diaria());
                            }
                            string argumento = "Forma de pago : " + oVenta.Pago.FormaPago + "\nDesc/Rec : $ " + oVenta.Pago.Descuento + "\nImporte : $ " + oVenta.Pago.Importe;
                            if (oVenta.Pago2 != null)
                                argumento = argumento + "\nForma de pago 2 : " + oVenta.Pago2.FormaPago + "\nDesc/Rec : $ " + oVenta.Pago2.Descuento + "\nImporte : $ " + oVenta.Pago2.Importe;
                            Ctrl_cajas_diarias ctrl = Ctrl_cajas_diarias.ClaseActiva();
                            Frm_Items frm = new Frm_Items(argumento, oVenta,ctrl.BuscarCajaDiaria( ocredito.ID_Caja_Diaria()),ocredito.Fecha);
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void dgrid_Debitos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgrid_Debitos.SelectedRows.Count > 0 && proveedor)
                {
                    int cal = (dgrid_Debitos.Rows[0].Height * (dgrid_Debitos.Rows.Count)) + 28;
                    if (cal > e.Location.Y && e.Location.Y > 28)
                    {
                        Crecibo_debito orecibo = (Crecibo_debito)dgrid_Debitos.CurrentRow.DataBoundItem;
                        Ccompra oCompra= orecibo.Compra();
                        if (oCompra != null)
                        {
                            if (oCompra.Lista() == null)
                            {
                                Ctrl_compras adm = Ctrl_compras.ClaseActiva();
                                adm.CargarItems(oCompra);
                            }
                            string argumento = "Forma de pago : " + oCompra.Forma_Pago + "\nDesc/Rec : $" + oCompra.Descuento + "\nImporte : $ " + oCompra.Total;
                            Frm_Items frm = new Frm_Items(argumento,oCompra);
                            frm.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void txt_importe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(txt_importe.Text) < 0)
                    txt_importe.Text = "0";
                else
                {
                    if (proveedor)
                    {
                        if (LRecibos.Count == 1)
                        {
                            if (Convert.ToDecimal(txt_importe.Text) > ApagarDelprimero)
                                txt_importe.Text = ApagarDelprimero.ToString();
                        }
                    }
                    else
                    {
                        if (LCreditos.Count == 1)
                        {
                            if (Convert.ToDecimal(txt_importe.Text) > ApagarDelprimero)
                                txt_importe.Text = ApagarDelprimero.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }

        }
        

        private void btn_Liquidacion_Click(object sender, EventArgs e)
        {
            btn_Agregar_Click(sender, e);
            SeleccionarTodos();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            if (proveedor)
            {
                Reportes.R_Cuenta_Proveedor frm = new Reportes.R_Cuenta_Proveedor (objpersona);
                frm.Show();
            }
            else
            {
                Reportes.R_Cuenta_Clie_Usu frm = new Reportes.R_Cuenta_Clie_Usu(objpersona);
                frm.Show();
            }
        }

        private void L_Incial_TextChanged(object sender, EventArgs e)
        {
            if (L_Incial.Text == "0")
            {
                L_Pagado.Text = "0";
                L_APagar.Text = "0";
            }
        }

        private void btn_actualizarSaldo_Click(object sender, EventArgs e)
        {
            try
            {
                adm.ActualizarInflacionDeCreditos(objcuenta);
                lbl_saldo.Text = objcuenta.Saldo.ToString();
                ActualizarGrillaCreditos();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_cuenta_corriente_Shown(object sender, EventArgs e)
        {
            btn_Cancelar.PerformClick();
        }

        private void p_grillas_Resize(object sender, EventArgs e)
        {
            p_grillaIzq.Width = p_grillas.Width / 2;
        }
    }
}
