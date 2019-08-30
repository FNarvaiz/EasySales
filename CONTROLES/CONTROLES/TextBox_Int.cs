using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CONTROLES
{
    public partial class TextBox_Int : TextBox
    {
        string _TextDefault;

        // PROPIEDADES PERSONALIZADAS
        #region

        [Category("Mis Propiedades")]
        [Description("Texto predeterminado al quedar vacia la propiedad .TEXT ")]

        public string TextDefault
        {
            get { return _TextDefault; }
            set { _TextDefault = value; }
        }

        #endregion       

        public TextBox_Int()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text == "")
            {
                Text = TextDefault;
                SelectAll();
            }

            base.OnTextChanged(e);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            String Aceptados = "0123456789" + Convert.ToChar(13);

            if (Aceptados.Contains("" + e.KeyChar) || Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            base.OnKeyPress(e);
        }
        
    }
}
