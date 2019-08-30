using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CONTROL;
using CLASES;
using System.Diagnostics;
namespace SIVS
{
    public partial class Frm_Splash_screen : Form
    {
        static public bool IniciarSistema = true;
        int tiempoDeEsperaCargaEnMemoria = 100;

        public Frm_Splash_screen()
        {
            InitializeComponent();
        }

        private void Frm_Splash_screen_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Splash_screen_Shown(object sender, EventArgs e)
        {
            try
            {
                Ctrl_BD adm = new Ctrl_BD();
                lbl_indicador.Text = "Comprobando si existe base de datos.";
                Update();
                System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                if (!adm.ExisteBD())
                {
                    lbl_indicador.Text = "Comprobando si existe la instancia en el equipo.";
                    Update();
                    System.Threading.Thread.Sleep(1000);
                    if (adm.ExisteInstancia())
                    {
                        lbl_indicador.Text = "Creando base de datos";
                        Update();
                        System.Threading.Thread.Sleep(30000);
                        adm.CrearBD();
                        lbl_indicador.Text = "Creando tablas de la base de datos";
                        Update();
                        System.Threading.Thread.Sleep(1000);
                        adm.CrearTablas();
                        lbl_indicador.Text = "Comprobando si existe base de datos.";
                        Update();
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                if (adm.ExisteBD())
                {
                    lbl_indicador.Text = "Comprobando versión del sistema.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_configuraciones.Actualizar();
                    Cconfiguracion oconfiguracion = Ctrl_configuraciones.Devolver();
                    
                    /*if (Ctrl_configuraciones.TieneVersionBasicProPremium())
                    {
                        if (Ctrl_configuraciones.TieneClave())
                        {
                            if (Ctrl_configuraciones.FechaCorrecta())
                            {
                                if (Ctrl_configuraciones.ClaveAntesDe40Dias())
                                {
                                    if (Ctrl_configuraciones.CantidadDeCajasDiariasCorrecta())
                                    {
                                        Ctrl_Resgitros admReg= Ctrl_Resgitros.ClaseActiva();
                                        oconfiguracion.Version = admReg.ClaveActualCorrecta();
                                        if (oconfiguracion.Version == 2)
                                            this.BackgroundImage = SIVS.Properties.Resources.splash_pro;
                                        else if (oconfiguracion.Version == 1)
                                            this.BackgroundImage = SIVS.Properties.Resources.splash_basic;
                                        else if (oconfiguracion.Version == 3)
                                            this.BackgroundImage = SIVS.Properties.Resources.splash_premium;
                                        else
                                            this.BackgroundImage = SIVS.Properties.Resources.splash_free;
                                    }
                                    else{
                                        oconfiguracion.Version=0;
                                        Ctrl_configuraciones.Modificar(oconfiguracion);
                                        this.BackgroundImage = SIVS.Properties.Resources.splash_free;
                                    }
                                }
                                else
                                {
                                    oconfiguracion.Version = 0;
                                    Ctrl_configuraciones.Modificar(oconfiguracion);
                                    this.BackgroundImage = SIVS.Properties.Resources.splash_free;
                                }
                            }
                            else
                            {
                                Frm_confirmacion form = new Frm_confirmacion("La Fecha de su máquina es incorrecta a registros anteriores.\nPor favor verifique q su fecha sea la actual en su computadora y vuelva a ingresar al sistema.\n Para mas información vaya a la página.", "Fecha incorrecta", "Aceptar", "Ir a la página");
                                form.ShowDialog();
                                if(form.RESPUESTA=="Ir a la página")
                                    Process.Start("www.facebook.com/easysoftgt");
                                Application.ExitThread();
                                IniciarSistema = false;
                                Application.Exit();
                            }
                        }
                        else
                        {
                            if (Ctrl_configuraciones.TienePerdiodoDePrueba())
                                this.BackgroundImage = SIVS.Properties.Resources.splash_pro;
                            else
                            {
                                oconfiguracion.Version = 0;
                                Ctrl_configuraciones.Modificar(oconfiguracion);
                                this.BackgroundImage = SIVS.Properties.Resources.splash_free;
                            }
                        }
                    }
                    else
                        this.BackgroundImage = SIVS.Properties.Resources.splash_free;
                    */
                    if (oconfiguracion.Version == 2)
                        this.BackgroundImage = SIVS.Properties.Resources.splash_pro;
                    else
                    {
                        if (oconfiguracion.Version == 1)
                            this.BackgroundImage = SIVS.Properties.Resources.splash_basic;
                        else this.BackgroundImage = SIVS.Properties.Resources.splash_free;
                    }

                    lbl_indicador.Text = "Cargando formas de pagos.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_formas_pagos admformas = Ctrl_formas_pagos.ClaseActiva();
                    lbl_indicador.Text = "Cargando unidades de medidas.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_medidas admmedidas = Ctrl_medidas.ClaseActiva();
                    lbl_indicador.Text = "Cargando unidades de medida.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_rubros admrubros = Ctrl_rubros.ClaseActiva();
                    lbl_indicador.Text = "Cargando rubros.";
                    Update();
                    System.Threading.Thread.Sleep(700);
                    Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
                    lbl_indicador.Text = "Cargando artículos vigentes.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_articulos admarti = Ctrl_articulos.ClaseActiva();
                    lbl_indicador.Text = "Cargando permisos.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_permisos admper = Ctrl_permisos.ClaseActiva();
                    lbl_indicador.Text = "Cargando usuarios.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_usuarios admusuarios = Ctrl_usuarios.ClaseActiva();
                    lbl_indicador.Text = "Cargando clientes.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_clientes admclientes = Ctrl_clientes.ClaseActiva();
                    lbl_indicador.Text = "Cargando proveedores.";
                    Update();
                    System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                    Ctrl_proveedores admproveedores = Ctrl_proveedores.ClaseActiva();
                    if (oconfiguracion.Facturacion)
                    {

                        lbl_indicador.Text = "Configurando impresora o comandera.";
                        Update();
                        System.Threading.Thread.Sleep(tiempoDeEsperaCargaEnMemoria);
                        try
                        {
                            cImpresora oImpresora = cImpresora.ImpresoraActiva(oconfiguracion.NombreLogico);
                        }
                        catch (Exception ex)
                        {
                            Frm_confirmacion frm = new Frm_confirmacion("No se detectó librería o comandera.Se deshabilitarán las configuraciones para la misma. Error en detalle: "+ex.Message, "Se desactivará la impresora o comandera", "Aceptar");
                            frm.ShowDialog();
                            oconfiguracion.Facturacion = false;
                            Ctrl_configuraciones.Modificar(oconfiguracion);
                        }
                        
                    }
                }
                else
                {
                    throw new Exception();
                }
                Close();
            }
            catch
            {
                Frm_confirmacion frm = new Frm_confirmacion("No se ha encontrado la instancia para crear o leer la base de datos del sistema.\nEasySales se cerrará.\nPongase en contacto con EasySoft grupo tecnologico para resolverlo.", "Error base de datos", "Aceptar");
                frm.ShowDialog();
                Application.ExitThread();
                IniciarSistema = false;
                Application.Exit();
            }
        }
    }
}
