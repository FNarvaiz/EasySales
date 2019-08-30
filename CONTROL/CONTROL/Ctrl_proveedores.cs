using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;

namespace CONTROL
{
    public class Ctrl_proveedores
    {
        public int ultimo;
        Ctrl_personas ctrlpersona = Ctrl_personas.ClaseActiva();
        List<Cproveedor> lista = new List<Cproveedor>();
        List<Cproveedor> listabajas;
        private static Ctrl_proveedores Control;

        public static Ctrl_proveedores ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_proveedores();
                Control.CargarLista();
            }
            return Control;
        }
        // LLAMADAS A LA BD
        public void CargarLista()
    {
            Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
            DataTable DT = Cdatos_proveedores.Devolver(true);
            Clocalidad localidad;
            Cproveedor oproveedor;
            foreach (DataRow DR in DT.Rows)
            {
                localidad = admlocalidades.BuscarPorID(Convert.ToInt32(DR[8]));
                oproveedor = new Cproveedor(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[5].ToString(), DR[3].ToString(), DR[4].ToString(), DR[6].ToString(), DR[7].ToString(), localidad);
                oproveedor.AgregarCuentaCorriente(new Ccuenta_corriente(Convert.ToInt32(DR[9]), Convert.ToDecimal(DR[10])));
                lista.Add(oproveedor);
                
            }
            if (DT.Rows.Count == 0)
                ultimo = 0;
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);
        }
        public void CargarBajas()
        {
            if (listabajas== null)
            {
                listabajas = new List<Cproveedor>();
                Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
                DataTable DT = Cdatos_proveedores.Devolver(false);
                Clocalidad localidad;
                Cproveedor oproveedor;
                foreach (DataRow DR in DT.Rows)
                {
                    localidad = admlocalidades.BuscarPorID(Convert.ToInt32(DR[8]));
                    oproveedor = new Cproveedor(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[5].ToString(), DR[3].ToString(), DR[4].ToString(), DR[6].ToString(), DR[7].ToString(), localidad);
                    oproveedor.AgregarCuentaCorriente(new Ccuenta_corriente(Convert.ToInt32(DR[8]), Convert.ToDecimal(DR[9])));
                    listabajas.Add(oproveedor);
                }
                if (DT.Rows.Count == 0)
                    ultimo = 0;
                else
                    ultimo = Convert.ToInt32(DT.Rows[0][0]);
            }
        }
        // METODOS ABM
        public void DarBaja(Cproveedor obj)
        {
            Cdatos_personas.BajaoAlta(obj, false);
            if(listabajas!=null)
                listabajas.Add(obj);
            lista.Remove(obj);
        }
        public void DarAlta(Cproveedor obj)
        {
            Cdatos_personas.BajaoAlta(obj, true);
            lista.Add(obj);
            listabajas.Remove(obj);
        }
        public void Agregar(Cproveedor obj, bool cargarpersona)
        {
            try
            {
                if (cargarpersona)
                {
                    obj.ID = ctrlpersona.Agregar(obj);
                    cargarpersona = false;
                }
                ultimo++;
                obj.ID_PRO = ultimo;
                Cdatos_proveedores.Agregar(obj);
                lista.Add(obj);
            }
            catch
            {
                Agregar(obj, cargarpersona);
            }
        }
        public void Modificar(Cproveedor obj)
        {
            ctrlpersona.Modificar(obj);
        }
        public void Eliminar(Cproveedor obj)
        {
            Ctrl_cuentas_corrientes ctrlCuenta = Ctrl_cuentas_corrientes.ClaseActiva();
            ctrlCuenta.Eliminar(obj.DevolverCuentaCorriente());
            Cdatos_proveedores.Eliminar(obj);
            ctrlpersona.Eliminar(obj);
            lista.Remove(obj);
        }
        // METODOS DATOS EN MEMORIA
        public List<Cproveedor> VerBajas()
        {
            CargarBajas();
            return listabajas;
        }
        public List<Cproveedor> VerLista()
        {
            return lista;
        }
        public List<Cproveedor> BuscarPorNombre(string Nombre)
        {
            List<Cproveedor> listaBusqueda = new List<Cproveedor>();
            foreach (Cproveedor aux in lista)
            {
                if (aux.Nombre.ToLower().Contains(Nombre.ToLower()))
                {
                    listaBusqueda.Add(aux);
                }
            }
            return listaBusqueda;
        }
        public Cproveedor BuscarPorID(int id)
        {
            foreach (Cproveedor obj in lista)
            {
                if (obj.ID_PRO == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public Cproveedor BuscarPorIDenBajas(int id)
        {
            foreach (Cproveedor obj in listabajas)
            {
                if (obj.ID_PRO == id)
                {
                    return obj;
                }
            }
            return null;
        }
    }
}
