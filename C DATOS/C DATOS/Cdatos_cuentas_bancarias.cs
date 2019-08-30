using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;

namespace C_DATOS
{
    public class Cdatos_cuentas_bancarias
    {
        static public void Agregar(Ccuenta_bancaria obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO [CUENTAS_BANCARIAS] (cbu,id_persona,titular,[tipo de cuenta],[nro de cuenta],id_banco) VALUES('" + obj.CBU + "'," + obj.PERSONA.ID + ",'" + obj.TITULAR + "','" + obj.TIPO_CUENTA + "','" + obj.NRO_CUENTA + "'," + obj.BANCO.ID + ")";
                cDatos.ActualizarDatos(cmdtxt);                
            }
            catch
            {
                throw new ArgumentException("Error al cargar la cuenta bancaria");
            }
        }
        static public void Eliminar(string cbu) 
        {
            try
            {
                string cmdtext = "DELETE FROM [CUENTAS_BANCARIAS] WHERE cbu='" + cbu + "'";
                cDatos.ActualizarDatos(cmdtext);
            }
            catch
            {
                throw new Exception("Error al eliminar la cuenta bancaria");
            }
        }
        static public DataTable DevolverCuentasBancarias()
        {
            try
            {
                string cmd = "SELECT Titular, CBU,[Nro de cuenta] as [Nro cuenta],[Tipo de cuenta] as [Tipo cuenta],B.Nombre Banco FROM CUENTAS_BANCARIAS C"
                                     + " INNER JOIN PERSONAS P ON P.id_Persona=C.id_Persona"
                                     + " INNER JOIN BANCOS B ON B.id_banco=C.id_banco";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos desde la BD ");
            }
        }
        static public DataTable DevolverCuentasBancarias(Cpersona opersona)
        {
            try
            {
                string cmd = "SELECT Titular, CBU,[Nro de cuenta] as [Nro cuenta],[Tipo de cuenta] as [Tipo cuenta],B.Nombre Banco FROM CUENTAS_BANCARIAS C"
                                     + " INNER JOIN PERSONAS P ON P.id_Persona=C.id_Persona"
                                     + " INNER JOIN BANCOS B ON B.id_banco=C.id_banco"
                                     + " WHERE p.id_persona=" + opersona.ID.ToString();
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos desde la BD ");
            }
        }
        static public DataTable DevolverCuentaBancaria(string cbu)
        {
            try
            {
                string cmd = "SELECT Titular, CBU,[Nro de cuenta] as [Nro cuenta],[Tipo de cuenta] as [Tipo cuenta],B.Nombre Banco FROM CUENTAS_BANCARIAS C"
                                     + " INNER JOIN PERSONAS P ON P.id_Persona=C.id_Persona"
                                     + " INNER JOIN BANCOS B ON B.id_banco=C.id_banco"
                                     + " WHERE cbu=" + cbu;
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos desde la BD ");
            }
        }
    }
}
