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
    public partial class Frm_ABM_compras : SIVS.Frm_ABM
    {
        static Frm_ABM_compras frmCompras;
        Ctrl_compras adm = Ctrl_compras.ClaseActiva();
        Ctrl_articulos admArt = Ctrl_articulos.ClaseActiva();
        Ctrl_formas_pagos admformaspagos = Ctrl_formas_pagos.ClaseActiva();
        Ctrl_proveedores admproveedores = Ctrl_proveedores.ClaseActiva();
        Ctrl_cuentas_corrientes admCuentas= Ctrl_cuentas_corrientes.ClaseActiva();
        Ctrl_medidas admMedidas = Ctrl_medidas.ClaseActiva();
        Ctrl_rubros admrubro = Ctrl_rubros.ClaseActiva();
        Carticulo oArt;
        Ccompra oCompra;
        Ccompra oCompraOriginal;
        Cmedida oMedida;
        bool modificacion = false;
        bool calcular = false;
        bool bucleCosto = false;
        bool bucleImpuestos = false;
        bool buclePorcentaje = false;

        public Frm_ABM_compras()
        {
            InitializeComponent();
        }
        public static Frm_ABM_compras AbrirForm()
        {
            if ((frmCompras == null) || (frmCompras.IsDisposed))
            {
                frmCompras = new Frm_ABM_compras();
            }
            frmCompras.Focus();
            return frmCompras;
        }
        private void Frm_ABM_compras_Load(object sender, EventArgs e)
        {
            if (Width != 1000)
            {
                Width = 1000;
                pn_btnDerechos.Visible = false;
                admArt.CargarNoVigentes();
                ActualizarProveddores();
                ActualizarCompras();
                ActualizarRubros();
                ActualizarFormasPagos();
                ActualizarMedidas();
                p_articulo.Visible = false;
                txt_IVA.Text = Form1.objConf.IVA.ToString();
                txt_IVA.TextDefault = txt_IVA.Text;
                if (cb_proveedor.Items.Count == 0)
                    cb_ConProveedor.Checked = false;
            }
        }
        private void ActualizarItems()
        {
            bs_Items.ResetBindings(false);
            bs_Items.DataSource = oCompra.Lista();
            dgrid_Items.DataSource = bs_Items;
            dgrid_Items.Columns[2].HeaderText = "Costo_Uni";
        }
        private void ActualizarRubros()
        {
            bs_rubros.ResetBindings(false);
            bs_rubros.DataSource = admrubro.VerLista();
            cb_Rubro.DataSource = bs_rubros;
            cb_Rubro.DisplayMember = "Nombre";
        }
        private void ActualizarMedidas()
        {
            bs_medidas.ResetBindings(false);
            bs_medidas.DataSource = admMedidas.VerLista();
            cb_medidas.DataSource = bs_medidas;
            cb_medidas.DisplayMember = "Nombre";
        }
        private void ActualizarCompras()
        {
            bs_Compras.ResetBindings(false);
            bs_Compras.DataSource = adm.VerLista();
            dgrid_compras.DataSource = bs_Compras;
            dgrid_compras.Columns[0].Visible=false;
        }
        private void ActualizarProveddores()
        {
            bs_Proveedores.ResetBindings(false);
            bs_Proveedores.DataSource = admproveedores.VerLista();
            cb_proveedor.DataSource = bs_Proveedores;
            cb_proveedor.DisplayMember = "Nombre";
        }
        private void ActualizarFormasPagos()
        {
            bs_FormasDePago.ResetBindings(false);
            bs_FormasDePago.DataSource = admformaspagos.VerLista();
            cb_formaPago.DataSource = bs_FormasDePago;
            cb_formaPago.DisplayMember = "Descripcion";
        }
        private bool NoAceptadoParaDecimal(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            String Aceptados = "0123456789," + Convert.ToChar(8);
            if (Aceptados.Contains("" + e.KeyChar))
                return false;
            return true;
        }
        private bool NoAceptadoParaEnteros(KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            String Aceptados = "0123456789" + Convert.ToChar(8);
            if (Aceptados.Contains("" + e.KeyChar))
                return false;
            return true;
        }
        private void Cerrar()
        {
            p_derecho.Padding = new Padding(8, 0, 0, 0);
            p_derecho.Dock = DockStyle.Right;
            p_articulo.Visible = false;
            gb_abm.Enabled = true;
            gb_abm.Visible = true;

            pn_btnDerechos.Visible = false;
            pn_btnABM.Visible = true;

            gb_abm.Visible = true;
            p_articulo.Visible=false;
            modificacion = false;
            dgrid_compras.ClearSelection();
            oCompraOriginal = null;
        }
        private void Abrir()
        {
            p_derecho.Padding = new Padding(0, 0, 8, 0);
            modificacion = true;
            gb_abm.Enabled = false;
            gb_abm.Visible = false;
            pn_btnDerechos.Visible = true;
            pn_btnABM.Visible = false;

            p_articulo.Visible = true;
            gb_abm.Visible = false ;
            p_derecho.Dock = DockStyle.Fill;
            if (oCompraOriginal == null)
            {
                lbl_Subtotal.Text = "0";
                txt_descuento.Text = "0";
            }
            p_articulo.Visible = true;
        }
        #region EVENTOS CLIK
        protected override  void btn_Agregar_Click(object sender, EventArgs e)
        {
            Abrir();
            dtp_fecha.Value = DateTime.Today;
            oCompra= new Ccompra(0,0,0,DateTime.Today,(Cforma_pago)cb_formaPago.SelectedItem);
            cb_formaPago.Text = admformaspagos.BuscarPorID(1).Descripcion;
            ActualizarItems();
        }
        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            oCompraOriginal = oCompra.Clonar();
            Abrir();
        }
        override protected void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (dgrid_Items.Rows.Count == 0)
                Cerrar();
            else
            {
                Frm_confirmacion frm = new Frm_confirmacion("¿Seguro que quiere perder todos los registros de articulos?", "Compra actual", "No", "Si");
                frm.ShowDialog();
                if (frm.RESPUESTA == "Si")
                {
                    dgrid_Items.Rows.Clear();
                    Cerrar();

                }
            }
            
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (dgrid_Items.Rows.Count > 0)
            {
                oCompra.Descuento = Convert.ToDecimal(txt_descuento.Text);
                oCompra.Total = Convert.ToDecimal(txt_total.Text);
                oCompra.Fecha = dtp_fecha.Value;
                if (oCompraOriginal == null)
                {
                    adm.Agregar(oCompra);
                    adm.GuardarItems(oCompra);
                    if (cb_ConProveedor.Checked)
                    {
                        Cproveedor opro = (Cproveedor)cb_proveedor.SelectedItem;
                        adm.ReferenciarConProveedor(oCompra, opro);
                        if (oCompra.FormaPagoDevolver().ID == 2)
                        {
                            admCuentas.CargarAltasDebitosyCreditos(opro.DevolverCuentaCorriente());
                            Crecibo_debito objdebito = new Crecibo_debito("Compra numero: " + oCompra.Id + " de la fecha: " + oCompra.Fecha.ToShortDateString(), oCompra.Total, DateTime.Today, true);
                            admCuentas.AgregarOperacion(objdebito, opro.DevolverCuentaCorriente());
                            admCuentas.AgregarReferiaEntreOperacion(objdebito, oCompra);
                        }
                    }
                }
                else
                {
                    adm.Modificar(oCompra);
                    adm.ModificarItems(oCompraOriginal,oCompra);
                    
                    if (cb_ConProveedor.Checked)
                    {
                        Cproveedor opro = (Cproveedor)cb_proveedor.SelectedItem;
                        if (oCompraOriginal.Proveedor != null)
                        {
                            adm.EliminarReferenciaProveedor(oCompraOriginal);
                        }
                        adm.ReferenciarConProveedor(oCompra, opro);
                        if (oCompra.FormaPagoDevolver().ID == 2)
                        {
                            admCuentas.CargarAltasDebitosyCreditos(opro.DevolverCuentaCorriente());
                            Crecibo_debito objdebito = new Crecibo_debito("Compra numero: " + oCompra.Id + " de la fecha: " + oCompra.Fecha.ToShortDateString(), oCompra.Total, DateTime.Today, true);
                            admCuentas.AgregarOperacion(objdebito, opro.DevolverCuentaCorriente());
                            admCuentas.AgregarReferiaEntreOperacion(objdebito, oCompra);
                        }
                    }
                    else{
                        if (oCompraOriginal.Proveedor != null)
                        {
                            adm.EliminarReferenciaProveedor(oCompraOriginal);
                            if (oCompraOriginal.Forma_Pago.ID == 2)
                            {
                                admCuentas.CargarAltasDebitosyCreditos(oCompraOriginal.Proveedor.DevolverCuentaCorriente());
                            }

                        }
                    }
                }
                
                Cerrar();
                ActualizarCompras();
                oCompra = null;
                Frm_confirmacion frmconf = new Frm_confirmacion("Operacion realizada exitosamente!", "Compra", "Aceptar");
                frmconf.ShowDialog();
            }
            else
            {
                Frm_confirmacion frmconf = new Frm_confirmacion("No hay articulos en la lista", "Compra", "Aceptar");
                frmconf.ShowDialog();
            }
        }
        private void btn_buscarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ABM_articulos frm = new Frm_ABM_articulos(true, true);
                frm.ShowDialog();
                if (frm.oArt != null)
                    txt_codigo.Text = frm.oArt.Codigo.ToString();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_confirmacion frm = new Frm_confirmacion("Eliminar la compra decrementará la existencia (Stock) de los articulos que contenga la misma.\nDesea eliminar esta compra?", "Confirmación de eliminación", "No", "Si");
                frm.ShowDialog();
                if (frm.RESPUESTA == "Si")
                {
                    oCompra = (Ccompra)dgrid_compras.CurrentRow.DataBoundItem;
                    if (oCompra.FormaPagoDevolver().ID == 2)
                    {
                        Cproveedor opro = oCompra.Proveedor;
                        if (opro != null)
                        {
                            Crecibo_debito orecibo = admCuentas.BuscarDeCompra(opro.DevolverCuentaCorriente(), oCompra);
                            if (orecibo != null)
                            {
                                frm = new Frm_confirmacion("La compra tiene referencia con debito de la cuenta corriente del proveedor. Quiere eliminar el debito de la cuenta corriente?", "Referencias con cuentas", "No", "Si");
                                admCuentas.EliminarRefOperacion(orecibo, "[COMPRAS-DEBITOS]");
                                if (frm.RESPUESTA == "Si")
                                {
                                    admCuentas.EliminarOperacion(orecibo, admCuentas.TieneCobro(orecibo), opro.DevolverCuentaCorriente());
                                }
                            }
                        }
                    }
                    foreach (Citem aux in oCompra.Lista())
                    {
                        adm.EquilibrarArticuloDeUnaEliminacion(aux);
                    }
                    adm.Eliminar(oCompra);
                    ActualizarCompras();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_AgregarItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_codigo.Text == "")
                {
                    throw new Exception("Tiene que elegir un artículo para agregarlo.");
                }
                Crubro orubro = (Crubro)cb_Rubro.SelectedItem;
                Cmedida omedida = (Cmedida)cb_medidas.SelectedItem;
                if (oArt == null)
                {
                    oArt = new Carticulo(txt_codigo.Text, txt_descripcion.Text, Convert.ToDecimal(txt_precio.Text), Convert.ToDecimal(txt_costoUnitario.Text), 0m, orubro, omedida, Convert.ToDecimal(txt_IVA.Text), txt_nota.Text,Convert.ToDecimal(txt_cantAlta.Text),Convert.ToDecimal(txt_cantMedia.Text),Convert.ToDecimal(txt_cantBaja.Text));
                    admArt.Agregar(oArt);
                }
                else
                {
                    oArt = new Carticulo(oArt.Codigo, oArt.Descripcion, Convert.ToDecimal(txt_precio.Text), Convert.ToDecimal(txt_costoPonderado.Text), oArt.Stock, orubro, omedida, Convert.ToDecimal(txt_IVA.Text), txt_nota.Text, Convert.ToDecimal(txt_cantAlta.Text), Convert.ToDecimal(txt_cantMedia.Text), Convert.ToDecimal(txt_cantBaja.Text));
                }
                Citem oitem=new Citem(oArt, Convert.ToDecimal(txt_cantidad.Text), Convert.ToDecimal(txt_costoUnitario.Text));
                if (oCompra.EstaEnLista(oitem))
                {
                    Frm_confirmacion frm = new Frm_confirmacion("El artículo ya esta en la compra, desea sumarle la cantidad ingresada a la compra?", "Artículo en compra", "No", "Si");
                    frm.ShowDialog();
                    if (frm.RESPUESTA != null)
                    {
                        if (frm.RESPUESTA == "Si")
                        {
                            oCompra.AgregarAExistente(oitem);
                        }
                    }
                }
                else
                {
                    oCompra.Agregar(oitem);
                }
                txt_codigo.Text = "";
                txt_descripcion.Clear();
                txt_nota.Clear();
                ActualizarItems();
                lbl_Subtotal.Text = oCompra.Subtotal.ToString();
                txt_codigo.Focus();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_AgregarNota_Click(object sender, EventArgs e)
        {
            if (txt_nota.Visible)
            {
                txt_nota.Visible = false;
                lbl_Nota_Registros.Text = "Registros Actuales";
            }
            else
            {
                lbl_Nota_Registros.Text = "Nota para este artículo";
                txt_nota.Visible = true;
                txt_nota.Focus();
            }
        }
        private void lbl_proveedor_Click(object sender, EventArgs e)
        {
            Frm_ABM_proveedores frm = new Frm_ABM_proveedores();
            frm.ShowDialog();
            ActualizarProveddores();
        }
        private void cb_formaPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (modificacion)
                {
                    Cforma_pago oforma = (Cforma_pago)cb_formaPago.SelectedItem;
                    if (oforma != null)
                    {
                        if (oforma.ID == 2)
                        {
                            cb_ConProveedor.Checked = true;

                            if (cb_ConProveedor.Checked)
                                oCompra.FormaPagoCambiar(oforma);
                            else
                                cb_formaPago.Text = admformaspagos.BuscarPorID(1).Descripcion;
                        }
                        else
                            oCompra.FormaPagoCambiar(oforma);

                    }
                }
                else
                {
                    if(oCompra!=null)
                        cb_formaPago.Text = oCompra.Forma_Pago.Descripcion;
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        #endregion 
        //COMBO BOX Y CHECK BOX
        private void cb_proveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (modificacion)
                {
                    Cproveedor opro = (Cproveedor)cb_proveedor.SelectedItem;
                    if (opro != null)
                    {
                        Ccuenta_corriente ocuenta = opro.DevolverCuentaCorriente();
                        if (ocuenta.Creditos == null)
                            admCuentas.CargarAltasDebitosyCreditos(ocuenta);
                    }
                }
                else
                {
                    if (oCompra != null)
                    {
                        if (oCompra.Proveedor != null)
                            cb_proveedor.Text = oCompra.Proveedor.Nombre;

                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void cb_medidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            oMedida = (Cmedida)cb_medidas.SelectedItem;
        }
        private void cb_ConProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (modificacion)
            {
                if (cb_ConProveedor.Checked)
                {
                    if (cb_proveedor.Items.Count == 0)
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("No hay proveedores para seleccionar. \nQuiere agregar uno?", "Proveedores", "No", "Si");
                        frm.ShowDialog();
                        if (frm.RESPUESTA == "Si")
                        {
                            Frm_ABM_proveedores frmpro = Frm_ABM_proveedores.AbrirForm();
                            frmpro.ShowDialog();
                            ActualizarProveddores();
                            if (cb_proveedor.Items.Count == 0)
                                cb_proveedor.Visible = true;
                            else
                                cb_ConProveedor.Checked = false;
                        }
                        else
                            cb_ConProveedor.Checked = false;
                    }
                    else
                    {
                        cb_proveedor.Visible = true;
                    }
                }
                else
                {
                    cb_proveedor.Visible = false;
                    if (oCompra != null)
                    {
                        if (oCompra.FormaPagoDevolver().ID == 2)
                            cb_formaPago.Text = admformaspagos.BuscarPorID(1).Descripcion;
                    }
                }
            }
            else
            {
                if (oCompra != null)
                {
                    if (oCompra.Proveedor != null)
                        cb_ConProveedor.Checked = true;
                    else
                        cb_ConProveedor.Checked = false;
                }
            }
        }
        //GRILLA
        private void dgrid_Items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (modificacion)
            {
                if (dgrid_Items.SelectedRows.Count > 0)
                {
                    
                    int cal = (dgrid_Items.Rows[0].Height * (dgrid_Items.Rows.Count)) + 28;
                    if (cal > e.Location.Y && e.Location.Y > 28)
                    {
                        Citem oitem= (Citem)dgrid_Items.CurrentRow.DataBoundItem;
                        Frm_confirmacion frm = new Frm_confirmacion("Seguro que quiere borrar de la compra el artículo "+oitem.Articulo.Descripcion + " ?", "Confirmación de borrar", "No", "Si");
                        frm.ShowDialog();
                        if (frm.RESPUESTA == "Si")
                        {
                            oCompra.Eliminar(oitem);
                            ActualizarItems();
                            lbl_Subtotal.Text = oCompra.Subtotal.ToString();
                        }
                    }
                }
            }
        }
        private void dgrid_compras_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_compras.CurrentRow != null)
            {
                oCompra = (Ccompra)dgrid_compras.CurrentRow.DataBoundItem;
                if (oCompra.Lista().Count == 0)
                    adm.CargarItems(oCompra);
                ActualizarItems();
                lbl_Subtotal.Text = oCompra.Subtotal.ToString();
                txt_descuento.Text = oCompra.Descuento.ToString();
                cb_formaPago.Text = oCompra.FormaPagoDevolver().Descripcion;
                dtp_fecha.Value = oCompra.Fecha;
                if (oCompra.Proveedor == null)
                    cb_ConProveedor.Checked = false;
                else
                {
                    cb_ConProveedor.Checked = true;
                    cb_proveedor.Text = oCompra.Proveedor.ToString();
                }
            }
        }
        // TEXTBOX
        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
                oArt = admArt.BuscarEnVigentes(txt_codigo.Text);
                if (oArt == null)
                    oArt = admArt.BuscarEnNoVigentes(txt_codigo.Text);
                if (oArt != null)
                {
                    cb_Rubro.SelectedItem = oArt.Rubro;
                    cb_medidas.SelectedItem = oArt.Unidad_Medida;
                    lbl_cantHistorica.Text = adm.CantidadHistorica(oArt).ToString();
                    txt_nota.Text = oArt.Nota;
                    txt_stock.Text = oArt.Stock.ToString();
                    txt_costoPonderado.Text = oArt.Costo.ToString();
                    txt_descripcion.Text = oArt.Descripcion;
                    lbl_ActualCosto.Text = oArt.Costo.ToString();
                    lbl_ActualPrecio.Text = oArt.Precio.ToString();
                    txt_cantBaja.Text = oArt.CantBaja.ToString();
                    txt_cantMedia.Text = oArt.CantMedia.ToString();
                    txt_cantAlta.Text = oArt.CantAlta.ToString();
                    txt_IVA.Text = oArt.Iva.ToString();
                    calcular = true;
                    buclePorcentaje = true;
                    bucleCosto = true;
                    bucleImpuestos = true;
                    txt_costoUnitario.Text = lbl_ActualCosto.Text;
                    calcular = true;

                    buclePorcentaje = true;
                    bucleCosto = true;
                    txt_precio.Text = lbl_ActualPrecio.Text;
                }
                else
                {
                    if (txt_descripcion.Text != "")
                    {
                        txt_descripcion.Clear();
                        txt_stock.Text = "0";
                        lbl_ActualCosto.Text = "0";
                        lbl_ActualPrecio.Text = "0";
                        lbl_cantHistorica.Text = "0";
                        txt_costoPonderado.Text = txt_costoUnitario.Text;
                        txt_nota.Clear();
                    }
                }
            
        }
        //private void txt_cantidad_TextChanged(object sender, EventArgs e)
        //{
        //        if(txt_cantidad.Text!="")
        //            txt_costoTotal.Text = (Convert.ToDecimal(txt_costoUnitario.Text) * Convert.ToDecimal(txt_cantidad.Text)).ToString();
        //}
        private void txt_cantidad_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.SelectAll();
        }
        private void txt_nuevoCosto_TextChanged(object sender, EventArgs e)
        {
            try{
                if(Convert.ToDecimal(txt_cantidad.Text) <= 0)
                    throw new Exception("La cantidad no puede ser 0");
                if (txt_costoUnitario.Text == "")
                    txt_costoUnitario.Text = lbl_ActualCosto.Text;
                else
                {
                    if (calcular)
                    {
                        if (oArt != null)
                        {
                            decimal cant = 0;
                            if (lbl_cantHistorica.Text == "0")
                                cant = Convert.ToDecimal(txt_stock.Text);
                            else
                                cant = Convert.ToDecimal(lbl_cantHistorica.Text);
                            decimal cal = (Convert.ToDecimal(lbl_ActualCosto.Text) * cant) + (Convert.ToDecimal(txt_costoUnitario.Text) * Convert.ToDecimal(txt_cantidad.Text));
                            cal = (cal / (Convert.ToDecimal(txt_cantidad.Text) + cant));
                            txt_costoPonderado.Text = Math.Round(cal, 2).ToString();
                        }
                        else
                            txt_costoPonderado.Text = txt_costoUnitario.Text;
                        if (bucleImpuestos)
                        {
                            bucleImpuestos = false;
                            calcular = false;
                            decimal costoConImp = Convert.ToDecimal(txt_costoUnitario.Text);
                            decimal imp = Convert.ToDecimal(txt_imp.Text);
                            decimal iva = Convert.ToDecimal(txt_IVA.Text);
                            if (iva != 0m)
                            {
                                iva = (iva / 100) + 1;
                                costoConImp = costoConImp / iva;
                            }
                            if (imp != 0m)
                            {
                                imp = (imp / 100) + 1;
                                txt_costoSinImp.Text = Math.Round((costoConImp / imp), 2).ToString();
                            }
                            else
                                txt_costoSinImp.Text = Math.Round(costoConImp, 2).ToString();
                        }

                        if (bucleCosto)
                        {
                            bucleCosto = false;
                            txt_costoTotal.Text = (Convert.ToDecimal(txt_cantidad.Text) * Convert.ToDecimal(txt_costoUnitario.Text)).ToString();
                        }
                    }
                }
            }
            catch(Exception ex){
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }

        }
        private void txt_nuevoPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_precio.Text == "")
                    txt_precio.Text = lbl_ActualPrecio.Text;
                else
                {
                    if (calcular)
                    {
                        calcular = false;
                        if (buclePorcentaje)
                        {
                            buclePorcentaje = false;
                            decimal costo = Convert.ToDecimal(txt_costoUnitario.Text);
                            if (costo != 0)
                            {
                                decimal precio = Convert.ToDecimal(txt_precio.Text);
                                //decimal costo = Convert.ToDecimal(txt_costoPonderado.Text);

                                decimal porcenaje = (precio - costo) * (100 / costo);
                                txt_PorcGanancia.Text = Math.Round(porcenaje, 2).ToString();
                            }
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
        private void txt_costoTotal_TextChanged(object sender, EventArgs e)
        {
            if (calcular)
            {
                try
                {
                    if (bucleCosto)
                    {
                        decimal cal = (Convert.ToDecimal(txt_costoTotal.Text) / Convert.ToDecimal(txt_cantidad.Text));
                        bucleCosto = false;
                        txt_costoUnitario.Text = Math.Round(cal, 2).ToString();
                    }
                }
                catch(Exception ex) {
                    Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                    frm.ShowDialog();
                }
            }
        }
        private void txt_descuento_TextChanged(object sender, EventArgs e)
        {
            if (txt_descuento.Text == "")
                txt_descuento.Text = "0";
            txt_total.Text = (Convert.ToDecimal(lbl_Subtotal.Text) - Convert.ToDecimal(txt_descuento.Text)).ToString();
        }
        private void txt_total_TextChanged(object sender, EventArgs e)
        {
            if (txt_descuento.Text == "")
                txt_total.Text = (Convert.ToDecimal(lbl_Subtotal.Text) - Convert.ToDecimal(txt_descuento.Text)).ToString();
        }
        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (oMedida.Entero)
            {
                if (e.KeyChar == ',')
                    e.Handled = true;
                else
                    txt_costoUnitario_KeyPress(sender, e);
            }
            else
                txt_costoUnitario_KeyPress(sender, e);
        }
        private void txt_costoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            calcular = true;
            bucleCosto = true;
            buclePorcentaje = true;
            bucleImpuestos = true;
        }
       
        private void txt_IVA_TextChanged(object sender, EventArgs e)
        {
            if (calcular)
            {
                if (Convert.ToDecimal(txt_IVA.Text) >= 100)
                    txt_IVA.Text = "99,99";
                else
                {
                    decimal costoSinImp = Convert.ToDecimal(txt_costoSinImp.Text);
                    decimal imp = Convert.ToDecimal(txt_imp.Text);
                    decimal iva = Convert.ToDecimal(txt_IVA.Text);
                    decimal costoConImp = 0;
                    imp = (imp / 100) + 1;
                    costoConImp = costoSinImp * imp;
                    if (iva != 0m)
                    {
                        iva = (iva / 100) + 1;
                        txt_costoUnitario.Text = Math.Round((costoConImp * iva), 2).ToString();
                    }
                    else
                        txt_costoUnitario.Text = Math.Round(costoConImp, 2).ToString();
                }
            }
        }
        private void txt_PorcGanancia_TextChanged(object sender, EventArgs e)
        {
            if (calcular)
            {
                if (txt_PorcGanancia.Text != "")
                {
                    buclePorcentaje = false;
                        //ESTO ES EL CALCULO POSTA 
                    /*decimal Costoponderado=Convert.ToDecimal(txt_costoPonderado.Text);
                    decimal cal = (Convert.ToDecimal(txt_PorcGanancia.Text) * Costoponderado)/100;
                    txt_precio.Text = (Math.Round((Costoponderado+cal), 2)).ToString();*/
                    // ESTO ES PORQ A LA GENTE LE INTERESA SACAR EL PRECIO POR UN PORCENTAJE CON EL COSTO ACTUAL

                    decimal Costo = Convert.ToDecimal(txt_costoUnitario.Text);
                    decimal cal = (Convert.ToDecimal(txt_PorcGanancia.Text) * Costo)/100;
                    txt_precio.Text = (Math.Round((Costo+cal), 2)).ToString();
                }
                else
                    txt_precio.Text = "0";
            }
        }

        private void lbl_rubro_Click(object sender, EventArgs e)
        {
            Frm_ABM_rubros frm = Frm_ABM_rubros.AbrirForm();
            frm.ShowDialog();
            ActualizarRubros();
        }
        private void lbl_medida_Click(object sender, EventArgs e)
        {
            Frm_ABM_medidas frm = Frm_ABM_medidas.AbrirForm();
            frm.ShowDialog();
            ActualizarMedidas();
        }
        private void lbl_formaPago_Click(object sender, EventArgs e)
        {
            Frm_ABM_formas_pagos frm = Frm_ABM_formas_pagos.AbrirForm();
            frm.ShowDialog();
            ActualizarFormasPagos();
        }
        private void txt_descuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void dtp_fecha_ValueChanged(object sender, EventArgs e)
        {
            if (!modificacion)
            {
                if (oCompra != null)
                {
                    dtp_fecha.Value = oCompra.Fecha;
                }
            }
        }
        private void Frm_ABM_compras_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!gb_abm.Visible && dgrid_Items.Rows.Count > 0)
            {
                Frm_confirmacion frm = new Frm_confirmacion("Hay una venta en curso. Se perderan todos los registros de ella si la cierra. Quiere cerrar todo igual?", "Confirmación de cierre", "No", "Si");
                frm.ShowDialog();
                if (frm.RESPUESTA == "Si")
                {
                    oCompra = null;
                }
                else
                {
                    e.Cancel = true;
                }

            }
            else
            {
                oCompra = null;
            }

        }

        private void gb_Articulo3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_imp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_costoSinImp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_costoSinImp.Text == "")
                    txt_costoSinImp.Text = lbl_ActualCosto.Text;
                else
                {
                    if (calcular)
                    {
                        if (bucleImpuestos)
                        {
                            bucleImpuestos = false;
                            decimal costoSinImp = Convert.ToDecimal(txt_costoSinImp.Text);
                            decimal imp = Convert.ToDecimal(txt_imp.Text);
                            decimal iva = Convert.ToDecimal(txt_IVA.Text);
                            decimal costoConImp = 0;
                            imp = (imp / 100) + 1;
                            costoConImp = costoSinImp * imp;
                            if (iva != 0m)
                            {
                                iva = (iva / 100) + 1;
                                txt_costoUnitario.Text = Math.Round((costoConImp * iva), 2).ToString();
                            }
                            else
                                txt_costoUnitario.Text = Math.Round(costoConImp, 2).ToString();
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

        private void btn_verMas_Click(object sender, EventArgs e)
        {
            if (adm.CargarMas())
                btn_verMas.Enabled = false;
            ActualizarCompras();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {

        }

        private void Frm_ABM_compras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 114 && e.KeyValue < 117)
            {

                if (115 == e.KeyValue)//F5   VER MAS COMPRAS
                {
                    if (pn_btnABM.Visible && btn_verMas.Enabled && btn_verMas.Visible)
                        btn_verMas.PerformClick();
                }
                else if (116 == e.KeyValue)//F6   AGREGAR ITEM
                {
                    if (pn_btnDerechos.Visible && btn_AgregarItem.Enabled && btn_AgregarItem.Visible)
                        btn_AgregarItem.PerformClick();
                }
            }
        }

    }

}
