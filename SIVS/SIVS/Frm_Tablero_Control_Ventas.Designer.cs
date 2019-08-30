namespace SIVS
{
    partial class Frm_Tablero_Control_Ventas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tablero_Control_Ventas));
            this.p_busqueda = new System.Windows.Forms.Panel();
            this.dgrid_pagos = new System.Windows.Forms.DataGridView();
            this.dgrid_ventas = new System.Windows.Forms.DataGridView();
            this.p_controles = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_FiltrarRubro = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_Rubro = new System.Windows.Forms.ComboBox();
            this.dtp_cajas_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_cajas_desde = new System.Windows.Forms.DateTimePicker();
            this.btn_Buscar = new CONTROLES.ButtonImages();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_recargos = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.lbl_total_año = new System.Windows.Forms.Label();
            this.lbl_total_mes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total_Dia = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_utilidad = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_costos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bs_rubros = new System.Windows.Forms.BindingSource(this.components);
            this.p_resultados = new System.Windows.Forms.Panel();
            this.p_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_pagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ventas)).BeginInit();
            this.p_controles.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).BeginInit();
            this.p_resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // p_busqueda
            // 
            this.p_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_busqueda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_busqueda.Controls.Add(this.dgrid_pagos);
            this.p_busqueda.Controls.Add(this.dgrid_ventas);
            this.p_busqueda.Controls.Add(this.p_controles);
            this.p_busqueda.Controls.Add(this.label28);
            this.p_busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_busqueda.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.p_busqueda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_busqueda.Location = new System.Drawing.Point(0, 0);
            this.p_busqueda.Margin = new System.Windows.Forms.Padding(4);
            this.p_busqueda.Name = "p_busqueda";
            this.p_busqueda.Size = new System.Drawing.Size(863, 345);
            this.p_busqueda.TabIndex = 122;
            this.p_busqueda.Paint += new System.Windows.Forms.PaintEventHandler(this.p_busqueda_Paint);
            // 
            // dgrid_pagos
            // 
            this.dgrid_pagos.AllowUserToAddRows = false;
            this.dgrid_pagos.AllowUserToDeleteRows = false;
            this.dgrid_pagos.AllowUserToResizeRows = false;
            this.dgrid_pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrid_pagos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_pagos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_pagos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_pagos.Location = new System.Drawing.Point(863, 88);
            this.dgrid_pagos.MultiSelect = false;
            this.dgrid_pagos.Name = "dgrid_pagos";
            this.dgrid_pagos.ReadOnly = true;
            this.dgrid_pagos.RowHeadersVisible = false;
            this.dgrid_pagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_pagos.Size = new System.Drawing.Size(87, 15);
            this.dgrid_pagos.TabIndex = 144;
            this.dgrid_pagos.Visible = false;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_ventas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_ventas.Location = new System.Drawing.Point(0, 82);
            this.dgrid_ventas.MultiSelect = false;
            this.dgrid_ventas.Name = "dgrid_ventas";
            this.dgrid_ventas.ReadOnly = true;
            this.dgrid_ventas.RowHeadersVisible = false;
            this.dgrid_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ventas.Size = new System.Drawing.Size(863, 263);
            this.dgrid_ventas.TabIndex = 143;
            // 
            // p_controles
            // 
            this.p_controles.Controls.Add(this.label11);
            this.p_controles.Controls.Add(this.cb_FiltrarRubro);
            this.p_controles.Controls.Add(this.label2);
            this.p_controles.Controls.Add(this.cbb_Rubro);
            this.p_controles.Controls.Add(this.dtp_cajas_hasta);
            this.p_controles.Controls.Add(this.dtp_cajas_desde);
            this.p_controles.Controls.Add(this.btn_Buscar);
            this.p_controles.Dock = System.Windows.Forms.DockStyle.Top;
            this.p_controles.Location = new System.Drawing.Point(0, 32);
            this.p_controles.Name = "p_controles";
            this.p_controles.Size = new System.Drawing.Size(863, 50);
            this.p_controles.TabIndex = 149;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label11.Location = new System.Drawing.Point(9, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 25);
            this.label11.TabIndex = 123;
            this.label11.Text = "Desde :";
            // 
            // cb_FiltrarRubro
            // 
            this.cb_FiltrarRubro.AutoSize = true;
            this.cb_FiltrarRubro.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cb_FiltrarRubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_FiltrarRubro.Location = new System.Drawing.Point(385, 11);
            this.cb_FiltrarRubro.Name = "cb_FiltrarRubro";
            this.cb_FiltrarRubro.Size = new System.Drawing.Size(133, 25);
            this.cb_FiltrarRubro.TabIndex = 148;
            this.cb_FiltrarRubro.Text = "Filtrar por rubro";
            this.cb_FiltrarRubro.UseVisualStyleBackColor = true;
            this.cb_FiltrarRubro.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(197, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 124;
            this.label2.Text = "Hasta :";
            // 
            // cbb_Rubro
            // 
            this.cbb_Rubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Rubro.Enabled = false;
            this.cbb_Rubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Rubro.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cbb_Rubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Rubro.FormattingEnabled = true;
            this.cbb_Rubro.Location = new System.Drawing.Point(518, 8);
            this.cbb_Rubro.Name = "cbb_Rubro";
            this.cbb_Rubro.Size = new System.Drawing.Size(223, 31);
            this.cbb_Rubro.TabIndex = 147;
            this.cbb_Rubro.Visible = false;
            // 
            // dtp_cajas_hasta
            // 
            this.dtp_cajas_hasta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_cajas_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cajas_hasta.Location = new System.Drawing.Point(265, 7);
            this.dtp_cajas_hasta.Name = "dtp_cajas_hasta";
            this.dtp_cajas_hasta.Size = new System.Drawing.Size(109, 31);
            this.dtp_cajas_hasta.TabIndex = 122;
            // 
            // dtp_cajas_desde
            // 
            this.dtp_cajas_desde.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_cajas_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cajas_desde.Location = new System.Drawing.Point(82, 7);
            this.dtp_cajas_desde.Name = "dtp_cajas_desde";
            this.dtp_cajas_desde.Size = new System.Drawing.Size(109, 31);
            this.dtp_cajas_desde.TabIndex = 121;
            this.dtp_cajas_desde.ValueChanged += new System.EventHandler(this.dtp_cajas_desde_ValueChanged);
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
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_Buscar.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.Location = new System.Drawing.Point(746, 8);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(110, 32);
            this.btn_Buscar.TabIndex = 142;
            this.btn_Buscar.Text = "      Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label28.Dock = System.Windows.Forms.DockStyle.Top;
            this.label28.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label28.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label28.Location = new System.Drawing.Point(0, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(863, 32);
            this.label28.TabIndex = 57;
            this.label28.Text = "Ventas por período";
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Total.Location = new System.Drawing.Point(150, 135);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(236, 25);
            this.lbl_Total.TabIndex = 126;
            this.lbl_Total.Text = "00000,00";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 125;
            this.label8.Text = "Total :";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label24.Location = new System.Drawing.Point(122, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 25);
            this.label24.TabIndex = 141;
            this.label24.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label6.Location = new System.Drawing.Point(4, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 131;
            this.label6.Text = "Subtotal :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label23.Location = new System.Drawing.Point(122, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(22, 25);
            this.label23.TabIndex = 140;
            this.label23.Text = "$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label5.Location = new System.Drawing.Point(5, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 25);
            this.label5.TabIndex = 127;
            this.label5.Text = "Descuentos :";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label21.Location = new System.Drawing.Point(122, 72);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 25);
            this.label21.TabIndex = 139;
            this.label21.Text = "$";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_Subtotal.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Subtotal.Location = new System.Drawing.Point(150, 42);
            this.lbl_Subtotal.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(236, 25);
            this.lbl_Subtotal.TabIndex = 132;
            this.lbl_Subtotal.Text = "00000,00";
            this.lbl_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label22.Location = new System.Drawing.Point(121, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(22, 25);
            this.label22.TabIndex = 138;
            this.label22.Text = "$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label3.Location = new System.Drawing.Point(6, 104);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 128;
            this.label3.Text = "Recargos :";
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_desc.Location = new System.Drawing.Point(150, 73);
            this.lbl_desc.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(236, 25);
            this.lbl_desc.TabIndex = 130;
            this.lbl_desc.Text = "00000,00";
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_recargos
            // 
            this.lbl_recargos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_recargos.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_recargos.Location = new System.Drawing.Point(150, 104);
            this.lbl_recargos.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_recargos.Name = "lbl_recargos";
            this.lbl_recargos.Size = new System.Drawing.Size(236, 25);
            this.lbl_recargos.TabIndex = 129;
            this.lbl_recargos.Text = "00000,00";
            this.lbl_recargos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.lbl_total_año);
            this.panel1.Controls.Add(this.lbl_total_mes);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_total_Dia);
            this.panel1.Controls.Add(this.label53);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(459, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 227);
            this.panel1.TabIndex = 123;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label33.Location = new System.Drawing.Point(90, 103);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(21, 25);
            this.label33.TabIndex = 176;
            this.label33.Text = "$";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label31.Location = new System.Drawing.Point(90, 72);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(21, 25);
            this.label31.TabIndex = 171;
            this.label31.Text = "$";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label29.Location = new System.Drawing.Point(90, 41);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(21, 25);
            this.label29.TabIndex = 170;
            this.label29.Text = "$";
            // 
            // lbl_total_año
            // 
            this.lbl_total_año.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_total_año.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_total_año.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_total_año.Location = new System.Drawing.Point(117, 101);
            this.lbl_total_año.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_total_año.Name = "lbl_total_año";
            this.lbl_total_año.Size = new System.Drawing.Size(269, 25);
            this.lbl_total_año.TabIndex = 164;
            this.lbl_total_año.Text = "000000,00";
            this.lbl_total_año.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_total_mes
            // 
            this.lbl_total_mes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_total_mes.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_total_mes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_total_mes.Location = new System.Drawing.Point(117, 70);
            this.lbl_total_mes.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_total_mes.Name = "lbl_total_mes";
            this.lbl_total_mes.Size = new System.Drawing.Size(269, 25);
            this.lbl_total_mes.TabIndex = 160;
            this.lbl_total_mes.Text = "000000,00";
            this.lbl_total_mes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label9.Location = new System.Drawing.Point(4, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 25);
            this.label9.TabIndex = 155;
            this.label9.Text = "Del año :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.Location = new System.Drawing.Point(4, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 25);
            this.label4.TabIndex = 153;
            this.label4.Text = "Del mes :";
            // 
            // lbl_total_Dia
            // 
            this.lbl_total_Dia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_total_Dia.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_total_Dia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_total_Dia.Location = new System.Drawing.Point(117, 39);
            this.lbl_total_Dia.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_total_Dia.Name = "lbl_total_Dia";
            this.lbl_total_Dia.Size = new System.Drawing.Size(269, 25);
            this.lbl_total_Dia.TabIndex = 152;
            this.lbl_total_Dia.Text = "000000,00";
            this.lbl_total_Dia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label53.Location = new System.Drawing.Point(4, 39);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(79, 25);
            this.label53.TabIndex = 151;
            this.label53.Text = "Del día  :";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(394, 32);
            this.label32.TabIndex = 59;
            this.label32.Text = "Montos de venta";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_utilidad);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.lbl_costos);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lbl_Total);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.lbl_Subtotal);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_desc);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.lbl_recargos);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Font = new System.Drawing.Font("Segoe UI Light", 28F);
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(394, 227);
            this.panel2.TabIndex = 120;
            // 
            // lbl_utilidad
            // 
            this.lbl_utilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_utilidad.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_utilidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_utilidad.Location = new System.Drawing.Point(150, 197);
            this.lbl_utilidad.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_utilidad.Name = "lbl_utilidad";
            this.lbl_utilidad.Size = new System.Drawing.Size(236, 25);
            this.lbl_utilidad.TabIndex = 146;
            this.lbl_utilidad.Text = "00000,00";
            this.lbl_utilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label14.Location = new System.Drawing.Point(6, 197);
            this.label14.Margin = new System.Windows.Forms.Padding(5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 145;
            this.label14.Text = "Utilidad :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label15.Location = new System.Drawing.Point(122, 197);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 25);
            this.label15.TabIndex = 147;
            this.label15.Text = "$";
            // 
            // lbl_costos
            // 
            this.lbl_costos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_costos.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_costos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_costos.Location = new System.Drawing.Point(150, 166);
            this.lbl_costos.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_costos.Name = "lbl_costos";
            this.lbl_costos.Size = new System.Drawing.Size(236, 25);
            this.lbl_costos.TabIndex = 143;
            this.lbl_costos.Text = "00000,00";
            this.lbl_costos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Margin = new System.Windows.Forms.Padding(5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 25);
            this.label7.TabIndex = 142;
            this.label7.Text = "Costos :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label10.Location = new System.Drawing.Point(122, 166);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 144;
            this.label10.Text = "$";
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label20.Dock = System.Windows.Forms.DockStyle.Top;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(394, 32);
            this.label20.TabIndex = 59;
            this.label20.Text = "Resultados de la búsqueda";
            // 
            // p_resultados
            // 
            this.p_resultados.Controls.Add(this.panel1);
            this.p_resultados.Controls.Add(this.panel2);
            this.p_resultados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_resultados.Location = new System.Drawing.Point(0, 345);
            this.p_resultados.Name = "p_resultados";
            this.p_resultados.Padding = new System.Windows.Forms.Padding(10);
            this.p_resultados.Size = new System.Drawing.Size(863, 247);
            this.p_resultados.TabIndex = 124;
            // 
            // Frm_Tablero_Control_Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(863, 592);
            this.Controls.Add(this.p_busqueda);
            this.Controls.Add(this.p_resultados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(879, 630);
            this.Name = "Frm_Tablero_Control_Ventas";
            this.Text = "Control de ventas";
            this.Load += new System.EventHandler(this.Frm_Tablero_Control_Ventas_Load);
            this.p_busqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_pagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ventas)).EndInit();
            this.p_controles.ResumeLayout(false);
            this.p_controles.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).EndInit();
            this.p_resultados.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel p_busqueda;
        private System.Windows.Forms.DataGridView dgrid_ventas;
        protected CONTROLES.ButtonImages btn_Buscar;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_cajas_hasta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtp_cajas_desde;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_recargos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label28;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lbl_total_mes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total_Dia;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label lbl_total_año;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_utilidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_costos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView dgrid_pagos;
        private System.Windows.Forms.CheckBox cb_FiltrarRubro;
        private System.Windows.Forms.ComboBox cbb_Rubro;
        private System.Windows.Forms.BindingSource bs_rubros;
        private System.Windows.Forms.Panel p_resultados;
        private System.Windows.Forms.Panel p_controles;
    }
}