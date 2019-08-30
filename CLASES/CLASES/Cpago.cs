using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cpago
    {
        Cforma_pago _formapago;
        Cpersona _persona;
        decimal _importe;
        string _codAutorizacion;
        decimal _descuento;

        public Cforma_pago FormaPago
        {
            set
            {
                _formapago = value;
            }
            get
            {
                return _formapago;
            }
        }
        public Cpersona Persona
        {
            set 
            {
                _persona = value;
            }
            get
            {
                return _persona;
            }
        }

        public decimal Importe
        {
            set
            {
                _importe = value;
            }
            get
            {
                return _importe;
            }
        }

        public string Cod_Autorizacion
        {
            set
            {
                _codAutorizacion = value;
            }
            get
            {
                return _codAutorizacion;
            }
        }

        public decimal Descuento
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

        public Cpago()
        { 
        
        }

        public Cpago(Cforma_pago forma, decimal importe,string codAutorizacion,decimal descuento)
        {
            FormaPago = forma;
            Importe = importe;
            Cod_Autorizacion = codAutorizacion;
            Descuento = descuento;
        }

        public override string ToString()
        {
            return FormaPago.Descripcion+ " $" + Importe;
        }
    }
}
