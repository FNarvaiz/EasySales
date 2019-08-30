using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
namespace CONTROL
{
    static public  class Ctrl_configuraciones
    {
        static Cconfiguracion objconf;
        static public Cconfiguracion Devolver()
        {
            if(objconf== null){
            objconf = Cdatos_configuraciones.Devolver();
                if (objconf == null)
                {
                    objconf = new Cconfiguracion(1, true, false, true, false,false, false, false, 0,true,true,true,3,3,21m,System.Net.Dns.GetHostName(),2,"");
                    Cdatos_configuraciones.Agregar(objconf);
                }
            }
            objconf.Version = 2; // VERSION DEL SISTEMA
            return objconf;
        }
        static public void Modificar(Cconfiguracion obj)
        {
            Cdatos_configuraciones.Modificar(obj);
        }
        static public  bool TieneVersionBasicProPremium()
        {
            if (objconf.Version > 0)
                return true;
            else
                return false;
        }
        static public  bool TienePerdiodoDePrueba()
        {
            if (Cdatos_ventas.CantVentas() < 100)
                return true;
            else
                return false;
        }
        static public bool TieneClave()
        {
            if (Cdatos_registros.Devolver(objconf).Count != 0)
                return true;
            else
                return false;
        }
        static public void CrearBackup(string ubicacion)
        {
            cDatos.RealizarBackup(ubicacion);
        }
        static public void Actualizar()
        {

            if (!cDatos.ExisteTabla("REGISTROS"))
            {
                cDatos.CrearTablaRegistro();
            }
            if (!cDatos.ExisteColumna("StockAlto", "Articulos"))
            {
                cDatos.CambiarStockDeRubros2Art();
            }
            if (!cDatos.ExisteColumna("Nombre_logico", "Configuraciones"))
            {
                cDatos.AgregarNombreLogico();
            }
            if(!cDatos.ExisteTabla("BANCOS"))
            {
                cDatos.CrearTablaBancos();
            }
            
        }
        static public  bool ClaveAntesDe40Dias()
        {
            if (Cdatos_registros.Devolver(objconf)[0].Fecha > DateTime.Today.AddDays(-40))
                return true;
            else
                return false;
        }


        static public  bool CantidadDeCajasDiariasCorrecta()
        {
            int cantCajasdiarias = Cdatos_cajas_diarias.CantidadDeCajas(Cdatos_registros.Devolver(objconf)[0].Fecha.ToShortDateString());
            int cajas = Cdatos_cajas.CantidadDeCajas();
            decimal resultado = cantCajasdiarias / cajas;
            if (resultado <= 5)
                return true;
            else
                return false;
        }
        static public  bool FechaCorrecta()
        {
            if (DateTime.Today >= Cdatos_cajas_diarias.UltimaFecha)
                return true;
            else
                return false;
        }
    }
}
