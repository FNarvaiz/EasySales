using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using C_DATOS;

namespace C_DATOS
{
    public class Cdatos_Tablero_Control
    {
        static public DataTable DevolverRankFormasPago(string desde, string hasta)
        {
            try
            {
                string cmd = "select P.id_Forma_Pago,count(P.id_Forma_Pago)as [N° Ventas],Descripcion,sum (Subtotal)as Subtotal,SUM(P.Descuento)as [Desc/Rec],SUM (Total) as Total from VENTAS V inner join [VENTAS-PAGOS] P on P.id_caja_diaria=V.id_Caja_Diaria and P.id_venta=V.id_venta inner join FORMAS_PAGOS F on P.id_Forma_Pago=F.id_Forma_Pago inner join CAJAS_DIARIAS C on C.id_Caja_diaria = V.id_Caja_Diaria where C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "' group by P.id_Forma_Pago,Descripcion order by [N° Ventas] desc";
                DataTable DT = cDatos.DevolverDatos(cmd);
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
                string cmd = "select Numero as [Caja],Descripcion as Concepto,Fecha,Importe FROM GASTOS G inner join CONCEPTOS P on P.id_concepto=G.id_concepto INNER JOIN CAJAS_DIARIAS C ON C.id_Caja_Diaria = G.id_CAJA_DIARIA WHERE C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "'";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;

            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverGastos(string desde, string hasta,Cconcepto concepto)
        {
            try
            {
                string cmd = "select Numero as [Caja],Descripcion as Concepto,Fecha,Importe FROM GASTOS G inner join CONCEPTOS P on P.id_concepto=G.id_concepto INNER JOIN CAJAS_DIARIAS C ON C.id_Caja_Diaria = G.id_CAJA_DIARIA WHERE C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "' AND Descripcion = '" + concepto.Concepto + "'";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;

            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverCobros(string desde, string hasta)
        {
            try
            {
                string cmd = "select Numero as [Caja],Descripcion as Concepto,Fecha,Importe FROM COBROS G inner join CONCEPTOS P on P.id_concepto=G.id_concepto INNER JOIN CAJAS_DIARIAS C ON C.id_Caja_Diaria = G.id_CAJA_DIARIA WHERE C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "'";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;

            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverCobros(string desde, string hasta, Cconcepto concepto)
        {
            try
            {
                string cmd = "select Numero as [Caja],Descripcion as Concepto,Fecha,Importe FROM COBROS G inner join CONCEPTOS P on P.id_concepto=G.id_concepto INNER JOIN CAJAS_DIARIAS C ON C.id_Caja_Diaria = G.id_CAJA_DIARIA WHERE C.Fecha BETWEEN '" + desde + "' AND '" + hasta + "' AND Descripcion = '" + concepto.Concepto + "'";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;

            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverTotalSubtotalMes(string desde,string hasta)
        {
            try
            {
                string cmd = "select (select SUM(descuento) from [Ventas-pagos] V inner join CAJAS_DIARIAS C on C.id_Caja_Diaria = V.id_caja_diaria WHERE descuento>0 AND Fecha BETWEEN '" + desde + "' AND '" + hasta + "') as Recargo,(select SUM(descuento) from [Ventas-pagos] V inner join CAJAS_DIARIAS C on C.id_Caja_Diaria = V.id_caja_diaria WHERE descuento<0 AND Fecha BETWEEN '" + desde + "' AND '" + hasta + "') as descuentos,SUM(subtotal) AS Subtotal,SUM(Total) AS Total from Ventas V inner join CAJAS_DIARIAS C on C.id_Caja_Diaria = V.id_caja_diaria WHERE Fecha BETWEEN '" + desde + "' AND '" + hasta + "'";
                DataTable DT = cDatos.DevolverDatos(cmd);
                return DT;

            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }

        }
        static public DataTable DevolverEstadisticas(string desde, string hasta)
        {
            try
            {
                string cmd = "SELECT V.Codigo,Descripcion,SUM(cantidad) AS [Unid. Vendidas],Precio_unitario AS [Precio Unitario],Costo_unitario AS [Costo Unitario],(Precio_Unitario-Costo_Unitario)AS [Margen Bruto],SUM((Precio_Unitario-Costo_Unitario)*Cantidad) AS Utilidad,SUM(Precio_Unitario*Cantidad) AS [Ingreso por ventas],SUM(Costo_Unitario*Cantidad) AS [Costos Soportados],((Precio_Unitario-Costo_Unitario)/Precio_Unitario)*100AS[RV (%)],((Precio_Unitario-Costo_Unitario)/Costo_unitario)*100 AS[RC (%)] FROM [VENTAS-ARTICULOS] V INNER JOIN ARTICULOS A ON A.codigo=V.codigo INNER JOIN CAJAS_DIARIAS C ON C.id_caja_diaria=V.id_caja_diaria WHERE fecha BETWEEN '" + desde + "' AND '" + hasta + "' GROUP BY V.codigo,descripcion,costo_unitario,precio_unitario";

                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }

        }
        static public DataTable DevolverSaldosClientes()
        {
            string cmd = "SELECT SUM(saldo),(SELECT SUM(saldo) FROM CUENTAS_CORRIENTES A INNER JOIN CLIENTES B ON A.id_Persona = B.id_persona where Saldo<0)FROM CUENTAS_CORRIENTES A INNER JOIN CLIENTES B ON A.id_Persona = B.id_persona WHERE Saldo>0";
            return cDatos.DevolverDatos(cmd);
        }
        static public DataTable DevolverSaldosProveedores()
        {
            string cmd = "SELECT SUM(saldo),(SELECT SUM(saldo) FROM CUENTAS_CORRIENTES A INNER JOIN PROVEEDORES B ON A.id_Persona = B.id_persona where Saldo<0)FROM CUENTAS_CORRIENTES A INNER JOIN PROVEEDORES B ON A.id_Persona = B.id_persona WHERE Saldo>0";
            return cDatos.DevolverDatos(cmd);
        }
        static public DataTable DevolverSaldosUsuarios()
        {
            string cmd = "SELECT SUM(saldo),(SELECT SUM(saldo) FROM CUENTAS_CORRIENTES A INNER JOIN USUARIOS B ON A.id_Persona = B.id_persona where Saldo<0)FROM CUENTAS_CORRIENTES A INNER JOIN USUARIOS B ON A.id_Persona = B.id_persona WHERE Saldo>0";
            return cDatos.DevolverDatos(cmd);
        }
        static public DataTable DevolverSaldosTotales()
        {
            string cmd = "SELECT SUM(saldo),(SELECT SUM(saldo) FROM CUENTAS_CORRIENTES A INNER JOIN PERSONAS B ON A.id_Persona = B.id_persona where Saldo<0)FROM CUENTAS_CORRIENTES A INNER JOIN PERSONAS B ON A.id_Persona = B.id_persona WHERE Saldo>0";
            return cDatos.DevolverDatos(cmd);
        }                
        static public DataTable DevolverSaldosCuentasCorrientes(bool alta)
        {
            string cmd = "SELECT P.id_persona,P.Nombre,Saldo FROM CUENTAS_CORRIENTES C INNER JOIN PERSONAS P ON C.id_Persona = P.id_persona WHERE C.Alta ='" + alta + "'";
            return cDatos.DevolverDatos(cmd);
        }
        static public DataTable DevolverSaldosCuentasCorrientes()
        {
            string cmd = "SELECT P.id_persona,P.Nombre,Saldo FROM CUENTAS_CORRIENTES C INNER JOIN PERSONAS P ON C.id_Persona = P.id_persona";
            return cDatos.DevolverDatos(cmd);
        }
        static public DataTable DevolverVentasBD(string desde, string hasta)
        {
            try
            {
                string cmd = "SELECT Fecha,Numero as [Nro Caja],Subtotal,descuento as [Desc/Rec],Total,V.id_venta,V.id_caja_diaria,sum(A.costo_unitario) as Costo,total-sum(A.costo_unitario) as Utilidad,E.nombre as Usuario FROM VENTAS V inner join [VENTAS-PAGOS] P on P.id_venta=V.id_venta AND P.id_Caja_diaria=V.id_Caja_diaria inner join [CAJAS_DIARIAS] C on C.id_Caja_diaria = V.id_caja_diaria inner join USUARIOS U on V.id_usuario = U.id_usuario inner join PERSONAS E on U.id_persona = E.id_persona inner join [VENTAS-ARTICULOS] O on O.id_venta = V.id_venta and O.id_caja_diaria=V.id_caja_diaria inner join ARTICULOS A on A.codigo = O.Codigo where C.fecha between '" + desde + "' AND '" + hasta + "' group by Fecha,Numero,Subtotal,descuento,Total,E.nombre,V.id_venta,V.id_caja_diaria order by Fecha desc";
                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverVentasArticulosBD(string desde, string hasta)
        {
            try
            {
                string cmd = "SELECT A.codigo,A.descripcion,A.Stock,sum(O.Cantidad) as Vendido,sum(A.costo_unitario*O.Cantidad) as Costo,sum(o.Cantidad*o.Precio_uni) as Monto FROM [CAJAS_DIARIAS] C inner join [VENTAS-ARTICULOS] O on O.id_caja_diaria=C.id_caja_diaria right join ARTICULOS A on A.codigo = O.Codigo where C.fecha between '" + desde + "' AND '" + hasta + "' group by A.Codigo,A.Descripcion,A.Stock order by Vendido desc";
                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverVentasArticulosBD(string desde, string hasta,Crubro oRubro)
        {
            try
            {
                string cmd = "SELECT A.codigo,A.descripcion,A.Stock,sum(O.Cantidad) as Vendido,sum(A.costo_unitario*O.Cantidad) as Costo,sum(o.Cantidad*o.Precio_uni) as Monto FROM [CAJAS_DIARIAS] C inner join [VENTAS-ARTICULOS] O on O.id_caja_diaria=C.id_caja_diaria right join ARTICULOS A on A.codigo = O.Codigo where A.id_rubro=" + oRubro.Nro + " AND C.fecha between '" + desde + "' AND '" + hasta + "'  group by A.Codigo,A.Descripcion,A.Stock order by Vendido desc";
                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public DataTable DevolverVentasBD()
        {
            try
            {
                string cmd = "SELECT Fecha,Numero as [Nro Caja],Subtotal,descuento as [Desc/Rec],Total,V.id_venta,V.id_caja_diaria,sum(A.costo_unitario) as Costo,total-sum(A.costo_unitario) as Utilidad,E.nombre as Usuario FROM VENTAS V inner join [VENTAS-PAGOS] P on P.id_venta=V.id_venta AND P.id_Caja_diaria=V.id_Caja_diaria inner join [CAJAS_DIARIAS] C on C.id_Caja_diaria = V.id_caja_diaria inner join USUARIOS U on V.id_usuario = U.id_usuario inner join PERSONAS E on U.id_persona = E.id_persona inner join [VENTAS-ARTICULOS] O on O.id_venta = V.id_venta and O.id_caja_diaria=V.id_caja_diaria inner join ARTICULOS A on A.codigo = O.Codigo group by Fecha,Numero,Subtotal,descuento,Total,E.nombre,V.id_venta,V.id_caja_diaria order by Fecha desc";
                return cDatos.DevolverDatos(cmd);
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }        
        static public DataTable DevolverCantidadDeArticulosVigentesPorRubro()
        {
            string cmd = "select R.id_rubro,R.Nombre,count(R.id_rubro) as Articulos from RUBROS R inner join ARTICULOS A on r.id_rubro = a.id_rubro where vigente=1 group by Nombre,R.id_rubro";
            return cDatos.DevolverDatos(cmd);
        }
        static public DataTable DevolverMontoDeVentasPorRubro(string desde, string hasta)
        {
            string cmd = "SELECT R.Nombre,sum((v.Cantidad*V.Precio_Uni)) As TOTAL"
                             + " FROM [VENTAS-ARTICULOS] V "
                             + " INNER JOIN ARTICULOS A on A.Codigo = V.Codigo "
                             + " INNER JOIN RUBROS R ON R.id_Rubro = A.id_Rubro "
                             + " GROUP BY R.Nombre"
                             + " ORDER BY Total";
            return cDatos.DevolverDatos(cmd);
        }
    }
}

