using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CLASES;
using CONTROL;

namespace SIVS
{
    public partial class Frm_Items : SIVS.Frm_ABM
    {
        List<Citem> Items;
        Cventa oVenta;
        Ccompra oCompra;
        Ccaja_diaria oCaja;
        DateTime _Fecha;
        public Frm_Items(string argumento,Ccompra Compra)
        {
            InitializeComponent();

            oCompra = Compra;
            Text = "Articulos de la compra " + oCompra.Id + ".";
            Items = oCompra.Lista();
            lbl_argumento.Text = argumento+"\n";
            btn_Guardar.Visible = false;
        }
        public Frm_Items(string argumento, Cventa Venta, Ccaja_diaria cajaDiaria, DateTime Fecha)
        {
            InitializeComponent();

            oVenta = Venta;
            oCaja = cajaDiaria;
            Items = oVenta.Items();
            Text = "Articulos de la venta " + oVenta.ID + ".";
            lbl_argumento.Text = argumento+"\n";
            _Fecha = Fecha;
        }
        private void Frm_Items_Load(object sender, EventArgs e)
        {
            bs_items.ResetBindings(false);
            bs_items.DataSource = Items;
            dgrid_items.DataSource = bs_items;
            Height = 465 + lbl_argumento.Height;
        }

        protected override void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {

            Reportes.R_Venta frm = new Reportes.R_Venta(oCaja.ID, oVenta, _Fecha);
            frm.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Ctrl_cajas_diarias.ClaseActiva().EliminarVenta(oVenta, oCaja);
                Frm_confirmacion frm = new Frm_confirmacion("Se ha eliminado satisfactoriamente.", "Mensaje", "Aceptar");
                frm.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }
    }
}
