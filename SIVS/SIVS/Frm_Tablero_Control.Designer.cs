namespace SIVS
{
    partial class Frm_Tablero_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tablero_Control));
            this.panel1 = new System.Windows.Forms.Panel();
            this.p_grilla = new System.Windows.Forms.Panel();
            this.dgrid_IndicadorStock = new System.Windows.Forms.DataGridView();
            this.p_buscador = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pn_abm = new System.Windows.Forms.Panel();
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.lbl_precioConIVA = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_rubro = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lbl_costosSoportados = new System.Windows.Forms.Label();
            this.lbl_utilidad = new System.Windows.Forms.Label();
            this.lbl_costoUni = new System.Windows.Forms.Label();
            this.lbl_ingresoVentas = new System.Windows.Forms.Label();
            this.lbl_iva = new System.Windows.Forms.Label();
            this.lbl_unidadMedida = new System.Windows.Forms.Label();
            this.lbl_margenBruto = new System.Windows.Forms.Label();
            this.lbl_precioSinIVA = new System.Windows.Forms.Label();
            this.lbl_cantVendido = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_unidadMedida2 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lbl_CantidadReponer = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.bs_articulos = new System.Windows.Forms.BindingSource(this.components);
            this.p_derecho = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.p_grilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_IndicadorStock)).BeginInit();
            this.p_buscador.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_articulos)).BeginInit();
            this.p_derecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.p_grilla);
            this.panel1.Controls.Add(this.p_buscador);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 500);
            this.panel1.TabIndex = 126;
            // 
            // p_grilla
            // 
            this.p_grilla.Controls.Add(this.dgrid_IndicadorStock);
            this.p_grilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_grilla.Location = new System.Drawing.Point(0, 57);
            this.p_grilla.Name = "p_grilla";
            this.p_grilla.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.p_grilla.Size = new System.Drawing.Size(432, 395);
            this.p_grilla.TabIndex = 64;
            // 
            // dgrid_IndicadorStock
            // 
            this.dgrid_IndicadorStock.AllowUserToAddRows = false;
            this.dgrid_IndicadorStock.AllowUserToDeleteRows = false;
            this.dgrid_IndicadorStock.AllowUserToResizeRows = false;
            this.dgrid_IndicadorStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_IndicadorStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_IndicadorStock.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_IndicadorStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_IndicadorStock.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_IndicadorStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_IndicadorStock.Location = new System.Drawing.Point(5, 0);
            this.dgrid_IndicadorStock.MultiSelect = false;
            this.dgrid_IndicadorStock.Name = "dgrid_IndicadorStock";
            this.dgrid_IndicadorStock.ReadOnly = true;
            this.dgrid_IndicadorStock.RowHeadersVisible = false;
            this.dgrid_IndicadorStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_IndicadorStock.Size = new System.Drawing.Size(422, 395);
            this.dgrid_IndicadorStock.TabIndex = 59;
            this.dgrid_IndicadorStock.SelectionChanged += new System.EventHandler(this.dgrid_IndicadorStock_SelectionChanged);
            this.dgrid_IndicadorStock.Sorted += new System.EventHandler(this.dgrid_IndicadorStock_Sorted);
            // 
            // p_buscador
            // 
            this.p_buscador.Controls.Add(this.txt_busqueda);
            this.p_buscador.Controls.Add(this.label36);
            this.p_buscador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_buscador.Location = new System.Drawing.Point(0, 452);
            this.p_buscador.Name = "p_buscador";
            this.p_buscador.Padding = new System.Windows.Forms.Padding(8);
            this.p_buscador.Size = new System.Drawing.Size(432, 48);
            this.p_buscador.TabIndex = 63;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_busqueda.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.txt_busqueda.Location = new System.Drawing.Point(126, 8);
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(298, 34);
            this.txt_busqueda.TabIndex = 62;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Left;
            this.label36.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label36.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label36.Location = new System.Drawing.Point(8, 8);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(118, 28);
            this.label36.TabIndex = 61;
            this.label36.Text = "Descripción :";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Dock = System.Windows.Forms.DockStyle.Top;
            this.label33.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label33.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label33.Location = new System.Drawing.Point(0, 32);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(285, 25);
            this.label33.TabIndex = 60;
            this.label33.Text = "Información detallada a la derecha";
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label30.Dock = System.Windows.Forms.DockStyle.Top;
            this.label30.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label30.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label30.Location = new System.Drawing.Point(0, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(432, 32);
            this.label30.TabIndex = 58;
            this.label30.Text = "Control de Stock";
            // 
            // pn_abm
            // 
            this.pn_abm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_abm.Controls.Add(this.label55);
            this.pn_abm.Controls.Add(this.label54);
            this.pn_abm.Controls.Add(this.label52);
            this.pn_abm.Controls.Add(this.label50);
            this.pn_abm.Controls.Add(this.label47);
            this.pn_abm.Controls.Add(this.label44);
            this.pn_abm.Controls.Add(this.label51);
            this.pn_abm.Controls.Add(this.label49);
            this.pn_abm.Controls.Add(this.label46);
            this.pn_abm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_abm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_abm.Location = new System.Drawing.Point(5, 439);
            this.pn_abm.Name = "pn_abm";
            this.pn_abm.Size = new System.Drawing.Size(489, 61);
            this.pn_abm.TabIndex = 129;
            // 
            // label55
            // 
            this.label55.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label55.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label55.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label55.Location = new System.Drawing.Point(145, 32);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(20, 20);
            this.label55.TabIndex = 162;
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label54.Dock = System.Windows.Forms.DockStyle.Top;
            this.label54.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label54.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label54.Location = new System.Drawing.Point(0, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(489, 24);
            this.label54.TabIndex = 161;
            this.label54.Text = "Referencias para el estado actual de stock";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label52.Location = new System.Drawing.Point(5, 28);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(134, 25);
            this.label52.TabIndex = 160;
            this.label52.Text = "Negativo o nulo";
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.label50.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label50.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label50.Location = new System.Drawing.Point(434, 32);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(20, 20);
            this.label50.TabIndex = 159;
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(196)))), ((int)(((byte)(29)))));
            this.label47.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label47.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label47.Location = new System.Drawing.Point(341, 32);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(20, 20);
            this.label47.TabIndex = 157;
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(133)))), ((int)(((byte)(27)))));
            this.label44.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label44.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label44.Location = new System.Drawing.Point(232, 32);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(20, 20);
            this.label44.TabIndex = 155;
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label51.Location = new System.Drawing.Point(386, 28);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(42, 25);
            this.label51.TabIndex = 158;
            this.label51.Text = "Alto";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label49.Location = new System.Drawing.Point(275, 28);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(60, 25);
            this.label49.TabIndex = 156;
            this.label49.Text = "Medio";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label46.Location = new System.Drawing.Point(181, 28);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(45, 25);
            this.label46.TabIndex = 154;
            this.label46.Text = "Bajo";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.label56);
            this.panel8.Controls.Add(this.lbl_precioConIVA);
            this.panel8.Controls.Add(this.label45);
            this.panel8.Controls.Add(this.lbl_estado);
            this.panel8.Controls.Add(this.lbl_rubro);
            this.panel8.Controls.Add(this.lbl_descripcion);
            this.panel8.Controls.Add(this.label53);
            this.panel8.Controls.Add(this.label48);
            this.panel8.Controls.Add(this.lbl_costosSoportados);
            this.panel8.Controls.Add(this.lbl_utilidad);
            this.panel8.Controls.Add(this.lbl_costoUni);
            this.panel8.Controls.Add(this.lbl_ingresoVentas);
            this.panel8.Controls.Add(this.lbl_iva);
            this.panel8.Controls.Add(this.lbl_unidadMedida);
            this.panel8.Controls.Add(this.lbl_margenBruto);
            this.panel8.Controls.Add(this.lbl_precioSinIVA);
            this.panel8.Controls.Add(this.lbl_cantVendido);
            this.panel8.Controls.Add(this.label43);
            this.panel8.Controls.Add(this.label42);
            this.panel8.Controls.Add(this.label40);
            this.panel8.Controls.Add(this.label38);
            this.panel8.Controls.Add(this.label37);
            this.panel8.Controls.Add(this.label31);
            this.panel8.Controls.Add(this.lbl_unidadMedida2);
            this.panel8.Controls.Add(this.label34);
            this.panel8.Controls.Add(this.label32);
            this.panel8.Controls.Add(this.lbl_CantidadReponer);
            this.panel8.Controls.Add(this.label41);
            this.panel8.Controls.Add(this.label39);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.panel8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel8.Location = new System.Drawing.Point(5, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(489, 500);
            this.panel8.TabIndex = 128;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label56.Location = new System.Drawing.Point(319, 78);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(62, 25);
            this.label56.TabIndex = 152;
            this.label56.Text = "Estado";
            // 
            // lbl_precioConIVA
            // 
            this.lbl_precioConIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_precioConIVA.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_precioConIVA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_precioConIVA.Location = new System.Drawing.Point(199, 331);
            this.lbl_precioConIVA.Name = "lbl_precioConIVA";
            this.lbl_precioConIVA.Size = new System.Drawing.Size(274, 25);
            this.lbl_precioConIVA.TabIndex = 155;
            this.lbl_precioConIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label45.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label45.Location = new System.Drawing.Point(4, 334);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(156, 25);
            this.label45.TabIndex = 154;
            this.label45.Text = "Precio con IVA :  $";
            // 
            // lbl_estado
            // 
            this.lbl_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_estado.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_estado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_estado.Location = new System.Drawing.Point(387, 76);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(86, 25);
            this.lbl_estado.TabIndex = 153;
            this.lbl_estado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rubro
            // 
            this.lbl_rubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_rubro.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_rubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_rubro.Location = new System.Drawing.Point(123, 78);
            this.lbl_rubro.Name = "lbl_rubro";
            this.lbl_rubro.Size = new System.Drawing.Size(196, 25);
            this.lbl_rubro.TabIndex = 151;
            this.lbl_rubro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_descripcion.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_descripcion.Location = new System.Drawing.Point(123, 40);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(350, 25);
            this.lbl_descripcion.TabIndex = 150;
            this.lbl_descripcion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label53.Location = new System.Drawing.Point(9, 40);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(109, 25);
            this.label53.TabIndex = 149;
            this.label53.Text = "Descripción :";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label48.Location = new System.Drawing.Point(50, 78);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(67, 25);
            this.label48.TabIndex = 148;
            this.label48.Text = "Rubro :";
            // 
            // lbl_costosSoportados
            // 
            this.lbl_costosSoportados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_costosSoportados.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_costosSoportados.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_costosSoportados.Location = new System.Drawing.Point(199, 366);
            this.lbl_costosSoportados.Name = "lbl_costosSoportados";
            this.lbl_costosSoportados.Size = new System.Drawing.Size(274, 25);
            this.lbl_costosSoportados.TabIndex = 147;
            this.lbl_costosSoportados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_utilidad
            // 
            this.lbl_utilidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_utilidad.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_utilidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_utilidad.Location = new System.Drawing.Point(199, 296);
            this.lbl_utilidad.Name = "lbl_utilidad";
            this.lbl_utilidad.Size = new System.Drawing.Size(274, 25);
            this.lbl_utilidad.TabIndex = 146;
            this.lbl_utilidad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_costoUni
            // 
            this.lbl_costoUni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_costoUni.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_costoUni.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_costoUni.Location = new System.Drawing.Point(199, 262);
            this.lbl_costoUni.Name = "lbl_costoUni";
            this.lbl_costoUni.Size = new System.Drawing.Size(274, 25);
            this.lbl_costoUni.TabIndex = 145;
            this.lbl_costoUni.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ingresoVentas
            // 
            this.lbl_ingresoVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_ingresoVentas.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_ingresoVentas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ingresoVentas.Location = new System.Drawing.Point(199, 154);
            this.lbl_ingresoVentas.Name = "lbl_ingresoVentas";
            this.lbl_ingresoVentas.Size = new System.Drawing.Size(139, 25);
            this.lbl_ingresoVentas.TabIndex = 144;
            this.lbl_ingresoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_iva
            // 
            this.lbl_iva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_iva.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_iva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_iva.Location = new System.Drawing.Point(422, 154);
            this.lbl_iva.Name = "lbl_iva";
            this.lbl_iva.Size = new System.Drawing.Size(51, 25);
            this.lbl_iva.TabIndex = 142;
            this.lbl_iva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_unidadMedida
            // 
            this.lbl_unidadMedida.AutoSize = true;
            this.lbl_unidadMedida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_unidadMedida.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbl_unidadMedida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_unidadMedida.Location = new System.Drawing.Point(400, 121);
            this.lbl_unidadMedida.Name = "lbl_unidadMedida";
            this.lbl_unidadMedida.Size = new System.Drawing.Size(71, 19);
            this.lbl_unidadMedida.TabIndex = 141;
            this.lbl_unidadMedida.Text = "UdMedida";
            this.lbl_unidadMedida.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_margenBruto
            // 
            this.lbl_margenBruto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_margenBruto.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_margenBruto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_margenBruto.Location = new System.Drawing.Point(199, 193);
            this.lbl_margenBruto.Name = "lbl_margenBruto";
            this.lbl_margenBruto.Size = new System.Drawing.Size(274, 25);
            this.lbl_margenBruto.TabIndex = 140;
            this.lbl_margenBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_precioSinIVA
            // 
            this.lbl_precioSinIVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_precioSinIVA.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_precioSinIVA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_precioSinIVA.Location = new System.Drawing.Point(199, 228);
            this.lbl_precioSinIVA.Name = "lbl_precioSinIVA";
            this.lbl_precioSinIVA.Size = new System.Drawing.Size(274, 25);
            this.lbl_precioSinIVA.TabIndex = 138;
            this.lbl_precioSinIVA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cantVendido
            // 
            this.lbl_cantVendido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_cantVendido.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_cantVendido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_cantVendido.Location = new System.Drawing.Point(137, 118);
            this.lbl_cantVendido.Name = "lbl_cantVendido";
            this.lbl_cantVendido.Size = new System.Drawing.Size(336, 25);
            this.lbl_cantVendido.TabIndex = 137;
            this.lbl_cantVendido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label43.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label43.Location = new System.Drawing.Point(5, 368);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(158, 25);
            this.label43.TabIndex = 136;
            this.label43.Text = "Costos totales :   $";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label42.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label42.Location = new System.Drawing.Point(9, 154);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(184, 25);
            this.label42.TabIndex = 135;
            this.label42.Text = "Ingreso por ventas : $";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label40.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label40.Location = new System.Drawing.Point(5, 193);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(162, 25);
            this.label40.TabIndex = 133;
            this.label40.Text = "Margen bruto :    $";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label38.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label38.Location = new System.Drawing.Point(344, 154);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(73, 25);
            this.label38.TabIndex = 131;
            this.label38.Text = "IVA :  %";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.Color.Transparent;
            this.label37.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label37.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label37.Location = new System.Drawing.Point(4, 228);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(163, 25);
            this.label37.TabIndex = 130;
            this.label37.Text = "Precio sin IVA :     $";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label31.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label31.Location = new System.Drawing.Point(4, 118);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(131, 25);
            this.label31.TabIndex = 129;
            this.label31.Text = "Cant. vendida :";
            // 
            // lbl_unidadMedida2
            // 
            this.lbl_unidadMedida2.AutoSize = true;
            this.lbl_unidadMedida2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unidadMedida2.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.lbl_unidadMedida2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_unidadMedida2.Location = new System.Drawing.Point(400, 411);
            this.lbl_unidadMedida2.Name = "lbl_unidadMedida2";
            this.lbl_unidadMedida2.Size = new System.Drawing.Size(71, 19);
            this.lbl_unidadMedida2.TabIndex = 128;
            this.lbl_unidadMedida2.Text = "UdMedida";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label34.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label34.Location = new System.Drawing.Point(5, 405);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(278, 25);
            this.label34.TabIndex = 61;
            this.label34.Text = "Reponer para mantener stock alto :";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(489, 32);
            this.label32.TabIndex = 58;
            this.label32.Text = "Datos y Estadísticas";
            // 
            // lbl_CantidadReponer
            // 
            this.lbl_CantidadReponer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_CantidadReponer.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_CantidadReponer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_CantidadReponer.Location = new System.Drawing.Point(289, 405);
            this.lbl_CantidadReponer.Name = "lbl_CantidadReponer";
            this.lbl_CantidadReponer.Size = new System.Drawing.Size(109, 25);
            this.lbl_CantidadReponer.TabIndex = 127;
            this.lbl_CantidadReponer.Text = "0";
            this.lbl_CantidadReponer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label41.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label41.Location = new System.Drawing.Point(5, 300);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(157, 25);
            this.label41.TabIndex = 134;
            this.label41.Text = "Utilidad :             $";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.Color.Transparent;
            this.label39.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label39.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label39.Location = new System.Drawing.Point(3, 262);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(163, 25);
            this.label39.TabIndex = 132;
            this.label39.Text = "Costo unitario :    $";
            // 
            // p_derecho
            // 
            this.p_derecho.Controls.Add(this.pn_abm);
            this.p_derecho.Controls.Add(this.panel8);
            this.p_derecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_derecho.Location = new System.Drawing.Point(437, 5);
            this.p_derecho.Name = "p_derecho";
            this.p_derecho.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.p_derecho.Size = new System.Drawing.Size(494, 500);
            this.p_derecho.TabIndex = 156;
            // 
            // Frm_Tablero_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(936, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_derecho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(952, 548);
            this.Name = "Frm_Tablero_Control";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Tablero  de control";
            this.Load += new System.EventHandler(this.Frm_Tablero_Control_Load);
            this.Shown += new System.EventHandler(this.Frm_Tablero_Control_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.p_grilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_IndicadorStock)).EndInit();
            this.p_buscador.ResumeLayout(false);
            this.p_buscador.PerformLayout();
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_articulos)).EndInit();
            this.p_derecho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_articulos;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrid_IndicadorStock;
        private System.Windows.Forms.Label label30;
        protected System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lbl_CantidadReponer;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lbl_unidadMedida2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label lbl_margenBruto;
        private System.Windows.Forms.Label lbl_precioSinIVA;
        private System.Windows.Forms.Label lbl_cantVendido;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lbl_costosSoportados;
        private System.Windows.Forms.Label lbl_utilidad;
        private System.Windows.Forms.Label lbl_costoUni;
        private System.Windows.Forms.Label lbl_ingresoVentas;
        private System.Windows.Forms.Label lbl_iva;
        private System.Windows.Forms.Label lbl_unidadMedida;
        private System.Windows.Forms.Label lbl_rubro;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_precioConIVA;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label56;
        protected System.Windows.Forms.Panel pn_abm;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Panel p_derecho;
        private System.Windows.Forms.Panel p_buscador;
        private System.Windows.Forms.Panel p_grilla;
    }
}