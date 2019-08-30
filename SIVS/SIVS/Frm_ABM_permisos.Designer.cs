namespace SIVS
{
    partial class Frm_ABM_permisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_permisos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bs_permisos = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.cb_admUsuarios = new System.Windows.Forms.CheckBox();
            this.cb_admClientes = new System.Windows.Forms.CheckBox();
            this.cb_compras = new System.Windows.Forms.CheckBox();
            this.cb_estadisticasytablero = new System.Windows.Forms.CheckBox();
            this.cb_admArticulos = new System.Windows.Forms.CheckBox();
            this.cb_admFormasPagos = new System.Windows.Forms.CheckBox();
            this.cb_cobrosypagos = new System.Windows.Forms.CheckBox();
            this.cb_admConfiguracion = new System.Windows.Forms.CheckBox();
            this.cb_admProveedores = new System.Windows.Forms.CheckBox();
            this.cb_admCtasCtes = new System.Windows.Forms.CheckBox();
            this.cb_todos = new System.Windows.Forms.CheckBox();
            this.dgrid_permisos = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_permisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_permisos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(0, 8);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(250, 8);
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(134, 8);
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(247, 8);
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(131, 8);
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(15, 8);
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 406);
            this.pbtn.Size = new System.Drawing.Size(886, 47);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.cb_todos);
            this.pn_abm.Controls.Add(this.cb_admCtasCtes);
            this.pn_abm.Controls.Add(this.cb_admProveedores);
            this.pn_abm.Controls.Add(this.cb_admConfiguracion);
            this.pn_abm.Controls.Add(this.cb_cobrosypagos);
            this.pn_abm.Controls.Add(this.cb_admFormasPagos);
            this.pn_abm.Controls.Add(this.cb_admArticulos);
            this.pn_abm.Controls.Add(this.cb_estadisticasytablero);
            this.pn_abm.Controls.Add(this.cb_compras);
            this.pn_abm.Controls.Add(this.cb_admClientes);
            this.pn_abm.Controls.Add(this.cb_admUsuarios);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.txt_nombre);
            this.pn_abm.Size = new System.Drawing.Size(360, 390);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_permisos);
            this.gb_abm.Size = new System.Drawing.Size(502, 390);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(886, 406);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(510, 8);
            this.p_derecho.Size = new System.Drawing.Size(368, 390);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(518, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(368, 47);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(518, 47);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(399, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 47);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 30;
            this.label1.Tag = "3";
            this.label1.Text = "Permiso (Rol) :";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Enabled = false;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(134, 9);
            this.txt_nombre.MaxLength = 30;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(212, 31);
            this.txt_nombre.TabIndex = 29;
            this.txt_nombre.Tag = "3";
            // 
            // cb_admUsuarios
            // 
            this.cb_admUsuarios.AutoSize = true;
            this.cb_admUsuarios.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admUsuarios.Location = new System.Drawing.Point(12, 58);
            this.cb_admUsuarios.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admUsuarios.Name = "cb_admUsuarios";
            this.cb_admUsuarios.Size = new System.Drawing.Size(272, 29);
            this.cb_admUsuarios.TabIndex = 31;
            this.cb_admUsuarios.Tag = "2";
            this.cb_admUsuarios.Text = "Administrar usuarios y permisos";
            this.cb_admUsuarios.UseVisualStyleBackColor = true;
            this.cb_admUsuarios.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_admClientes
            // 
            this.cb_admClientes.AutoSize = true;
            this.cb_admClientes.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admClientes.Location = new System.Drawing.Point(12, 213);
            this.cb_admClientes.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admClientes.Name = "cb_admClientes";
            this.cb_admClientes.Size = new System.Drawing.Size(179, 29);
            this.cb_admClientes.TabIndex = 32;
            this.cb_admClientes.Tag = "2";
            this.cb_admClientes.Text = "Administrar clientes";
            this.cb_admClientes.UseVisualStyleBackColor = true;
            this.cb_admClientes.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_compras
            // 
            this.cb_compras.AutoSize = true;
            this.cb_compras.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_compras.Location = new System.Drawing.Point(12, 244);
            this.cb_compras.Margin = new System.Windows.Forms.Padding(1);
            this.cb_compras.Name = "cb_compras";
            this.cb_compras.Size = new System.Drawing.Size(162, 29);
            this.cb_compras.TabIndex = 33;
            this.cb_compras.Tag = "2";
            this.cb_compras.Text = "Efectuar compras";
            this.cb_compras.UseVisualStyleBackColor = true;
            this.cb_compras.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_estadisticasytablero
            // 
            this.cb_estadisticasytablero.AutoSize = true;
            this.cb_estadisticasytablero.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_estadisticasytablero.Location = new System.Drawing.Point(12, 182);
            this.cb_estadisticasytablero.Margin = new System.Windows.Forms.Padding(1);
            this.cb_estadisticasytablero.Name = "cb_estadisticasytablero";
            this.cb_estadisticasytablero.Size = new System.Drawing.Size(268, 29);
            this.cb_estadisticasytablero.TabIndex = 34;
            this.cb_estadisticasytablero.Tag = "2";
            this.cb_estadisticasytablero.Text = "Estadisticas y tablero de control";
            this.cb_estadisticasytablero.UseVisualStyleBackColor = true;
            this.cb_estadisticasytablero.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_admArticulos
            // 
            this.cb_admArticulos.AutoSize = true;
            this.cb_admArticulos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admArticulos.Location = new System.Drawing.Point(12, 275);
            this.cb_admArticulos.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admArticulos.Name = "cb_admArticulos";
            this.cb_admArticulos.Size = new System.Drawing.Size(186, 29);
            this.cb_admArticulos.TabIndex = 35;
            this.cb_admArticulos.Tag = "2";
            this.cb_admArticulos.Text = "Administrar articulos";
            this.cb_admArticulos.UseVisualStyleBackColor = true;
            this.cb_admArticulos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_admFormasPagos
            // 
            this.cb_admFormasPagos.AutoSize = true;
            this.cb_admFormasPagos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admFormasPagos.Location = new System.Drawing.Point(12, 151);
            this.cb_admFormasPagos.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admFormasPagos.Name = "cb_admFormasPagos";
            this.cb_admFormasPagos.Size = new System.Drawing.Size(243, 29);
            this.cb_admFormasPagos.TabIndex = 36;
            this.cb_admFormasPagos.Tag = "2";
            this.cb_admFormasPagos.Text = "Administrar formas de pago";
            this.cb_admFormasPagos.UseVisualStyleBackColor = true;
            this.cb_admFormasPagos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_cobrosypagos
            // 
            this.cb_cobrosypagos.AutoSize = true;
            this.cb_cobrosypagos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_cobrosypagos.Location = new System.Drawing.Point(12, 120);
            this.cb_cobrosypagos.Margin = new System.Windows.Forms.Padding(1);
            this.cb_cobrosypagos.Name = "cb_cobrosypagos";
            this.cb_cobrosypagos.Size = new System.Drawing.Size(212, 29);
            this.cb_cobrosypagos.TabIndex = 37;
            this.cb_cobrosypagos.Tag = "2";
            this.cb_cobrosypagos.Text = "Efectuar cobros y pagos";
            this.cb_cobrosypagos.UseVisualStyleBackColor = true;
            this.cb_cobrosypagos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_admConfiguracion
            // 
            this.cb_admConfiguracion.AutoSize = true;
            this.cb_admConfiguracion.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admConfiguracion.Location = new System.Drawing.Point(12, 306);
            this.cb_admConfiguracion.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admConfiguracion.Name = "cb_admConfiguracion";
            this.cb_admConfiguracion.Size = new System.Drawing.Size(220, 29);
            this.cb_admConfiguracion.TabIndex = 38;
            this.cb_admConfiguracion.Tag = "2";
            this.cb_admConfiguracion.Text = "Cambiar configuraciones";
            this.cb_admConfiguracion.UseVisualStyleBackColor = true;
            this.cb_admConfiguracion.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_admProveedores
            // 
            this.cb_admProveedores.AutoSize = true;
            this.cb_admProveedores.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admProveedores.Location = new System.Drawing.Point(12, 89);
            this.cb_admProveedores.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admProveedores.Name = "cb_admProveedores";
            this.cb_admProveedores.Size = new System.Drawing.Size(217, 29);
            this.cb_admProveedores.TabIndex = 39;
            this.cb_admProveedores.Tag = "2";
            this.cb_admProveedores.Text = "Administrar proveedores";
            this.cb_admProveedores.UseVisualStyleBackColor = true;
            this.cb_admProveedores.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_admCtasCtes
            // 
            this.cb_admCtasCtes.AutoSize = true;
            this.cb_admCtasCtes.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_admCtasCtes.Location = new System.Drawing.Point(12, 337);
            this.cb_admCtasCtes.Margin = new System.Windows.Forms.Padding(1);
            this.cb_admCtasCtes.Name = "cb_admCtasCtes";
            this.cb_admCtasCtes.Size = new System.Drawing.Size(192, 29);
            this.cb_admCtasCtes.TabIndex = 40;
            this.cb_admCtasCtes.Tag = "2";
            this.cb_admCtasCtes.Text = "Administrar Ctas Ctes";
            this.cb_admCtasCtes.UseVisualStyleBackColor = true;
            this.cb_admCtasCtes.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // cb_todos
            // 
            this.cb_todos.AutoSize = true;
            this.cb_todos.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cb_todos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_todos.Location = new System.Drawing.Point(284, 322);
            this.cb_todos.Margin = new System.Windows.Forms.Padding(1);
            this.cb_todos.Name = "cb_todos";
            this.cb_todos.Size = new System.Drawing.Size(62, 43);
            this.cb_todos.TabIndex = 41;
            this.cb_todos.Tag = "1";
            this.cb_todos.Text = "Todos";
            this.cb_todos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cb_todos.UseVisualStyleBackColor = true;
            this.cb_todos.CheckedChanged += new System.EventHandler(this.cb_todos_CheckedChanged);
            // 
            // dgrid_permisos
            // 
            this.dgrid_permisos.AllowUserToAddRows = false;
            this.dgrid_permisos.AllowUserToDeleteRows = false;
            this.dgrid_permisos.AllowUserToResizeRows = false;
            this.dgrid_permisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_permisos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_permisos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_permisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_permisos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_permisos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_permisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_permisos.Location = new System.Drawing.Point(0, 0);
            this.dgrid_permisos.MultiSelect = false;
            this.dgrid_permisos.Name = "dgrid_permisos";
            this.dgrid_permisos.ReadOnly = true;
            this.dgrid_permisos.RowHeadersVisible = false;
            this.dgrid_permisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_permisos.Size = new System.Drawing.Size(502, 390);
            this.dgrid_permisos.TabIndex = 27;
            this.dgrid_permisos.SelectionChanged += new System.EventHandler(this.dgrid_permisos_SelectionChanged);
            // 
            // Frm_ABM_permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 453);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(902, 436);
            this.Name = "Frm_ABM_permisos";
            this.Text = "Administrar permisos";
            this.Activated += new System.EventHandler(this.Frm_ABM_permisos_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_permisos_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_permisos_Shown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_permisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_permisos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_permisos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.CheckBox cb_cobrosypagos;
        private System.Windows.Forms.CheckBox cb_admFormasPagos;
        private System.Windows.Forms.CheckBox cb_admArticulos;
        private System.Windows.Forms.CheckBox cb_estadisticasytablero;
        private System.Windows.Forms.CheckBox cb_compras;
        private System.Windows.Forms.CheckBox cb_admClientes;
        private System.Windows.Forms.CheckBox cb_admUsuarios;
        private System.Windows.Forms.CheckBox cb_admCtasCtes;
        private System.Windows.Forms.CheckBox cb_admProveedores;
        private System.Windows.Forms.CheckBox cb_admConfiguracion;
        private System.Windows.Forms.CheckBox cb_todos;
        private System.Windows.Forms.DataGridView dgrid_permisos;
    }
}
