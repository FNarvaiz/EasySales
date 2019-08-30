using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_Ventas
    {
        static Ctrl_Ventas Control;        

        public static Ctrl_Ventas ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_Ventas();
            }

            return Control;
        }

        public void CargarItems(Cventa oVenta,int  caja_diaria)
        {
                DataTable DT = Cdatos_ventas.DevolverArticulosVenta(oVenta,caja_diaria);
                Ctrl_articulos admArt = Ctrl_articulos.ClaseActiva();
                admArt.DevolverListaVigentes();
                foreach(DataRow DR in DT.Rows)
                {   
                        Carticulo obj =admArt.BuscarEnVigentes(DR[0].ToString());
                        oVenta.Items().Add(new Citem(obj, Convert.ToDecimal(DR[1]), Convert.ToDecimal(DR[2])));
                }         
        }

        public decimal CantidadDeArtHistorico(Carticulo oArt)
        {
            return Cdatos_ventas.CantHistoricaArt(oArt);
        }
    }
}
