using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  Cusuario:Cpersona
    {
        int _id_usuario;
        string _pass;
        Cpermiso _permiso;
        public int ID_USUARIO
        {
            set
            {
                _id_usuario = value;
            }
            get
            {
                return _id_usuario;
            }
        }
        public string PASS
        {
            set
            {
                if (value != "")
                {
                    _pass = value;
                }
                else
                {
                    throw new Exception("Debe ingresar un pass para el usuario");
                }
            }
            get
            {
                return _pass;
            }
        }
        public String Permiso
        {
            get
            {
                return _permiso.Descripcion;
            }
        }
        public void PERMISO(Cpermiso permiso)
        {
            _permiso = permiso;
        }
        public Cpermiso PERMISO()
        {
            return _permiso;
        }
        
        public Cusuario(string nom,string pass, string direc, string tel, string celular, string email,Clocalidad localidad,Cpermiso permiso)
        {
            PASS = pass;
            Nombre = nom;
            Domicilio = direc;
            Tel = tel;
            Email = email;
            Cel = celular;
            LOCALIDAD(localidad);
            PERMISO(permiso);
        }

        public Cusuario(int id_usuario,int id,string nom,string pass, string direc, string tel, string celular, string email,Clocalidad localidad,Cpermiso permiso)
        {
            ID_USUARIO = id_usuario;
            PASS = pass;
            ID = id;
            Nombre = nom;
            Domicilio = direc;
            Tel = tel;
            Email = email;
            Cel = celular;
            LOCALIDAD(localidad);
            PERMISO(permiso);
        }
    }
}
