using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    static public class Cdatos_reportes
    {
        static public DataTable StockBajo()
        {
            try
            {
                String cmdtext = "SELECT Codigo,Descripcion,Stock,M.nombre as Medida FROM ARTICULOS A inner join Rubros R on A.id_rubro=R.id_rubro inner join MEDIDAS M on M.id_medida=A.id_Medida where vigente=1 and R.cant_baja>=A.stock ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable StockMedio()
        {
            try
            {
                String cmdtext = "SELECT Codigo,Descripcion,Stock,M.nombre as Medida FROM ARTICULOS A inner join Rubros R on A.id_rubro=R.id_rubro inner join MEDIDAS M on M.id_medida=A.id_Medida where vigente=1 and R.cant_baja<A.stock and R.cant_media>=A.stock ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable StockAlto()
        {
            try
            {
                String cmdtext = "SELECT Codigo,Descripcion,Stock,M.nombre as Medida FROM ARTICULOS A inner join Rubros R on A.id_rubro=R.id_rubro inner join MEDIDAS M on M.id_medida=A.id_Medida where vigente=1 and R.cant_alta<A.stock ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable StockTodos()
        {
            try
            {
                String cmdtext = "SELECT Codigo,Descripcion,Stock,M.nombre as Medida FROM ARTICULOS A inner join Rubros R on A.id_rubro=R.id_rubro inner join MEDIDAS M on M.id_medida=A.id_Medida where vigente=1 ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable PreciosGondolas()
        {
            try
            {
                String cmdtext = "SELECT Codigo,Descripcion,Stock,M.nombre,A.precio as Medida FROM ARTICULOS A inner join Rubros R on A.id_rubro=R.id_rubro inner join MEDIDAS M on M.id_medida=A.id_Medida where vigente=1 ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverDebitos(Ccuenta_corriente obj)
        {
            string cmdtext = "SELECT Concepto,R.Fecha,Alta,Importe FROM [RECIBOS_DEBITOS] R left join [Compras-DEBITOS] C on C.numero=R.numero left join [COMPRAS] Y on Y.id_compra= C.id_compra where id_cuenta_corriente=" + obj.ID;
            return cDatos.DevolverDatos(cmdtext);
        }
        static public DataTable DevolverCreditos(Ccuenta_corriente obj)
        {
            string cmdtext = "SELECT Concepto,Importe,R.Fecha,Alta FROM [PAGOS_CREDITOS] R left join [Ventas-CREDITOS] C on C.numero=R.numero left join [VENTAS] V on V.id_caja_diaria= C.id_caja_diaria AND V.id_venta= C.id_venta where id_cuenta_corriente=" + obj.ID;
            return cDatos.DevolverDatos(cmdtext);
        }
        static public DataTable CuentasClientes(bool Alta)
        {
            try
            {
                String cmdtext = "SELECT C.Nombre,Y.Saldo,Telefono,Direccion,Celular,Mail,L.Nombre as Localidad FROM CLIENTES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.Alta='" + Alta + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable CuentasUsuarios(bool altas)
        {
            try
            {
                String cmdtext = "SELECT C.Nombre,Y.Saldo,Telefono,Direccion,Celular,Mail,L.Nombre as Localidad FROM USUARIOS P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.Alta='" + altas + "' order by id_usuario";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }              
        static public DataTable CuentasProveedores(bool altas)
        {
            try
            {
                String cmdtext = "select C.Nombre,Y.Saldo,Telefono,Direccion,Celular,Mail,L.Nombre as Localidad FROM PROVEEDORES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.alta='" + altas + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable Proveedores(bool altas)
        {
            try
            {
                String cmdtext = "select C.Nombre,Telefono,Direccion,Celular,Mail,Cuit,L.Nombre as Localidad FROM PROVEEDORES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.alta='" + altas + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable Clientes(bool Alta)
        {
            try
            {
                String cmdtext = "SELECT C.Nombre,Telefono,Direccion,Celular,Mail,L.Nombre as Localidad FROM CLIENTES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.Alta='" + Alta + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable Usuarios(bool altas)
        {
            try
            {
                String cmdtext = "SELECT C.Nombre,Telefono,Direccion,Celular,Mail,L.Nombre as Localidad,K.Descripcion as Permiso FROM USUARIOS P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona inner join Permisos K on K.id_permiso= P.Id_permiso where Y.Alta='" + altas+"'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }   
        static public DataTable VentasDia(string Fecha)
        {
            try
            {
                String cmdtext = "SELECT V.id_venta,Subtotal,Total,Importe,Codigo_Autorizacion,P.Descuento,F.Descripcion FROM VENTAS V inner join [Cajas_diarias] K on K.id_caja_diaria=V.id_caja_diaria inner join [VENTAS-PAGOS] P on P.id_venta=V.id_venta inner join [FORMAS_PAGOS] F on F.id_forma_pago=P.id_forma_pago and K.id_caja_diaria=P.id_caja_diaria  where K.fecha='" + Fecha + "' order by id_venta asc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
    }
}
