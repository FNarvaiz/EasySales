using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Ccompra
    {
        List<Citem> _Lista;
        decimal _subtotal;
        decimal _total;
        decimal _descuento;
        int _ID;
        DateTime _fecha;
        Cforma_pago _oforma_pago;
        Cproveedor _Proveedor;
        public int Id
        {
            set
            {
                if (value > -1)
                {
                    _ID = value;
                }
                else
                {
                    throw new Exception("El ID no puede ser negativo");
                }
            }
            get
            {
                return _ID;
            }
        }        
        public DateTime Fecha
        {
            set
            {
                _fecha = value;
            }
            get
            {
                return _fecha;
            }
        }
        public decimal Subtotal
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El total no puede ser negativo");
                }
                else
                {
                    _subtotal = value;
                }

            }
            get
            {
                return _subtotal;
            }
        }
        public decimal Descuento
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Los descuentos obtenidos no puede ser negativos");
                }
                else
                {
                    _descuento = value;
                }
            }
            get
            {
                return _descuento;
            }
        }
        public decimal Total
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El total no puede ser negativo");
                }
                else
                {
                    _total = value;
                }
                
            }
            get
            {
                return _total;
            }
        }
        public Cforma_pago Forma_Pago
        {
            set
            {
                _oforma_pago = value;
            }
          get
            {
                return _oforma_pago;
            }
        }
        public Cproveedor Proveedor
        {
            set
            {
                _Proveedor = value;
            }
            get
            {
                return _Proveedor;
            }
        }
        public List<Citem> L_items
        {
            set 
            {
                if (value != null)
                {
                    _Lista = value;
                }
            }
        }
        public List<Citem> Lista()
        {
            return _Lista;
        }

        public Cforma_pago FormaPagoDevolver() 
        {
            return _oforma_pago;
        }
        public void FormaPagoCambiar(Cforma_pago obj)
        {
            _oforma_pago = obj;
        }
        
        public Ccompra Clonar()
        {
            Ccompra oCompra= (Ccompra)this.MemberwiseClone();
            oCompra._Lista = new List<Citem>();
            Citem oItemClonado;
            foreach(Citem oItem in _Lista){
                oItemClonado = new Citem(oItem.Articulo, oItem.Cantidad, oItem.Precio_Uni);
                oCompra._Lista.Add(oItemClonado);
            }
            return oCompra;
        }
        public Ccompra(int id, decimal subtotal, decimal total, decimal descuento, DateTime fecha, Cforma_pago oFormaPago, List<Citem> ListaArt)
        {
            Total = total;
            Id = id;
            Descuento = descuento;
            Fecha = fecha;
            _oforma_pago = oFormaPago;
            L_items = ListaArt;
            Subtotal = subtotal;
        }
        public Ccompra(int id, decimal subtotal, decimal total, decimal descuento, DateTime fecha)
        {
            Total = total;
            Id = id;
            Descuento = descuento;
            Fecha = fecha;
            Subtotal = subtotal;
        }
        public Ccompra(decimal subtotal, decimal total, decimal descuento, DateTime fecha, Cforma_pago oFormaPago)
        {
            Total = total;
            Descuento = descuento;
            Fecha = fecha;
            _oforma_pago = oFormaPago;
            _Lista = new List<Citem>();
            Subtotal = subtotal;
        }
        public Ccompra(int id, decimal subtotal, decimal total, decimal descuento, DateTime fecha, Cforma_pago oFormaPago)
        {
            Id = id;
            Subtotal = subtotal;
            Total = total;
            Descuento = descuento;
            Fecha = fecha;
            _oforma_pago = oFormaPago;
            _Lista = new List<Citem>();
        }

        public Ccompra(decimal subtotal, decimal total, decimal descuento, DateTime fecha, Cforma_pago oFormaPago, List<Citem> ListaArt)
        {
            Subtotal = subtotal;
            Total = total;
            Descuento = descuento;
            Fecha = fecha;            
            _oforma_pago = oFormaPago;
            L_items=ListaArt;

        }
        public void Agregar(Citem obj)
        {
            
            _Lista.Insert(0,obj);
            Subtotal += obj.Total;
        }
        public void AgregarAExistente(Citem obj)
        {
            foreach (Citem oitem in _Lista)
            {
                if (oitem.Articulo.Codigo == obj.Articulo.Codigo)
                {
                    Subtotal -= oitem.Total;
                    oitem.Cantidad += obj.Cantidad;
                    oitem.Total = oitem.Precio_Uni * oitem.Cantidad;
                    obj.Total = oitem.Total;
                }
            }
            Subtotal += obj.Total;
        }
        public bool EstaEnLista(Citem obj)
        {
            foreach (Citem oitem in _Lista)
            {
                if (oitem.Articulo.Codigo == obj.Articulo.Codigo)
                {
                    return true;
                }
            }
            return false;
        }

        public void Eliminar(Citem obj)
        {
            
            _Lista.Remove(obj);
            Subtotal -= obj.Total;
        }
    }
    
}
