using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using System.Data;
namespace C_DATOS
{
    public class Cdatos_cajas
    {
        static public DataTable DevovlerTodos()
        {
            try
            {
                String cmdtext = "SELECT numero FROM CAJAS";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public int CantidadDeCajas()
        {
            try
            {
                String cmdtext = "SELECT count(numero) FROM CAJAS";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return Convert.ToInt32(DT.Rows[0][0]);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public void Agregar(Ccaja obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO CAJAS (numero) VALUES (" + obj.Numero + ")";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al cargar localidad");
            }
        }

        static public void Eliminar(Ccaja obj)
        {
            string cmdtext = "DELETE FROM CAJAS WHERE numero=" + obj.Numero;
            cDatos.ActualizarDatos(cmdtext);

        }

        static public void Modificar(Ccaja objviejo,Ccaja objnuevo)
        {
            try
            {
                string cmdtxt = "UPDATE CAJAS SET numero = " + objnuevo.Numero + " WHERE numero =" + objviejo.Numero;
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al modificar localidad");
            }

        }
        static public bool ReferenciasExistentes(Ccaja obj)
        {
            String cmdtext = "SELECT P.numero FROM [CAJAS_DIARIAS] P  where P.numero =" + obj.Numero;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }

    }
}
