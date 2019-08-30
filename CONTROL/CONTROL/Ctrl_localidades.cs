using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using C_DATOS;


namespace CONTROL
{
    public class Ctrl_localidades
    {
        public int ultimo;
        public bool actualizar;
        List<Clocalidad> lista = new List<Clocalidad>();
        private static Ctrl_localidades Control;

        public static Ctrl_localidades ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_localidades();
                Control.CargarLista();
            }
            return Control;
        }
        public void CargarLista()
        {
            DataTable DT = Cdatos_localidades.Devolver();
            foreach (DataRow DR in DT.Rows)
            {
                lista.Add(new Clocalidad(Convert.ToInt32(DR[0]), DR[1].ToString()));
            }
            if (DT.Rows.Count == 0)
            {
                ultimo = 0;
                Agregar(new Clocalidad("Miramar"));
            }
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);
            
        }
        public List<Clocalidad> VerLista()
        {
            return lista;
        }
        public void Agregar(Clocalidad obj)
        {
            try
            {
                ultimo++;
                obj.ID = ultimo;
                Cdatos_localidades.Agregar(obj);
                lista.Add(obj);
                actualizar = true;
            }
            catch
            {
                Agregar(obj);
            }
        }
        public Clocalidad BuscarPorID(int id)
        {
            foreach (Clocalidad obj in lista)
            {
                if (obj.ID== id)
                {
                    return obj;
                }
            }
            return null;
        }

        public void Modificar(Clocalidad obj)
        {
            Cdatos_localidades.Modificar(obj);
            actualizar = true;
        }
        public bool EnUso(Clocalidad obj)
        {
            return Cdatos_localidades.ReferenciasExistentes(obj);
        }
        public void Eliminar(Clocalidad obj)
        {
            Cdatos_localidades.Eliminar(obj);
            lista.Remove(obj);
            actualizar = true;
        }
        public void Reemplazar(Clocalidad objaReemplazar, Clocalidad objReemplazante)
        {
            Cdatos_localidades.CambiarDePersonas(objaReemplazar, objReemplazante);
        }
    }
}
