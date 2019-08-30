using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace SIVS
{
    public class cGrafico
    {
        List<cResumenConcepto> _datos;
        bool _porDia;
        public List<cResumenConcepto> Datos
        {
            get { return _datos; }
        }
        string _titulo;
        public cGrafico(string titulo,bool porDia){
            _datos= new List<cResumenConcepto>();
            _titulo = titulo;
            _porDia = porDia;
        }
        private cResumenConcepto Buscar(object obj)
        {
            foreach (cResumenConcepto aux in _datos)
                if (aux.Concepto.ToString() == obj.ToString())
                    return aux;
            cResumenConcepto nuevo = new cResumenConcepto(obj);

            _datos.Add(nuevo);
            return nuevo;
        }
        public void TresDe(Chart obj, bool _3d)
        {
            if (_3d)
            {
                if (obj.Series[0].ChartType == SeriesChartType.StackedColumn)
                    foreach (Series aux in obj.Series)
                        aux.ChartType = SeriesChartType.Column;
            }
            obj.ChartAreas[0].Area3DStyle.Enable3D = _3d;

        }
        public void AgregarDato(object Concepto, DateTime fecha, decimal cant)
        {
            cResumenConcepto obj = Buscar(Concepto);
            obj.Sumar(fecha, cant, _porDia);
        }
        private Series CrearSerie(Chart obj, SeriesChartType tipo, string nombre)
        {
            Series serie = obj.Series.Add(nombre);
            serie.ChartType = tipo;
            //serie.Palette = ChartColorPalette.Pastel;
            
            serie.Font = new Font(new FontFamily("Segoe UI"), 16, FontStyle.Regular, GraphicsUnit.Pixel);
            return serie;
        }
        private DataPoint CrearPoint(Series serie, string nombre, int cant)
        {
            DataPoint point = serie.Points.Add(cant);
            point.Font = new Font(new FontFamily("Segoe UI"), 16, FontStyle.Regular, GraphicsUnit.Pixel);
            //point.Name = obj.Nombre +" "+ cant;
            point.Label = nombre;
            return point;
        }
        private void CargarComboBox(ComboBox obj)
        {
            obj.Items.Add("Torta");
            obj.Items.Add("Columnas");
            obj.Items.Add("Columnas superpuestas");
            obj.Items.Add("Barras");
            obj.Items.Add("Lineas rectas");
            obj.Items.Add("Lineas onduladas");

        }
        public void Graficar(Chart c_generico,int tipoDeGrafico )
        {
            c_generico.Series.Clear();
            Series nuevaSerie;
            int cant = 0;
            int total = 0;
            if (tipoDeGrafico == 0)
            {
                nuevaSerie = CrearSerie(c_generico, SeriesChartType.Pie, _titulo);
                nuevaSerie.BorderWidth = 2;
                nuevaSerie.BorderColor = Color.Gray;
                nuevaSerie.BorderDashStyle = ChartDashStyle.Solid;
                nuevaSerie.Palette = ChartColorPalette.Pastel;
                foreach (cResumenConcepto aux in _datos)
                {
                    cant = Convert.ToInt32(Math.Round(aux.Importe, 0));
                    DataPoint point = CrearPoint(nuevaSerie, aux.Concepto.ToString() + " " + cant, cant);
                    total += cant;
                }
            }
            else
            {
                SeriesChartType tipo;
                if (tipoDeGrafico == 1)
                {
                    c_generico.Palette = ChartColorPalette.Pastel;
                    tipo = SeriesChartType.Column;
                }
                else if (tipoDeGrafico == 3)
                {
                    c_generico.Palette = ChartColorPalette.Pastel;
                    tipo = SeriesChartType.Bar;
                }
                else if (tipoDeGrafico == 2)
                {
                    c_generico.Palette = ChartColorPalette.Pastel;
                    if(c_generico.ChartAreas[0].Area3DStyle.Enable3D)
                        tipo = SeriesChartType.Column;
                    else
                        tipo = SeriesChartType.StackedColumn;
                }
                else
                {
                    c_generico.Palette = ChartColorPalette.Bright;
                    if (tipoDeGrafico == 4)
                        tipo = SeriesChartType.Line;
                    else
                        tipo = SeriesChartType.Spline;
                }
                foreach (cResumenConcepto aux in _datos)
                {
                    cant = Convert.ToInt32(Math.Round(aux.Importe, 0));
                    nuevaSerie = CrearSerie(c_generico, tipo, aux.Concepto.ToString() + " " + cant);
                    if (_porDia)
                    {
                        nuevaSerie.XValueType = ChartValueType.Date;
                        c_generico.ChartAreas[0].AxisX.LabelStyle.Format = "dd/MM/yy";
                    }
                    total += cant;
                    foreach (cPunto punto in aux.Puntos)
                    {
                        cant = Convert.ToInt32(punto.Cantidad);
                        DataPoint point = CrearPoint(nuevaSerie, "", cant);
                        point.SetValueXY(punto.Fecha(_porDia), cant);
                        
                        point.Color = nuevaSerie.Color;

                    }

                }
            }
            c_generico.Titles[0].Text = _titulo + " Total : " + total.ToString();
        }

        internal void Limpiar()
        {
            _datos.Clear();
        }
    }


    public class cResumenConcepto
    {
        object _concepto;
        List<cPunto> _puntos = new List<cPunto>();
        decimal _importe;

        public List<cPunto> Puntos
        {
            get { return _puntos; }
        }
        public object Concepto
        {
            get { return _concepto; }
        }


        public decimal Importe
        {
            get { return _importe; }
        }
        public cResumenConcepto(object obj)
        {
            _concepto = obj;
            _importe = 0;

        }
        public void LimpiarSerie()
        {
            _importe = 0;
            _puntos.Clear();
        }
        private int Orden(DateTime fecha)
        {
            int orden = 0;
            foreach (cPunto aux in _puntos)
                if (fecha < ((DateTime)aux.Indicador))
                    return orden;
                else
                    orden++;
            return orden;
        }
        private cPunto BuscarPunto(DateTime fecha,bool porDia)
        {
            if(porDia)
                foreach (cPunto aux in _puntos)
                {
                    DateTime punto = (DateTime)aux.Indicador;
                    if (punto.Date==fecha.Date)
                        return aux;
                }
            else
                foreach (cPunto aux in _puntos)
                {
                    DateTime punto = (DateTime)aux.Indicador;
                    if (punto.Month == fecha.Month && punto.Year == fecha.Year)
                        return aux;
                }
            cPunto nuevoPunto = new cPunto(fecha);
            Puntos.Insert(Orden(fecha), nuevoPunto);
            return nuevoPunto;
        }
        public void Sumar(DateTime fecha, decimal cantidad, bool porDia)
        {
            cPunto punto = BuscarPunto(fecha.Date, porDia);
            punto.Cantidad += cantidad;
            _importe += cantidad;
        }
    }

    public class cPunto
    {
        object _indicador;

        public object Indicador
        {
            get { return _indicador; }
            set { _indicador = value; }
        }
        decimal _cant;

        public decimal Cantidad
        {
            get { return _cant; }
            set { _cant = value; }
        }

        public cPunto(object indicador)
        {
            Indicador = indicador;
            Cantidad = 0;

        }
        public string Nombre()
        {
                return _indicador.ToString();
        }
        public object Fecha(bool PorDia)
        {
            if(PorDia)
                return ((DateTime)_indicador).Date;
            return ((DateTime)_indicador).Month + "/" + ((DateTime)_indicador).Year;
            
        }
    }
}
