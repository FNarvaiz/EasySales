using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class  cActivoMercaderia
    {
        List<cMercaderia> _lista;
        decimal _totActivoAlCosto;
        decimal _totUtilidad;
        decimal _totActivoAlPrecio;
        string _ultimoOrden="";
        bool _ascendente=true;
        public List<cMercaderia> Lista
        {
            get
            {
                return _lista;
            }
        }
        public decimal TotalAlCosto
        {
            get
            {
                return _totActivoAlCosto;
            }
        }
        public decimal TotalUltilidad
        {
            get
            {
                return _totUtilidad;
            }
        }
        public decimal TotalAlPrecio
        {
            get
            {
                return _totActivoAlPrecio;
            }
        }
        public cActivoMercaderia()
        {
            _lista = new List<cMercaderia>();
            _totActivoAlPrecio = 0;
            _totActivoAlCosto = 0;
            _totUtilidad = 0;
        }
        public void Agregar(cMercaderia obj)
        {
            _totActivoAlPrecio += obj.Activo_Al_Precio;
            _totActivoAlCosto += obj.Activo_Al_Costo;
            _totUtilidad += obj.Utilidad;
            _lista.Add(obj);

        }
        public void OrdenarPor(string nombreColumna)
        {
            List<cMercaderia> nuevaLista=new List<cMercaderia>();
            if (_ultimoOrden == nombreColumna)
            {
                foreach (cMercaderia aux in _lista)
                    nuevaLista.Insert(0,aux);
                if (_ascendente)
                    _ascendente = false;
                else
                    _ascendente = true;
                _lista = nuevaLista;
            }
            else
            {
                
                bool insertado;
                if ("Activo_Al_Costo" == nombreColumna)
                {
                    _ascendente = true;
                    _ultimoOrden = nombreColumna;
                    foreach (cMercaderia aux in _lista)
                    {
                        insertado=false;
                        for (int x = 0; x < nuevaLista.Count; x++)
                        {
                            if (nuevaLista[x].Activo_Al_Costo < aux.Activo_Al_Costo)
                            {
                                nuevaLista.Insert(x, aux);
                                x = nuevaLista.Count;
                                insertado = true;
                            }
                        }
                        if (!insertado)
                            nuevaLista.Add(aux);
                    }
                    _lista = nuevaLista;
                }
                else if ("Activo_Al_Precio" == nombreColumna)
                {
                    _ascendente = true;
                    _ultimoOrden = nombreColumna;
                    foreach (cMercaderia aux in _lista)
                    {
                        insertado = false;
                        for (int x = 0; x < nuevaLista.Count; x++)
                        {
                            if (nuevaLista[x].Activo_Al_Precio < aux.Activo_Al_Precio)
                            {
                                nuevaLista.Insert(x, aux);
                                x = nuevaLista.Count;
                                insertado = true;
                            }
                        }
                        if (!insertado)
                            nuevaLista.Add(aux);
                    }
                    _lista = nuevaLista;
                } 
                else if ("Stock" == nombreColumna)
                {
                    _ascendente = true;
                    _ultimoOrden = nombreColumna;
                    foreach (cMercaderia aux in _lista)
                    {
                        insertado = false;
                        for (int x = 0; x < nuevaLista.Count; x++)
                        {
                            if (nuevaLista[x].Stock < aux.Stock)
                            {
                                nuevaLista.Insert(x, aux);
                                x = nuevaLista.Count;
                                insertado = true;
                            }
                        }
                        if (!insertado)
                            nuevaLista.Add(aux);
                    }
                    _lista = nuevaLista;
                }
                else if ("Utilidad" == nombreColumna)
                {
                    _ascendente = true;
                    _ultimoOrden = nombreColumna;
                    foreach (cMercaderia aux in _lista)
                    {
                        insertado = false;
                        for (int x = 0; x < nuevaLista.Count; x++)
                        {
                            if (nuevaLista[x].Utilidad < aux.Utilidad)
                            {
                                nuevaLista.Insert(x, aux);
                                x = nuevaLista.Count;
                                insertado = true;
                            }
                        }
                        if (!insertado)
                            nuevaLista.Add(aux);
                    }
                    _lista = nuevaLista;
                }

            }
        }

    }
}
