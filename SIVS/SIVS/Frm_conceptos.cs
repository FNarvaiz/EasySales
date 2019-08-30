using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SIVS
{
    public partial class Frm_conceptos : Form
    {
        
        string _descripcion;
        bool _guardar=false;
        public string Descripcion
        {
            get
            {
                return _descripcion;
            }
        }
        public bool Guardar
        {
            get
            {
                return _guardar;
            }
        }
        public Frm_conceptos()
        {
            
            InitializeComponent();
        }
        
        private void Frm_conceptos_Load(object sender, EventArgs e)
        {
            
        }


 

        

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            _descripcion = txt_nombre.Text;
            _guardar=true;
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Frm_conceptos_Shown(object sender, EventArgs e)
        {
            txt_nombre.Focus();
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                btn_guardar_Click(sender, e);
        }

    }
}
