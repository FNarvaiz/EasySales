using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using CLASES;
using System.Threading;
using CONTROLES;
using System.Timers;
using System.Diagnostics;
using System.IO;
namespace SIVS
{
    public partial class Form1 : Form
    {
        Ctrl_cajas_diarias adm = Ctrl_cajas_diarias.ClaseActiva();
        Ctrl_clientes admclientes = Ctrl_clientes.ClaseActiva();
        Ctrl_formas_pagos admformaspagos = Ctrl_formas_pagos.ClaseActiva();
        Ctrl_medidas admMedidas = Ctrl_medidas.ClaseActiva();
        Ctrl_articulos admart;
        cImpresora _oImpresora;
        Cventa VentaActual = new Cventa(new Cpago());
        Carticulo ObjArt;
        static public Cusuario objusu;
        Ccaja_diaria ObjCajaDiaria;
        //CImpresorasFiscales oImpresora;
        static public Cconfiguracion objConf;
        bool primeraves = true;

        #region ////////////////////////////////////////////////////////////////////////////////// TOOLSTRIP MENUS

        private void cuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_cuentas_bancarias frm = Frm_ABM_cuentas_bancarias.AbrirForm();
            frm.Show();
            //Frm_confirmacion frm = new Frm_confirmacion("Esta función aún no se encuentra disponible. Disculpe las molestias, estamos trabajando para mejorar Easysales Market.", "Función no disponible", "Aceptar");
            //frm.ShowDialog();
        }

        private void ts_soporte_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com/easysoftgt");
        }

        private void ts_ControlGastos_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_Gastos frm = Frm_Tablero_Control_Gastos.AbrirForm();
            frm.Show();
        }

        private void ts_ControlRubros_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_Rubros frm = Frm_Tablero_Control_Rubros.AbrirForm();
            frm.Show();
        }

        private void ts_ControlFormasPago_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_Formas_Pago frm = Frm_Tablero_Control_Formas_Pago.AbrirForm();
            frm.Show();
        }
        private void ts_ControlStock_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control frm = Frm_Tablero_Control.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_ControlVentas_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_Ventas frm = Frm_Tablero_Control_Ventas.AbrirForm();
            frm.Show();
        }
        private void ts_ControlCtasCtes_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_CtasCtes frm = Frm_Tablero_Control_CtasCtes.AbrirForm();
            frm.Show();
        }
        private void ts_Articulos_Click(object sender, EventArgs e)
        {
            Frm_ABM_articulos frm = Frm_ABM_articulos.AbrirForm(true, objConf);
            frm.Show();
            frm.Focus();
        }
        private void ts_CajaDiaria_Click(object sender, EventArgs e)
        {
            if (ObjCajaDiaria == null)
            {
                Frm_confirmacion frm = new Frm_confirmacion("No hay caja diaria abierta.\nDesea abrirla?", "Caja diaria", "No", "Si");
                frm.ShowDialog();

                if (frm.RESPUESTA == "Si")
                {
                    btn_AbrirCaja_Click(sender, e);
                }
            }
            if (ObjCajaDiaria != null)
            {
                Frm_caja_diaria frm = Frm_caja_diaria.AbrirForm(ObjCajaDiaria, objusu);
                frm.Show();
                frm.Focus();
            }
        }
        private void ts_CuentasCorrientes_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            Frm_ABM_cuentas_corrientes frm = Frm_ABM_cuentas_corrientes.AbrirForm(ObjCajaDiaria, Convert.ToInt32(item.Tag));
            frm.Show();
            frm.Focus();
        }
        private void ts_FormasPagos_Click(object sender, EventArgs e)
        {
            Frm_ABM_formas_pagos frm = Frm_ABM_formas_pagos.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_Localidades_Click(object sender, EventArgs e)
        {
            Frm_ABM_localidades frm = Frm_ABM_localidades.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_Permisos_Click(object sender, EventArgs e)
        {
            Frm_ABM_permisos frm = Frm_ABM_permisos.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_Usuario_Click(object sender, EventArgs e)
        {
            Frm_ABM_usuarios frm = Frm_ABM_usuarios.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_Clientes_Click(object sender, EventArgs e)
        {
            Frm_ABM_clientes frm = Frm_ABM_clientes.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_Proveedores_Click(object sender, EventArgs e)
        {
            Frm_ABM_proveedores frm = Frm_ABM_proveedores.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_Cajas_Click(object sender, EventArgs e)
        {
            Frm_ABM_cajas frm = Frm_ABM_cajas.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_TableroControl_Click(object sender, EventArgs e)
        {
        }
        private void ts_medidas_Click(object sender, EventArgs e)
        {
            Frm_ABM_medidas frm = Frm_ABM_medidas.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void ts_compras_Click(object sender, EventArgs e)
        {
            Frm_ABM_compras frm = Frm_ABM_compras.AbrirForm();
            frm.Show();
            frm.Focus();
        }
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void configuracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ABM_configuraciones frm = new Frm_ABM_configuraciones(objConf);
            frm.ShowDialog();
            FormatoFormulario();
            CalcularDescuento();
            PermisosHabilitados();
        }
        #endregion

        #region ////////////////////////////////////////////////////////////////////////// IMPRESORAS FISCALES
        //public void ConfiguracionEpson(short portnum)
        //{
        //    oEpson.PortNumber = portnum;
        //    oEpson.MessagesOn = true;
        //    oEpson.BaudRate = "9600";
        //}

        //private void ConfigurarImpresora()
        //{
        //    bool tieneImpresora = true;
        //    if (tieneImpresora)
        //    {
        //        oImpresora = new CImpresorasFiscales();
        //        Int16 portnumber = 2;
        //        if (objConf.Epson_Samsung)
        //            ConfiguracionEpson(portnumber);
        //        else { }
        //        //oImpresora.ConfigurarHasar(portnumber, 1);
        //    }
        //}

        //public void ImprimirEpsonVenta(Cventa oventa)
        //{
        //    try
        //    {
        //        //int impresion = 1;
        //        bool respuesta;
        //        string completo = "G";
        //        string nomart;
        //        string cant;
        //        string precio;
        //        string iva = "2100";
        //        string qualifier = "M";
        //        string budle = "0";
        //        string porcInterno = "0";
        //        string Descripcionpago;
        //        string importe;
        //        string identificador;
        //        string adicional;
        //        string internaltax = "0";
        //        bool Porcien = false;
        //        bool importesporcien = false;
        //        bool SacarComa = true;
        //        //if (impresion == 1)
        //        //{ticket
        //        respuesta = oEpson.OpenTicket(ref completo);
        //        if (respuesta)
        //        {
        //            foreach (Citem oitem in oventa.Items())
        //            {
        //                nomart = oitem.Articulo.ToString();
        //                cant = (oitem.Cantidad * 1000).ToString().Replace(",", ".");
        //                if (Porcien)
        //                    precio = (oitem.Precio_Uni * 100).ToString();
        //                else
        //                    precio = oitem.Precio_Uni.ToString();
        //                if (SacarComa)
        //                    precio = precio.Replace(",", "");
        //                else
        //                    precio = precio.Replace(",", ".");
        //                respuesta = oEpson.SendTicketItem(ref nomart, ref cant, ref precio, ref iva, ref qualifier, ref budle, ref porcInterno, ref internaltax);
        //                //respuesta = oEpson.SendTicketItem("ARTICULO 1", "1000", "100", "2100", "M", "0", "0");
        //            }

        //            if (respuesta)
        //            {
        //                qualifier = "P";
        //                adicional = "Lindo sub";
        //                respuesta = oEpson.GetTicketSubtotal(ref qualifier, ref adicional);
        //                if (respuesta)
        //                {
        //                    if (oventa.Pago.FormaPago.Descuento)
        //                    {
        //                        Descripcionpago = "Descuento";
        //                        if (importesporcien)
        //                            importe = (oventa.DescRecargo * -100).ToString();
        //                        else
        //                            importe = (oventa.DescRecargo * -1).ToString();
        //                        if (SacarComa)
        //                            importe = importe.Replace(",", "");
        //                        else
        //                            importe = importe.Replace(",", ".");
        //                        identificador = "D";
        //                        respuesta = oEpson.SendTicketPayment(ref Descripcionpago, ref  importe, ref  identificador);
        //                    }
        //                    else if (oventa.Pago.FormaPago.Recargo)
        //                    {
        //                        Descripcionpago = "Recargo";
        //                        if (importesporcien)
        //                            importe = (oventa.DescRecargo * 100).ToString();
        //                        else
        //                            importe = (oventa.DescRecargo).ToString();
        //                        if (SacarComa)
        //                            importe = importe.Replace(",", "");
        //                        else
        //                            importe = importe.Replace(",", ".");
        //                        identificador = "R";
        //                        respuesta = oEpson.SendTicketPayment(ref Descripcionpago, ref  importe, ref identificador);
        //                    }
        //                    Descripcionpago = oventa.Pago.FormaPago.Descripcion;
        //                    if (importesporcien)
        //                        importe = (oventa.Total * 100).ToString();
        //                    else
        //                        importe = (oventa.Total).ToString();
        //                    if (SacarComa)
        //                        importe = importe.Replace(",", "");
        //                    else
        //                        importe = importe.Replace(",", ".");
        //                    identificador = "T";
        //                    respuesta = oEpson.SendTicketPayment(ref Descripcionpago, ref importe, ref  identificador);
        //                    if (respuesta)
        //                    {
        //                        respuesta = oEpson.CloseTicket();
        //                        if (!respuesta)
        //                            throw new Exception(oEpson.FiscalStatus + "." + oEpson.PrinterStatus);
        //                    }
        //                    else
        //                        throw new Exception(oEpson.FiscalStatus + "." + oEpson.PrinterStatus);
        //                }
        //                else
        //                    throw new Exception(oEpson.FiscalStatus + "." + oEpson.PrinterStatus);
        //            }
        //            else
        //                throw new Exception(oEpson.FiscalStatus + "." + oEpson.PrinterStatus);
        //        }
        //        else
        //            throw new Exception(oEpson.FiscalStatus + "." + oEpson.PrinterStatus);
        //        //}
        //        //    if(impresion==2){//ticket factura
        //        //        respuesta = oEpson.OpenTicket(ref completo);
        //        //        if (respuesta)
        //        //        {
        //        //            foreach (Citem oitem in oventa.Items())
        //        //            {
        //        //                nomart = oitem.Articulo;
        //        //                cant = (oitem.Cantidad * 1000).ToString();
        //        //                precio = (oitem.Precio_Uni * 100).ToString().Replace(",", ".") ;
        //        //                respuesta = oEpson.SendTicketItem(ref nomart, ref cant, ref precio, ref iva, ref qualifier, ref budle, ref porcInterno);
        //        //            }
        //        //            //respuesta = Me.PrinterFiscal1.OpenInvoice("T", "C", "A", "1", "P", "12", "I", "I", "PEPE", "LE BOU", "CUIT", "30614104712", "N", "LA", "PAMPA", "98", "REM 1", "REM 2", "G")
        //        //            if (respuesta)
        //        //            {
        //        //                qualifier = "P";
        //        //                //string adicional = "Gracias por su compra";
        //        //                adicional = "Lindo sub";
        //        //                respuesta = oEpson.GetTicketSubtotal(ref qualifier, ref adicional);
        //        //                if (respuesta)
        //        //                {

        //        //                    if (oventa.FORMAPAGO().Descuento)
        //        //                    {
        //        //                        Descripcionpago = "Descuento";
        //        //                        importe = (oventa.DescRecargo*-100).ToString().Replace(",",".");
        //        //                        identificador = "D";
        //        //                        respuesta = oEpson.SendTicketPayment(ref Descripcionpago, ref  importe, ref  identificador);
        //        //                    }
        //        //                    else if (oventa.FORMAPAGO().Recargo)
        //        //                    {
        //        //                        Descripcionpago = "Recargo";
        //        //                        importe = (oventa.DescRecargo * 100).ToString().Replace(",", ".");
        //        //                        identificador = "R";
        //        //                        respuesta = oEpson.SendTicketPayment(ref Descripcionpago, ref  importe, ref identificador);
        //        //                    }
        //        //                    Descripcionpago = oventa.FormaDePago;
        //        //                    importe = (oventa.Total * 100).ToString().Replace(",", ".");
        //        //                    identificador = "T";
        //        //                    respuesta = oEpson.SendTicketPayment(ref Descripcionpago, ref importe, ref  identificador);
        //        //                    if (respuesta)
        //        //                    {
        //        //                        respuesta = oEpson.CloseTicket();
        //        //                    }
        //        //                }
        //        //            }
        //        //        }

        //        //If respuesta Then respuesta = Me.PrinterFiscal1.SendInvoiceItem("ARTICULO 1", "1000", "100", "2100", "M", "0", "0", "EXTRA", "EXTRA", "EXTRA", "1050", "0")
        //        //If respuesta Then respuesta = Me.PrinterFiscal1.GetInvoiceSubtotal("P", "LINDO SUB")
        //        //If respuesta Then respuesta = Me.PrinterFiscal1.SendInvoicePayment("PAGO1", "200", "T")
        //        //If respuesta Then respuesta = Me.PrinterFiscal1.CloseInvoice("T", "A", "HOLA")
        //    }
        //    catch (Exception ex)
        //    {
        //        Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
        //        frm.ShowDialog();
        //    }
        //}
        //public void EpsonTirarX()
        //{
        //    try
        //    {
        //        string tipodecierre = "X";
        //        string impresion = "P";
        //        oEpson.CloseJournal(ref tipodecierre, ref impresion);
        //    }
        //    catch (Exception ex)
        //    {
        //        Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
        //        frm.ShowDialog();
        //    }
        //}
        //public void EpsonTirarZ()
        //{
        //    try
        //    {
        //        string tipodecierre = "Z";
        //        string impresion = "P";
        //        oEpson.CloseJournal(ref tipodecierre, ref impresion);
        //    }
        //    catch (Exception ex)
        //    {
        //        Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
        //        frm.ShowDialog();
        //    }
        //}
        //private void btn_tirarX_Click(object sender, EventArgs e)
        //{
        //    Reportes.R_Articulos frm = new Reportes.R_Articulos(1);
        //    frm.Show();
        //    //if (objConf.Epson_Samsung)
        //    //    EpsonTirarX();
        //    //else
        //    //    oImpresora.HasarTirarX();
        //}

        //private void btn_tirarZ_Click(object sender, EventArgs e)
        //{

        //}
        #endregion

        #region ///////////////////////////////////////////////////////////////////////// BARRA LATERAL
        private void p_detalles_MouseEnter(object sender, EventArgs e)
        {
            if (p_detalles.Location.X > Width - p_detalles.Width)
            {
                p_detalles.BackColor = Color.FromArgb(29, 121, 72);
                while (p_detalles.Location.X > Width - p_detalles.Width)
                {
                    p_detalles.Location = new Point(p_detalles.Location.X - 12, p_detalles.Location.Y);
                    p_detalles.Update();
                }
                p_detalles.Location = new Point(Width - p_detalles.Width, p_detalles.Location.Y);
            }
        }

        private void p_detalles_MouseLeave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn_vuelto.Tag) == 2)
            {
                if (MousePosition.X < p_detalles.Location.X || MousePosition.Y < (p_detalles.Location.Y + 22) || MousePosition.Y > p_detalles.Location.Y + p_detalles.Height + 19)
                {
                    while (p_detalles.Location.X < Width - 32)
                    {
                        p_detalles.Location = new Point(p_detalles.Location.X + 6, p_detalles.Location.Y);
                        this.Update();
                    }
                    p_detalles.Location = new Point(Width - 32, p_detalles.Location.Y);
                    p_detalles.BackColor = Color.Transparent;
                }

            }
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void ActualizarVenta()
        {
            try
            {
                bs_venta.ResetBindings(false);
                bs_venta.DataSource = VentaActual.Items();
                dgrid_items.DataSource = bs_venta;
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void ActualizarLabels()
        {
            lbl_Subtotal.Text = VentaActual.Subtotal.ToString();
            lbl_Total.Text = VentaActual.Total.ToString();
            lbl_desc.Text = VentaActual.DescRecargo.ToString();
            lbl_Total2.Text = lbl_Total.Text;
            txt_codigo.Focus();
        }

        private void Login()
        {
            BindingSource bs = new BindingSource();
            Ctrl_usuarios admusu = Ctrl_usuarios.ClaseActiva();
            bs.ResetBindings(false);
            bs.DataSource = admusu.VerLista();
            //lbl_usuario.Text = "";
            //lbl_permiso.Text = "";
            Cusuario oUsarioNuevo = null;
            if (bs.List.Count == 0)
            {
                Frm_ABM_usuarios frmusu = new Frm_ABM_usuarios(true);
                frmusu.ShowDialog();
                frmusu.Focus();
                oUsarioNuevo = frmusu.OBJUSUARIO;
            }
            else
            {
                if (objConf.MultiUsuario)
                {
                    List<int> ocultarcolumnas = new List<int>();
                    ocultarcolumnas.Add(0);
                    ocultarcolumnas.Add(1);
                    ocultarcolumnas.Add(3);
                    ocultarcolumnas.Add(7);
                    ocultarcolumnas.Add(5);
                    ocultarcolumnas.Add(6);
                    ocultarcolumnas.Add(8);
                    ocultarcolumnas.Add(9);
                    ocultarcolumnas.Add(10);
                    Frm_Eleccion frm = new Frm_Eleccion("Usuarios", "el usuario", bs, ocultarcolumnas, "");
                    frm.ShowDialog();
                    frm.Focus();
                    if (frm.ObjRespuesta != null)
                        oUsarioNuevo = (Cusuario)frm.ObjRespuesta;
                }
                else
                {
                    oUsarioNuevo = admusu.VerLista()[0];
                    ts_login.Visible = false;
                }
            }
            if (oUsarioNuevo != null)
            {
                if (objConf.PedirPass)
                {
                    bool Verificar = true;
                    while (Verificar)
                    {
                        Frm_confirmacion frmconf = new Frm_confirmacion("Password (4 numeros) :", "Contraseña para ingresar como " + oUsarioNuevo.Nombre, "Aceptar", true, false);
                        frmconf.ShowDialog();
                        if (frmconf.RESPUESTA == "Aceptar")
                        {
                            if (frmconf.NUMERO != "")
                            {
                                if (oUsarioNuevo.PASS == frmconf.NUMERO)
                                {
                                    Verificar = false;
                                    objusu = oUsarioNuevo;
                                    lbl_usuario.Text = objusu.Nombre;
                                    lbl_permiso.Text = objusu.Permiso;
                                    HabilitarToolStrip();
                                    PermisosHabilitados();
                                }
                            }
                        }
                        else
                        {
                            oUsarioNuevo = null;
                            Verificar = false;
                        }
                    }
                }
                else
                {
                    objusu = oUsarioNuevo;
                    lbl_usuario.Text = objusu.Nombre;
                    lbl_permiso.Text = objusu.Permiso;
                    HabilitarToolStrip();
                    PermisosHabilitados();
                }
            }
        }
        private void HabilitarToolStrip()
        {
            foreach (ToolStripMenuItem aux in ms_menu.Items)
            {
                aux.Enabled = true;
            }
        }
        private void PermisosHabilitados()
        {
            if (objusu != null)
            {
                Cpermiso oper = objusu.PERMISO();
                ts_CuentasCorrientes.Visible = oper.CTAS_CTES;
                if (objConf.MultiUsuario)
                {
                    ts_Usuario.Visible = oper.USUARIOS_Y_PERMISOS;
                    ts_Permisos.Visible = oper.USUARIOS_Y_PERMISOS;
                }
                ts_Clientes.Visible = oper.CLIENTES;
                if (objConf.ExistenciaPorCompras)
                    ts_compras.Visible = oper.COMPRAS;
                ts_Articulos.Visible = oper.ARTICULOS;
                ts_TableroControl.Visible = oper.ESTADISTICAS_Y_TABLERO_CONTROL;
                ts_Proveedores.Visible = oper.PROVEEDORES;
                ts_configuraciones.Visible = oper.CONFIGURACIONES;
                ts_FormasPagos.Visible = oper.FORMAS_DE_PAGO;
                ts_Localidades.Visible = oper.CLIENTES;
                ts_Ventas.Visible = oper.ESTADISTICAS_Y_TABLERO_CONTROL;
                btn_nuevoGasto.Enabled = oper.COBROS_y_PAGOS;
                btn_nuevoCobro.Enabled = oper.COBROS_y_PAGOS;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (primeraves)
            {
                objConf = Ctrl_configuraciones.Devolver(Application.StartupPath + "\\config.json");
                bs_FormasDePago.ResetBindings(false);
                admformaspagos.CargarLista();
                bs_FormasDePago.DataSource = admformaspagos.VerLista();
                bs_formasDePago2.DataSource = admformaspagos.VerLista();
                cb_FormasPagos.DataSource = bs_FormasDePago;
                cb_FormasPagos.DisplayMember = "Descripcion";
                cb_FormasPagos.Text = "Contado";
                primeraves = false;
                gb_grande.Width = Width - 267;
                FormatoFormulario();
                ActualizarVenta();
                dgrid_items.Columns[0].HeaderText = "Cant";
                dgrid_items.Columns[0].Width = 30;
                dgrid_items.Columns[2].Width = 60;
                dgrid_items.Columns[3].Width = 100;
                gb_grande.Visible = false;

                //ConfigurarImpresora();
                FormatoDeVersiones();
                Login();
                try
                {
                    if (objConf.Facturacion)
                        _oImpresora = cImpresora.ImpresoraActiva(objConf.NombreLogico);
                }
                catch (Exception ex)
                {
                    Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Se desactivara la Impresora", "Aceptar");
                    frm.ShowDialog();
                    _oImpresora = null;
                    objConf.Facturacion = false;
                    Ctrl_configuraciones.Modificar(objConf);
                }
            }
        }
        private void FormatoDeVersiones()
        {
            if (objConf.Version < 2)
            {
                flowLayoutPanel1.BackgroundImage = SIVS.Properties.Resources.EASYSOFT_chivo;
                flowLayoutPanel1.Cursor = Cursors.Hand;
                if (objConf.Version == 1)
                    BackgroundImage = SIVS.Properties.Resources.splash_basic;
                ts_TableroControl.Enabled = false;
                btn_nuevoCobro.Enabled = false;
                btn_nuevoGasto.Enabled = false;
                ts_Usuario.Enabled = false;
            }
            else
            {
                flowLayoutPanel1.BackgroundImage = null;
                if (Convert.ToInt32(btn_AbrirCaja.Tag) == 2)
                {//Esta abierta
                    btn_nuevoGasto.Visible = true;
                    btn_nuevoCobro.Visible = true;
                    btn_devolucion.Visible = true;
                    btn_Imprimir.Visible = true;
                }
                if (objConf.Version == 2)
                {
                    flowLayoutPanel1.Cursor = Cursors.Default;
                    BackgroundImage = SIVS.Properties.Resources.splash_pro;
                }
                else
                    BackgroundImage = SIVS.Properties.Resources.splash_premium;
            }
        }



        private void FormatoFormulario()
        {

            gb_grande.Location = new Point(12, ms_menu.Height);
            gb_grande.Height = this.Height - 130;
            p_detalles.Location = new Point(Width - p_detalles.Width, ms_menu.Height);
            p_detalles.Height = this.Height - 106;
            btn_vuelto.Location = new Point(0, 0);
            dgrid_items.Height = gb_grande.Height - 336;
            p_grande.Location = new Point(p_grande.Location.X, gb_grande.Height - 226);
            ts_compras.Visible = objConf.ExistenciaPorCompras;
            ts_Cajas.Visible = objConf.MultiCaja;
            ts_Permisos.Visible = objConf.MultiUsuario;
            if (!objConf.MultiUsuario)
                ts_login.Visible = objConf.PedirPass;
            else
                ts_login.Visible = true;
            ts_Usuario.Visible = objConf.MultiUsuario;
            p_adicional.Location = new Point(p_adicional.Location.X, p_detalles.Height - 210);
        }

        private void ActualizarCuentas()
        {
            Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
            bs_CuentasClientes.ResetBindings(false);
            bs_CuentasClientes.DataSource = admcuentas.DevolverClienteUsuarios();
            cb_CuentasClientes.DataSource = bs_CuentasClientes;
            cb_CuentasClientes.DisplayMember = "Nombre";
        }

        private void txt_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (ObjArt != null)
                {
                    if (ObjArt.Unidad_Medida.Entero)
                    {
                        if (e.KeyChar == ',')
                            e.Handled = true;
                    }
                    if (e.KeyChar == Convert.ToChar(13))
                    {
                        VentaActual.AgregarItem(new Citem(ObjArt, Convert.ToDecimal(txt_cantidad.Text), Convert.ToDecimal(ObjArt.Precio)));
                        ActualizarVenta();
                        txt_codigo.Clear();
                        ActualizarLabels();
                        ObjArt = null;
                        txt_cantidad.Text = "1";
                    }
                }
                else
                {
                    if (e.KeyChar == Convert.ToChar(13))
                        txt_codigo.Focus();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void txt_cantidad_MouseClick(object sender, MouseEventArgs e)
        {
            txt_cantidad.SelectAll();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    Carticulo obj = admart.BuscarEnVigentes(txt_codigo.Text);
                    if (obj != null)
                    {
                        VentaActual.AgregarItem(new Citem(obj, Convert.ToDecimal(txt_cantidad.Text), Convert.ToDecimal(obj.Precio)));
                        ActualizarVenta();
                        txt_codigo.Clear();
                        ActualizarLabels();
                        ObjArt = null;
                        txt_cantidad.Text = "1";
                    }
                    else
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("No se encontro ningun artículo con ese código", "Código inexistente", "Aceptar");
                        frm.ShowDialog();
                    }
                    e.Handled= true;
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txt_cantidad.Text == "")
                {
                    txt_cantidad.Text = "1";
                }
                if (txt_codigo.Text != "")
                {
                    ObjArt = admart.BuscarEnVigentes(txt_codigo.Text);
                    if (ObjArt != null)
                    {
                        lbl_art.Text = ObjArt.Descripcion;
                        lbl_unidad.Text = ObjArt.Unidad_Medida.ToString();
                        lbl_PrecioTotal.Text = (ObjArt.Precio * Convert.ToDecimal(txt_cantidad.Text)).ToString();
                        if (ObjArt.Unidad_Medida.Entero)
                        {
                            if (txt_cantidad.Text.Contains(","))
                                txt_cantidad.Text = "1";
                        }
                    }
                    else
                    {
                        lbl_art.Text = "";
                        lbl_PrecioTotal.Text = "";
                    }
                }
                else
                {
                    lbl_art.Text = "";
                    lbl_PrecioTotal.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_AbrirCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(btn_AbrirCaja.Tag) == 1)//Abre la caja
                {
                    if (objusu == null)
                        Login();
                    if (objusu != null)
                    {
                        Ctrl_cajas cajas = new Ctrl_cajas();
                        BindingSource bs = new BindingSource();
                        bs.DataSource = cajas.VerLista();
                        Ccaja objcaja = null;
                        if (objConf.MultiCaja)
                        {
                            Frm_Eleccion frmele = new Frm_Eleccion("Elija Caja", bs);
                            frmele.ShowDialog();
                            if (frmele.ObjRespuesta != null)
                            {
                                objcaja = (Ccaja)frmele.ObjRespuesta;
                            }
                        }
                        else
                        {
                            objcaja = cajas.VerLista()[0];
                        }
                        if (objcaja != null)
                        {
                            ObjCajaDiaria = adm.TraerCajaDelDia(objcaja);
                            if (ObjCajaDiaria == null)
                            {

                                Frm_confirmacion frmconf = new Frm_confirmacion("EFECTIVO INICIAL : $ ", "Iniciar Caja Diaria", "Aceptar", true, true);
                                frmconf.ShowDialog();
                                if (frmconf.RESPUESTA != null)
                                {
                                    if (frmconf.NUMERO != "")
                                    {
                                        ObjCajaDiaria = adm.GenerarCaja(Convert.ToDecimal(frmconf.NUMERO), objcaja);
                                    }
                                    else
                                        throw new Exception("No ingreso el efectivo inicial para iniciar la caja");
                                }
                                else
                                    throw new Exception("No ingreso el efectivo inicial para iniciar la caja");
                            }
                            else
                            {
                                adm.CargarVentas(ObjCajaDiaria);
                                adm.UltimaVenta(ObjCajaDiaria);
                            }
                            admart = Ctrl_articulos.ClaseActiva();
                        }
                    }
                    if (ObjCajaDiaria != null)
                    {
                        btn_AbrirCaja.Text = "    Cerrar caja diaria";
                        btn_AbrirCaja.Tag = 2;
                        gb_grande.Visible = true;
                        p_adicional.Visible = true;
                        p_vuelto.Visible = true;
                        if (objConf.Version > 1)
                        {
                            lbl_registros.Visible = true;
                            btn_nuevoCobro.Visible = true;
                            btn_nuevoGasto.Visible = true;
                            btn_Imprimir.Visible = true;
                            //btn_devolucion.Visible = true;
                        }
                        txt_codigo.Focus();
                    }
                }
                else//Cierra caja
                {
                    Frm_confirmacion frm = new Frm_confirmacion("¿Desea cerrar la caja diaria?", "Cerrar Caja", "No", "Si");
                    frm.ShowDialog();
                    if (frm.RESPUESTA == "Si")
                    {
                        adm.CerrarCaja(ObjCajaDiaria);
                        btn_AbrirCaja.Text = "    Abrir Caja";
                        ObjCajaDiaria = null;
                        btn_AbrirCaja.Tag = 1;
                        gb_grande.Visible = false;
                        lbl_registros.Visible = false;
                        btn_nuevoCobro.Visible = false;
                        btn_nuevoGasto.Visible = false;
                        btn_Imprimir.Visible = false;
                        p_adicional.Visible = false;
                        p_vuelto.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (txt_codigo.Visible)
            {
                txt_codigo.Focus();
            }
            if (admformaspagos.actualizar)
            {
                bs_FormasDePago.ResetBindings(false);
                bs_FormasDePago.DataSource = admformaspagos.VerLista();
                cb_FormasPagos.DataSource = bs_FormasDePago;
                admformaspagos.actualizar = false;
            }
            if (admclientes.Actualizar)
            {
                ActualizarCuentas();
            }

        }

        private void cb_FormasPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VentaActual.Pago.FormaPago = (Cforma_pago)cb_FormasPagos.SelectedItem;
                VentaActual.CalcularVenta();
                ActualizarLabels();

                if (VentaActual.Pago.FormaPago.ID == 2)
                {
                    p_cuentacorriente.Visible = true;
                    p_autorizacion.Visible = false;
                    if (cb_CuentasClientes.Items.Count == 0)
                        ActualizarCuentas();

                    if (cb_CuentasClientes.Items.Count == 0)
                        cb_CuentasClientes.Enabled = false;
                    else
                        cb_CuentasClientes.Enabled = true;
                }
                else
                {
                    p_autorizacion.Visible = VentaActual.Pago.FormaPago.Autorizacion;
                    p_cuentacorriente.Visible = false;
                }
                CalcularDescuento();
            }
            catch
            {
            }
        }

        private void btn_CerrarVenta_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (VentaActual.Items().Count == 0)
                {
                    throw new Exception("La venta debe tener articulos");
                }
                else
                {

                    if (!cb_2formasPago.Checked)
                    {
                        VentaActual.Pago.Importe = VentaActual.Total;
                        VentaActual.Pago.Descuento = VentaActual.DescRecargo;
                        if (VentaActual.Pago.FormaPago.Autorizacion)
                        {
                            VentaActual.Pago.Cod_Autorizacion = txt_codAutorizacion.Text;
                            txt_codAutorizacion.Clear();
                        }
                    }
                    
                    adm.AgregarVenta(VentaActual, objusu, ObjCajaDiaria);
                    adm.GuardarItems(VentaActual, ObjCajaDiaria);
                    
                    if (cb_imprimir.Checked)
                    {

                        if (objConf.Facturacion)
                        {
                            _oImpresora.ImprimirVenta(VentaActual, ObjCajaDiaria);
                        }
                        else
                        {
                            Reportes.R_Venta rpt = new Reportes.R_Venta(ObjCajaDiaria.ID, VentaActual, ObjCajaDiaria.Fecha);
                            rpt.ShowDialog();
                        }
                    }
                    if (p_cuentacorriente.Visible)
                    {
                        Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                        Cpersona objpersona = (Cpersona)cb_CuentasClientes.SelectedItem;
                        admcuentas.CargarAltasDebitosyCreditos(objpersona.DevolverCuentaCorriente());
                        Cpago_credito objcredito = new Cpago_credito("Venta numero " + VentaActual.ID, VentaActual.Total, DateTime.Today, true);
                        admcuentas.AgregarOperacion(objcredito, objpersona.DevolverCuentaCorriente());
                        admcuentas.AgregarReferiaEntreOperacion(objcredito, VentaActual, ObjCajaDiaria);
                    }
                    if (cb_2formasPago.Checked)
                    {
                        if (VentaActual.Pago.FormaPago.ID == 2)
                        {
                            Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                            admcuentas.CargarAltasDebitosyCreditos(VentaActual.Pago.Persona.DevolverCuentaCorriente());
                            Cpago_credito objcredito = new Cpago_credito("Venta numero " + VentaActual.ID, VentaActual.Pago.Importe, DateTime.Today, true);
                            admcuentas.AgregarOperacion(objcredito, VentaActual.Pago.Persona.DevolverCuentaCorriente());
                            admcuentas.AgregarReferiaEntreOperacion(objcredito, VentaActual, ObjCajaDiaria);
                        }
                        else if (VentaActual.Pago2.FormaPago.ID == 2)
                        {
                            Ctrl_cuentas_corrientes admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
                            admcuentas.CargarAltasDebitosyCreditos(VentaActual.Pago2.Persona.DevolverCuentaCorriente());
                            Cpago_credito objcredito = new Cpago_credito("Venta numero " + VentaActual.ID, VentaActual.Pago2.Importe, DateTime.Today, true);
                            admcuentas.AgregarOperacion(objcredito, VentaActual.Pago2.Persona.DevolverCuentaCorriente());
                            admcuentas.AgregarReferiaEntreOperacion(objcredito, VentaActual, ObjCajaDiaria);
                        }
                    }
                    //if (objConf.Facturacion)
                    //{
                    //    if (objConf.Epson_Samsung)
                    //        ImprimirEpsonVenta(VentaActual);
                    //    else { }
                    //        //oImpresora.ImprimirTicketHasar(VentaActual);
                    //}
                  
                    cb_2formasPago.Checked = false;
                    VentaActual = new Cventa(new Cpago());
                    VentaActual.Pago.FormaPago = (Cforma_pago)cb_FormasPagos.SelectedItem; // PARA LA SIGUIENTE VENTA               
                    ActualizarVenta();
                    ActualizarLabels();
                    cb_FormasPagos.Text = "Contado";
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void lbl_Cuentas_Click(object sender, EventArgs e)
        {
            Frm_ABM_clientes frmclientes = Frm_ABM_clientes.AbrirForm();
            frmclientes.ShowDialog();
            if (admclientes.Actualizar)
            {
                ActualizarCuentas();
                admclientes.Actualizar = false;
                if (cb_CuentasClientes.Items.Count > 0)
                    cb_CuentasClientes.Enabled = true;
            }
        }

        private void lbl_articulos_Click(object sender, EventArgs e)
        {
            Frm_ABM_articulos frm = new Frm_ABM_articulos(true, true);
            frm.ShowDialog();
            txt_codigo.Focus();
            if (frm.oArt != null)
                txt_codigo.Text = frm.oArt.Codigo.ToString();
        }

        private void dgrid_items_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgrid_items.SelectedRows.Count > 0)
                {
                    int cal = dgrid_items.Rows[0].Height * (dgrid_items.Rows.Count + 1);
                    if (cal > e.Location.Y && e.Location.Y > dgrid_items.Rows[0].Height)
                    {
                        VentaActual.EliminarItem(((Citem)(dgrid_items.CurrentRow.DataBoundItem)));
                        ActualizarVenta();
                        ActualizarLabels();
                    }
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Frm_ABM_compras frm = Frm_ABM_compras.AbrirForm();
            frm.Show();
        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (!primeraves)
            {
                FormatoFormulario();
            }
            //gb_grande.Height = this.Height - 74;
            //dgrid_items.Height = gb_grande.Height - 319;
            //p_grande.Location = new Point(p_grande.Location.X, this.Height - 306);
        }

        private void CalcularDescuento()
        {
            try
            {
                if (Convert.ToDecimal(lbl_Subtotal.Text) > 0)
                {
                    decimal descuRec1;
                    decimal descuRec2;
                    if (cb_adicional.Checked)
                    {
                        if (objConf.OrdenPrioridad)
                        {
                            if (objConf.DescuentoFormaPago)
                            {
                                if (VentaActual.Pago.FormaPago.Descuento)
                                    descuRec1 = VentaActual.Subtotal * VentaActual.Pago.FormaPago.Porcentaje / -100;
                                else if (VentaActual.Pago.FormaPago.Recargo)
                                    descuRec1 = VentaActual.Subtotal * VentaActual.Pago.FormaPago.Porcentaje / 100;
                                else
                                    descuRec1 = 0;
                                if (rb_descuento.Checked)
                                {
                                    descuRec2 = (VentaActual.Subtotal + descuRec1) * Convert.ToDecimal(txt_adicional.Text) / -100;
                                }
                                else
                                {
                                    descuRec2 = (VentaActual.Subtotal + descuRec1) * Convert.ToDecimal(txt_adicional.Text) / 100;
                                }
                            }
                            else
                            {
                                if (rb_descuento.Checked)
                                    descuRec1 = VentaActual.Subtotal * Convert.ToDecimal(txt_adicional.Text) / -100;
                                else
                                    descuRec1 = VentaActual.Subtotal * Convert.ToDecimal(txt_adicional.Text) / 100;
                                if (VentaActual.Pago.FormaPago.Descuento)
                                {
                                    descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / -100;
                                }
                                else if (VentaActual.Pago.FormaPago.Recargo)
                                {
                                    descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / 100;
                                }
                                else
                                    descuRec2 = 0;
                            }
                        }
                        else
                        {
                            if (objConf.DescuentoFormaPago)
                            {
                                if (rb_descuento.Checked)
                                {
                                    descuRec1 = VentaActual.Subtotal * Convert.ToDecimal(txt_adicional.Text) / -100;
                                    if (VentaActual.Pago.FormaPago.Descuento)
                                        descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / -100;
                                    else if (VentaActual.Pago.FormaPago.Recargo)
                                        descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / 100;
                                    else
                                        descuRec2 = 0;
                                }
                                else
                                {
                                    if (VentaActual.Pago.FormaPago.Descuento)
                                    {
                                        descuRec1 = VentaActual.Subtotal * VentaActual.Pago.FormaPago.Porcentaje / -100;
                                        descuRec2 = (VentaActual.Subtotal + descuRec1) * Convert.ToDecimal(txt_adicional.Text) / 100;
                                    }
                                    else
                                    {
                                        descuRec1 = VentaActual.Subtotal * Convert.ToDecimal(txt_adicional.Text) / 100;
                                        if (VentaActual.Pago.FormaPago.Recargo)
                                            descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / 100;
                                        else
                                            descuRec2 = 0;
                                    }
                                }
                            }
                            else
                            {
                                if (rb_recargo.Checked)
                                {
                                    descuRec1 = VentaActual.Subtotal * Convert.ToDecimal(txt_adicional.Text) / 100;
                                    if (VentaActual.Pago.FormaPago.Recargo)
                                        descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / 100;
                                    else if (VentaActual.Pago.FormaPago.Descuento)
                                        descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / -100;
                                    else
                                        descuRec2 = 0;
                                }
                                else
                                {
                                    if (VentaActual.Pago.FormaPago.Recargo)
                                    {
                                        descuRec1 = VentaActual.Subtotal * VentaActual.Pago.FormaPago.Porcentaje / 100;
                                        descuRec2 = (VentaActual.Subtotal + descuRec1) * Convert.ToDecimal(txt_adicional.Text) / -100;
                                    }
                                    else
                                    {
                                        descuRec1 = VentaActual.Subtotal * Convert.ToDecimal(txt_adicional.Text) / -100;
                                        if (VentaActual.Pago.FormaPago.Descuento)
                                            descuRec2 = (VentaActual.Subtotal + descuRec1) * VentaActual.Pago.FormaPago.Porcentaje / -100;
                                        else
                                            descuRec2 = 0;
                                    }
                                }
                            }
                        }
                        decimal descRectotal = (descuRec1 + descuRec2);
                        VentaActual.CalcularVenta(descRectotal);
                    }
                    else
                    {
                        VentaActual.CalcularVenta();
                    }
                    ActualizarLabels();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Error de calculo", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void lbl_Subtotal_TextChanged(object sender, EventArgs e)
        {
            CalcularDescuento();
        }

        private void txt_adicional_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_adicional.Text) >= 100)
                txt_adicional.Text = "99,99";
        }

        private void ts_Ventas_Click(object sender, EventArgs e)
        {
            Frm_Ventas frm = Frm_Ventas.AbrirForm();
            frm.Show();
            frm.Focus();
        }

        private void ts_Estadisticas_Click(object sender, EventArgs e)
        {
            Frm_confirmacion frm = new Frm_confirmacion("Estamos trabajando para mejorar EasySales Market. Esta opción se encontrará disponible en la próximas actualizaciones.", "Informe", "Aceptar");
            frm.ShowDialog();
            //Frm_Estadisticas frm = Frm_Estadisticas.AbrirForm();
            //frm.Show();
            //frm.Focus();
        }

        private void ts_Rubro_Click(object sender, EventArgs e)
        {
            Frm_ABM_rubros frm = Frm_ABM_rubros.AbrirForm();
            frm.Show();
            frm.Focus();
        }

        private void txt_monto_TextChanged(object sender, EventArgs e)
        {
            decimal vuelto = Convert.ToDecimal(txt_monto.Text) - Convert.ToDecimal(lbl_Total2.Text);
            lbl_vuelto.Text = vuelto.ToString();
        }

        private void btn_vuelto_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btn_vuelto.Tag) == 2)
            {
                btn_vuelto.Tag = 1;
                btn_vuelto.Image = SIVS.Properties.Resources.Board_Pin_1;
                gb_grande.Width = Width - 267;
            }
            else
            {
                btn_vuelto.Tag = 2;
                btn_vuelto.Image = SIVS.Properties.Resources.Board_Pin2;
                gb_grande.Width = Width - 44;
            }
            FormatoFormulario();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 111 && e.KeyValue < 124)
            {

                if (122 == e.KeyValue)
                {
                    //finalizar venta
                    btn_CerrarVenta_Click_1(sender, e);
                }
                else if (112 == e.KeyValue)
                {
                    //abrir caja o cerrar caja
                    btn_AbrirCaja_Click(sender, e);
                }
                else if (120 == e.KeyValue)//F9
                {
                    //ingresar cantidad
                    txt_cantidad.SelectAll();
                    txt_cantidad.Focus();
                }
                else if (121 == e.KeyValue)
                {
                    // Facturacion o no

                }
                else if (123 == e.KeyValue)//F12
                {
                    // Vuelto
                    p_detalles_MouseEnter(sender, e);
                    txt_monto.SelectAll();
                    txt_monto.Focus();
                }
                else if (116 == e.KeyValue)//F5
                {
                    //ingresar codigo articulo
                    txt_codigo.SelectAll();
                    txt_codigo.Focus();
                }
                else if (117 == e.KeyValue) //F6
                {
                    //Buscar Articulo por nombre
                    lbl_articulos_Click(sender, e);
                }
                else if (118 == e.KeyValue)
                {
                    //seleccion forma de pago
                    cb_FormasPagos.Focus();
                }
                else if (119 == e.KeyValue)
                {
                    //seleccion cuenta corriente
                    if (!p_cuentacorriente.Visible)
                    {
                        cb_FormasPagos.Text = "Cuenta Corriente";
                    }
                    cb_CuentasClientes.Focus();
                }

            }

            //string frase = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789-_.:,;<>!?¡¿";
            //Byte[] codigos = System.Text.ASCIIEncoding.ASCII.GetBytes(frase);
            //string todos = "";
            //int l = 0;
            //foreach (byte AUX in codigos)
            //{
            //    todos += AUX.ToString() + " " + frase[l].ToString() + "   ";
            //    if (l == 10 || l == 20 || l == 30 || l == 40)
            //    {
            //        todos += "\n";
            //    }

            //    l++;
            //}
            //MessageBox.Show(todos);
            //txt_codigo.Text = todos;
            //MessageBox.Show(e.KeyValue.ToString() + " " + e.KeyCode.ToString() + " " + e.KeyData.ToString());

        }

        private void ts_Articulos_MouseEnter(object sender, EventArgs e)
        {
            ToolStripItem a = (ToolStripItem)sender;
            a.Text = a.Tag.ToString();
        }

        private void ts_Articulos_MouseLeave(object sender, EventArgs e)
        {
            ToolStripItem a = (ToolStripItem)sender;
            a.Text = "";
        }

        private void gb_grande_SizeChanged(object sender, EventArgs e)
        {
            int diferencia = gb_grande.Width - 1025;
            p_precio.Location = new Point(749 + diferencia, p_precio.Location.Y);
            p_articulo.Width = 1019 + diferencia;
            p_descripcion.Width = 858 + diferencia;
            dgrid_items.Width = p_articulo.Width;
        }

        private void lbl_unidad_TextChanged(object sender, EventArgs e)
        {
        }

        private void cb_2formasPago_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_items.Rows.Count == 0)
                {
                    if (cb_2formasPago.Checked)
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("Antes de seleccionar metodos de pago debe ingresar artículos a la venta.", "Venta incompleta", "Aceptar");
                        frm.ShowDialog();
                        cb_2formasPago.Checked = false;
                    }

                }
                else
                {
                    if (cb_2formasPago.Checked)
                    {
                        Frm_Formas_pagos_varias frm = new Frm_Formas_pagos_varias(lbl_Subtotal.Text);
                        frm.ShowDialog();
                        if (frm.PAGOS.Count > 0)
                        {
                            VentaActual.Pago = frm.PAGOS.First();
                            VentaActual.Pago2 = frm.PAGOS.Last();
                            VentaActual.DescRecargo = VentaActual.Pago.Descuento + VentaActual.Pago2.Descuento;
                            VentaActual.Total = VentaActual.Pago.Importe + VentaActual.Pago2.Importe;
                            btn_CerrarVenta_Click_1(sender, e);
                        }
                        cb_2formasPago.Checked = false;
                    }
                }


            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void lbl_art_TextChanged(object sender, EventArgs e)
        {
            //txt_cantidad.Text = "1";
        }

        private void btn_nuevoCobro_Click(object sender, EventArgs e)
        {
            //Frm_Activacion frm = new Frm_Activacion();
            //frm.ShowDialog();
            Frm_Operacion form = new Frm_Operacion(false, ObjCajaDiaria);
            form.ShowDialog();
        }

        private void btn_nuevoGasto_Click(object sender, EventArgs e)
        {
            Frm_Operacion form = new Frm_Operacion(true, ObjCajaDiaria);
            form.ShowDialog();
        }

        private void txt_adicional_Leave(object sender, EventArgs e)
        {
            CalcularDescuento();
        }

        private void txt_adicional_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_adicional_Leave(sender, e);
            }
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (objConf.Version < 2)
            {
                Frm_confirmacion frm = new Frm_confirmacion("La versión PRO es la más popular y usada de nuestras versiones.\nDesea ingresar la clave o solicitarla en nuestra página?", "Versión PRO", "Solicitar", "Ingresar");
                frm.ShowDialog();
                if ("Ir a la página" == frm.RESPUESTA)
                    Process.Start("www.facebook.com/easysoftgt");
                else
                {
                    Frm_Activacion frmAct = new Frm_Activacion();
                    frmAct.ShowDialog();
                    FormatoDeVersiones();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_confirmacion frm = new Frm_confirmacion("¿Desea cerrar el sistema?", "Cierre de sistema", "No", "Si");
            frm.ShowDialog();
            if (frm.RESPUESTA != null)
            {
                if (frm.RESPUESTA == "No")
                    e.Cancel = true;
                else
                {
                    if(ObjCajaDiaria!=null)
                        btn_AbrirCaja_Click(sender,e);
                    if(_oImpresora!=null)
                        _oImpresora.Cerrar();
                }
            }
        }

        private void mi_ActualizarPrecios_Click(object sender, EventArgs e)
        {
            Frm_ActualizarPrecios frm = new Frm_ActualizarPrecios();
            frm.Show();
        }

        private void txt_adicionalFijo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_adicionalFijo_Leave(sender, e);
            }
        }

        private void txt_adicionalFijo_Leave(object sender, EventArgs e)
        {

            decimal porcentaje = Convert.ToDecimal(txt_adicionalFijo.Text) / Convert.ToDecimal(lbl_Subtotal.Text);
            porcentaje = porcentaje * 100;
            txt_adicional.Text = porcentaje.ToString();
            CalcularDescuento();

        }

        private void txt_adicionalFijo_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(txt_adicionalFijo.Text) > Convert.ToDecimal(lbl_Subtotal.Text))
            {
                txt_adicionalFijo.Text = lbl_Subtotal.Text;
            }
        }


        private void ts_admin_Click(object sender, EventArgs e)
        {
            frm_admin frm = new frm_admin();
            frm.ShowDialog();
        }
        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            Cventa oVenta = ObjCajaDiaria.UltimaVenta();
            if (oVenta != null)
            {
                Reportes.R_Venta rpt = new Reportes.R_Venta(ObjCajaDiaria.ID, oVenta, ObjCajaDiaria.Fecha);
                rpt.Show();
            }
            else
            {
                Frm_confirmacion frm = new Frm_confirmacion("No hay ventas en la caja diaria actual.", "Faltan ventas", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void ts_CVentasArticulos_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_Ventas_Articulos frm = Frm_Tablero_Control_Ventas_Articulos.AbrirForm();
            frm.Show();
        }

        private void ts_ControlMercaderia_Click(object sender, EventArgs e)
        {
            Frm_Tablero_Control_Mercaderia frm = Frm_Tablero_Control_Mercaderia.AbrirForm();
            frm.Show();
        }

        private void ts_ControlUsuarios_Click(object sender, EventArgs e)
        {
            //HACER EL CONTROL DE USUARIOS !! 
        }

        private void tsm_backup_Click(object sender, EventArgs e)
        {
            try
            {
                if (objConf.backupDirectory == "")
                    throw new Exception("No esta configurada la carpeta donde se realiza el backup. Comuniquece con soporte para arreglarlo.");
                Ctrl_configuraciones.CrearBackup();
                System.Diagnostics.Process.Start(@""+objConf.backupDirectory);
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_devolucion_Click(object sender, EventArgs e)
        {
            Frm_ABM_articulos frm = new Frm_ABM_articulos(true, true);
            frm.ShowDialog();
            if (frm.oArt != null)
            {
                VentaActual.AgregarItem(new Citem(frm.oArt,-1, Convert.ToDecimal(frm.oArt.Precio)));
                ActualizarVenta();
                txt_codigo.Clear();
                ActualizarLabels();
                ObjArt = null;
                txt_cantidad.Text = "1";
            }
        }        
    }
}

//RECODATORIO PARA MAURETE !!!
//METODO PARA PONER FONDO DEGRADADO ! (METODO OVERRIDE)

//protected override void OnPaintBackground(PaintEventArgs e)
//{
//    Color Abajo = Color.FromArgb(230, 230, 230);
//    Color Arriba = Color.FromArgb(100, 190, 100);
//    brocha = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Arriba, Arriba, LinearGradientMode.Vertical);
//    e.Graphics.FillRectangle(brocha, e.ClipRectangle);
//}