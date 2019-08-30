using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using C_DATOS;
namespace CONTROL
{
    public class Ctrl_cajas
    {
        List<Ccaja> lista = new List<Ccaja>();
        public bool Existe(Ccaja obj)
        {
            foreach (Ccaja caja in lista)
            {
                if (caja.Numero == obj.Numero)
                    return true;
            }
            return false;
        }
        public void Modificar(Ccaja obj, Ccaja objmodificado)
        {
            Cdatos_cajas.Modificar(obj,objmodificado);
            obj.Numero = obj.Numero;
        }
        public void Agregar(Ccaja obj)
        {
            Cdatos_cajas.Agregar(obj);
            lista.Add(obj);
        }
        public List<Ccaja> VerLista()
        {
            if (lista.Count == 0)
            {
                DataTable DT = Cdatos_cajas.DevovlerTodos();
                foreach (DataRow DR in DT.Rows)
                {
                    lista.Add(new Ccaja(Convert.ToInt32(DR[0])));
                }
                if (DT.Rows.Count == 0)
                {
                    Agregar(new Ccaja(1));
                }
            }
            return lista;
        }
        public bool TieneReferencias(Ccaja obj)
        {
            return Cdatos_cajas.ReferenciasExistentes(obj);
        }
        public void Eliminar(Ccaja obj)
        {
            Cdatos_cajas.Eliminar(obj);
            lista.Remove(obj);
        }
    }
}
