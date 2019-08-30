using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Ccaja
    {
        int _numero;
        public int Numero
        {
            set
            {
                _numero = value;
            }
            get
            {
                return _numero;
            }
        }
        public Ccaja(int numero)
        {
            Numero = numero;
        }
    }
}
