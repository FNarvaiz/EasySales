using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Citem
    {
        Carticulo _oArt;
        decimal _cant;
        decimal _precio_uni;
        decimal _total;
        public decimal Cantidad
        {
            set
            {
                
                    _cant = value;
                
            }

            get
            {
                return _cant;
            }
        }        
        public Carticulo Articulo
        {
            set
            {
                _oArt = value;
            }
            get
            {
                return _oArt;
            }
        }
        public decimal Precio_Uni
        {
            get
            {
                return _precio_uni;
            }
        }
        public decimal Total
        {
            set
            {
                _total = value;
            }
            get
            {
                return _total;
            }
        }
        //public Carticulo DevolverArt()
        //{
        //    return _oArt;
        //}
        
        public Citem(Carticulo oArt,decimal cant,decimal precio_uni)
        {
            Cantidad = cant;
            _oArt = oArt;
            _total= Math.Round(precio_uni*cant,2);
            _precio_uni = precio_uni;
        }
    }
}
