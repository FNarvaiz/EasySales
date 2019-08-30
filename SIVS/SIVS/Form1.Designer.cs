namespace SIVS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.p_adicional = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_adicionalFijo = new CONTROLES.TextBox_Decimal();
            this.txt_adicional = new CONTROLES.TextBox_Decimal();
            this.cb_adicional = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rb_descuento = new System.Windows.Forms.RadioButton();
            this.rb_recargo = new System.Windows.Forms.RadioButton();
            this.p_detalles = new System.Windows.Forms.Panel();
            this.btn_vuelto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_registros = new System.Windows.Forms.Label();
            this.btn_nuevoCobro = new CONTROLES.ButtonImages();
            this.btn_nuevoGasto = new CONTROLES.ButtonImages();
            this.btn_Imprimir = new CONTROLES.ButtonImages();
            this.btn_devolucion = new CONTROLES.ButtonImages();
            this.lbl_usuario = new System.Windows.Forms.Label();
            this.p_vuelto = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_vuelto = new System.Windows.Forms.Label();
            this.txt_monto = new CONTROLES.TextBox_Decimal();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_pagacon = new System.Windows.Forms.Label();
            this.lbl_Total2 = new System.Windows.Forms.Label();
            this.btn_AbrirCaja = new CONTROLES.ButtonImages();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_permiso = new System.Windows.Forms.Label();
            this.tt_mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.cb_CuentasClientes = new System.Windows.Forms.ComboBox();
            this.cb_FormasPagos = new System.Windows.Forms.ComboBox();
            this.txt_codAutorizacion = new System.Windows.Forms.TextBox();
            this.lbl_articulos = new System.Windows.Forms.Label();
            this.txt_cantidad = new CONTROLES.TextBox_Decimal();
            this.btn_CerrarVenta = new CONTROLES.ButtonImages();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.ts_Articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Articulos = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Rubros = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_Uni_medida = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_ActualizarPrecios = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_CajaDiaria = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_TableroControl = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlStock = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlCtasCtes = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlFormasPago = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlGastos = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlRubros = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_ControlMercaderia = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_CVentasArticulos = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_compras = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Ventas = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_CuentasCorrientes = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasCorrientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CtaCteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CtaCteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_CtaCteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Clientes = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Permisos = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_FormasPagos = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Localidades = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_Cajas = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_configuraciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_backup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_configuracion = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_login = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_soporte = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_admin = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_grande = new System.Windows.Forms.GroupBox();
            this.dgrid_items = new System.Windows.Forms.DataGridView();
            this.p_articulo = new System.Windows.Forms.Panel();
            this.p_precio = new System.Windows.Forms.Panel();
            this.lbl_PrecioTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_unidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.p_descripcion = new System.Windows.Forms.Panel();
            this.lbl_art = new System.Windows.Forms.Label();
            this.p_grande = new System.Windows.Forms.Panel();
            this.p_autorizacion = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_2formasPago = new System.Windows.Forms.CheckBox();
            this.p_cuentacorriente = new System.Windows.Forms.Panel();
            this.lbl_Cuentas = new System.Windows.Forms.Label();
            this.cb_imprimir = new System.Windows.Forms.CheckBox();
            this.p_formapago = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.bs_FormasDePago = new System.Windows.Forms.BindingSource(this.components);
            this.bs_venta = new System.Windows.Forms.BindingSource(this.components);
            this.bs_CuentasClientes = new System.Windows.Forms.BindingSource(this.components);
            this.bs_formasDePago2 = new System.Windows.Forms.BindingSource(this.components);
            this.p_adicional.SuspendLayout();
            this.p_detalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.p_vuelto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ms_menu.SuspendLayout();
            this.gb_grande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_items)).BeginInit();
            this.p_articulo.SuspendLayout();
            this.p_precio.SuspendLayout();
            this.p_descripcion.SuspendLayout();
            this.p_grande.SuspendLayout();
            this.p_autorizacion.SuspendLayout();
            this.p_cuentacorriente.SuspendLayout();
            this.p_formapago.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_FormasDePago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_venta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CuentasClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_formasDePago2)).BeginInit();
            this.SuspendLayout();
            // 
            // p_adicional
            // 
            this.p_adicional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.p_adicional.Controls.Add(this.label8);
            this.p_adicional.Controls.Add(this.txt_adicionalFijo);
            this.p_adicional.Controls.Add(this.txt_adicional);
            this.p_adicional.Controls.Add(this.cb_adicional);
            this.p_adicional.Controls.Add(this.label7);
            this.p_adicional.Controls.Add(this.rb_descuento);
            this.p_adicional.Controls.Add(this.rb_recargo);
            this.p_adicional.ForeColor = System.Drawing.Color.LightGray;
            this.p_adicional.Location = new System.Drawing.Point(29, 472);
            this.p_adicional.Name = "p_adicional";
            this.p_adicional.Size = new System.Drawing.Size(186, 188);
            this.p_adicional.TabIndex = 98;
            this.p_adicional.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(3, 152);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 99;
            this.label8.Text = "Monto fijo:";
            // 
            // txt_adicionalFijo
            // 
            this.txt_adicionalFijo.CantDecimales = 2;
            this.txt_adicionalFijo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_adicionalFijo.Location = new System.Drawing.Point(100, 149);
            this.txt_adicionalFijo.Name = "txt_adicionalFijo";
            this.txt_adicionalFijo.Size = new System.Drawing.Size(82, 31);
            this.txt_adicionalFijo.TabIndex = 98;
            this.txt_adicionalFijo.Text = "0";
            this.txt_adicionalFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adicionalFijo.TextDefault = "0";
            this.txt_adicionalFijo.TextChanged += new System.EventHandler(this.txt_adicionalFijo_TextChanged);
            this.txt_adicionalFijo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_adicionalFijo_KeyDown);
            this.txt_adicionalFijo.Leave += new System.EventHandler(this.txt_adicionalFijo_Leave);
            // 
            // txt_adicional
            // 
            this.txt_adicional.CantDecimales = 2;
            this.txt_adicional.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_adicional.Location = new System.Drawing.Point(117, 108);
            this.txt_adicional.Name = "txt_adicional";
            this.txt_adicional.Size = new System.Drawing.Size(65, 31);
            this.txt_adicional.TabIndex = 97;
            this.txt_adicional.Text = "0";
            this.txt_adicional.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_adicional.TextDefault = "0";
            this.txt_adicional.TextChanged += new System.EventHandler(this.txt_adicional_TextChanged);
            this.txt_adicional.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_adicional_KeyDown);
            this.txt_adicional.Leave += new System.EventHandler(this.txt_adicional_Leave);
            // 
            // cb_adicional
            // 
            this.cb_adicional.AutoSize = true;
            this.cb_adicional.BackColor = System.Drawing.Color.Transparent;
            this.cb_adicional.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_adicional.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_adicional.Location = new System.Drawing.Point(9, 16);
            this.cb_adicional.Name = "cb_adicional";
            this.cb_adicional.Size = new System.Drawing.Size(150, 29);
            this.cb_adicional.TabIndex = 90;
            this.cb_adicional.Text = "Incluir adicional";
            this.cb_adicional.UseVisualStyleBackColor = false;
            this.cb_adicional.CheckedChanged += new System.EventHandler(this.lbl_Subtotal_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(4, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 92;
            this.label7.Text = "Porcentaje: %";
            // 
            // rb_descuento
            // 
            this.rb_descuento.AutoSize = true;
            this.rb_descuento.BackColor = System.Drawing.Color.Transparent;
            this.rb_descuento.Checked = true;
            this.rb_descuento.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rb_descuento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_descuento.Location = new System.Drawing.Point(9, 77);
            this.rb_descuento.Name = "rb_descuento";
            this.rb_descuento.Size = new System.Drawing.Size(110, 29);
            this.rb_descuento.TabIndex = 94;
            this.rb_descuento.TabStop = true;
            this.rb_descuento.Text = "Descuento";
            this.rb_descuento.UseVisualStyleBackColor = false;
            this.rb_descuento.CheckedChanged += new System.EventHandler(this.lbl_Subtotal_TextChanged);
            // 
            // rb_recargo
            // 
            this.rb_recargo.AutoSize = true;
            this.rb_recargo.BackColor = System.Drawing.Color.Transparent;
            this.rb_recargo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rb_recargo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_recargo.Location = new System.Drawing.Point(9, 47);
            this.rb_recargo.Name = "rb_recargo";
            this.rb_recargo.Size = new System.Drawing.Size(92, 29);
            this.rb_recargo.TabIndex = 93;
            this.rb_recargo.Text = "Recargo";
            this.rb_recargo.UseVisualStyleBackColor = false;
            // 
            // p_detalles
            // 
            this.p_detalles.AutoSize = true;
            this.p_detalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(72)))));
            this.p_detalles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_detalles.Controls.Add(this.p_adicional);
            this.p_detalles.Controls.Add(this.btn_vuelto);
            this.p_detalles.Controls.Add(this.pictureBox1);
            this.p_detalles.Controls.Add(this.flowLayoutPanel1);
            this.p_detalles.Controls.Add(this.lbl_usuario);
            this.p_detalles.Controls.Add(this.p_vuelto);
            this.p_detalles.Controls.Add(this.btn_AbrirCaja);
            this.p_detalles.Controls.Add(this.pictureBox2);
            this.p_detalles.Controls.Add(this.lbl_permiso);
            this.p_detalles.Location = new System.Drawing.Point(1043, 78);
            this.p_detalles.Name = "p_detalles";
            this.p_detalles.Size = new System.Drawing.Size(238, 676);
            this.p_detalles.TabIndex = 88;
            this.p_detalles.MouseEnter += new System.EventHandler(this.p_detalles_MouseEnter);
            this.p_detalles.MouseLeave += new System.EventHandler(this.p_detalles_MouseLeave);
            // 
            // btn_vuelto
            // 
            this.btn_vuelto.FlatAppearance.BorderSize = 0;
            this.btn_vuelto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vuelto.Image = global::SIVS.Properties.Resources.Board_Pin_1;
            this.btn_vuelto.Location = new System.Drawing.Point(0, 0);
            this.btn_vuelto.Name = "btn_vuelto";
            this.btn_vuelto.Size = new System.Drawing.Size(27, 27);
            this.btn_vuelto.TabIndex = 98;
            this.btn_vuelto.Tag = "1";
            this.btn_vuelto.UseVisualStyleBackColor = true;
            this.btn_vuelto.Click += new System.EventHandler(this.btn_vuelto_Click);
            this.btn_vuelto.MouseEnter += new System.EventHandler(this.p_detalles_MouseEnter);
            this.btn_vuelto.MouseLeave += new System.EventHandler(this.p_detalles_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::SIVS.Properties.Resources.User;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(17, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.flowLayoutPanel1.Controls.Add(this.lbl_registros);
            this.flowLayoutPanel1.Controls.Add(this.btn_nuevoCobro);
            this.flowLayoutPanel1.Controls.Add(this.btn_nuevoGasto);
            this.flowLayoutPanel1.Controls.Add(this.btn_Imprimir);
            this.flowLayoutPanel1.Controls.Add(this.btn_devolucion);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(26, 255);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(186, 194);
            this.flowLayoutPanel1.TabIndex = 104;
            this.flowLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseClick);
            // 
            // lbl_registros
            // 
            this.lbl_registros.AutoSize = true;
            this.lbl_registros.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_registros.ForeColor = System.Drawing.Color.White;
            this.lbl_registros.Location = new System.Drawing.Point(3, 0);
            this.lbl_registros.Name = "lbl_registros";
            this.lbl_registros.Size = new System.Drawing.Size(82, 25);
            this.lbl_registros.TabIndex = 109;
            this.lbl_registros.Text = "Registrar";
            this.lbl_registros.Visible = false;
            // 
            // btn_nuevoCobro
            // 
            this.btn_nuevoCobro.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nuevoCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_nuevoCobro.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_nuevoCobro.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(44)))));
            this.btn_nuevoCobro.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_nuevoCobro.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_nuevoCobro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevoCobro.BackgroundImage")));
            this.btn_nuevoCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nuevoCobro.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_nuevoCobro.FlatAppearance.BorderSize = 0;
            this.btn_nuevoCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoCobro.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btn_nuevoCobro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_nuevoCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoCobro.ImageEnableFalse = ((System.Drawing.Image)(resources.GetObject("btn_nuevoCobro.ImageEnableFalse")));
            this.btn_nuevoCobro.ImageOnMouseDown = ((System.Drawing.Image)(resources.GetObject("btn_nuevoCobro.ImageOnMouseDown")));
            this.btn_nuevoCobro.ImageOnMouseEnter = ((System.Drawing.Image)(resources.GetObject("btn_nuevoCobro.ImageOnMouseEnter")));
            this.btn_nuevoCobro.ImageOnNothing = ((System.Drawing.Image)(resources.GetObject("btn_nuevoCobro.ImageOnNothing")));
            this.btn_nuevoCobro.Location = new System.Drawing.Point(3, 28);
            this.btn_nuevoCobro.Name = "btn_nuevoCobro";
            this.btn_nuevoCobro.Size = new System.Drawing.Size(179, 32);
            this.btn_nuevoCobro.TabIndex = 107;
            this.btn_nuevoCobro.Tag = "1";
            this.btn_nuevoCobro.Text = "     Nuevo cobro";
            this.btn_nuevoCobro.UseVisualStyleBackColor = false;
            this.btn_nuevoCobro.Visible = false;
            this.btn_nuevoCobro.Click += new System.EventHandler(this.btn_nuevoCobro_Click);
            // 
            // btn_nuevoGasto
            // 
            this.btn_nuevoGasto.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_nuevoGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_nuevoGasto.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_nuevoGasto.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(44)))));
            this.btn_nuevoGasto.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_nuevoGasto.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_nuevoGasto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevoGasto.BackgroundImage")));
            this.btn_nuevoGasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_nuevoGasto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_nuevoGasto.FlatAppearance.BorderSize = 0;
            this.btn_nuevoGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoGasto.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btn_nuevoGasto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_nuevoGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nuevoGasto.ImageEnableFalse = ((System.Drawing.Image)(resources.GetObject("btn_nuevoGasto.ImageEnableFalse")));
            this.btn_nuevoGasto.ImageOnMouseDown = ((System.Drawing.Image)(resources.GetObject("btn_nuevoGasto.ImageOnMouseDown")));
            this.btn_nuevoGasto.ImageOnMouseEnter = ((System.Drawing.Image)(resources.GetObject("btn_nuevoGasto.ImageOnMouseEnter")));
            this.btn_nuevoGasto.ImageOnNothing = ((System.Drawing.Image)(resources.GetObject("btn_nuevoGasto.ImageOnNothing")));
            this.btn_nuevoGasto.Location = new System.Drawing.Point(3, 66);
            this.btn_nuevoGasto.Name = "btn_nuevoGasto";
            this.btn_nuevoGasto.Size = new System.Drawing.Size(179, 32);
            this.btn_nuevoGasto.TabIndex = 108;
            this.btn_nuevoGasto.Tag = "1";
            this.btn_nuevoGasto.Text = "    Nuevo gasto";
            this.btn_nuevoGasto.UseVisualStyleBackColor = false;
            this.btn_nuevoGasto.Visible = false;
            this.btn_nuevoGasto.Click += new System.EventHandler(this.btn_nuevoGasto_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Imprimir.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Imprimir.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(44)))));
            this.btn_Imprimir.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Imprimir.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Imprimir.BackgroundImage = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Imprimir.FlatAppearance.BorderSize = 0;
            this.btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Imprimir.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btn_Imprimir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Imprimir.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Imprimir.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Imprimir.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Imprimir.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Imprimir.Location = new System.Drawing.Point(3, 104);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(179, 32);
            this.btn_Imprimir.TabIndex = 110;
            this.btn_Imprimir.Tag = "1";
            this.btn_Imprimir.Text = "    Imprimir Ultima";
            this.btn_Imprimir.UseVisualStyleBackColor = false;
            this.btn_Imprimir.Visible = false;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_devolucion
            // 
            this.btn_devolucion.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_devolucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_devolucion.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_devolucion.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(44)))));
            this.btn_devolucion.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_devolucion.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_devolucion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_devolucion.BackgroundImage")));
            this.btn_devolucion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_devolucion.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_devolucion.FlatAppearance.BorderSize = 0;
            this.btn_devolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_devolucion.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.btn_devolucion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_devolucion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_devolucion.ImageEnableFalse = ((System.Drawing.Image)(resources.GetObject("btn_devolucion.ImageEnableFalse")));
            this.btn_devolucion.ImageOnMouseDown = ((System.Drawing.Image)(resources.GetObject("btn_devolucion.ImageOnMouseDown")));
            this.btn_devolucion.ImageOnMouseEnter = ((System.Drawing.Image)(resources.GetObject("btn_devolucion.ImageOnMouseEnter")));
            this.btn_devolucion.ImageOnNothing = ((System.Drawing.Image)(resources.GetObject("btn_devolucion.ImageOnNothing")));
            this.btn_devolucion.Location = new System.Drawing.Point(3, 142);
            this.btn_devolucion.Name = "btn_devolucion";
            this.btn_devolucion.Size = new System.Drawing.Size(179, 32);
            this.btn_devolucion.TabIndex = 111;
            this.btn_devolucion.Tag = "1";
            this.btn_devolucion.Text = "   Devolución";
            this.btn_devolucion.UseVisualStyleBackColor = false;
            this.btn_devolucion.Visible = false;
            this.btn_devolucion.Click += new System.EventHandler(this.btn_devolucion_Click);
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lbl_usuario.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_usuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_usuario.Location = new System.Drawing.Point(63, 26);
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(148, 25);
            this.lbl_usuario.TabIndex = 101;
            this.lbl_usuario.Text = ".";
            this.lbl_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // p_vuelto
            // 
            this.p_vuelto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.p_vuelto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_vuelto.Controls.Add(this.label12);
            this.p_vuelto.Controls.Add(this.lbl_vuelto);
            this.p_vuelto.Controls.Add(this.txt_monto);
            this.p_vuelto.Controls.Add(this.label13);
            this.p_vuelto.Controls.Add(this.lbl_pagacon);
            this.p_vuelto.Controls.Add(this.lbl_Total2);
            this.p_vuelto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_vuelto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_vuelto.Location = new System.Drawing.Point(26, 147);
            this.p_vuelto.Name = "p_vuelto";
            this.p_vuelto.Size = new System.Drawing.Size(185, 102);
            this.p_vuelto.TabIndex = 86;
            this.p_vuelto.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(11, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 25);
            this.label12.TabIndex = 55;
            this.label12.Text = "Vuelto :";
            // 
            // lbl_vuelto
            // 
            this.lbl_vuelto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vuelto.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_vuelto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_vuelto.Location = new System.Drawing.Point(100, 73);
            this.lbl_vuelto.Name = "lbl_vuelto";
            this.lbl_vuelto.Size = new System.Drawing.Size(73, 20);
            this.lbl_vuelto.TabIndex = 54;
            this.lbl_vuelto.Text = ".";
            this.lbl_vuelto.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt_monto
            // 
            this.txt_monto.CantDecimales = 2;
            this.txt_monto.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txt_monto.Location = new System.Drawing.Point(100, 10);
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(73, 32);
            this.txt_monto.TabIndex = 53;
            this.txt_monto.Text = "0";
            this.txt_monto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_monto.TextDefault = "0";
            this.tt_mensaje.SetToolTip(this.txt_monto, "[F12]");
            this.txt_monto.TextChanged += new System.EventHandler(this.txt_monto_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(9, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 25);
            this.label13.TabIndex = 52;
            this.label13.Text = "Total :";
            // 
            // lbl_pagacon
            // 
            this.lbl_pagacon.AutoSize = true;
            this.lbl_pagacon.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pagacon.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_pagacon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_pagacon.Location = new System.Drawing.Point(9, 15);
            this.lbl_pagacon.Name = "lbl_pagacon";
            this.lbl_pagacon.Size = new System.Drawing.Size(94, 25);
            this.lbl_pagacon.TabIndex = 50;
            this.lbl_pagacon.Text = "Paga con :";
            // 
            // lbl_Total2
            // 
            this.lbl_Total2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Total2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Total2.Location = new System.Drawing.Point(100, 46);
            this.lbl_Total2.Name = "lbl_Total2";
            this.lbl_Total2.Size = new System.Drawing.Size(73, 20);
            this.lbl_Total2.TabIndex = 51;
            this.lbl_Total2.Text = "0";
            this.lbl_Total2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btn_AbrirCaja
            // 
            this.btn_AbrirCaja.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AbrirCaja.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_AbrirCaja.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(44)))));
            this.btn_AbrirCaja.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_AbrirCaja.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AbrirCaja.BackgroundImage = global::SIVS.Properties.Resources.Counting_machine5;
            this.btn_AbrirCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AbrirCaja.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_AbrirCaja.FlatAppearance.BorderSize = 0;
            this.btn_AbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AbrirCaja.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.btn_AbrirCaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AbrirCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AbrirCaja.ImageEnableFalse = global::SIVS.Properties.Resources.Counting_machine5;
            this.btn_AbrirCaja.ImageOnMouseDown = global::SIVS.Properties.Resources.Counting_machine5;
            this.btn_AbrirCaja.ImageOnMouseEnter = global::SIVS.Properties.Resources.CajaDiaria_48_Flip_30;
            this.btn_AbrirCaja.ImageOnNothing = global::SIVS.Properties.Resources.Counting_machine5;
            this.btn_AbrirCaja.Location = new System.Drawing.Point(26, 93);
            this.btn_AbrirCaja.Name = "btn_AbrirCaja";
            this.btn_AbrirCaja.Size = new System.Drawing.Size(185, 48);
            this.btn_AbrirCaja.TabIndex = 52;
            this.btn_AbrirCaja.Tag = "1";
            this.btn_AbrirCaja.Text = "    Abrir Caja";
            this.tt_mensaje.SetToolTip(this.btn_AbrirCaja, "[F1]");
            this.btn_AbrirCaja.UseVisualStyleBackColor = false;
            this.btn_AbrirCaja.Click += new System.EventHandler(this.btn_AbrirCaja_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SIVS.Properties.Resources.ID_Card_1_;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Location = new System.Drawing.Point(17, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.TabIndex = 106;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_permiso
            // 
            this.lbl_permiso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_permiso.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_permiso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_permiso.Location = new System.Drawing.Point(63, 42);
            this.lbl_permiso.Name = "lbl_permiso";
            this.lbl_permiso.Size = new System.Drawing.Size(148, 48);
            this.lbl_permiso.TabIndex = 103;
            this.lbl_permiso.Text = ".";
            this.lbl_permiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(152, 3);
            this.txt_codigo.MaxLength = 20;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(170, 32);
            this.txt_codigo.TabIndex = 13;
            this.tt_mensaje.SetToolTip(this.txt_codigo, "[F5]");
            this.txt_codigo.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // cb_CuentasClientes
            // 
            this.cb_CuentasClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_CuentasClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CuentasClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_CuentasClientes.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_CuentasClientes.ForeColor = System.Drawing.Color.White;
            this.cb_CuentasClientes.FormattingEnabled = true;
            this.cb_CuentasClientes.Location = new System.Drawing.Point(124, 12);
            this.cb_CuentasClientes.Name = "cb_CuentasClientes";
            this.cb_CuentasClientes.Size = new System.Drawing.Size(270, 33);
            this.cb_CuentasClientes.TabIndex = 79;
            this.tt_mensaje.SetToolTip(this.cb_CuentasClientes, "[F8]");
            // 
            // cb_FormasPagos
            // 
            this.cb_FormasPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_FormasPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FormasPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_FormasPagos.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_FormasPagos.ForeColor = System.Drawing.Color.White;
            this.cb_FormasPagos.FormattingEnabled = true;
            this.cb_FormasPagos.Location = new System.Drawing.Point(183, 7);
            this.cb_FormasPagos.Name = "cb_FormasPagos";
            this.cb_FormasPagos.Size = new System.Drawing.Size(269, 33);
            this.cb_FormasPagos.TabIndex = 77;
            this.tt_mensaje.SetToolTip(this.cb_FormasPagos, "[F7]");
            this.cb_FormasPagos.SelectedIndexChanged += new System.EventHandler(this.cb_FormasPagos_SelectedIndexChanged);
            // 
            // txt_codAutorizacion
            // 
            this.txt_codAutorizacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codAutorizacion.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.txt_codAutorizacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codAutorizacion.Location = new System.Drawing.Point(122, 8);
            this.txt_codAutorizacion.MaxLength = 20;
            this.txt_codAutorizacion.Name = "txt_codAutorizacion";
            this.txt_codAutorizacion.Size = new System.Drawing.Size(178, 34);
            this.txt_codAutorizacion.TabIndex = 102;
            this.tt_mensaje.SetToolTip(this.txt_codAutorizacion, "[F5]");
            // 
            // lbl_articulos
            // 
            this.lbl_articulos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_articulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_articulos.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_articulos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_articulos.Image = global::SIVS.Properties.Resources.Tag;
            this.lbl_articulos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_articulos.Location = new System.Drawing.Point(4, 52);
            this.lbl_articulos.Name = "lbl_articulos";
            this.lbl_articulos.Size = new System.Drawing.Size(142, 34);
            this.lbl_articulos.TabIndex = 82;
            this.lbl_articulos.Text = "Artículo :";
            this.lbl_articulos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tt_mensaje.SetToolTip(this.lbl_articulos, "[F6]");
            this.lbl_articulos.Click += new System.EventHandler(this.lbl_articulos_Click);
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantidad.CantDecimales = 3;
            this.txt_cantidad.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txt_cantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantidad.Location = new System.Drawing.Point(401, 4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(71, 32);
            this.txt_cantidad.TabIndex = 56;
            this.txt_cantidad.Text = "1";
            this.txt_cantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantidad.TextDefault = "1";
            this.tt_mensaje.SetToolTip(this.txt_cantidad, "[F9]");
            this.txt_cantidad.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_cantidad_MouseClick);
            this.txt_cantidad.TextChanged += new System.EventHandler(this.txt_codigo_TextChanged);
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            // 
            // btn_CerrarVenta
            // 
            this.btn_CerrarVenta.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_CerrarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_CerrarVenta.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_CerrarVenta.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(44)))));
            this.btn_CerrarVenta.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_CerrarVenta.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_CerrarVenta.BackgroundImage = global::SIVS.Properties.Resources.Finalizar_venta_48x48;
            this.btn_CerrarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_CerrarVenta.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_CerrarVenta.FlatAppearance.BorderSize = 0;
            this.btn_CerrarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.btn_CerrarVenta.ForeColor = System.Drawing.Color.White;
            this.btn_CerrarVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CerrarVenta.ImageEnableFalse = null;
            this.btn_CerrarVenta.ImageOnMouseDown = global::SIVS.Properties.Resources.Finalizar_venta_48x48;
            this.btn_CerrarVenta.ImageOnMouseEnter = global::SIVS.Properties.Resources.Finalizar_venta_48x48_flip_30;
            this.btn_CerrarVenta.ImageOnNothing = global::SIVS.Properties.Resources.Finalizar_venta_48x48;
            this.btn_CerrarVenta.Location = new System.Drawing.Point(15, 145);
            this.btn_CerrarVenta.Name = "btn_CerrarVenta";
            this.btn_CerrarVenta.Size = new System.Drawing.Size(364, 50);
            this.btn_CerrarVenta.TabIndex = 92;
            this.btn_CerrarVenta.Text = "     Finalizar Venta";
            this.tt_mensaje.SetToolTip(this.btn_CerrarVenta, "[F11]");
            this.btn_CerrarVenta.UseVisualStyleBackColor = false;
            this.btn_CerrarVenta.Click += new System.EventHandler(this.btn_CerrarVenta_Click_1);
            // 
            // ms_menu
            // 
            this.ms_menu.AllowItemReorder = true;
            this.ms_menu.AutoSize = false;
            this.ms_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ms_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ms_menu.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_Articulos,
            this.ts_CajaDiaria,
            this.ts_TableroControl,
            this.ts_compras,
            this.ts_Ventas,
            this.ts_CuentasCorrientes,
            this.ts_Usuario,
            this.ts_Clientes,
            this.ts_Proveedores,
            this.ts_Permisos,
            this.ts_FormasPagos,
            this.ts_Localidades,
            this.ts_Cajas,
            this.ts_configuraciones,
            this.ts_login,
            this.ts_soporte,
            this.ts_admin});
            this.ms_menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ms_menu.Size = new System.Drawing.Size(1276, 77);
            this.ms_menu.TabIndex = 8;
            this.ms_menu.Text = "menuStrip1";
            this.ms_menu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical270;
            // 
            // ts_Articulos
            // 
            this.ts_Articulos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_Articulos,
            this.mi_Rubros,
            this.mi_Uni_medida,
            this.mi_ActualizarPrecios});
            this.ts_Articulos.Enabled = false;
            this.ts_Articulos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Articulos.Image = global::SIVS.Properties.Resources.Tag;
            this.ts_Articulos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Articulos.Name = "ts_Articulos";
            this.ts_Articulos.Size = new System.Drawing.Size(60, 73);
            this.ts_Articulos.Tag = "Articulos";
            this.ts_Articulos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Articulos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Articulos.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Articulos.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // mi_Articulos
            // 
            this.mi_Articulos.Name = "mi_Articulos";
            this.mi_Articulos.Size = new System.Drawing.Size(288, 26);
            this.mi_Articulos.Text = "Artículos";
            this.mi_Articulos.Click += new System.EventHandler(this.ts_Articulos_Click);
            // 
            // mi_Rubros
            // 
            this.mi_Rubros.Name = "mi_Rubros";
            this.mi_Rubros.Size = new System.Drawing.Size(288, 26);
            this.mi_Rubros.Text = "Rubros";
            this.mi_Rubros.Click += new System.EventHandler(this.ts_Rubro_Click);
            // 
            // mi_Uni_medida
            // 
            this.mi_Uni_medida.Name = "mi_Uni_medida";
            this.mi_Uni_medida.Size = new System.Drawing.Size(288, 26);
            this.mi_Uni_medida.Text = "Unidades de medida";
            this.mi_Uni_medida.Click += new System.EventHandler(this.ts_medidas_Click);
            // 
            // mi_ActualizarPrecios
            // 
            this.mi_ActualizarPrecios.Name = "mi_ActualizarPrecios";
            this.mi_ActualizarPrecios.Size = new System.Drawing.Size(288, 26);
            this.mi_ActualizarPrecios.Text = "Actualizar precios masivamente";
            this.mi_ActualizarPrecios.Click += new System.EventHandler(this.mi_ActualizarPrecios_Click);
            // 
            // ts_CajaDiaria
            // 
            this.ts_CajaDiaria.BackColor = System.Drawing.Color.Transparent;
            this.ts_CajaDiaria.Enabled = false;
            this.ts_CajaDiaria.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_CajaDiaria.Image = global::SIVS.Properties.Resources.Counting_machine5;
            this.ts_CajaDiaria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_CajaDiaria.Name = "ts_CajaDiaria";
            this.ts_CajaDiaria.Size = new System.Drawing.Size(60, 73);
            this.ts_CajaDiaria.Tag = " Caja Diaria";
            this.ts_CajaDiaria.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_CajaDiaria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_CajaDiaria.Click += new System.EventHandler(this.ts_CajaDiaria_Click);
            this.ts_CajaDiaria.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_CajaDiaria.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_TableroControl
            // 
            this.ts_TableroControl.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_ControlStock,
            this.ts_ControlVentas,
            this.ts_ControlCtasCtes,
            this.ts_ControlFormasPago,
            this.ts_ControlGastos,
            this.ts_ControlRubros,
            this.ts_ControlMercaderia,
            this.ts_CVentasArticulos});
            this.ts_TableroControl.Enabled = false;
            this.ts_TableroControl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_TableroControl.Image = global::SIVS.Properties.Resources.Tablero_Control_48x48;
            this.ts_TableroControl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_TableroControl.Name = "ts_TableroControl";
            this.ts_TableroControl.Size = new System.Drawing.Size(60, 73);
            this.ts_TableroControl.Tag = "Control";
            this.ts_TableroControl.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_TableroControl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_TableroControl.Click += new System.EventHandler(this.ts_TableroControl_Click);
            this.ts_TableroControl.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_TableroControl.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_ControlStock
            // 
            this.ts_ControlStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlStock.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlStock.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlStock.Name = "ts_ControlStock";
            this.ts_ControlStock.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ts_ControlStock.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlStock.Text = "Control de stock";
            this.ts_ControlStock.Click += new System.EventHandler(this.ts_ControlStock_Click);
            // 
            // ts_ControlVentas
            // 
            this.ts_ControlVentas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlVentas.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlVentas.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlVentas.Name = "ts_ControlVentas";
            this.ts_ControlVentas.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlVentas.Text = "Control de ventas";
            this.ts_ControlVentas.Click += new System.EventHandler(this.ts_ControlVentas_Click);
            // 
            // ts_ControlCtasCtes
            // 
            this.ts_ControlCtasCtes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlCtasCtes.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlCtasCtes.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlCtasCtes.Name = "ts_ControlCtasCtes";
            this.ts_ControlCtasCtes.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlCtasCtes.Text = "Control de cuentas corrientes";
            this.ts_ControlCtasCtes.Click += new System.EventHandler(this.ts_ControlCtasCtes_Click);
            // 
            // ts_ControlFormasPago
            // 
            this.ts_ControlFormasPago.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlFormasPago.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlFormasPago.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlFormasPago.Name = "ts_ControlFormasPago";
            this.ts_ControlFormasPago.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlFormasPago.Text = "Control de formas de pago";
            this.ts_ControlFormasPago.Click += new System.EventHandler(this.ts_ControlFormasPago_Click);
            // 
            // ts_ControlGastos
            // 
            this.ts_ControlGastos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlGastos.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlGastos.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlGastos.Name = "ts_ControlGastos";
            this.ts_ControlGastos.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlGastos.Text = "Control de gastos";
            this.ts_ControlGastos.Click += new System.EventHandler(this.ts_ControlGastos_Click);
            // 
            // ts_ControlRubros
            // 
            this.ts_ControlRubros.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlRubros.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlRubros.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlRubros.Name = "ts_ControlRubros";
            this.ts_ControlRubros.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlRubros.Text = "Control de rubros";
            this.ts_ControlRubros.Click += new System.EventHandler(this.ts_ControlRubros_Click);
            // 
            // ts_ControlMercaderia
            // 
            this.ts_ControlMercaderia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ts_ControlMercaderia.ForeColor = System.Drawing.Color.Black;
            this.ts_ControlMercaderia.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.ts_ControlMercaderia.Name = "ts_ControlMercaderia";
            this.ts_ControlMercaderia.Size = new System.Drawing.Size(278, 26);
            this.ts_ControlMercaderia.Text = "Control de mercaderia";
            this.ts_ControlMercaderia.Click += new System.EventHandler(this.ts_ControlMercaderia_Click);
            // 
            // ts_CVentasArticulos
            // 
            this.ts_CVentasArticulos.Name = "ts_CVentasArticulos";
            this.ts_CVentasArticulos.Size = new System.Drawing.Size(278, 26);
            this.ts_CVentasArticulos.Text = "Control de ventas de artículos";
            this.ts_CVentasArticulos.Click += new System.EventHandler(this.ts_CVentasArticulos_Click);
            // 
            // ts_compras
            // 
            this.ts_compras.Enabled = false;
            this.ts_compras.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_compras.Image = global::SIVS.Properties.Resources.Compras_48x481;
            this.ts_compras.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_compras.Name = "ts_compras";
            this.ts_compras.Size = new System.Drawing.Size(60, 73);
            this.ts_compras.Tag = "Compras";
            this.ts_compras.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_compras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_compras.Click += new System.EventHandler(this.ts_compras_Click);
            this.ts_compras.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_compras.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_Ventas
            // 
            this.ts_Ventas.Enabled = false;
            this.ts_Ventas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Ventas.Image = global::SIVS.Properties.Resources.Dollar3;
            this.ts_Ventas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Ventas.Name = "ts_Ventas";
            this.ts_Ventas.Size = new System.Drawing.Size(60, 73);
            this.ts_Ventas.Tag = "Ventas";
            this.ts_Ventas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Ventas.Click += new System.EventHandler(this.ts_Ventas_Click);
            this.ts_Ventas.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Ventas.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_CuentasCorrientes
            // 
            this.ts_CuentasCorrientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentasCorrientesToolStripMenuItem});
            this.ts_CuentasCorrientes.Enabled = false;
            this.ts_CuentasCorrientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_CuentasCorrientes.Image = global::SIVS.Properties.Resources.Accounts_book;
            this.ts_CuentasCorrientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_CuentasCorrientes.Name = "ts_CuentasCorrientes";
            this.ts_CuentasCorrientes.Size = new System.Drawing.Size(60, 73);
            this.ts_CuentasCorrientes.Tag = "Ctas.Ctes.";
            this.ts_CuentasCorrientes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_CuentasCorrientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_CuentasCorrientes.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_CuentasCorrientes.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // cuentasCorrientesToolStripMenuItem
            // 
            this.cuentasCorrientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_CtaCteClientes,
            this.mi_CtaCteProveedores,
            this.mi_CtaCteUsuarios});
            this.cuentasCorrientesToolStripMenuItem.Name = "cuentasCorrientesToolStripMenuItem";
            this.cuentasCorrientesToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.cuentasCorrientesToolStripMenuItem.Text = "Cuentas Corrientes";
            // 
            // mi_CtaCteClientes
            // 
            this.mi_CtaCteClientes.Name = "mi_CtaCteClientes";
            this.mi_CtaCteClientes.Size = new System.Drawing.Size(163, 26);
            this.mi_CtaCteClientes.Tag = "1";
            this.mi_CtaCteClientes.Text = "Clientes";
            this.mi_CtaCteClientes.Click += new System.EventHandler(this.ts_CuentasCorrientes_Click);
            // 
            // mi_CtaCteProveedores
            // 
            this.mi_CtaCteProveedores.Name = "mi_CtaCteProveedores";
            this.mi_CtaCteProveedores.Size = new System.Drawing.Size(163, 26);
            this.mi_CtaCteProveedores.Tag = "2";
            this.mi_CtaCteProveedores.Text = "Proveedores";
            this.mi_CtaCteProveedores.Click += new System.EventHandler(this.ts_CuentasCorrientes_Click);
            // 
            // mi_CtaCteUsuarios
            // 
            this.mi_CtaCteUsuarios.Name = "mi_CtaCteUsuarios";
            this.mi_CtaCteUsuarios.Size = new System.Drawing.Size(163, 26);
            this.mi_CtaCteUsuarios.Tag = "3";
            this.mi_CtaCteUsuarios.Text = "Usuarios";
            this.mi_CtaCteUsuarios.Click += new System.EventHandler(this.ts_CuentasCorrientes_Click);
            // 
            // ts_Usuario
            // 
            this.ts_Usuario.Enabled = false;
            this.ts_Usuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Usuario.Image = global::SIVS.Properties.Resources.User;
            this.ts_Usuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Usuario.Name = "ts_Usuario";
            this.ts_Usuario.Size = new System.Drawing.Size(60, 73);
            this.ts_Usuario.Tag = "Usuarios";
            this.ts_Usuario.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Usuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Usuario.Click += new System.EventHandler(this.ts_Usuario_Click);
            this.ts_Usuario.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Usuario.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_Clientes
            // 
            this.ts_Clientes.Enabled = false;
            this.ts_Clientes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Clientes.Image = global::SIVS.Properties.Resources.Customer;
            this.ts_Clientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Clientes.Name = "ts_Clientes";
            this.ts_Clientes.Size = new System.Drawing.Size(60, 73);
            this.ts_Clientes.Tag = "Clientes";
            this.ts_Clientes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Clientes.Click += new System.EventHandler(this.ts_Clientes_Click);
            this.ts_Clientes.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Clientes.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_Proveedores
            // 
            this.ts_Proveedores.Enabled = false;
            this.ts_Proveedores.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Proveedores.Image = global::SIVS.Properties.Resources.Shopping_Vehicle;
            this.ts_Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Proveedores.Name = "ts_Proveedores";
            this.ts_Proveedores.Size = new System.Drawing.Size(60, 73);
            this.ts_Proveedores.Tag = "Proveedores";
            this.ts_Proveedores.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Proveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Proveedores.Click += new System.EventHandler(this.ts_Proveedores_Click);
            this.ts_Proveedores.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Proveedores.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_Permisos
            // 
            this.ts_Permisos.Enabled = false;
            this.ts_Permisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Permisos.Image = global::SIVS.Properties.Resources.ID_Card_1_;
            this.ts_Permisos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Permisos.Name = "ts_Permisos";
            this.ts_Permisos.Size = new System.Drawing.Size(60, 73);
            this.ts_Permisos.Tag = "Permisos";
            this.ts_Permisos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Permisos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Permisos.Click += new System.EventHandler(this.ts_Permisos_Click);
            this.ts_Permisos.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Permisos.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_FormasPagos
            // 
            this.ts_FormasPagos.Enabled = false;
            this.ts_FormasPagos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_FormasPagos.Image = global::SIVS.Properties.Resources.Debit_Card;
            this.ts_FormasPagos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_FormasPagos.Name = "ts_FormasPagos";
            this.ts_FormasPagos.Size = new System.Drawing.Size(60, 73);
            this.ts_FormasPagos.Tag = "Formas Pago";
            this.ts_FormasPagos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_FormasPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_FormasPagos.Click += new System.EventHandler(this.ts_FormasPagos_Click);
            this.ts_FormasPagos.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_FormasPagos.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_Localidades
            // 
            this.ts_Localidades.Enabled = false;
            this.ts_Localidades.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Localidades.Image = global::SIVS.Properties.Resources.Map_and_Location;
            this.ts_Localidades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Localidades.Name = "ts_Localidades";
            this.ts_Localidades.Size = new System.Drawing.Size(60, 73);
            this.ts_Localidades.Tag = "Localidades";
            this.ts_Localidades.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Localidades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Localidades.Click += new System.EventHandler(this.ts_Localidades_Click);
            this.ts_Localidades.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Localidades.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_Cajas
            // 
            this.ts_Cajas.Enabled = false;
            this.ts_Cajas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_Cajas.Image = global::SIVS.Properties.Resources.For_This_Week;
            this.ts_Cajas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_Cajas.Name = "ts_Cajas";
            this.ts_Cajas.Size = new System.Drawing.Size(60, 73);
            this.ts_Cajas.Tag = "Cajas";
            this.ts_Cajas.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_Cajas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_Cajas.Click += new System.EventHandler(this.ts_Cajas_Click);
            this.ts_Cajas.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_Cajas.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_configuraciones
            // 
            this.ts_configuraciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_backup,
            this.tsm_configuracion});
            this.ts_configuraciones.Enabled = false;
            this.ts_configuraciones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_configuraciones.Image = global::SIVS.Properties.Resources.Engineering;
            this.ts_configuraciones.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_configuraciones.Name = "ts_configuraciones";
            this.ts_configuraciones.Size = new System.Drawing.Size(60, 73);
            this.ts_configuraciones.Tag = "Config";
            this.ts_configuraciones.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_configuraciones.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_configuraciones.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_configuraciones.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // tsm_backup
            // 
            this.tsm_backup.Name = "tsm_backup";
            this.tsm_backup.Size = new System.Drawing.Size(174, 26);
            this.tsm_backup.Text = "Crear backup";
            this.tsm_backup.Click += new System.EventHandler(this.tsm_backup_Click);
            // 
            // tsm_configuracion
            // 
            this.tsm_configuracion.Name = "tsm_configuracion";
            this.tsm_configuracion.Size = new System.Drawing.Size(174, 26);
            this.tsm_configuracion.Text = "Configuración";
            this.tsm_configuracion.Click += new System.EventHandler(this.configuracionesToolStripMenuItem_Click);
            // 
            // ts_login
            // 
            this.ts_login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ts_login.Image = global::SIVS.Properties.Resources.Login2;
            this.ts_login.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_login.Name = "ts_login";
            this.ts_login.Size = new System.Drawing.Size(60, 73);
            this.ts_login.Tag = "Login";
            this.ts_login.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_login.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            this.ts_login.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_login.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_soporte
            // 
            this.ts_soporte.Image = global::SIVS.Properties.Resources.User_Headphone;
            this.ts_soporte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ts_soporte.Name = "ts_soporte";
            this.ts_soporte.Size = new System.Drawing.Size(60, 73);
            this.ts_soporte.Tag = "Soporte";
            this.ts_soporte.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.ts_soporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ts_soporte.Click += new System.EventHandler(this.ts_soporte_Click);
            this.ts_soporte.MouseEnter += new System.EventHandler(this.ts_Articulos_MouseEnter);
            this.ts_soporte.MouseLeave += new System.EventHandler(this.ts_Articulos_MouseLeave);
            // 
            // ts_admin
            // 
            this.ts_admin.Name = "ts_admin";
            this.ts_admin.Size = new System.Drawing.Size(12, 73);
            this.ts_admin.Click += new System.EventHandler(this.ts_admin_Click);
            // 
            // gb_grande
            // 
            this.gb_grande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.gb_grande.Controls.Add(this.dgrid_items);
            this.gb_grande.Controls.Add(this.p_articulo);
            this.gb_grande.Controls.Add(this.p_grande);
            this.gb_grande.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.gb_grande.Location = new System.Drawing.Point(12, 77);
            this.gb_grande.Name = "gb_grande";
            this.gb_grande.Size = new System.Drawing.Size(1025, 585);
            this.gb_grande.TabIndex = 9;
            this.gb_grande.TabStop = false;
            this.gb_grande.SizeChanged += new System.EventHandler(this.gb_grande_SizeChanged);
            // 
            // dgrid_items
            // 
            this.dgrid_items.AllowUserToAddRows = false;
            this.dgrid_items.AllowUserToDeleteRows = false;
            this.dgrid_items.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgrid_items.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_items.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_items.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_items.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrid_items.Location = new System.Drawing.Point(3, 116);
            this.dgrid_items.MultiSelect = false;
            this.dgrid_items.Name = "dgrid_items";
            this.dgrid_items.ReadOnly = true;
            this.dgrid_items.RowHeadersVisible = false;
            this.dgrid_items.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_items.Size = new System.Drawing.Size(1016, 258);
            this.dgrid_items.TabIndex = 57;
            this.dgrid_items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_items_MouseDoubleClick);
            // 
            // p_articulo
            // 
            this.p_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_articulo.Controls.Add(this.p_precio);
            this.p_articulo.Controls.Add(this.txt_cantidad);
            this.p_articulo.Controls.Add(this.lbl_unidad);
            this.p_articulo.Controls.Add(this.lbl_articulos);
            this.p_articulo.Controls.Add(this.label1);
            this.p_articulo.Controls.Add(this.txt_codigo);
            this.p_articulo.Controls.Add(this.label4);
            this.p_articulo.Controls.Add(this.p_descripcion);
            this.p_articulo.Location = new System.Drawing.Point(3, 18);
            this.p_articulo.Name = "p_articulo";
            this.p_articulo.Size = new System.Drawing.Size(1019, 98);
            this.p_articulo.TabIndex = 91;
            // 
            // p_precio
            // 
            this.p_precio.Controls.Add(this.lbl_PrecioTotal);
            this.p_precio.Controls.Add(this.label2);
            this.p_precio.Location = new System.Drawing.Point(827, 0);
            this.p_precio.Name = "p_precio";
            this.p_precio.Size = new System.Drawing.Size(183, 38);
            this.p_precio.TabIndex = 91;
            // 
            // lbl_PrecioTotal
            // 
            this.lbl_PrecioTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PrecioTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PrecioTotal.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_PrecioTotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_PrecioTotal.Location = new System.Drawing.Point(88, 0);
            this.lbl_PrecioTotal.Name = "lbl_PrecioTotal";
            this.lbl_PrecioTotal.Size = new System.Drawing.Size(95, 38);
            this.lbl_PrecioTotal.TabIndex = 49;
            this.lbl_PrecioTotal.Text = "00000";
            this.lbl_PrecioTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 32);
            this.label2.TabIndex = 48;
            this.label2.Text = "Total: $";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_unidad
            // 
            this.lbl_unidad.AutoSize = true;
            this.lbl_unidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_unidad.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_unidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_unidad.Location = new System.Drawing.Point(478, 4);
            this.lbl_unidad.Name = "lbl_unidad";
            this.lbl_unidad.Size = new System.Drawing.Size(87, 32);
            this.lbl_unidad.TabIndex = 90;
            this.lbl_unidad.Text = "Unidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(328, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 32);
            this.label1.TabIndex = 47;
            this.label1.Text = "Cant:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Image = global::SIVS.Properties.Resources.Barcode;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(4, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 46;
            this.label4.Text = "Código :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // p_descripcion
            // 
            this.p_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.p_descripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.p_descripcion.Controls.Add(this.lbl_art);
            this.p_descripcion.Font = new System.Drawing.Font("Segoe UI Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_descripcion.Location = new System.Drawing.Point(152, 39);
            this.p_descripcion.Name = "p_descripcion";
            this.p_descripcion.Size = new System.Drawing.Size(864, 52);
            this.p_descripcion.TabIndex = 73;
            // 
            // lbl_art
            // 
            this.lbl_art.AutoSize = true;
            this.lbl_art.BackColor = System.Drawing.Color.Transparent;
            this.lbl_art.Font = new System.Drawing.Font("Segoe UI Light", 25F);
            this.lbl_art.Location = new System.Drawing.Point(3, 4);
            this.lbl_art.Name = "lbl_art";
            this.lbl_art.Size = new System.Drawing.Size(28, 46);
            this.lbl_art.TabIndex = 84;
            this.lbl_art.Text = ".";
            this.lbl_art.TextChanged += new System.EventHandler(this.lbl_art_TextChanged);
            // 
            // p_grande
            // 
            this.p_grande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_grande.Controls.Add(this.p_autorizacion);
            this.p_grande.Controls.Add(this.cb_2formasPago);
            this.p_grande.Controls.Add(this.p_cuentacorriente);
            this.p_grande.Controls.Add(this.cb_imprimir);
            this.p_grande.Controls.Add(this.p_formapago);
            this.p_grande.Controls.Add(this.panel1);
            this.p_grande.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_grande.Location = new System.Drawing.Point(3, 380);
            this.p_grande.Name = "p_grande";
            this.p_grande.Size = new System.Drawing.Size(1019, 202);
            this.p_grande.TabIndex = 89;
            // 
            // p_autorizacion
            // 
            this.p_autorizacion.Controls.Add(this.txt_codAutorizacion);
            this.p_autorizacion.Controls.Add(this.label10);
            this.p_autorizacion.Location = new System.Drawing.Point(6, 108);
            this.p_autorizacion.Name = "p_autorizacion";
            this.p_autorizacion.Size = new System.Drawing.Size(305, 50);
            this.p_autorizacion.TabIndex = 103;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Image = global::SIVS.Properties.Resources.Verify;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(0, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 38);
            this.label10.TabIndex = 81;
            this.label10.Text = "Cod.";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_2formasPago
            // 
            this.cb_2formasPago.AutoSize = true;
            this.cb_2formasPago.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.cb_2formasPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.cb_2formasPago.Location = new System.Drawing.Point(11, 164);
            this.cb_2formasPago.Name = "cb_2formasPago";
            this.cb_2formasPago.Size = new System.Drawing.Size(234, 32);
            this.cb_2formasPago.TabIndex = 100;
            this.cb_2formasPago.Text = "Segunda forma de pago";
            this.cb_2formasPago.UseVisualStyleBackColor = true;
            this.cb_2formasPago.CheckedChanged += new System.EventHandler(this.cb_2formasPago_CheckedChanged);
            // 
            // p_cuentacorriente
            // 
            this.p_cuentacorriente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_cuentacorriente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_cuentacorriente.Controls.Add(this.cb_CuentasClientes);
            this.p_cuentacorriente.Controls.Add(this.lbl_Cuentas);
            this.p_cuentacorriente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_cuentacorriente.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_cuentacorriente.Location = new System.Drawing.Point(4, 56);
            this.p_cuentacorriente.Name = "p_cuentacorriente";
            this.p_cuentacorriente.Size = new System.Drawing.Size(403, 50);
            this.p_cuentacorriente.TabIndex = 94;
            // 
            // lbl_Cuentas
            // 
            this.lbl_Cuentas.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Cuentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Cuentas.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Cuentas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_Cuentas.Image = global::SIVS.Properties.Resources.Accounts_book;
            this.lbl_Cuentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Cuentas.Location = new System.Drawing.Point(1, 7);
            this.lbl_Cuentas.Name = "lbl_Cuentas";
            this.lbl_Cuentas.Size = new System.Drawing.Size(117, 38);
            this.lbl_Cuentas.TabIndex = 80;
            this.lbl_Cuentas.Text = "       CtaCte:";
            this.lbl_Cuentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Cuentas.Click += new System.EventHandler(this.lbl_Cuentas_Click);
            // 
            // cb_imprimir
            // 
            this.cb_imprimir.AutoSize = true;
            this.cb_imprimir.BackColor = System.Drawing.Color.Transparent;
            this.cb_imprimir.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_imprimir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_imprimir.Location = new System.Drawing.Point(251, 167);
            this.cb_imprimir.Name = "cb_imprimir";
            this.cb_imprimir.Size = new System.Drawing.Size(95, 29);
            this.cb_imprimir.TabIndex = 110;
            this.cb_imprimir.Text = "Imprimir";
            this.cb_imprimir.UseVisualStyleBackColor = false;
            // 
            // p_formapago
            // 
            this.p_formapago.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_formapago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_formapago.Controls.Add(this.cb_FormasPagos);
            this.p_formapago.Controls.Add(this.label9);
            this.p_formapago.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_formapago.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_formapago.Location = new System.Drawing.Point(4, 4);
            this.p_formapago.Name = "p_formapago";
            this.p_formapago.Size = new System.Drawing.Size(459, 46);
            this.p_formapago.TabIndex = 93;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label9.Image = global::SIVS.Properties.Resources.Debit_Card;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 38);
            this.label9.TabIndex = 78;
            this.label9.Text = "  Forma pago :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label9.Click += new System.EventHandler(this.ts_FormasPagos_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_desc);
            this.panel1.Controls.Add(this.btn_CerrarVenta);
            this.panel1.Controls.Add(this.lbl_Total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_Subtotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel1.Location = new System.Drawing.Point(635, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 202);
            this.panel1.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 32);
            this.label3.TabIndex = 97;
            this.label3.Text = "Desc/Rec :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 32F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(5, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 59);
            this.label6.TabIndex = 98;
            this.label6.Text = "Total :";
            // 
            // lbl_desc
            // 
            this.lbl_desc.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_desc.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_desc.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_desc.Image = global::SIVS.Properties.Resources.pesos;
            this.lbl_desc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_desc.Location = new System.Drawing.Point(143, 40);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(236, 30);
            this.lbl_desc.TabIndex = 78;
            this.lbl_desc.Text = "00000";
            this.lbl_desc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI Light", 32F);
            this.lbl_Total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Total.Image = global::SIVS.Properties.Resources.pesos60px;
            this.lbl_Total.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Total.Location = new System.Drawing.Point(133, 77);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(258, 60);
            this.lbl_Total.TabIndex = 75;
            this.lbl_Total.Tag = "10";
            this.lbl_Total.Text = "00000";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 32);
            this.label5.TabIndex = 98;
            this.label5.Text = "Subtotal :";
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Subtotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Subtotal.Image = ((System.Drawing.Image)(resources.GetObject("lbl_Subtotal.Image")));
            this.lbl_Subtotal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Subtotal.Location = new System.Drawing.Point(143, 5);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(236, 30);
            this.lbl_Subtotal.TabIndex = 72;
            this.lbl_Subtotal.Text = "00000";
            this.lbl_Subtotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_Subtotal.TextChanged += new System.EventHandler(this.lbl_Subtotal_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.BackgroundImage = global::SIVS.Properties.Resources.splash_free;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1276, 750);
            this.Controls.Add(this.ms_menu);
            this.Controls.Add(this.p_detalles);
            this.Controls.Add(this.gb_grande);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.ms_menu;
            this.Name = "Form1";
            this.Text = "EasySales Market  3.4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.p_adicional.ResumeLayout(false);
            this.p_adicional.PerformLayout();
            this.p_detalles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.p_vuelto.ResumeLayout(false);
            this.p_vuelto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.gb_grande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_items)).EndInit();
            this.p_articulo.ResumeLayout(false);
            this.p_articulo.PerformLayout();
            this.p_precio.ResumeLayout(false);
            this.p_precio.PerformLayout();
            this.p_descripcion.ResumeLayout(false);
            this.p_descripcion.PerformLayout();
            this.p_grande.ResumeLayout(false);
            this.p_grande.PerformLayout();
            this.p_autorizacion.ResumeLayout(false);
            this.p_autorizacion.PerformLayout();
            this.p_cuentacorriente.ResumeLayout(false);
            this.p_formapago.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_FormasDePago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_venta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CuentasClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_formasDePago2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_FormasDePago;
        private System.Windows.Forms.BindingSource bs_venta;
        private System.Windows.Forms.BindingSource bs_CuentasClientes;
        private System.Windows.Forms.ToolStripMenuItem ts_CajaDiaria;
        private System.Windows.Forms.ToolStripMenuItem ts_Articulos;
        private System.Windows.Forms.ToolStripMenuItem ts_CuentasCorrientes;
        private System.Windows.Forms.ToolStripMenuItem ts_FormasPagos;
        private System.Windows.Forms.ToolStripMenuItem ts_Localidades;
        private System.Windows.Forms.ToolStripMenuItem ts_Permisos;
        private System.Windows.Forms.ToolStripMenuItem ts_Usuario;
        private System.Windows.Forms.ToolStripMenuItem ts_Clientes;
        private System.Windows.Forms.ToolStripMenuItem ts_Proveedores;
        private System.Windows.Forms.ToolStripMenuItem ts_configuraciones;
        private System.Windows.Forms.ToolStripMenuItem ts_login;
        private System.Windows.Forms.ToolStripMenuItem ts_compras;
        private System.Windows.Forms.ToolStripMenuItem ts_Ventas;
        protected CONTROLES.ButtonImages btn_AbrirCaja;
        protected System.Windows.Forms.Panel p_vuelto;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_vuelto;
        private CONTROLES.TextBox_Decimal txt_monto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_pagacon;
        private System.Windows.Forms.Label lbl_Total2;
        private System.Windows.Forms.Button btn_vuelto;
        private System.Windows.Forms.Panel p_detalles;
        private System.Windows.Forms.Panel p_adicional;
        private CONTROLES.TextBox_Decimal txt_adicional;
        private System.Windows.Forms.CheckBox cb_adicional;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rb_descuento;
        private System.Windows.Forms.RadioButton rb_recargo;
        private System.Windows.Forms.ToolTip tt_mensaje;
        private System.Windows.Forms.Label lbl_permiso;
        private System.Windows.Forms.Label lbl_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected CONTROLES.ButtonImages btn_nuevoCobro;
        protected CONTROLES.ButtonImages btn_nuevoGasto;
        private System.Windows.Forms.GroupBox gb_grande;
        private System.Windows.Forms.Label lbl_unidad;
        private System.Windows.Forms.Label lbl_PrecioTotal;
        private System.Windows.Forms.Label lbl_articulos;
        private System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Panel p_descripcion;
        private System.Windows.Forms.Label lbl_art;
        private System.Windows.Forms.Panel p_grande;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Panel p_cuentacorriente;
        private System.Windows.Forms.ComboBox cb_CuentasClientes;
        private System.Windows.Forms.Label lbl_Cuentas;
        protected System.Windows.Forms.Panel p_formapago;
        private System.Windows.Forms.ComboBox cb_FormasPagos;
        private System.Windows.Forms.Label label9;
        protected CONTROLES.ButtonImages btn_CerrarVenta;
        private System.Windows.Forms.DataGridView dgrid_items;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel p_articulo;
        private System.Windows.Forms.Panel p_precio;
        private System.Windows.Forms.CheckBox cb_2formasPago;
        private System.Windows.Forms.BindingSource bs_formasDePago2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_codAutorizacion;
        private CONTROLES.TextBox_Decimal txt_cantidad;
        private System.Windows.Forms.Panel p_autorizacion;
        private System.Windows.Forms.ToolStripMenuItem ts_ControlVentas;
        private System.Windows.Forms.ToolStripMenuItem ts_ControlCtasCtes;
        private System.Windows.Forms.ToolStripMenuItem ts_ControlRubros;
        private System.Windows.Forms.ToolStripMenuItem ts_ControlMercaderia;
        private System.Windows.Forms.ToolStripMenuItem ts_ControlFormasPago;
        private System.Windows.Forms.ToolStripMenuItem ts_ControlGastos;
        private System.Windows.Forms.Label lbl_registros;
        private System.Windows.Forms.ToolStripMenuItem ts_soporte;
        protected System.Windows.Forms.MenuStrip ms_menu;
        protected System.Windows.Forms.ToolStripMenuItem ts_TableroControl;
        protected System.Windows.Forms.ToolStripMenuItem ts_ControlStock;
        private System.Windows.Forms.ToolStripMenuItem mi_Articulos;
        private System.Windows.Forms.ToolStripMenuItem mi_ActualizarPrecios;
        private System.Windows.Forms.Label label8;
        private CONTROLES.TextBox_Decimal txt_adicionalFijo;
        private System.Windows.Forms.ToolStripMenuItem ts_admin;
        protected CONTROLES.ButtonImages btn_Imprimir;
        private System.Windows.Forms.CheckBox cb_imprimir;
        private System.Windows.Forms.ToolStripMenuItem ts_CVentasArticulos;
        private System.Windows.Forms.ToolStripMenuItem ts_Cajas;
        private System.Windows.Forms.ToolStripMenuItem mi_Rubros;
        private System.Windows.Forms.ToolStripMenuItem mi_Uni_medida;
        private System.Windows.Forms.ToolStripMenuItem cuentasCorrientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_CtaCteClientes;
        private System.Windows.Forms.ToolStripMenuItem mi_CtaCteProveedores;
        private System.Windows.Forms.ToolStripMenuItem mi_CtaCteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsm_backup;
        private System.Windows.Forms.ToolStripMenuItem tsm_configuracion;
        protected CONTROLES.ButtonImages btn_devolucion;
    }
}

