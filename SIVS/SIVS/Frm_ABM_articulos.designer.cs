namespace SIVS
{
    partial class Frm_ABM_articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_articulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgrid_articulos = new System.Windows.Forms.DataGridView();
            this.bs_articulos = new System.Windows.Forms.BindingSource(this.components);
            this.btn_stock = new CONTROLES.ButtonImages();
            this.bs_rubros = new System.Windows.Forms.BindingSource(this.components);
            this.cbb_Rubro = new System.Windows.Forms.ComboBox();
            this.lbl_rubro = new System.Windows.Forms.Label();
            this.btn_DarBaja = new CONTROLES.ButtonImages();
            this.btn_VerBajas = new CONTROLES.ButtonImages();
            this.toolTipGral = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_medida = new System.Windows.Forms.Label();
            this.cb_medidas = new System.Windows.Forms.ComboBox();
            this.bs_medidas = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_precio = new CONTROLES.TextBox_Decimal();
            this.txt_costo = new CONTROLES.TextBox_Decimal();
            this.txt_IVA = new CONTROLES.TextBox_Decimal();
            this.txt_PrecioConIva = new CONTROLES.TextBox_Decimal();
            this.txt_nota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_stock = new CONTROLES.TextBox_Decimal();
            this.btn_Reporte = new CONTROLES.ButtonImages();
            this.btn_GuardarMas = new CONTROLES.ButtonImages();
            this.txt_cantAlta = new CONTROLES.TextBox_Decimal();
            this.txt_cantMedia = new CONTROLES.TextBox_Decimal();
            this.txt_cantBaja = new CONTROLES.TextBox_Decimal();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btn_precios = new CONTROLES.ButtonImages();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_busquedaDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_busquedaCodigo = new System.Windows.Forms.TextBox();
            this.btn_modificarPrecios = new CONTROLES.ButtonImages();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_medidas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(3, 8);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click_1);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(125, 46);
            this.btn_Cancelar.TabIndex = 25;
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(9, 46);
            this.btn_Guardar.TabIndex = 24;
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(244, 8);
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(128, 8);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(12, 8);
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pbtn.Location = new System.Drawing.Point(0, 472);
            this.pbtn.Size = new System.Drawing.Size(996, 85);
            this.pbtn.TabIndex = 6;
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.label24);
            this.pn_abm.Controls.Add(this.txt_cantAlta);
            this.pn_abm.Controls.Add(this.txt_stock);
            this.pn_abm.Controls.Add(this.label23);
            this.pn_abm.Controls.Add(this.txt_nota);
            this.pn_abm.Controls.Add(this.label22);
            this.pn_abm.Controls.Add(this.txt_cantMedia);
            this.pn_abm.Controls.Add(this.label11);
            this.pn_abm.Controls.Add(this.txt_PrecioConIva);
            this.pn_abm.Controls.Add(this.txt_cantBaja);
            this.pn_abm.Controls.Add(this.txt_IVA);
            this.pn_abm.Controls.Add(this.txt_costo);
            this.pn_abm.Controls.Add(this.txt_precio);
            this.pn_abm.Controls.Add(this.label10);
            this.pn_abm.Controls.Add(this.label21);
            this.pn_abm.Controls.Add(this.label9);
            this.pn_abm.Controls.Add(this.lbl_medida);
            this.pn_abm.Controls.Add(this.cb_medidas);
            this.pn_abm.Controls.Add(this.lbl_rubro);
            this.pn_abm.Controls.Add(this.label5);
            this.pn_abm.Controls.Add(this.txt_descripcion);
            this.pn_abm.Controls.Add(this.cbb_Rubro);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.txt_codigo);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.label3);
            this.pn_abm.Controls.Add(this.label4);
            this.pn_abm.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_abm.Size = new System.Drawing.Size(331, 456);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_articulos);
            this.gb_abm.Controls.Add(this.panel1);
            this.gb_abm.Padding = new System.Windows.Forms.Padding(5);
            this.gb_abm.Size = new System.Drawing.Size(641, 456);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(996, 472);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(649, 8);
            this.p_derecho.Size = new System.Drawing.Size(339, 456);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Controls.Add(this.btn_GuardarMas);
            this.pn_btnDerechos.Location = new System.Drawing.Point(754, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(242, 85);
            this.pn_btnDerechos.Controls.SetChildIndex(this.btn_GuardarMas, 0);
            this.pn_btnDerechos.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.pn_btnDerechos.Controls.SetChildIndex(this.btn_Guardar, 0);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.btn_modificarPrecios);
            this.pn_btnABM.Controls.Add(this.btn_Reporte);
            this.pn_btnABM.Controls.Add(this.btn_DarBaja);
            this.pn_btnABM.Controls.Add(this.btn_VerBajas);
            this.pn_btnABM.Controls.Add(this.btn_stock);
            this.pn_btnABM.Size = new System.Drawing.Size(754, 85);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_stock, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_VerBajas, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_DarBaja, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Reporte, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_modificarPrecios, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.pn_btnSalir, 0);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Controls.Add(this.btn_precios);
            this.pn_btnSalir.Location = new System.Drawing.Point(635, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 85);
            this.pn_btnSalir.Controls.SetChildIndex(this.btn_precios, 0);
            this.pn_btnSalir.Controls.SetChildIndex(this.btn_Salir, 0);
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(88, 5);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(232, 30);
            this.txt_codigo.TabIndex = 10;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(3, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.Location = new System.Drawing.Point(3, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Costo Unitario :  $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.Location = new System.Drawing.Point(3, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción :";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_descripcion.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_descripcion.Location = new System.Drawing.Point(116, 41);
            this.txt_descripcion.MaxLength = 200;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(204, 30);
            this.txt_descripcion.TabIndex = 11;
            this.txt_descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.Location = new System.Drawing.Point(3, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio Unitario S/I :  $";
            // 
            // dgrid_articulos
            // 
            this.dgrid_articulos.AllowUserToAddRows = false;
            this.dgrid_articulos.AllowUserToDeleteRows = false;
            this.dgrid_articulos.AllowUserToResizeRows = false;
            this.dgrid_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrid_articulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_articulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_articulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_articulos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_articulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_articulos.Location = new System.Drawing.Point(5, 5);
            this.dgrid_articulos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 41);
            this.dgrid_articulos.Name = "dgrid_articulos";
            this.dgrid_articulos.ReadOnly = true;
            this.dgrid_articulos.RowHeadersVisible = false;
            this.dgrid_articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_articulos.Size = new System.Drawing.Size(631, 407);
            this.dgrid_articulos.TabIndex = 26;
            this.dgrid_articulos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_articulos_KeyDown);
            this.dgrid_articulos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_articulos_MouseDoubleClick);
            this.dgrid_articulos.Resize += new System.EventHandler(this.Frm_ABM_articulos_ResizeEnd);
            // 
            // btn_stock
            // 
            this.btn_stock.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_stock.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_stock.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.btn_stock.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_stock.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_stock.BackgroundImage = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_stock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_stock.FlatAppearance.BorderSize = 0;
            this.btn_stock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stock.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_stock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_stock.ImageEnableFalse = null;
            this.btn_stock.ImageOnMouseDown = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_stock.ImageOnMouseEnter = global::SIVS.Properties.Resources.ModificaStock_32x32_flip;
            this.btn_stock.ImageOnNothing = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_stock.Location = new System.Drawing.Point(476, 46);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(226, 32);
            this.btn_stock.TabIndex = 6;
            this.btn_stock.Text = "Modificar Stock";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // cbb_Rubro
            // 
            this.cbb_Rubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_Rubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Rubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Rubro.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_Rubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Rubro.FormattingEnabled = true;
            this.cbb_Rubro.Location = new System.Drawing.Point(97, 336);
            this.cbb_Rubro.Name = "cbb_Rubro";
            this.cbb_Rubro.Size = new System.Drawing.Size(223, 31);
            this.cbb_Rubro.TabIndex = 20;
            this.cbb_Rubro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // lbl_rubro
            // 
            this.lbl_rubro.AutoSize = true;
            this.lbl_rubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_rubro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_rubro.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_rubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_rubro.Location = new System.Drawing.Point(3, 339);
            this.lbl_rubro.Name = "lbl_rubro";
            this.lbl_rubro.Size = new System.Drawing.Size(69, 27);
            this.lbl_rubro.TabIndex = 31;
            this.lbl_rubro.Text = "Rubro :";
            this.lbl_rubro.Click += new System.EventHandler(this.lbl_rubro_Click);
            // 
            // btn_DarBaja
            // 
            this.btn_DarBaja.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_DarBaja.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_DarBaja.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.btn_DarBaja.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_DarBaja.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_DarBaja.BackgroundImage = global::SIVS.Properties.Resources.Upload_32x32;
            this.btn_DarBaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DarBaja.FlatAppearance.BorderSize = 0;
            this.btn_DarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarBaja.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_DarBaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DarBaja.ImageEnableFalse = null;
            this.btn_DarBaja.ImageOnMouseDown = global::SIVS.Properties.Resources.Upload_32x32;
            this.btn_DarBaja.ImageOnMouseEnter = global::SIVS.Properties.Resources.Upload_32x32_flip;
            this.btn_DarBaja.ImageOnNothing = global::SIVS.Properties.Resources.Upload_32x32;
            this.btn_DarBaja.Location = new System.Drawing.Point(12, 46);
            this.btn_DarBaja.Name = "btn_DarBaja";
            this.btn_DarBaja.Size = new System.Drawing.Size(110, 32);
            this.btn_DarBaja.TabIndex = 7;
            this.btn_DarBaja.Text = "   Dar baja";
            this.toolTipGral.SetToolTip(this.btn_DarBaja, "Dar de baja el artículo");
            this.btn_DarBaja.UseVisualStyleBackColor = false;
            this.btn_DarBaja.Click += new System.EventHandler(this.btn_DarBaja_Click);
            // 
            // btn_VerBajas
            // 
            this.btn_VerBajas.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_VerBajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_VerBajas.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_VerBajas.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.btn_VerBajas.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_VerBajas.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_VerBajas.BackgroundImage = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_VerBajas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_VerBajas.FlatAppearance.BorderSize = 0;
            this.btn_VerBajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerBajas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_VerBajas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_VerBajas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerBajas.ImageEnableFalse = null;
            this.btn_VerBajas.ImageOnMouseDown = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_VerBajas.ImageOnMouseEnter = global::SIVS.Properties.Resources.VerBajas_32x32_flip;
            this.btn_VerBajas.ImageOnNothing = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_VerBajas.Location = new System.Drawing.Point(128, 46);
            this.btn_VerBajas.Name = "btn_VerBajas";
            this.btn_VerBajas.Size = new System.Drawing.Size(110, 32);
            this.btn_VerBajas.TabIndex = 77;
            this.btn_VerBajas.Tag = "";
            this.btn_VerBajas.Text = "     Ver bajas";
            this.btn_VerBajas.UseVisualStyleBackColor = false;
            this.btn_VerBajas.Click += new System.EventHandler(this.btn_VerBajas_Click);
            // 
            // lbl_medida
            // 
            this.lbl_medida.AutoSize = true;
            this.lbl_medida.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_medida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_medida.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_medida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_medida.Location = new System.Drawing.Point(1, 376);
            this.lbl_medida.Name = "lbl_medida";
            this.lbl_medida.Size = new System.Drawing.Size(154, 27);
            this.lbl_medida.TabIndex = 33;
            this.lbl_medida.Text = "Unid. de Medida : ";
            this.lbl_medida.Click += new System.EventHandler(this.lbl_medida_Click);
            // 
            // cb_medidas
            // 
            this.cb_medidas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_medidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_medidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_medidas.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_medidas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_medidas.FormattingEnabled = true;
            this.cb_medidas.Location = new System.Drawing.Point(168, 373);
            this.cb_medidas.Name = "cb_medidas";
            this.cb_medidas.Size = new System.Drawing.Size(152, 31);
            this.cb_medidas.TabIndex = 21;
            this.cb_medidas.SelectedIndexChanged += new System.EventHandler(this.cb_medidas_SelectedIndexChanged);
            this.cb_medidas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label9.Location = new System.Drawing.Point(3, 266);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 25);
            this.label9.TabIndex = 35;
            this.label9.Text = "Tasa de IVA :  $";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label10.Location = new System.Drawing.Point(3, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(179, 25);
            this.label10.TabIndex = 37;
            this.label10.Text = "Precio Unitario C/I :  $";
            // 
            // txt_precio
            // 
            this.txt_precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_precio.CantDecimales = 2;
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_precio.Location = new System.Drawing.Point(187, 226);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(133, 30);
            this.txt_precio.TabIndex = 17;
            this.txt_precio.Text = "0";
            this.txt_precio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_precio.TextDefault = "0";
            this.txt_precio.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calcular);
            // 
            // txt_costo
            // 
            this.txt_costo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_costo.CantDecimales = 2;
            this.txt_costo.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_costo.Location = new System.Drawing.Point(168, 189);
            this.txt_costo.Name = "txt_costo";
            this.txt_costo.Size = new System.Drawing.Size(152, 30);
            this.txt_costo.TabIndex = 16;
            this.txt_costo.Text = "0";
            this.txt_costo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_costo.TextDefault = "0";
            this.txt_costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_IVA
            // 
            this.txt_IVA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_IVA.CantDecimales = 2;
            this.txt_IVA.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_IVA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_IVA.Location = new System.Drawing.Point(187, 263);
            this.txt_IVA.Name = "txt_IVA";
            this.txt_IVA.Size = new System.Drawing.Size(133, 30);
            this.txt_IVA.TabIndex = 18;
            this.txt_IVA.Text = "0";
            this.txt_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_IVA.TextDefault = "0";
            this.txt_IVA.TextChanged += new System.EventHandler(this.txt_precio_TextChanged);
            this.txt_IVA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calcular);
            // 
            // txt_PrecioConIva
            // 
            this.txt_PrecioConIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_PrecioConIva.CantDecimales = 2;
            this.txt_PrecioConIva.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrecioConIva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_PrecioConIva.Location = new System.Drawing.Point(187, 300);
            this.txt_PrecioConIva.Name = "txt_PrecioConIva";
            this.txt_PrecioConIva.Size = new System.Drawing.Size(133, 30);
            this.txt_PrecioConIva.TabIndex = 19;
            this.txt_PrecioConIva.Text = "0";
            this.txt_PrecioConIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_PrecioConIva.TextDefault = "0";
            this.txt_PrecioConIva.TextChanged += new System.EventHandler(this.txt_PrecioConIva_TextChanged);
            this.txt_PrecioConIva.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calcular);
            // 
            // txt_nota
            // 
            this.txt_nota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nota.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nota.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nota.Location = new System.Drawing.Point(68, 409);
            this.txt_nota.MaxLength = 300;
            this.txt_nota.Multiline = true;
            this.txt_nota.Name = "txt_nota";
            this.txt_nota.Size = new System.Drawing.Size(252, 39);
            this.txt_nota.TabIndex = 22;
            this.txt_nota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label11.Location = new System.Drawing.Point(3, 409);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 25);
            this.label11.TabIndex = 43;
            this.label11.Text = "Nota :";
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_stock.CantDecimales = 2;
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_stock.Location = new System.Drawing.Point(88, 77);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(232, 30);
            this.txt_stock.TabIndex = 12;
            this.txt_stock.Text = "0";
            this.txt_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_stock.TextDefault = "0";
            this.txt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress_1);
            // 
            // btn_Reporte
            // 
            this.btn_Reporte.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Reporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Reporte.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Reporte.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Reporte.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Reporte.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Reporte.BackgroundImage = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Reporte.FlatAppearance.BorderSize = 0;
            this.btn_Reporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Reporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Reporte.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Reporte.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Reporte.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_Reporte.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_Reporte.Location = new System.Drawing.Point(360, 8);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(110, 32);
            this.btn_Reporte.TabIndex = 78;
            this.btn_Reporte.Text = "   Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_GuardarMas
            // 
            this.btn_GuardarMas.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_GuardarMas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_GuardarMas.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_GuardarMas.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_GuardarMas.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_GuardarMas.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_GuardarMas.BackgroundImage = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_GuardarMas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GuardarMas.FlatAppearance.BorderSize = 0;
            this.btn_GuardarMas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GuardarMas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_GuardarMas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GuardarMas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GuardarMas.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_GuardarMas.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_GuardarMas.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_GuardarMas.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_GuardarMas.Location = new System.Drawing.Point(9, 8);
            this.btn_GuardarMas.Name = "btn_GuardarMas";
            this.btn_GuardarMas.Size = new System.Drawing.Size(226, 32);
            this.btn_GuardarMas.TabIndex = 23;
            this.btn_GuardarMas.Text = "     Guardar y agregar otro";
            this.btn_GuardarMas.UseVisualStyleBackColor = false;
            this.btn_GuardarMas.Click += new System.EventHandler(this.btn_GuardarMas_Click);
            // 
            // txt_cantAlta
            // 
            this.txt_cantAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantAlta.CantDecimales = 2;
            this.txt_cantAlta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cantAlta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantAlta.Location = new System.Drawing.Point(272, 142);
            this.txt_cantAlta.Name = "txt_cantAlta";
            this.txt_cantAlta.Size = new System.Drawing.Size(48, 31);
            this.txt_cantAlta.TabIndex = 15;
            this.txt_cantAlta.Text = "3";
            this.txt_cantAlta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantAlta.TextDefault = "3";
            this.txt_cantAlta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_cantMedia
            // 
            this.txt_cantMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantMedia.CantDecimales = 2;
            this.txt_cantMedia.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cantMedia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantMedia.Location = new System.Drawing.Point(169, 142);
            this.txt_cantMedia.Name = "txt_cantMedia";
            this.txt_cantMedia.Size = new System.Drawing.Size(48, 31);
            this.txt_cantMedia.TabIndex = 14;
            this.txt_cantMedia.Text = "2";
            this.txt_cantMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantMedia.TextDefault = "2";
            this.txt_cantMedia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_cantBaja
            // 
            this.txt_cantBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cantBaja.CantDecimales = 2;
            this.txt_cantBaja.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cantBaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cantBaja.Location = new System.Drawing.Point(54, 142);
            this.txt_cantBaja.Name = "txt_cantBaja";
            this.txt_cantBaja.Size = new System.Drawing.Size(48, 31);
            this.txt_cantBaja.TabIndex = 13;
            this.txt_cantBaja.Text = "1";
            this.txt_cantBaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_cantBaja.TextDefault = "1";
            this.txt_cantBaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label24.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label24.Location = new System.Drawing.Point(220, 145);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(46, 25);
            this.label24.TabIndex = 106;
            this.label24.Text = "Alto:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label23.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label23.Location = new System.Drawing.Point(105, 145);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(64, 25);
            this.label23.TabIndex = 105;
            this.label23.Text = "Medio:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label22.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label22.Location = new System.Drawing.Point(3, 145);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 25);
            this.label22.TabIndex = 104;
            this.label22.Text = "Bajo:";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label21.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label21.Location = new System.Drawing.Point(0, 113);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(326, 25);
            this.label21.TabIndex = 103;
            this.label21.Text = "Niveles de stock";
            // 
            // btn_precios
            // 
            this.btn_precios.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_precios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_precios.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_precios.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_precios.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_precios.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_precios.BackgroundImage = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_precios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_precios.FlatAppearance.BorderSize = 0;
            this.btn_precios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_precios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_precios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_precios.ImageEnableFalse = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_precios.ImageOnMouseDown = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_precios.ImageOnMouseEnter = global::SIVS.Properties.Resources.Reporte_32_flip30;
            this.btn_precios.ImageOnNothing = global::SIVS.Properties.Resources.Reporte_32;
            this.btn_precios.Location = new System.Drawing.Point(3, 46);
            this.btn_precios.Name = "btn_precios";
            this.btn_precios.Size = new System.Drawing.Size(110, 32);
            this.btn_precios.TabIndex = 79;
            this.btn_precios.Text = "   Precios";
            this.btn_precios.UseVisualStyleBackColor = false;
            this.btn_precios.Click += new System.EventHandler(this.buttonImages1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_busquedaDescripcion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_busquedaCodigo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 412);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(631, 39);
            this.panel1.TabIndex = 29;
            // 
            // txt_busquedaDescripcion
            // 
            this.txt_busquedaDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_busquedaDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_busquedaDescripcion.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaDescripcion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_busquedaDescripcion.Location = new System.Drawing.Point(204, 5);
            this.txt_busquedaDescripcion.MaxLength = 300;
            this.txt_busquedaDescripcion.Multiline = true;
            this.txt_busquedaDescripcion.Name = "txt_busquedaDescripcion";
            this.txt_busquedaDescripcion.Size = new System.Drawing.Size(188, 29);
            this.txt_busquedaDescripcion.TabIndex = 41;
            this.txt_busquedaDescripcion.Tag = "1";
            this.txt_busquedaDescripcion.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            this.txt_busquedaDescripcion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_articulos_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "Busqueda descripción:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label7.Location = new System.Drawing.Point(392, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 25);
            this.label7.TabIndex = 38;
            this.label7.Text = "Codigo:";
            // 
            // txt_busquedaCodigo
            // 
            this.txt_busquedaCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_busquedaCodigo.Dock = System.Windows.Forms.DockStyle.Right;
            this.txt_busquedaCodigo.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busquedaCodigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_busquedaCodigo.Location = new System.Drawing.Point(463, 5);
            this.txt_busquedaCodigo.MaxLength = 100;
            this.txt_busquedaCodigo.Name = "txt_busquedaCodigo";
            this.txt_busquedaCodigo.Size = new System.Drawing.Size(163, 30);
            this.txt_busquedaCodigo.TabIndex = 30;
            this.txt_busquedaCodigo.Tag = "2";
            this.txt_busquedaCodigo.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            this.txt_busquedaCodigo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_articulos_KeyDown);
            // 
            // btn_modificarPrecios
            // 
            this.btn_modificarPrecios.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_modificarPrecios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_modificarPrecios.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_modificarPrecios.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.btn_modificarPrecios.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_modificarPrecios.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_modificarPrecios.BackgroundImage = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_modificarPrecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_modificarPrecios.FlatAppearance.BorderSize = 0;
            this.btn_modificarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modificarPrecios.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_modificarPrecios.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_modificarPrecios.ImageEnableFalse = null;
            this.btn_modificarPrecios.ImageOnMouseDown = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_modificarPrecios.ImageOnMouseEnter = global::SIVS.Properties.Resources.ModificaStock_32x32_flip;
            this.btn_modificarPrecios.ImageOnNothing = global::SIVS.Properties.Resources.ModificaStock_32x32;
            this.btn_modificarPrecios.Location = new System.Drawing.Point(244, 46);
            this.btn_modificarPrecios.Name = "btn_modificarPrecios";
            this.btn_modificarPrecios.Size = new System.Drawing.Size(226, 32);
            this.btn_modificarPrecios.TabIndex = 80;
            this.btn_modificarPrecios.Text = "Modificar Precios";
            this.btn_modificarPrecios.UseVisualStyleBackColor = false;
            this.btn_modificarPrecios.Click += new System.EventHandler(this.btn_modificarPrecios_Click);
            // 
            // Frm_ABM_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(996, 557);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1012, 593);
            this.Name = "Frm_ABM_articulos";
            this.Tag = "1";
            this.Text = "Administrador de artículos";
            this.Activated += new System.EventHandler(this.Frm_ABM_articulos_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_articulos_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_articulos_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_articulos_KeyDown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_medidas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgrid_articulos;
        private System.Windows.Forms.BindingSource bs_articulos;
        private CONTROLES.ButtonImages btn_stock;
        private System.Windows.Forms.BindingSource bs_rubros;
        private System.Windows.Forms.ComboBox cbb_Rubro;
        private System.Windows.Forms.Label lbl_rubro;
        private CONTROLES.ButtonImages btn_DarBaja;
        private CONTROLES.ButtonImages btn_VerBajas;
        private System.Windows.Forms.ToolTip toolTipGral;
        private System.Windows.Forms.Label lbl_medida;
        private System.Windows.Forms.ComboBox cb_medidas;
        private System.Windows.Forms.BindingSource bs_medidas;
        private System.Windows.Forms.TextBox txt_nota;
        private System.Windows.Forms.Label label11;
        private CONTROLES.TextBox_Decimal txt_PrecioConIva;
        private CONTROLES.TextBox_Decimal txt_IVA;
        private CONTROLES.TextBox_Decimal txt_costo;
        private CONTROLES.TextBox_Decimal txt_precio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private CONTROLES.TextBox_Decimal txt_stock;
        private CONTROLES.ButtonImages btn_Reporte;
        protected CONTROLES.ButtonImages btn_GuardarMas;
        private CONTROLES.TextBox_Decimal txt_cantAlta;
        private CONTROLES.TextBox_Decimal txt_cantMedia;
        private CONTROLES.TextBox_Decimal txt_cantBaja;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private CONTROLES.ButtonImages btn_precios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_busquedaCodigo;
        private CONTROLES.ButtonImages btn_modificarPrecios;
        private System.Windows.Forms.TextBox txt_busquedaDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
