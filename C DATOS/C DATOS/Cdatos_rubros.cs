using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class Cdatos_rubros
    {
        static public bool ReferenciasExistentes(Crubro obj)
        {
            String cmdtext = "SELECT P.id_rubro FROM ARTICULOS P  where P.id_rubro=" + obj.Nro;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        static public void CambiarDeArticulos(Crubro objviejo, Crubro objnuevo)
        {
            string cmdtxt = "UPDATE ARTICULOS SET id_rubro = " + objnuevo.Nro + " WHERE id_rubro =" + objviejo.Nro;
            cDatos.ActualizarDatos(cmdtxt);
        }

        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_rubro,Nombre FROM RUBROS order by id_rubro desc";
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
                String cmdtext = "SELECT id_rubro,Nombre FROM RUBROS where id_rubro=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver localidad");
            }

        }

        static public void Agregar(Crubro oRubro)
        {
            try
            {
                string cmdtxt = "INSERT INTO RUBROS (id_rubro,nombre) VALUES (" + oRubro.Nro + ",'" + oRubro.Nombre + "')";
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al cargar rubro");
            }
        }

        static public void Eliminar(Crubro oRubro)
        {
            string cmdtext = "DELETE FROM RUBROS WHERE id_rubro=" + oRubro.Nro;
            cDatos.ActualizarDatos(cmdtext);
            
        }
        
   
        static public void Modificar(Crubro oRubro)
        {
            try
            {
                string cmdtxt = "UPDATE RUBROS SET NOMBRE = '" + oRubro.Nombre + "' wHERE id_rubro =" + oRubro.Nro;
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al modificar rubro");
            }

        }  
    }
}
