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
        static string configFile;
        static public Cconfiguracion Devolver(string filePath)
        {
            configFile = filePath;
            if (objconf == null)
            {
                if (File.Exists(configFile)) {
                    if (File.Exists("C:\\config.json"))
                        configFile = "C:\\config.json";
                    //objconf = Cdatos_configuraciones.Devolver();
                    using (StreamReader SR = new StreamReader(configFile))
                        objconf = JsonConvert.DeserializeObject<Cconfiguracion>(SR.ReadToEnd());
                }
                else
                {
                    string connection = "data source=" + System.Net.Dns.GetHostName() + "\\EASYSOFT;initial catalog=EASYSALES_BD;user id=sa;password=M1987F1990";

                    try
                    {
                        objconf = Cdatos_configuraciones.Devolver(connection);
                    }
                    catch { }
                    if(objconf==null)
                        objconf = new Cconfiguracion(1, true, false, true, false, false, false, false, 0, true, true, true, 3, 3, 21m, System.Net.Dns.GetHostName(), 2, "");

                    objconf.connectionString = connection;
                    using (FileStream file = File.Create(configFile)) {
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
            using (StreamWriter SW = new StreamWriter(configFile))
            {
                SW.Write(JsonConvert.SerializeObject(objconf));
            }
        }
      
        static public void CrearBackup()
        {
            cDatos.RealizarBackup(objconf.backupDirectory);
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
