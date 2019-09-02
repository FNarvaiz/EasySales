using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using System.Globalization;
namespace C_DATOS
{
    public class  Cdatos_cajas_diarias
    {
        static DateTime _UltimaFecha;
        static public DateTime UltimaFecha
        {
            get
            {
                return _UltimaFecha;
            }
        }

        static private string SacarComa(decimal obj)
        {
            return (obj.ToString()).Replace(",", ".");
        }
        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_caja,fecha,efectivo_inicial,efectivo_final,ventas_efectivo,ventas_otros,ventas_total,gastos,cobros FROM [CAJAS_DIARIAS] ";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverGastos(string desde, string hasta)
        {
            try
            {
                string cmd = "select G.id as [Nro],P.Descripcion as Concepto,Fecha as Caja,Importe,F.Descripcion as Formadepago FROM GASTOS G inner join CONCEPTOS P on P.id_concepto=G.id_concepto INNER JOIN CAJAS_DIARIAS C ON C.id_Caja_Diaria = G.id_CAJA_DIARIA INNER JOIN [FORMAS_PAGOS] F ON F.id_forma_pago = G.id_forma_pago WHERE C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "'" ;
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;

            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverCobros(string desde, string hasta)
        {
            try
            {
                string cmd = "select G.id as [Nro],P.Descripcion as Concepto,Fecha as Caja,Importe,F.Descripcion as Formadepago FROM COBROS G inner join CONCEPTOS P on P.id_concepto=G.id_concepto INNER JOIN CAJAS_DIARIAS C ON C.id_Caja_Diaria = G.id_CAJA_DIARIA INNER JOIN [FORMAS_PAGOS] F ON F.id_forma_pago = G.id_forma_pago WHERE C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "'";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable Devolver(string desde,string hasta)
        {
            try
            {
                String cmdtext = "SELECT id_caja_diaria,Fecha,Efectivo_inicial,Efectivo_final,Ventas_efectivo,Ventas_otros,Ventas_total,Gastos,Cobros FROM [CAJAS_DIARIAS] WHERE fecha BETWEEN '" + desde + "' AND '" + hasta + "' and cerrada=1 order by fecha desc ";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public bool CajaCerrada(Ccaja_diaria obj)
        {
            try
            {
                String cmdtext = "SELECT cerrada FROM [CAJAS_DIARIAS] WHERE id_caja_diaria=" + obj.ID;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return Convert.ToBoolean(DT.Rows[0][0]);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public int CantidadDeCajas(string desde){
            try
            {
                String cmdtext = "SELECT Count (id_caja_diaria),max(fecha) FROM [CAJAS_DIARIAS] WHERE fecha >= '" + desde + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if (DT.Rows[0][1] != null)
                    _UltimaFecha = DateTime.Today;
                else
                    _UltimaFecha = Convert.ToDateTime(DT.Rows[0][1]);
                return Convert.ToInt32(DT.Rows[0][0]) ;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverUltimo()
        {
            try
            {
                String cmdtext = "SELECT Top 1 id_caja_diaria,fecha,efectivo_inicial,efectivo_final,ventas_efectivo,ventas_otros,ventas_total,gastos,cobros FROM [CAJAS_DIARIAS] order by id_caja_diaria desc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        //static public DataTable DevolverDelDia(Ccaja obj)
        //{
        //    try
        //    {
        //        String cmdtext = "SELECT id_caja_diaria,fecha,efectivo_inicial,efectivo_final,ventas_efectivo,ventas_otros,ventas_total,gastos,cobros FROM [CAJAS_DIARIAS] where numero=" + obj.Numero + " and fecha='" + DateTime.Today.ToShortDateString() + "'";
        //        DataTable DT = cDatos.DevolverDatos(cmdtext);
        //        return DT;
        //    }
        //    catch
        //    {
        //        throw new ArgumentException("Error al devolver los datos");
        //    }
        //}
        static public DataTable DevolverDelDia(Ccaja obj)
        {
            try
            {
                String cmdtext = "SELECT id_caja_diaria,fecha,efectivo_inicial,efectivo_final,ventas_efectivo,ventas_otros,ventas_total,gastos,cobros FROM [CAJAS_DIARIAS] where numero=" + obj.Numero + " and Cerrada=0";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public Ccaja_diaria DevolverCajaDiaria(int id)
        {
            try
            {//                                 0          1          2             3               4               5             6       7       8 
                String cmdtext = "SELECT id_caja_diaria,fecha,efectivo_inicial,efectivo_final,ventas_efectivo,ventas_otros,ventas_total,gastos,cobros FROM [CAJAS_DIARIAS] where id_caja_diaria=" + id ;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return new Ccaja_diaria(Convert.ToDateTime(DT.Rows[0][1]), Convert.ToInt32(DT.Rows[0][0]), Convert.ToDecimal(DT.Rows[0][2]), Convert.ToDecimal(DT.Rows[0][3]), Convert.ToDecimal(DT.Rows[0][4]), Convert.ToDecimal(DT.Rows[0][5]), Convert.ToDecimal(DT.Rows[0][6]), Convert.ToDecimal(DT.Rows[0][7]), Convert.ToDecimal(DT.Rows[0][8]));
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public Ccaja_diaria Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT id_caja,fecha,efectivo_inicial,efectivo_final,ventas_efectivo,ventas_otros,ventas_total,gastos,cobros FROM [CAJAS_DIARIAS] where id_caja=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if (DT.Rows.Count == 0)
                    return null;
                else
                {
                    return new Ccaja_diaria(Convert.ToDateTime(DT.Rows[0][1]), id, Convert.ToDecimal(DT.Rows[0][2]), Convert.ToDecimal(DT.Rows[0][3]), Convert.ToDecimal(DT.Rows[0][4]), Convert.ToDecimal(DT.Rows[0][5]), Convert.ToDecimal(DT.Rows[0][6]), Convert.ToDecimal(DT.Rows[0][8]), Convert.ToDecimal(DT.Rows[0][7]));
                }
            }
            catch
            {
                throw new ArgumentException("Error al devolver la compra");
            }
        }

        static public void Agregar(Ccaja_diaria obj,Ccaja objcaja)
        {
            try
            {
                string cmdtxt = "INSERT INTO [CAJAS_DIARIAS] (id_caja_diaria,numero,fecha,efectivo_inicial,cerrada) VALUES("+obj.ID+","+objcaja.Numero+"," + obj.Fecha.ToSqlDate() + "," + SacarComa(obj.Efec_inicial)+ ",0)";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch(Exception ex)
            {
                throw new ArgumentException("Error la caja diaria.\n Erro:\n"+ex.Message);
            }
        }


        static public void Eliminar(Ccaja_diaria obj)
        {
            string cmdtext = "DELETE FROM [CAJAS_DIARIAS] WHERE id_caja=" + obj.ID;
            cDatos.ActualizarDatos(cmdtext);
            
        }
        static public void Modificar(Ccaja_diaria obj)
        {
            try
            {
                string cmdtxt = "UPDATE [CAJAS_DIARIAS] SET efectivo_inicial=" + SacarComa(obj.Efec_inicial) + ",efectivo_final=" + SacarComa(obj.Efec_final) + ",ventas_efectivo=" + SacarComa(obj.V_efectivo) + ", ventas_otros = " + SacarComa(obj.V_otros) + ",ventas_total=" + SacarComa(obj.V_total) + ",cobros=" + SacarComa(obj.Cobros) + ",gastos=" + SacarComa(obj.Gastos) + " WHERE id_caja_diaria=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
               
            }
            catch
            {
                throw new ArgumentException("Error al modificar compra");
            }
        }
        static public void Modificar(Ccaja_diaria obj,bool Cerrar)
        {
            try
            {
                string cmdtxt = "UPDATE [CAJAS_DIARIAS] SET efectivo_inicial=" + SacarComa(obj.Efec_inicial) + ",efectivo_final=" + SacarComa(obj.Efec_final) + ",ventas_efectivo=" + SacarComa(obj.V_efectivo) + ", ventas_otros = " + SacarComa(obj.V_otros) + ",ventas_total=" + SacarComa(obj.V_total) + ",cobros=" + SacarComa(obj.Cobros) + ",gastos=" + SacarComa(obj.Gastos) + ",cerrada='" + Cerrar + "' WHERE id_caja_diaria=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar compra");
            }
        }
    }
}
