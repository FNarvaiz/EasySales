using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CLASES
{
    public class Ccaja_diaria
    {
        decimal _EfectivoInicial;
        decimal _VentasEfectivo;
        decimal _Cobros;
        decimal _Gastos;
        decimal _EfectivoFinal;
        decimal _VentasOtros;
        decimal _VentasTotal;
        DateTime _Fecha;
        int _id;
        List<Cgasto> ListaGastos;
        List<Ccobro> ListaCobros;
        List<Cventa> ListaVentas;
        public int ID
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }
        public DateTime Fecha
        {
            set
            {
                _Fecha = value;
            }
            get
            {
                return _Fecha;
            }
        }
        public decimal Gastos
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Los gastos no puede ser negativa");
                }
                else
                {
                    _Gastos = value;
                }
            }
            get
            {
                return _Gastos;
            }
        }
        public decimal Cobros
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("Los cobros no puede ser negativa");
                }
                else
                {
                    _Cobros = value;
                }
            }
            get
            {
                return _Cobros;
            }
        }
        public decimal V_otros
        {
            set
            {
                
                    _VentasOtros = value;
                
            }
            get
            {
                return _VentasOtros;
            }
        }    
        public decimal V_total{
            set
            {
                
                    _VentasTotal = value;
                
            }
            get
            {
                return _VentasTotal;
            }
        }
        public decimal V_efectivo
        {
            set
            {
               
                    _VentasEfectivo = value;
                
            }
            get
            {
                return _VentasEfectivo;
            }
        }     
        public decimal Efec_inicial
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("La caja no puede ser negativa");
                }
                else
                {
                    _EfectivoInicial = value;
                }
            }
            get
            {
                return _EfectivoInicial;
            }
        }
        public decimal Efec_final
        {
            set
            {
                if (value < 0)
                {
                    _EfectivoFinal = value;
                    //throw new Exception("La caja no puede ser negativa");
                }
                else
                {
                    _EfectivoFinal = value;
                }
            }
            get
            {
                return _EfectivoFinal;
            }
        }

        public Ccaja_diaria(int id,DateTime fecha, decimal efecInicial)
        {
            ID = id;
            Fecha = fecha;
            Efec_inicial = efecInicial;
            Efec_final = efecInicial;
        }
        
        public Ccaja_diaria(DateTime fecha, int id, decimal efecInicial,decimal efecfinal,decimal v_efec,decimal v_otro,decimal v_total,decimal cobros,decimal gastos)
        {
            Fecha = fecha;
            ID = id;
            Efec_inicial = efecInicial;
            Efec_final = efecfinal;
            V_efectivo = v_efec;
            V_otros = v_otro;
            V_total = v_total;
            Gastos = gastos;
            Cobros = cobros;
        }

        public void AgregarGasto(Cgasto obj)
        {
            if (obj.FORMAPAGO().Altera_caja)
                Efec_final -= obj.Importe;
            Gastos += obj.Importe;
            ListaGastos.Add(obj);
        }

        public void AgregarVenta(Cventa obj)
        {
            if (obj.Pago.FormaPago.Altera_caja)
            {
                Efec_final += obj.Pago.Importe;
                V_efectivo += obj.Pago.Importe;
            }
            else
                V_otros += obj.Pago.Importe;
            if (obj.Pago2 != null)
            {
                if (obj.Pago2.FormaPago.Altera_caja)
                {
                    Efec_final += obj.Pago2.Importe;
                    V_efectivo += obj.Pago2.Importe;
                }
                else
                    V_otros += obj.Pago2.Importe;
            }
            V_total += obj.Total;
            ListaVentas.Add(obj);
        }
        public void EliminarVenta(Cventa obj)
        {
            if (obj.Pago.FormaPago.Altera_caja)
            {
                Efec_final -= obj.Pago.Importe;
                V_efectivo -= obj.Pago.Importe;
            }
            else
                V_otros -= obj.Pago.Importe;
            if (obj.Pago2 != null)
            {
                if (obj.Pago2.FormaPago.Altera_caja)
                {
                    Efec_final -= obj.Pago2.Importe;
                    V_efectivo -= obj.Pago2.Importe;
                }
                else
                    V_otros -= obj.Pago2.Importe;
            }
            V_total -= obj.Total;
            if(ListaVentas!=null)
            ListaVentas.Remove(obj);
        } 
        public void AgregarCobro(Ccobro obj)
        {
            if (obj.FORMAPAGO().Altera_caja)
                Efec_final += obj.Importe;
            Cobros += obj.Importe;
            ListaCobros.Add(obj);
        }
        public void EliminarGasto(Cgasto obj)
        {
            if(obj.FORMAPAGO().Altera_caja)
                Efec_final+=obj.Importe;
            Gastos -= obj.Importe;
            ListaGastos.Remove(obj);
        }
        public void EliminarCobro(Ccobro obj)
        {
            if(obj.FORMAPAGO().Altera_caja)
                Efec_final-=obj.Importe;
            Cobros -= obj.Importe;
            ListaCobros.Remove(obj);
        }
        public void InstanciarCobros()
        {
            Cobros = 0;
            ListaCobros = new List<Ccobro>();
        }
        public void InstanciarGastos()
        {
            Gastos = 0;
            ListaGastos = new List<Cgasto>();
        }
        public void InstanciarVentas()
        {
            V_efectivo = 0;
            V_otros = 0;
            V_total = 0;
            ListaVentas = new List<Cventa>();
        }
        public void InstanciarVentasSinCalcular()
        {
            ListaVentas = new List<Cventa>();
        }
        public List<Ccobro> LISTACOBROS()
        {
            return ListaCobros;
        }
        public List<Cgasto> LISTAGASTOS()
        {
            return ListaGastos;
        }
        public List<Cventa> LISTAVENTAS()
        {
            return ListaVentas;
        }
        public decimal CalcularGanaciaSobreCosto()
        {
            decimal total = 0;
            foreach(Cventa auxVenta in LISTAVENTAS()){
                foreach (Citem auxItem in auxVenta.Items())
                {
                    total += (auxItem.Articulo.Precio - auxItem.Articulo.Costo) * auxItem.Cantidad;
                }
            }
            return total;
        }
        public Cventa UltimaVenta()
        {
            if (ListaVentas != null)
            {
                if (ListaVentas.Count != 0)
                    return LISTAVENTAS()[LISTAVENTAS().Count - 1];
                else
                    return null;
            }
            else
                return null;
        }

    }
}
