namespace SIVS
{
    partial class Frm_ABM_localidades
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_localidades));
            this.bs_localidades = new System.Windows.Forms.BindingSource(this.components);
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrid_localidades = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_localidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_localidades)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(1, 8);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = null;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(122, 8);
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = null;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(6, 8);
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(240, 8);
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = null;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(124, 8);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = null;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(8, 8);
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 351);
            this.pbtn.Size = new System.Drawing.Size(728, 47);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.txt_nombre);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Padding = new System.Windows.Forms.Padding(10);
            this.pn_abm.Size = new System.Drawing.Size(226, 335);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_localidades);
            this.gb_abm.Size = new System.Drawing.Size(478, 335);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(728, 351);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(486, 8);
            this.p_derecho.Size = new System.Drawing.Size(234, 335);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(486, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(242, 47);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(486, 47);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(367, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 47);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(10, 35);
            this.txt_nombre.MaxLength = 20;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(206, 31);
            this.txt_nombre.TabIndex = 27;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Localidad:";
            // 
            // dgrid_localidades
            // 
            this.dgrid_localidades.AllowUserToAddRows = false;
            this.dgrid_localidades.AllowUserToDeleteRows = false;
            this.dgrid_localidades.AllowUserToResizeRows = false;
            this.dgrid_localidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_localidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_localidades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_localidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_localidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_localidades.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_localidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_localidades.Location = new System.Drawing.Point(0, 0);
            this.dgrid_localidades.MultiSelect = false;
            this.dgrid_localidades.Name = "dgrid_localidades";
            this.dgrid_localidades.ReadOnly = true;
            this.dgrid_localidades.RowHeadersVisible = false;
            this.dgrid_localidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_localidades.Size = new System.Drawing.Size(478, 335);
            this.dgrid_localidades.TabIndex = 27;
            this.dgrid_localidades.SelectionChanged += new System.EventHandler(this.dgrid_localidades_SelectionChanged);
            // 
            // Frm_ABM_localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 398);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_localidades";
            this.Text = "Administrar localidades";
            this.Activated += new System.EventHandler(this.Frm_ABM_localidades_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_localidades_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_localidades_Shown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_localidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_localidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_localidades;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrid_localidades;
    }
}
