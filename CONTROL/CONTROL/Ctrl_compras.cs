using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using C_DATOS;
using CLASES;

namespace CONTROL
{
    public class Ctrl_compras
    {
        public int ultimo;

        List<Ccompra> lista = new List<Ccompra>();
        static Ctrl_compras Control;

        public static Ctrl_compras ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_compras();
            }

            return Control;
        }
        public DataTable VerTodas()
        {
            DataTable DT = Cdatos_compras.Devolver();
            if (DT.Rows.Count == 0)
                ultimo = 0;
            else
                ultimo = Convert.ToInt32(DT.Rows[0][0]);
            return DT;
        }
        private void CargarALista(DataTable DT)
        {
            Ctrl_formas_pagos CtrlFormaPago = Ctrl_formas_pagos.ClaseActiva();
            Ctrl_proveedores CtrlProveedor = Ctrl_proveedores.ClaseActiva();
            Ccompra ocompra;
            foreach (DataRow DR in DT.Rows)
            {
                ocompra = new Ccompra(Convert.ToInt32(DR[0]), Convert.ToDecimal(DR[4]), Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[3]), Convert.ToDateTime(DR[1]), CtrlFormaPago.BuscarPorID(Convert.ToInt32(DR[5])));
                lista.Add(ocompra);
                if (DR[6].ToString() != "")
                    ocompra.Proveedor = CtrlProveedor.BuscarPorID(Convert.ToInt32(DR[6]));
            }
        }
        public List<Ccompra> VerLista()
        {
            if (lista.Count == 0)
            {
                DataTable DT = Cdatos_compras.Devolver();
                CargarALista(DT);
                if (DT.Rows.Count == 0)
                    ultimo = 0;
                else
                    ultimo = Convert.ToInt32(DT.Rows[0][0]);
            }
            return lista;
        }
        public bool CargarMas()
        {
            DataTable DT = Cdatos_compras.Devolver(lista[lista.Count-1].Id);
            CargarALista(DT);
            if (DT.Rows.Count == 0)
                return true;
            return false;
        }
        public void Agregar(Ccompra obj)
        {
            try
            {
                ultimo++;
                obj.Id = ultimo;
                Cdatos_compras.Agregar(obj);
                
                lista.Add(obj);
            }
            catch{
                ultimo++;
                Agregar(obj);
            }
        }
        public void GuardarItems(Ccompra obj)
        {
            Ctrl_articulos admArt = Ctrl_articulos.ClaseActiva();
            int cont = 0;
            foreach (Citem aux in obj.Lista())
            {
                Cdatos_compras.GuardarItem(aux,obj);
                aux.Articulo.Stock+=aux.Cantidad;
                aux.Articulo.Costo = aux.Precio_Uni;
                admArt.Modificar(aux.Articulo);
                cont++;
                if(cont==3 || cont==6 || cont==9 )
                    System.Threading.Thread.Sleep(2000);
            }
        }
        public decimal CantidadHistorica(Carticulo oart)
        {
            return Cdatos_compras.CantidadComprada(oart);
        }
        public Ccompra BuscarPorID(int id)
        {
            foreach (Ccompra obj in lista)
            {
                if (obj.Id == id)
                {
                    return obj;
                }
            }
            return null;
        }
        public void CargarItems(Ccompra obj)
        {
            DataTable DT = Cdatos_compras.VerItems(obj);
            Ctrl_articulos adm = Ctrl_articulos.ClaseActiva();
            Carticulo oart;
             List<Citem> list = new List<Citem>();
            foreach (DataRow DR in DT.Rows)
            {
                oart = adm.BuscarEnVigentes(DR[0].ToString());
                if (oart == null)
                    oart = adm.BuscarEnNoVigentes(DR[0].ToString());
                list.Add(new Citem(oart, Convert.ToDecimal(DR[1]), Convert.ToDecimal(DR[2])));
            }

            obj.L_items = list;
        }
        public void ModificarItems(Ccompra objViejo, Ccompra objNuevo)
        {
            EliminarItems(objViejo);
            foreach (Citem oItemViejo in objViejo.Lista())
            {
                EquilibrarArticuloDeUnaEliminacion(oItemViejo);
            }
            GuardarItems(objNuevo);
            /*List<Citem> ItemsParaEliminar = new List<Citem>();
            List<Citem> ItemsQNoCambiaron = new List<Citem>();
            foreach (Citem oItemViejo in objViejo.Lista())
            {
                if (objNuevo.Lista().Contains(oItemViejo))
                {
                    ItemsQNoCambiaron.Add(oItemViejo);
                    objNuevo.Lista().Remove(oItemViejo);
                }
                else
                {
                    EliminarItem(objNuevo, oItemViejo);
                    EquilibrarArticuloDeUnaEliminacion(oItemViejo);
                }
            }
            GuardarItems(objNuevo);
            foreach (Citem oitem in ItemsQNoCambiaron)
            {
                objNuevo.Lista().Add(oitem);
            }
            lista.Remove(objViejo);
            lista.Add(objNuevo);*/
        }
        public void Modificar(Ccompra obj)
        {
            Cdatos_compras.Modificar(obj);                      
        }
        public void ReferenciarConProveedor(Ccompra oCompra, Cproveedor oPro)
        {
            Cdatos_compras.AgregarReferenciaAProveedor(oCompra, oPro);
            oCompra.Proveedor=oPro;
        }
        public void EliminarItem(Ccompra oCompra, Citem oItem)
        {
            Cdatos_compras.EliminarItem(oCompra, oItem);
        }
        public void EliminarItems(Ccompra oCompra)
        {
            Cdatos_compras.EliminarItems(oCompra);
        }
        public void Eliminar(Ccompra obj)
        {
            Cdatos_compras.Eliminar(obj);
            lista.Remove(obj);
        }
        public void EliminarReferenciaProveedor(Ccompra oCompra)
        {
            Cdatos_compras.EliminarReferenciaAProveedor(oCompra);
        }
        public void EquilibrarArticuloDeUnaEliminacion(Citem obj)
        {
            Carticulo art = obj.Articulo;
            decimal canthist = Convert.ToDecimal(Cdatos_compras.CantidadComprada(art));
            decimal Cal = art.Costo * canthist;
            Cal = Cal - obj.Total;
            decimal cantActual = canthist - obj.Cantidad;
            if(cantActual!=0)
                Cal = Cal / cantActual;
            art.Costo = Cal;
            Cdatos_articulos.ModificarStockYCosto(obj.Articulo, (-1 * obj.Cantidad));
            art.Stock -= obj.Cantidad;
        }
        public int VerificarTodas()
        {
            int contador = 0;
            foreach (Ccompra oCompra in VerLista())
            {
                if (!Correcta(oCompra))
                {
                    if(!Corregir(oCompra))
                        return -1;
                    contador++;
                }
            }
            return contador;
        }
        public bool Correcta(Ccompra oCompra){
            if (oCompra.Lista().Count == 0)
            {
                CargarItems(oCompra);
            }
            decimal subtotal = 0;
            foreach (Citem aux in oCompra.Lista())
            {
                subtotal += aux.Cantidad * aux.Precio_Uni;
            }
            if (subtotal > oCompra.Subtotal - 3 && subtotal < oCompra.Subtotal + 3)
            {
                if (subtotal - oCompra.Descuento == oCompra.Total)
                    return true;
                else
                    return false;
            }
            return false;
        }
        public bool Corregir(Ccompra oCompra)
        {
            try
            {
               decimal subtotal=0;
                foreach (Citem aux in oCompra.Lista())
                {
                    subtotal += aux.Cantidad * aux.Precio_Uni;
                }    
                oCompra.Subtotal=subtotal;
                oCompra.Total=subtotal-oCompra.Descuento;
                Cdatos_compras.Modificar(oCompra);
            }
            catch(Exception){
                return false;
            }
            return true;
        }
        
    }
}

