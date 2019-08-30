namespace SIVS
{
    partial class Frm_Tablero_Control_Ventas_Articulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgrid_ventas = new System.Windows.Forms.DataGridView();
            this.p_buscador = new System.Windows.Forms.Panel();
            this.cb_FiltrarRubro = new System.Windows.Forms.CheckBox();
            this.cbb_Rubro = new System.Windows.Forms.ComboBox();
            this.btn_Buscar = new CONTROLES.ButtonImages();
            this.dtp_cajas_hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_cajas_desde = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.bs_rubros = new System.Windows.Forms.BindingSource(this.components);
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ventas)).BeginInit();
            this.p_buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Controls.Add(this.dgrid_ventas);
            this.panel6.Controls.Add(this.p_buscador);
            this.panel6.Controls.Add(this.label28);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.panel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.Location = new System.Drawing.Point(10, 10);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(841, 453);
            this.panel6.TabIndex = 123;
            // 
            // dgrid_ventas
            // 
            this.dgrid_ventas.AllowUserToAddRows = false;
            this.dgrid_ventas.AllowUserToDeleteRows = false;
            this.dgrid_ventas.AllowUserToResizeRows = false;
            this.dgrid_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_ventas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_ventas.Location = new System.Drawing.Point(0, 82);
            this.dgrid_ventas.MultiSelect = false;
            this.dgrid_ventas.Name = "dgrid_ventas";
            this.dgrid_ventas.ReadOnly = true;
            this.dgrid_ventas.RowHeadersVisible = false;
            this.dgrid_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ventas.Size = new System.Drawing.Size(841, 371);
            this.dgrid_ventas.TabIndex = 143;
            // 
            // p_buscador
            // 
            this.p_buscador.Controls.Add(this.cb_FiltrarRubro);
            this.p_buscador.Controls.Add(this.cbb_Rubro);
            this.p_buscador.Controls.Add(this.btn_Buscar);
            this.p_buscador.Controls.Add(this.dtp_cajas_hasta);
            this.p_buscador.Controls.Add(this.label2);
            this.p_buscador.Controls.Add(this.dtp_cajas_desde);
            this.p_buscador.Controls.Add(this.label11);
            this.p_buscador.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_buscador.Location = new System.Drawing.Point(0, 32);
            this.p_buscador.Name = "p_buscador";
            this.p_buscador.Padding = new System.Windows.Forms.Padding(10);
            this.p_buscador.Size = new System.Drawing.Size(841, 50);
            this.p_buscador.TabIndex = 149;
            // 
            // cb_FiltrarRubro
            // 
            this.cb_FiltrarRubro.AutoSize = true;
            this.cb_FiltrarRubro.Dock = System.Windows.Forms.DockStyle.Right;
            this.cb_FiltrarRubro.Enabled = false;
            this.cb_FiltrarRubro.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cb_FiltrarRubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_FiltrarRubro.Location = new System.Drawing.Point(365, 10);
            this.cb_FiltrarRubro.Name = "cb_FiltrarRubro";
            this.cb_FiltrarRubro.Size = new System.Drawing.Size(133, 30);
            this.cb_FiltrarRubro.TabIndex = 148;
            this.cb_FiltrarRubro.Text = "Filtrar por rubro";
            this.cb_FiltrarRubro.UseVisualStyleBackColor = true;
            // 
            // cbb_Rubro
            // 
            this.cbb_Rubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_Rubro.Dock = System.Windows.Forms.DockStyle.Right;
            this.cbb_Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Rubro.Enabled = false;
            this.cbb_Rubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Rubro.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cbb_Rubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Rubro.FormattingEnabled = true;
            this.cbb_Rubro.Location = new System.Drawing.Point(498, 10);
            this.cbb_Rubro.Name = "cbb_Rubro";
            this.cbb_Rubro.Size = new System.Drawing.Size(223, 31);
            this.cbb_Rubro.TabIndex = 147;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Buscar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Buscar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Buscar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Buscar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Buscar.BackgroundImage = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Buscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_Buscar.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.Location = new System.Drawing.Point(721, 10);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(110, 30);
            this.btn_Buscar.TabIndex = 142;
            this.btn_Buscar.Text = "      Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtp_cajas_hasta
            // 
            this.dtp_cajas_hasta.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp_cajas_hasta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_cajas_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cajas_hasta.Location = new System.Drawing.Point(250, 10);
            this.dtp_cajas_hasta.Name = "dtp_cajas_hasta";
            this.dtp_cajas_hasta.Size = new System.Drawing.Size(109, 31);
            this.dtp_cajas_hasta.TabIndex = 122;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(187, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 124;
            this.label2.Text = "Hasta :";
            // 
            // dtp_cajas_desde
            // 
            this.dtp_cajas_desde.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtp_cajas_desde.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_cajas_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cajas_desde.Location = new System.Drawing.Point(78, 10);
            this.dtp_cajas_desde.Name = "dtp_cajas_desde";
            this.dtp_cajas_desde.Size = new System.Drawing.Size(109, 31);
            this.dtp_cajas_desde.TabIndex = 121;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Left;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label11.Location = new System.Drawing.Point(10, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 123;
            this.label11.Text = "Desde :";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(841, 32);
            this.label28.TabIndex = 57;
            this.label28.Text = "Ventas por período";
            // 
            // Frm_Tablero_Control_Ventas_Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(861, 473);
            this.Controls.Add(this.panel6);
            this.MinimumSize = new System.Drawing.Size(877, 300);
            this.Name = "Frm_Tablero_Control_Ventas_Articulos";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de ventas de artículos";
            this.Shown += new System.EventHandler(this.Frm_Tablero_Control_Ventas_Articulos_Shown);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ventas)).EndInit();
            this.p_buscador.ResumeLayout(false);
            this.p_buscador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox cb_FiltrarRubro;
        private System.Windows.Forms.ComboBox cbb_Rubro;
        protected CONTROLES.ButtonImages btn_Buscar;
        private System.Windows.Forms.DateTimePicker dtp_cajas_desde;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_cajas_hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrid_ventas;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.BindingSource bs_rubros;
        private System.Windows.Forms.Panel p_buscador;
    }
}