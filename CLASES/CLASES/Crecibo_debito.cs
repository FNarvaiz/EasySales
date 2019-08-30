using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Crecibo_debito:Coperacion
    {
        bool _Alta;
        Ccompra _Compra;
        string _concepto;
        List<Cpago_credito> _creditos;
        public string Concepto
        {
            set
            {
                if (value != "")
                {
                    _concepto = value;
                }
                else
                {
                    throw new Exception("La Concepto no puede estar vacia");
                }
            }
            get
            {
                return _concepto;
            }
        }
        public Ccompra Compra()
        {
            return _Compra;
        }
        public void Compra(Ccompra obj)
        {
            _Compra = obj;
        }
        public bool Alta
        {
            set
            {
                _Alta = value;
            }
            get
            {
                return _Alta;
            }
        }
        public void AgregarCreditos(Cpago_credito obj)
        {
            _creditos.Add(obj);
        }
        public bool AltaOp()
        {
            return _Alta;
        }

        public Crecibo_debito(int numero, string concepto, decimal importe, DateTime fecha, bool alta)
        {
            Concepto = concepto;
            Numero = numero;
            Importe = importe;
            Fecha = fecha;
            Alta = alta;
            
        }
        public void InstanciaCreditos()
        {
            _creditos = new List<Cpago_credito>();
        }
        public List<Cpago_credito> Creditos()
        {
            return _creditos;
        }
        public Crecibo_debito(string concepto, decimal importe, DateTime fecha, bool alta)
        {
            Concepto = concepto;
            Importe = importe;
            Fecha = fecha;
            Alta = alta;
        }
    }
}
