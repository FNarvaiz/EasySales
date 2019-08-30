namespace SIVS
{
    partial class Frm_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Items));
            this.bs_items = new System.Windows.Forms.BindingSource(this.components);
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_argumento = new System.Windows.Forms.Label();
            this.dgrid_items = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_items)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(442, 406);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.ImageEnableFalse = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_Cancelar.ImageOnMouseDown = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_Cancelar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Confirmar_32_Flip;
            this.btn_Cancelar.ImageOnNothing = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_Cancelar.Location = new System.Drawing.Point(424, 9);
            this.btn_Cancelar.Text = "     Aceptar";
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Guardar.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Guardar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Guardar.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Guardar.Location = new System.Drawing.Point(308, 9);
            this.btn_Guardar.Text = "      Imprimir";
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(13, 9);
            this.btn_Eliminar.Size = new System.Drawing.Size(206, 32);
            this.btn_Eliminar.Text = "      Eliminar venta";
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = null;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(109, 417);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Visible = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = null;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(11, 417);
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Visible = false;
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 400);
            // 
            // pn_abm
            // 
            this.pn_abm.Size = new System.Drawing.Size(71, 384);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_items);
            this.gb_abm.Controls.Add(this.lbl_argumento);
            this.gb_abm.Controls.Add(this.lbl);
            this.gb_abm.Size = new System.Drawing.Size(633, 384);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(728, 400);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(641, 8);
            this.p_derecho.Size = new System.Drawing.Size(79, 384);
            this.p_derecho.Visible = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl.Location = new System.Drawing.Point(0, 356);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(17, 28);
            this.lbl.TabIndex = 31;
            this.lbl.Text = " ";
            // 
            // lbl_argumento
            // 
            this.lbl_argumento.AutoSize = true;
            this.lbl_argumento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_argumento.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_argumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_argumento.Location = new System.Drawing.Point(0, 328);
            this.lbl_argumento.Name = "lbl_argumento";
            this.lbl_argumento.Size = new System.Drawing.Size(160, 28);
            this.lbl_argumento.TabIndex = 32;
            this.lbl_argumento.Text = "Costo Unitario :  $";
            // 
            // dgrid_items
            // 
            this.dgrid_items.AllowUserToAddRows = false;
            this.dgrid_items.AllowUserToDeleteRows = false;
            this.dgrid_items.AllowUserToResizeRows = false;
            this.dgrid_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_items.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_items.Location = new System.Drawing.Point(0, 0);
            this.dgrid_items.MultiSelect = false;
            this.dgrid_items.Name = "dgrid_items";
            this.dgrid_items.ReadOnly = true;
            this.dgrid_items.RowHeadersVisible = false;
            this.dgrid_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_items.Size = new System.Drawing.Size(633, 328);
            this.dgrid_items.TabIndex = 28;
            // 
            // Frm_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(728, 451);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_Items";
            this.Load += new System.EventHandler(this.Frm_Items_Load);
            this.pbtn.ResumeLayout(false);
            this.gb_abm.ResumeLayout(false);
            this.gb_abm.PerformLayout();
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_items;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_argumento;
        private System.Windows.Forms.DataGridView dgrid_items;
    }
}
