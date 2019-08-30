using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using C_DATOS;
using CLASES;
using System.Data;
namespace CONTROL
{
    public class Ctrl_ActualizarPrecios
    {
        List<Carticulo> L_ArtDesactualizados = new List<Carticulo>();
        List<Carticulo> L_ArtActualizados= new List<Carticulo>();
        List<Crubro> L_RubrosSeleccionados= new List<Crubro>();
        decimal TotalDesactualizado;
        decimal TotalActualizado;
        decimal Diferencia;
        
        public decimal totalDes
        {
            get
            {
                return TotalDesactualizado;
            }
        }
        public decimal diferencia
        {
            get
            {
                return Diferencia;
            }
        }
        public decimal totalAct
        {
            get
            {
                return TotalActualizado;
            }
        }

        Ctrl_articulos admArt = Ctrl_articulos.ClaseActiva();
        public List<Carticulo> AgregarAtirculosPorRubro(Crubro oRubro)
        {
            if (L_RubrosSeleccionados.Contains(oRubro))
                throw new Exception("El rubro seleccionado ya esta cargado. No se puede repetir.");
            else
            {
                if (L_ArtDesactualizados.Count == 0)
                    L_ArtDesactualizados = admArt.DevolverListaVigentes(oRubro);
                else
                {
                    List<Carticulo> L = admArt.DevolverListaVigentes(oRubro);
                    foreach (Carticulo aux in L)
                    {
                        if (!L_ArtDesactualizados.Contains(aux))                            
                            L_ArtDesactualizados.Add(aux);
                    }
                }
                L_RubrosSeleccionados.Add(oRubro);
            }
            return L_ArtDesactualizados;
        }

        public List<Crubro> RubrosSeleccionados()
        {
            return L_RubrosSeleccionados;
        }

        public List<Carticulo> QuitarArticulosPorRubro(Crubro oRubro)
        {
            if (!L_RubrosSeleccionados.Contains(oRubro))
                throw new Exception("El rubro seleccionado no esta cargado. No se puede quitar.");
            else
            {
                if (L_RubrosSeleccionados.Count == 1)
                {
                    L_ArtDesactualizados.Clear();
                }
                else{
                    List<Carticulo> L = new List<Carticulo>();
                    foreach (Carticulo aux in L_ArtDesactualizados)
                    {
                        if (aux.Rubro == oRubro)
                            L.Add(aux);
                    }
                    foreach (Carticulo aux in L)
                        L_ArtDesactualizados.Remove(aux);
                }
                
                L_RubrosSeleccionados.Remove(oRubro);
            }
            return L_ArtDesactualizados;
        }
        public List<Carticulo> QuitarArticulo(Carticulo oArticulo)
        {
            if (!L_ArtDesactualizados.Contains(oArticulo))
                throw new Exception("El artículo seleccionado no esta cargado. No se puede quitar.");
            else
            {
                L_ArtDesactualizados.Remove(oArticulo);
            }
            return L_ArtDesactualizados;
        }
        public List<Carticulo> GenerarVistaPrevia(decimal valor, bool porcentaje, bool incremento, bool redondear)
        {
            if (L_ArtDesactualizados.Count == 0)
                throw new Exception("No tiene ningun artículo para generar vista previa.");
            else
            {
                TotalDesactualizado = 0;
                TotalActualizado = 0;
                Diferencia = 0;
                L_ArtActualizados.Clear();
                Carticulo oArtActualizado;
                decimal precioActualizado=0;
                if (porcentaje)
                {
                    if (incremento)
                    {
                        if (redondear)
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio * valor / 100;
                                precioActualizado += aux.Precio;
                                precioActualizado = precioActualizado* 2;
                                precioActualizado =Math.Round(precioActualizado, 1, MidpointRounding.AwayFromZero);
                                oArtActualizado.Precio = precioActualizado / 2;
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                        else
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio * valor / 100;
                                precioActualizado += aux.Precio;
                                oArtActualizado.Precio = Math.Round(precioActualizado, 2, MidpointRounding.AwayFromZero);
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                    }
                    else
                    {
                        if (redondear)
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio * valor / 100;
                                precioActualizado = aux.Precio - precioActualizado;
                                precioActualizado = precioActualizado * 2;
                                precioActualizado = Math.Round(precioActualizado, 1, MidpointRounding.AwayFromZero);
                                oArtActualizado.Precio = precioActualizado / 2;
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                        else
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio * valor / 100;
                                precioActualizado = aux.Precio - precioActualizado;
                                oArtActualizado.Precio = Math.Round(precioActualizado, 2, MidpointRounding.AwayFromZero);
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                    }
                }
                else
                {
                    if (incremento)
                    {
                        if (redondear)
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio + valor;
                                precioActualizado = precioActualizado * 2;
                                precioActualizado = Math.Round(precioActualizado, 1, MidpointRounding.AwayFromZero);
                                oArtActualizado.Precio = precioActualizado / 2;
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                        else
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio + valor ;
                                oArtActualizado.Precio = Math.Round(precioActualizado, 2, MidpointRounding.AwayFromZero);
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                    }
                    else
                    {
                        if (redondear)
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio - valor;
                                precioActualizado = precioActualizado * 2;
                                precioActualizado = Math.Round(precioActualizado, 1, MidpointRounding.AwayFromZero);
                                oArtActualizado.Precio = precioActualizado / 2;
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                        else
                        {
                            foreach (Carticulo aux in L_ArtDesactualizados)
                            {
                                oArtActualizado = (Carticulo)aux.Clone();
                                precioActualizado = aux.Precio - valor;
                                oArtActualizado.Precio = Math.Round(precioActualizado, 2, MidpointRounding.AwayFromZero);
                                L_ArtActualizados.Add(oArtActualizado);
                                TotalDesactualizado += aux.Precio;
                                TotalActualizado += oArtActualizado.Precio;
                            }
                        }
                    }
                }
            }
            Diferencia = TotalActualizado - TotalDesactualizado;
            return L_ArtActualizados;
        }
        public void GuardarCambios()
        {
            if (L_ArtActualizados.Count == 0)
                throw new Exception("No tiene ningun artículo para generar vista previa.");
            else
            {
                foreach (Carticulo aux in L_ArtActualizados)
                {
                    admArt.Modificar(aux);
                }
            }
        }
    }
}
