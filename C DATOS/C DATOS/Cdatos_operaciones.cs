using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_operaciones
    {
        static public bool Actualizar = true;

        static public int DevolverUltimo(string tabla)
        {
            try
            {
                string cmdtext;
                if (tabla == "GASTOS" || tabla == "COBROS")
                    cmdtext = "SELECT top 1 id FROM "+tabla+" order by id desc";
                else
                    cmdtext = "SELECT top 1 numero FROM " + tabla+ " order by numero desc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if(DT.Rows.Count==0)
                    return 0;
                else
                    return Convert.ToInt32(DT.Rows[0][0]);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }

        static public DataTable DevolverCreditos(Ccuenta_corriente obj,bool alta){
            string cmdtext = "SELECT R.numero,R.Concepto,R.Importe,R.fecha,V.id_venta,V.id_caja_diaria,V.subtotal,V.total,P.Importe,P.Codigo_Autorizacion,P.Descuento,P.id_forma_pago FROM [PAGOS_CREDITOS] R left join [Ventas-CREDITOS] C on C.numero=R.numero left join [VENTAS] V on V.id_caja_diaria= C.id_caja_diaria AND V.id_venta= C.id_venta left join [VENTAS-PAGOS] P on V.id_caja_diaria= P.id_caja_diaria AND V.id_venta= P.id_venta where id_cuenta_corriente=" + obj.ID + " and Alta='" + alta + "' order by R.numero desc";
            return cDatos.DevolverDatos(cmdtext);
        }
        static public DataTable DevolverDebitos(Ccuenta_corriente obj, bool alta)
        {
            string cmdtext = "SELECT R.numero,Concepto,Importe,R.fecha,Y.id_compra,Y.subtotal,Y.total,Y.descuento_obtenidos,Y.fecha FROM [RECIBOS_DEBITOS] R left join [Compras-DEBITOS] C on C.numero=R.numero left join [COMPRAS] Y on Y.id_compra= C.id_compra where id_cuenta_corriente=" + obj.ID + " and Alta='" + alta + "'";
            return cDatos.DevolverDatos(cmdtext);
        }
        
        static public DataTable Devolver(string tabla, Ccaja_diaria obj)
        {
            string cmdtext = "SELECT id,id_concepto,Importe,id_forma_pago FROM " + tabla + " where id_caja_diaria=" + obj.ID;
            return cDatos.DevolverDatos(cmdtext);
        }
        static public DataTable DevolverGastosOCobros(string tabla, Ccaja_diaria obj)
        {
            string cmdtext = "SELECT X.id,X.id_concepto,X.Importe,X.id_forma_pago FROM " + tabla + " X where id_caja_diaria=" + obj.ID;
            return cDatos.DevolverDatos(cmdtext);
        }
        static public DataTable DevolverGastosOCobros(string tabla, DateTime fecha)
        {
            string cmdtext = "SELECT X.id,X.id_concepto,X.Importe,X.id_forma_pago, FROM " + tabla + " X inner join [CAJAS_DIARIAS] C on C.id_caja_diaria=X.id_caja_diaria  where C.fecha>" + fecha;
            return cDatos.DevolverDatos(cmdtext);
        }
        static public DataTable DevolverCreditosDeDebitos(Crecibo_debito obj)
        {
            try
            {
                string cmdtext = "SELECT Credito FROM [DEBITOS-CREDITOS] where Debito=" + obj.Numero ;
                return cDatos.DevolverDatos(cmdtext);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverRebibosDePagos(Cpago_credito obj)
        {
            try
            {
                string cmdtext = "SELECT Debito FROM [DEBITOS-CREDITOS] where Credito=" + obj.Numero;
                return cDatos.DevolverDatos(cmdtext);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        //static public DataTable Devolver(int id)
        //{
        //    try
        //    {
        //        String cmdtext = "SELECT id_Localidad,Nombre FROM LOCALIDADES where id_Localidad=" + id;
        //        DataTable DT = cDatos.DevolverDatos(cmdtext);
        //        DataColumn[] PK = new DataColumn[1];
        //        PK[0] = DT.Columns["id_Localidad"];
        //        DT.PrimaryKey = PK;
        //        return DT;
        //    }
        //    catch
        //    {
        //        throw new ArgumentException("Error al devolver localidad");
        //    }

        //}
        static public void Agregar(Ccobro obj,Ccaja_diaria caja)
        {
            try
            {
                string cmdtxt = "INSERT INTO COBROS (id,id_concepto,importe,id_caja_diaria,id_forma_pago) VALUES ("+obj.Numero+"," + obj.ID_Concepto() + ","+((obj.Importe.ToString()).Replace(",","."))+","+caja.ID+","+(obj.FORMAPAGO()).ID+")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion");
            }
        }
        static public void Agregar(Cgasto obj, Ccaja_diaria caja)
        {
            try
            {
                string cmdtxt = "INSERT INTO GASTOS (id,id_concepto,importe,id_caja_diaria,id_forma_pago) VALUES (" + obj.Numero + "," + obj.ID_Concepto() + "," + ((obj.Importe.ToString()).Replace(",", ".")) + "," + caja.ID + "," + (obj.FORMAPAGO()).ID + ")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion");
            }
        }
        static public void Agregar(string tabla,Coperacion obj,Ccuenta_corriente cuenta,string concepto)
        {
            try
            {
                string cmdtxt = "INSERT INTO " + tabla + " (numero,concepto,importe,fecha,id_cuenta_corriente,alta) VALUES (" + obj.Numero + ",'" + concepto + "'," + (obj.Importe.ToString()).Replace(",", ".") + ",'" + obj.Fecha.ToShortDateString() + "'," + cuenta.ID + ",1)";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion");
            }
        }
        static public void AgregarRelacion(Crecibo_debito obj1, Ccobro obj2)
        {
            try
            {
                string cmdtxt = "INSERT INTO [COBROS-RECIBOS] (numero,id) VALUES (" + obj1.Numero + "," + obj2.Numero + ")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion");
            }
        }
        static public void AgregarRelacion(Cpago_credito obj1, Cgasto obj2)
        {
            try
            {
                string cmdtxt = "INSERT INTO [GASTOS-PAGOS] (numero,id) VALUES (" + obj1.Numero + "," + obj2.Numero + ")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion");
            }
        }
        static public void AgregarRelacion(Cpago_credito obj1, Cventa obj2,int id_caja_diaria)
        {
            try
            {
                string cmdtxt = "INSERT INTO [VENTAS-CREDITOS] (numero,id_caja_diaria,id_venta) VALUES (" + obj1.Numero + "," + id_caja_diaria + ","+obj2.ID+")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion venta a creditos");
            }
        }
        static public void AgregarRelacion(Crecibo_debito obj1, Ccompra obj2)
        {
            try
            {
                string cmdtxt = "INSERT INTO [COMPRAS-DEBITOS] (numero,id_compra) VALUES (" + obj1.Numero + "," + obj2.Id + ")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion compra a recibos");
            }
        }
        static public void AgregarRelacion(Cpago_credito obj1,Crecibo_debito  obj2)
        {
            try
            {
                string cmdtxt = "INSERT INTO [DEBITOS-CREDITOS] (debito,credito) VALUES (" + obj2.Numero + "," + obj1.Numero + ")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la operacion debitos a creditos");
            }
        }
        static public bool TieneDebito(Ccobro obj)
        {
            string cmdtext = "SELECT numero FROM [COBROS-RECIBOS] WHERE id=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return false;
            else
                return true;
        }
        //static public DataTable TieneRecibo(Ccobro obj)
        //{
        //    string cmdtext = "SELECT numero,id_cuenta_corriente FROM [COBROS-RECIBOS] WHERE id=" + obj.Numero;
        //    DataTable DT = cDatos.DevolverDatos(cmdtext);
        //    if (DT.Rows.Count == 0)
        //        return false;
        //    else
        //        return true;
        //}
        static public bool TieneCredito(Cgasto obj)
        {
            string cmdtext = "SELECT numero FROM [GASTOS-PAGOS] WHERE id=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return false;
            else
                return true;
        }
        static public int BuscarCuentayCargarCredito(Cgasto obj)
        {
            string cmdtext = "SELECT R.numero,Concepto,Importe,R.fecha,R.id_cuenta_corriente FROM [GASTOS-PAGOS] G inner join [PAGOS_CREDITOS] R on G.numero=R.Numero WHERE id=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            obj.Credito(new Cpago_credito(Convert.ToInt32(DT.Rows[0][0]),DT.Rows[0][1].ToString(),Convert.ToDecimal(DT.Rows[0][2]),Convert.ToDateTime(DT.Rows[0][3]),true));
            return Convert.ToInt32(DT.Rows[0][4]);
        }
        static public int BuscarCuentayCargarDebito(Ccobro obj)
        {
            string cmdtext = "SELECT R.numero,Concepto,Importe,R.fecha,R.id_cuenta_corriente FROM [COBROS-RECIBOS] G inner join [RECIBOS_DEBITOS] R on G.numero=R.Numero WHERE id=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            obj.Debito(new Crecibo_debito(Convert.ToInt32(DT.Rows[0][0]),DT.Rows[0][1].ToString(),Convert.ToDecimal(DT.Rows[0][2]),Convert.ToDateTime(DT.Rows[0][3]),true));
            return Convert.ToInt32(DT.Rows[0][4]);
        }
        static public bool TieneGasto(Cpago_credito obj)
        {
            string cmdtext = "SELECT id FROM [GASTOS-PAGOS] WHERE numero=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return false;
            else
                return true;
        }
        static public bool TieneCobro(Crecibo_debito obj)
        {
            string cmdtext = "SELECT id FROM [COBROS-RECIBOS] WHERE numero=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return false;
            else
                return true;
        }

        static public void Eliminar(Ccobro obj)
        {
            string cmdtext = "SELECT numero FROM [COBROS-RECIBOS] WHERE id=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count != 0)
            {
                cmdtext = "DELETE FROM [COBROS-RECIBOS] WHERE id=" + obj.Numero;
                cDatos.ActualizarDatos(cmdtext);
                foreach (DataRow R in DT.Rows)
                {
                    cmdtext = "DELETE FROM [RECIBOS-DEBITOS] WHERE numero=" + R[0].ToString();
                    cDatos.ActualizarDatos(cmdtext);
                }
            }
            cmdtext = "DELETE FROM COBROS WHERE id=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
            Actualizar = true;
        }
        static public void Eliminar(Cgasto obj)
        {
            string cmdtext = "SELECT numero FROM [GASTOS-PAGOS] WHERE id=" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count != 0)
            {
                cmdtext = "DELETE FROM [GASTOS-PAGOS] WHERE id=" + obj.Numero;
                cDatos.ActualizarDatos(cmdtext);
                foreach (DataRow R in DT.Rows)
                {
                    cmdtext = "DELETE FROM [PAGOS-CREDITOS] WHERE numero=" + R[0].ToString();
                    cDatos.ActualizarDatos(cmdtext);
                }
            }
            cmdtext = "DELETE FROM GASTOS WHERE id=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
            Actualizar = true;
        }
        //static public void Eliminar(Crecibo_debito obj)
        //{
        //    string cmdtext = "SELECT id FROM [COBROS-RECIBOS] WHERE numero=" + obj.Numero;
        //    DataTable DT = cDatos.DevolverDatos(cmdtext);
        //    if (DT.Rows.Count != 0)
        //    {
        //        cmdtext = "DELETE FROM [COBROS-RECIBOS] WHERE numero=" + obj.Numero;
        //        cDatos.ActualizarDatos(cmdtext);
        //        foreach (DataRow R in DT.Rows)
        //        {
        //            cmdtext = "DELETE FROM COBROS WHERE id=" + R[0].ToString();
        //            cDatos.ActualizarDatos(cmdtext);
        //        }
        //    }
        //    cmdtext = "DELETE FROM [RECIBOS-DEBITOS] WHERE numero=" + obj.Numero;
        //    cDatos.ActualizarDatos(cmdtext);
        //    Actualizar = true;
        //}
        static public void EliminarReferenciaDe(string tabla,Coperacion obj)
        {
            string cmdtext = "DELETE FROM "+tabla+" WHERE numero=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void EliminarReferenciaDebitosCreditos(string columna, Coperacion obj)
        {
            string cmdtext = "DELETE FROM [DEBITOS-CREDITOS] WHERE " + columna + "=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void EliminarReferenciaDe(Ccobro obj)
        {
            string cmdtext = "DELETE FROM [COBROS-RECIBOS] WHERE id=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void EliminarReferenciaDe(Cgasto obj)
        {
            string cmdtext = "DELETE FROM [GASTOS-PAGOS] WHERE id=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void Eliminar(string tabla,Coperacion obj)
        {
            string cmdtext = "DELETE FROM "+tabla+" WHERE numero=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void Eliminar(string tabla,Ccuenta_corriente obj)
        {
            string cmdtext = "DELETE FROM "+tabla+" WHERE id_cuenta_corriente=" + obj.ID;
            cDatos.ActualizarDatos(cmdtext);
        }
        //static public void Eliminar(Cpago_credito obj)
        //{
        //    string cmdtext = "SELECT id FROM [GASTOS-PAGOS] WHERE numero=" + obj.Numero;
        //    DataTable DT = cDatos.DevolverDatos(cmdtext);
        //    if (DT.Rows.Count != 0)
        //    {
        //        cmdtext = "DELETE FROM [GASTOS-PAGOS] WHERE numero=" + obj.Numero;
        //        cDatos.ActualizarDatos(cmdtext);
        //        foreach (DataRow R in DT.Rows)
        //        {
        //            cmdtext = "DELETE FROM GASTOS WHERE id=" + R[0].ToString();
        //            cDatos.ActualizarDatos(cmdtext);
        //        }
        //    }
        //    cmdtext = "DELETE FROM [PAGOS-CREDITOS] WHERE numero=" + obj.Numero;
        //    cDatos.ActualizarDatos(cmdtext);
        //    Actualizar = true;
        //}
        static public void ModificarGasto(Cgasto obj, Cforma_pago objformapago)
        {
            try
            {
                string cmdtxt = "UPDATE GASTOS SET id_concepto = " + obj.ID_Concepto() + ",importe=" + (obj.Importe.ToString()).Replace(",", ".") + ",id_forma_pago=" +objformapago.ID+ " WHERE id=" + obj.Numero;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar la operacion");
            }
        }
        static public void ModificarCobro(Ccobro obj, Cforma_pago objformapago)
        {
            try
            {
                string cmdtxt = "UPDATE COBROS SET id_concepto = " + obj.ID_Concepto() + ",importe=" + (obj.Importe.ToString()).Replace(",", ".") + ",id_forma_pago=" + objformapago.ID + " WHERE id=" + obj.Numero;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar la operacion");
            }
        }
        static public void Modificar(string tabla, Coperacion obj,bool alta,string concepto)
        {
            try
            {
                string cmdtxt = "UPDATE " + tabla + " SET alta='"+alta+"' ,concepto = '" + concepto + "',importe=" + (obj.Importe.ToString()).Replace(",", ".") + ",fecha='" + obj.Fecha.ToShortDateString() + "' WHERE numero=" + obj.Numero;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar la operacion");
            }
        }
        static public void DarDeBajas(Ccuenta_corriente obj)
        {
            try
            {
                string cmdtxt = "UPDATE [PAGOS_CREDITOS] SET alta = 0 WHERE id_cuenta_corriente=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
                cmdtxt = "UPDATE [RECIBOS_DEBITOS] SET alta = 0 WHERE id_cuenta_corriente=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al modificar la operacion");
            }
        }
    }
}
