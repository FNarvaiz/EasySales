using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CLASES;
using C_DATOS;
using System.Data;
namespace CONTROL
{
    public class Ctrl_cajas_diarias
    {
        int ultimocobro;
        int ultimogasto;
        int ultimaventa;
        public List<Ccaja_diaria> ListaCajas;
        private static Ctrl_cajas_diarias Control;
        public static Ctrl_cajas_diarias ClaseActiva()
        {
            if (Control == null)
            {
                Control = new Ctrl_cajas_diarias();
            }
            return Control;
        }
        public int UltimoId()
        {
            DataTable DT = Cdatos_cajas_diarias.DevolverUltimo();
            if (DT.Rows.Count == 0)
                return 0;
            return Convert.ToInt32(DT.Rows[0][0]);
        }
        public Ccaja_diaria TraerCajaDelDia(Ccaja obj)
        {
            DataTable DT = Cdatos_cajas_diarias.DevolverDelDia(obj);
                foreach (DataRow DR in DT.Rows)
                {
                    Ccaja_diaria caja = new Ccaja_diaria(Convert.ToInt32(DR[0]), Convert.ToDateTime(DR[1]), Convert.ToDecimal(DR[2]));
                    CargarGastosCobros(caja);
                    return caja ;
                }
                return null ;
        }
        public Ccaja_diaria BuscarCajaDiaria(int id)
        {
           return Cdatos_cajas_diarias.DevolverCajaDiaria(id);
            
        }

        public List<Ccaja_diaria> DevolverCajas(DateTime desde, DateTime hasta)
        {
            if(ListaCajas == null)
            {
                ListaCajas = new List<Ccaja_diaria>();
            }
            if (ListaCajas.Count == 0)
            {
                DataTable DT = Cdatos_cajas_diarias.Devolver(desde.ToShortDateString(), hasta.ToShortDateString());
                foreach (DataRow DR in DT.Rows)
                {
                    ListaCajas.Add(new Ccaja_diaria(Convert.ToDateTime(DR[1]), Convert.ToInt32(DR[0]), Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[4]), Convert.ToDecimal(DR[5]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]), Convert.ToDecimal(DR[8])));
                }
            }
            else if (ListaCajas[ListaCajas.Count-1].Fecha >= desde)
            {
                DataTable DT = Cdatos_cajas_diarias.Devolver(desde.ToShortDateString(), ListaCajas[ListaCajas.Count-1].Fecha.AddDays(-1).ToShortDateString());
                foreach (DataRow DR in DT.Rows)
                {
                    ListaCajas.Add(new Ccaja_diaria(Convert.ToDateTime(DR[1]),Convert.ToInt32(DR[0]), Convert.ToDecimal(DR[2]), Convert.ToDecimal(DR[3]), Convert.ToDecimal(DR[4]), Convert.ToDecimal(DR[5]), Convert.ToDecimal(DR[6]), Convert.ToDecimal(DR[7]), Convert.ToDecimal(DR[8])));
                }
            }
            if (ListaCajas.Count > 0)
            {
                    List<Ccaja_diaria> ListaCajasAux = new List<Ccaja_diaria>();

                    foreach (Ccaja_diaria Aux in ListaCajas)
                    {
                        if (Aux.Fecha >= desde && Aux.Fecha <= hasta)
                        {
                            ListaCajasAux.Add(Aux);
                        }

                    }
                    return ListaCajasAux;

                
            }
            
            return ListaCajas;
        }
        public Ccaja_diaria GenerarCaja(decimal SaldoInicial, Ccaja objcaja)
        {
            Ccaja_diaria obj= new Ccaja_diaria(this.UltimoId()+1,DateTime.Today,SaldoInicial);
            Cdatos_cajas_diarias.Agregar(obj, objcaja);
            obj.InstanciarVentas();
            obj.InstanciarCobros();
            obj.InstanciarGastos();
            return obj;
        }
        public void CerrarCaja(Ccaja_diaria  caja)
        {
            Cdatos_cajas_diarias.Modificar(caja, true);
            ultimaventa = 0;
            if (ListaCajas != null)
                ListaCajas.Insert(0, caja);
        }
        public void Modificar(Ccaja_diaria obj)
        {
            Cdatos_cajas_diarias.Modificar(obj);
        }
        public void AgregarOperacion(Ccobro obj,Ccaja_diaria caja)
        {
            if (ultimocobro == 0)
                ultimocobro = Cdatos_operaciones.DevolverUltimo("COBROS");
            try
            {
                ultimocobro++;
                obj.Numero = ultimocobro;
                Cdatos_operaciones.Agregar(obj, caja);
                caja.AgregarCobro(obj);
            }
            catch
            {
                AgregarOperacion(obj,caja);
            }
        }
        public void AgregarOperacion(Cgasto obj,Ccaja_diaria caja)
        {
            if (ultimogasto == 0)
                ultimogasto = Cdatos_operaciones.DevolverUltimo("GASTOS");
            try
            {
                ultimogasto++;
                obj.Numero = ultimogasto;
                Cdatos_operaciones.Agregar(obj, caja);
                caja.AgregarGasto(obj);
            }
            catch
            {
                AgregarOperacion(obj,caja);
            }
        }
        public void CargarGastosCobros(Ccaja_diaria caja)
        {
            caja.InstanciarCobros();
            DataTable DT = Cdatos_operaciones.DevolverGastosOCobros("COBROS", caja);
            Ctrl_formas_pagos admformas = Ctrl_formas_pagos.ClaseActiva();
            admformas.CargarLista();
            Ctrl_conceptos admconceptos = Ctrl_conceptos.ClaseActiva();
            foreach (DataRow DR in DT.Rows)
            {
                caja.AgregarCobro(new Ccobro(Convert.ToInt32(DR[0]),admconceptos.BuscarPorID(Convert.ToInt32( DR[1])), Convert.ToDecimal(DR[2]), admformas.BuscarPorID(Convert.ToInt32(DR[3]))));
            }
            caja.InstanciarGastos();
            DT = Cdatos_operaciones.DevolverGastosOCobros("GASTOS", caja);
            foreach (DataRow DR in DT.Rows)
            {
                caja.AgregarGasto(new Cgasto(Convert.ToInt32(DR[0]), admconceptos.BuscarPorID(Convert.ToInt32(DR[1])), Convert.ToDecimal(DR[2]), admformas.BuscarPorID(Convert.ToInt32(DR[3]))));
            }
        }        
        public bool CobrosYGastosCargados(Ccaja_diaria caja)
        {
            if (caja.LISTACOBROS() == null)
                return false;
            if (caja.LISTAGASTOS() == null)
                return false;
            return true;
        }
        public bool VentasCargadas(Ccaja_diaria caja)
        {
            if (caja.LISTAVENTAS() == null)
                return false;
            return true;
        }
        public void ModificarOperacion(Ccobro obj,Ccobro objnuevo,Ccaja_diaria caja)
        {
            objnuevo.Numero = obj.Numero;
            Cdatos_operaciones.ModificarCobro(objnuevo, objnuevo.FORMAPAGO());
            caja.EliminarCobro(obj);
            caja.AgregarCobro(objnuevo);
        }
        public void ModificarOperacion(Cgasto obj,Cgasto objnuevo,Ccaja_diaria caja)
        {
            objnuevo.Numero=obj.Numero;
            Cdatos_operaciones.ModificarGasto( objnuevo, objnuevo.FORMAPAGO());
            caja.EliminarGasto(obj);
            caja.AgregarGasto(objnuevo);
        }
        public bool TieneDebito(Ccobro obj)
        {
            return Cdatos_operaciones.TieneDebito(obj);
        }
        //public bool TraerDebito(Ccobro obj)
        //{
        //    return Cdatos_operaciones.TieneRecibo(obj);
        //}
        public bool TieneCredito(Cgasto obj)
        {
            return Cdatos_operaciones.TieneCredito(obj);
        }
        public void EliminarOperacion(Ccobro obj, bool tienedebito,Ccaja_diaria caja)
        {
            if (tienedebito)
                Cdatos_operaciones.EliminarReferenciaDe(obj);
            Cdatos_operaciones.Eliminar(obj);
            caja.EliminarCobro(obj);
        }
        public void EliminarOperacion(Cgasto obj, bool tienecredito,Ccaja_diaria caja)
        {
            if (tienecredito)
                Cdatos_operaciones.EliminarReferenciaDe(obj);
            Cdatos_operaciones.Eliminar(obj);
            caja.EliminarGasto(obj);
        }
        public void AgregarVenta(Cventa obj,Cusuario objusu,Ccaja_diaria caja)
        {
            ultimaventa++;
            obj.ID = ultimaventa;
            Cdatos_ventas.Agregar(obj,caja,objusu);
            Cdatos_ventas.RegistrarPago(obj, caja, obj.Pago);
            if (obj.Pago2 != null)
                Cdatos_ventas.RegistrarPago(obj, caja, obj.Pago2);
            caja.AgregarVenta(obj);
        }
        public void EliminarVenta(Cventa obj, Ccaja_diaria caja)
        {
            foreach (Citem aux in obj.Items())
            {
                Cdatos_ventas.EliminarItem(aux,obj,caja);
            }
            Cdatos_ventas.EliminarPagos(obj, caja);
            Cdatos_ventas.Eliminar(obj, caja);
            
            caja.EliminarVenta(obj);
            if(Cdatos_cajas_diarias.CajaCerrada(caja))
                Cdatos_cajas_diarias.Modificar(caja);
        }
        public void GuardarItems(Cventa obj,Ccaja_diaria caja)
        {
            foreach (Citem aux in obj.Items())
            {
                Cdatos_ventas.RegistrarItem(aux,obj,caja);
            }
        }
        public void UltimaVenta(Ccaja_diaria actual)
        {
            ultimaventa = 0;
            foreach (Cventa venta in actual.LISTAVENTAS())
                if (venta.ID > ultimaventa)
                    ultimaventa = venta.ID;
        }
        public void CargarVentas(Ccaja_diaria caja)
        {
            if (caja.LISTAVENTAS() == null)
            {
                caja.InstanciarVentas();
                DataTable DT = Cdatos_ventas.Devolver(caja);
                Ctrl_formas_pagos admformas = Ctrl_formas_pagos.ClaseActiva();
                if (DT.Rows.Count != 0)
                {
                    Cpago pago;
                    int idventa;
                    int anterior=0;
                    Ctrl_Ventas admVentas = Ctrl_Ventas.ClaseActiva();
                    Cventa oventa = new Cventa();
                    foreach (DataRow DR in DT.Rows)
                    {
                        pago= new Cpago(admformas.BuscarPorID(Convert.ToInt32(DR[3])),Convert.ToDecimal(DR[4]),DR[5].ToString(),Convert.ToDecimal(DR[6]));
                        idventa=Convert.ToInt32(DR[0]);
                        if(anterior==idventa)
                        {
                            oventa.Pago2 = pago;
                            oventa.DescRecargo += pago.Descuento;
                        }
                        else
                        {
                            oventa = new Cventa(idventa, Convert.ToDecimal(DR[1]), Convert.ToDecimal(DR[2]), pago.Descuento, pago);
                            admVentas.CargarItems(oventa, caja.ID);
                            caja.AgregarVenta(oventa);
                        }
                        anterior = idventa;
                    }
                }
            }          
        }
        public void CargarVentasSinCalcular(Ccaja_diaria caja)
        {
            if (caja.LISTAVENTAS() == null)
            {
                caja.InstanciarVentasSinCalcular();
                DataTable DT = Cdatos_ventas.Devolver(caja);
                Ctrl_formas_pagos admformas = Ctrl_formas_pagos.ClaseActiva();
                if (DT.Rows.Count != 0)
                {
                    Cpago pago;
                    int idventa;
                    int anterior = 0;
                    Cventa oventa = new Cventa();
                    foreach (DataRow DR in DT.Rows)
                    {
                        pago = new Cpago(admformas.BuscarPorID(Convert.ToInt32(DR[3])), Convert.ToDecimal(DR[4]), DR[5].ToString(), Convert.ToDecimal(DR[6]));
                        idventa = Convert.ToInt32(DR[0]);
                        if (anterior == idventa)
                        {
                            oventa.Pago2 = pago;
                            oventa.DescRecargo += pago.Descuento;
                        }
                        else
                        {
                            oventa = new Cventa(idventa, Convert.ToDecimal(DR[1]), Convert.ToDecimal(DR[2]), pago.Descuento, pago);
                            caja.LISTAVENTAS().Add(oventa);
                        }
                        anterior = idventa;
                    }
                }
            }
        }
    }
}
