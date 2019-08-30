using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;

namespace CONTROL
{
    public class Ctrl_clientes
    {
        //ATRIBUTOS
        public int ultimo;
        Ctrl_personas ctrlpersona = Ctrl_personas.ClaseActiva();
        List<Ccliente> lista = new List<Ccliente>();
        List<Ccliente> listabajas;
        public bool Actualizar = false;
        private static Ctrl_clientes Control;

        public static Ctrl_clientes ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_clientes();
                Control.CargarAltas();
            }
            return Control;
        }
        
        //METODOS ABM
        public void Agregar(Ccliente obj, bool cargarpersona)
        {
            try
            {
                if (cargarpersona)
                {
                    obj.ID = ctrlpersona.Agregar(obj);
                    cargarpersona = false;
                }
                ultimo++;
                obj.ID_CLIENTE = ultimo;
                Cdatos_clientes.Agregar(obj);
                lista.Add(obj);
                Actualizar = true;
            }
            catch
            {
                Agregar(obj, cargarpersona);
            }
        }
        public void Modificar(Ccliente obj)
        {
            ctrlpersona.Modificar(obj);
            Actualizar = true;
        }
        public void Eliminar(Ccliente obj)
        {
            Cdatos_clientes.Eliminar(obj);
            ctrlpersona.Eliminar(obj);
            lista.Remove(obj);
            Actualizar = true;
        }
        public void DarBaja(Ccliente obj)
        {
            Cdatos_personas.BajaoAlta(obj, false);
            if (listabajas != null)
                listabajas.Add(obj);
            lista.Remove(obj);
        }
        public void DarAlta(Ccliente obj)
        {
            Cdatos_personas.BajaoAlta(obj, true);
            lista.Add(obj);
            listabajas.Remove(obj);
        }
        
        //METODOS DE BUSQUEDA Y DEVOLUCION DE DATOS
        public Ccliente BuscarPorID(int id)
        {
            foreach (Ccliente obj in lista)
            {
                if (obj.ID_CLIENTE == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public List<Ccliente> BuscarPorNombre(string nombre)
        {
            List<Ccliente> Listabusqueda = new List<Ccliente>();

            foreach (Ccliente aux in lista)
            {
                if (aux.Nombre.ToLower().Contains(nombre.ToLower()))
                    Listabusqueda.Add(aux);
            }
            return Listabusqueda;
        }
        public List<Ccliente> VerClientesConCuentas()
        {
            List<Ccliente> listaconcuentas = new List<Ccliente>();
            foreach (Ccliente obj in lista)
            {
                if (obj.DevolverCuentaCorriente() != null)
                {
                    listaconcuentas.Add(obj);
                }
            }
            Actualizar = false;
            return listaconcuentas;
        }
        public List<Cpersona> VerClientesSinCuentas()
        {
            List<Cpersona> listasincuentas = new List<Cpersona>();
            foreach (Ccliente obj in lista)
            {
                if (obj.DevolverCuentaCorriente() == null)
                {
                    listasincuentas.Add(obj);
                }
            }
            return listasincuentas;
        }
        public List<Ccliente> VerLista()
        {
            return lista;
        }
        public List<Ccliente> VerBajas()
        {
            return listabajas;
        }
        
        //METODOS LLAMADA A LA BD
        public void CargarAltas()
        {
                Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
                DataTable DT = Cdatos_clientes.Devolver(true);
                Clocalidad localidad;
                Ccliente ocliente;
                foreach (DataRow DR in DT.Rows)
                {
                    localidad = admlocalidades.BuscarPorID(Convert.ToInt32(DR[7]));
                    ocliente= new Ccliente(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[5].ToString(), DR[3].ToString(), DR[4].ToString(), DR[6].ToString(), localidad);
                    lista.Add(ocliente);
                    ocliente.AgregarCuentaCorriente(new Ccuenta_corriente(Convert.ToInt32(DR[8]), Convert.ToDecimal(DR[9])));
                }
                if (DT.Rows.Count == 0)
                    ultimo = 0;
                else
                    ultimo = Convert.ToInt32(DT.Rows[0][0]);
            
        }
        public void CargarBajas()
        {
            if (listabajas == null)
            {
                listabajas = new List<Ccliente>();
                Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
                DataTable DT = Cdatos_clientes.Devolver(false);
                Clocalidad localidad;
                Ccliente ocliente;
                foreach (DataRow DR in DT.Rows)
                {
                    localidad = admlocalidades.BuscarPorID(Convert.ToInt32(DR[7]));
                    ocliente = new Ccliente(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[5].ToString(), DR[3].ToString(), DR[4].ToString(), DR[6].ToString(), localidad);
                    listabajas.Add(ocliente);
                    ocliente.AgregarCuentaCorriente(new Ccuenta_corriente(Convert.ToInt32(DR[8]), Convert.ToDecimal(DR[9])));
                }
                if (DT.Rows.Count == 0)
                    ultimo = 0;
                else
                    ultimo = Convert.ToInt32(DT.Rows[0][0]);
            }
        }
    }
}
