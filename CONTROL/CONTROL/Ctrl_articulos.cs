using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C_DATOS;
using CLASES;
using System.Data;
namespace CONTROL
{
    public class Ctrl_articulos
    {
        List<Carticulo> listavigentes;
        List<Carticulo> listanovigentes;
        string _ultimaDescripcion=" ";
        string _ultimoCodigo = " ";
        List<Carticulo> _resultados= new List<Carticulo>();
        List<Carticulo> _nuevosResultados = new List<Carticulo>();
        static Ctrl_articulos Control;

        public static Ctrl_articulos ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_articulos();
                Control.CargarVigentes();
                Control.CargarNoVigentes();
            }
            
            return Control;
        }
        public void CargarVigentes()
        {
            listavigentes = new List<Carticulo>();
            Ctrl_rubros admrubro = Ctrl_rubros.ClaseActiva();
            Ctrl_medidas admmedida = Ctrl_medidas.ClaseActiva();
            DataTable DT = Cdatos_articulos.Devolver(true);
            foreach (DataRow DR in DT.Rows)
            {
                listavigentes.Add(new Carticulo(DR[0].ToString(), DR[1].ToString(), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[4]), admrubro.BuscarPorID(Convert.ToInt32(DR[5])), admmedida.BuscarPorID(Convert.ToInt32(DR[6])), Convert.ToDecimal(DR[7]), DR[8].ToString(), Convert.ToDecimal(DR[9]), Convert.ToDecimal(DR[10]), Convert.ToDecimal(DR[11])));
            }
        }
        public void CargarNoVigentes()
        {
            if (listanovigentes == null)
            {
                listanovigentes = new List<Carticulo>();
                DataTable DT = Cdatos_articulos.Devolver(false);
                Ctrl_rubros admrubro = Ctrl_rubros.ClaseActiva();
                Ctrl_medidas admmedida = Ctrl_medidas.ClaseActiva();
                foreach (DataRow DR in DT.Rows)
                {

                    listanovigentes.Add(new Carticulo(DR[0].ToString(), DR[1].ToString(), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[4]), admrubro.BuscarPorID(Convert.ToInt32(DR[5])), admmedida.BuscarPorID(Convert.ToInt32(DR[6])), Convert.ToDecimal(DR[7]), DR[8].ToString(), Convert.ToDecimal(DR[9]), Convert.ToDecimal(DR[10]), Convert.ToDecimal(DR[11])));
                }
            }
        }
        public List<Carticulo> DevolverListaVigentes()
        {    
            return listavigentes;
        }
        
        public DataTable DevolverVigentesBD()
        {
            return Cdatos_articulos.DevolverVigentesOrderByStock();
        }
        public List<Carticulo> DevolverListaVigentes(Crubro oRubro)
        {
            List<Carticulo> L = new List<Carticulo>();
            foreach (Carticulo aux in listavigentes)
            {
                if (aux.Rubro == oRubro)
                    L.Add(aux);
            }
            return L;
        }

        public DataTable DevolverVigentesBD(string descrip)
        {
            return Cdatos_articulos.DevolverVigentesOrderByStock(descrip);
        }
        public List<Carticulo> BuscarEnListaVigentesPorDescripcion(string buscado)
        {
            if (buscado != "")
            {
                _nuevosResultados = new List<Carticulo>();
                if (buscado.Contains(_ultimaDescripcion))
                {
                    
                    if (_resultados.Count > 0)
                    {
                        foreach (Carticulo aux in _resultados)
                            if (aux.Descripcion.ToLower().Contains(buscado.ToLower()))
                                _nuevosResultados.Add(aux);
                    }
                    
                }
                 else
                {
                    foreach (Carticulo aux in listavigentes)
                        if (aux.Descripcion.ToLower().Contains(buscado.ToLower()) )
                            _nuevosResultados.Add(aux);
                }
                _resultados = _nuevosResultados;
            }
            else
                _resultados = listavigentes;
            _ultimaDescripcion = buscado;
            return _resultados;
        }
        public List<Carticulo> BuscarEnListaVigentesPorCodigo(string buscado)
        {
            if (buscado != "")
            {
                _nuevosResultados = new List<Carticulo>();
                if (buscado.Contains(_ultimoCodigo))
                {
                    if (_resultados.Count > 0)
                        foreach (Carticulo aux in _resultados)
                            if (aux.Codigo.Contains(buscado))
                                _nuevosResultados.Add(aux);
                }
                else
                {
                    foreach (Carticulo aux in listavigentes)
                        if (aux.Codigo.Contains(buscado))
                            _nuevosResultados.Add(aux);
                }
                _resultados = _nuevosResultados;
            }
            else
                _resultados = listavigentes;
            _ultimoCodigo = buscado;
            return _resultados;
        }

        public List<Carticulo> DevolverListaNoVigentes()
        {
            if (listanovigentes.Count==0)
            {
                
            }
            return listanovigentes;
        }
        public void ModificarPreciosMultiples(List<Carticulo> lista, decimal precioNuevo)
        {
            if (lista.Count == 0)
                throw new Exception("Seleccione uno o varios artículos para modificar el precio de todos a la vez");
            if(precioNuevo<0)
                throw new Exception("El nuevo precio no puede ser menor a 0");
            Cdatos_articulos.ModificarPrecios(lista, precioNuevo);
        }

        public void Agregar(Carticulo obj)
        {
            try
            {
                if(ExisteCodigo(obj.Codigo))
                {
                    throw new Exception("El código ingresado ya existe en un artículo");
                }               
                Cdatos_articulos.Agregar(obj);
                listavigentes.Add(obj);
                    
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public bool ExisteCodigo(string codigo)
        {
            foreach (Carticulo obj in listavigentes)
                if (obj.Codigo == codigo)
                    return true;
            foreach (Carticulo obj in listanovigentes)
                if (obj.Codigo == codigo)
                    return true;
            return false;
        }
        public Carticulo BuscarEnVigentes(string codigo)
        {
           
            foreach (Carticulo obj in listavigentes)
                if (obj.Codigo == codigo)
                    return obj;
            foreach( Carticulo obj in listanovigentes)
                if (obj.Codigo == codigo)
                    return obj;
            return null;
        }

        public Carticulo BuscarEnNoVigentes(string codigo){
            foreach (Carticulo obj in listanovigentes)
                {
                    if (obj.Codigo == codigo)
                    {
                        return obj;
                    }
                }
            return null;
        }

        public void Modificar(Carticulo obj,bool vigente)
        {
            if (vigente)
            {
                listanovigentes.Remove(obj);
                listavigentes.Add(obj);
            }
            else
            {
                listavigentes.Remove(obj);
                if (listanovigentes != null)
                    listanovigentes.Add(obj);
            }
            Cdatos_articulos.Modificar(obj,vigente);
        }
        public void Modificar(Carticulo obj)
        {
            Carticulo art = BuscarEnVigentes(obj.Codigo);
            if (art == null)
            {
                art = BuscarEnNoVigentes(obj.Codigo);
                listanovigentes.Remove(art);
                listavigentes.Add(art);
                art.Costo = obj.Costo;
                art.Precio = obj.Precio;
                art.Stock = obj.Stock;
                Cdatos_articulos.Modificar(obj, true);
            }
            else
            {
                art.Costo = obj.Costo;
                art.Precio = obj.Precio;
                art.Stock = obj.Stock;
                Cdatos_articulos.Modificar(obj);
            }
        }
        public void Modificar(Carticulo obj, Carticulo objNuevo)
        {
            if (obj.Codigo == objNuevo.Codigo)
            {
                Cdatos_articulos.Modificar(objNuevo);
            }
            else
            {
                if (ExisteCodigo( objNuevo.Codigo))
                {
                    throw new Exception("El código ingresado ya existe en otro artículo cargado");
                }               
                Cdatos_articulos.Modificar(obj,objNuevo);
            }
            modifcarObjetoEnMemoria(obj, objNuevo);
        }

        public void modifcarObjetoEnMemoria(Carticulo obj, Carticulo objNuevo)
        {
            obj.CantBaja = objNuevo.CantBaja;
            obj.CantMedia = objNuevo.CantMedia;
            obj.CantAlta = objNuevo.CantAlta;
            obj.Codigo = objNuevo.Codigo;
            obj.Costo = objNuevo.Costo;
            obj.Descripcion = objNuevo.Descripcion;
            obj.Iva = objNuevo.Iva;
            obj.Nota = objNuevo.Nota;
            obj.Precio = objNuevo.Precio;
            obj.Rubro = objNuevo.Rubro;
            obj.Stock = objNuevo.Stock;
            obj.Unidad_Medida = objNuevo.Unidad_Medida;
        }
        public bool TieneReferencias(Carticulo obj)
        {
            return Cdatos_articulos.TieneReferencias(obj);
        }

        public void Eliminar(Carticulo obj,bool tieneReferencia,bool vigente)
        {
            if (tieneReferencia)
            {
                Cdatos_articulos.EliminarReferencias(obj);
            }
            Cdatos_articulos.Eliminar(obj);
            if (vigente)
            {                
                listavigentes.Remove(obj);
            }
            else
            {
                listanovigentes.Remove(obj);
            }
        }

        public int VerificarStock()
        {
            try
            {
                Ctrl_compras admCompras = Ctrl_compras.ClaseActiva();
                Ctrl_Ventas admVentas = Ctrl_Ventas.ClaseActiva();
                decimal cantComprada;
                decimal cantVendida;
                decimal cantActual;
                int CantCorregida = 0;
                foreach (Carticulo oArt in listavigentes)
                {
                    cantComprada = admCompras.CantidadHistorica(oArt);
                    cantVendida = admVentas.CantidadDeArtHistorico(oArt);
                    cantActual = cantComprada - cantVendida;
                    if (oArt.Stock != cantActual)
                    {
                        oArt.Stock = cantActual;
                        ModificarStock(oArt);
                        CantCorregida++;
                    }
                }
                foreach (Carticulo oArt in listanovigentes)
                {
                    cantComprada = admCompras.CantidadHistorica(oArt);
                    cantVendida = admVentas.CantidadDeArtHistorico(oArt);
                    cantActual = cantComprada - cantVendida;
                    if (oArt.Stock != cantActual)
                    {
                        oArt.Stock = cantActual;
                        ModificarStock(oArt);
                        CantCorregida++;
                    }
                }
                return CantCorregida;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        public cActivoMercaderia TraerMercaderia()
        {
            cActivoMercaderia obj = new cActivoMercaderia();
            foreach (Carticulo aux in DevolverListaVigentes())
            {
                obj.Agregar(new cMercaderia(aux));
            }
            return obj;
        }
        public void ModificarStock(Carticulo oArt)
        {
            Cdatos_articulos.ModificarStock(oArt);
        }

    }
}
