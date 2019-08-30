using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using System.Data;
namespace C_DATOS
{
    public class Cdatos_permisos
    {
        static public bool Actualizar = true;
        static public bool ReferenciasExistentes(Cpermiso obj)
        {
            String cmdtext = "SELECT P.id_permiso FROM USUARIOS P  where P.id_permiso=" + obj.ID;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_permiso,Descripcion,usuariosPermisos,proovedores,cobrosPagos,formaPago,estadTableroControl,clientes,compras,articulos,config,ctasCtes FROM PERMISOS";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }

        }

        static public DataTable Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT id_permiso,Descripcion FROM PERMISOS where id_permiso=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver permiso");
            }

        }

        static public void Agregar(Cpermiso oPermiso)
        {
            try
            {
                string cmdtxt = "INSERT INTO PERMISOS (id_permiso,Descripcion,usuariosPermisos,proovedores,cobrosPagos,formaPago,estadTableroControl,clientes,compras,articulos,config,ctasCtes) VALUES (" + oPermiso.ID + ",'" + oPermiso.Descripcion + "','" + oPermiso.USUARIOS_Y_PERMISOS + "','" + oPermiso.PROVEEDORES + "','" + oPermiso.COBROS_y_PAGOS + "','" + oPermiso.FORMAS_DE_PAGO + "','" + oPermiso.ESTADISTICAS_Y_TABLERO_CONTROL + "','" + oPermiso.CLIENTES + "','" + oPermiso.COMPRAS + "','" + oPermiso.ARTICULOS + "','" + oPermiso.CONFIGURACIONES + "','" + oPermiso.CTAS_CTES + "')";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar el permiso");
            }
        }

        static public void Eliminar(Cpermiso oPermiso)
        {
            string cmdtext = "DELETE FROM PERMISOS WHERE id_permiso=" + oPermiso.ID;
            cDatos.ActualizarDatos(cmdtext);
            Actualizar = true;
        }

        static public void Modificar(Cpermiso oPermiso)
        {
            try
            {
                string cmdtxt = "UPDATE PERMISOS SET Descripcion = '" + oPermiso.Descripcion + "', usuariosPermisos ='" + oPermiso.USUARIOS_Y_PERMISOS + "',proovedores ='" + oPermiso.PROVEEDORES + "',cobrosPagos ='" + oPermiso.COBROS_y_PAGOS + "',formaPago ='" + oPermiso.FORMAS_DE_PAGO + "',estadTableroControl ='" + oPermiso.ESTADISTICAS_Y_TABLERO_CONTROL + "',clientes ='" + oPermiso.CLIENTES + "',compras ='" + oPermiso.COMPRAS + "',articulos ='" + oPermiso.ARTICULOS + "',config ='" + oPermiso.CONFIGURACIONES + "',ctasCtes ='" + oPermiso.CTAS_CTES + "' FROM PERMISOS WHERE id_permiso =" + oPermiso.ID;        
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar permiso");
            }

        }  
    }
}
