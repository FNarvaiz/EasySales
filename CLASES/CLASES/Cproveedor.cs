using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Cproveedor:Cpersona
    {

        string _Cuit;
        int _id_proveedor;

        public int ID_PRO
        {
            set
            {
                _id_proveedor = value;
            }
            get
            {
                return _id_proveedor;
            }
        }
        public string CUIT
        {
            set
            {
                _Cuit = value;
            }
            get
            {
                return _Cuit;
            }
        }
        public Cproveedor(string nom, string direc, string tel, string celular, string email, string cuit,Clocalidad localidad)
        {
            Nombre = nom;
            Domicilio = direc;
            Tel = tel;
            Email = email;
            Cel = celular;
            CUIT=cuit;
            LOCALIDAD(localidad);
        }

        public Cproveedor(int id_pro, int Id, string nombre, string direc, string tel, string celular, string email, string cuit, Clocalidad localidad)
        {
            ID_PRO = id_pro;
            ID= Id;
            Nombre = nombre;
            Domicilio = direc;
            Tel = tel;
            Email = email;
            Cel = celular;
            CUIT=cuit;
            LOCALIDAD(localidad);
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
