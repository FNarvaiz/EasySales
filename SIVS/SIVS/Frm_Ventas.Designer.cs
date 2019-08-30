namespace SIVS
{
    partial class Frm_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bs_Ventas = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CajasDiarias = new System.Windows.Forms.BindingSource(this.components);
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgrid_CajasDiarias = new System.Windows.Forms.DataGridView();
            this.dgrid_Ventas = new System.Windows.Forms.DataGridView();
            this.p_fecha = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CajasDiarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CajasDiarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Ventas)).BeginInit();
            this.p_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(3, 7);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(405, 474);
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Visible = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(307, 474);
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Visible = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Eliminar.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Eliminar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Eliminar.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Eliminar.Location = new System.Drawing.Point(361, 7);
            this.btn_Eliminar.Size = new System.Drawing.Size(231, 32);
            this.btn_Eliminar.Text = "      Reporte de gastos y cobros";
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Modificar.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Modificar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Modificar.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Modificar.Location = new System.Drawing.Point(20, 7);
            this.btn_Modificar.Size = new System.Drawing.Size(155, 32);
            this.btn_Modificar.Text = "     Reporte cajas";
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Agregar.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Agregar.Location = new System.Drawing.Point(181, 7);
            this.btn_Agregar.Size = new System.Drawing.Size(174, 32);
            this.btn_Agregar.Text = "      Reporte de la caja";
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 462);
            this.pbtn.Size = new System.Drawing.Size(1192, 51);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.dgrid_Ventas);
            this.pn_abm.Controls.Add(this.label7);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.pn_abm.ForeColor = System.Drawing.Color.Black;
            this.pn_abm.Size = new System.Drawing.Size(409, 446);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_CajasDiarias);
            this.gb_abm.Controls.Add(this.p_fecha);
            this.gb_abm.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.gb_abm.Size = new System.Drawing.Size(759, 446);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(1192, 462);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(767, 8);
            this.p_derecho.Size = new System.Drawing.Size(417, 446);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(1182, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(10, 51);
            this.pn_btnDerechos.Visible = false;
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(1182, 51);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(1063, 0);
            // 
            // dtp_desde
            // 
            this.dtp_desde.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp_desde.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(344, 0);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(151, 32);
            this.dtp_desde.TabIndex = 29;
            this.dtp_desde.ValueChanged += new System.EventHandler(this.dtp_desde_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Mostrar todas las cajas diarias a partir del :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(409, 38);
            this.label1.TabIndex = 52;
            this.label1.Text = "Doble click sobre la venta para ver los artículos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(409, 32);
            this.label7.TabIndex = 58;
            this.label7.Text = "Ventas de la caja seleccionada";
            // 
            // dgrid_CajasDiarias
            // 
            this.dgrid_CajasDiarias.AllowUserToAddRows = false;
            this.dgrid_CajasDiarias.AllowUserToDeleteRows = false;
            this.dgrid_CajasDiarias.AllowUserToResizeRows = false;
            this.dgrid_CajasDiarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_CajasDiarias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_CajasDiarias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_CajasDiarias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_CajasDiarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_CajasDiarias.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_CajasDiarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_CajasDiarias.Location = new System.Drawing.Point(0, 47);
            this.dgrid_CajasDiarias.MultiSelect = false;
            this.dgrid_CajasDiarias.Name = "dgrid_CajasDiarias";
            this.dgrid_CajasDiarias.ReadOnly = true;
            this.dgrid_CajasDiarias.RowHeadersVisible = false;
            this.dgrid_CajasDiarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_CajasDiarias.Size = new System.Drawing.Size(759, 399);
            this.dgrid_CajasDiarias.TabIndex = 50;
            this.dgrid_CajasDiarias.SelectionChanged += new System.EventHandler(this.dgrid_CajasDiarias_SelectionChanged);
            // 
            // dgrid_Ventas
            // 
            this.dgrid_Ventas.AllowUserToAddRows = false;
            this.dgrid_Ventas.AllowUserToDeleteRows = false;
            this.dgrid_Ventas.AllowUserToResizeRows = false;
            this.dgrid_Ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Ventas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Ventas.Location = new System.Drawing.Point(0, 32);
            this.dgrid_Ventas.MultiSelect = false;
            this.dgrid_Ventas.Name = "dgrid_Ventas";
            this.dgrid_Ventas.ReadOnly = true;
            this.dgrid_Ventas.RowHeadersVisible = false;
            this.dgrid_Ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Ventas.Size = new System.Drawing.Size(409, 376);
            this.dgrid_Ventas.TabIndex = 59;
            this.dgrid_Ventas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_Ventas_MouseDoubleClick);
            // 
            // p_fecha
            // 
            this.p_fecha.Controls.Add(this.dtp_hasta);
            this.p_fecha.Controls.Add(this.label3);
            this.p_fecha.Controls.Add(this.dtp_desde);
            this.p_fecha.Controls.Add(this.label2);
            this.p_fecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_fecha.Location = new System.Drawing.Point(0, 10);
            this.p_fecha.Name = "p_fecha";
            this.p_fecha.Size = new System.Drawing.Size(759, 37);
            this.p_fecha.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(495, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 51;
            this.label3.Text = "hasta";
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp_hasta.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(548, 0);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(151, 32);
            this.dtp_hasta.TabIndex = 52;
            this.dtp_hasta.ValueChanged += new System.EventHandler(this.dtp_desde_ValueChanged);
            // 
            // Frm_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1192, 513);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_Ventas";
            this.Text = "Historial de cajas diarias con sus ventas";
            this.Load += new System.EventHandler(this.Frm_Ventas_Load);
            this.Shown += new System.EventHandler(this.Frm_Ventas_Shown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_Ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CajasDiarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CajasDiarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Ventas)).EndInit();
            this.p_fecha.ResumeLayout(false);
            this.p_fecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_Ventas;
        private System.Windows.Forms.BindingSource bs_CajasDiarias;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgrid_Ventas;
        private System.Windows.Forms.DataGridView dgrid_CajasDiarias;
        private System.Windows.Forms.Panel p_fecha;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.Label label3;
    }
}
