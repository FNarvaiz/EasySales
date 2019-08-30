namespace SIVS
{
    partial class Frm_ABM_compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_compras));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgrid_compras = new System.Windows.Forms.DataGridView();
            this.p_datosCompra = new System.Windows.Forms.Panel();
            this.txt_total = new CONTROLES.TextBox_Decimal();
            this.txt_descuento = new CONTROLES.TextBox_Decimal();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ConProveedor = new System.Windows.Forms.CheckBox();
            this.cb_proveedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl_formaPago = new System.Windows.Forms.Label();
            this.cb_formaPago = new System.Windows.Forms.ComboBox();
            this.dgrid_Items = new System.Windows.Forms.DataGridView();
            this.l_articulos = new System.Windows.Forms.Label();
            this.txt_cantidad = new CONTROLES.TextBox_Decimal();
            this.txt_IVA = new CONTROLES.TextBox_Decimal();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_AgregarItem = new CONTROLES.ButtonImages();
            this.txt_PorcGanancia = new CONTROLES.TextBox_Decimal();
            this.txt_precio = new CONTROLES.TextBox_Decimal();
            this.txt_costoUnitario = new CONTROLES.TextBox_Decimal();
            this.txt_costoTotal = new CONTROLES.TextBox_Decimal();
            this.p_articulo = new System.Windows.Forms.Panel();
            this.txt_costoSinImp = new CONTROLES.TextBox_Decimal();
            this.label26 = new System.Windows.Forms.Label();
            this.txt_imp = new CONTROLES.TextBox_Decimal();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txt_cantAlta = new CONTROLES.TextBox_Decimal();
            this.txt_cantMedia = new CONTROLES.TextBox_Decimal();
            this.txt_cantBaja = new CONTROLES.TextBox_Decimal();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_buscarArticulo = new CONTROLES.ButtonImages();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.lbl_cantHistorica = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cb_Rubro = new System.Windows.Forms.ComboBox();
            this.lbl_rubro = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.Label();
            this.lbl_medida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Nota_Registros = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_ActualPrecio = new System.Windows.Forms.Label();
            this.cb_medidas = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_ActualCosto = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_costoPonderado = new System.Windows.Forms.TextBox();
            this.lbl_costoPonderado = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.bs_FormasDePago = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Proveedores = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Items = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Compras = new System.Windows.Forms.BindingSource(this.components);
            this.bs_rubros = new System.Windows.Forms.BindingSource(this.components);
            this.bs_medidas = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_verMas = new CONTROLES.ButtonImages();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_compras)).BeginInit();
            this.p_datosCompra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Items)).BeginInit();
            this.p_articulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_FormasDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Proveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Compras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_medidas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(0, 10);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(128, 10);
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(12, 10);
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 532);
            this.pbtn.Size = new System.Drawing.Size(1331, 50);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.dgrid_Items);
            this.pn_abm.Controls.Add(this.l_articulos);
            this.pn_abm.Controls.Add(this.p_datosCompra);
            this.pn_abm.Size = new System.Drawing.Size(421, 516);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_compras);
            this.gb_abm.Controls.Add(this.label1);
            this.gb_abm.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.gb_abm.Size = new System.Drawing.Size(356, 516);
            // 
            // p_arriba
            // 
            this.p_arriba.Controls.Add(this.p_articulo);
            this.p_arriba.Size = new System.Drawing.Size(1331, 532);
            this.p_arriba.Controls.SetChildIndex(this.p_articulo, 0);
            this.p_arriba.Controls.SetChildIndex(this.p_derecho, 0);
            this.p_arriba.Controls.SetChildIndex(this.gb_abm, 0);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(364, 8);
            this.p_derecho.Size = new System.Drawing.Size(429, 516);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(1081, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(250, 50);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.btn_verMas);
            this.pn_btnABM.Size = new System.Drawing.Size(1081, 50);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_verMas, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.pn_btnSalir, 0);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(962, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 50);
            // 
            // dgrid_compras
            // 
            this.dgrid_compras.AllowUserToAddRows = false;
            this.dgrid_compras.AllowUserToDeleteRows = false;
            this.dgrid_compras.AllowUserToResizeRows = false;
            this.dgrid_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_compras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_compras.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_compras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_compras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_compras.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_compras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_compras.Location = new System.Drawing.Point(0, 31);
            this.dgrid_compras.MultiSelect = false;
            this.dgrid_compras.Name = "dgrid_compras";
            this.dgrid_compras.ReadOnly = true;
            this.dgrid_compras.RowHeadersVisible = false;
            this.dgrid_compras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_compras.Size = new System.Drawing.Size(356, 485);
            this.dgrid_compras.TabIndex = 28;
            this.dgrid_compras.VirtualMode = true;
            this.dgrid_compras.SelectionChanged += new System.EventHandler(this.dgrid_compras_SelectionChanged);
            // 
            // p_datosCompra
            // 
            this.p_datosCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_datosCompra.Controls.Add(this.txt_total);
            this.p_datosCompra.Controls.Add(this.txt_descuento);
            this.p_datosCompra.Controls.Add(this.dtp_fecha);
            this.p_datosCompra.Controls.Add(this.label4);
            this.p_datosCompra.Controls.Add(this.lbl_proveedor);
            this.p_datosCompra.Controls.Add(this.label7);
            this.p_datosCompra.Controls.Add(this.cb_ConProveedor);
            this.p_datosCompra.Controls.Add(this.cb_proveedor);
            this.p_datosCompra.Controls.Add(this.label5);
            this.p_datosCompra.Controls.Add(this.label3);
            this.p_datosCompra.Controls.Add(this.lbl_Subtotal);
            this.p_datosCompra.Controls.Add(this.lbl_formaPago);
            this.p_datosCompra.Controls.Add(this.cb_formaPago);
            this.p_datosCompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_datosCompra.Location = new System.Drawing.Point(0, 315);
            this.p_datosCompra.Name = "p_datosCompra";
            this.p_datosCompra.Size = new System.Drawing.Size(421, 201);
            this.p_datosCompra.TabIndex = 94;
            // 
            // txt_total
            // 
            this.txt_total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_total.CantDecimales = 2;
            this.txt_total.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_total.Location = new System.Drawing.Point(305, 88);
            this.txt_total.MaxLength = 8;
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(105, 31);
            this.txt_total.TabIndex = 54;
            this.txt_total.Text = "0";
            this.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_total.TextDefault = "0";
            this.txt_total.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            this.txt_total.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descuento_KeyPress);
            // 
            // txt_descuento
            // 
            this.txt_descuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descuento.CantDecimales = 2;
            this.txt_descuento.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_descuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descuento.Location = new System.Drawing.Point(305, 51);
            this.txt_descuento.MaxLength = 8;
            this.txt_descuento.Name = "txt_descuento";
            this.txt_descuento.Size = new System.Drawing.Size(105, 31);
            this.txt_descuento.TabIndex = 2;
            this.txt_descuento.Text = "0";
            this.txt_descuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_descuento.TextDefault = "0";
            this.txt_descuento.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_descuento.TextChanged += new System.EventHandler(this.txt_descuento_TextChanged);
            this.txt_descuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descuento_KeyPress);
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(26, 48);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(111, 31);
            this.dtp_fecha.TabIndex = 1;
            this.dtp_fecha.ValueChanged += new System.EventHandler(this.dtp_fecha_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(21, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Fecha :";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_proveedor.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_proveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_proveedor.Image = global::SIVS.Properties.Resources.Truck_1_;
            this.lbl_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_proveedor.Location = new System.Drawing.Point(42, 163);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(140, 25);
            this.lbl_proveedor.TabIndex = 51;
            this.lbl_proveedor.Text = "Proveedor :";
            this.lbl_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_proveedor.Click += new System.EventHandler(this.lbl_proveedor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(202, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 25);
            this.label7.TabIndex = 34;
            this.label7.Text = "Subtotal : $";
            // 
            // cb_ConProveedor
            // 
            this.cb_ConProveedor.AutoSize = true;
            this.cb_ConProveedor.Checked = true;
            this.cb_ConProveedor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_ConProveedor.Location = new System.Drawing.Point(26, 480);
            this.cb_ConProveedor.Name = "cb_ConProveedor";
            this.cb_ConProveedor.Size = new System.Drawing.Size(15, 14);
            this.cb_ConProveedor.TabIndex = 4;
            this.cb_ConProveedor.UseVisualStyleBackColor = true;
            this.cb_ConProveedor.CheckedChanged += new System.EventHandler(this.cb_ConProveedor_CheckedChanged);
            // 
            // cb_proveedor
            // 
            this.cb_proveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_proveedor.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_proveedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_proveedor.FormattingEnabled = true;
            this.cb_proveedor.Location = new System.Drawing.Point(196, 161);
            this.cb_proveedor.Name = "cb_proveedor";
            this.cb_proveedor.Size = new System.Drawing.Size(214, 31);
            this.cb_proveedor.TabIndex = 5;
            this.cb_proveedor.SelectedIndexChanged += new System.EventHandler(this.cb_proveedor_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(184, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Descuento : $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(227, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total : $";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Subtotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Subtotal.Location = new System.Drawing.Point(305, 14);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(105, 31);
            this.lbl_Subtotal.TabIndex = 41;
            this.lbl_Subtotal.Text = "0";
            this.lbl_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Subtotal.TextChanged += new System.EventHandler(this.txt_descuento_TextChanged);
            // 
            // lbl_formaPago
            // 
            this.lbl_formaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_formaPago.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_formaPago.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_formaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_formaPago.Image = global::SIVS.Properties.Resources.Debit_Card;
            this.lbl_formaPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_formaPago.Location = new System.Drawing.Point(8, 126);
            this.lbl_formaPago.Name = "lbl_formaPago";
            this.lbl_formaPago.Size = new System.Drawing.Size(182, 29);
            this.lbl_formaPago.TabIndex = 1;
            this.lbl_formaPago.Text = "  Forma de pago :";
            this.lbl_formaPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_formaPago.Click += new System.EventHandler(this.lbl_formaPago_Click);
            // 
            // cb_formaPago
            // 
            this.cb_formaPago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_formaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_formaPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_formaPago.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_formaPago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_formaPago.FormattingEnabled = true;
            this.cb_formaPago.Location = new System.Drawing.Point(196, 124);
            this.cb_formaPago.Name = "cb_formaPago";
            this.cb_formaPago.Size = new System.Drawing.Size(214, 31);
            this.cb_formaPago.TabIndex = 3;
            this.cb_formaPago.SelectedIndexChanged += new System.EventHandler(this.cb_formaPago_SelectedIndexChanged);
            // 
            // dgrid_Items
            // 
            this.dgrid_Items.AllowUserToAddRows = false;
            this.dgrid_Items.AllowUserToDeleteRows = false;
            this.dgrid_Items.AllowUserToResizeRows = false;
            this.dgrid_Items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_Items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Items.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_Items.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Items.Location = new System.Drawing.Point(0, 31);
            this.dgrid_Items.MultiSelect = false;
            this.dgrid_Items.Name = "dgrid_Items";
            this.dgrid_Items.ReadOnly = true;
            this.dgrid_Items.RowHeadersVisible = false;
            this.dgrid_Items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Items.Size = new System.Drawing.Size(421, 284);
            this.dgrid_Items.TabIndex = 59;
            this.dgrid_Items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_Items_MouseDoubleClick);
            // 
            // l_articulos
            // 
            this.l_articulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.l_articulos.Dock = System.Windows.Forms.DockStyle.Top;
            this.l_articulos.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.l_articulos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.l_articulos.Location = new System.Drawing.Point(0, 0);
            this.l_articulos.Name = "l_articulos";
            this.l_articulos.Size = new System.Drawing.Size(421, 31);
            this.l_articulos.TabIndex = 58;
            this.l_articulos.Text = "Articulos de la compra seleccionada";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantidad.CantDecimales = 2;
            this.txt_cantidad.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_cantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad.Location = new System.Drawing.Point(167, 266);
            this.txt_cantidad.MaxLength = 8;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(92, 29);
            this.txt_cantidad.TabIndex = 86;
            this.txt_cantidad.Text = "1";
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantidad.TextDefault = "1";
            this.txt_cantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_nuevoCosto_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // txt_IVA
            // 
            this.txt_IVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_IVA.CantDecimales = 2;
            this.txt_IVA.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_IVA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_IVA.Location = new System.Drawing.Point(168, 364);
            this.txt_IVA.MaxLength = 8;
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(92, 29);
            this.txt_IVA.TabIndex = 90;
            this.txt_IVA.Text = "1";
            this.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IVA.TextDefault = "1";
            this.txt_IVA.TextChanged += new System.EventHandler(this.txt_IVA_TextChanged);
            this.txt_IVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(57, 364);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 25);
            this.label19.TabIndex = 84;
            this.label19.Text = "Tasa IVA : %";
            // 
            // btn_AgregarItem
            // 
            this.btn_AgregarItem.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarItem.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_AgregarItem.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_AgregarItem.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_AgregarItem.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarItem.BackgroundImage = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_AgregarItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AgregarItem.FlatAppearance.BorderSize = 0;
            this.btn_AgregarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AgregarItem.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AgregarItem.ImageEnableFalse = null;
            this.btn_AgregarItem.ImageOnMouseDown = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_AgregarItem.ImageOnMouseEnter = global::SIVS.Properties.Resources.ModificaStock_32x32_flip;
            this.btn_AgregarItem.ImageOnNothing = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_AgregarItem.Location = new System.Drawing.Point(161, 474);
            this.btn_AgregarItem.Name = "btn_AgregarItem";
            this.btn_AgregarItem.Size = new System.Drawing.Size(224, 32);
            this.btn_AgregarItem.TabIndex = 93;
            this.btn_AgregarItem.Text = "     Agregar a la compra";
            this.tt_mensaje.SetToolTip(this.btn_AgregarItem, "F6");
            this.btn_AgregarItem.UseVisualStyleBackColor = false;
            this.btn_AgregarItem.Click += new System.EventHandler(this.btn_AgregarItem_Click);
            // 
            // txt_PorcGanancia
            // 
            this.txt_PorcGanancia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PorcGanancia.CantDecimales = 2;
            this.txt_PorcGanancia.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_PorcGanancia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PorcGanancia.Location = new System.Drawing.Point(431, 299);
            this.txt_PorcGanancia.MaxLength = 8;
            this.txt_PorcGanancia.Name = "txt_PorcGanancia";
            this.txt_PorcGanancia.Size = new System.Drawing.Size(86, 29);
            this.txt_PorcGanancia.TabIndex = 92;
            this.txt_PorcGanancia.Text = "1";
            this.txt_PorcGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PorcGanancia.TextDefault = null;
            this.txt_PorcGanancia.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_PorcGanancia.TextChanged += new System.EventHandler(this.txt_PorcGanancia_TextChanged);
            this.txt_PorcGanancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_precio.CantDecimales = 2;
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_precio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_precio.Location = new System.Drawing.Point(431, 331);
            this.txt_precio.MaxLength = 8;
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(86, 29);
            this.txt_precio.TabIndex = 91;
            this.txt_precio.Text = "1";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_precio.TextDefault = "1";
            this.txt_precio.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_nuevoPrecio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // txt_costoUnitario
            // 
            this.txt_costoUnitario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costoUnitario.CantDecimales = 2;
            this.txt_costoUnitario.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_costoUnitario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costoUnitario.Location = new System.Drawing.Point(168, 397);
            this.txt_costoUnitario.MaxLength = 8;
            this.txt_costoUnitario.Name = "txt_costoUnitario";
            this.txt_costoUnitario.Size = new System.Drawing.Size(92, 29);
            this.txt_costoUnitario.TabIndex = 87;
            this.txt_costoUnitario.Text = "1";
            this.txt_costoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_costoUnitario.TextDefault = "1";
            this.txt_costoUnitario.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_costoUnitario.TextChanged += new System.EventHandler(this.txt_nuevoCosto_TextChanged);
            this.txt_costoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costoTotal.CantDecimales = 2;
            this.txt_costoTotal.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_costoTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costoTotal.Location = new System.Drawing.Point(168, 430);
            this.txt_costoTotal.MaxLength = 8;
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(92, 29);
            this.txt_costoTotal.TabIndex = 88;
            this.txt_costoTotal.Text = "0";
            this.txt_costoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_costoTotal.TextDefault = "0";
            this.txt_costoTotal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_costoTotal.TextChanged += new System.EventHandler(this.txt_costoTotal_TextChanged);
            this.txt_costoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // p_articulo
            // 
            this.p_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_articulo.Controls.Add(this.txt_costoSinImp);
            this.p_articulo.Controls.Add(this.label26);
            this.p_articulo.Controls.Add(this.txt_imp);
            this.p_articulo.Controls.Add(this.label25);
            this.p_articulo.Controls.Add(this.label24);
            this.p_articulo.Controls.Add(this.label23);
            this.p_articulo.Controls.Add(this.label22);
            this.p_articulo.Controls.Add(this.txt_cantAlta);
            this.p_articulo.Controls.Add(this.txt_cantMedia);
            this.p_articulo.Controls.Add(this.txt_cantBaja);
            this.p_articulo.Controls.Add(this.label21);
            this.p_articulo.Controls.Add(this.txt_cantidad);
            this.p_articulo.Controls.Add(this.btn_AgregarItem);
            this.p_articulo.Controls.Add(this.btn_buscarArticulo);
            this.p_articulo.Controls.Add(this.label20);
            this.p_articulo.Controls.Add(this.txt_IVA);
            this.p_articulo.Controls.Add(this.txt_nota);
            this.p_articulo.Controls.Add(this.lbl_cantHistorica);
            this.p_articulo.Controls.Add(this.label19);
            this.p_articulo.Controls.Add(this.label18);
            this.p_articulo.Controls.Add(this.cb_Rubro);
            this.p_articulo.Controls.Add(this.lbl_rubro);
            this.p_articulo.Controls.Add(this.txt_PorcGanancia);
            this.p_articulo.Controls.Add(this.txt_stock);
            this.p_articulo.Controls.Add(this.txt_precio);
            this.p_articulo.Controls.Add(this.lbl_medida);
            this.p_articulo.Controls.Add(this.label2);
            this.p_articulo.Controls.Add(this.lbl_Nota_Registros);
            this.p_articulo.Controls.Add(this.label15);
            this.p_articulo.Controls.Add(this.label8);
            this.p_articulo.Controls.Add(this.lbl_ActualPrecio);
            this.p_articulo.Controls.Add(this.cb_medidas);
            this.p_articulo.Controls.Add(this.label11);
            this.p_articulo.Controls.Add(this.lbl_ActualCosto);
            this.p_articulo.Controls.Add(this.txt_costoUnitario);
            this.p_articulo.Controls.Add(this.label14);
            this.p_articulo.Controls.Add(this.label13);
            this.p_articulo.Controls.Add(this.txt_costoTotal);
            this.p_articulo.Controls.Add(this.label9);
            this.p_articulo.Controls.Add(this.label12);
            this.p_articulo.Controls.Add(this.txt_descripcion);
            this.p_articulo.Controls.Add(this.label6);
            this.p_articulo.Controls.Add(this.txt_costoPonderado);
            this.p_articulo.Controls.Add(this.lbl_costoPonderado);
            this.p_articulo.Controls.Add(this.txt_codigo);
            this.p_articulo.Controls.Add(this.label10);
            this.p_articulo.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_articulo.Location = new System.Drawing.Point(793, 8);
            this.p_articulo.Name = "p_articulo";
            this.p_articulo.Size = new System.Drawing.Size(530, 516);
            this.p_articulo.TabIndex = 52;
            this.p_articulo.Paint += new System.Windows.Forms.PaintEventHandler(this.gb_Articulo3_Paint);
            // 
            // txt_costoSinImp
            // 
            this.txt_costoSinImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costoSinImp.CantDecimales = 2;
            this.txt_costoSinImp.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_costoSinImp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costoSinImp.Location = new System.Drawing.Point(168, 299);
            this.txt_costoSinImp.MaxLength = 8;
            this.txt_costoSinImp.Name = "txt_costoSinImp";
            this.txt_costoSinImp.Size = new System.Drawing.Size(92, 29);
            this.txt_costoSinImp.TabIndex = 106;
            this.txt_costoSinImp.Text = "1";
            this.txt_costoSinImp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_costoSinImp.TextDefault = "1";
            this.txt_costoSinImp.TextChanged += new System.EventHandler(this.txt_costoSinImp_TextChanged);
            this.txt_costoSinImp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label26.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label26.Location = new System.Drawing.Point(0, 301);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(168, 25);
            this.label26.TabIndex = 105;
            this.label26.Text = "Costo Unid. S/imp: $";
            // 
            // txt_imp
            // 
            this.txt_imp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_imp.CantDecimales = 2;
            this.txt_imp.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_imp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_imp.Location = new System.Drawing.Point(168, 331);
            this.txt_imp.MaxLength = 8;
            this.txt_imp.Name = "txt_imp";
            this.txt_imp.Size = new System.Drawing.Size(92, 29);
            this.txt_imp.TabIndex = 104;
            this.txt_imp.Text = "3,5";
            this.txt_imp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_imp.TextDefault = "1";
            this.txt_imp.TextChanged += new System.EventHandler(this.txt_IVA_TextChanged);
            this.txt_imp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnitario_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label25.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label25.Location = new System.Drawing.Point(36, 333);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(126, 25);
            this.label25.TabIndex = 103;
            this.label25.Text = "Tasa de IIBB: %";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(405, 216);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 25);
            this.label24.TabIndex = 102;
            this.label24.Text = "Alto:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label23.Location = new System.Drawing.Point(257, 216);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 25);
            this.label23.TabIndex = 101;
            this.label23.Text = "Medio:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(143, 213);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 25);
            this.label22.TabIndex = 100;
            this.label22.Text = "Bajo:";
            // 
            // txt_cantAlta
            // 
            this.txt_cantAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantAlta.CantDecimales = 2;
            this.txt_cantAlta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cantAlta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantAlta.Location = new System.Drawing.Point(460, 213);
            this.txt_cantAlta.Name = "txt_cantAlta";
            this.txt_cantAlta.Size = new System.Drawing.Size(59, 31);
            this.txt_cantAlta.TabIndex = 99;
            this.txt_cantAlta.Text = "3";
            this.txt_cantAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantAlta.TextDefault = "3";
            // 
            // txt_cantMedia
            // 
            this.txt_cantMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantMedia.CantDecimales = 2;
            this.txt_cantMedia.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cantMedia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantMedia.Location = new System.Drawing.Point(332, 213);
            this.txt_cantMedia.Name = "txt_cantMedia";
            this.txt_cantMedia.Size = new System.Drawing.Size(59, 31);
            this.txt_cantMedia.TabIndex = 98;
            this.txt_cantMedia.Text = "2";
            this.txt_cantMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantMedia.TextDefault = "2";
            // 
            // txt_cantBaja
            // 
            this.txt_cantBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantBaja.CantDecimales = 2;
            this.txt_cantBaja.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cantBaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantBaja.Location = new System.Drawing.Point(192, 213);
            this.txt_cantBaja.Name = "txt_cantBaja";
            this.txt_cantBaja.Size = new System.Drawing.Size(59, 31);
            this.txt_cantBaja.TabIndex = 97;
            this.txt_cantBaja.Text = "1";
            this.txt_cantBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantBaja.TextDefault = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(7, 213);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 25);
            this.label21.TabIndex = 96;
            this.label21.Text = "Niveles de stock:";
            // 
            // btn_buscarArticulo
            // 
            this.btn_buscarArticulo.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_buscarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_buscarArticulo.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_buscarArticulo.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_buscarArticulo.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_buscarArticulo.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_buscarArticulo.BackgroundImage = global::SIVS.Properties.Resources.buscar_32;
            this.btn_buscarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_buscarArticulo.FlatAppearance.BorderSize = 0;
            this.btn_buscarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscarArticulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_buscarArticulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_buscarArticulo.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_buscarArticulo.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_buscarArticulo.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_buscarArticulo.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_buscarArticulo.Location = new System.Drawing.Point(297, 36);
            this.btn_buscarArticulo.Name = "btn_buscarArticulo";
            this.btn_buscarArticulo.Size = new System.Drawing.Size(32, 32);
            this.btn_buscarArticulo.TabIndex = 95;
            this.btn_buscarArticulo.UseVisualStyleBackColor = false;
            this.btn_buscarArticulo.Click += new System.EventHandler(this.btn_buscarArticulo_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label20.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label20.Location = new System.Drawing.Point(9, 108);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(58, 25);
            this.label20.TabIndex = 82;
            this.label20.Text = "Nota :";
            // 
            // txt_nota
            // 
            this.txt_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nota.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_nota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nota.Location = new System.Drawing.Point(121, 108);
            this.txt_nota.MaxLength = 300;
            this.txt_nota.Multiline = true;
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(400, 34);
            this.txt_nota.TabIndex = 83;
            // 
            // lbl_cantHistorica
            // 
            this.lbl_cantHistorica.AutoSize = true;
            this.lbl_cantHistorica.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_cantHistorica.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_cantHistorica.Location = new System.Drawing.Point(443, 147);
            this.lbl_cantHistorica.Name = "lbl_cantHistorica";
            this.lbl_cantHistorica.Size = new System.Drawing.Size(21, 25);
            this.lbl_cantHistorica.TabIndex = 58;
            this.lbl_cantHistorica.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(292, 146);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 25);
            this.label18.TabIndex = 57;
            this.label18.Text = "Existencia histórica:";
            // 
            // cb_Rubro
            // 
            this.cb_Rubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Rubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Rubro.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_Rubro.ForeColor = System.Drawing.Color.White;
            this.cb_Rubro.FormattingEnabled = true;
            this.cb_Rubro.Location = new System.Drawing.Point(348, 175);
            this.cb_Rubro.Name = "cb_Rubro";
            this.cb_Rubro.Size = new System.Drawing.Size(173, 33);
            this.cb_Rubro.TabIndex = 85;
            // 
            // lbl_rubro
            // 
            this.lbl_rubro.AutoSize = true;
            this.lbl_rubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_rubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_rubro.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_rubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_rubro.Location = new System.Drawing.Point(268, 175);
            this.lbl_rubro.Name = "lbl_rubro";
            this.lbl_rubro.Size = new System.Drawing.Size(74, 30);
            this.lbl_rubro.TabIndex = 77;
            this.lbl_rubro.Text = "Rubro :";
            this.lbl_rubro.Click += new System.EventHandler(this.lbl_rubro_Click);
            // 
            // txt_stock
            // 
            this.txt_stock.AutoSize = true;
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_stock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_stock.Location = new System.Drawing.Point(405, 39);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(21, 25);
            this.txt_stock.TabIndex = 56;
            this.txt_stock.Text = "0";
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_medida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_medida.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_medida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_medida.Location = new System.Drawing.Point(7, 175);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(86, 30);
            this.lbl_medida.TabIndex = 80;
            this.lbl_medida.Text = "Medida :";
            this.lbl_medida.Click += new System.EventHandler(this.lbl_medida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(264, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Precio a público :  $";
            // 
            // lbl_Nota_Registros
            // 
            this.lbl_Nota_Registros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_Nota_Registros.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Nota_Registros.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Nota_Registros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Nota_Registros.Location = new System.Drawing.Point(0, 0);
            this.lbl_Nota_Registros.Name = "lbl_Nota_Registros";
            this.lbl_Nota_Registros.Size = new System.Drawing.Size(530, 31);
            this.lbl_Nota_Registros.TabIndex = 55;
            this.lbl_Nota_Registros.Text = "Registros";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(261, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(171, 25);
            this.label15.TabIndex = 41;
            this.label15.Text = "Ganancia / Costo : %";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(30, 432);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Costo Total :    $";
            // 
            // lbl_ActualPrecio
            // 
            this.lbl_ActualPrecio.AutoSize = true;
            this.lbl_ActualPrecio.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_ActualPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ActualPrecio.Location = new System.Drawing.Point(230, 146);
            this.lbl_ActualPrecio.Name = "lbl_ActualPrecio";
            this.lbl_ActualPrecio.Size = new System.Drawing.Size(21, 25);
            this.lbl_ActualPrecio.TabIndex = 54;
            this.lbl_ActualPrecio.Text = "0";
            // 
            // cb_medidas
            // 
            this.cb_medidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_medidas.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_medidas.ForeColor = System.Drawing.Color.White;
            this.cb_medidas.FormattingEnabled = true;
            this.cb_medidas.Location = new System.Drawing.Point(96, 175);
            this.cb_medidas.Name = "cb_medidas";
            this.cb_medidas.Size = new System.Drawing.Size(154, 33);
            this.cb_medidas.TabIndex = 84;
            this.cb_medidas.SelectedIndexChanged += new System.EventHandler(this.cb_medidas_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(73, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 25);
            this.label11.TabIndex = 33;
            this.label11.Text = "Cantidad :";
            // 
            // lbl_ActualCosto
            // 
            this.lbl_ActualCosto.AutoSize = true;
            this.lbl_ActualCosto.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_ActualCosto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ActualCosto.Location = new System.Drawing.Point(79, 146);
            this.lbl_ActualCosto.Name = "lbl_ActualCosto";
            this.lbl_ActualCosto.Size = new System.Drawing.Size(21, 25);
            this.lbl_ActualCosto.TabIndex = 53;
            this.lbl_ActualCosto.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label14.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label14.Location = new System.Drawing.Point(156, 146);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 25);
            this.label14.TabIndex = 52;
            this.label14.Text = "Precio : $";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(9, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 25);
            this.label13.TabIndex = 51;
            this.label13.Text = "Costo : $";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(341, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 3;
            this.label9.Text = "Stock :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(-2, 398);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(170, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "Costo Unid. C/imp: $";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descripcion.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descripcion.Location = new System.Drawing.Point(121, 71);
            this.txt_descripcion.MaxLength = 100;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(400, 31);
            this.txt_descripcion.TabIndex = 82;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(7, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Descripción :";
            // 
            // txt_costoPonderado
            // 
            this.txt_costoPonderado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costoPonderado.Enabled = false;
            this.txt_costoPonderado.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_costoPonderado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costoPonderado.Location = new System.Drawing.Point(431, 266);
            this.txt_costoPonderado.Name = "txt_costoPonderado";
            this.txt_costoPonderado.Size = new System.Drawing.Size(86, 29);
            this.txt_costoPonderado.TabIndex = 46;
            this.txt_costoPonderado.Text = "0";
            this.txt_costoPonderado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_costoPonderado.TextChanged += new System.EventHandler(this.txt_PorcGanancia_TextChanged);
            // 
            // lbl_costoPonderado
            // 
            this.lbl_costoPonderado.AutoSize = true;
            this.lbl_costoPonderado.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_costoPonderado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_costoPonderado.Location = new System.Drawing.Point(264, 268);
            this.lbl_costoPonderado.Name = "lbl_costoPonderado";
            this.lbl_costoPonderado.Size = new System.Drawing.Size(167, 25);
            this.lbl_costoPonderado.TabIndex = 47;
            this.lbl_costoPonderado.Text = "Costo Ponderado : $";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(121, 36);
            this.txt_codigo.MaxLength = 20;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(170, 31);
            this.txt_codigo.TabIndex = 81;
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(7, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Código :";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Compras";
            // 
            // btn_verMas
            // 
            this.btn_verMas.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_verMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_verMas.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_verMas.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_verMas.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_verMas.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_verMas.BackgroundImage = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_verMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_verMas.FlatAppearance.BorderSize = 0;
            this.btn_verMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verMas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_verMas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_verMas.ImageEnableFalse = null;
            this.btn_verMas.ImageOnMouseDown = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_verMas.ImageOnMouseEnter = global::SIVS.Properties.Resources.ModificaStock_32x32_flip;
            this.btn_verMas.ImageOnNothing = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_verMas.Location = new System.Drawing.Point(356, 10);
            this.btn_verMas.Name = "btn_verMas";
            this.btn_verMas.Size = new System.Drawing.Size(110, 32);
            this.btn_verMas.TabIndex = 94;
            this.btn_verMas.Text = "     Ver +";
            this.tt_mensaje.SetToolTip(this.btn_verMas, "F5");
            this.btn_verMas.UseVisualStyleBackColor = false;
            this.btn_verMas.Click += new System.EventHandler(this.btn_verMas_Click);
            // 
            // Frm_ABM_compras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1331, 582);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 620);
            this.Name = "Frm_ABM_compras";
            this.Text = "Gestión de compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_ABM_compras_FormClosing);
            this.Load += new System.EventHandler(this.Frm_ABM_compras_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_compras_KeyDown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_compras)).EndInit();
            this.p_datosCompra.ResumeLayout(false);
            this.p_datosCompra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Items)).EndInit();
            this.p_articulo.ResumeLayout(false);
            this.p_articulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_FormasDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Proveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Compras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_medidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_compras;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_formaPago;
        private System.Windows.Forms.Label lbl_formaPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_costoPonderado;
        private System.Windows.Forms.Label lbl_costoPonderado;
        private System.Windows.Forms.BindingSource bs_FormasDePago;
        private System.Windows.Forms.ComboBox cb_proveedor;
        private System.Windows.Forms.BindingSource bs_Proveedores;
        private System.Windows.Forms.CheckBox cb_ConProveedor;
        private System.Windows.Forms.BindingSource bs_Items;
        private System.Windows.Forms.BindingSource bs_Compras;
        private System.Windows.Forms.Panel p_articulo;
        private System.Windows.Forms.Label lbl_Nota_Registros;
        private System.Windows.Forms.Label lbl_ActualPrecio;
        private System.Windows.Forms.Label lbl_ActualCosto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txt_stock;
        private System.Windows.Forms.Label lbl_cantHistorica;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel p_datosCompra;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.BindingSource bs_rubros;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        private System.Windows.Forms.Label label4;
        private CONTROLES.TextBox_Decimal txt_total;
        private CONTROLES.TextBox_Decimal txt_descuento;
        private CONTROLES.TextBox_Decimal txt_PorcGanancia;
        private CONTROLES.TextBox_Decimal txt_precio;
        private CONTROLES.TextBox_Decimal txt_costoUnitario;
        private CONTROLES.TextBox_Decimal txt_costoTotal;
        private CONTROLES.ButtonImages btn_AgregarItem;
        private System.Windows.Forms.ComboBox cb_Rubro;
        private System.Windows.Forms.Label lbl_rubro;
        private System.Windows.Forms.ComboBox cb_medidas;
        private System.Windows.Forms.BindingSource bs_medidas;
        private System.Windows.Forms.Label lbl_medida;
        private CONTROLES.TextBox_Decimal txt_IVA;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txt_nota;
        private CONTROLES.TextBox_Decimal txt_cantidad;
        private System.Windows.Forms.Label label20;
        private CONTROLES.ButtonImages btn_buscarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private CONTROLES.TextBox_Decimal txt_cantAlta;
        private CONTROLES.TextBox_Decimal txt_cantMedia;
        private CONTROLES.TextBox_Decimal txt_cantBaja;
        private System.Windows.Forms.DataGridView dgrid_Items;
        private System.Windows.Forms.Label l_articulos;
        private CONTROLES.TextBox_Decimal txt_costoSinImp;
        private System.Windows.Forms.Label label26;
        private CONTROLES.TextBox_Decimal txt_imp;
        private System.Windows.Forms.Label label25;
        private CONTROLES.ButtonImages btn_verMas;
    }
}
