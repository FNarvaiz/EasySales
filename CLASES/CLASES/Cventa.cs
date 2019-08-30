using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cventa
    {
        decimal _Subtotal;
        decimal _Total;
        decimal _Descuento;
        int _id;
        List<Citem> lista;
        Cpago _pago;
        Cpago _pago2;

        public Cpago Pago
        {
            set
            {
                _pago = value;
            }
            get
            {
                return _pago;
            }
        }


        public Cpago Pago2
        {
            set
            {
                _pago2 = value;
            }
            get
            {
                return _pago2;
            }
        }

        public int ID
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public decimal Subtotal
        {
            set
            {
                _Subtotal= value;
            }
            get
            {
                return _Subtotal;
            }
        }
        public decimal DescRecargo
        {
            set
            {
                _Descuento = value;
            }
            get
            {
                return _Descuento;
            }
        }
        public decimal Total
        {
            set
            {
                _Total = value;
            }
            get
            {
                return _Total;
            }
        }
        public Cventa(Cpago opago)
        {
            lista = new List<Citem>();
            Pago = opago;
        }
        public Cventa()
        {
            lista = new List<Citem>();
        }
        // CONSTRUCTORES

        public Cventa(decimal subtotal, decimal total, decimal descuento, Cpago FP)
        {
            lista = new List<Citem>();
            Pago = FP;
            Subtotal = subtotal;
            Total = total;
            DescRecargo = descuento;
        }

        public Cventa(int id, decimal subtotal, decimal total, decimal descuento)
        {
            lista = new List<Citem>();
            Subtotal = subtotal;
            Total = total;
            DescRecargo = descuento;
            ID = id;
        }

        public Cventa(int id, decimal subtotal, decimal total, decimal descuento,Cpago FP)
        {
            lista = new List<Citem>();
            ID = id;
            Subtotal = subtotal;
            Total = total;
            DescRecargo = descuento;
            Pago = FP;
        }

        // METODOS
        public bool NoEstaEnLista(Citem obj)
        {
            foreach (Citem aux in lista)
            {
                if (aux.Articulo == obj.Articulo)
                {
                    aux.Cantidad += obj.Cantidad;
                    aux.Total += obj.Total;
                    return false;
                }
            }
            return true;
        }
        public void CalcularVenta(){
            if (Pago.FormaPago.Descuento)
                DescRecargo = Subtotal * Pago.FormaPago.Porcentaje / -100;
            else
            {
                if (Pago.FormaPago.Recargo)
                    DescRecargo = Subtotal * Pago.FormaPago.Porcentaje / 100;
                else
                    DescRecargo = 0;
            }
            DescRecargo = Math.Round(DescRecargo, 2);
            Total = Subtotal + DescRecargo;
        }
        
        public void CalcularVenta(decimal DescuentoRecargo)
        {
            DescRecargo = Math.Round(DescuentoRecargo, 2);
            Total = Subtotal + DescRecargo;
        }
        public void AgregarItem(Citem obj)
        {
            Subtotal += obj.Total;
            CalcularVenta();
            if(NoEstaEnLista(obj))
                lista.Insert(0,obj);
        }
        public void EliminarItem(Citem obj)
        {
            Subtotal -= obj.Total;
            CalcularVenta();
            lista.Remove(obj);
        }
        public List<Citem> Items()
        {
            return lista;
        }
    }
}
