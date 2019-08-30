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
    public partial class Frm_confirmacion : Form
    {
        string Arg;
        string Cap;
        string op1;
        string op2;
        string op3;
        string respuesta;
        string Numero;
        bool mostrarchar = false;
        bool mostrartxt = false;

        public Frm_confirmacion(string argumento, string capcion, string opcion1, string opcion2, string opcion3)
        {
            Arg = argumento;
            Cap = capcion;
            op1 = opcion1;
            op2 = opcion2;
            op3 = opcion3;
            InitializeComponent();
        }
        public Frm_confirmacion(string argumento, string capcion, string opcion1, string opcion2)
        {
            Arg = argumento;
            Cap = capcion;
            op1 = opcion1;
            op2 = opcion2;
            InitializeComponent();
        }
        public Frm_confirmacion(string argumento, string capcion, string opcion1)
        {
            Arg = argumento;
            Cap = capcion;
            op1 = opcion1;
            InitializeComponent();
        }
        public Frm_confirmacion(string argumento, string capcion, string opcion1, bool txtvisible, bool mostrarchars)
        {
            Arg = argumento;
            Cap = capcion;
            op1 = opcion1;
            mostrartxt = txtvisible;
            mostrarchar = mostrarchars;
            InitializeComponent();
        }
        public string RESPUESTA
        {
            set
            {
                respuesta = value;
            }
            get
            {
                return respuesta;
            }
        }
        public string NUMERO
        {
            get
            {
                return Numero;
            }
        }
        private void Frm_confirmacion_Load(object sender, EventArgs e)
        {
            txt_importe.Visible = mostrartxt;
            if (!mostrarchar)
            {
                txt_importe.PasswordChar = '*';
                txt_importe.MaxLength = 4;
                txt_importe.TextDefault = "";
                txt_importe.Text = "";
            }
            btn_op1.Text = "      " + op1;
            if (op1 == "Aceptar")
            {
                btn_op1.BackgroundImage = SIVS.Properties.Resources.Confirmar_32;
                btn_op1.ImageOnNothing = btn_op1.BackgroundImage;
                btn_op1.ImageOnMouseEnter = SIVS.Properties.Resources.Confirmar_32_Flip;
                btn_op1.ImageOnMouseDown = btn_op1.BackgroundImage;
            }
            else
            {
                if (op1 == "No")
                {
                    btn_op1.BackgroundImage = SIVS.Properties.Resources.Cancelar;
                    btn_op1.ImageOnNothing = btn_op1.BackgroundImage;
                    btn_op1.ImageOnMouseEnter = SIVS.Properties.Resources.Cancel_flip30;
                    btn_op1.ImageOnMouseDown = btn_op1.BackgroundImage;
                }
            }
            if (op2 == null)
                btn_op2.Visible = false;
            else
            {
                btn_op2.Text = op2;
                if (op2 == "Si")
                {
                    btn_op2.BackgroundImage = SIVS.Properties.Resources.Confirmar_32;
                    btn_op2.ImageOnNothing = btn_op2.BackgroundImage;
                    btn_op2.ImageOnMouseEnter = SIVS.Properties.Resources.Confirmar_32_Flip;
                    btn_op2.ImageOnMouseDown = btn_op2.BackgroundImage;
                }
            }
            if (op3 == null)
                btn_op3.Visible = false;
            else
                btn_op3.Text = op3;
            this.Text = Cap;
            lbl_argumento.Text = Arg;
            Height = 132 + lbl_argumento.Height;

        }


        private void btn_op1_Click(object sender, EventArgs e)
        {
            if (txt_importe.Visible)
                Numero = txt_importe.Text;
            respuesta = op1;
            Close();
        }

        private void btn_op2_Click(object sender, EventArgs e)
        {
            respuesta = op2;
            Close();
        }

        private void btn_op3_Click(object sender, EventArgs e)
        {
            respuesta = op3;
            Close();
        }

        private void txt_importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
                btn_op1_Click(sender, e);
        }

        private void Frm_confirmacion_Activated(object sender, EventArgs e)
        {
            if (txt_importe.Visible)
                txt_importe.Focus();
        }

    }
}
