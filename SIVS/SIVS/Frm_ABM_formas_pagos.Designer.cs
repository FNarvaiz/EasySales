namespace SIVS
{
    partial class Frm_ABM_formas_pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_formas_pagos));
            this.bs_pagos = new System.Windows.Forms.BindingSource(this.components);
            this.rb_descuento = new System.Windows.Forms.CheckBox();
            this.rb_Recargo = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_AlteraCaja = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Descripcion = new System.Windows.Forms.TextBox();
            this.txt_Porcentaje = new CONTROLES.TextBox_Decimal();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_autorizacion = new System.Windows.Forms.CheckBox();
            this.dgrid_FPagos = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_pagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_FPagos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(0, 10);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = null;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(137, 10);
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = null;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(21, 10);
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(247, 10);
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = null;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(131, 10);
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = null;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(15, 10);
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Size = new System.Drawing.Size(935, 51);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.cb_autorizacion);
            this.pn_abm.Controls.Add(this.label5);
            this.pn_abm.Controls.Add(this.txt_Porcentaje);
            this.pn_abm.Controls.Add(this.rb_descuento);
            this.pn_abm.Controls.Add(this.rb_Recargo);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.cb_AlteraCaja);
            this.pn_abm.Controls.Add(this.label3);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.label4);
            this.pn_abm.Controls.Add(this.txt_Descripcion);
            this.pn_abm.Size = new System.Drawing.Size(384, 331);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_FPagos);
            this.gb_abm.Size = new System.Drawing.Size(527, 331);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(935, 347);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(535, 8);
            this.p_derecho.Size = new System.Drawing.Size(392, 331);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(679, 0);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(679, 51);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(560, 0);
            // 
            // rb_descuento
            // 
            this.rb_descuento.AutoSize = true;
            this.rb_descuento.BackColor = System.Drawing.Color.Transparent;
            this.rb_descuento.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rb_descuento.Location = new System.Drawing.Point(15, 180);
            this.rb_descuento.Name = "rb_descuento";
            this.rb_descuento.Size = new System.Drawing.Size(111, 29);
            this.rb_descuento.TabIndex = 61;
            this.rb_descuento.Text = "Descuento";
            this.rb_descuento.UseVisualStyleBackColor = false;
            this.rb_descuento.CheckedChanged += new System.EventHandler(this.rb_descuento_CheckedChanged);
            // 
            // rb_Recargo
            // 
            this.rb_Recargo.AutoSize = true;
            this.rb_Recargo.BackColor = System.Drawing.Color.Transparent;
            this.rb_Recargo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rb_Recargo.Location = new System.Drawing.Point(15, 152);
            this.rb_Recargo.Name = "rb_Recargo";
            this.rb_Recargo.Size = new System.Drawing.Size(93, 29);
            this.rb_Recargo.TabIndex = 60;
            this.rb_Recargo.Text = "Recargo";
            this.rb_Recargo.UseVisualStyleBackColor = false;
            this.rb_Recargo.CheckedChanged += new System.EventHandler(this.rb_Recargo_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(161, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Porcentaje: %";
            // 
            // cb_AlteraCaja
            // 
            this.cb_AlteraCaja.AutoSize = true;
            this.cb_AlteraCaja.BackColor = System.Drawing.Color.Transparent;
            this.cb_AlteraCaja.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_AlteraCaja.Location = new System.Drawing.Point(15, 242);
            this.cb_AlteraCaja.Name = "cb_AlteraCaja";
            this.cb_AlteraCaja.Size = new System.Drawing.Size(110, 29);
            this.cb_AlteraCaja.TabIndex = 58;
            this.cb_AlteraCaja.Text = "Altera caja";
            this.cb_AlteraCaja.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "o descuento, el porcentaje del mismo y si altera";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Indique si la forma de pago dispone de recargo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.Location = new System.Drawing.Point(10, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 54;
            this.label4.Text = "Descripción:";
            // 
            // txt_Descripcion
            // 
            this.txt_Descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Descripcion.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_Descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Descripcion.Location = new System.Drawing.Point(120, 8);
            this.txt_Descripcion.MaxLength = 50;
            this.txt_Descripcion.Name = "txt_Descripcion";
            this.txt_Descripcion.Size = new System.Drawing.Size(245, 31);
            this.txt_Descripcion.TabIndex = 53;
            // 
            // txt_Porcentaje
            // 
            this.txt_Porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Porcentaje.CantDecimales = 2;
            this.txt_Porcentaje.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_Porcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_Porcentaje.Location = new System.Drawing.Point(282, 166);
            this.txt_Porcentaje.Name = "txt_Porcentaje";
            this.txt_Porcentaje.Size = new System.Drawing.Size(81, 31);
            this.txt_Porcentaje.TabIndex = 62;
            this.txt_Porcentaje.Text = "0";
            this.txt_Porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_Porcentaje.TextDefault = "0";
            this.txt_Porcentaje.TextChanged += new System.EventHandler(this.txt_Porcentaje_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.Location = new System.Drawing.Point(10, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 63;
            this.label5.Text = "el efectivo en caja.";
            // 
            // cb_autorizacion
            // 
            this.cb_autorizacion.AutoSize = true;
            this.cb_autorizacion.BackColor = System.Drawing.Color.Transparent;
            this.cb_autorizacion.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_autorizacion.Location = new System.Drawing.Point(131, 242);
            this.cb_autorizacion.Name = "cb_autorizacion";
            this.cb_autorizacion.Size = new System.Drawing.Size(249, 29);
            this.cb_autorizacion.TabIndex = 64;
            this.cb_autorizacion.Text = "Pedir código de autorización";
            this.cb_autorizacion.UseVisualStyleBackColor = false;
            // 
            // dgrid_FPagos
            // 
            this.dgrid_FPagos.AllowUserToAddRows = false;
            this.dgrid_FPagos.AllowUserToDeleteRows = false;
            this.dgrid_FPagos.AllowUserToResizeRows = false;
            this.dgrid_FPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_FPagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_FPagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_FPagos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_FPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_FPagos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_FPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_FPagos.Location = new System.Drawing.Point(0, 0);
            this.dgrid_FPagos.MultiSelect = false;
            this.dgrid_FPagos.Name = "dgrid_FPagos";
            this.dgrid_FPagos.ReadOnly = true;
            this.dgrid_FPagos.RowHeadersVisible = false;
            this.dgrid_FPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_FPagos.Size = new System.Drawing.Size(527, 331);
            this.dgrid_FPagos.TabIndex = 28;
            this.dgrid_FPagos.SelectionChanged += new System.EventHandler(this.dgrid_FPagos_SelectionChanged);
            // 
            // Frm_ABM_formas_pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(935, 398);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_formas_pagos";
            this.Text = "Administrar formas de pagos";
            this.Activated += new System.EventHandler(this.Frm_ABM_formas_pagos_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_formas_pagos_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_formas_pagos_Shown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_pagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_FPagos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_pagos;
        private System.Windows.Forms.CheckBox rb_descuento;
        private System.Windows.Forms.CheckBox rb_Recargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_AlteraCaja;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Descripcion;
        private CONTROLES.TextBox_Decimal txt_Porcentaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cb_autorizacion;
        private System.Windows.Forms.DataGridView dgrid_FPagos;
    }
}
