namespace SIVS
{
    partial class Frm_cuenta_corriente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cuenta_corriente));
            this.dgrid_Debitos = new System.Windows.Forms.DataGridView();
            this.dgrid_Creditos = new System.Windows.Forms.DataGridView();
            this.lbl_debito = new System.Windows.Forms.Label();
            this.lbl_creditos = new System.Windows.Forms.Label();
            this.L_descripcion = new System.Windows.Forms.Label();
            this.bs_debitos = new System.Windows.Forms.BindingSource(this.components);
            this.bs_creditos = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tt_general = new System.Windows.Forms.ToolTip(this.components);
            this.cb_afecta_caja = new System.Windows.Forms.CheckBox();
            this.rb_debito = new System.Windows.Forms.RadioButton();
            this.rb_credito = new System.Windows.Forms.RadioButton();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_concepto = new System.Windows.Forms.TextBox();
            this.p_datos = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_actualizarSaldo = new CONTROLES.ButtonImages();
            this.btn_VerTodo = new CONTROLES.ButtonImages();
            this.btn_DarBaja = new CONTROLES.ButtonImages();
            this.btn_DarBajaTodos = new CONTROLES.ButtonImages();
            this.p_saldos = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.L_APagar = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.L_Pagado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.L_Incial = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_importe = new CONTROLES.TextBox_Decimal();
            this.bs_formas = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_formaPago = new System.Windows.Forms.Label();
            this.btn_Liquidacion = new CONTROLES.ButtonImages();
            this.btn_Reporte = new CONTROLES.ButtonImages();
            this.btn_AgregarDebito = new CONTROLES.ButtonImages();
            this.p_grillas = new System.Windows.Forms.Panel();
            this.p_grillaIzq = new System.Windows.Forms.Panel();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Debitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Creditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_debitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_creditos)).BeginInit();
            this.p_datos.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p_saldos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_formas)).BeginInit();
            this.p_grillas.SuspendLayout();
            this.p_grillaIzq.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(4, 45);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = null;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(7, 45);
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = null;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(7, 7);
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(286, 7);
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = null;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(170, 7);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = null;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(8, 7);
            this.btn_Agregar.Size = new System.Drawing.Size(156, 32);
            this.btn_Agregar.Tag = "1";
            this.btn_Agregar.Text = "      Agregar Credito";
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 483);
            this.pbtn.Size = new System.Drawing.Size(992, 85);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.lbl_formaPago);
            this.pn_abm.Controls.Add(this.txt_importe);
            this.pn_abm.Controls.Add(this.cb_afecta_caja);
            this.pn_abm.Controls.Add(this.rb_debito);
            this.pn_abm.Controls.Add(this.rb_credito);
            this.pn_abm.Controls.Add(this.txt_dia);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.label4);
            this.pn_abm.Controls.Add(this.txt_concepto);
            this.pn_abm.Size = new System.Drawing.Size(174, 467);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.p_grillas);
            this.gb_abm.Controls.Add(this.p_saldos);
            this.gb_abm.Controls.Add(this.p_datos);
            this.gb_abm.Size = new System.Drawing.Size(794, 467);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(992, 483);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(802, 8);
            this.p_derecho.Size = new System.Drawing.Size(182, 467);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(863, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(129, 85);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.btn_AgregarDebito);
            this.pn_btnABM.Controls.Add(this.btn_VerTodo);
            this.pn_btnABM.Controls.Add(this.btn_Reporte);
            this.pn_btnABM.Controls.Add(this.btn_DarBaja);
            this.pn_btnABM.Controls.Add(this.btn_Liquidacion);
            this.pn_btnABM.Controls.Add(this.btn_DarBajaTodos);
            this.pn_btnABM.Size = new System.Drawing.Size(863, 85);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_DarBajaTodos, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Liquidacion, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_DarBaja, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Reporte, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_VerTodo, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_AgregarDebito, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.pn_btnSalir, 0);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(743, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(120, 85);
            // 
            // dgrid_Debitos
            // 
            this.dgrid_Debitos.AllowUserToAddRows = false;
            this.dgrid_Debitos.AllowUserToDeleteRows = false;
            this.dgrid_Debitos.AllowUserToResizeRows = false;
            this.dgrid_Debitos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Debitos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Debitos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Debitos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Debitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_Debitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Debitos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgrid_Debitos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Debitos.Location = new System.Drawing.Point(0, 32);
            this.dgrid_Debitos.MultiSelect = false;
            this.dgrid_Debitos.Name = "dgrid_Debitos";
            this.dgrid_Debitos.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Debitos.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgrid_Debitos.RowHeadersVisible = false;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgrid_Debitos.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgrid_Debitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Debitos.Size = new System.Drawing.Size(317, 254);
            this.dgrid_Debitos.TabIndex = 26;
            this.dgrid_Debitos.SelectionChanged += new System.EventHandler(this.dgrid_Debitos_SelectionChanged);
            this.dgrid_Debitos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_Debitos_MouseDoubleClick);
            // 
            // dgrid_Creditos
            // 
            this.dgrid_Creditos.AllowUserToAddRows = false;
            this.dgrid_Creditos.AllowUserToDeleteRows = false;
            this.dgrid_Creditos.AllowUserToResizeRows = false;
            this.dgrid_Creditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Creditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Creditos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Creditos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Creditos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_Creditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Creditos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_Creditos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Creditos.Location = new System.Drawing.Point(322, 32);
            this.dgrid_Creditos.Name = "dgrid_Creditos";
            this.dgrid_Creditos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_Creditos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_Creditos.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.dgrid_Creditos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_Creditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Creditos.Size = new System.Drawing.Size(344, 254);
            this.dgrid_Creditos.TabIndex = 27;
            this.dgrid_Creditos.SelectionChanged += new System.EventHandler(this.dgrid_Creditos_SelectionChanged);
            this.dgrid_Creditos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_Creditos_MouseDoubleClick);
            // 
            // lbl_debito
            // 
            this.lbl_debito.BackColor = System.Drawing.Color.Transparent;
            this.lbl_debito.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_debito.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_debito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_debito.Location = new System.Drawing.Point(0, 0);
            this.lbl_debito.Name = "lbl_debito";
            this.lbl_debito.Size = new System.Drawing.Size(317, 32);
            this.lbl_debito.TabIndex = 37;
            this.lbl_debito.Text = "Débitos";
            this.lbl_debito.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_creditos
            // 
            this.lbl_creditos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_creditos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_creditos.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_creditos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_creditos.Location = new System.Drawing.Point(322, 0);
            this.lbl_creditos.Name = "lbl_creditos";
            this.lbl_creditos.Size = new System.Drawing.Size(344, 32);
            this.lbl_creditos.TabIndex = 38;
            this.lbl_creditos.Text = "Créditos";
            this.lbl_creditos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // L_descripcion
            // 
            this.L_descripcion.AutoSize = true;
            this.L_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.L_descripcion.Dock = System.Windows.Forms.DockStyle.Left;
            this.L_descripcion.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.L_descripcion.Location = new System.Drawing.Point(0, 0);
            this.L_descripcion.Name = "L_descripcion";
            this.L_descripcion.Size = new System.Drawing.Size(155, 28);
            this.L_descripcion.TabIndex = 37;
            this.L_descripcion.Text = "Datos personales";
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_saldo.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.lbl_saldo.Location = new System.Drawing.Point(115, 53);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(158, 54);
            this.lbl_saldo.TabIndex = 39;
            this.lbl_saldo.Text = "0000,00";
            this.lbl_saldo.TextChanged += new System.EventHandler(this.lbl_saldo_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 38);
            this.label6.TabIndex = 40;
            this.label6.Text = "Saldo";
            // 
            // tt_general
            // 
            this.tt_general.IsBalloon = true;
            // 
            // cb_afecta_caja
            // 
            this.cb_afecta_caja.BackColor = System.Drawing.Color.Transparent;
            this.cb_afecta_caja.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cb_afecta_caja.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_afecta_caja.Location = new System.Drawing.Point(7, 335);
            this.cb_afecta_caja.Name = "cb_afecta_caja";
            this.cb_afecta_caja.Size = new System.Drawing.Size(156, 47);
            this.cb_afecta_caja.TabIndex = 59;
            this.cb_afecta_caja.Text = "Registrar en caja";
            this.cb_afecta_caja.UseVisualStyleBackColor = false;
            this.cb_afecta_caja.CheckedChanged += new System.EventHandler(this.cb_afecta_caja_CheckedChanged);
            // 
            // rb_debito
            // 
            this.rb_debito.AutoSize = true;
            this.rb_debito.BackColor = System.Drawing.Color.Transparent;
            this.rb_debito.Enabled = false;
            this.rb_debito.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rb_debito.Location = new System.Drawing.Point(90, 309);
            this.rb_debito.Name = "rb_debito";
            this.rb_debito.Size = new System.Drawing.Size(80, 29);
            this.rb_debito.TabIndex = 56;
            this.rb_debito.Text = "Debito";
            this.rb_debito.UseVisualStyleBackColor = false;
            // 
            // rb_credito
            // 
            this.rb_credito.AutoSize = true;
            this.rb_credito.BackColor = System.Drawing.Color.Transparent;
            this.rb_credito.Checked = true;
            this.rb_credito.Enabled = false;
            this.rb_credito.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.rb_credito.Location = new System.Drawing.Point(6, 309);
            this.rb_credito.Name = "rb_credito";
            this.rb_credito.Size = new System.Drawing.Size(85, 29);
            this.rb_credito.TabIndex = 57;
            this.rb_credito.TabStop = true;
            this.rb_credito.Text = "Credito";
            this.rb_credito.UseVisualStyleBackColor = false;
            this.rb_credito.CheckedChanged += new System.EventHandler(this.rb_credito_CheckedChanged);
            // 
            // txt_dia
            // 
            this.txt_dia.Enabled = false;
            this.txt_dia.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_dia.Location = new System.Drawing.Point(13, 32);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(150, 31);
            this.txt_dia.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(8, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 55;
            this.label2.Text = "Importe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(7, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Fecha :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.Location = new System.Drawing.Point(8, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 52;
            this.label4.Text = "Concepto:";
            // 
            // txt_concepto
            // 
            this.txt_concepto.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_concepto.Location = new System.Drawing.Point(12, 94);
            this.txt_concepto.MaxLength = 100;
            this.txt_concepto.Multiline = true;
            this.txt_concepto.Name = "txt_concepto";
            this.txt_concepto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_concepto.Size = new System.Drawing.Size(150, 148);
            this.txt_concepto.TabIndex = 90;
            // 
            // p_datos
            // 
            this.p_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_datos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_datos.Controls.Add(this.panel2);
            this.p_datos.Controls.Add(this.L_descripcion);
            this.p_datos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_datos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_datos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_datos.Location = new System.Drawing.Point(0, 286);
            this.p_datos.Name = "p_datos";
            this.p_datos.Size = new System.Drawing.Size(794, 181);
            this.p_datos.TabIndex = 52;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_actualizarSaldo);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_saldo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(498, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(296, 181);
            this.panel2.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 30F);
            this.label5.Location = new System.Drawing.Point(7, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 54);
            this.label5.TabIndex = 60;
            this.label5.Text = "$";
            // 
            // btn_actualizarSaldo
            // 
            this.btn_actualizarSaldo.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_actualizarSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_actualizarSaldo.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_actualizarSaldo.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_actualizarSaldo.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_actualizarSaldo.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_actualizarSaldo.BackgroundImage = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_actualizarSaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_actualizarSaldo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_actualizarSaldo.FlatAppearance.BorderSize = 0;
            this.btn_actualizarSaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizarSaldo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_actualizarSaldo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_actualizarSaldo.ImageEnableFalse = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_actualizarSaldo.ImageOnMouseDown = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_actualizarSaldo.ImageOnMouseEnter = global::SIVS.Properties.Resources.Liquidacion_32_flip;
            this.btn_actualizarSaldo.ImageOnNothing = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_actualizarSaldo.Location = new System.Drawing.Point(4, 145);
            this.btn_actualizarSaldo.Name = "btn_actualizarSaldo";
            this.btn_actualizarSaldo.Size = new System.Drawing.Size(288, 32);
            this.btn_actualizarSaldo.TabIndex = 59;
            this.btn_actualizarSaldo.Text = "   Actualizar saldo a precios actuales";
            this.btn_actualizarSaldo.UseVisualStyleBackColor = false;
            this.btn_actualizarSaldo.Click += new System.EventHandler(this.btn_actualizarSaldo_Click);
            // 
            // btn_VerTodo
            // 
            this.btn_VerTodo.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_VerTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_VerTodo.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_VerTodo.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_VerTodo.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_VerTodo.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_VerTodo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_VerTodo.FlatAppearance.BorderSize = 0;
            this.btn_VerTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerTodo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_VerTodo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_VerTodo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_VerTodo.ImageEnableFalse = null;
            this.btn_VerTodo.ImageOnMouseDown = null;
            this.btn_VerTodo.ImageOnMouseEnter = null;
            this.btn_VerTodo.ImageOnNothing = null;
            this.btn_VerTodo.Location = new System.Drawing.Point(170, 45);
            this.btn_VerTodo.Name = "btn_VerTodo";
            this.btn_VerTodo.Size = new System.Drawing.Size(226, 32);
            this.btn_VerTodo.TabIndex = 56;
            this.btn_VerTodo.Text = "     Ver todos";
            this.btn_VerTodo.UseVisualStyleBackColor = false;
            this.btn_VerTodo.Click += new System.EventHandler(this.btn_VerTodo_Click);
            // 
            // btn_DarBaja
            // 
            this.btn_DarBaja.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_DarBaja.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_DarBaja.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
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
            this.btn_DarBaja.Location = new System.Drawing.Point(402, 7);
            this.btn_DarBaja.Name = "btn_DarBaja";
            this.btn_DarBaja.Size = new System.Drawing.Size(110, 32);
            this.btn_DarBaja.TabIndex = 57;
            this.btn_DarBaja.Text = "   Dar baja";
            this.btn_DarBaja.UseVisualStyleBackColor = false;
            this.btn_DarBaja.Click += new System.EventHandler(this.btn_DarBaja_Click);
            // 
            // btn_DarBajaTodos
            // 
            this.btn_DarBajaTodos.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_DarBajaTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_DarBajaTodos.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_DarBajaTodos.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_DarBajaTodos.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_DarBajaTodos.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_DarBajaTodos.BackgroundImage = global::SIVS.Properties.Resources.Upload_32x32;
            this.btn_DarBajaTodos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_DarBajaTodos.FlatAppearance.BorderSize = 0;
            this.btn_DarBajaTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarBajaTodos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_DarBajaTodos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_DarBajaTodos.ImageEnableFalse = null;
            this.btn_DarBajaTodos.ImageOnMouseDown = global::SIVS.Properties.Resources.Upload_32x32;
            this.btn_DarBajaTodos.ImageOnMouseEnter = global::SIVS.Properties.Resources.Upload_32x32_flip;
            this.btn_DarBajaTodos.ImageOnNothing = global::SIVS.Properties.Resources.Upload_32x32;
            this.btn_DarBajaTodos.Location = new System.Drawing.Point(402, 45);
            this.btn_DarBajaTodos.Name = "btn_DarBajaTodos";
            this.btn_DarBajaTodos.Size = new System.Drawing.Size(226, 32);
            this.btn_DarBajaTodos.TabIndex = 58;
            this.btn_DarBajaTodos.Text = "   Dar baja todos";
            this.btn_DarBajaTodos.UseVisualStyleBackColor = false;
            this.btn_DarBajaTodos.Click += new System.EventHandler(this.btn_DarBajaTodos_Click);
            // 
            // p_saldos
            // 
            this.p_saldos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_saldos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_saldos.Controls.Add(this.label11);
            this.p_saldos.Controls.Add(this.L_APagar);
            this.p_saldos.Controls.Add(this.label13);
            this.p_saldos.Controls.Add(this.label8);
            this.p_saldos.Controls.Add(this.L_Pagado);
            this.p_saldos.Controls.Add(this.label10);
            this.p_saldos.Controls.Add(this.label7);
            this.p_saldos.Controls.Add(this.L_Incial);
            this.p_saldos.Controls.Add(this.label3);
            this.p_saldos.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_saldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_saldos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_saldos.Location = new System.Drawing.Point(666, 0);
            this.p_saldos.Name = "p_saldos";
            this.p_saldos.Size = new System.Drawing.Size(128, 286);
            this.p_saldos.TabIndex = 54;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label11.Location = new System.Drawing.Point(7, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 25);
            this.label11.TabIndex = 64;
            this.label11.Text = "$";
            // 
            // L_APagar
            // 
            this.L_APagar.AutoSize = true;
            this.L_APagar.BackColor = System.Drawing.Color.Transparent;
            this.L_APagar.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.L_APagar.Location = new System.Drawing.Point(21, 162);
            this.L_APagar.Name = "L_APagar";
            this.L_APagar.Size = new System.Drawing.Size(107, 37);
            this.L_APagar.TabIndex = 63;
            this.L_APagar.Text = "0000,00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label13.Location = new System.Drawing.Point(5, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 62;
            this.label13.Text = "Saldo a pagar :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label8.Location = new System.Drawing.Point(5, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 25);
            this.label8.TabIndex = 61;
            this.label8.Text = "$";
            // 
            // L_Pagado
            // 
            this.L_Pagado.AutoSize = true;
            this.L_Pagado.BackColor = System.Drawing.Color.Transparent;
            this.L_Pagado.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.L_Pagado.Location = new System.Drawing.Point(19, 98);
            this.L_Pagado.Name = "L_Pagado";
            this.L_Pagado.Size = new System.Drawing.Size(107, 37);
            this.L_Pagado.TabIndex = 60;
            this.L_Pagado.Text = "0000,00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label10.Location = new System.Drawing.Point(3, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 25);
            this.label10.TabIndex = 59;
            this.label10.Text = "Saldo pagado :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label7.Location = new System.Drawing.Point(5, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 25);
            this.label7.TabIndex = 58;
            this.label7.Text = "$";
            // 
            // L_Incial
            // 
            this.L_Incial.AutoSize = true;
            this.L_Incial.BackColor = System.Drawing.Color.Transparent;
            this.L_Incial.Font = new System.Drawing.Font("Segoe UI Light", 20F);
            this.L_Incial.Location = new System.Drawing.Point(19, 33);
            this.L_Incial.Name = "L_Incial";
            this.L_Incial.Size = new System.Drawing.Size(107, 37);
            this.L_Incial.TabIndex = 57;
            this.L_Incial.Text = "0000,00";
            this.L_Incial.TextChanged += new System.EventHandler(this.L_Incial_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.Location = new System.Drawing.Point(5, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 56;
            this.label3.Text = "Saldo inicial :";
            // 
            // txt_importe
            // 
            this.txt_importe.CantDecimales = 2;
            this.txt_importe.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_importe.Location = new System.Drawing.Point(11, 272);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(151, 31);
            this.txt_importe.TabIndex = 91;
            this.txt_importe.Text = "0";
            this.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_importe.TextDefault = "0";
            this.txt_importe.TextChanged += new System.EventHandler(this.txt_importe_TextChanged);
            // 
            // lbl_formaPago
            // 
            this.lbl_formaPago.AutoSize = true;
            this.lbl_formaPago.BackColor = System.Drawing.Color.Transparent;
            this.lbl_formaPago.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_formaPago.Location = new System.Drawing.Point(8, 375);
            this.lbl_formaPago.Name = "lbl_formaPago";
            this.lbl_formaPago.Size = new System.Drawing.Size(128, 25);
            this.lbl_formaPago.TabIndex = 82;
            this.lbl_formaPago.Text = "Forma de pago";
            this.lbl_formaPago.Visible = false;
            // 
            // btn_Liquidacion
            // 
            this.btn_Liquidacion.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Liquidacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Liquidacion.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Liquidacion.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Liquidacion.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Liquidacion.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Liquidacion.BackgroundImage = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_Liquidacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Liquidacion.FlatAppearance.BorderSize = 0;
            this.btn_Liquidacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Liquidacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Liquidacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Liquidacion.ImageEnableFalse = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_Liquidacion.ImageOnMouseDown = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_Liquidacion.ImageOnMouseEnter = global::SIVS.Properties.Resources.Liquidacion_32_flip;
            this.btn_Liquidacion.ImageOnNothing = global::SIVS.Properties.Resources.Liquidacion_32;
            this.btn_Liquidacion.Location = new System.Drawing.Point(634, 7);
            this.btn_Liquidacion.Name = "btn_Liquidacion";
            this.btn_Liquidacion.Size = new System.Drawing.Size(145, 32);
            this.btn_Liquidacion.TabIndex = 58;
            this.btn_Liquidacion.Text = "   Liquidación";
            this.btn_Liquidacion.UseVisualStyleBackColor = false;
            this.btn_Liquidacion.Click += new System.EventHandler(this.btn_Liquidacion_Click);
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
            this.btn_Reporte.Location = new System.Drawing.Point(518, 7);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(110, 32);
            this.btn_Reporte.TabIndex = 59;
            this.btn_Reporte.Text = "   Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // btn_AgregarDebito
            // 
            this.btn_AgregarDebito.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarDebito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarDebito.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_AgregarDebito.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_AgregarDebito.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_AgregarDebito.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarDebito.BackgroundImage = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarDebito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AgregarDebito.FlatAppearance.BorderSize = 0;
            this.btn_AgregarDebito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarDebito.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AgregarDebito.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AgregarDebito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarDebito.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarDebito.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarDebito.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_AgregarDebito.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarDebito.Location = new System.Drawing.Point(8, 45);
            this.btn_AgregarDebito.Name = "btn_AgregarDebito";
            this.btn_AgregarDebito.Size = new System.Drawing.Size(156, 32);
            this.btn_AgregarDebito.TabIndex = 60;
            this.btn_AgregarDebito.Tag = "2";
            this.btn_AgregarDebito.Text = "      Agregar debito";
            this.btn_AgregarDebito.UseVisualStyleBackColor = false;
            this.btn_AgregarDebito.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // p_grillas
            // 
            this.p_grillas.Controls.Add(this.dgrid_Creditos);
            this.p_grillas.Controls.Add(this.lbl_creditos);
            this.p_grillas.Controls.Add(this.p_grillaIzq);
            this.p_grillas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_grillas.Location = new System.Drawing.Point(0, 0);
            this.p_grillas.Name = "p_grillas";
            this.p_grillas.Size = new System.Drawing.Size(666, 286);
            this.p_grillas.TabIndex = 55;
            this.p_grillas.Resize += new System.EventHandler(this.p_grillas_Resize);
            // 
            // p_grillaIzq
            // 
            this.p_grillaIzq.Controls.Add(this.dgrid_Debitos);
            this.p_grillaIzq.Controls.Add(this.lbl_debito);
            this.p_grillaIzq.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_grillaIzq.Location = new System.Drawing.Point(0, 0);
            this.p_grillaIzq.Name = "p_grillaIzq";
            this.p_grillaIzq.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.p_grillaIzq.Size = new System.Drawing.Size(322, 286);
            this.p_grillaIzq.TabIndex = 39;
            // 
            // Frm_cuenta_corriente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(992, 568);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_cuenta_corriente";
            this.Text = "Cuenta corriente de";
            this.Activated += new System.EventHandler(this.Frm_cuenta_corriente_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_cuenta_corriente_FormClosing);
            this.Load += new System.EventHandler(this.Frm_cuenta_corriente_Load);
            this.Shown += new System.EventHandler(this.Frm_cuenta_corriente_Shown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Debitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Creditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_debitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_creditos)).EndInit();
            this.p_datos.ResumeLayout(false);
            this.p_datos.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.p_saldos.ResumeLayout(false);
            this.p_saldos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_formas)).EndInit();
            this.p_grillas.ResumeLayout(false);
            this.p_grillaIzq.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_Creditos;
        private System.Windows.Forms.DataGridView dgrid_Debitos;
        private System.Windows.Forms.Label lbl_creditos;
        private System.Windows.Forms.Label lbl_debito;
        private System.Windows.Forms.Label L_descripcion;
        private System.Windows.Forms.BindingSource bs_debitos;
        private System.Windows.Forms.BindingSource bs_creditos;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip tt_general;
        private System.Windows.Forms.CheckBox cb_afecta_caja;
        private System.Windows.Forms.RadioButton rb_debito;
        private System.Windows.Forms.RadioButton rb_credito;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_concepto;
        protected System.Windows.Forms.Panel p_datos;
        protected System.Windows.Forms.Panel panel2;
        private CONTROLES.ButtonImages btn_VerTodo;
        private CONTROLES.ButtonImages btn_DarBaja;
        private CONTROLES.ButtonImages btn_DarBajaTodos;
        protected System.Windows.Forms.Panel p_saldos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label L_APagar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_Pagado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label L_Incial;
        private System.Windows.Forms.Label label3;
        private CONTROLES.TextBox_Decimal txt_importe;
        private System.Windows.Forms.BindingSource bs_formas;
        private System.Windows.Forms.Label lbl_formaPago;
        private CONTROLES.ButtonImages btn_Liquidacion;
        private CONTROLES.ButtonImages btn_Reporte;
        protected CONTROLES.ButtonImages btn_AgregarDebito;
        private CONTROLES.ButtonImages btn_actualizarSaldo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel p_grillas;
        private System.Windows.Forms.Panel p_grillaIzq;
    }
}
