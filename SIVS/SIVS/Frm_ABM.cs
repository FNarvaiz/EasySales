using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SIVS
{
    public partial class Frm_ABM : Form
    {
        //LinearGradientBrush brocha;
        int ancho = 0;
        int anchoAnchicado = 0;
        public Frm_ABM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MinimumSize = this.Size;
            ancho = Width;
            anchoAnchicado = gb_abm.Width+30;
            //Color Abajo = Color.FromArgb(230, 230, 230);
            //Color Arriba = Color.FromArgb(100, 190, 100);
            //brocha = new LinearGradientBrush(new Rectangle(0, 0, Width, Height), Arriba, Abajo, LinearGradientMode.Vertical);            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected virtual void btn_Agregar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = false;
            pn_btnABM.Visible = false;
            p_derecho.Visible = true;
            pn_btnDerechos.Visible = true;
        }

        protected virtual void btn_Cancelar_Click(object sender, EventArgs e)
        {
            gb_abm.Enabled = true;
            pn_btnDerechos.Visible = false;
            p_derecho.Visible = false;
            pn_btnABM.Visible = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void pn_btnDerechos_Paint(object sender, PaintEventArgs e)
        {

        }

        protected virtual void Frm_ABM_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue > 111 && e.KeyValue < 120)
            {

                if (112 == e.KeyValue)//F1   AGREGAR
                {
                    if (pn_btnABM.Visible && btn_Agregar.Enabled && btn_Agregar.Visible)
                        btn_Agregar.PerformClick();
                }
                else if (113 == e.KeyValue)//F2 MODIFICAR
                {
                    if (pn_btnABM.Visible && btn_Modificar.Enabled && btn_Modificar.Visible)
                        btn_Modificar.PerformClick();
                }
                else if (114 == e.KeyValue)//F3 ELIMINAR
                {
                    if (pn_btnABM.Visible && btn_Eliminar.Enabled && btn_Eliminar.Visible)
                        btn_Eliminar.PerformClick();
                }
                else if (115 == e.KeyValue)//F4 SALIR
                {
                    if (pn_btnABM.Visible && btn_Salir.Enabled && btn_Salir.Visible)
                        btn_Salir.PerformClick();
                }
                else if (118 == e.KeyValue)// F7 GUARDAR
                {
                    if (pn_btnDerechos.Visible && btn_Guardar.Enabled && btn_Guardar.Visible)
                        btn_Guardar.PerformClick();
                }
                else if (119 == e.KeyValue)//F8 CANCELAR
                {
                    if (pn_btnDerechos.Visible && btn_Cancelar.Enabled && btn_Cancelar.Visible)
                        btn_Cancelar.PerformClick();
                }
            }
        }



        //protected override void OnPaintBackground(PaintEventArgs e)
        //{
        //   e.Graphics.FillRectangle(brocha, e.ClipRectangle);
        //}

    }
}
