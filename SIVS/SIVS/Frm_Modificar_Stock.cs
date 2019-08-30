using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLASES;
using CONTROL;

namespace SIVS
{
    public partial class Frm_Modificar_Stock : Form
    {
        Ctrl_articulos adm = Ctrl_articulos.ClaseActiva();
        
        public Frm_Modificar_Stock()
        {
            InitializeComponent();
        }

        private void Frm_Modificar_Stock_Load(object sender, EventArgs e)
        {            
            cbb_articulo.DataSource = adm.DevolverListaVigentes();
            cbb_articulo.DisplayMember = "Descripcion";
            lbl_datos.Text = "";
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(13))
                {
                    txt_stock.Focus();
                    e.Handled = true;
                    Carticulo obj=  adm.BuscarEnVigentes(txt_codigo.Text);
                    if(obj!=null){
                        cbb_articulo.SelectedItem = obj;
                    }
                    else{
                        lbl_datos.Text = "";
                        Frm_confirmacion frm = new Frm_confirmacion("No se encontro ningun articulo con ese código.", "Codigo incorrecto", "Aceptar");
                        frm.ShowDialog();

                    }

                }
            }
            catch
            { }
        }
        private void CompletarDatos(Carticulo obj)
        {
            lbl_datos.Text = "Stock actual: " + obj.Stock + "   Medida: " + obj.Unidad_Medida.Nombre;
        }

        private void Frm_Modificar_Stock_Activated(object sender, EventArgs e)
        {
            txt_stock.Clear();
            txt_codigo.Clear();
            txt_codigo.Focus();
        }

        private void cbb_articulo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Carticulo oArt = (Carticulo)cbb_articulo.SelectedItem;
            CompletarDatos(oArt);
            txt_codigo.Text = oArt.Codigo.ToString();
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {           

            try
            {
                if ( e.KeyChar == Convert.ToChar(13))
                {
                    btn_Modificar.PerformClick();
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Carticulo oArt = (Carticulo)cbb_articulo.SelectedItem;
                oArt.Modificar_Stock(Convert.ToInt32(txt_stock.Text));
                adm.ModificarStock(oArt);
                txt_codigo.Focus();
                CompletarDatos(oArt);
            }
            catch(Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }



    }
}
