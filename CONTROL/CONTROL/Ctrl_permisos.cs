using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using C_DATOS;
namespace CONTROL
{
    public class Ctrl_permisos
    {
        public int ultimo;
        public bool actualizar;
        List<Cpermiso> lista = new List<Cpermiso>();
        private static Ctrl_permisos Control;

        public static Ctrl_permisos ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_permisos();
                Control.CargarLista();
            }
            return Control;
        }
        public void CargarLista()
        {
            if (lista.Count == 0)
            {
                DataTable DT = Cdatos_permisos.Devolver();
                foreach (DataRow DR in DT.Rows)
                {
                    lista.Add(new Cpermiso(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToBoolean(DR[2]), Convert.ToBoolean(DR[3]), Convert.ToBoolean(DR[4]), Convert.ToBoolean(DR[5]), Convert.ToBoolean(DR[6]), Convert.ToBoolean(DR[7]), Convert.ToBoolean(DR[8]), Convert.ToBoolean(DR[9]), Convert.ToBoolean(DR[10]), Convert.ToBoolean(DR[11])));
                }
                if (DT.Rows.Count == 0)
                {
                    ultimo = 0;
                   Agregar(new Cpermiso("Administrador",true,true,true,true,true,true,true,true,true,true));
                }
                else
                    ultimo = Convert.ToInt32(DT.Rows[0][0]);
            }
        }
        public List<Cpermiso> VerLista()
        {
            return lista;
        }
        public void Agregar(Cpermiso obj)
        {
            try
            {
                ultimo++;
                obj.ID = ultimo;
                Cdatos_permisos.Agregar(obj);
                lista.Add(obj);
                actualizar = true;
            }
            catch
            {
                Agregar(obj);
            }
        }
        public Cpermiso BuscarPorID(int id)
        {
            foreach (Cpermiso obj in lista)
            {
                if (obj.ID == id)
                {
                    return obj;
                }
            }
            return null;
        }

        public void Modificar(Cpermiso obj)
        {
            Cdatos_permisos.Modificar(obj);
            actualizar = true;
        }
        public bool EnUso(Cpermiso obj)
        {
            return Cdatos_permisos.ReferenciasExistentes(obj);
        }
        public void Eliminar(Cpermiso obj)
        {
            Cdatos_permisos.Eliminar(obj);
            lista.Remove(obj);
            actualizar = true;
        }
    }
}
