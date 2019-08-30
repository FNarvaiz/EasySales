namespace SIVS
{
    partial class Frm_Tablero_Control_Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tablero_Control_Gastos));
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_Gastos = new System.Windows.Forms.Label();
            this.cb_FiltrarGastos = new System.Windows.Forms.CheckBox();
            this.cbb_conceptosGastos = new System.Windows.Forms.ComboBox();
            this.btn_BuscarGastos = new CONTROLES.ButtonImages();
            this.dgrid_gastos = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_gastos_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_TotalGastos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp_gastos_hasta = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_FiltrarCobros = new System.Windows.Forms.CheckBox();
            this.cbb_conceptosCobros = new System.Windows.Forms.ComboBox();
            this.btn_BuscarCobros = new CONTROLES.ButtonImages();
            this.dgrid_cobros = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_cobros_desde = new System.Windows.Forms.DateTimePicker();
            this.lbl_TotalCobros = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtp_cobros_hasta = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.bs_conceptosGastos = new System.Windows.Forms.BindingSource(this.components);
            this.bs_conceptosCobros = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_Cobros = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_gastos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_conceptosGastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_conceptosCobros)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.lbl_Gastos);
            this.panel4.Controls.Add(this.cb_FiltrarGastos);
            this.panel4.Controls.Add(this.cbb_conceptosGastos);
            this.panel4.Controls.Add(this.btn_BuscarGastos);
            this.panel4.Controls.Add(this.dgrid_gastos);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtp_gastos_desde);
            this.panel4.Controls.Add(this.lbl_TotalGastos);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.dtp_gastos_hasta);
            this.panel4.Controls.Add(this.label24);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(390, 484);
            this.panel4.TabIndex = 125;
            // 
            // lbl_Gastos
            // 
            this.lbl_Gastos.AutoSize = true;
            this.lbl_Gastos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gastos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_Gastos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Gastos.Location = new System.Drawing.Point(7, 108);
            this.lbl_Gastos.Name = "lbl_Gastos";
            this.lbl_Gastos.Size = new System.Drawing.Size(341, 25);
            this.lbl_Gastos.TabIndex = 146;
            this.lbl_Gastos.Text = "Seleccione un concepto y oprima \" Buscar \"";
            this.lbl_Gastos.Visible = false;
            // 
            // cb_FiltrarGastos
            // 
            this.cb_FiltrarGastos.AutoSize = true;
            this.cb_FiltrarGastos.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cb_FiltrarGastos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_FiltrarGastos.Location = new System.Drawing.Point(12, 80);
            this.cb_FiltrarGastos.Name = "cb_FiltrarGastos";
            this.cb_FiltrarGastos.Size = new System.Drawing.Size(159, 25);
            this.cb_FiltrarGastos.TabIndex = 145;
            this.cb_FiltrarGastos.Text = "Filtrar por concepto";
            this.cb_FiltrarGastos.UseVisualStyleBackColor = true;
            this.cb_FiltrarGastos.CheckedChanged += new System.EventHandler(this.cb_FiltrarGastos_CheckedChanged);
            // 
            // cbb_conceptosGastos
            // 
            this.cbb_conceptosGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_conceptosGastos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_conceptosGastos.Enabled = false;
            this.cbb_conceptosGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_conceptosGastos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cbb_conceptosGastos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_conceptosGastos.FormattingEnabled = true;
            this.cbb_conceptosGastos.Location = new System.Drawing.Point(12, 139);
            this.cbb_conceptosGastos.Name = "cbb_conceptosGastos";
            this.cbb_conceptosGastos.Size = new System.Drawing.Size(251, 31);
            this.cbb_conceptosGastos.TabIndex = 144;
            // 
            // btn_BuscarGastos
            // 
            this.btn_BuscarGastos.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BuscarGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_BuscarGastos.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_BuscarGastos.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_BuscarGastos.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_BuscarGastos.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_BuscarGastos.BackgroundImage = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarGastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_BuscarGastos.FlatAppearance.BorderSize = 0;
            this.btn_BuscarGastos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_BuscarGastos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BuscarGastos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarGastos.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarGastos.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarGastos.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_BuscarGastos.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarGastos.Location = new System.Drawing.Point(269, 139);
            this.btn_BuscarGastos.Name = "btn_BuscarGastos";
            this.btn_BuscarGastos.Size = new System.Drawing.Size(110, 32);
            this.btn_BuscarGastos.TabIndex = 143;
            this.btn_BuscarGastos.Text = "      Buscar";
            this.btn_BuscarGastos.UseVisualStyleBackColor = false;
            this.btn_BuscarGastos.Click += new System.EventHandler(this.btn_BuscarGastos_Click);
            // 
            // dgrid_gastos
            // 
            this.dgrid_gastos.AllowUserToAddRows = false;
            this.dgrid_gastos.AllowUserToDeleteRows = false;
            this.dgrid_gastos.AllowUserToResizeRows = false;
            this.dgrid_gastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_gastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_gastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_gastos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_gastos.Location = new System.Drawing.Point(7, 177);
            this.dgrid_gastos.MultiSelect = false;
            this.dgrid_gastos.Name = "dgrid_gastos";
            this.dgrid_gastos.ReadOnly = true;
            this.dgrid_gastos.RowHeadersVisible = false;
            this.dgrid_gastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_gastos.Size = new System.Drawing.Size(373, 250);
            this.dgrid_gastos.TabIndex = 73;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(390, 32);
            this.label29.TabIndex = 58;
            this.label29.Text = "Gastos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Desde :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(194, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hasta :";
            // 
            // dtp_gastos_desde
            // 
            this.dtp_gastos_desde.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_gastos_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_gastos_desde.Location = new System.Drawing.Point(77, 43);
            this.dtp_gastos_desde.Name = "dtp_gastos_desde";
            this.dtp_gastos_desde.Size = new System.Drawing.Size(111, 31);
            this.dtp_gastos_desde.TabIndex = 28;
            this.dtp_gastos_desde.ValueChanged += new System.EventHandler(this.dtp_gastos_desde_ValueChanged);
            // 
            // lbl_TotalGastos
            // 
            this.lbl_TotalGastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_TotalGastos.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_TotalGastos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_TotalGastos.Location = new System.Drawing.Point(112, 433);
            this.lbl_TotalGastos.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_TotalGastos.Name = "lbl_TotalGastos";
            this.lbl_TotalGastos.Size = new System.Drawing.Size(268, 39);
            this.lbl_TotalGastos.TabIndex = 126;
            this.lbl_TotalGastos.Text = "00000,00";
            this.lbl_TotalGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(14, 438);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 28);
            this.label8.TabIndex = 125;
            this.label8.Text = "Total :";
            // 
            // dtp_gastos_hasta
            // 
            this.dtp_gastos_hasta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_gastos_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_gastos_hasta.Location = new System.Drawing.Point(269, 43);
            this.dtp_gastos_hasta.Name = "dtp_gastos_hasta";
            this.dtp_gastos_hasta.Size = new System.Drawing.Size(111, 31);
            this.dtp_gastos_hasta.TabIndex = 29;
            this.dtp_gastos_hasta.ValueChanged += new System.EventHandler(this.dtp_gastos_hasta_ValueChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(84, 438);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(22, 28);
            this.label24.TabIndex = 141;
            this.label24.Text = "$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_Cobros);
            this.panel1.Controls.Add(this.cb_FiltrarCobros);
            this.panel1.Controls.Add(this.cbb_conceptosCobros);
            this.panel1.Controls.Add(this.btn_BuscarCobros);
            this.panel1.Controls.Add(this.dgrid_cobros);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtp_cobros_desde);
            this.panel1.Controls.Add(this.lbl_TotalCobros);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dtp_cobros_hasta);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(396, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 484);
            this.panel1.TabIndex = 126;
            // 
            // cb_FiltrarCobros
            // 
            this.cb_FiltrarCobros.AutoSize = true;
            this.cb_FiltrarCobros.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.cb_FiltrarCobros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_FiltrarCobros.Location = new System.Drawing.Point(8, 81);
            this.cb_FiltrarCobros.Name = "cb_FiltrarCobros";
            this.cb_FiltrarCobros.Size = new System.Drawing.Size(159, 25);
            this.cb_FiltrarCobros.TabIndex = 145;
            this.cb_FiltrarCobros.Text = "Filtrar por concepto";
            this.cb_FiltrarCobros.UseVisualStyleBackColor = true;
            this.cb_FiltrarCobros.CheckedChanged += new System.EventHandler(this.cb_FiltrarCobros_CheckedChanged);
            // 
            // cbb_conceptosCobros
            // 
            this.cbb_conceptosCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_conceptosCobros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_conceptosCobros.Enabled = false;
            this.cbb_conceptosCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_conceptosCobros.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cbb_conceptosCobros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_conceptosCobros.FormattingEnabled = true;
            this.cbb_conceptosCobros.Location = new System.Drawing.Point(6, 140);
            this.cbb_conceptosCobros.Name = "cbb_conceptosCobros";
            this.cbb_conceptosCobros.Size = new System.Drawing.Size(260, 31);
            this.cbb_conceptosCobros.TabIndex = 144;
            // 
            // btn_BuscarCobros
            // 
            this.btn_BuscarCobros.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BuscarCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_BuscarCobros.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_BuscarCobros.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_BuscarCobros.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_BuscarCobros.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_BuscarCobros.BackgroundImage = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarCobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_BuscarCobros.FlatAppearance.BorderSize = 0;
            this.btn_BuscarCobros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCobros.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_BuscarCobros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BuscarCobros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarCobros.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarCobros.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarCobros.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_BuscarCobros.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarCobros.Location = new System.Drawing.Point(273, 139);
            this.btn_BuscarCobros.Name = "btn_BuscarCobros";
            this.btn_BuscarCobros.Size = new System.Drawing.Size(110, 32);
            this.btn_BuscarCobros.TabIndex = 143;
            this.btn_BuscarCobros.Text = "      Buscar";
            this.btn_BuscarCobros.UseVisualStyleBackColor = false;
            this.btn_BuscarCobros.Click += new System.EventHandler(this.btn_BuscarCobros_Click);
            // 
            // dgrid_cobros
            // 
            this.dgrid_cobros.AllowUserToAddRows = false;
            this.dgrid_cobros.AllowUserToDeleteRows = false;
            this.dgrid_cobros.AllowUserToResizeRows = false;
            this.dgrid_cobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_cobros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_cobros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_cobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_cobros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_cobros.Location = new System.Drawing.Point(7, 177);
            this.dgrid_cobros.MultiSelect = false;
            this.dgrid_cobros.Name = "dgrid_cobros";
            this.dgrid_cobros.ReadOnly = true;
            this.dgrid_cobros.RowHeadersVisible = false;
            this.dgrid_cobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_cobros.Size = new System.Drawing.Size(376, 250);
            this.dgrid_cobros.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(393, 32);
            this.label5.TabIndex = 58;
            this.label5.Text = "Cobros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(3, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 28);
            this.label6.TabIndex = 47;
            this.label6.Text = "Desde :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(197, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 28);
            this.label7.TabIndex = 48;
            this.label7.Text = "Hasta :";
            // 
            // dtp_cobros_desde
            // 
            this.dtp_cobros_desde.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_cobros_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cobros_desde.Location = new System.Drawing.Point(80, 44);
            this.dtp_cobros_desde.Name = "dtp_cobros_desde";
            this.dtp_cobros_desde.Size = new System.Drawing.Size(111, 31);
            this.dtp_cobros_desde.TabIndex = 28;
            this.dtp_cobros_desde.ValueChanged += new System.EventHandler(this.dtp_desde_Cobros_ValueChanged);
            // 
            // lbl_TotalCobros
            // 
            this.lbl_TotalCobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_TotalCobros.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_TotalCobros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_TotalCobros.Location = new System.Drawing.Point(111, 433);
            this.lbl_TotalCobros.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_TotalCobros.Name = "lbl_TotalCobros";
            this.lbl_TotalCobros.Size = new System.Drawing.Size(272, 39);
            this.lbl_TotalCobros.TabIndex = 126;
            this.lbl_TotalCobros.Text = "00000,00";
            this.lbl_TotalCobros.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(13, 438);
            this.label10.Margin = new System.Windows.Forms.Padding(5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 28);
            this.label10.TabIndex = 125;
            this.label10.Text = "Total :";
            // 
            // dtp_cobros_hasta
            // 
            this.dtp_cobros_hasta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_cobros_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_cobros_hasta.Location = new System.Drawing.Point(272, 43);
            this.dtp_cobros_hasta.Name = "dtp_cobros_hasta";
            this.dtp_cobros_hasta.Size = new System.Drawing.Size(111, 31);
            this.dtp_cobros_hasta.TabIndex = 29;
            this.dtp_cobros_hasta.ValueChanged += new System.EventHandler(this.dtp_hasta_Cobros_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(83, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 28);
            this.label11.TabIndex = 141;
            this.label11.Text = "$";
            // 
            // lbl_Cobros
            // 
            this.lbl_Cobros.AutoSize = true;
            this.lbl_Cobros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cobros.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_Cobros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Cobros.Location = new System.Drawing.Point(2, 109);
            this.lbl_Cobros.Name = "lbl_Cobros";
            this.lbl_Cobros.Size = new System.Drawing.Size(341, 25);
            this.lbl_Cobros.TabIndex = 147;
            this.lbl_Cobros.Text = "Seleccione un concepto y oprima \" Buscar \"";
            this.lbl_Cobros.Visible = false;
            // 
            // Frm_Tablero_Control_Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(789, 484);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Tablero_Control_Gastos";
            this.Text = "Control de gastos y cobros";
            this.Load += new System.EventHandler(this.Frm_Tablero_Control_Gastos_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_gastos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_conceptosGastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_conceptosCobros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgrid_gastos;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_gastos_desde;
        private System.Windows.Forms.DateTimePicker dtp_gastos_hasta;
        protected CONTROLES.ButtonImages btn_BuscarGastos;
        private System.Windows.Forms.Label lbl_TotalGastos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox cbb_conceptosGastos;
        private System.Windows.Forms.Label lbl_Gastos;
        private System.Windows.Forms.CheckBox cb_FiltrarGastos;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_FiltrarCobros;
        private System.Windows.Forms.ComboBox cbb_conceptosCobros;
        protected CONTROLES.ButtonImages btn_BuscarCobros;
        private System.Windows.Forms.DataGridView dgrid_cobros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_cobros_desde;
        private System.Windows.Forms.Label lbl_TotalCobros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtp_cobros_hasta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.BindingSource bs_conceptosGastos;
        private System.Windows.Forms.BindingSource bs_conceptosCobros;
        private System.Windows.Forms.Label lbl_Cobros;
    }
}