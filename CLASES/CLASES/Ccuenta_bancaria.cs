using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Ccuenta_bancaria
    {
        string _Cbu;
        Cpersona _oPersona;
        Cbanco _oBanco;
        string _NroCuenta;
        string _TipoCuenta;
        string _Titular;

        public string CBU
        { 
            set
            {
                if (value != "")
                {
                    _Cbu = value;
                }
            }
            get
            {
                return _Cbu;
            }
        }
        public Cpersona PERSONA
        {
            set
            {
                if (value != null)
                {
                    _oPersona = value;
                }
            }
            get 
            {
                return _oPersona;
            }
        }
        public Cbanco BANCO
        {
            set
            {
                if (value != null)
                {
                    _oBanco = value;
                }
            }
            get
            {
                return _oBanco;
            }
        }
        public string NRO_CUENTA
        {
            set
            {
                if (value != "")
                {
                    _NroCuenta = value;
                }
            }
            get
            {
                return _NroCuenta;
            }
        }
        public string TIPO_CUENTA
        {
            set
            {
                if (value != "")
                {
                    _TipoCuenta = value;
                }
            }
            get
            {
                return _TipoCuenta;
            }
        }
        public string TITULAR
        {
            set
            {
                if (value != "")
                {
                    _Titular = value;
                }
            }
            get
            {
                return _Titular;
            }
        }
  
        public Ccuenta_bancaria(string cbu, Cpersona opersona, string titular, string tipoCuenta, string nroCuenta, Cbanco obanco)
        {
            CBU = cbu;
            PERSONA = opersona;
            BANCO = obanco;
            NRO_CUENTA = nroCuenta;
            TIPO_CUENTA = tipoCuenta;
            TITULAR = titular;
        }
    }
}
