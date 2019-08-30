using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    abstract public class  Cpersona
    {
        int _IdPersona;
        string _Nombre;
        string _Direccion;
        string _Telefono;
        string _Celular;
        string _email;
        Clocalidad _localidad;
        Ccuenta_corriente _cuenta;
        public void AgregarCuentaCorriente(Ccuenta_corriente obj)
        {
            _cuenta = obj;
        }
        public Ccuenta_corriente DevolverCuentaCorriente()
        {
            return _cuenta;
        }
        public int ID
        {
            set
            {
                if (value > 0)
                {
                    _IdPersona = value;
                }
                else
                {
                    throw new ArgumentException("Error en ID de cliente");
                }
            }
            get
            {
                return _IdPersona;
            }
        }
        public string Nombre
        {
            set
            {
                if (value != "")
                {
                    _Nombre = value;
                }
                else
                {
                    throw new ArgumentException("Debe ingresar un nombre para el cliente");
                }
            }
            get
            {
                return _Nombre;
            }
        }
        public string Cel
        {
            set
            {
                _Celular = value;
            }
            get
            {
                return _Celular;
            }
        }
        public string Email
        {
            set
            {
                    _email = value;
               
            }
            get
            {
                return _email;
            }
        }
        public string Domicilio
        {
            set
            {
                _Direccion = value;
            }
            get
            {
                return _Direccion;
            }
        }
        public string Tel
        {
            set
            {
                _Telefono = value;
            }
            get
            {
                return _Telefono;
            }
        }
        public string Localidad
        {
            get
            {
                return _localidad.Nombre;
            }
        }
        public decimal Saldo
        {
            get
            {
                return DevolverCuentaCorriente().Saldo;
            }
        }
        public void LOCALIDAD(Clocalidad localidad)
        {
            _localidad = localidad;
        }
        public Clocalidad LOCALIDAD()
        {
            return _localidad;
        }


        

    }
    
}
