using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Cforma_pago
    {
        string _descripcion;
        int _id;
        decimal _porcentaje;
        bool _descuento;
        bool _recargo;
        bool _altera_caja;
        bool _Codigo_Autorizacion;
        public int ID
        {
            set
            {
                if (value > -1)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("El ID no puede ser negativo");
                }
            }
            get
            {
                return _id;
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
        public Decimal Porcentaje
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El porcentaje no puede ser negativo");
                }
                else
                {
                    _porcentaje = value;
                }
            }
            get
            {
                return _porcentaje;
            }
        }
        public bool Recargo
        {
            set
            {
                _recargo = value;
            }
            get
            {
                return _recargo;
            }
        }
        public bool Descuento
        {
            set
            {
                _descuento = value;
            }
            get
            {
                return _descuento;
            }
        }
        public bool Altera_caja
        {
            set
            {
                _altera_caja = value;
            }
            get
            {
                return _altera_caja;
            }
        }
        public bool Autorizacion
        {
            set
            {
                _Codigo_Autorizacion = value;
            }
            get
            {
                return _Codigo_Autorizacion;
            }
        }

        public Cforma_pago (int id, string descripcion,bool desc,bool recargo,bool alteracaja,decimal porc,bool ConAutorizacion)
        {
            Descripcion = descripcion;
            ID = id;
            Descuento = desc;
            Porcentaje = porc;
            Recargo = recargo;
            Altera_caja = alteracaja;
            Autorizacion= ConAutorizacion;
        }

        public Cforma_pago(string descripcion, bool desc, bool recargo, bool alteracaja, decimal porc, bool ConAutorizacion)
        {
            Altera_caja = alteracaja;
            Descripcion = descripcion;
            Descuento = desc;
            Porcentaje = porc;
            Recargo = recargo;
            Autorizacion = ConAutorizacion;
        }
        public override string ToString()
        {
            return _descripcion;
        }
    }
}
