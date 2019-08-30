using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
using C_DATOS;

namespace CONTROL
{
    public class Ctrl_cuentas_bancarias
    {
        private static Ctrl_cuentas_bancarias adm;

        List<Ccuenta_bancaria> lista = new List<Ccuenta_bancaria>();

        public static Ctrl_cuentas_bancarias ClaseActiva()
        {
            if (adm == null)
            {
                adm = new Ctrl_cuentas_bancarias();
                //adm.CargarEnMemoria();
            }
            return adm;
        }
        public void Eliminar(string cbu) 
        {
            Cdatos_cuentas_bancarias.Eliminar(cbu);
        }
        public List<Cpersona> DevolverPersonas()
        {
            List<Cpersona> lista = new List<Cpersona>();
            Ctrl_usuarios admusu = Ctrl_usuarios.ClaseActiva();
            foreach (Cpersona aux in admusu.VerLista())
            {
                lista.Add(aux);
            }
            Ctrl_clientes admclientes = Ctrl_clientes.ClaseActiva();
            foreach (Cpersona aux in admclientes.VerLista())
            {
                lista.Add(aux);
            }
            Ctrl_proveedores admproveedores = Ctrl_proveedores.ClaseActiva();
            foreach (Cpersona aux in admproveedores.VerLista())
            {
                lista.Add(aux);
            }
            return lista;
        }
        public DataTable DevolverCuentasBancarias(Cpersona opersona) 
        {
            return Cdatos_cuentas_bancarias.DevolverCuentasBancarias(opersona);
        }
        /*public Ccuenta_bancaria DevolverCuentaBancaria(string cbu)
        {
            DataTable DT = Cdatos_cuentas_bancarias.DevolverCuentaBancaria(cbu);
            Ccuenta_bancaria oCuenta = new Ccuenta_bancaria(DT.Rows[0][0].
            
            return oCuenta;
        }*/
        public void CargarEnMemoria()
        {
            lista = new List<Ccuenta_bancaria>();
            Ctrl_bancos admBancos = Ctrl_bancos.ClaseActiva();
            Ctrl_personas admPersonas = Ctrl_personas.ClaseActiva();
            DataTable DT = Cdatos_cuentas_bancarias.DevolverCuentasBancarias();
            foreach (DataRow DR in DT.Rows)
            {
                //oPersona=admPersona
                //lista.Add(new Ccuenta_bancaria(DR[0].ToString(),adm, DR[2].ToString(), DR[3].ToString(), DR[4].ToString(),Convert.ToInt32(DR[5])));
                //cbu,id_persona,titular,tipo_cuenta,nro_cuenta,id_banco
               //DR[0].ToString(), DR[1].ToString(), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[4]), admrubro.BuscarPorID(Convert.ToInt32(DR[5])), admmedida.BuscarPorID(Convert.ToInt32(DR[6])), Convert.ToDecimal(DR[7]), DR[8].ToString(), Convert.ToDecimal(DR[9]), Convert.ToDecimal(DR[10]), Convert.ToDecimal(DR[11])));
            }
        }
        public void Agregar(Ccuenta_bancaria obj)
        {
            Cdatos_cuentas_bancarias.Agregar(obj);
        }
    }
}
