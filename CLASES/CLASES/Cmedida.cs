using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cmedida
    {
        int _id;
        string _nombre;
        bool _entero;

        public int ID
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public string  Nombre
        {
            set
            {
                _nombre = value;
            }
            get
            {
                return _nombre;
            }
        }
        public bool Entero
        {
            set
            {
                _entero = value;
            }
            get
            {
                return _entero;
            }
        }
        public Cmedida(int id, string nombre, bool entero)
        {
            Entero = entero;
            Nombre = nombre;
            ID = id;
        }
        public Cmedida( string nombre, bool entero)
        {
            Entero = entero;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return _nombre;
        }
    }
}
