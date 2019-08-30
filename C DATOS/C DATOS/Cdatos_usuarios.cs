using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_usuarios
    {
        static public DataTable Devolver(bool altas)
        {
            try
            {
                String cmdtext = "SELECT P.id_usuario,P.id_persona,C.nombre,P.pass,C.telefono,C.celular,C.direccion,C.mail,L.id_localidad,L.Nombre,K.id_permiso,Y.id_cuenta_corriente,Y.saldo FROM USUARIOS P inner join PERSONAS C on C.id_persona=P.id_persona inner join LOCALIDADES L on L.id_localidad=C.id_localidad inner join PERMISOS K on K.id_permiso=P.id_permiso inner join [CUENTAS_CORRIENTES] Y on Y.id_persona= C.id_persona where Y.Alta='"+altas+"' order by id_usuario";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }              

        static public void Agregar(Cusuario obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO USUARIOS (id_usuario,id_persona,pass,id_permiso) VALUES("+obj.ID_USUARIO+"," + obj.ID + ",'"+obj.PASS+"',"+(obj.PERMISO()).ID+")";
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al cargar la persona");
            }
        }
        static public bool TieneVentas(Cusuario obj)
        {
            String cmdtext = "SELECT id_venta FROM VENTAS where id_usuario=" + obj.ID_USUARIO;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count == 0)
            {
                return false;
            }
            else
                return true;
        }
        static public void Eliminar(Cusuario obj)
        {
            string cmdtext = "DELETE FROM USUARIOS WHERE id_usuario=" + obj.ID_USUARIO;
            cDatos.ActualizarDatos(cmdtext);
            
        }
        static public void Modificar(Cusuario obj)
        {
            try
            {
                string cmdtxt = "UPDATE USUARIOS SET pass = '" + obj.PASS + "', id_permiso=" + (obj.PERMISO()).ID + " WHERE id_usuario=" + obj.ID_USUARIO;
                cDatos.ActualizarDatos(cmdtxt);
                
            }
            catch
            {
                throw new ArgumentException("Error al modificar el usuario");
            }
        }
    }
}
