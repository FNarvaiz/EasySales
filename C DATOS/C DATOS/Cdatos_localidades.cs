using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_localidades
    {
        static public bool Actualizar = true;

        static public bool ReferenciasExistentes(Clocalidad obj)
        {
            String cmdtext = "SELECT P.id_localidad FROM PERSONAS P  where P.id_localidad=" + obj.ID;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        static public void CambiarDePersonas(Clocalidad objviejo, Clocalidad objnuevo)
        {
            string cmdtxt = "UPDATE PERSONAS SET id_localidad = " + objnuevo.ID + " WHERE id_Localidad =" + objviejo.ID;
            cDatos.ActualizarDatos(cmdtxt);
        }

        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_localidad,Nombre as Localidad FROM LOCALIDADES";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                DataColumn[] PK = new DataColumn[1];
                PK[0] = DT.Columns["id_localidad"];
                DT.PrimaryKey = PK;
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }

        }

        static public Clocalidad Devolver(string nombre)
        {
            String cmdtext = "SELECT id_Localidad,Nombre FROM LOCALIDADES where Nombre='" + nombre + "'";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count > 0)
                return new Clocalidad(Convert.ToInt32(DT.Rows[0][0]), DT.Rows[0][0].ToString());
            return null;
        }

        static public DataTable Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT id_Localidad,Nombre FROM LOCALIDADES where id_Localidad=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                DataColumn[] PK = new DataColumn[1];
                PK[0] = DT.Columns["id_Localidad"];
                DT.PrimaryKey = PK;
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver localidad");
            }

        }

        static public void Agregar(Clocalidad oLocalidad)
        {
            try
            {
                string cmdtxt = "INSERT INTO LOCALIDADES (id_localidad,nombre) VALUES ("+oLocalidad.ID+",'" + oLocalidad.Nombre + "')";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar localidad");
            }
        }

        static public void Eliminar(Clocalidad oLocalidad)
        {
                string cmdtext = "DELETE FROM LOCALIDADES WHERE id_Localidad=" + oLocalidad.ID;
                cDatos.ActualizarDatos(cmdtext);
                Actualizar = true;
        }

        static public void Modificar(Clocalidad oLocalidad)
        {
            try
            {
                string cmdtxt = "UPDATE LOCALIDADES SET NOMBRE = '" + oLocalidad.Nombre + "' WHERE id_Localidad =" + oLocalidad.ID;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar localidad");
            }

        }  
    }
}
