using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_medidas
    {
        public int ultimo;
        public bool actualizar;
        List<Cmedida> lista = new List<Cmedida>();
        private static Ctrl_medidas Control;

        public static Ctrl_medidas ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_medidas();
                Control.CargarLista();
            }
            return Control;
        }
        public void CargarLista()
        {
            DataTable DT = Cdatos_medidas.Devolver();
            foreach (DataRow DR in DT.Rows)
            {
                lista.Add(new Cmedida(Convert.ToInt32(DR[0]), DR[1].ToString(),Convert.ToBoolean(DR[2])));
            }
            if (DT.Rows.Count == 0)
            {
                ultimo = 0;
                Agregar(new Cmedida( "Unidad", true));
                Agregar(new Cmedida( "Gramo", false));
                Agregar(new Cmedida( "kilogramo", false));
                Agregar(new Cmedida( "Miligramo", false));
                Agregar(new Cmedida( "Litro", false));
                Agregar(new Cmedida( "Mililitro", false));
            }
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);
        }
        public List<Cmedida> VerLista()
        {
            return lista;
        }
        public void Agregar(Cmedida obj)
        {
            try
            {
                ultimo++;
                obj.ID = ultimo;
                Cdatos_medidas.Agregar(obj);
                lista.Add(obj);
                actualizar = true;
            }
            catch
            {
                Agregar(obj);
            }
        }
        public Cmedida BuscarPorID(int ID)
        {
            foreach (Cmedida obj in lista)
            {
                if (obj.ID == ID)
                {
                    return obj;
                }
            }
            return null;
        }

        public void Modificar(Cmedida objmodicado, Cmedida objantiguo)
        {
            if (objantiguo.ID != objantiguo.ID)
            {
                Cdatos_medidas.Agregar(objmodicado);
                Cdatos_medidas.CambiarDeArticulos(objantiguo, objmodicado);
                Cdatos_medidas.Eliminar(objantiguo);
                objantiguo.ID = objmodicado.ID;
            }
            else
                Cdatos_medidas.Modificar(objmodicado);
            objantiguo.Nombre = objmodicado.Nombre;
            actualizar = true;
        }
        public bool EnUso(Cmedida obj)
        {
            return Cdatos_medidas.ReferenciasExistentes(obj);
        }
        public void Eliminar(Cmedida obj)
        {
            Cdatos_medidas.Eliminar(obj);
            lista.Remove(obj);
            actualizar = true;
        }
        public void Reemplazar(Cmedida objaReemplazar, Cmedida objReemplazante)
        {
            Cdatos_medidas.CambiarDeArticulos(objaReemplazar, objReemplazante);
        }
    }
}
