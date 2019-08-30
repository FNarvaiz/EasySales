using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using System.Data;
namespace C_DATOS
{
    public class Cdatos_medidas
    {
        static public bool ReferenciasExistentes(Cmedida obj)
        {
            String cmdtext = "SELECT P.id_medida FROM ARTICULOS P  where P.id_medida=" + obj.ID;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        static public void CambiarDeArticulos(Cmedida objviejo, Cmedida objnuevo)
        {
            string cmdtxt = "UPDATE ARTICULOS SET id_medida = " + objnuevo.ID + " WHERE id_medida =" + objviejo.ID;
            cDatos.ActualizarDatos(cmdtxt);
        }

        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_medida,Nombre,Entera FROM MEDIDAS order by id_medida asc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }

        }

        static public DataTable Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT id_medida,Nombre,entera FROM MEDIDAS where id_medida=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver medidas.");
            }

        }

        static public void Agregar(Cmedida obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO MEDIDAS (id_medida,nombre,entera) VALUES (" + obj.ID + ",'" + obj.Nombre + "','"+obj.Entero+"')";
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al guardar medida.");
            }
        }

        static public void Eliminar(Cmedida obj)
        {
            string cmdtext = "DELETE FROM MEDIDAS WHERE id_medida=" + obj.ID;
            cDatos.ActualizarDatos(cmdtext);

        }


        static public void Modificar(Cmedida obj)
        {
            try
            {
                string cmdtxt = "UPDATE MEDIDAS SET NOMBRE = '" + obj.Nombre + "' WHERE id_medida =" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar la medida.");
            }
        }  
    }
}
