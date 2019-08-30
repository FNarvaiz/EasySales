using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Ccliente:Cpersona
    {
        int _id_cliente;
        public int ID_CLIENTE
        {
            set
            {
                _id_cliente = value;
            }
            get
            {
                return _id_cliente;
            }
        }
        
        public Ccliente(string nom, string direc, string tel, string celular, string email,Clocalidad localidad)
        {
            Nombre = nom;
            Domicilio = direc;
            Tel = tel;
            Email = email;
            Cel = celular;
            LOCALIDAD(localidad);
        }
        public Ccliente(int id_cliente,int id,string nom, string direc, string tel, string celular, string email,Clocalidad localidad)
        {
            ID_CLIENTE = id_cliente;
            ID = id;
            Nombre = nom;
            Domicilio = direc;
            Tel = tel;
            Email = email;
            Cel = celular;
            LOCALIDAD(localidad);
        }

    }
}
