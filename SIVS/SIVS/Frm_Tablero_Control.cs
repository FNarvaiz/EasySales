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
using System.Diagnostics;
namespace SIVS
{


    public partial class Frm_Tablero_Control : Form
    {
        private static Frm_Tablero_Control frm;
        Ctrl_tablero admTablero = new Ctrl_tablero();
        Ctrl_articulos admArt = Ctrl_articulos.ClaseActiva();
        Ctrl_rubros admRubro = Ctrl_rubros.ClaseActiva();
        Carticulo oArt;
        //LinearGradientBrush brocha;

        public static Frm_Tablero_Control AbrirForm()
        {
            if ((frm == null) || (frm.IsDisposed))
            {
                frm = new Frm_Tablero_Control();
            }
            frm.Focus();
            return frm;
        }
        public Frm_Tablero_Control()
        {
            InitializeComponent();
        }

        private void Frm_Tablero_Control_Load(object sender, EventArgs e)
        {
            ActualizarDatagrid();
        }

        public void ActualizarDatagrid()
        {
            bs_articulos.DataSource = admArt.DevolverVigentesBD();
            dgrid_IndicadorStock.DataSource = bs_articulos;
            dgrid_IndicadorStock.Columns[3].Visible = false;
            dgrid_IndicadorStock.Columns[4].Visible = false;
            dgrid_IndicadorStock.Columns[5].Visible = false;
            dgrid_IndicadorStock.Columns[0].HeaderText = "Código";
            dgrid_IndicadorStock.Columns[1].HeaderText = "Descripción";
            PintarIndicadorStock();
        }

        public void PintarIndicadorStock()
        {
            Crubro orubro;
            dgrid_IndicadorStock.GridColor = Color.Black;
            
            decimal stock;
            Carticulo oart = null;
            foreach (DataGridViewRow DR in dgrid_IndicadorStock.Rows)
            {
                oart = admArt.BuscarEnVigentes(DR.Cells[0].Value.ToString());
                stock= Convert.ToDecimal(dgrid_IndicadorStock.Rows[DR.Index].Cells[2].Value);
                if (stock <= 0)
                {
                    dgrid_IndicadorStock.Rows[DR.Index].Cells[0].Style.BackColor = Color.FromArgb(235, 48, 48);
                    dgrid_IndicadorStock.Rows[DR.Index].Cells[1].Style.BackColor = Color.FromArgb(235, 48, 48);
                    dgrid_IndicadorStock.Rows[DR.Index].Cells[2].Style.BackColor = Color.FromArgb(235, 48, 48);
                }
                else
                {
                    orubro = admRubro.BuscarPorID(Convert.ToInt32(DR.Cells[3].Value));
                    if (stock <= oart.CantBaja)
                    {
                        dgrid_IndicadorStock.Rows[DR.Index].Cells[0].Style.BackColor = Color.FromArgb(255, 133, 27);
                        dgrid_IndicadorStock.Rows[DR.Index].Cells[1].Style.BackColor = Color.FromArgb(255, 133, 27);
                        dgrid_IndicadorStock.Rows[DR.Index].Cells[2].Style.BackColor = Color.FromArgb(255, 133, 27);             
                    }
                    else
                    {
                        if (stock >= oart.CantAlta)
                        {
                            dgrid_IndicadorStock.Rows[DR.Index].Cells[0].Style.BackColor = Color.FromArgb(55, 178, 88);
                            dgrid_IndicadorStock.Rows[DR.Index].Cells[1].Style.BackColor = Color.FromArgb(55, 178, 88);
                            dgrid_IndicadorStock.Rows[DR.Index].Cells[2].Style.BackColor = Color.FromArgb(55, 178, 88);
                        }
                        else
                        {
                            dgrid_IndicadorStock.Rows[DR.Index].Cells[0].Style.BackColor = Color.FromArgb(234, 196, 29);
                            dgrid_IndicadorStock.Rows[DR.Index].Cells[1].Style.BackColor = Color.FromArgb(234, 196, 29);
                            dgrid_IndicadorStock.Rows[DR.Index].Cells[2].Style.BackColor = Color.FromArgb(234, 196, 29);
                        }
                    }
                }
            }
        } 
        
        private void dgrid_IndicadorStock_SelectionChanged(object sender, EventArgs e)
        {
            if (dgrid_IndicadorStock.SelectedRows.Count > 0)
            {
                if ((lbl_cantVendido.Text = dgrid_IndicadorStock.CurrentRow.Cells[5].Value.ToString())=="")
                {
                lbl_cantVendido.Text="0";
                }
                
                oArt = admArt.BuscarEnVigentes(dgrid_IndicadorStock.CurrentRow.Cells[0].Value.ToString());
                lbl_descripcion.Text = oArt.Descripcion;
                lbl_rubro.Text = oArt.Rubro.Nombre;
                lbl_iva.Text = oArt.Iva.ToString();
                lbl_precioSinIVA.Text = oArt.CalcularPrecioSinIVA().ToString();
                lbl_precioConIVA.Text = oArt.Precio.ToString();
                lbl_costoUni.Text = oArt.Costo.ToString();
                lbl_unidadMedida.Text = oArt.Unidad_Medida.ToString();
                lbl_unidadMedida2.Text = oArt.Unidad_Medida.ToString();
                lbl_margenBruto.Text = ((Convert.ToDecimal(lbl_precioSinIVA.Text)) - (Convert.ToDecimal(lbl_costoUni.Text))).ToString();
                lbl_estado.BackColor = dgrid_IndicadorStock.CurrentRow.Cells[0].Style.BackColor;
                lbl_CantidadReponer.Text=oArt.CantidadReponer().ToString();
                if (dgrid_IndicadorStock.CurrentRow.Cells[4].Value.ToString() == "")
                    lbl_ingresoVentas.Text = "0";
                else
                    lbl_ingresoVentas.Text = Math.Round(Convert.ToDecimal(dgrid_IndicadorStock.CurrentRow.Cells[4].Value),2).ToString();
                lbl_utilidad.Text = Math.Round((Convert.ToDecimal(lbl_cantVendido.Text) * Convert.ToDecimal(lbl_margenBruto.Text)),2).ToString();
                lbl_costosSoportados.Text = Math.Round((Convert.ToDecimal(lbl_cantVendido.Text) * Convert.ToDecimal(lbl_costoUni.Text)), 2).ToString();
            }
        }
       
        //METODOS OVERRIDE
        
        private void dgrid_IndicadorStock_Sorted(object sender, EventArgs e)
        {
            PintarIndicadorStock();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
                if (txt_busqueda.Text=="")
                {
                    ActualizarDatagrid();
                }
                else
                {
                    if(!txt_busqueda.Text.Contains("'"))
                    {
                    bs_articulos.ResetBindings(false);
                    bs_articulos.DataSource = admArt.DevolverVigentesBD(txt_busqueda.Text);
                    dgrid_IndicadorStock.DataSource = bs_articulos;
                    PintarIndicadorStock();
                    }
                }
                       
        }

        private void Frm_Tablero_Control_Shown(object sender, EventArgs e)
        {
            if (Form1.objConf.Version < 2)
            {
                Frm_confirmacion frm = new Frm_confirmacion("Esta opción se encuentra disponible a partir de la versión PRO, contáctenos a traves de nuestra página y/o facebook para ser PRO!", "Función no disponible", "Aceptar", "Ir a la página");
                frm.ShowDialog();
                if (frm.RESPUESTA != null)
                {
                    if (frm.RESPUESTA == "Ir a la página")
                    {
                        Process.Start("www.facebook.com/easysoftgt");
                    }
                }
                Close();
            }
        }

    }
}
