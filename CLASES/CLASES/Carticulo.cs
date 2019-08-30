using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Carticulo : ICloneable
    { 
        string _descripcion;
        decimal _precio;
        decimal _costo;
        decimal _stock;
        string  _codigo;
        Crubro _rubro;
        Cmedida _medida;
        decimal _iva;
        string _nota;
        decimal _cantbaja;
        decimal _cantmedia;
        decimal _cantalta;



        //public Cmedida MEDIDA()
        //{
        //    return _medida;
        //}
        //public void RUBRO(Crubro obj)
        //{
        //    _rubro = obj;
        //}
        //public Crubro RUBRO()
        //{
        //    return _rubro;
        //}
        public Crubro Rubro
        {
            set
            {
                _rubro = value;
            }
            get
            {
                return _rubro;
            }
        }
        
        public string Codigo
        {
            set
            {
                if (value != "")
                {
                    _codigo = value;
                }
                else
                {
                    throw new Exception("Ingrese el código del artículo.");
                }
            }
            get
            {
                return _codigo;
            }
        }
        public string Descripcion
        {
            set
            {
                if (value != "")
                {
                    _descripcion = value;
                }
                else
                {
                    throw new Exception("La descripcion no puede estar vacia");
                }
            }
            get
            {
                return _descripcion;
            }
        }
        public decimal Stock
        {
            set
            {
                if (_medida.Entero)
                    _stock = Math.Round(value);
                else
                    _stock = value;
            }
            get
            {
                return _stock;
            }
        }
        public decimal Costo
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El costo no puede ser negativo");
                }
                else
                {
                    _costo = value;
                }
            }
            get
            {
                return _costo;
            }
        }
        public decimal Precio
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El precio no puede ser negativo");
                }
                else
                {
                    _precio = value;
                }
            }
            get
            {
                return _precio;
            }
        }
        public decimal Iva
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El IVA no puede ser negativo");
                }
                else
                {
                    _iva = value;
                }
            }
            get
            {
                return _iva;
            }
        }
        public string Nota
        {
            set
            {
                 _nota = value;
            }
            get
            {
                return _nota;
            }
        }
        
        public Cmedida Unidad_Medida
        {
            set
            {
                _medida = value;
            }
            get 
            { 
                return _medida; 
            }
        }

        public decimal CantBaja
        {
            set
            {
                _cantbaja = value;
            }
            get
            {
                return _cantbaja;
            }
        }
        public decimal CantMedia
        {
            set
            {
                if (CantBaja < value)
                    _cantmedia = value;
                else
                    throw new Exception("El stock medio no puede ser menor al stock bajo.");
            }
            get
            {
                return _cantmedia;
            }
        }
        public decimal CantAlta
        {
            set
            {
                if(CantMedia<value)
                    _cantalta = value;
                else
                    throw new Exception("El stock alto no puede ser menor al stock medio.");
            }
            get
            {
                return _cantalta;
            }
        }

        public void Modificar_Stock(decimal cant)
        {
            Stock += cant;
        }

        public Carticulo( string descrip, decimal precio, decimal costo)
        {
            Descripcion = descrip;         
            Precio = precio;
            Costo = costo;
        }
        public Carticulo(string codigo, string descrip, decimal precioConIva, decimal costo, decimal stock,Crubro orubro,Cmedida omedida,decimal iva,string nota,decimal cantAlta,decimal cantMedia,decimal cantBaja)
        {
            Descripcion = descrip;
            Codigo = codigo;
            Precio = precioConIva;
            Costo = costo;
            
            _rubro = orubro;
            _medida = omedida;
            _iva = iva;
            _nota = nota;
            CantBaja = cantBaja;
            CantMedia = cantMedia;
            CantAlta = cantAlta;
            Stock = stock;
        }
        public Carticulo()
        {
        }
        public decimal CalcularPrecioSinIVA()
        {      
         decimal oiva = (Convert.ToDecimal(Iva) / 100) + 1;
         return Math.Round((Precio / oiva), 2);
        }
        public decimal CantidadReponer()
        {
                if (CantAlta < Stock)
                {
                    return 0;                    
                }
                else
                {
                    return CantAlta - Stock;
                }
        }
        public override string ToString()
        {
            return _descripcion;
        }
        public  object Clone()
        {
            return MemberwiseClone(); 
        }
    }
}
