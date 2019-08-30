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
    public partial class TextBox_Decimal : TextBox
    {
        string _TextDefault;
        int _CantDecimal=2;

        // PROPIEDADES PERSONALIZADAS
        #region

        [Category("Mis Propiedades")]
        [Description("Texto predeterminado al quedar vacia la propiedad .TEXT ")]
        
        public string TextDefault
        {
            get { return _TextDefault; }
            set { _TextDefault = value; }
        }
        [Category("Mis Propiedades")]
        [Description("Cantidad de decimales que acepta el control.")]

        public int CantDecimales
        {
            get { return _CantDecimal; }
            set { _CantDecimal = value; }
        }

        #endregion       

        public TextBox_Decimal()
        {
            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            if (Text == "")
            {
                Text = TextDefault;
                SelectAll();
            }
            else if(Text.Contains(","))
            {
                if (Text.Length == 1)
                {
                    Text = "0,";
                    this.SelectionStart = 2;
                }
                else
                {
                    int tope = Text.IndexOf(",") + _CantDecimal + 1;
                    if (Text.Length > tope)
                    {
                        int cursor = this.SelectionStart;
                        Text = Text.Remove(tope);
                        this.SelectionStart = cursor;
                    }
                }
            }
            base.OnTextChanged(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            String Aceptados = "0123456789,."+Convert.ToChar(13);
            if (Aceptados.Contains("" + e.KeyChar)||Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {

                    e.KeyChar = ',';
                        if (this.Text.Contains(","))
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            e.Handled = false;
                        }
                }
                else
                {
                    e.Handled = false;
                }

            }
            else
            {
                e.Handled = true;
            }
            

            base.OnKeyPress(e);
        }          
    }
}
