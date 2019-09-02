using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_ventas
    {
        static private string SacarComa(decimal obj)
        {
            return (obj.ToString()).Replace(",", ".");
        }
        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_venta,subtotal,total,descuento FROM VENTAS ";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public int  CantVentas()
        {
            try
            {
                String cmdtext = "SELECT count (id_venta) FROM VENTAS  ";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return Convert.ToInt32( DT.Rows[0][0]);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable Devolver(Ccaja_diaria obj)
        {
            try
            {
                String cmdtext = "SELECT V.id_venta,subtotal,total,id_forma_pago,importe,codigo_autorizacion,descuento FROM VENTAS V inner join [VENTAS-PAGOS] P on P.id_venta=V.id_venta and V.id_caja_diaria=P.id_caja_diaria where V.id_caja_diaria=" + obj.ID + " order by id_venta asc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverArticulosVenta(Cventa oVenta,int id_caja_diaria)
        {
            try
            {
                string cmd = "select A.codigo,V.cantidad,V.Precio_uni from [VENTAS-ARTICULOS] V INNER JOIN ARTICULOS A ON A.codigo=V.codigo WHERE id_venta =" + oVenta.ID +" and id_caja_diaria="+id_caja_diaria;
                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new Exception("Error al devolver los datos");
            }           

        }
        static public DataTable DevolverItemsVenta(Cventa oVenta, int id_caja_diaria)
        {
            try
            {
                string cmd = "select A.Codigo,A.Descripcion,V.cantidad as Cant,M.Nombre as Medida,(V.Precio_uni*V.cantidad) as ImporteTot from [VENTAS-ARTICULOS] V INNER JOIN ARTICULOS A ON A.codigo=V.codigo INNER JOIN MEDIDAS M ON M.ID_MEDIDA=A.ID_MEDIDA WHERE id_venta =" + oVenta.ID + " and id_caja_diaria=" + id_caja_diaria;
                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new Exception("Error al devolver los datos");
            }

        }

        static public void Agregar(Cventa obj,Ccaja_diaria objcaja,Cusuario objusu)
        {
            try
            {
                string cmdtxt = "INSERT INTO VENTAS (id_venta,id_caja_diaria,subtotal,total,id_usuario) VALUES("+obj.ID+","+objcaja.ID+"," +SacarComa(obj.Subtotal) + "," +SacarComa(obj.Total) + ","+objusu.ID_USUARIO+")";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al cargar la venta");
            }
        }
        static public void Eliminar(Cventa obj, Ccaja_diaria objcaja)
        {
            try
            {
                string cmdtxt = "DELETE FROM [VENTAS-CREDITOS] where id_venta=" + obj.ID + " AND id_caja_diaria=" + objcaja.ID;
                cDatos.ActualizarDatos(cmdtxt);
                cmdtxt = "DELETE FROM VENTAS where id_venta=" + obj .ID+ " AND id_caja_diaria=" + objcaja.ID;
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al cargar la venta");
            }
        }
        static public void EliminarPagos(Cventa oventa, Ccaja_diaria ocaja)
        {
            string cmdtxt = "DELETE FROM [VENTAS-PAGOS] where  id_venta=" + oventa.ID + " AND id_caja_diaria=" + ocaja.ID;
            cDatos.ActualizarDatos(cmdtxt);
        }
        static public void RegistrarPago(Cventa oventa, Ccaja_diaria ocaja, Cpago opago)
        {
            string cmdtxt = "INSERT INTO [VENTAS-PAGOS] (id_venta,id_caja_diaria,id_forma_pago,descuento,importe,codigo_autorizacion) VALUES(" + oventa.ID + "," + ocaja.ID + "," + opago.FormaPago.ID + "," + SacarComa(opago.Descuento) + "," + SacarComa(opago.Importe) + ",'" + opago.Cod_Autorizacion + "')";
            cDatos.ActualizarDatos(cmdtxt);
        }
        static public void EliminarItem(Citem obj, Cventa objV, Ccaja_diaria objC)
        {
            try
            {
                string cmdtxt = "DELETE FROM [VENTAS-ARTICULOS]  where  codigo='" + obj.Articulo.Codigo + "' AND id_venta=" + objV.ID + " AND id_caja_diaria=" + objC.ID;
                cDatos.ActualizarDatos(cmdtxt);
                obj.Articulo.Stock += obj.Cantidad;
                cmdtxt = "UPDATE ARTICULOS SET stock= (stock+" + SacarComa(obj.Cantidad) + ") where codigo='" + obj.Articulo.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        static public void RegistrarItem(Citem obj,Cventa objV,Ccaja_diaria objC)
        {
            try
            {
                string cmdtxt = "INSERT INTO [VENTAS-ARTICULOS] (id_venta,id_caja_diaria,codigo,cantidad,precio_uni,desc_rec_uni) VALUES(" + objV.ID + "," + objC.ID + ",'" +obj.Articulo.Codigo+"',"+SacarComa(obj.Cantidad)+","+SacarComa(obj.Precio_Uni) +",0)";
                cDatos.ActualizarDatos(cmdtxt);
                //if(obj.Cantidad>0)
                cmdtxt = "UPDATE ARTICULOS SET stock= (stock-(" +SacarComa(obj.Cantidad) + ")) where codigo='" + obj.Articulo.Codigo+"'";
                obj.Articulo.Stock -= obj.Cantidad;
                //else
                //cmdtxt = "UPDATE ARTICULOS SET stock= (stock+" + SacarComa(obj.Cantidad*-1) + ") where codigo='" + obj.Articulo.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch(Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        
        static public void Modificar(Cventa obj)
        {
            try
            {
                string cmdtxt = "UPDATE VENTAS SET subtotal = " + SacarComa(obj.Subtotal) + ", total=" +SacarComa(obj.Total)  + " WHERE id_venta=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al modificar venta");
            }
        }
        static public decimal CantHistoricaArt(Carticulo oArt)
        {
            String cmdtext = "select sum (cantidad) as cant , codigo from [ventas-articulos] where codigo='" + oArt.Codigo + "' group by codigo";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return 0;
            else
                return Convert.ToDecimal(DT.Rows[0][0]);
        }

    }
}
