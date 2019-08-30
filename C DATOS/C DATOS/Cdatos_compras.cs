using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_compras
    {
        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT top 50 C.id_compra,fecha,total,descuento_obtenidos,subtotal,id_forma_pago,P.id_proveedor FROM COMPRAS C left join [COMPRAS-PROVEEDORES] P on C.id_compra=P.id_compra order by C.id_compra desc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable Devolver(int idTope)
        {
            try
            {
                String cmdtext = "SELECT top 50 C.id_compra,fecha,total,descuento_obtenidos,subtotal,id_forma_pago,P.id_proveedor FROM COMPRAS C left join [COMPRAS-PROVEEDORES] P on C.id_compra=P.id_compra where c.id_compra<"+ idTope+" order by C.id_compra desc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }  
        //static public Ccompra Devolver(int id)
        //{
        //    try
        //    {
        //        String cmdtext = "SELECT id_compra,fecha,total,descuentos_obtenidos FROM COMPRAS where id_compra=" + id;
        //        DataTable DT = cDatos.DevolverDatos(cmdtext);
        //        if (DT.Rows.Count == 0)
        //            return null;
        //        else
        //        {
        //            return new Ccompra(id, Convert.ToDecimal(DT.Rows[0][2]), Convert.ToDecimal(DT.Rows[0][3]), Convert.ToDateTime(DT.Rows[0][1]));
        //        }
        //    }
        //    catch
        //    {
        //        throw new ArgumentException("Error al devolver la compra");
        //    }
        //}
        static public void Agregar(Ccompra obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO COMPRAS (id_compra,subtotal, fecha,total,descuento_obtenidos,id_forma_pago) VALUES(" + obj.Id + "," + obj.Subtotal.ToString().Replace(",", ".") + ",'" + obj.Fecha.ToShortDateString() + "'," + obj.Total.ToString().Replace(",", ".") + "," + obj.Descuento.ToString().Replace(",", ".") + "," + obj.FormaPagoDevolver().ID + ")";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al cargar la persona");
            }
        }
        static public void GuardarItem(Citem obj, Ccompra oCompra)
        {
            try
            {
                string cmdtxt = "INSERT INTO [COMPRAS-ARTICULOS] (id_compra,codigo,costo,cantidad) VALUES(" + oCompra.Id + ",'" + obj.Articulo.Codigo.ToString() + "'," + obj.Precio_Uni.ToString().Replace(",", ".") + "," + obj.Cantidad.ToString().Replace(",", ".") + ")";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al cargar el artículo a la compra");
            }
        }
        static public void AgregarReferenciaAProveedor( Ccompra oCompra, Cproveedor oPro)
        {
            try
            {
                string cmdtxt = "INSERT INTO [COMPRAS-PROVEEDORES] (id_compra,id_proveedor) VALUES(" + oCompra.Id + ","+oPro.ID_PRO+ ")";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al cargar el artículo a la compra");
            }
        }
        static public void Eliminar(Ccompra obj)
        {
            string cmdtext;
            if(obj.Proveedor!=null){
                cmdtext="DELETE FROM [COMPRAS-PROVEEDORES] WHERE id_compra=" + obj.Id;
                cDatos.ActualizarDatos(cmdtext);
            }
            cmdtext = "DELETE FROM [COMPRAS-ARTICULOS] WHERE id_compra=" + obj.Id;
            cDatos.ActualizarDatos(cmdtext);
            cmdtext = "DELETE FROM COMPRAS WHERE id_compra=" + obj.Id;
            cDatos.ActualizarDatos(cmdtext);
            
        }
        static public void EliminarItem(Ccompra oCompra, Citem oItem)
        {
            string cmdtext = "DELETE FROM [COMPRAS-ARTICULOS] WHERE id_compra=" + oCompra.Id +" AND codigo='"+ oItem.Articulo.Codigo +"' ";
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void EliminarItems(Ccompra oCompra)
        {
            string cmdtext = "DELETE FROM [COMPRAS-ARTICULOS] WHERE id_compra=" + oCompra.Id;
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void EliminarReferenciaAProveedor(Ccompra oCompra)
        {
            try
            {
                string cmdtxt = "DELETE FROM [COMPRAS-PROVEEDORES] WHERE id_compra=" + oCompra.Id;
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al eliminar la referencia del proveedor con la compra");
            }
        }
        static public DataTable VerItems(Ccompra obj)
        {
            String cmdtext = "SELECT codigo,cantidad,costo FROM [COMPRAS-ARTICULOS] where id_compra=" + obj.Id;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            return DT;
        }
        static public decimal CantidadComprada(Carticulo oart)
        {
            String cmdtext = "select sum (cantidad) as cant , codigo from [compras-articulos] where codigo='" + oart.Codigo + "' group by codigo";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return 0;
            else
                return Convert.ToDecimal(DT.Rows[0][0]);
        }
        static public void Modificar(Ccompra obj)
        {
            try
            {
                string cmdtxt = "UPDATE COMPRAS SET SUBTOTAL= " + obj.Subtotal.ToString().Replace(",", ".") + ", fecha = '" + obj.Fecha.ToShortDateString() + "', id_forma_pago=" + obj.FormaPagoDevolver().ID + ",total=" + obj.Total.ToString().Replace(",", ".") + ",descuento_obtenidos=" + obj.Descuento.ToString().Replace(",", ".") + " WHERE id_compra=" + obj.Id;
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar compra");
            }
        }
        
    }
}
