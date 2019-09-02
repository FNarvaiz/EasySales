using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;
using CLASES;
using CONTROL;

namespace SIVS
{
    public partial class Frm_ABM_articulos : SIVS.Frm_ABM
    {
        static Frm_ABM_articulos frmArt;
        Ctrl_articulos adm = Ctrl_articulos.ClaseActiva();
        Ctrl_rubros admrubro = Ctrl_rubros.ClaseActiva();
        Ctrl_medidas admmedida = Ctrl_medidas.ClaseActiva();
        public Carticulo oArt;
        Cmedida omedida;
        bool vigente;
        bool modoSeleccion=false;
        bool calcular = false;
        Cconfiguracion oConf;

        public static Frm_ABM_articulos AbrirForm(bool vigente,Cconfiguracion obconf)
        {
            if ((frmArt == null) || (frmArt.IsDisposed))
            {
                frmArt = new Frm_ABM_articulos(vigente,obconf);
            }
            return frmArt;
        }

        public Frm_ABM_articulos(bool vig,Cconfiguracion obconf)
        {
            InitializeComponent();
            vigente = vig;
            oConf = obconf;
        }

        public Frm_ABM_articulos(bool vig,bool modoseleccion)
        {
            modoSeleccion = modoseleccion;
            InitializeComponent();
            vigente = vig;
        }

        private void Frm_ABM_articulos_Load(object sender, EventArgs e)
        {            
            if (Tag.ToString()== "1")
            {
                if (!vigente)
                    adm.CargarNoVigentes();
                ActualizarDgrid();
                ActualizarRubros();
                ActualizarMedidas();
                Tag = 2;
            }
            if (modoSeleccion)
            {
                p_derecho.Visible = false;
                Height = 508;
                pbtn.Visible = false;
                btn_DarBaja.Visible = false;
            }
            else
            {
                //if (oConf.ExistenciaPorCompras)
                //{
                //    btn_stock.Visible = false;
                //    txt_stock.Enabled = false;
                //}
                txt_IVA.Text = oConf.IVA.ToString();
                txt_IVA.TextDefault = oConf.IVA.ToString();
                btn_Cancelar.PerformClick();
            }
        }

        private void Cerrar()
        {
            
            if (!oConf.ExistenciaPorCompras)
                btn_stock.Visible = true;
            txt_codigo.Clear();
            txt_precio.Clear();
            txt_descripcion.Clear();
            txt_costo.Clear();
            txt_stock.Clear();
            txt_nota.Clear();
            txt_PrecioConIva.Clear();
            oArt = null;
        }

        private void Abrir()
        {
            txt_codigo.Focus();
        }

        private void ActualizarDgrid()
        {
            try
            {
                bs_articulos.ResetBindings(false);
                
                if (vigente)
                {
                    bs_articulos.DataSource = adm.BuscarEnListaVigentesPorCodigo(txt_busquedaCodigo.Text);
                }
                else
                {
                    bs_articulos.DataSource = adm.DevolverListaNoVigentes();
                }
                
                dgrid_articulos.DataSource = bs_articulos;
                
                bs_articulos.Sort = "Descripcion ASC";
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }

            txt_busquedaCodigo.Focus();
        }
      

        private void ActualizarRubros()
        {
            bs_rubros.ResetBindings(false);
            bs_rubros.DataSource = admrubro.VerLista();
            cbb_Rubro.DataSource = bs_rubros;
            cbb_Rubro.DisplayMember = "Nombre";
        }

        private void ActualizarMedidas()
        {
            bs_medidas.ResetBindings(false);
            bs_medidas.DataSource = admmedida.VerLista();
            cb_medidas.DataSource = bs_medidas;
            cb_medidas.DisplayMember = "Nombre";
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                btn_Cancelar.PerformClick();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información al usuario", "Aceptar");
                frm.ShowDialog();
            }
        }

        protected new void btn_Agregar_Click(object sender, EventArgs e)
        {
            Abrir();
            txt_costo.Enabled = true;
            if(oConf.ExistenciaPorCompras)
                txt_stock.Text="0";
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            btn_Agregar.PerformClick();
            if (dgrid_articulos.SelectedRows.Count > 0)
            {
                //if (oConf.ExistenciaPorCompras)
                    //txt_costo.Enabled = false;
                oArt = (Carticulo)dgrid_articulos.CurrentRow.DataBoundItem;
                cbb_Rubro.SelectedItem = oArt.Rubro;
                cb_medidas.SelectedItem = oArt.Unidad_Medida;
                txt_codigo.Text = oArt.Codigo.ToString();
                txt_costo.Text = oArt.Costo.ToString();
                txt_descripcion.Text = oArt.Descripcion;
                txt_stock.Text = oArt.Stock.ToString();
                txt_IVA.Text = oArt.Iva.ToString();
                txt_cantBaja.Text = oArt.CantBaja.ToString();
                txt_cantMedia.Text = oArt.CantMedia.ToString();
                txt_cantAlta.Text = oArt.CantAlta.ToString();
                calcular = true;
                txt_PrecioConIva.Text = oArt.Precio.ToString();
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected new void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_articulos.SelectedRows.Count > 0)
                {
                    Carticulo obj = (Carticulo)dgrid_articulos.CurrentRow.DataBoundItem;


                    Frm_confirmacion frm = new Frm_confirmacion("Esta seguro de eliminar el artículo: " + obj.Descripcion + " ?", "Eliminación artículo", "No", "Si");

                    frm.ShowDialog();

                    if (frm.RESPUESTA == "Si")
                    {
                        bool TieneReferencia = adm.TieneReferencias((Carticulo)dgrid_articulos.CurrentRow.DataBoundItem);
                        if (TieneReferencia)
                        {
                            Frm_confirmacion frm2 = new Frm_confirmacion("El artículo seleccionado se encuentra referenciado en ventas y/o compras, por lo tanto es imposible su eliminación.\n Quiere darlde de baja?", "Referencia de un artículo", "No", "Si");
                            frm2.ShowDialog();
                            if (frm2.RESPUESTA == "Si")
                                btn_DarBaja_Click(sender, e);
                        }
                        else
                        {
                            adm.Eliminar((Carticulo)dgrid_articulos.CurrentRow.DataBoundItem, TieneReferencia, vigente);
                        }
                    }
                    ActualizarDgrid();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_stock_Click(object sender, EventArgs e)
        {
            Frm_Modificar_Stock FrmModificarStock = new Frm_Modificar_Stock();
            FrmModificarStock.Show();
        }

        private void txt_busqueda_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(((TextBox)sender).Tag) == 2)
            {//BUSQUEDA POR CODIGO
                if (txt_busquedaCodigo.Text == "")
                {
                    ActualizarDgrid();
                }
                else
                {
                    bs_articulos.ResetBindings(true);
                    bs_articulos.DataSource = adm.BuscarEnListaVigentesPorCodigo(txt_busquedaCodigo.Text);
                    dgrid_articulos.DataSource = bs_articulos;
                }
            }
            else
            {//BUSQUEDA POR DESCRIPCION
                if (txt_busquedaDescripcion.Text == "")
                {
                    ActualizarDgrid();
                }
                else
                {
                    bs_articulos.ResetBindings(true);
                    bs_articulos.DataSource = adm.BuscarEnListaVigentesPorDescripcion(txt_busquedaDescripcion.Text);
                    dgrid_articulos.DataSource = bs_articulos;
                }
            }

        }

        private void dgrid_articulos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                
                    DataGridView dgrid = (DataGridView)sender;
                    if (dgrid.SelectedRows.Count > 0)
                    {
                        int cal = (dgrid.Rows[0].Height * (dgrid.Rows.Count)) + 33;
                        if (cal > e.Location.Y && e.Location.Y > 33)
                        {
                            oArt =(Carticulo) dgrid.CurrentRow.DataBoundItem;
                            if (modoSeleccion)
                            {
                                Close();
                            }
                            else
                            {
                                Frm_confirmacion frm = new Frm_confirmacion("Descripción : " + oArt.Descripcion + "\nCódigo : " + oArt.Codigo + "\nStock : " + oArt.Stock + "\nCosto unitario : $ " + oArt.Costo + "\nIVA : % " + oArt.Iva + "\nPrecio unitario C/IVA : $ " + oArt.Precio + "\nRubro : " + oArt.Rubro + "\nUnidad de medida : " + oArt.Unidad_Medida + "\nNota : " + oArt.Nota, "Datos del artículo", "Aceptar");
                                frm.ShowDialog();
                            }
                        }
                    }
                    //if (dgrid_articulos.SelectedRows.Count > 0)
                    //{
                    //    int cal = (dgrid_articulos.Rows[0].Height * (dgrid_articulos.Rows.Count))+28;
                    //    //int cal= dgrid_articulos.Rows.GetRowsHeight(DataGridViewElementStates.Displayed);
                    //    if (cal > e.Location.Y && e.Location.Y > 28)
                    //    {
                            
                    //    }
                    //}
                
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_VerBajas_Click(object sender, EventArgs e)
        {
            adm.CargarNoVigentes();
            BindingSource bs = new BindingSource();
            bs.DataSource = adm.DevolverListaNoVigentes();
            List<int> columnasAocultar = new List<int>();
            for (int cont = 3; cont < 6; cont++)
                columnasAocultar.Add(cont);
            Frm_Eleccion frm = new Frm_Eleccion("Articulos dados de bajas","el artículo", bs, columnasAocultar,"Doble click para dar de alta.");
            frm.ShowDialog();
            if (frm.ObjRespuesta != null)
            {
                adm.Modificar((Carticulo)frm.ObjRespuesta, true);
                ActualizarDgrid();
            }
        }

        private void btn_DarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgrid_articulos.SelectedRows.Count > 0)
                {
                    Carticulo obj = (Carticulo)dgrid_articulos.CurrentRow.DataBoundItem;
                    adm.Modificar(obj, false);
                    ActualizarDgrid();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Bueno, esto es embarazoso. Pero lo solucionaremos :)", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {
            if (calcular)
            {
                calcular = false;
                if (Convert.ToDecimal(txt_IVA.Text) >= 100)
                    txt_IVA.Text = "99,99";
                else
                {
                    decimal preciosiniva = Convert.ToDecimal(txt_precio.Text);
                    decimal iva = (Convert.ToDecimal(txt_IVA.Text) / 100) + 1;
                    txt_PrecioConIva.Text = Math.Round((preciosiniva * iva), 2).ToString();
                }
            }
        }

        private void Calcular(object sender, KeyPressEventArgs e)
        {
            calcular = true;
            txt_codigo_KeyPress(sender, e);
        }

        private void txt_PrecioConIva_TextChanged(object sender, EventArgs e)
        {
            if (calcular)
            {
                calcular = false;
                decimal precioconiva = Convert.ToDecimal(txt_PrecioConIva.Text);
                decimal iva = (Convert.ToDecimal(txt_IVA.Text) / 100) + 1;
                txt_precio.Text = Math.Round((precioconiva / iva),2).ToString();
            }
        }

        private void cb_medidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            omedida = (Cmedida)cb_medidas.SelectedItem;
            if (omedida != null)
            {
                if (omedida.Entero)
                {
                    if (txt_stock.Text.Contains(","))
                    {
                        txt_stock.Text = Math.Round(Convert.ToDecimal(txt_stock.Text)).ToString();
                    }
                }
            }
        }


        private void txt_stock_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (omedida.Entero)
            {
                if (e.KeyChar == ',')
                {
                    e.Handled = true;
                }
            }
            txt_codigo_KeyPress(sender, e);
        }

        private void lbl_rubro_Click(object sender, EventArgs e)
        {
            Frm_ABM_rubros frm = Frm_ABM_rubros.AbrirForm();
            frm.ShowDialog();
            ActualizarRubros();
        }

        private void lbl_medida_Click(object sender, EventArgs e)
        {
            Frm_ABM_medidas frm = Frm_ABM_medidas.AbrirForm();
            frm.ShowDialog();
            ActualizarMedidas();
        }

        private void btn_Reporte_Click(object sender, EventArgs e)
        {
            Reportes.R_Articulos frm = new Reportes.R_Articulos(4);
            frm.ShowDialog();
        }

        private void btn_GuardarMas_Click(object sender, EventArgs e)
        {
            try
            {
                Guardar();
                txt_codigo.Focus();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información al usuario", "Aceptar");
                frm.ShowDialog();
            }
        }
        void Guardar()
        {
            try
            {
                Crubro orubro = (Crubro)cbb_Rubro.SelectedItem;
                Cmedida omedida = (Cmedida)cb_medidas.SelectedItem;
                Carticulo oArtNuevo = new Carticulo(txt_codigo.Text, txt_descripcion.Text, Convert.ToDecimal(txt_PrecioConIva.Text), Convert.ToDecimal(txt_costo.Text), Convert.ToDecimal(txt_stock.Text), orubro, omedida, Convert.ToDecimal(txt_IVA.Text), txt_nota.Text, Convert.ToDecimal(txt_cantAlta.Text), Convert.ToDecimal(txt_cantMedia.Text), Convert.ToDecimal(txt_cantBaja.Text));
                
                if (oArt == null)
                {
                    adm.Agregar(oArtNuevo);
                }
                else
                {
                    adm.Modificar(oArt, oArtNuevo);                        
                }             

                txt_codigo.Clear();
                oArt = null;
                ActualizarDgrid();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información al usuario", "Aceptar");
                frm.ShowDialog();
            }

        }

        private void Frm_ABM_articulos_KeyDown(object sender, KeyEventArgs e)
        {
            if (modoSeleccion)
            {
                if (e.KeyCode == Keys.Enter)
                {

                    if (dgrid_articulos.Rows.Count > 0)
                    {
                        oArt = (Carticulo)dgrid_articulos.CurrentRow.DataBoundItem;
                        Close();
                    }
                }
            }
            else
            {
                if (e.KeyValue > 114 && e.KeyValue < 117)
                {

                    if (115 == e.KeyValue)//F5   REPORTE
                    {

                        if (pn_btnABM.Visible && btn_Reporte.Enabled && btn_Reporte.Visible)
                            btn_Reporte.PerformClick();
                    }
                    else if (116 == e.KeyValue)//F6   GUARDAR MAS
                    {

                        if (pn_btnDerechos.Visible && btn_GuardarMas.Enabled && btn_GuardarMas.Visible)
                            btn_GuardarMas.PerformClick();
                    }
                    else 
                    {
                        txt_busquedaDescripcion.Focus();
                    }
                }
            }          
        }


        private void Frm_ABM_articulos_Activated(object sender, EventArgs e)
        {
            if (txt_busquedaCodigo.Text == "" && txt_busquedaDescripcion.Text == "")
                ActualizarDgrid();
            if (modoSeleccion)
            {
                txt_busquedaDescripcion.Focus();
           }

        }

        private void buttonImages1_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> columnasVisibles = new List<int>();
                columnasVisibles.Add(2);
                columnasVisibles.Add(5);
                frm_multiSeleccion frm = new frm_multiSeleccion(adm.DevolverListaVigentes(), columnasVisibles);
                frm.ShowDialog();
                if (frm.Lista.Count > 0)
                {
                    Reportes.R_PreciosParaGondola frmR = new Reportes.R_PreciosParaGondola(frm.Lista);
                    frmR.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información al usuario", "Aceptar");
                frm.ShowDialog();
            }

        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SendKeys.Send("{TAB}");
                e.Handled = true;
            }
        }


        private void txt_codigo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (oArt == null)
                {
                    Carticulo obj = adm.BuscarEnVigentes(txt_codigo.Text);
                    if (obj != null)
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("El artículo ya existe en la lista, verifique los datos.", "Información al usuario", "Aceptar");
                        frm.ShowDialog();
                    }
                }
                e.Handled = true;
                txt_codigo_KeyPress(sender, e);
            }
        }

        private void btn_Salir_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_modificarPrecios_Click(object sender, EventArgs e)
        {
            try{
                List<Carticulo> lista = new List<Carticulo>();
                foreach (DataGridViewRow DR in dgrid_articulos.SelectedRows)
                        lista.Add((Carticulo)DR.DataBoundItem);
                Frm_confirmacion frm = new Frm_confirmacion("Ingrese el nuevo precio:", "Modificación de precio", "Guardar", true, true);
                frm.ShowDialog();
                if (frm.RESPUESTA == "Guardar")
                {
                    adm.ModificarPreciosMultiples(lista, Convert.ToDecimal(frm.NUMERO));
                    ActualizarDgrid();
                }
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Información al usuario", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void Frm_ABM_articulos_ResizeEnd(object sender, EventArgs e)
        {
            if (dgrid_articulos.Columns.Count > 0)
            {
                if (dgrid_articulos.Width > dgrid_articulos.Columns.GetColumnsWidth(DataGridViewElementStates.Displayed))
                    dgrid_articulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                else
                    dgrid_articulos.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void Frm_ABM_articulos_Shown(object sender, EventArgs e)
        {
            txt_busquedaCodigo.Focus();
        }
    }
}
