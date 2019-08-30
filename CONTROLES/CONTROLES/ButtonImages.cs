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
    public partial class ButtonImages : Button
    {
        private Image press; //Imagen a mostrar cuando se ha precionado nuestro control
        private Image over; //Imagen a mostrar cuando el puntero del mouse esta encima del control
        private Image normal; //Imagen a mostrar cuando nuestro control esta en estado normal
        private Image Desabilitado; //Imagen a mostrar cuando nuestro control esta deshabilitado

        private Color _BackcolorOnNothing;
        private Color _BackcolorOnEnter;
        private Color _BackcolorMouseDown;
        private Color _BackcolorEnableFalse;

        private ContentAlignment alineacion=ContentAlignment.MiddleCenter;

        #region

        [Category("Mis Propiedades")]
        [Description("Imagen A mostrar al Precionar el control")]
        public Image ImageOnMouseDown
        {
            get { return press; }
            set { press = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Imagen cuando el mouse esta en el area del control")]
        public Image ImageOnMouseEnter
        {
            get { return over; }
            set { over = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Imagen cuando el control estado en un estado normal")]
        public Image ImageOnNothing
        {
            get { return normal; }
            set { normal = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Imagen a mostrar cuando el control esta desahabilitado")]
        public Image ImageEnableFalse
        {
            get { return Desabilitado; }
            set { Desabilitado = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Alineacion texto")]
        public ContentAlignment Alineacion
        {
            get { return alineacion; }
            set { alineacion = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Color a mostrar en el control normal")]
        public Color BackcolorOnNothing
        {
            get { return _BackcolorOnNothing; }
            set { _BackcolorOnNothing = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Color a mostrar al entrar en el control")]
        public Color BackcolorOnEnter
        {
            get { return _BackcolorOnEnter; }
            set { _BackcolorOnEnter = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Color a mostrar al precionar el control")]
        public Color BackcolorMouseDown
        {
            get { return _BackcolorMouseDown; }
            set { _BackcolorMouseDown = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Color a mostrar cuando el control tiene la propiedad ENABLE = FALSE")]
        public Color BackcolorEnableFalse
        {
            get { return _BackcolorEnableFalse; }
            set { _BackcolorEnableFalse = value; }
        }
        #endregion

        public ButtonImages()
        {
            InitializeComponent();
            
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            base.TextAlign = Alineacion;
        }

        public override ContentAlignment TextAlign
        {
            get
            {
                return base.TextAlign;
            }
            set
            {
                base.TextAlign = value;
            }
        }
        
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }
            set
            {
                base.BackgroundImage = value;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }
    
        protected override void OnMouseEnter(EventArgs e)
        {
        BackColor = BackcolorOnEnter;
        BackgroundImage = ImageOnMouseEnter;
        base.OnMouseHover(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
        BackColor = BackcolorOnNothing;
        BackgroundImage = ImageOnNothing;
        base.OnMouseLeave(e);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            BackColor = BackcolorMouseDown;
            BackgroundImage = ImageOnMouseDown;      
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            BackgroundImage = ImageOnMouseEnter;
            OnClick(EventArgs.Empty);
        }
        protected override void OnCreateControl()
        {
        base.OnCreateControl();
        base.BackgroundImage = ImageOnNothing;
        //base.FlatStyle = FlatStyle.Standard;
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!base.Enabled)
            {
                BackgroundImage = ImageEnableFalse;
                BackColor = BackcolorEnableFalse;
            }
            else
            {
                BackgroundImage = ImageOnNothing;
                BackColor = BackcolorOnNothing;
            }
        }
    }
}