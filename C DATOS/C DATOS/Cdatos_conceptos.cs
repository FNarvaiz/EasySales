using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using System.Data;
namespace C_DATOS
{
    public class Cdatos_conceptos
    {
        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_concepto,descripcion FROM CONCEPTOS";
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
        static public void Agregar(Cconcepto obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO CONCEPTOS (id_concepto,descripcion) VALUES(" + obj.ID + ",'" + obj.Concepto + "')";
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al cargar el concepto.");
            }
        }
        static public void EliminarReferencias(Cconcepto obj)
        {

            string cmdtext = "DELETE FROM [GASTOS] WHERE id_concepto=" + obj.ID ;
            cDatos.ActualizarDatos(cmdtext);
            cmdtext = "DELETE FROM [COBROS] WHERE id_concepto=" + obj.ID ;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public bool TieneReferencias(Cconcepto obj)
        {
            String cmdtext = "SELECT id_cpncepto FROM [COBROS] WHERE id_concepto=" + obj.ID ;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count > 0)
                return true;
            cmdtext = "SELECT id_concepto FROM [GASTOS] WHERE id_concepto=" + obj.ID ;
            DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        static public void Eliminar(Cconcepto obj)
        {
            string cmdtext = "DELETE FROM CONCEPTOS WHERE id_concepto = " + obj.ID ;
            cDatos.ActualizarDatos(cmdtext);

        }
        static public void Modificar(Cconcepto obj)
        {
            try
            {
                string cmdtxt = "UPDATE CONCEPTOS SET  descripcion= '" + obj.Concepto + "' WHERE id_concepto=" + obj.ID ;
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar concepto");
            }
        }
    }
}
