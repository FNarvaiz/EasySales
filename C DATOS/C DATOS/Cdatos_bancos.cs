using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;

namespace C_DATOS
{
    public class Cdatos_bancos
    {
        static public bool Actualizar = true;

        static public bool ReferenciasExistentes(Cbanco obj)
        {
            String cmdtext = "SELECT id_banco FROM CUENTAS_BANCARIAS where id_banco=" + obj.ID;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        static public DataTable Devolver()
        {
            try
            {
                string cmdtext = "SELECT id_banco, nombre FROM BANCOS ORDER BY id_banco DESC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                DataColumn[] PK = new DataColumn[1];
                PK[0] = DT.Columns["id_banco"];
                DT.PrimaryKey = PK;
                return DT;
            }
            catch 
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public void Agregar(Cbanco obj)
        {
            try
            {
                string cmdtext = "INSERT INTO BANCOS (id_banco, nombre) VALUES(" + obj.ID + ",'" + obj.NOMBRE + "')";
                cDatos.ActualizarDatos(cmdtext);
                Actualizar = true;
            }
            catch { }
        }
        static public void Modificar(Cbanco obj) 
        {
            try
            {
                string cmd = "UPDATE BANCOS SET Nombre='" + obj.NOMBRE + "' WHERE id_banco=" + obj.ID;
                cDatos.ActualizarDatos(cmd);
                Actualizar = true;
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        static public void Eliminar(Cbanco obj)
        {
            try
            {
                string cmd = "DELETE FROM BANCOS WHERE id_banco=" + obj.ID;
                cDatos.ActualizarDatos(cmd);
                Actualizar = true;
            }
            catch(Exception ex) 
            {
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
