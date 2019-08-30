using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using C_DATOS;
using CLASES;

namespace CONTROL
{
    public class Ctrl_tablero
    {  
        public DataTable DevolverRankFormasPago(string desde, string hasta)
        {
            return Cdatos_Tablero_Control.DevolverRankFormasPago(desde, hasta);                     
        }

        public DataTable DevolverGastos(string desde, string hasta)
        {
            return Cdatos_Tablero_Control.DevolverGastos(desde, hasta);
        }

        public DataTable DevolverCobros(string desde, string hasta)
        {
            return Cdatos_Tablero_Control.DevolverCobros(desde, hasta);
        }

        public DataTable DevolverGastos(string desde, string hasta, Cconcepto concepto)
        {
            return Cdatos_Tablero_Control.DevolverGastos(desde, hasta, concepto);
        }

        public DataTable DevolverCobros(string desde, string hasta, Cconcepto concepto)
        {
            return Cdatos_Tablero_Control.DevolverCobros(desde, hasta, concepto);
        }

        public DataTable DevolverTotalSubtotalMes(string desde,string hasta)
        {
            return Cdatos_Tablero_Control.DevolverTotalSubtotalMes(desde,hasta);            
        }

        public DataTable DevolverEstadisticas(string desde,string hasta)
        {
            return Cdatos_Tablero_Control.DevolverEstadisticas(desde, hasta);
        }

        public DataTable DevolverTotalesCtaCteClientes()
        {
            return Cdatos_Tablero_Control.DevolverSaldosClientes();
        }

        public DataTable DevolverTotalesCtaCteProveedores()
        {
            return Cdatos_Tablero_Control.DevolverSaldosProveedores();
        }

        public DataTable DevolverSaldosUsuarios()
        {
            return Cdatos_Tablero_Control.DevolverSaldosUsuarios();
        }

        public DataTable DevolverSaldosTotales()
        {
            return Cdatos_Tablero_Control.DevolverSaldosTotales();
        }

        public DataTable DevolverVentasBD(string desde, string hasta)
        {
            return Cdatos_Tablero_Control.DevolverVentasBD(desde, hasta);
        }
        public DataTable DevolverVentasArticulosBD(string desde, string hasta,bool por_rubro,Crubro oRubro)
        {
            if(por_rubro)
                return Cdatos_Tablero_Control.DevolverVentasArticulosBD(desde, hasta, oRubro);
            else
                return Cdatos_Tablero_Control.DevolverVentasArticulosBD(desde, hasta);
        }

        public DataTable DevolverVentasBD()
        {
            return Cdatos_Tablero_Control.DevolverVentasBD();
        }

        public DataTable DevolverSaldosCuentasCorrientes(bool alta)
        {
            return Cdatos_Tablero_Control.DevolverSaldosCuentasCorrientes(alta);
        }

        public DataTable DevolverSaldosCuentasCorrientes()
        {
            return Cdatos_Tablero_Control.DevolverSaldosCuentasCorrientes();
        }

        public DataTable DevolverCantidadDeArticulosVigentesPorRubro()
        {
            return Cdatos_Tablero_Control.DevolverCantidadDeArticulosVigentesPorRubro();
        }

        public DataTable DevolverMontoDeVentasPorRubro(string desde, string hasta)
        {
            return Cdatos_Tablero_Control.DevolverMontoDeVentasPorRubro(desde, hasta);
        }
    }
}
