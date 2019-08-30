using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CLASES;
namespace C_DATOS
{
    public class  Cdatos_formas_pagos
    {
        static public bool Actualizar = true;

        static public DataTable Devolver()
        {
            try
            {
                String cmdtext = "SELECT id_forma_pago,descripcion,porcentaje,descuento,recargo,altera_caja,Con_Codigo FROM [FORMAS_PAGOS] order by id_forma_pago desc";
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                return DT;
            }
            catch
            {
                throw new ArgumentException("Error al devolver los datos");
            }
        }
        static public Cforma_pago Devolver(int id)
        {
            try
            {
                String cmdtext = "SELECT id_forma_pago,descripcion,porcentaje,descuento,recargo,altera_caja,Con_Codigo FROM [FORMAS_PAGOS] where id_forma_pago=" + id;
                DataTable DT = cDatos.DevolverDatos(cmdtext);
                if (DT.Rows.Count == 0)
                    return null;
                else
                    return new Cforma_pago(id, DT.Rows[0][1].ToString(), Convert.ToBoolean(DT.Rows[0][2]), Convert.ToBoolean(DT.Rows[0][3]), Convert.ToBoolean(DT.Rows[0][4]), Convert.ToDecimal(DT.Rows[0][5]), Convert.ToBoolean(DT.Rows[0][6]));
            }
            catch
            {
                throw new ArgumentException("Error al devolver Forma de pago");
            }

        }
        static public void Agregar(Cforma_pago obj)
        {
            try
            {
                string cmdtxt = "INSERT INTO [FORMAS_PAGOS] (id_forma_pago,descripcion,porcentaje,descuento,recargo,altera_caja,Con_Codigo) VALUES(" + obj.ID + ",'" + obj.Descripcion + "'," + obj.Porcentaje.ToString().Replace(",", ".") + "," + Convert.ToByte(obj.Descuento) + "," + Convert.ToByte(obj.Recargo) + "," + Convert.ToByte(obj.Altera_caja) + ",'"+obj.Autorizacion+"')";
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al cargar la forma de pago");
            }
        }
        static public bool EnUso(Cforma_pago obj)
        {
            string cmdtext = "SELECT id_forma_pago FROM [ventas-pagos] WHERE id_forma_pago=" + obj.ID;
            DataTable DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count != 0)
                return true;
            cmdtext = "SELECT id_forma_pago FROM COMPRAS  WHERE id_forma_pago=" + obj.ID;
            DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count != 0)
                return true;
            cmdtext = "SELECT id_forma_pago FROM COBROS  WHERE id_forma_pago=" + obj.ID;
            DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count != 0)
                return true;
            cmdtext = "SELECT id_forma_pago FROM GASTOS  WHERE id_forma_pago=" + obj.ID;
            DT = cDatos.DevolverDatos(cmdtext);
            if (DT.Rows.Count != 0)
                return true;
            return false;
        }        
        static public void Eliminar(Cforma_pago obj)
        {
            string cmdtext = "DELETE FROM [FORMAS_PAGOS] WHERE id_forma_pago=" + obj.ID;
            cDatos.ActualizarDatos(cmdtext);
            Actualizar = true;
        }
        static public void CambiarReferencias1a2(Cforma_pago obj1, Cforma_pago obj2)
        {
            string cmdtxt = "UPDATE GASTOS SET id_forma_pago=" + obj2.ID + " WHERE id_forma_pago=" + obj1.ID;
            cDatos.ActualizarDatos(cmdtxt);
            cmdtxt = "UPDATE COBROS SET id_forma_pago=" + obj2.ID + " WHERE id_forma_pago=" + obj1.ID;
            cDatos.ActualizarDatos(cmdtxt);
            cmdtxt = "UPDATE COMPRAS SET id_forma_pago=" + obj2.ID + " WHERE id_forma_pago=" + obj1.ID;
            cDatos.ActualizarDatos(cmdtxt);
            cmdtxt = "UPDATE VENTAS SET id_forma_pago=" + obj2.ID + " WHERE id_forma_pago=" + obj1.ID;
            cDatos.ActualizarDatos(cmdtxt);
        }
        static public void Modificar(Cforma_pago obj)
        {
            try
            {
                string cmdtxt = "UPDATE [FORMAS_PAGOS] SET descripcion = '" + obj.Descripcion + "',porcentaje=" + obj.Porcentaje.ToString().Replace(",",".") + " ,descuento=" + Convert.ToByte(obj.Descuento) + ",recargo=" + Convert.ToByte(obj.Recargo) + ",altera_caja=" + Convert.ToByte(obj.Altera_caja) + ",Con_codigo='"+obj.Autorizacion+"' WHERE id_forma_pago=" + obj.ID;
                cDatos.ActualizarDatos(cmdtxt);
                Actualizar = true;
            }
            catch
            {
                throw new ArgumentException("Error al modificar la forma de pago");
            }
        }  
    }
}
