using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using CONTROL;
using CLASES;
namespace SIVS
{
    public partial class Frm_Activacion : Form
    {

        Ctrl_Resgitros adm = Ctrl_Resgitros.ClaseActiva();
        public Frm_Activacion()
        {
            InitializeComponent();
        }
        
        private void btn_activacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_nombre.Text != "")
                {
                    int V= adm.ClaveCorrecta(txt_nombre.Text);
                    if (V > 0)
                    {
                        adm.Agregar(new Cregistro(DateTime.Today, txt_nombre.Text));
                        Cconfiguracion oConf = Ctrl_configuraciones.Devolver();
                        oConf.Version = V;
                        Ctrl_configuraciones.Modificar(oConf);
                        Close();
                    }
                    else
                    {
                        Frm_confirmacion frm = new Frm_confirmacion("La clave ingresada es incorrecta.", "Clave", "Aceptar");
                        frm.ShowDialog();
                    }
                }
            }
            catch(Exception ex)
            {
                Frm_confirmacion frm = new Frm_confirmacion(ex.Message, "Factores", "Aceptar");
                frm.ShowDialog();
            }
        }

        private void btn_Soporte_Click(object sender, EventArgs e)
        {
            Process.Start("www.facebook.com/easysoftgt");
        }

        private void btn_Free_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
