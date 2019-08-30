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
    public partial class ButtonImagesMetro : Button
    {
        private Image _press; //Imagen a mostrar cuando se ha precionado nuestro control
        private Image _over; //Imagen a mostrar cuando el puntero del mouse esta encima del control
        private Image _normal; //Imagen a mostrar cuando nuestro control esta en estado normal
        private Image _desabilitado; //Imagen a mostrar cuando nuestro control esta deshabilitado
        private int _extencion; // Cantidad de pixels q se agranda el boton
        private ContentAlignment alineacion = ContentAlignment.MiddleCenter;
        private int OriginalWidth;

        #region
        [Category("Mis Propiedades")]
        [Description(" Cantidad de pixels q se agranda el boton")]
        public int ExtencionWidth
        {
            get { return _extencion; }
            set { _extencion = value; }
        }
        [Category("Mis Propiedades")]
        [Description("Imagen A mostrar al Precionar el control")]
        public Image ImageOnMouseDown
        {
            get { return _press; }
            set { _press = value; }
        }
        [Category("Mis Propiedades")]
        [Description("Imagen cuando el mouse esta en el area del control")]
        public Image ImageOnMouseEnter
        {
            get { return _over; }
            set { _over = value; }
        }
        [Category("Mis Propiedades")]
        [Description("Imagen cuando el control estado en un estado normal")]
        public Image ImageOnNothing
        {
            get { return _normal; }
            set { _normal = value; }
        }
        [Category("Mis Propiedades")]
        [Description("Imagen a mostrar cuando el control esta desahabilitado")]
        public Image ImageEnableFalse
        {
            get { return _desabilitado; }
            set { _desabilitado = value; }
        }

        [Category("Mis Propiedades")]
        [Description("Alineacion texto")]

        public ContentAlignment Alineacion
        {
            get { return alineacion; }
            set { alineacion = value; }
        }

        #endregion

        public ButtonImagesMetro()
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
            OriginalWidth = Width;

            BackgroundImage = ImageOnMouseEnter;

            while (OriginalWidth + 30 > Width)
            {
                Width++;
            }
            base.OnMouseHover(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            BackgroundImage = ImageOnNothing;

            while (OriginalWidth < Width)
            {
                Width--;
            }
            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
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
        }
        protected override void OnEnabledChanged(EventArgs e)
        {
            base.OnEnabledChanged(e);
            if (!base.Enabled)
                BackgroundImage = ImageEnableFalse;
            else
                BackgroundImage =ImageOnNothing;   
        }
    }
}