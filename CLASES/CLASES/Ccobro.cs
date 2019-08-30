using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Ccobro:Coperacion
    {
        Cforma_pago _Forma_pago;
        Cconcepto _Concepto;
        Crecibo_debito _Debito;
        public Crecibo_debito Debito()
        {
            return _Debito;
        }
        public void Debito(Crecibo_debito ocred)
        {
            _Debito = ocred;
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

        
        
        public Ccobro(int numero, Cconcepto concepto, decimal importe,Cforma_pago FP)
        {
            _Concepto = concepto;
            Numero = numero;
            Importe = importe;
            _Forma_pago= FP;
            
        }

        public Ccobro(Cconcepto concepto, decimal importe,Cforma_pago FP)
        {
            _Concepto = concepto;
            Importe = importe;
            _Forma_pago = FP;
        }
    }
}
