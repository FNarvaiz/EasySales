using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_cuentas_corrientes
    {
        static public bool Actualizar = true;

        static public DataTable DevolverDeProveedores(bool LosDeAlta)
        {
            try
            {
                String cmdtext = "SELECT id_proveedor,id_cuenta_corriente,saldo FROM [CUENTAS_CORRIENTES] C inner join PERSONAS P on P.id_persona=C.id_persona inner join PROVEEDORES K on K.id_persona=C.id_persona inner join LOCALIDADES L on L.id_localidad= P.id_localidad where C.Alta='"+LosDeAlta+"'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public int DevolverUltimo()
        {
            String cmdtext = "SELECT top 1 id_cuenta_corriente FROM [CUENTAS_CORRIENTES] order by id_cuenta_corriente desc";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return 0;
            else
                return Convert.ToInt32(DT.Rows[0][0]);
        }
        static public DataTable DevolverDeClientes(bool LosDeAlta)
        {
            try
            {
                String cmdtext = "SELECT id_cliente,id_cuenta_corriente,saldo FROM CLIENTES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad= C.id_localidad inner join [CUENTAS_CORRIENTES] K on K.id_persona=C.id_persona where K.Alta='" + LosDeAlta + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }        
        //static public Ccuenta_corriente Devolver(int id_persona)
        //{
        //    try
        //    {
        //        String cmdtext = "SELECT id_cuenta_corriente,saldo FROM [CUENTAS_CORRIENTES] where id_persona=" + id_persona;
        //        DataTable DT = cDatos.DevolverDatos(cmdtext);
        //        if (DT.Rows.Count == 0)
        //            return null;
        //        else
        //            return new Ccuenta_corriente(Convert.ToInt32(DT.Rows[0][0]), Convert.ToDecimal(DT.Rows[0][1]));
        //    }
        //    catch
        //    {
        //        throw new ArgumentException("Error al devolver la cuenta corriente");
        //    }
        ////}
        //static public bool TieneDebitosoCreditos(Ccuenta_corriente obj){
        //    String cmdtext = "SELECT Cid_cuenta_corriente FROM [CUENTAS_CORRIENTES]C where id_persona=" + obj.ID;
        //    DataTable DT = cDatos.DevolverDatos(cmdtext);
        //    if (DT.Rows.Count == 0)
        //        return false;
        //    return true;
        //} 
        static public void Agregar(Ccuenta_corriente obj,Cpersona objpersona)
        {
            try
            {
                string cmdtxt = "INSERT INTO [CUENTAS_CORRIENTES] (alta,id_cuenta_corriente,saldo,id_persona) VALUES(1," + obj.ID + "," + obj.Saldo + "," + objpersona.ID + ")";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la cuenta corriente");
            }
        }
        static public void Eliminar(Ccuenta_corriente obj)
        {
            string cmdtext = "DELETE FROM [CUENTAS_CORRIENTES] WHERE id_cuenta_corriente=" + obj.ID;
            cDatos.ActualizarDatos(cmdtext);
            Actualizar = true;
        }
        static public void CambiarAlta(Ccuenta_corriente obj,bool alta)
        {
            try
            {
                string cmdtxt = "UPDATE [CUENTA_CORRIENTE] SET alta ='"+alta+"'  WHERE id_cuenta_corriente=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar la forma de pago");
            }
        }
        static public void Modificar(Ccuenta_corriente obj)
        {
            try
            {

                string cmdtxt = "UPDATE [CUENTAS_CORRIENTES] SET saldo = " + (obj.Saldo.ToString()).Replace(",",".") + " WHERE id_cuenta_corriente=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar la forma de pago");
            }
        }  

    }
}
