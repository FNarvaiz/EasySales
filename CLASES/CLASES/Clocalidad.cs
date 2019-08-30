using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Clocalidad
    {
        string _nombre;
        int _id;    
        public int ID
        {
            set
            {
                if (value > -1)
                {
                    _id = value;
                }
                else
                {
                    throw new Exception("El ID no puede ser negativo");
                }
            }
            get
            {
                return _id;
            }
        }
        public string Nombre
        {
            set
            {
                if (value != "")
                {
                    _nombre = value;
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre para la localidad");
                }
            }
            get
            {
                return _nombre;
            }
        }

        public Clocalidad(int idLocalidad, string nombre)
        {
            Nombre = nombre;
            ID = idLocalidad;
        }
        public Clocalidad(string nombre)
        {
            Nombre = nombre;
        }
    }
}
