using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CONTROL;
using CLASES;
namespace SIVS
{
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {

        }

        private void btn_VerificarCompras_Click(object sender, EventArgs e)
        {
            try
            {
                Ctrl_compras admCompras = Ctrl_compras.ClaseActiva();
                int cont= admCompras.VerificarTodas();
                Frm_confirmacion frm;
                if(cont>0)
                    frm = new Frm_confirmacion("Se ha verificado y se han corregido "+ cont+" compras.","Finish","Aceptar");
                else if(cont==0)
                    frm = new Frm_confirmacion("Se ha verificado todas las compras y no se detecto errores de calculos.","Finish","Aceptar");
                else
                    frm = new Frm_confirmacion("Se ha producido un error en el transcurso, llame a soporte.","Finish","Aceptar");
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "A surgido un temita", "Aceptar");
                frm.ShowDialog();
            }
        }
        private void btn_CalcularStock_Click(object sender, EventArgs e)
        {
            try
            {
                Ctrl_articulos admArticulos = Ctrl_articulos.ClaseActiva();
                
                int cont = admArticulos.VerificarStock();
                Frm_confirmacion frm;
                if (cont > 0)
                    frm = new Frm_confirmacion("Se ha verificado y se han corregido " + cont + " articulos.", "Finish", "Aceptar");
                else if (cont == 0)
                    frm = new Frm_confirmacion("Se ha verificado todas los articulos y no se detecto errores de calculos.", "Finish", "Aceptar");
                else
                    frm = new Frm_confirmacion("Se ha producido un error en el transcurso, llame a soporte.", "Finish", "Aceptar");
                frm.ShowDialog();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "A surgido un temita", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_CajasDiarias_Click(object sender, EventArgs e)
        {

        }
    }
}
