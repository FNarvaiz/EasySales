using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class cMercaderia
    {
        Carticulo _oArt;
        public string  Codigo
        {
            get
            {
                return _oArt.Codigo;
            }
        }
        public string  Descripcion
        {
            get
            {
                return _oArt.Descripcion;
            }
        }
        
        public decimal Stock
        {
            get{
                return _oArt.Stock;
            }
        }
        public decimal Activo_Al_Costo
        {
            get
            {
                return _oArt.Costo * _oArt.Stock;
            }
        }
        public decimal Activo_Al_Precio
        {
            get
            {
                return _oArt.Precio * _oArt.Stock;
            }
        }
        public decimal Utilidad
        {
            get
            {
                return Activo_Al_Precio - Activo_Al_Costo;
            }
        }
        public cMercaderia(Carticulo obj){
            _oArt=obj;
        }

    }
}
