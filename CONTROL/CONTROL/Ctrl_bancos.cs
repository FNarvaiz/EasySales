using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using C_DATOS;

namespace CONTROL
{
    public class Ctrl_bancos
    {
        public int ultimo;
        public bool actualizar;
        List<Cbanco> lista = new List<Cbanco>();
        private static Ctrl_bancos Control;

        public static Ctrl_bancos ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_bancos();
                Control.CargarLista();
            }
            return Control;
        }
        public void CargarLista()
        {
            DataTable DT = Cdatos_bancos.Devolver();
            foreach (DataRow DR in DT.Rows)
            {
                lista.Add(new Cbanco(Convert.ToInt32(DR[0]), DR[1].ToString()));
            }
            if (DT.Rows.Count == 0)
            {
                ultimo = 0;
                Agregar(new Cbanco("Banco Nación"));
            }
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);

        }
        public List<Cbanco> VerLista()
        {
            return lista;
        }
        public void Agregar(Cbanco obj)
        {
            try
            {
                ultimo++;
                obj.ID = ultimo;
                Cdatos_bancos.Agregar(obj);
                lista.Add(obj);
                actualizar = true;
            }
            catch
            {
                Agregar(obj);
            }
        }
                
        public Cbanco BuscarPorID(int id)
        {
            foreach (Cbanco obj in lista)
            {
                if (obj.ID == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public void Modificar(Cbanco obj)
        {
            Cdatos_bancos.Modificar(obj);
            actualizar = true;
        }
        public bool EnUso(Cbanco obj)
        {
            return Cdatos_bancos.ReferenciasExistentes(obj);
        }
        public void Eliminar(Cbanco obj)
        {
            Cdatos_bancos.Eliminar(obj);
            lista.Remove(obj);
            actualizar = true;
        }
        public void Reemplazar(Cbanco objaReemplazar, Cbanco objReemplazante)
        {
            //Cdatos_bancos.CambiarDePersonas(objaReemplazar, objReemplazante);
        }
    }
}
