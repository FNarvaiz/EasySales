using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cbanco
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
        public string NOMBRE
        {
            set
            {
                if (value != "")
                {
                    _nombre = value;
                }
                else
                {
                    throw new Exception("Debe ingresar un nombre para el banco");
                }
            }
            get
            {
                return _nombre;
            }
        }
        public Cbanco(int idBanco, string nombre)
        {
            NOMBRE = nombre;
            ID = idBanco;
        }
        public Cbanco(string nombre)
        {
            NOMBRE = nombre;
        }
    }
}
