using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;

namespace C_DATOS
{
    public class  Cdatos_personas
    {
        static public DataTable DevolverUltimo()
        {
            String cmdtext = "SELECT top 1 id_persona,nombre,telefono,celular,direccion,mail FROM PERSONAS order by id_persona desc";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            return DT;
        }
        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_persona,nombre,telefono,celular,direccion,mail FROM PERSONAS ";
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
                String cmdtext = "SELECT id_persona,nombre,telefono,celular,direccion,mail FROM PERSONAS where id_persona=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if (DT.Rows.Count == 0)
                    return null;
                else
                    return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver Forma de pago");
            }

        }
        static public void Agregar(Cpersona obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO PERSONAS (id_persona,nombre,telefono,celular,direccion,mail,id_localidad) VALUES("+obj.ID+",'" + obj.Nombre + "','" + obj.Tel + "','" + obj.Cel + "','" + obj.Domicilio + "','" + obj.Email + "'," + (obj.LOCALIDAD()).ID + ")";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al cargar la persona");
            }
        }        
        static public void Eliminar(Cpersona obj)
        {
            string cmdtext = "DELETE FROM PERSONAS WHERE id_persona=" + obj.ID;
            cDatos.ActualizarDatos(cmdtext);
            
        }
        static public void Modificar(Cpersona obj)
        {
            try
            {
                string cmdtxt = "UPDATE PERSONAS SET nombre = '" + obj.Nombre + "',direccion='" + obj.Domicilio + "' ,telefono='" + obj.Tel + "',celular='" + obj.Cel + "',mail='"+obj.Email+"',id_localidad=" + (obj.LOCALIDAD()).ID + "WHERE id_persona=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al modificar la forma de pago");
            }
        }
        static public void BajaoAlta(Cpersona obj,bool Alta)
        {
            try
            {
                string cmdtxt = "UPDATE [CUENTAS_CORRIENTES] SET alta='" + Alta + "' WHERE id_persona=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar el alta de la persona.");
            }
        }
    }
}
