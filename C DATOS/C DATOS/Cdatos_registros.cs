using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using System.Data;
namespace C_DATOS
{
    public static class Cdatos_registros
    {
        static List<Cregistro> Registros = new List<Cregistro>();
        static public List<Cregistro> Devolver(Cconfiguracion oconf)
        {
            try
            {
                if (Registros.Count == 0)
                {
                    String cmdtext = "SELECT fecha,PK FROM REGISTROS where id_configuracion=" + oconf.ID;
                    DataTable DT = cDatos.DevolverDatos(cmdtext);
                    foreach (DataRow DR in DT.Rows)
                        Registros.Add(new Cregistro(Convert.ToDateTime(DR[0]), DR[1].ToString()));
                }
                return Registros;
            }
            catch
            {
                throw new ArgumentException("Error al devolver registros");
            }

        }
        static public bool ClaveCorrecta(string ClaveActual)
        {
            foreach (Cregistro oreg in Registros)
            {
                if (oreg.Clave == ClaveActual)
                {
                    return false;
                }
            }
            return true;
        }

        static public void Agregar(Cregistro oregistro, Cconfiguracion oconf)
        {
            try
            {
                string cmdtxt = "INSERT INTO REGISTROS (fecha,PK,id_configuracion) VALUES ('" + oregistro.Fecha.ToShortDateString()+"','" + oregistro.Clave + "',"+ oconf.ID+")";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al agregar registro");
            }
        }
    }
}
