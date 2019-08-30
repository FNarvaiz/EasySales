using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_usuarios
    {
        public int ultimo;
        Ctrl_personas ctrlpersona = Ctrl_personas.ClaseActiva();
        List<Cusuario> lista = new List<Cusuario>();
        List<Cusuario> listabajas;
        private static Ctrl_usuarios Control;

        public static Ctrl_usuarios ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_usuarios();
                Control.CargarLista();
            }
            return Control;
        }
        // CARGAR DE BD
        public void CargarLista()
        {
            Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
            Ctrl_permisos admpermisos = Ctrl_permisos.ClaseActiva();
            DataTable DT = Cdatos_usuarios.Devolver(true);
            Clocalidad localidad;
            Cpermiso permiso;
            Cusuario usuario;
            foreach (DataRow DR in DT.Rows)
            {
                localidad = admlocalidades.BuscarPorID(Convert.ToInt32(DR[8]));
                permiso = admpermisos.BuscarPorID(Convert.ToInt32(DR[10]));
                usuario = new Cusuario(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[3].ToString(), DR[6].ToString(), DR[4].ToString(), DR[5].ToString(), DR[7].ToString(), localidad, permiso);
                lista.Add(usuario);
                usuario.AgregarCuentaCorriente(new Ccuenta_corriente(Convert.ToInt32(DR[11]), Convert.ToDecimal(DR[12])));
            }
            if (DT.Rows.Count == 0)
                ultimo = 0;
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);
        }
        public void CargarBajas()
        {
            listabajas = new List<Cusuario>();
            Ctrl_localidades admlocalidades = Ctrl_localidades.ClaseActiva();
            Ctrl_permisos admpermisos = Ctrl_permisos.ClaseActiva();
            DataTable DT = Cdatos_usuarios.Devolver(false);
            Clocalidad localidad;
            Cpermiso permiso; 
            Cusuario usuario;
            foreach (DataRow DR in DT.Rows)
            {
                localidad = admlocalidades.BuscarPorID(Convert.ToInt32(DR[8]));
                permiso = admpermisos.BuscarPorID(Convert.ToInt32(DR[10]));
                usuario = new Cusuario(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[3].ToString(), DR[6].ToString(), DR[4].ToString(), DR[5].ToString(), DR[7].ToString(), localidad, permiso);
                listabajas.Add(usuario);
                usuario.AgregarCuentaCorriente(new Ccuenta_corriente(Convert.ToInt32(DR[11]), Convert.ToDecimal(DR[12])));
            }
        }

        // DEVOLVER DE MEMORIA
        public List<Cusuario> VerLista()
        {
            return lista;
        }
        public List<Cusuario> VerListaBajas()
        {
            if(listabajas==null)
                CargarBajas();
            return listabajas;
        }
        public Cusuario BuscarPorID(int id)
        {
            foreach (Cusuario obj in lista)
            {
                if (obj.ID_USUARIO == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public bool TieneVentas(Cusuario obj)
        {
            return (Cdatos_usuarios.TieneVentas(obj));
        }
        public bool UnicoAdministrador(Cusuario obj)
        {
            foreach (Cusuario aux in lista)
            {
                if (aux.PERMISO().ID == 1)
                {
                    if (aux.ID_USUARIO != obj.ID_USUARIO)
                        return false;
                }
            }
            return true;
        }
        // METODOS ABM
        public void Agregar(Cusuario obj,bool cargarpersona)
        {
            try
            {
                if (cargarpersona)
                {
                    obj.ID = ctrlpersona.Agregar(obj);
                    cargarpersona = false;
                }
                obj.ID_USUARIO = ultimo + 1;
                Cdatos_usuarios.Agregar(obj);
                ultimo++;
                lista.Add(obj);
            }
            catch
            {
                ultimo++;
                Agregar(obj,cargarpersona);
            }
        }
        public void Modificar(Cusuario obj)
        {
            Cdatos_usuarios.Modificar(obj);
        }
        public void DarBajaoAlta(Cusuario obj, bool alta)
        {
            if (alta)
            {
                listabajas.Remove(obj);
                lista.Add(obj);
            }
            else
            {
                lista.Remove(obj);
                listabajas.Add(obj);
            }
            Cdatos_personas.BajaoAlta(obj, alta);
        }
        public void Eliminar(Cusuario obj)
        {
            Cdatos_usuarios.Eliminar(obj);
            ctrlpersona.Eliminar(obj);
            lista.Remove(obj);
        }
    }
}
