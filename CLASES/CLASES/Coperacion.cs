using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    abstract public class   Coperacion
    {
        decimal _importe;
        int _numero;
        DateTime _fecha;
        public int Numero
        {
            set
            {
                if (value > -1)
                {
                    _numero = value;
                }
                else
                {
                    throw new Exception("El Numero no puede ser negativo");
                }
            }
            get
            {
                return _numero;
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
        public decimal Importe
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("El importe no puede ser negativo");
                }
                else
                {
                    _importe = value;
                }
            }
            get
            {
                return _importe;
            }
        }
        
        
    }
}
