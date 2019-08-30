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
    public partial class Frm_ActualizarPrecios : Form
    {
        public Frm_ActualizarPrecios()
        {
            InitializeComponent();
        }
        Ctrl_rubros admRubros = Ctrl_rubros.ClaseActiva();
        Ctrl_ActualizarPrecios admActualizarPrecios = new Ctrl_ActualizarPrecios();
        private void ActualizarRubros()
        {
            bs_CbbRubros.ResetBindings(false);
            bs_CbbRubros.DataSource = admRubros.VerLista();
            cbb_Rubros.DataSource = bs_CbbRubros;
            cbb_Rubros.DisplayMember = "Nombre";
        }
        private void ActualizarDgridRubros()
        {
            bs_DgridRubros.ResetBindings(false);
            bs_DgridRubros.DataSource = admActualizarPrecios.RubrosSeleccionados();
            dgrid_Rubros.DataSource = bs_DgridRubros;
            

        }
        private void ActualizarDgridArticulos(List<Carticulo> L)
        {
            bs_Articulos.ResetBindings(false);
            bs_Articulos.DataSource = L;
            dgrid_Articulos.DataSource = bs_Articulos;
            dgrid_Articulos.Columns[0].Visible = false;
            dgrid_Articulos.Columns[3].Visible = false;
            dgrid_Articulos.Columns[4].Visible = false;
            dgrid_Articulos.Columns[6].Visible = false;
            dgrid_Articulos.Columns[7].Visible = false;
            dgrid_Articulos.Columns[8].Visible = false;
            dgrid_Articulos.Columns[9].Visible = false;
            dgrid_Articulos.Columns[10].Visible = false;
            dgrid_Articulos.Columns[11].Visible = false;
        }
        private void ActualizarDgridArticulosActualizados(List<Carticulo> L)
        {
            bs_ArticulosActualizados.ResetBindings(false);
            bs_ArticulosActualizados.DataSource = L;
            dgrid_ArticulosActualizados.DataSource = bs_ArticulosActualizados;
            dgrid_ArticulosActualizados.Columns[0].Visible = false;
            dgrid_ArticulosActualizados.Columns[3].Visible = false;
            dgrid_ArticulosActualizados.Columns[4].Visible = false;
            dgrid_ArticulosActualizados.Columns[6].Visible = false;
            dgrid_ArticulosActualizados.Columns[7].Visible = false;
            dgrid_ArticulosActualizados.Columns[8].Visible = false;
            dgrid_ArticulosActualizados.Columns[9].Visible = false;
            dgrid_ArticulosActualizados.Columns[10].Visible = false;
            dgrid_ArticulosActualizados.Columns[11].Visible = false;
        }

        private void Frm_ActualizarPrecios_Load(object sender, EventArgs e)
        {
            ActualizarRubros();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgridArticulos(admActualizarPrecios.AgregarAtirculosPorRubro((Crubro)cbb_Rubros.SelectedItem));
                ActualizarDgridRubros();
            }
            catch(Exception ex)
            {
                Frm_confirmacion form = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                form.ShowDialog();
            }
        }

        private void btn_QuitarRubro_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_Rubros.SelectedRows.Count > 0)
                {
                    ActualizarDgridArticulos(admActualizarPrecios.QuitarArticulosPorRubro((Crubro)dgrid_Rubros.CurrentRow.DataBoundItem));
                    ActualizarDgridRubros();
                }
                else
                    throw new Exception("No selecciono ningun rubro para quitar.");
            }
            catch (Exception ex)
            {
                Frm_confirmacion form = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                form.ShowDialog();
            }

        }

        private void btn_QuitarArticulo_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_Articulos.SelectedRows.Count > 0)
                {
                    ActualizarDgridArticulos(admActualizarPrecios.QuitarArticulo((Carticulo)dgrid_Articulos.CurrentRow.DataBoundItem));
                }
                else
                    throw new Exception("No selecciono ningun artículo para quitar.");

            }
            catch (Exception ex)
            {
                Frm_confirmacion form = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                form.ShowDialog();
            }
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            if (rb_Porcentaje.Checked)
            {
                if (Convert.ToDecimal(txt_valor.Text) > 100)
                    txt_valor.Text = "100";
            }
        }

        private void rb_Porcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_Porcentaje.Checked)
            {
                if (Convert.ToDecimal(txt_valor.Text) > 100)
                    txt_valor.Text = "100";
            }
        }

        private void btn_GenerarVista_Click(object sender, EventArgs e)
        {
            try
            {
                ActualizarDgridArticulosActualizados(admActualizarPrecios.GenerarVistaPrevia(Convert.ToDecimal(txt_valor.Text),rb_Porcentaje.Checked,rb_Incremento.Checked,cb_Redondear.Checked));
                lbl_totalActualizado.Text = admActualizarPrecios.totalAct.ToString();
                lbl_Total.Text = admActualizarPrecios.totalDes.ToString();
                lbl_Diferencia.Text = admActualizarPrecios.diferencia.ToString();
            }
            catch (Exception ex)
            {
                Frm_confirmacion form = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                form.ShowDialog();
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                admActualizarPrecios.GuardarCambios();
                Close();
            }
            catch (Exception ex)
            {
                Frm_confirmacion form = new Frm_confirmacion(ex.Message, "Información", "Aceptar");
                form.ShowDialog();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
