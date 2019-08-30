using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C_DATOS;
using CLASES;
using System.Data;
namespace CONTROL
{
    public class Ctrl_formas_pagos
    {
        public int ultimo;
        List<Cforma_pago> lista = new List<Cforma_pago>();
        private static Ctrl_formas_pagos Control;
        public bool actualizar = false;
        public static Ctrl_formas_pagos ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_formas_pagos();
            }
            return Control;
        }
        public DataTable VerTodos()
        {
            DataTable DT = Cdatos_formas_pagos.Devolver();
            if (DT.Rows.Count == 0)
                ultimo = 0;
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);
            return DT;
        }
        public void CargarLista()
        {
            if (lista.Count == 0)
            {
                DataTable DT = Cdatos_formas_pagos.Devolver();
                foreach (DataRow DR in DT.Rows)
                {
                    lista.Add(new Cforma_pago(Convert.ToInt32(DR[0]), DR[1].ToString(), Convert.ToBoolean(DR[3]), Convert.ToBoolean(DR[4]), Convert.ToBoolean(DR[5]), Convert.ToDecimal(DR[2]),Convert.ToBoolean(DR[6])));
                }
                if (DT.Rows.Count == 0)
                {
                    ultimo = 0;
                    Agregar(new Cforma_pago("Contado",false,false,true,0,false));
                    Agregar(new Cforma_pago("Cuenta Corriente",false,false,false,0,false));
                }
                else
                    ultimo = Convert.ToInt32(DT.Rows[0][0]);
            }
        }
        public List<Cforma_pago> VerLista()
        {
            return lista;
        }
        public void Agregar(Cforma_pago obj){
            try{
                ultimo++;
                obj.ID=ultimo;
                Cdatos_formas_pagos.Agregar(obj);
                lista.Add(obj);
                actualizar = true;
            }
            catch{
                Agregar(obj);
            }
        }
        public Cforma_pago BuscarPorID(int id)
        {
            foreach (Cforma_pago obj in lista)
            {
                if (obj.ID == id)
                {
                    return obj;
                }
            }
            return null;
        }

        public void Modificar(Cforma_pago obj)
        {
            Cdatos_formas_pagos.Modificar(obj);
            actualizar = true;
        }
        public bool EnUso(Cforma_pago obj){
            return Cdatos_formas_pagos.EnUso(obj);
        }
        public void CambiarReferenciasDe(Cforma_pago objaCambiar, Cforma_pago objremplasante)
        {
            Cdatos_formas_pagos.CambiarReferencias1a2(objaCambiar, objremplasante);
        }
        public void Eliminar(Cforma_pago obj)
        {
            if (obj.ID == 2 || obj.ID == 1)
                throw new Exception("La forma de pago " + obj.Descripcion + " es propia del sistema. No se puede eliminar");
            Cdatos_formas_pagos.Eliminar(obj);
            lista.Remove(obj);
            actualizar = true;
        }
    }
}
