using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Crubro
    {
        int _numero;
        string _nombre;
        
        
        public int Nro
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
        
        public string Nombre
        {
            set
            {
                if (value == "")
                {
                    throw new Exception("El rubro no puede ser vacio");
                }
                else
                    _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }
        
        public Crubro(int num, string nom)
        {
            Nro = num;
            Nombre = nom;
            
        }
        public Crubro(string num, string nom)
        {
            if(num=="")
                throw new Exception("El numero de rubro es necesario");
            Nro = Convert.ToInt32(num);
            Nombre = nom;
           
        }
        
        public override string ToString()
        {
            return Nombre;
        }
    }
}
