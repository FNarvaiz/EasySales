using System;
using CLASES;
using C_DATOS;
using System.IO;
using Newtonsoft.Json;

namespace CONTROL
{
    static public  class Ctrl_configuraciones
    {
        static Cconfiguracion objconf;
        static public Cconfiguracion Devolver(string filePath)
        {
            if (objconf == null)
            {
                if (File.Exists(filePath)) {
                    //objconf = Cdatos_configuraciones.Devolver();
                    using (StreamReader SR = new StreamReader(filePath))
                        objconf = JsonConvert.DeserializeObject<Cconfiguracion>(SR.ReadToEnd());
                }
                else
                {
                    objconf = new Cconfiguracion(1, true, false, true, false, false, false, false, 0, true, true, true, 3, 3, 21m, System.Net.Dns.GetHostName(), 2, "");
                    objconf.connectionString = "data source=" + System.Net.Dns.GetHostName() + "\\EASYSOFT;initial catalog=EASYSALES_BD;user id=sa;password=M1987F1990";

                    //Cdatos_configuraciones.Agregar(objconf);
                    using (FileStream file = File.Create(filePath)) {
                        using (StreamWriter SW = new StreamWriter(file)) {
                            SW.Write(JsonConvert.SerializeObject(objconf));
                        }
                    }
                }
            }

            objconf.Version = 3; // VERSION DEL SISTEMA
            return objconf;
        }
        /*public void Cargar(string archivo)
        {
            System.IO.StreamReader lector = new System.IO.StreamReader(archivo);

            for (int x = 0; x < 3; x++)
            {
                if (LeerConfiguracion(lector))
                    x = 3;
                else if (x == 2)
                    throw new Exception("El sistema no se a podido conectar a la base de datos en los 3 intentos, por favor comuniquece con su proveedor.");
            }
            cAcceso.Cambios();
            _dao.Cargar();
            daoRegistros.CargarUltimoID();

            /*          
                        foreach (cContrato aux in daoContratos.Activa().DevolverLista())
                            aux.saldoInicial();
                        cCaja obj;
                        for (int x = 1; x < 12; x++)
                        {
                            obj=daoCajas.Activa().Buscar(x);
                            if (obj.Cerrada)
                            {

                                daoCajas.Activa().CargarCerrada(obj);
                                daoCajas.Activa().GuardarSaldosLimitesDeContratos(obj);
                            }
                        }
        }*/
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
