using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cregistro
    {
        DateTime _Fecha;
        String _Clave;
        public DateTime Fecha
        {
            set
            {
                _Fecha = value;
            }
            get
            {
                return _Fecha;
            }
        }
        public string Clave
        {
            set
            {
                _Clave = value;
            }
            get
            {
                return _Clave;
            }
        }
        public Cregistro(DateTime fecha, string clave)
        {
            Fecha = fecha;
            Clave = clave;
        }
    }
}
