using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C_DATOS;
using CLASES;
using System.Data;
namespace CONTROL
{
    class Ctrl_personas
    {
        int ultimo;
        Ctrl_cuentas_corrientes admcuentas;
        private static Ctrl_personas Control;

        public static Ctrl_personas ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_personas();
                Control.admcuentas = Ctrl_cuentas_corrientes.ClaseActiva();
            }
            return Control;
        }
        // CARGAR DATOS
        public int BuscarUltimo()
        {
            DataTable DT = Cdatos_personas.DevolverUltimo();
            if (DT.Rows.Count == 0)
                return 0;
            return Convert.ToInt32(DT.Rows[0][0]);
        }
        // METODOS ABM
        public int Agregar(Cpersona obj){
            try{
                if (ultimo == 0)
                {
                    ultimo = BuscarUltimo();
                }
                obj.ID=ultimo+1;
                Cdatos_personas.Agregar(obj);
                ultimo++;
                
                admcuentas.Agregar(new Ccuenta_corriente(0), obj);
                return ultimo;
            }
            catch{
                ultimo++;
                return Agregar(obj);
            }
        }
        public void Eliminar(Cpersona obj)
        {
            admcuentas.Eliminar(obj.DevolverCuentaCorriente());
            Cdatos_personas.Eliminar(obj);
        }
        public void Modificar(Cpersona obj)
        {
            Cdatos_personas.Modificar(obj);
        }
        public void DarBajaoAlta(Cpersona obj, bool Alta)
        {
            Cdatos_personas.BajaoAlta(obj,Alta);
        }
        
    }
}
