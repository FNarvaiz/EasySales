using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_cobros_gastos
    {
        public void CargarCobrosyGastos(Ccaja_diaria obj)
        {
            DataTable DT = Cdatos_operaciones.Devolver("COBROS", obj);
            obj.InstanciarCobros();
            Cforma_pago objformapago;
            Ctrl_formas_pagos admfomas = Ctrl_formas_pagos.ClaseActiva();
            Ctrl_conceptos admconceptos = Ctrl_conceptos.ClaseActiva();
            foreach (DataRow DR in DT.Rows)
            {
                objformapago = admfomas.BuscarPorID(Convert.ToInt32(DR[3]));
                
                obj.AgregarCobro(new Ccobro(Convert.ToInt32(DR[0]), admconceptos.BuscarPorID(Convert.ToInt32(DR[1])), Convert.ToDecimal(DR[2]), objformapago));
            }
            DT = Cdatos_operaciones.Devolver("GASTOS", obj);
            obj.InstanciarGastos();
            foreach (DataRow DR in DT.Rows)
            {
                objformapago = admfomas.BuscarPorID(Convert.ToInt32(DR[3]));
                obj.AgregarGasto(new Cgasto(Convert.ToInt32(DR[0]), admconceptos.BuscarPorID(Convert.ToInt32(DR[1])), Convert.ToDecimal(DR[2]), objformapago));
            }
        }
        public List<Cgasto> TraerGatosDesde(DateTime Fecha)
        {
            Cforma_pago objformapago;
            Ctrl_formas_pagos admfomas = Ctrl_formas_pagos.ClaseActiva();
            DataTable DT = Cdatos_operaciones.DevolverGastosOCobros("GASTOS",Fecha);
            List<Cgasto> lista = new List<Cgasto>();
            Ctrl_conceptos admconceptos = Ctrl_conceptos.ClaseActiva();
            foreach (DataRow DR in DT.Rows)
            {
                objformapago = admfomas.BuscarPorID(Convert.ToInt32(DR[3]));
                lista.Add(new Cgasto(Convert.ToInt32(DR[0]), admconceptos.BuscarPorID(Convert.ToInt32(DR[1])), Convert.ToDecimal(DR[2]), objformapago));
            }
            return lista;
        }
        public List<Ccobro> TraerCobrosDesde(DateTime Fecha)
        {
            Cforma_pago objformapago;
            Ctrl_formas_pagos admfomas = Ctrl_formas_pagos.ClaseActiva();
            DataTable DT = Cdatos_operaciones.DevolverGastosOCobros("COBROS", Fecha);
            List<Ccobro> lista = new List<Ccobro>();
            Ctrl_conceptos admconceptos = Ctrl_conceptos.ClaseActiva();
            foreach (DataRow DR in DT.Rows)
            {
                objformapago = admfomas.BuscarPorID(Convert.ToInt32(DR[3]));
                lista.Add(new Ccobro(Convert.ToInt32(DR[0]), admconceptos.BuscarPorID(Convert.ToInt32(DR[1])), Convert.ToDecimal(DR[2]), objformapago));
            }
            return lista;
        }
    }
}
