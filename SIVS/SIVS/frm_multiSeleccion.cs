using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CLASES;
namespace SIVS
{
    public partial class frm_multiSeleccion : Form
    {
        List<Carticulo> _lista = new List<Carticulo>();
        List<int> _columnas;
        public List<Carticulo> Lista
        {
            get
            {
                return _lista;
            }
        }
        public frm_multiSeleccion(List<Carticulo> lista,List<int> columnasVisibles)
        {
            InitializeComponent();
            Text += "los artículos";
            bs_objetos.ResetBindings(false);
            bs_objetos.DataSource = lista;
            _columnas = columnasVisibles;
        }

        private void ActualizarGrilla()
        {
            dgrid_objetos.DataSource = bs_objetos;
            
            for (int x = 1; x < dgrid_objetos.Columns.Count; x++){
                dgrid_objetos.Columns[x].ReadOnly = true;
                dgrid_objetos.Columns[x].Visible=false;
            }
            foreach (int x in _columnas)
            {
                dgrid_objetos.Columns[x+1].Visible = true;
            }
            foreach (DataGridViewRow DR in dgrid_objetos.Rows)
            {
                DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)DR.Cells[0];
                celdaCheck.Value = false;
            }
        }

        private void btn_alta_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow DR in dgrid_objetos.Rows)
            {
                DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)DR.Cells[0];
                if ((Boolean)celdaCheck.Value)
                    _lista.Add((Carticulo)DR.DataBoundItem);
            }
            Close();
        }

        private void frm_multiSeleccion_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_todos_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow DR in dgrid_objetos.Rows)
            {
                DataGridViewCheckBoxCell celdaCheck = (DataGridViewCheckBoxCell)DR.Cells[0];
                celdaCheck.Value = true;
            }
        }
    }
}
