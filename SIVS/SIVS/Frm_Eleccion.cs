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
    public partial class Frm_Eleccion : Form
    {
        BindingSource BS_genrico;
        object obj = null;
        List<int> ocultar;

        public object ObjRespuesta
        {
            get
            {
                return obj;
            }
        }
        public Frm_Eleccion(string capcion,BindingSource BS)
        {
            InitializeComponent();
            Text = capcion;
            BS_genrico = BS;
        }
        public Frm_Eleccion(string capcion,string capcion2, BindingSource BS, List<int> ColumnasInvibles,string lblDescr)
        {
            InitializeComponent();
            Text = capcion;
            lbl_cap.Text = "Seleccione " + capcion2;
            BS_genrico = BS;
            ocultar = ColumnasInvibles;
            if (lblDescr != "")
                lbl_indicador.Text = lblDescr;
        }
        private void dgrid_FPagos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (dgrid_Generico.SelectedRows.Count > 0)
                {
                    int cal = (dgrid_Generico.Rows[0].Height * (dgrid_Generico.Rows.Count ))+28;
                    if (cal > e.Location.Y && e.Location.Y > 28)
                    {
                        obj = dgrid_Generico.CurrentRow.DataBoundItem;
                        Close();
                    }
                }
            }
            catch
            {
            }
        }
        private void Frm_Eleccion_Load(object sender, EventArgs e)
        {
            dgrid_Generico.DataSource = BS_genrico;
            if (ocultar != null)
            {
                foreach (int x in ocultar)
                {
                    dgrid_Generico.Columns[x].Visible = false;
                }
            }
        }
        private void dgrid_Generico_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==Convert.ToChar(13)){
                if(dgrid_Generico.Rows.Count>0){
                    obj = dgrid_Generico.CurrentRow.DataBoundItem;
                    Close();
                }
            }  
        }
      

        private void dgrid_Generico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgrid_Generico.Rows.Count > 0)
                {
                    obj = dgrid_Generico.CurrentRow.DataBoundItem;
                    Close();
                }
            }  
        }

        
    }

}
