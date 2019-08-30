using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_conceptos
    {
        public int ultimo;
        List<Cconcepto> lista = new List<Cconcepto>();
        private static Ctrl_conceptos Control;

        public static Ctrl_conceptos ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_conceptos();
                Control.CargarLista();
            }
            return Control;
        }
        public void CargarLista()
        {
            DataTable DT = Cdatos_conceptos.Devolver();
            foreach (DataRow DR in DT.Rows)
            {
                lista.Add(new Cconcepto(Convert.ToInt32(DR[0]), DR[1].ToString()));
            }
            if (DT.Rows.Count == 0){
                Agregar(new Cconcepto("Recibos a clientes cuentas corrientes."));
                Agregar(new Cconcepto("Pagos a proveedores cuentas corrientes."));
            }
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);

        }
        public List<Cconcepto> VerLista()
        {
            return lista;
        }
        public void Agregar(Cconcepto obj)
        {
            try
            {
                ultimo++;
                obj.ID = ultimo;
                Cdatos_conceptos.Agregar(obj);
                lista.Add(obj);
            }
            catch
            {
                Agregar(obj);
            }
        }
        public Cconcepto BuscarPorID(int id)
        {
            foreach (Cconcepto obj in lista)
            {
                if (obj.ID == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public List<Cconcepto> BuscarPorNombre(string concep)
        {
            List<Cconcepto> L = new List<Cconcepto>();
            string concepto;
            foreach (Cconcepto obj in lista)
            {
                concepto=obj.Concepto.ToLower();
                if(concepto.Contains(concep.ToLower()))
                {
                    L.Add(obj);
                }
            }
            return L;
        }
        public Cconcepto BuscarConcepto(string concep)
        {
            foreach (Cconcepto obj in lista)
            {
                if (obj.Concepto == concep)
                {
                    return obj;
                }
            }
            return null;
        }
        public void Modificar(Cconcepto obj)
        {
            Cdatos_conceptos.Modificar(obj);
        }
        public bool EnUso(Cconcepto obj)
        {
            return Cdatos_conceptos.TieneReferencias(obj);
        }
        public void Eliminar(Cconcepto obj)
        {
            Cdatos_conceptos.Eliminar(obj);
            lista.Remove(obj);
        }
        public List<Cconcepto> ListaParaCombo()
        {
            List<Cconcepto> L = new List<Cconcepto>();
            foreach (Cconcepto obj in lista)
                    L.Add(obj);
            L.Add(new Cconcepto(-1, "Nuevo Concepto"));
            return L;
        }
    }
}
