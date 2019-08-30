namespace SIVS
{
    partial class Frm_ABM_configuraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_configuraciones));
            this.tt_general = new System.Windows.Forms.ToolTip(this.components);
            this.rb_Xventa = new System.Windows.Forms.RadioButton();
            this.rb_Xcaja_diaria = new System.Windows.Forms.RadioButton();
            this.cb_multicaja = new System.Windows.Forms.CheckBox();
            this.cb_multiusuario = new System.Windows.Forms.CheckBox();
            this.cb_pedirpassword = new System.Windows.Forms.CheckBox();
            this.cb_Comisiones = new System.Windows.Forms.CheckBox();
            this.rb_habilitarImpresora = new System.Windows.Forms.RadioButton();
            this.rb_desabilitarImpresora = new System.Windows.Forms.RadioButton();
            this.rb_Epson = new System.Windows.Forms.RadioButton();
            this.rb_Hasar = new System.Windows.Forms.RadioButton();
            this.rb_Xcompras = new System.Windows.Forms.RadioButton();
            this.rb_formulario = new System.Windows.Forms.RadioButton();
            this.rb_AdiFor = new System.Windows.Forms.RadioButton();
            this.rb_ForAdi = new System.Windows.Forms.RadioButton();
            this.rb_RecDesc = new System.Windows.Forms.RadioButton();
            this.rb_DescRec = new System.Windows.Forms.RadioButton();
            this.txt_puerto = new CONTROLES.TextBox_Int();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.p_configimpr = new System.Windows.Forms.Panel();
            this.txt_nomLogico = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_ModelHasar = new System.Windows.Forms.ComboBox();
            this.cb_ModelEpson = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_porcentaje = new CONTROLES.TextBox_Decimal();
            this.pn_comisiones = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_iva = new CONTROLES.TextBox_Decimal();
            this.label13 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            this.panel2.SuspendLayout();
            this.p_configimpr.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.pn_comisiones.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(3, 6);
            this.btn_Salir.Text = "      Cancelar";
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            this.btn_Salir.Visible = false;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(224, 6);
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click_1);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackcolorEnableFalse = System.Drawing.Color.Gray;
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Guardar.Location = new System.Drawing.Point(108, 6);
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(208, 404);
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Visible = false;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(110, 404);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Visible = false;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(12, 404);
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Visible = false;
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 449);
            this.pbtn.Size = new System.Drawing.Size(908, 44);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.label9);
            this.pn_abm.Controls.Add(this.rb_Xventa);
            this.pn_abm.Controls.Add(this.rb_Xcaja_diaria);
            this.pn_abm.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_abm.Location = new System.Drawing.Point(0, 0);
            this.pn_abm.Margin = new System.Windows.Forms.Padding(4);
            this.pn_abm.Size = new System.Drawing.Size(294, 149);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.label11);
            this.gb_abm.Controls.Add(this.rb_desabilitarImpresora);
            this.gb_abm.Controls.Add(this.rb_habilitarImpresora);
            this.gb_abm.Location = new System.Drawing.Point(300, 0);
            this.gb_abm.Size = new System.Drawing.Size(178, 149);
            // 
            // p_arriba
            // 
            this.p_arriba.Dock = System.Windows.Forms.DockStyle.None;
            this.p_arriba.Location = new System.Drawing.Point(7, 178);
            this.p_arriba.Padding = new System.Windows.Forms.Padding(0);
            this.p_arriba.Size = new System.Drawing.Size(478, 149);
            // 
            // p_derecho
            // 
            this.p_derecho.Dock = System.Windows.Forms.DockStyle.Left;
            this.p_derecho.Location = new System.Drawing.Point(0, 0);
            this.p_derecho.Padding = new System.Windows.Forms.Padding(0);
            this.p_derecho.Size = new System.Drawing.Size(300, 149);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(566, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(342, 44);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.label15);
            this.pn_btnABM.Size = new System.Drawing.Size(566, 44);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.pn_btnSalir, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.label15, 0);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(449, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(117, 44);
            // 
            // rb_Xventa
            // 
            this.rb_Xventa.AutoSize = true;
            this.rb_Xventa.BackColor = System.Drawing.Color.Transparent;
            this.rb_Xventa.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Xventa.Location = new System.Drawing.Point(12, 97);
            this.rb_Xventa.Name = "rb_Xventa";
            this.rb_Xventa.Size = new System.Drawing.Size(273, 29);
            this.rb_Xventa.TabIndex = 55;
            this.rb_Xventa.Text = "Cada venta tiene un vendedor";
            this.tt_general.SetToolTip(this.rb_Xventa, "Cada venta se ");
            this.rb_Xventa.UseVisualStyleBackColor = false;
            // 
            // rb_Xcaja_diaria
            // 
            this.rb_Xcaja_diaria.AutoSize = true;
            this.rb_Xcaja_diaria.BackColor = System.Drawing.Color.Transparent;
            this.rb_Xcaja_diaria.Checked = true;
            this.rb_Xcaja_diaria.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Xcaja_diaria.Location = new System.Drawing.Point(12, 52);
            this.rb_Xcaja_diaria.Name = "rb_Xcaja_diaria";
            this.rb_Xcaja_diaria.Size = new System.Drawing.Size(260, 29);
            this.rb_Xcaja_diaria.TabIndex = 56;
            this.rb_Xcaja_diaria.TabStop = true;
            this.rb_Xcaja_diaria.Text = "Una caja diaria por vendedor";
            this.tt_general.SetToolTip(this.rb_Xcaja_diaria, "El mismo vendedor va a ser para toda la caja diaria");
            this.rb_Xcaja_diaria.UseVisualStyleBackColor = false;
            this.rb_Xcaja_diaria.CheckedChanged += new System.EventHandler(this.rb_Xventa_CheckedChanged);
            // 
            // cb_multicaja
            // 
            this.cb_multicaja.AutoSize = true;
            this.cb_multicaja.BackColor = System.Drawing.Color.Transparent;
            this.cb_multicaja.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.cb_multicaja.FlatAppearance.BorderSize = 0;
            this.cb_multicaja.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.cb_multicaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cb_multicaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.cb_multicaja.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_multicaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_multicaja.Location = new System.Drawing.Point(12, 40);
            this.cb_multicaja.Name = "cb_multicaja";
            this.cb_multicaja.Size = new System.Drawing.Size(167, 29);
            this.cb_multicaja.TabIndex = 94;
            this.cb_multicaja.Text = "Sistema multicaja";
            this.tt_general.SetToolTip(this.cb_multicaja, "Podra manejar mas de una caja la cual se le pedira al abrir la caja diaria");
            this.cb_multicaja.UseVisualStyleBackColor = false;
            // 
            // cb_multiusuario
            // 
            this.cb_multiusuario.AutoSize = true;
            this.cb_multiusuario.BackColor = System.Drawing.Color.Transparent;
            this.cb_multiusuario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.cb_multiusuario.FlatAppearance.BorderSize = 0;
            this.cb_multiusuario.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.cb_multiusuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cb_multiusuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.cb_multiusuario.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_multiusuario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_multiusuario.Location = new System.Drawing.Point(12, 81);
            this.cb_multiusuario.Name = "cb_multiusuario";
            this.cb_multiusuario.Size = new System.Drawing.Size(194, 29);
            this.cb_multiusuario.TabIndex = 93;
            this.cb_multiusuario.Text = "Sistema multiusuario";
            this.tt_general.SetToolTip(this.cb_multiusuario, "Podra manejar usuarios y permisos con restricciones dentro del sistema para mayor" +
        " control del mismo ");
            this.cb_multiusuario.UseVisualStyleBackColor = false;
            // 
            // cb_pedirpassword
            // 
            this.cb_pedirpassword.AutoSize = true;
            this.cb_pedirpassword.BackColor = System.Drawing.Color.Transparent;
            this.cb_pedirpassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.cb_pedirpassword.FlatAppearance.BorderSize = 0;
            this.cb_pedirpassword.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.cb_pedirpassword.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cb_pedirpassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.cb_pedirpassword.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_pedirpassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_pedirpassword.Location = new System.Drawing.Point(12, 122);
            this.cb_pedirpassword.Name = "cb_pedirpassword";
            this.cb_pedirpassword.Size = new System.Drawing.Size(282, 29);
            this.cb_pedirpassword.TabIndex = 92;
            this.cb_pedirpassword.Text = "Pedir password al iniciar usuario";
            this.tt_general.SetToolTip(this.cb_pedirpassword, "Confirmacion para tener confidencialidad en el sistema");
            this.cb_pedirpassword.UseVisualStyleBackColor = false;
            // 
            // cb_Comisiones
            // 
            this.cb_Comisiones.AutoSize = true;
            this.cb_Comisiones.BackColor = System.Drawing.Color.Transparent;
            this.cb_Comisiones.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_Comisiones.Location = new System.Drawing.Point(6, 35);
            this.cb_Comisiones.Name = "cb_Comisiones";
            this.cb_Comisiones.Size = new System.Drawing.Size(190, 29);
            this.cb_Comisiones.TabIndex = 88;
            this.cb_Comisiones.Text = "Habilitar comisiones";
            this.tt_general.SetToolTip(this.cb_Comisiones, "Podra manejar usuarios y permisos con restricciones dentro del sistema para mayor" +
        " control del mismo ");
            this.cb_Comisiones.UseVisualStyleBackColor = false;
            this.cb_Comisiones.CheckedChanged += new System.EventHandler(this.cb_Comisiones_CheckedChanged);
            // 
            // rb_habilitarImpresora
            // 
            this.rb_habilitarImpresora.AutoSize = true;
            this.rb_habilitarImpresora.BackColor = System.Drawing.Color.Transparent;
            this.rb_habilitarImpresora.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_habilitarImpresora.Location = new System.Drawing.Point(29, 54);
            this.rb_habilitarImpresora.Name = "rb_habilitarImpresora";
            this.rb_habilitarImpresora.Size = new System.Drawing.Size(96, 29);
            this.rb_habilitarImpresora.TabIndex = 59;
            this.rb_habilitarImpresora.Text = "Habilitar";
            this.tt_general.SetToolTip(this.rb_habilitarImpresora, "El mismo vendedor va a ser para toda la caja diaria");
            this.rb_habilitarImpresora.UseVisualStyleBackColor = false;
            this.rb_habilitarImpresora.CheckedChanged += new System.EventHandler(this.rb_habilitarImpresora_CheckedChanged);
            // 
            // rb_desabilitarImpresora
            // 
            this.rb_desabilitarImpresora.AutoSize = true;
            this.rb_desabilitarImpresora.BackColor = System.Drawing.Color.Transparent;
            this.rb_desabilitarImpresora.Checked = true;
            this.rb_desabilitarImpresora.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_desabilitarImpresora.Location = new System.Drawing.Point(29, 99);
            this.rb_desabilitarImpresora.Name = "rb_desabilitarImpresora";
            this.rb_desabilitarImpresora.Size = new System.Drawing.Size(113, 29);
            this.rb_desabilitarImpresora.TabIndex = 60;
            this.rb_desabilitarImpresora.TabStop = true;
            this.rb_desabilitarImpresora.Text = "Desabilitar";
            this.tt_general.SetToolTip(this.rb_desabilitarImpresora, "El mismo vendedor va a ser para toda la caja diaria");
            this.rb_desabilitarImpresora.UseVisualStyleBackColor = false;
            // 
            // rb_Epson
            // 
            this.rb_Epson.AutoSize = true;
            this.rb_Epson.BackColor = System.Drawing.Color.Transparent;
            this.rb_Epson.Checked = true;
            this.rb_Epson.Enabled = false;
            this.rb_Epson.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Epson.Location = new System.Drawing.Point(12, 79);
            this.rb_Epson.Name = "rb_Epson";
            this.rb_Epson.Size = new System.Drawing.Size(156, 29);
            this.rb_Epson.TabIndex = 102;
            this.rb_Epson.TabStop = true;
            this.rb_Epson.Text = "Epson Samsung";
            this.tt_general.SetToolTip(this.rb_Epson, "El mismo vendedor va a ser para toda la caja diaria");
            this.rb_Epson.UseVisualStyleBackColor = false;
            // 
            // rb_Hasar
            // 
            this.rb_Hasar.AutoSize = true;
            this.rb_Hasar.BackColor = System.Drawing.Color.Transparent;
            this.rb_Hasar.Enabled = false;
            this.rb_Hasar.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Hasar.Location = new System.Drawing.Point(12, 149);
            this.rb_Hasar.Name = "rb_Hasar";
            this.rb_Hasar.Size = new System.Drawing.Size(74, 29);
            this.rb_Hasar.TabIndex = 103;
            this.rb_Hasar.Text = "Hasar";
            this.tt_general.SetToolTip(this.rb_Hasar, "El mismo vendedor va a ser para toda la caja diaria");
            this.rb_Hasar.UseVisualStyleBackColor = false;
            // 
            // rb_Xcompras
            // 
            this.rb_Xcompras.AutoSize = true;
            this.rb_Xcompras.BackColor = System.Drawing.Color.Transparent;
            this.rb_Xcompras.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Xcompras.Location = new System.Drawing.Point(7, 43);
            this.rb_Xcompras.Name = "rb_Xcompras";
            this.rb_Xcompras.Size = new System.Drawing.Size(346, 29);
            this.rb_Xcompras.TabIndex = 55;
            this.rb_Xcompras.Text = "Por medio de compras (Recomendado)";
            this.rb_Xcompras.UseVisualStyleBackColor = false;
            // 
            // rb_formulario
            // 
            this.rb_formulario.AutoSize = true;
            this.rb_formulario.BackColor = System.Drawing.Color.Transparent;
            this.rb_formulario.Checked = true;
            this.rb_formulario.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_formulario.Location = new System.Drawing.Point(7, 77);
            this.rb_formulario.Name = "rb_formulario";
            this.rb_formulario.Size = new System.Drawing.Size(308, 29);
            this.rb_formulario.TabIndex = 56;
            this.rb_formulario.TabStop = true;
            this.rb_formulario.Text = "Por medio de formulario existencia";
            this.rb_formulario.UseVisualStyleBackColor = false;
            this.rb_formulario.CheckedChanged += new System.EventHandler(this.rb_formulario_CheckedChanged);
            // 
            // rb_AdiFor
            // 
            this.rb_AdiFor.AutoSize = true;
            this.rb_AdiFor.BackColor = System.Drawing.Color.Transparent;
            this.rb_AdiFor.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_AdiFor.Location = new System.Drawing.Point(6, 128);
            this.rb_AdiFor.Name = "rb_AdiFor";
            this.rb_AdiFor.Size = new System.Drawing.Size(363, 29);
            this.rb_AdiFor.TabIndex = 58;
            this.rb_AdiFor.Text = "Primero adicional y luego forma de pago ";
            this.rb_AdiFor.UseVisualStyleBackColor = false;
            // 
            // rb_ForAdi
            // 
            this.rb_ForAdi.AutoSize = true;
            this.rb_ForAdi.BackColor = System.Drawing.Color.Transparent;
            this.rb_ForAdi.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_ForAdi.Location = new System.Drawing.Point(6, 97);
            this.rb_ForAdi.Name = "rb_ForAdi";
            this.rb_ForAdi.Size = new System.Drawing.Size(358, 29);
            this.rb_ForAdi.TabIndex = 57;
            this.rb_ForAdi.Text = "Primero forma de pago y luego adicional";
            this.rb_ForAdi.UseVisualStyleBackColor = false;
            // 
            // rb_RecDesc
            // 
            this.rb_RecDesc.AutoSize = true;
            this.rb_RecDesc.BackColor = System.Drawing.Color.Transparent;
            this.rb_RecDesc.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_RecDesc.Location = new System.Drawing.Point(6, 37);
            this.rb_RecDesc.Name = "rb_RecDesc";
            this.rb_RecDesc.Size = new System.Drawing.Size(331, 29);
            this.rb_RecDesc.TabIndex = 55;
            this.rb_RecDesc.Text = "Primero recargo y luego el descuento";
            this.rb_RecDesc.UseVisualStyleBackColor = false;
            // 
            // rb_DescRec
            // 
            this.rb_DescRec.AutoSize = true;
            this.rb_DescRec.BackColor = System.Drawing.Color.Transparent;
            this.rb_DescRec.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_DescRec.Location = new System.Drawing.Point(6, 66);
            this.rb_DescRec.Name = "rb_DescRec";
            this.rb_DescRec.Size = new System.Drawing.Size(317, 29);
            this.rb_DescRec.TabIndex = 56;
            this.rb_DescRec.Text = "Primero descuento y  luego recargo";
            this.rb_DescRec.UseVisualStyleBackColor = false;
            // 
            // txt_puerto
            // 
            this.txt_puerto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_puerto.Enabled = false;
            this.txt_puerto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_puerto.Location = new System.Drawing.Point(139, 52);
            this.txt_puerto.Name = "txt_puerto";
            this.txt_puerto.Size = new System.Drawing.Size(76, 26);
            this.txt_puerto.TabIndex = 96;
            this.txt_puerto.Text = "3";
            this.txt_puerto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_puerto.TextDefault = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.Location = new System.Drawing.Point(7, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 93;
            this.label2.Text = "Modelo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.Location = new System.Drawing.Point(7, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Num Puerto :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cb_pedirpassword);
            this.panel2.Controls.Add(this.cb_multiusuario);
            this.panel2.Controls.Add(this.cb_multicaja);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(7, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(364, 160);
            this.panel2.TabIndex = 98;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 32);
            this.label7.TabIndex = 57;
            this.label7.Text = "General";
            // 
            // p_configimpr
            // 
            this.p_configimpr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_configimpr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_configimpr.Controls.Add(this.txt_nomLogico);
            this.p_configimpr.Controls.Add(this.label14);
            this.p_configimpr.Controls.Add(this.cb_ModelHasar);
            this.p_configimpr.Controls.Add(this.cb_ModelEpson);
            this.p_configimpr.Controls.Add(this.label12);
            this.p_configimpr.Controls.Add(this.rb_Hasar);
            this.p_configimpr.Controls.Add(this.rb_Epson);
            this.p_configimpr.Controls.Add(this.label6);
            this.p_configimpr.Controls.Add(this.label1);
            this.p_configimpr.Controls.Add(this.txt_puerto);
            this.p_configimpr.Controls.Add(this.label2);
            this.p_configimpr.Enabled = false;
            this.p_configimpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_configimpr.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_configimpr.Location = new System.Drawing.Point(668, 178);
            this.p_configimpr.Margin = new System.Windows.Forms.Padding(4);
            this.p_configimpr.Name = "p_configimpr";
            this.p_configimpr.Size = new System.Drawing.Size(232, 266);
            this.p_configimpr.TabIndex = 99;
            // 
            // txt_nomLogico
            // 
            this.txt_nomLogico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nomLogico.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_nomLogico.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nomLogico.Location = new System.Drawing.Point(119, 228);
            this.txt_nomLogico.MaxLength = 60;
            this.txt_nomLogico.Name = "txt_nomLogico";
            this.txt_nomLogico.Size = new System.Drawing.Size(99, 31);
            this.txt_nomLogico.TabIndex = 108;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label14.Location = new System.Drawing.Point(7, 230);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 25);
            this.label14.TabIndex = 107;
            this.label14.Text = "Nom lógico:";
            // 
            // cb_ModelHasar
            // 
            this.cb_ModelHasar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_ModelHasar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ModelHasar.Enabled = false;
            this.cb_ModelHasar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ModelHasar.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_ModelHasar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_ModelHasar.FormattingEnabled = true;
            this.cb_ModelHasar.Items.AddRange(new object[] {
            "P-615F",
            "P-PR4F",
            "P-951F",
            "P-PR5F 1.00",
            "P-PR5F 2.01"});
            this.cb_ModelHasar.Location = new System.Drawing.Point(97, 180);
            this.cb_ModelHasar.Name = "cb_ModelHasar";
            this.cb_ModelHasar.Size = new System.Drawing.Size(121, 31);
            this.cb_ModelHasar.TabIndex = 106;
            // 
            // cb_ModelEpson
            // 
            this.cb_ModelEpson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_ModelEpson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ModelEpson.Enabled = false;
            this.cb_ModelEpson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_ModelEpson.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_ModelEpson.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_ModelEpson.FormattingEnabled = true;
            this.cb_ModelEpson.Items.AddRange(new object[] {
            "TM-2000AF",
            "TM-2000AF+",
            "TM-300AF",
            "TM-T285F",
            "TM-U950F",
            "TM-U2002AF+",
            "SRP-270",
            "SRP-250",
            "TM-U220AF"});
            this.cb_ModelEpson.Location = new System.Drawing.Point(97, 114);
            this.cb_ModelEpson.Name = "cb_ModelEpson";
            this.cb_ModelEpson.Size = new System.Drawing.Size(121, 31);
            this.cb_ModelEpson.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label12.Location = new System.Drawing.Point(7, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 25);
            this.label12.TabIndex = 104;
            this.label12.Text = "Modelo :";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 32);
            this.label6.TabIndex = 101;
            this.label6.Text = "Config Com/impr";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.rb_Xcompras);
            this.panel4.Controls.Add(this.rb_formulario);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(7, 335);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(363, 109);
            this.panel4.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 32);
            this.label5.TabIndex = 57;
            this.label5.Text = "Modificaciones de stock";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.rb_AdiFor);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.rb_ForAdi);
            this.panel5.Controls.Add(this.rb_RecDesc);
            this.panel5.Controls.Add(this.rb_DescRec);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(378, 10);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(522, 160);
            this.panel5.TabIndex = 99;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(522, 32);
            this.label8.TabIndex = 57;
            this.label8.Text = "Orden de descuentos y recargos adicionales";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 32);
            this.label9.TabIndex = 96;
            this.label9.Text = "Vendedores";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label3.Location = new System.Drawing.Point(3, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 25);
            this.label3.TabIndex = 89;
            this.label3.Text = "Porcentaje de comision:";
            // 
            // txt_porcentaje
            // 
            this.txt_porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_porcentaje.CantDecimales = 8;
            this.txt_porcentaje.Enabled = false;
            this.txt_porcentaje.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_porcentaje.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_porcentaje.Location = new System.Drawing.Point(211, 72);
            this.txt_porcentaje.Name = "txt_porcentaje";
            this.txt_porcentaje.Size = new System.Drawing.Size(64, 31);
            this.txt_porcentaje.TabIndex = 90;
            this.txt_porcentaje.Text = "0";
            this.txt_porcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_porcentaje.TextDefault = "0";
            // 
            // pn_comisiones
            // 
            this.pn_comisiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_comisiones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_comisiones.Controls.Add(this.txt_porcentaje);
            this.pn_comisiones.Controls.Add(this.label10);
            this.pn_comisiones.Controls.Add(this.label3);
            this.pn_comisiones.Controls.Add(this.cb_Comisiones);
            this.pn_comisiones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_comisiones.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_comisiones.Location = new System.Drawing.Point(378, 335);
            this.pn_comisiones.Margin = new System.Windows.Forms.Padding(4);
            this.pn_comisiones.Name = "pn_comisiones";
            this.pn_comisiones.Size = new System.Drawing.Size(282, 109);
            this.pn_comisiones.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label10.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(282, 32);
            this.label10.TabIndex = 57;
            this.label10.Text = "Comisiones";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.txt_iva);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(492, 178);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 149);
            this.panel3.TabIndex = 98;
            // 
            // txt_iva
            // 
            this.txt_iva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_iva.CantDecimales = 8;
            this.txt_iva.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_iva.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_iva.Location = new System.Drawing.Point(94, 73);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(64, 31);
            this.txt_iva.TabIndex = 92;
            this.txt_iva.Text = "0";
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_iva.TextDefault = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label13.Location = new System.Drawing.Point(9, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 25);
            this.label13.TabIndex = 91;
            this.label13.Text = "Defecto:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 32);
            this.label4.TabIndex = 58;
            this.label4.Text = "I.V.A";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(178, 32);
            this.label11.TabIndex = 61;
            this.label11.Text = "Comandera";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.label15.Location = new System.Drawing.Point(17, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(242, 25);
            this.label15.TabIndex = 92;
            this.label15.Text = "Easysales Market Versión 3.3 ";
            // 
            // Frm_ABM_configuraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(908, 493);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pn_comisiones);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.p_configimpr);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_configuraciones";
            this.Text = "Configuración del sistema Versión 3.3";
            this.Load += new System.EventHandler(this.Frm_ABM_configuraciones_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_configuraciones_Shown);
            this.Controls.SetChildIndex(this.p_arriba, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.p_configimpr, 0);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel5, 0);
            this.Controls.SetChildIndex(this.pbtn, 0);
            this.Controls.SetChildIndex(this.pn_comisiones, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.gb_abm.PerformLayout();
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnABM.PerformLayout();
            this.pn_btnSalir.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.p_configimpr.ResumeLayout(false);
            this.p_configimpr.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.pn_comisiones.ResumeLayout(false);
            this.pn_comisiones.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tt_general;
        private System.Windows.Forms.RadioButton rb_Xcompras;
        private System.Windows.Forms.RadioButton rb_formulario;
        private System.Windows.Forms.RadioButton rb_AdiFor;
        private System.Windows.Forms.RadioButton rb_ForAdi;
        private System.Windows.Forms.RadioButton rb_RecDesc;
        private System.Windows.Forms.RadioButton rb_DescRec;
        private CONTROLES.TextBox_Int txt_puerto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb_Xventa;
        private System.Windows.Forms.RadioButton rb_Xcaja_diaria;
        private System.Windows.Forms.CheckBox cb_multicaja;
        private System.Windows.Forms.CheckBox cb_multiusuario;
        private System.Windows.Forms.CheckBox cb_pedirpassword;
        protected System.Windows.Forms.Panel panel2;
        protected System.Windows.Forms.Panel panel4;
        protected System.Windows.Forms.Panel p_configimpr;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cb_Comisiones;
        private System.Windows.Forms.Label label3;
        private CONTROLES.TextBox_Decimal txt_porcentaje;
        protected System.Windows.Forms.Panel pn_comisiones;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rb_desabilitarImpresora;
        private System.Windows.Forms.RadioButton rb_habilitarImpresora;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rb_Hasar;
        private System.Windows.Forms.RadioButton rb_Epson;
        private System.Windows.Forms.ComboBox cb_ModelHasar;
        private System.Windows.Forms.ComboBox cb_ModelEpson;
        protected System.Windows.Forms.Panel panel3;
        private CONTROLES.TextBox_Decimal txt_iva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_nomLogico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
    }
}
