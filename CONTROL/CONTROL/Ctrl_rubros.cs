using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_rubros
    {
        public bool actualizar;
        List<Crubro> lista = new List<Crubro>();
        private static Ctrl_rubros Control;

        public static Ctrl_rubros ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_rubros();
                Control.CargarLista();
            }
            return Control;
        }
        public void CargarLista()
        {
            DataTable DT = Cdatos_rubros.Devolver();
            foreach (DataRow DR in DT.Rows)
            {
                lista.Add(new Crubro(Convert.ToInt32(DR[0]), DR[1].ToString()));
            }
            if (DT.Rows.Count == 0)
            {
                Agregar(new Crubro(1,"Generico"));
            }
        }
        public List<Crubro> VerLista()
        {
            return lista;
        }
        public void Agregar(Crubro obj)
        {
            try
            {
                Cdatos_rubros.Agregar(obj);
                lista.Insert(0,obj);
                actualizar = true;
            }
            catch
            {
                Agregar(obj);
            }
        }
        public Crubro BuscarPorID(int Numero)
        {
            foreach (Crubro obj in lista)
            {
                if (obj.Nro == Numero)
                {
                    return obj;
                }
            }
            return null;
        }

        public void Modificar(Crubro objmodicado,Crubro objantiguo)
        {
            if (objantiguo.Nro != objantiguo.Nro)
            {
                Cdatos_rubros.Agregar(objmodicado);
                Cdatos_rubros.CambiarDeArticulos(objantiguo, objmodicado);
                Cdatos_rubros.Eliminar(objantiguo);
                objantiguo.Nro = objmodicado.Nro;
            }
            else
                Cdatos_rubros.Modificar(objmodicado);
            objantiguo.Nombre = objmodicado.Nombre;
            actualizar = true;
        }
        public bool EnUso(Crubro obj)
        {
            return Cdatos_rubros.ReferenciasExistentes(obj);
        }
        public void Eliminar(Crubro obj)
        {
            Cdatos_rubros.Eliminar(obj);
            lista.Remove(obj);
            actualizar = true;
        }
        public void Reemplazar(Crubro objaReemplazar, Crubro objReemplazante)
        {
            Cdatos_rubros.CambiarDeArticulos(objaReemplazar, objReemplazante);
        }
        
        public int CantidadDeRubrosCanrgados()
        {
            return lista.Count;
        }
    }
}
