using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Cpago_credito:Coperacion
    {
        bool _Alta;
        Cventa _Venta;
        int id_caja_diaria;
        string _concepto;
        List<Crecibo_debito> _recibos;
        public List<Crecibo_debito> Recibos()
        {
            return _recibos;
        }
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
        public int ID_Caja_Diaria()
        {
            return id_caja_diaria;
        }
        public void ID_Caja_Diaria(int id)
        {
            id_caja_diaria=id;
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
        public Cventa Venta()
        {
            return _Venta;
        }
        public void Venta(Cventa obj)
        {
            _Venta = obj;
        }
        public bool AltaOp()
        {
            return _Alta;
        }
        public void AgregarRecibo(Crecibo_debito obj)
        {
            _recibos.Add(obj);
        }
        public Cpago_credito(int numero, string concepto, decimal importe, DateTime fecha, bool alta)
        {
            Concepto = concepto;
            Numero = numero;
            Importe = importe;
            Fecha = fecha;
            Alta = alta;
        }
        public void InstanciaRecibos()
        {
            _recibos = new List<Crecibo_debito>();
        }
        public Cpago_credito(string concepto, decimal importe, DateTime fecha, bool alta)
        {
            Concepto = concepto;
            Importe = importe;
            Fecha = fecha;
            Alta = alta;
        }
    }
}
