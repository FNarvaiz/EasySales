using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIVS
{
    public partial class Frm_graficos : Form
    {
        cGrafico _obj;

        public Frm_graficos(cGrafico obj)
        {
            InitializeComponent();
            _obj = obj;
        }

        private void frm_grafico_Shown(object sender, EventArgs e)
        {
            cb_graficos.Text = "Torta";
            cb_graficos.SelectedIndexChanged += new System.EventHandler(cb_graficos_SelectedIndexChanged);
            _obj.Graficar(c_generico, cb_graficos.SelectedIndex);
        }

        private void cb_graficos_SelectedIndexChanged(object sender, EventArgs e)
        {
            _obj.Graficar(c_generico, cb_graficos.SelectedIndex);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                System.Drawing.Bitmap ImagenPanel = new Bitmap(p_interiorIzquierdo.Width, p_interiorIzquierdo.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
                System.IO.MemoryStream STREAM = new System.IO.MemoryStream();
                p_interiorIzquierdo.DrawToBitmap(ImagenPanel, new Rectangle(0, 0, p_interiorIzquierdo.Width, p_interiorIzquierdo.Height));
                SaveFileDialog frm = new SaveFileDialog();
                frm.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp";
                frm.Title = "Guardar imagen";
                frm.FileName = "Nueva Imagen";
                frm.ShowDialog();
                if (frm.FileName != null)
                    ImagenPanel.Save(frm.OpenFile(), System.Drawing.Imaging.ImageFormat.Bmp);
                frm.Dispose();
            }
            catch (Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion( ex.Message,"Mensaje","Aceptar");
                frm.ShowDialog();
            } 
        }

       

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_3d_CheckedChanged(object sender, EventArgs e)
        {
            _obj.TresDe(c_generico, cb_3d.Checked);
        }
    }
}
