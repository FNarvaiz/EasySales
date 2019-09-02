using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace C_DATOS
{
    public class cDatos
    {

        ///////////////////////////////////// VARIABLES DE CONEXION ALTERNATIVAS /////////////////////////////////////

        //static SqlConnection CN = new SqlConnection("data source=192.168.1.10\\EASYSOFT,1488;initial catalog=SIPP_BD;user id=FIDENZA;password=polakiller");       
        //static SqlConnection CN = new SqlConnection("data source=TRESALEGRESTIGR\\EASYSOFT;integrated security=true;initial catalog=SIVS_BD");
        //static SqlConnection CN = new SqlConnection("data source=MAURO-PC;integrated security=true;initial catalog=SIVS_BD");
        //static string instancia = "data source=" + System.Net.Dns.GetHostName() + "\\SQLEXPRESS;integrated security=true;initial catalog=SIVS_BD";
        //static SqlConnection CN = new SqlConnection("data source=" + System.Net.Dns.GetHostName() + "\\EASYSOFT;initial catalog=EASYSALES_BD;user id=sa;password=M1987F1990");
        static SqlConnection CN;// = new SqlConnection("data source=DESKTOP-Q0SDDJ5\\SQLEXPRESS;initial catalog=Siguenia;integrated security=true");

        static public void StartConnection(string connectinString)
        {
            CN = new SqlConnection(connectinString);
        }

        static public void CrearBD()
        {
            //SqlConnection CNN = new SqlConnection("data source=FIDENZA\\EASYSOFT;database=master;integrated security=yes");
            //SqlConnection CNN = new SqlConnection("data source=TRESALEGRESTIGR\\EASYSOFTNUEVO;database=master;integrated security=yes");
            //SqlConnection CNN = new SqlConnection("data source=192.168.1.10\\EASYSOFT,1488;database=master;integrated security=yes");
            //SqlConnection CNN = new SqlConnection("data source=MAURO-PC;database=master;integrated security=yes");
            try
            {
                SqlConnection CNN = new SqlConnection("data source=" + System.Net.Dns.GetHostName() + "\\EASYSOFT;database=master;Trusted_connection=True;user id=sa;password=M1987F1990");
                SqlCommand cmd = new SqlCommand("CREATE DATABASE EASYSALES_BD", CNN);
                CNN.Open();
                cmd.ExecuteNonQuery();
                CNN.Close();
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        static public bool ExisteInstancia()
        {
            try
            {
                //SqlConnection CNN = new SqlConnection("data source=MAURO-PC;database=master;integrated security=yes");
                SqlConnection CNN = new SqlConnection("data source=" + System.Net.Dns.GetHostName() + "\\EASYSOFT;database=master;integrated security=yes;user id=Sa;password=M1987F1990");
                SqlCommand cmd = new SqlCommand("SELECT name FROM sysdatabases", CNN);
                CNN.Open();
                cmd.ExecuteNonQuery();
                CNN.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public void RealizarBackup(string direccion)
        {
            ActualizarDatos("BACKUP DATABASE ["+ cDatos.CN.Database+"] TO DISK = N'" + direccion + "\\Backup"  + DateTime.Today.Year + "-" + DateTime.Today.MonthTwoDigit() + "-" + DateTime.Today.DayTwoDigit() + ".bak' WITH NOFORMAT, NOINIT, NAME = N'HOTEL_LUGRA', SKIP, NOREWIND, NOUNLOAD, STATS = 10");
        }
        static public bool ExisteTabla(string NombreTabla){
           string scmd ="SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' AND TABLE_NAME = @nombreTabla";
           try
           {
               CN.Open();
               SqlCommand cmd = new SqlCommand(scmd, CN);
               cmd.Parameters.AddWithValue("@nombreTabla", NombreTabla);
               // Comprobamos si está
               // Devuelve 1 si ya existe
               // o 0 si no existe
               int n = (int)cmd.ExecuteScalar();
               CN.Close();
               if (n == 0)
                   return false;
               else
                   return true;
           }
           catch
           {
               return false;
           }
       }
        static public bool ExisteColumna(string NombreColumna ,string NombreTabla){
           string scmd ="select count(*) FROM INFORMATION_SCHEMA.COLUMNS AS c1 where c1.column_name = @nombreColumna AND c1.table_name = @nombreTabla";
           try
           {
               CN.Open();
               SqlCommand cmd = new SqlCommand(scmd, CN);
               cmd.Parameters.AddWithValue("@nombreColumna", NombreColumna);
               cmd.Parameters.AddWithValue("@nombreTabla", NombreTabla);
               // Comprobamos si está
               // Devuelve 1 si ya existe
               // o 0 si no existe
               int n = (int)cmd.ExecuteScalar();
               CN.Close();
               if (n == 0)
                   return false;
               else
                   return true;
           }
           catch
           {
               return false;
           }
       }


        #region //////////////// CREACIÓN DE TABLAS POR ACTUALIZACIONES

        static public void CrearTablaRegistro()
        {
            string cmdtext = "Create table [REGISTROS]"
                        + "("
                        + "[PK] Varchar(100) NOT NULL, UNIQUE ([PK]),"
                        + "[Fecha] Datetime NOT NULL, UNIQUE ([Fecha]),"
                        + "[id_configuracion] Integer NOT NULL,"
                        + "Primary Key ([PK]) ) ";
            ActualizarDatos(cmdtext);
            cmdtext = "Alter table [REGISTROS] add  foreign key([id_configuracion]) references [CONFIGURACIONES] ([id_configuracion])  on update no action on delete no action ";
            ActualizarDatos(cmdtext);
            cmdtext = "alter table CONFIGURACIONES ADD Version int NULL";
            ActualizarDatos(cmdtext);
            cmdtext = "update configuraciones set version=2";
            ActualizarDatos(cmdtext);
        }
        static public void CrearTablaBancos()
        {
            string cmdtext = "Create table [BANCOS]"
                        + "("
                        + "[id_banco] Integer NOT NULL, UNIQUE ([id_banco]),"
                        + "[Nombre] Varchar(100) NOT NULL,"
                        + "Primary Key ([id_banco]))";
            ActualizarDatos(cmdtext);
             cmdtext = "Create table [CUENTAS_BANCARIAS]"
                        + "("
                        + "[CBU] Varchar(30) NOT NULL, UNIQUE ([CBU]),"
                        + "[id_Persona] Integer NOT NULL,"
                        + "[Titular] Varchar(100) NULL,"
                        + "[Tipo de cuenta] Varchar(50) NULL,"
                        + "[Nro de cuenta] Varchar(100) NULL,"
                        + "[id_banco] Integer NOT NULL,"
                        + "Primary Key ([CBU]))";
            ActualizarDatos(cmdtext);
            cmdtext = "Alter table [CUENTAS_BANCARIAS] add  foreign key([id_Persona]) references [PERSONAS] ([id_Persona])  on update no action on delete no action";
            ActualizarDatos(cmdtext);
            cmdtext = "Alter table [CUENTAS_BANCARIAS] add  foreign key([id_banco]) references [BANCOS] ([id_banco])  on update no action on delete no action";
            ActualizarDatos(cmdtext);
            cmdtext = "ALTER TABLE [COMPRAS-ARTICULOS] "+
                "add constraint FK_COMPRAS_ARTICULOS_codigo foreign key(codigo) "+
                "references ARTICULOS(codigo) "+
                "ON UPDATE CASCADE";
            ActualizarDatos(cmdtext);
            cmdtext = "ALTER TABLE [VENTAS-ARTICULOS] "+
                "add constraint FK_VENTAS_ARTICULOS_codigo foreign key(codigo) "+
                "references ARTICULOS(codigo) "+
                "ON UPDATE CASCADE";
            ActualizarDatos(cmdtext);
        }
        #endregion

        static public void CambiarStockDeRubros2Art()
        {
            string cmdtext = "alter table Articulos ADD StockAlto decimal(11,3) NULL "
                             + "alter table Articulos ADD StockBajo decimal(11,3) NULL "
                             + "alter table Articulos ADD StockMedio decimal(11,3) NULL";
            ActualizarDatos(cmdtext);
            cmdtext = "update Articulos set StockAlto= R.Cant_Alta,StockBajo= R.Cant_Baja,StockMedio= R.Cant_Media from Articulos A inner join Rubros R on A.id_rubro=R.id_rubro";
            ActualizarDatos(cmdtext);
            cmdtext = "Alter table Rubros drop column Cant_media "
                    + "Alter table Rubros drop column Cant_alta "
                    + "Alter table Rubros drop column Cant_baja";
            ActualizarDatos(cmdtext);
        }
        static public void AgregarNombreLogico()
        {
            string cmdtext = "alter table Configuraciones ADD Nombre_logico Varchar(30) NULL";
            ActualizarDatos(cmdtext);
        }
        static public bool ExisteBD()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }

                Desconectar();
                return true;
            }
            catch(Exception ex)
            {
                string z= ex.Message;
                return false;             
            }
        }
        static private void Conectar()
        {
            try
            {
             if (CN.State == ConnectionState.Closed)
             {
                        CN.Open();
             }
            }
            catch
            {
                throw new Exception("Error al conectar!");
            }
        }
        static private void Desconectar()
        {
            try
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }
            }
            catch
            {
                throw new Exception("Error al desconectar!");
            }
        }        
        static public DataTable DevolverDatos(string cmdText)
        {
            try
            {
                DataTable DT = new DataTable();
                SqlCommand cmd = new SqlCommand(cmdText, CN);
                Conectar();
                SqlDataReader DR = cmd.ExecuteReader();
                DT.Load(DR);
                Desconectar();
                return DT;
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        static public void ActualizarDatos(string cmdText)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, CN);
                Conectar();
                cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        static public void ActualizarDatosConEspera(string cmdText)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(cmdText, CN);
                Conectar();
                cmd.ExecuteNonQuery();
                int aux = cmd.CommandTimeout;
                Desconectar();
            }
            catch (SqlException err)
            {
                throw new Exception(err.Message);
            }
        }
        static public void ActualizarDatos(string cmdText,byte[] imagen)
        {
            try
            {

                SqlCommand cmd = new SqlCommand(cmdText, CN);
                //comm.Parameters.Add(new SqlParameter("@Pic", SqlDbType.Image)).Value = arrImage;
                //cmd.Parameters.Add("@Imagen", imagen);
                cmd.Parameters.Add(new SqlParameter("@Imagen", SqlDbType.Image)).Value = imagen;
                
                Conectar();
                cmd.ExecuteNonQuery();
                Desconectar();
            }
            catch (SqlException err)
            {
                 throw new Exception(err.Message);
            }
        }
        static public void CrearTablas() // UNA POR UNA PORQUE TODAS JUNTAS TIRAN ERROR POR TIEMPO DE EJECUCIÓN
        {
            try
            {
                string cmdtext = "Create table [USUARIOS]"
                    + "("
                    + "[id_Usuario] Integer NOT NULL,"
                    + "[Pass] Varchar(4) NULL,"
                    + "[id_Persona] Integer NOT NULL,"
                    + "[id_Permiso] Integer NOT NULL,"
                    + "Primary Key ([id_Usuario])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [ARTICULOS]"
                    + "("
                    + "[Codigo] Varchar(20) NOT NULL,"
                    + "[Stock] Decimal(11,3) NOT NULL,"
                    + "[Costo_Unitario] Decimal(10,2) NULL,"
                    + "[Descripcion] Varchar(200) NOT NULL,"
                    + "[Precio_Unitario] Decimal(10,2) NOT NULL,"
                    + "[Vigente] Bit Default 1 NULL,"
                    + "[id_Rubro] Integer NOT NULL,"
                    + "[id_Medida] Integer NOT NULL,"
                    + "[Nota] Varchar(300) NULL,"
                    + "[IVA] Decimal(4,2) NULL,"
                    + "[StockAlto] decimal(11,3) NULL,"
                    + "[StockBajo] decimal(11,3) NULL,"
                    + "[StockMedio] decimal(11,3) NULL,"
                    + "Primary Key ([Codigo])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [FORMAS_PAGOS]"
                    + "("
                    + "[id_Forma_Pago] Integer NOT NULL,"
                    + "[Descripcion] Varchar(50) NOT NULL, UNIQUE ([Descripcion]),"
                    + "[Porcentaje] Decimal(10,2) NULL,"
                    + "[Descuento] Bit NULL,"
                    + "[Recargo] Bit NULL,"
                    + "[Altera_Caja] Bit Default 0 NULL,"
                    + "[Alta] Bit Default 1 NULL,"
                    + "[Con_Codigo] Bit NULL,"
                    + "Primary Key ([id_Forma_Pago])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [LOCALIDADES]"
                    + "("
                    + "[id_Localidad] Integer NOT NULL,"
                    + "[Nombre] Varchar(20) NOT NULL,"
                    + "[Codigo_postal] Integer NULL,"
                    + "Primary Key ([id_Localidad])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [GASTOS]"
                    + "("
                    + "[id] Integer NOT NULL,"
                    + "[Importe] Decimal(10,2) NOT NULL,"
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[id_Forma_Pago] Integer NOT NULL,"
                    + "[id_concepto] Integer NOT NULL,"
                    + "Primary Key ([id])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [CUENTAS_CORRIENTES]"
                    + "("
                    + "[id_Cuenta_Corriente] Integer NOT NULL,"
                    + "[Saldo] Decimal(10,2) Default (0) NULL,"
                    + "[id_Persona] Integer NULL,"
                    + "[Alta] Bit Default 1 NULL,"
                    + "Primary Key ([id_Cuenta_Corriente])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [RECIBOS_DEBITOS]"
                    + "("
                    + "[Numero] Integer NOT NULL,"
                    + "[Fecha] Datetime NOT NULL,"
                    + "[Concepto] Varchar(100) NOT NULL,"
                    + "[Importe] Decimal(10,2) NOT NULL,"
                    + "[id_Cuenta_Corriente] Integer NOT NULL,"
                    + "[Alta] Bit NULL,"
                    + "Primary Key ([Numero])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [VENTAS]"
                    + "("
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[id_Venta] Integer NOT NULL,"
                    + "[Subtotal] Decimal(10,2) NOT NULL,"
                    + "[Total] Decimal(10,2) NOT NULL,"
                    + "[id_Usuario] Integer NOT NULL,"
                    + "Primary Key ([id_Caja_Diaria],[id_Venta])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [PAGOS_CREDITOS]"
                    + "("
                    + "[Numero] Integer NOT NULL,"
                    + "[Fecha] Datetime NOT NULL,"
                    + "[Concepto] Varchar(100) NOT NULL,"
                    + "[Importe] Decimal(10,2) NOT NULL,"
                    + "[id_Cuenta_Corriente] Integer NOT NULL,"
                    + "[Alta] Bit NULL,"
                    + "Primary Key ([Numero])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COMPRAS]"
                    + "("
                    + "[id_Compra] Integer NOT NULL,"
                    + "[Fecha] Datetime NOT NULL,"
                    + "[Subtotal] Decimal(10,2) NULL,"
                    + "[Descuento_Obtenidos] Decimal(10,2) NULL,"
                    + "[Total] Decimal(10,2) NOT NULL,"
                    + "[id_Forma_Pago] Integer NOT NULL,"
                    + "Primary Key ([id_Compra])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [CAJAS_DIARIAS]"
                    + "("
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[Fecha] Datetime NOT NULL,"
                    + "[Efectivo_Inicial] Decimal(10,2) NOT NULL,"
                    + "[Gastos] Decimal(10,2) NULL,"
                    + "[Cobros] Decimal(10,2) NULL,"
                    + "[Efectivo_Final] Decimal(10,2) NULL,"
                    + "[Ventas_Efectivo] Decimal(10,2) NULL,"
                    + "[Ventas_Otros] Decimal(10,2) NULL,"
                    + "[Ventas_Total] Decimal(10,2) NULL,"
                    + "[Numero] Integer NOT NULL,"
                    + "[Cerrada] Bit Default 0 NULL,"
                    + "Primary Key ([id_Caja_Diaria])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COBROS]"
                    + "("
                    + "[id] Integer NOT NULL,"
                    + "[Importe] Decimal(10,2) NOT NULL,"
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[id_Forma_Pago] Integer NOT NULL,"
                    + "[id_concepto] Integer NOT NULL,"
                    + "Primary Key ([id])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COMPRAS-ARTICULOS]"
                    + "("
                    + "[id_Compra] Integer NOT NULL,"
                    + "[Codigo] Varchar(20) NOT NULL,"
                    + "[Costo] Decimal(10,2) NOT NULL,"
                    + "[Cantidad] Decimal(10,2) NOT NULL,"
                    + "Primary Key ([id_Compra],[Codigo])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [VENTAS-ARTICULOS]"
                    + "("
                    + "[Codigo] Varchar(20) NOT NULL,"
                    + "[id_Venta] Integer NOT NULL,"
                    + "[Cantidad] Decimal(11,3) NOT NULL,"
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[Precio_Uni] Decimal(10,2) NULL,"
                    + "[Desc_Rec_Uni] Decimal(10,2) NULL,"
                    + "Primary Key ([Codigo],[id_Venta],[id_Caja_Diaria])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [PERSONAS]"
                    + "("
                    + "[id_Persona] Integer NOT NULL,"
                    + "[id_Localidad] Integer NOT NULL,"
                    + "[Nombre] Varchar(100) NOT NULL,"
                    + "[Telefono] Varchar(20) NULL,"
                    + "[Celular] Varchar(20) NULL,"
                    + "[Direccion] Varchar(100) NULL,"
                    + "[Mail] Varchar(40) NULL,"
                    + "[Nota] Varchar(300) NULL,"
                    + "Primary Key ([id_Persona])"
                    + ")  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [GASTOS-PAGOS]"
                    + "("
                    + "[id] Integer NOT NULL,"
                    + "[Numero] Integer NOT NULL,"
                    + "Primary Key ([id],[Numero])"
                    + ")  ";
                ActualizarDatos(cmdtext);
                
                cmdtext = "Create table [CLIENTES]"
                    + "("
                    + "[Id_cliente] Integer NOT NULL,"
                    + "[id_Persona] Integer NOT NULL,"
                    + "Primary Key ([Id_cliente])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [PROVEEDORES]"
                    + "("
                    + "[Id_proveedor] Integer NOT NULL,"
                    + "[Cuit] Varchar(20) NULL,"
                    + "[id_Persona] Integer NOT NULL,"
                    + "Primary Key ([Id_proveedor])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COMPRAS-PROVEEDORES]"
                    + "("
                    + "[id_Compra] Integer NOT NULL,"
                    + "[Id_proveedor] Integer NOT NULL,"
                    + "Primary Key ([id_Compra],[Id_proveedor])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [PERMISOS]"
                    + "("
                    + "[id_Permiso] Integer NOT NULL,"
                    + "[Descripcion] Varchar(30) NOT NULL,"
                    + "[usuariosPermisos] Bit NOT NULL,"
                    + "[proovedores] Bit NOT NULL,"
                    + "[cobrosPagos] Bit NOT NULL,"
                    + "[estadTableroControl] Bit NOT NULL,"
                    + "[clientes] Bit NOT NULL,"
                    + "[compras] Bit NOT NULL,"
                    + "[articulos] Bit NOT NULL,"
                    + "[config] Bit NOT NULL,"
                    + "[ctasCtes] Bit NOT NULL,"
                    + "[formaPago] Bit NULL,"
                    + "Primary Key ([id_Permiso])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COBROS-RECIBOS]"
                    + "("
                    + "[id] Integer NOT NULL,"
                    + "[Numero] Integer NOT NULL,"
                    + "Primary Key ([id],[Numero])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [CAJAS]"
                    + "("
                    + "[Numero] Integer NOT NULL,"
                    + "[Nota] Varchar(300) NULL,"
                    + "Primary Key ([Numero])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [RUBROS]"
                    + "("
                    + "[id_Rubro] Integer NOT NULL,"
                    + "[Nombre] Varchar(60) NOT NULL,"
                    + "Primary Key ([id_Rubro])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [CONFIGURACIONES]"
                    + "("
                    + "[id_configuracion] Integer NOT NULL,"
                    + "[Multiusuario] Bit NULL,"
                    + "[Multicaja] Bit NULL,"
                    + "[Pass] Bit NULL,"
                    + "[PorVenta] Bit NULL,"
                    + "[Facturacion] Bit NULL,"
                    + "[Nro_puerto] Integer NULL,"
                    + "[Epson_Samsung] Bit NULL,"
                    + "[PorComision] Bit NULL,"
                    + "[PorcComision] Decimal(10,2) NULL,"
                    + "[OrdenPrioridad] Bit NULL,"
                    + "[OrdenDescForm] Bit NULL,"
                    + "[ExistenciaCompras] Bit NULL,"
                    + "[Modelo] Integer NULL,"
                    + "[IVA] Decimal(4,2) NULL,"
                    + "[Nombre_empresa] Varchar(60) NULL,"
                    + "[HostName] Varchar(40) NULL,"
                    + "[DepositoPrincipal] Integer NULL,"
                    + "[Version] Integer NULL,"
                    + "Primary Key ([id_configuracion])"
                    + ")  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [VENTAS-CREDITOS]"
                    + "("
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[id_Venta] Integer NOT NULL,"
                    + "[Numero] Integer NOT NULL,"
                    + "Primary Key ([id_Caja_Diaria],[id_Venta],[Numero])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COMPRAS-DEBITOS]"
                    + "("
                    + "[id_Compra] Integer NOT NULL,"
                    + "[Numero] Integer NOT NULL,"
                    + "Primary Key ([id_Compra],[Numero])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [MEDIDAS]"
                    + "("
                    + "[id_Medida] Integer NOT NULL,"
                    + "[Nombre] Varchar(20) NOT NULL,"
                    + "[Entera] Bit NULL,"
                    + "Primary Key ([id_Medida])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [CONCEPTOS]"
                    + "("
                    + "[id_concepto] Integer NOT NULL,"
                    + "[Descripcion] Varchar(100) NOT NULL,"
                    + "[perdida] Bit NULL,"
                    + "Primary Key ([id_concepto])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [VENTAS-PAGOS]"
                    + "("
                    + "[id_Forma_Pago] Integer NOT NULL,"
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[id_Venta] Integer NOT NULL,"
                    + "[Importe] Decimal(10,2) NULL,"
                    + "[Codigo_Autorizacion] Varchar(20) NULL,"
                    + "[Descuento] Decimal(10,2) NULL,"
                    + "Primary Key ([id_Forma_Pago],[id_Caja_Diaria],[id_Venta])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [DEBITOS-CREDITOS]"
                    + "("
                    + "[Debito] Integer NOT NULL,"
                    + "[Credito] Integer NOT NULL,"
                    + "Primary Key ([Debito],[Credito])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [REGISTROS]"
                    + "("
                    + "[PK] Varchar(100) NOT NULL, UNIQUE ([PK]),"
                    + "[Fecha] Datetime NOT NULL, UNIQUE ([Fecha]),"
                    + "[id_configuracion] Integer NOT NULL,"
                    + "Primary Key ([PK]) ) ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [PERDIDAS]"
                    + "("
                    + "[id_Perdida] Integer NOT NULL,"
                    + "[Fecha] Datetime NOT NULL,"
                    + "[id_concepto] Integer NOT NULL,"
                    + "[Total] Decimal(10,2) NOT NULL,"
                    + "Primary Key ([id_Perdida])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COMBOS]"
                    + "("
                    + "[id_combo] Integer NOT NULL,"
                    + "[Descripcion] Varchar(20) NOT NULL,"
                    + "[Periodo] Bit NULL,"
                    + "[Precio] Decimal(10,2) NULL,"
                    + "[DiaEspecifico] Bit NULL,"
                    + "[Fecha_Inicio] Datetime NULL,"
                    + "[Fecha_Fin] Datetime NULL,"
                    + "Primary Key ([id_combo])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [COMBOS-ARTICULOS]"
                    + "("
                    + "[Codigo] Varchar(20) NOT NULL,"
                    + "[id_combo] Integer NOT NULL,"
                    + "[Precio] Decimal(10,2) NOT NULL,"
                    + "[Cantidad] Decimal(10,2) NOT NULL,"
                    + "Primary Key ([Codigo],[id_combo])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [VENTAS-COMBOS]"
                    + "("
                    + "[id_combo] Integer NOT NULL,"
                    + "[id_Caja_Diaria] Integer NOT NULL,"
                    + "[id_Venta] Integer NOT NULL,"
                    + "[Cantidad] Integer NOT NULL,"
                    + "Primary Key ([id_combo],[id_Caja_Diaria],[id_Venta])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [PRODUCTOS]"
                    + "("
                    + "[Cod_producido] Varchar(20) NOT NULL,"
                    + "[Cod_base] Varchar(20) NOT NULL,"
                    + "[Cantidad] Decimal(10,2) NOT NULL,"
                    + "Primary Key ([Cod_producido],[Cod_base])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [UBICACIONES]"
                    + "("
                    + "[id_ubicacion] Integer NOT NULL,"
                    + "[Descripcion] Varchar(100) NOT NULL,"
                    + "Primary Key ([id_ubicacion])"
                    + ")  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [UBICACIONES-ARTICULOS]"
                    + "("
                    + "[id_ubicacion] Integer NOT NULL,"
                    + "[Codigo] Varchar(20) NOT NULL,"
                    + "[Stock] Decimal(10,2) NULL,"
                    + "Primary Key ([id_ubicacion],[Codigo])"
                    + ") ";
                ActualizarDatos(cmdtext);
                cmdtext = "Create table [ARTICULOS-PERDIDAS]"
                    + "("
                    + "[id_Perdida] Integer NOT NULL,"
                    + "[Codigo] Varchar(20) NOT NULL,"
                    + "[Cantidad] Decimal(10,2) NOT NULL,"
                    + "[Monto_unitario] Decimal(10,2) NOT NULL,"
                    + "Primary Key ([id_Perdida],[Codigo])"
                    + ") ";
                ActualizarDatos(cmdtext);

                cmdtext = "Alter table [VENTAS] add  foreign key([id_Usuario]) references [USUARIOS] ([id_Usuario])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS-ARTICULOS] add  foreign key([Codigo]) references [ARTICULOS] ([Codigo])  on update no action on delete no action  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-ARTICULOS] add  foreign key([Codigo]) references [ARTICULOS] ([Codigo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMBOS-ARTICULOS] add  foreign key([Codigo]) references [ARTICULOS] ([Codigo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [PRODUCTOS] add  foreign key([Cod_producido]) references [ARTICULOS] ([Codigo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [PRODUCTOS] add  foreign key([Cod_base]) references [ARTICULOS] ([Codigo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [UBICACIONES-ARTICULOS] add  foreign key([Codigo]) references [ARTICULOS] ([Codigo])  on update no action on delete no action";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [ARTICULOS-PERDIDAS] add  foreign key([Codigo]) references [ARTICULOS] ([Codigo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS] add  foreign key([id_Forma_Pago]) references [FORMAS_PAGOS] ([id_Forma_Pago])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [GASTOS] add  foreign key([id_Forma_Pago]) references [FORMAS_PAGOS] ([id_Forma_Pago])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COBROS] add  foreign key([id_Forma_Pago]) references [FORMAS_PAGOS] ([id_Forma_Pago])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-PAGOS] add  foreign key([id_Forma_Pago]) references [FORMAS_PAGOS] ([id_Forma_Pago])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [PERSONAS] add  foreign key([id_Localidad]) references [LOCALIDADES] ([id_Localidad])  on update no action on delete no action";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [GASTOS-PAGOS] add  foreign key([id]) references [GASTOS] ([id])  on update no action on delete no action  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [RECIBOS_DEBITOS] add  foreign key([id_Cuenta_Corriente]) references [CUENTAS_CORRIENTES] ([id_Cuenta_Corriente])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [PAGOS_CREDITOS] add  foreign key([id_Cuenta_Corriente]) references [CUENTAS_CORRIENTES] ([id_Cuenta_Corriente])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COBROS-RECIBOS] add  foreign key([Numero]) references [RECIBOS_DEBITOS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS-DEBITOS] add  foreign key([Numero]) references [RECIBOS_DEBITOS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [DEBITOS-CREDITOS] add  foreign key([Debito]) references [RECIBOS_DEBITOS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-ARTICULOS] add  foreign key([id_Caja_Diaria],[id_Venta]) references [VENTAS] ([id_Caja_Diaria],[id_Venta])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-CREDITOS] add  foreign key([id_Caja_Diaria],[id_Venta]) references [VENTAS] ([id_Caja_Diaria],[id_Venta])  on update no action on delete no action  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-PAGOS] add  foreign key([id_Caja_Diaria],[id_Venta]) references [VENTAS] ([id_Caja_Diaria],[id_Venta])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-COMBOS] add  foreign key([id_Caja_Diaria],[id_Venta]) references [VENTAS] ([id_Caja_Diaria],[id_Venta])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [GASTOS-PAGOS] add  foreign key([Numero]) references [PAGOS_CREDITOS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-CREDITOS] add  foreign key([Numero]) references [PAGOS_CREDITOS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [DEBITOS-CREDITOS] add  foreign key([Credito]) references [PAGOS_CREDITOS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS-ARTICULOS] add  foreign key([id_Compra]) references [COMPRAS] ([id_Compra])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS-PROVEEDORES] add  foreign key([id_Compra]) references [COMPRAS] ([id_Compra])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS-DEBITOS] add  foreign key([id_Compra]) references [COMPRAS] ([id_Compra])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COBROS] add  foreign key([id_Caja_Diaria]) references [CAJAS_DIARIAS] ([id_Caja_Diaria])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [GASTOS] add  foreign key([id_Caja_Diaria]) references [CAJAS_DIARIAS] ([id_Caja_Diaria])  on update no action on delete no action  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS] add  foreign key([id_Caja_Diaria]) references [CAJAS_DIARIAS] ([id_Caja_Diaria])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COBROS-RECIBOS] add  foreign key([id]) references [COBROS] ([id])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [CUENTAS_CORRIENTES] add  foreign key([id_Persona]) references [PERSONAS] ([id_Persona])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [USUARIOS] add  foreign key([id_Persona]) references [PERSONAS] ([id_Persona])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [PROVEEDORES] add  foreign key([id_Persona]) references [PERSONAS] ([id_Persona])  on update no action on delete no action  ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [CLIENTES] add  foreign key([id_Persona]) references [PERSONAS] ([id_Persona])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMPRAS-PROVEEDORES] add  foreign key([Id_proveedor]) references [PROVEEDORES] ([Id_proveedor])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [USUARIOS] add  foreign key([id_Permiso]) references [PERMISOS] ([id_Permiso])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [CAJAS_DIARIAS] add  foreign key([Numero]) references [CAJAS] ([Numero])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [ARTICULOS] add  foreign key([id_Rubro]) references [RUBROS] ([id_Rubro])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [ARTICULOS] add  foreign key([id_Medida]) references [MEDIDAS] ([id_Medida])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [GASTOS] add  foreign key([id_concepto]) references [CONCEPTOS] ([id_concepto])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COBROS] add  foreign key([id_concepto]) references [CONCEPTOS] ([id_concepto])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [PERDIDAS] add  foreign key([id_concepto]) references [CONCEPTOS] ([id_concepto])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [ARTICULOS-PERDIDAS] add  foreign key([id_Perdida]) references [PERDIDAS] ([id_Perdida])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [COMBOS-ARTICULOS] add  foreign key([id_combo]) references [COMBOS] ([id_combo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [VENTAS-COMBOS] add  foreign key([id_combo]) references [COMBOS] ([id_combo])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [UBICACIONES-ARTICULOS] add  foreign key([id_ubicacion]) references [UBICACIONES] ([id_ubicacion])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                cmdtext = "Alter table [REGISTROS] add  foreign key([id_configuracion]) references [CONFIGURACIONES] ([id_configuracion])  on update no action on delete no action ";
                ActualizarDatos(cmdtext);
                
                cmdtext = "Set quoted_identifier on ";
                ActualizarDatos(cmdtext);
                cmdtext = "Set quoted_identifier off ";
                ActualizarDatos(cmdtext);
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        //static public 
    }
}