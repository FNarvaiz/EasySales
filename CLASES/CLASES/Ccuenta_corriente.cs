using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Ccuenta_corriente
    {
        decimal _saldo;
        int _id;
        List<Cpago_credito> _Creditos;
        List<Crecibo_debito> _Debitos;
        
        public int ID
        {
            set
            {
                if (value > 0)
                {
                    _id= value;
                }
                else
                {
                    throw new ArgumentException("Error en ID de cuenta corriente");
                }
            }
            get
            {
                return _id;
            }
        }
        public decimal Saldo
        {
            set
            {
                _saldo = value;
            }
            get
            {
                return _saldo;
            }
        }
        public List<Cpago_credito> Creditos
        {
            set
            {
                _Creditos = value;
            }
            get
            {
                return _Creditos;
            }
        }
        public List<Crecibo_debito> Debitos
        {
            set
            {
                _Debitos = value;
            }
            get
            {
                return _Debitos;
            }
        }
        public Ccuenta_corriente(int id, decimal saldo)
        {
            Saldo = saldo;
            ID = id;
        }
        public Ccuenta_corriente(decimal saldo)
        {
            Saldo = saldo;
        }
        public void AgregarCredito(Cpago_credito obj)
        {
            
            _Creditos.Add(obj);
            Saldo += obj.Importe;
        }
        public void AgregarDebito(Crecibo_debito obj)
        {
            _Debitos.Add(obj);
            Saldo -= obj.Importe;
        }
        public void EliminarCredito(Cpago_credito obj)
        {
            _Creditos.Remove(obj);
            Saldo -= obj.Importe;
        }
        public void EliminarDebito(Crecibo_debito obj)
        {
            _Debitos.Remove(obj);
            Saldo += obj.Importe;
        }
        public void ModificarCredito(Cpago_credito obj, decimal nuevoimporte)
        {
            Saldo += (nuevoimporte - obj.Importe);
            obj.Importe = nuevoimporte;
        }
        public void ModificarDebito(Crecibo_debito obj, decimal nuevoimporte)
        {
            Saldo -= (nuevoimporte - obj.Importe);
            obj.Importe = nuevoimporte;
        }
        public Cpago_credito BuscarCredito(int numero)
        {
            foreach (Cpago_credito aux in Creditos)
            {
                if (aux.Numero == numero)
                    return aux;
            }
            return null;
        }
        public Crecibo_debito BuscarDebito(int numero)
        {
            foreach (Crecibo_debito aux in Debitos)
            {
                if (aux.Numero == numero)
                    return aux;
            }
            return null;
        }
    }

}
