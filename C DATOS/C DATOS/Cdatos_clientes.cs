using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_clientes
    {
        static public DataTable Devolver(bool Alta)
        {
            try
            {
                String cmdtext = "SELECT id_cliente,P.id_persona,C.nombre,telefono,celular,direccion,mail,L.id_localidad,Y.id_cuenta_corriente,Y.Saldo FROM CLIENTES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad= C.id_localidad left join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.Alta='"+Alta+"'";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }

        static public Ccliente Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT id_cliente,P.id_persona,C.nombre,telefono,celular,direccion,mail,L.id_localidad,L.nombre FROM CLIENTES P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad= C.id_localidad where id_cliente=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if (DT.Rows.Count == 0)
                    return null;
                else
                {
                    DataRow DR = DT.Rows[0];
                    Clocalidad localidad = new Clocalidad(Convert.ToInt32(DR[7]), DR[8].ToString());
                    Ccliente obj= new Ccliente(Convert.ToInt32(DR[0]), Convert.ToInt32(DR[1]), DR[2].ToString(), DR[6].ToString(), DR[3].ToString(), DR[4].ToString(), DR[5].ToString(), localidad);
                    return obj;
                }
            }
            catch
            {
                throw new ArgumentException("Error al devolver cliente");
            }

        }

        static public void Agregar(Ccliente obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO CLIENTES (id_cliente,id_persona) VALUES("+obj.ID_CLIENTE+"," + obj.ID + ")";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al cargar la persona");
            }
        }


        static public void Eliminar(Ccliente obj)
        {
            string cmdtext = "DELETE FROM CLIENTES WHERE id_cliente=" + obj.ID_CLIENTE;
            cDatos.ActualizarDatos(cmdtext);
            
        }  
    }
}
