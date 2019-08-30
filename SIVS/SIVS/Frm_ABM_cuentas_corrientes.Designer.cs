namespace SIVS
{
    partial class Frm_ABM_cuentas_corrientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_cuentas_corrientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_Definicion = new System.Windows.Forms.Label();
            this.bs_personas = new System.Windows.Forms.BindingSource(this.components);
            this.l_indicacion = new System.Windows.Forms.Label();
            this.dgrid_personas = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_personas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_personas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(1156, 416);
            this.btn_Cancelar.Visible = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.Enabled = false;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(1070, 416);
            this.btn_Guardar.Visible = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Eliminar.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Eliminar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_Eliminar.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Eliminar.Location = new System.Drawing.Point(249, 10);
            this.btn_Eliminar.Size = new System.Drawing.Size(231, 32);
            this.btn_Eliminar.Text = "Nuevo prov / client / usuario";
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(12, 10);
            this.btn_Modificar.Text = "    Ver";
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = null;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Agregar.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.Location = new System.Drawing.Point(128, 10);
            this.btn_Agregar.Size = new System.Drawing.Size(115, 32);
            this.btn_Agregar.Text = "    Reporte";
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 361);
            this.pbtn.Size = new System.Drawing.Size(728, 48);
            // 
            // pn_abm
            // 
            this.pn_abm.Size = new System.Drawing.Size(2, 345);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_personas);
            this.gb_abm.Controls.Add(this.lbl_Definicion);
            this.gb_abm.Controls.Add(this.l_indicacion);
            this.gb_abm.Size = new System.Drawing.Size(702, 345);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(728, 361);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(710, 8);
            this.p_derecho.Size = new System.Drawing.Size(10, 345);
            this.p_derecho.Visible = false;
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(694, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(34, 48);
            this.pn_btnDerechos.Visible = false;
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(694, 48);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(571, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(123, 48);
            // 
            // lbl_Definicion
            // 
            this.lbl_Definicion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Definicion.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Definicion.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Definicion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Definicion.Location = new System.Drawing.Point(0, 0);
            this.lbl_Definicion.Name = "lbl_Definicion";
            this.lbl_Definicion.Size = new System.Drawing.Size(702, 28);
            this.lbl_Definicion.TabIndex = 38;
            this.lbl_Definicion.Text = "Proveedores";
            this.lbl_Definicion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // l_indicacion
            // 
            this.l_indicacion.BackColor = System.Drawing.Color.Transparent;
            this.l_indicacion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.l_indicacion.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.l_indicacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l_indicacion.Location = new System.Drawing.Point(0, 317);
            this.l_indicacion.Name = "l_indicacion";
            this.l_indicacion.Size = new System.Drawing.Size(702, 28);
            this.l_indicacion.TabIndex = 39;
            this.l_indicacion.Text = "Para ver los detalles de una Cta. Cte. haga doble clic sobre la misma";
            this.l_indicacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgrid_personas
            // 
            this.dgrid_personas.AllowUserToAddRows = false;
            this.dgrid_personas.AllowUserToDeleteRows = false;
            this.dgrid_personas.AllowUserToResizeRows = false;
            this.dgrid_personas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_personas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_personas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_personas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_personas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_personas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_personas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_personas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_personas.Location = new System.Drawing.Point(0, 28);
            this.dgrid_personas.MultiSelect = false;
            this.dgrid_personas.Name = "dgrid_personas";
            this.dgrid_personas.ReadOnly = true;
            this.dgrid_personas.RowHeadersVisible = false;
            this.dgrid_personas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_personas.Size = new System.Drawing.Size(702, 289);
            this.dgrid_personas.TabIndex = 39;
            this.dgrid_personas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_personas_MouseDoubleClick);
            // 
            // Frm_ABM_cuentas_corrientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(728, 409);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_cuentas_corrientes";
            this.Text = "Cuentas Corrientes";
            this.Activated += new System.EventHandler(this.Frm_ABM_cuentas_corrientes_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ABM_cuentas_corrientes_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ABM_cuentas_corrientes_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_cuentas_corrientes_Shown);
            this.pbtn.ResumeLayout(false);
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_personas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_personas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Definicion;
        private System.Windows.Forms.BindingSource bs_personas;
        private System.Windows.Forms.Label l_indicacion;
        private System.Windows.Forms.DataGridView dgrid_personas;
    }
}
