using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Cgasto:Coperacion
    {
        Cforma_pago _Forma_pago;
        Cconcepto _Concepto;
        Cpago_credito _Credito;
        public Cpago_credito Credito()
        {
            return _Credito;
        }
        public void Credito(Cpago_credito ocred)
        {
            _Credito = ocred;
        }
        public string Concepto
        {
            get
            {
                return _Concepto.Concepto;
            }
        }
        public int ID_Concepto()
        {
                return _Concepto.ID;
        }
        public string FormaDePago
        {
            get
            {
                return _Forma_pago.Descripcion;
            }
        }
        public Cforma_pago FORMAPAGO()
        {
            return _Forma_pago;
        }
        public void FORMAPAGO(Cforma_pago obj)
        {
            _Forma_pago = obj;
        }
        public Cgasto (int numero, Cconcepto concepto, decimal importe,Cforma_pago FP)
        {
            _Concepto = concepto;
            Numero = numero;
            Importe = importe;
            _Forma_pago = FP;
        }

        public Cgasto(Cconcepto concepto, decimal importe, Cforma_pago FP)
        {
            _Concepto = concepto;
            Importe = importe;
            _Forma_pago = FP;
        }
    }
}
