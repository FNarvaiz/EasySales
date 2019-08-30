using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_proveedores
    {
        static public DataTable Devolver(bool altas)
        {
            try
            {
                String cmdtext = "SELECT id_proveedor,P.id_persona,C.nombre,telefono,celular,direccion,mail,cuit,L.id_localidad,Y.id_cuenta_corriente,Y.saldo FROM PROVEEDORES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad= C.id_localidad inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.alta='" + altas + "'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public Cproveedor Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT P.id_persona,nombre,direccion,telefono,celular,mail,cuit FROM PROVEEDORES P inner join PERSONAS C on C.id_persona=P.id_persona where id_proveedor=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if (DT.Rows.Count == 0)
                    return null;
                else
                {
                    DataRow DR = DT.Rows[0];
                    Clocalidad localidad = new Clocalidad(Convert.ToInt32(DR[8]), DR[9].ToString());
                    Cproveedor obj=  new Cproveedor(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[5].ToString(), DR[3].ToString(), DR[4].ToString(), DR[6].ToString(), DR[7].ToString(), localidad);
                    return obj;
                }
            }
            catch
            {
                throw new ArgumentException("Error al devolver proveedor");
            }

        }
        static public void Agregar(Cproveedor obj)
        {      
            try
            {
                string cmdtxt = "INSERT INTO PROVEEDORES (id_proveedor,id_persona,cuit) VALUES("+obj.ID_PRO+","+obj.ID +",'"+obj.CUIT+ "')";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new Exception("Error al cargar la persona");
            }
        }
        static public void Eliminar(Cproveedor obj)
        {
            string cmdtext = "DELETE FROM PROVEEDORES WHERE id_proveedor=" + obj.ID_PRO;
            cDatos.ActualizarDatos(cmdtext);
            
        }
        static public void Modificar(Cproveedor obj)
        {
            try
            {
                string cmdtxt = "UPDATE PROVEEDORES SET CUIT = '" + obj.CUIT + "' WHERE id_proveedor=" + obj.ID_PRO;
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al modificar el proveedor");
            }
        }
    }
}
