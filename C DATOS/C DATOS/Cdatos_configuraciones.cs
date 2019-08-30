using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using System.Data;
namespace C_DATOS
{
    public class Cdatos_configuraciones
    {
        static public void Agregar(Cconfiguracion obj)
        {
            try
            {

                string cmdtxt = "INSERT INTO Configuraciones (id_configuracion,multiusuario,multicaja,pass,porventa,Facturacion,Epson_Samsung,porcomision,porccomision,ordenprioridad,ordendescform,existenciacompras,nro_puerto,modelo,iva,hostname,version,nombre_logico) VALUES (" + obj.ID + ",'" + obj.MultiUsuario + "','" + obj.MultiCaja + "','" + obj.PedirPass + "','" + obj.PorVenta + "','" + obj.Facturacion + "','" + obj.Epson_Samsung + "','" + obj.PorComisiones + "'," + ((obj.PorcComision.ToString()).Replace(",", ".")) + ",'" + obj.OrdenPrioridad + "','" + obj.DescuentoFormaPago + "','" + obj.ExistenciaPorCompras + "'," + obj.Puerto + "," + obj.Modelo + ","+((obj.IVA.ToString()).Replace(",", "."))+",'"+obj.HostName+"',"+obj.Version+",'"+obj.NombreLogico+"')";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                obj.ID++;
                Agregar(obj);
            }
        }
        static public void Modificar(Cconfiguracion obj)
        {
            try
            {
                string cmdtxt = "UPDATE configuraciones SET  multiusuario= '" + obj.MultiUsuario + "',multicaja= '" + obj.MultiCaja + "',pass= '" + obj.PedirPass + "',Porventa= '" + obj.PorVenta + "',Facturacion= '" + obj.Facturacion + "',Epson_Samsung= '" + obj.Epson_Samsung + "',porcomision= '" + obj.PorComisiones + "',porccomision= " + ((obj.PorcComision.ToString()).Replace(",", ".")) + ",ordenprioridad='" + obj.OrdenPrioridad + "',ordendescform='" + obj.DescuentoFormaPago + "',existenciacompras='" + obj.ExistenciaPorCompras + "',nro_puerto=" + obj.Puerto + ",modelo=" + obj.Modelo + ",iva="+((obj.IVA.ToString()).Replace(",", "."))+" , hostname='"+obj.HostName +"',nombre_logico='"+obj.NombreLogico+ "' WHERE id_configuracion =" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
              
            }
            catch
            {
                throw new ArgumentException("Error al modificar localidad");
            }

        }
        static public Cconfiguracion Devolver()
        {
            String cmdtext = "SELECT id_configuracion,multiusuario,multicaja,pass,porventa,Facturacion,Epson_Samsung,porcomision,porccomision,ordenprioridad,ordendescform,existenciacompras,nro_puerto,modelo,iva,HostName,version,nombre_logico FROM CONFIGURACIONES where hostname='"+System.Net.Dns.GetHostName()+"'";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count > 0)
                return new Cconfiguracion(Convert.ToInt32(DT.Rows[0][0]), Convert.ToBoolean(DT.Rows[0][1]), Convert.ToBoolean(DT.Rows[0][2]), Convert.ToBoolean(DT.Rows[0][3]), Convert.ToBoolean(DT.Rows[0][4]), Convert.ToBoolean(DT.Rows[0][5]), Convert.ToBoolean(DT.Rows[0][6]), Convert.ToBoolean(DT.Rows[0][7]), Convert.ToDecimal(DT.Rows[0][8]), Convert.ToBoolean(DT.Rows[0][9]), Convert.ToBoolean(DT.Rows[0][10]), Convert.ToBoolean(DT.Rows[0][11]), Convert.ToInt32(DT.Rows[0][12]), Convert.ToInt32(DT.Rows[0][13]), Convert.ToDecimal(DT.Rows[0][14]), DT.Rows[0][15].ToString(), Convert.ToInt32(DT.Rows[0][16]), DT.Rows[0][17].ToString());
            return null;
        }

    }
}
