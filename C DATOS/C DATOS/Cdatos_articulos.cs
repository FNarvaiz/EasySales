using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_articulos
    {
        static private string SacarComa(decimal obj)
        {
            return (obj.ToString()).Replace(",", ".");
        }
        static public DataTable DevolverVigentesOrderByStock()
        {
            try
            {
                String cmdtext = "SELECT A.Codigo,Descripcion,Stock,A.id_rubro,sum(precio_uni*Cantidad)As [Ingreso por ventas],sum(Cantidad)As [Veces Vendido] FROM ARTICULOS A LEFT JOIN [VENTAS-ARTICULOS] V on A.codigo = V.codigo WHERE vigente=1 group by A.codigo,descripcion,stock,id_rubro ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverVigentesOrderByStock(string descr)
        {
            try
            {
                String cmdtext = "SELECT A.Codigo,Descripcion,Stock,A.id_rubro,sum(precio_uni*Cantidad)As [Ingreso por ventas],sum(Cantidad)As [Veces Vendido] FROM ARTICULOS A LEFT JOIN [VENTAS-ARTICULOS] V on A.codigo = V.codigo WHERE vigente=1 and A.descripcion LIKE '%" + descr + "%' group by A.codigo,descripcion,stock,id_rubro ORDER BY stock ASC";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public void ModificarStockYCosto(Carticulo obj ,decimal stock){
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET costo_unitario=" + SacarComa(obj.Costo) + ",stock= stock+" +SacarComa(stock) + " WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }    
        }
        static public void ModificarStock(Carticulo obj)
        {
            try
            {
                
                string cmdtxt = "UPDATE ARTICULOS SET stock= " + SacarComa(obj.Stock) + " WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }
        static public void ModificarPrecios(List<Carticulo> lista,decimal precioNuevo)
        {
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET precio_unitario= " + SacarComa(precioNuevo) + " WHERE ";
                foreach(Carticulo aux in lista){
                    if (aux != lista[0])
                        cmdtxt += " OR ";
                    cmdtxt += "codigo='" + aux.Codigo + "'";
                    aux.Precio = precioNuevo;
                }

                cDatos.ActualizarDatos(cmdtxt);
            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }
        static public DataTable Devolver(bool vigentes)
        {
            try
            {
                String cmdtext = "SELECT codigo,descripcion,costo_unitario,precio_unitario,stock,id_rubro,id_medida,iva,nota,StockAlto,StockMedio,StockBajo FROM ARTICULOS where vigente='"+vigentes+"' ORDER BY descripcion asc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public string UltimoCodigo()
        {
            String cmdtext = "SELECT top 1 codigo FROM ARTICULOS order by codigo desc";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
                return "0";
            else
                return DT.Rows[0][0].ToString();
        }
        static public bool TieneReferencias(Carticulo obj)
        {
            String cmdtext = "SELECT codigo FROM [VENTAS-ARTICULOS] WHERE CODIGO='" + obj.Codigo + "'";
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count > 0)
                return true;
            cmdtext = "SELECT codigo FROM [COMPRAS-ARTICULOS] WHERE CODIGO='" + obj.Codigo + "'";
            DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count > 0)
                return true;
            return false;
        }
        static public DataTable DevolverDeVenta(int id_venta)
        {

            String cmdtext = "SELECT A.codigo,descripcion,costo_unitario,precio_unitario,stock,cantidad,iva,nota,StockAlto,StockMedio,StockBajo FROM ARTICULOS A inner join [VENTAS-ARTICULOS] V on V.codigo=A.codigo where V.id_venta=" + id_venta;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            return DT;
        }
        static public DataTable DevolverDeCompra(int id_compra)
        {

            String cmdtext = "SELECT A.codigo,descripcion,costo_unitario,precio_unitario,stock,cantidad,Costo,iva,nota,StockAlto,StockMedio,StockBajo FROM ARTICULOS A inner join [COMPRAS-ARTICULOS] C on C.codigo=A.codigo where C.id_compra=" + id_compra;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            return DT;
        }        
        static public void Agregar(Carticulo obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO ARTICULOS (codigo,descripcion,costo_unitario,precio_unitario,stock,vigente,id_rubro,id_medida,iva,nota,StockAlto,StockMedio,StockBajo) VALUES('" + obj.Codigo + "','" + obj.Descripcion + "'," + SacarComa(obj.Costo) + "," + SacarComa(obj.Precio) + "," + SacarComa(obj.Stock) + ",1," + obj.Rubro.Nro + "," + obj.Unidad_Medida.ID + "," + SacarComa(obj.Iva) + ",'" + obj.Nota + "'," + SacarComa(obj.CantAlta) + "," + SacarComa(obj.CantMedia) + "," + SacarComa(obj.CantBaja) + ")";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Error al cargar el artículo.Mensaje:" + ex.Message);
            }
        }
        //static public void EquilibrarEliminacion(Cventa obj)
        //{
        //    DataTable DT = DevolverDeVenta(obj.ID);
        //    int totalstock;
        //    foreach (DataRow DR in DT.Rows)
        //    {
        //        totalstock = Convert.ToInt32(DR[4]) + Convert.ToInt32(DR[5]);
        //        Modificar(new Carticulo((DR[0]).ToString(), DR[1].ToString(), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[2]), totalstock));
        //    }
        //}
        //static public void EquilibrarEliminacion(Ccompra obj)
        //{
        //    DataTable DT = DevolverDeVenta(obj.Id);
        //    int totalstock;
        //    foreach (DataRow DR in DT.Rows)
        //    {
        //        totalstock = Convert.ToInt32(DR[4]) - Convert.ToInt32(DR[5]);
        //        Modificar(new Carticulo(DR[0].ToString(), DR[1].ToString(), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[2]), totalstock));
        //    }
        //}
        static public void EliminarReferencias(Carticulo obj){
            
            string cmdtext = "DELETE FROM [VENTAS-ARTICULOS] WHERE codigo='" + obj.Codigo+"'";
            cDatos.ActualizarDatos(cmdtext);
            cmdtext = "DELETE FROM [COMPRAS-ARTICULOS] WHERE codigo='" + obj.Codigo + "'";
            cDatos.ActualizarDatos(cmdtext);
        }
        static public void Eliminar(Carticulo obj)
        {
            string cmdtext = "DELETE FROM ARTICULOS WHERE codigo = '" + obj.Codigo + "'";
            cDatos.ActualizarDatos(cmdtext);
            
        }
        static public void Modificar(Carticulo obj)
        {
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET  descripcion= '" + obj.Descripcion + "', precio_unitario=" + SacarComa(obj.Precio) + ",costo_unitario=" + SacarComa(obj.Costo) + ",stock=" + SacarComa(obj.Stock) + ", id_rubro=" + obj.Rubro.Nro + ",id_medida=" + obj.Unidad_Medida.ID + ",iva=" + SacarComa(obj.Iva) + ",nota='" + obj.Nota + "',StockAlto=" + SacarComa(obj.CantAlta) + ",StockMedio=" + SacarComa(obj.CantMedia) + ",StockBajo=" + SacarComa(obj.CantBaja) + "  WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }       
        static public void Modificar(Carticulo obj, Carticulo objNuevo)
        {
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET  codigo='" + objNuevo.Codigo + "', descripcion= '" + obj.Descripcion + "', precio_unitario=" + SacarComa(obj.Precio) + ",costo_unitario=" + SacarComa(obj.Costo) + ",stock=" + SacarComa(obj.Stock) + ", id_rubro=" + obj.Rubro.Nro + ",id_medida=" + obj.Unidad_Medida.ID + ",iva=" + SacarComa(obj.Iva) + ",nota='" + obj.Nota + "',StockAlto=" + SacarComa(obj.CantAlta) + ",StockMedio=" + SacarComa(obj.CantMedia) + ",StockBajo=" + SacarComa(obj.CantBaja) + "  WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }
        static public void Modificar(Carticulo obj,bool vigente)
        {
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET Vigente='" + vigente + "', descripcion= '" + obj.Descripcion + "', precio_unitario=" + SacarComa(obj.Precio) + ",costo_unitario=" + SacarComa(obj.Costo) + ",stock=" + SacarComa(obj.Stock) + ", id_rubro=" + obj.Rubro.Nro + ",id_medida=" + obj.Unidad_Medida.ID + ",iva=" + SacarComa(obj.Iva) + ",nota='" + obj.Nota + "',StockAlto=" + SacarComa(obj.CantAlta) + ",StockMedio=" + SacarComa(obj.CantMedia) + ",StockBajo=" + SacarComa(obj.CantBaja) + " WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }
        static public void Modificar(Carticulo obj, Carticulo objNuevo,bool vigente)
        {
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET Codigo='" + objNuevo.Codigo + "', Vigente='" + vigente + "', descripcion= '" + obj.Descripcion + "', precio_unitario=" + SacarComa(obj.Precio) + ",costo_unitario=" + SacarComa(obj.Costo) + ",stock=" + SacarComa(obj.Stock) + ", id_rubro=" + obj.Rubro.Nro + ",id_medida=" + obj.Unidad_Medida.ID + ",iva=" + SacarComa(obj.Iva) + ",nota='" + obj.Nota + "',StockAlto=" + SacarComa(obj.CantAlta) + ",StockMedio=" + SacarComa(obj.CantMedia) + ",StockBajo=" + SacarComa(obj.CantBaja) + " WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatos(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }
        static public void ModificarConEspera(Carticulo obj)
        {
            try
            {
                string cmdtxt = "UPDATE ARTICULOS SET  descripcion= '" + obj.Descripcion + "', precio_unitario=" + SacarComa(obj.Precio) + ",costo_unitario=" + SacarComa(obj.Costo) + ",stock=" + SacarComa(obj.Stock) + ", id_rubro=" + obj.Rubro.Nro + ",id_medida=" + obj.Unidad_Medida.ID + ",iva=" + SacarComa(obj.Iva) + ",nota='" + obj.Nota + "',StockAlto=" + SacarComa(obj.CantAlta) + ",StockMedio=" + SacarComa(obj.CantMedia) + ",StockBajo=" + SacarComa(obj.CantBaja) + "  WHERE codigo='" + obj.Codigo + "'";
                cDatos.ActualizarDatosConEspera(cmdtxt);

            }
            catch
            {
                throw new ArgumentException("Error al modificar artículo");
            }
        }
    }
}
