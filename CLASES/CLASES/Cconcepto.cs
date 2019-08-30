using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Cconcepto
    {
        string _descripcion;
        int _id;
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
        public override string ToString()
        {
            return _descripcion;
        }
        public string Concepto
        {
            set
            {
                if (value == "")
                {
                    throw new Exception("El concepto de una operación no puede ser vacio");
                }
                else
                    _descripcion = value;
            }
            get
            {
                return _descripcion;
            }
        }
        public Cconcepto(int id, string concepto)
        {
            ID = id;
            Concepto = concepto;
        }
        public Cconcepto(string concepto)
        {
            Concepto = concepto;
        }

    }
}
