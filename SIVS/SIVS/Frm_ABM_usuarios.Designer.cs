namespace SIVS
{
    partial class Frm_ABM_usuarios
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_usuarios));
            this.bs_usuarios = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_localidades = new System.Windows.Forms.ComboBox();
            this.bs_permisos = new System.Windows.Forms.BindingSource(this.components);
            this.bs_localidades = new System.Windows.Forms.BindingSource(this.components);
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_permisos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_permisos = new System.Windows.Forms.Label();
            this.p_contraseña = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_pass = new CONTROLES.TextBox_Int();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_VerBajas = new CONTROLES.ButtonImages();
            this.btn_Reporte = new CONTROLES.ButtonImages();
            this.ToolTip_usuarios = new System.Windows.Forms.ToolTip(this.components);
            this.dgrid_usuarios = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_usuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_permisos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_localidades)).BeginInit();
            this.p_contraseña.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = null;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(0, 45);
            this.btn_Salir.TabIndex = 4;
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = null;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(222, 45);
            this.btn_Cancelar.TabIndex = 14;
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = null;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(106, 45);
            this.btn_Guardar.TabIndex = 13;
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = null;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(245, 7);
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = null;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(129, 7);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = null;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(13, 7);
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 412);
            this.pbtn.Size = new System.Drawing.Size(1009, 85);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.p_contraseña);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.txt_nombre);
            this.pn_abm.Controls.Add(this.txt_direccion);
            this.pn_abm.Controls.Add(this.lbl_localidad);
            this.pn_abm.Controls.Add(this.txt_tel);
            this.pn_abm.Controls.Add(this.label4);
            this.pn_abm.Controls.Add(this.txt_mail);
            this.pn_abm.Controls.Add(this.label9);
            this.pn_abm.Controls.Add(this.label5);
            this.pn_abm.Controls.Add(this.label6);
            this.pn_abm.Controls.Add(this.cb_localidades);
            this.pn_abm.Controls.Add(this.txt_cel);
            this.pn_abm.Size = new System.Drawing.Size(347, 396);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_usuarios);
            this.gb_abm.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.gb_abm.Size = new System.Drawing.Size(638, 396);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(1009, 412);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(646, 8);
            this.p_derecho.Size = new System.Drawing.Size(355, 396);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(670, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(339, 85);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.btn_Reporte);
            this.pn_btnABM.Controls.Add(this.btn_VerBajas);
            this.pn_btnABM.Size = new System.Drawing.Size(670, 85);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_VerBajas, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.pn_btnSalir, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Reporte, 0);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(551, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 85);
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.AutoSize = true;
            this.lbl_localidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_localidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_localidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_localidad.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_localidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_localidad.Location = new System.Drawing.Point(6, 192);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(90, 27);
            this.lbl_localidad.TabIndex = 22;
            this.lbl_localidad.Text = "Localidad:";
            this.ToolTip_usuarios.SetToolTip(this.lbl_localidad, "Clic para agregar una localidad");
            this.lbl_localidad.Click += new System.EventHandler(this.lbl_localidad_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(170, 41);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(163, 31);
            this.txt_nombre.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.Location = new System.Drawing.Point(8, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Email :";
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mail.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_mail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mail.Location = new System.Drawing.Point(71, 226);
            this.txt_mail.MaxLength = 40;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(262, 31);
            this.txt_mail.TabIndex = 10;
            // 
            // txt_cel
            // 
            this.txt_cel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cel.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_cel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cel.Location = new System.Drawing.Point(101, 115);
            this.txt_cel.MaxLength = 20;
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(232, 31);
            this.txt_cel.TabIndex = 7;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tel.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_tel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tel.Location = new System.Drawing.Point(170, 78);
            this.txt_tel.MaxLength = 20;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(163, 31);
            this.txt_tel.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.Location = new System.Drawing.Point(8, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 32;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label6.Location = new System.Drawing.Point(8, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Teléfono particular:";
            // 
            // cb_localidades
            // 
            this.cb_localidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_localidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_localidades.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_localidades.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_localidades.FormattingEnabled = true;
            this.cb_localidades.Location = new System.Drawing.Point(101, 189);
            this.cb_localidades.Name = "cb_localidades";
            this.cb_localidades.Size = new System.Drawing.Size(232, 31);
            this.cb_localidades.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_direccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.Location = new System.Drawing.Point(101, 152);
            this.txt_direccion.MaxLength = 100;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(232, 31);
            this.txt_direccion.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label9.Location = new System.Drawing.Point(8, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 38;
            this.label9.Text = "Dirección:";
            // 
            // cb_permisos
            // 
            this.cb_permisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_permisos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_permisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_permisos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_permisos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_permisos.FormattingEnabled = true;
            this.cb_permisos.Location = new System.Drawing.Point(98, 74);
            this.cb_permisos.Name = "cb_permisos";
            this.cb_permisos.Size = new System.Drawing.Size(235, 31);
            this.cb_permisos.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 25);
            this.label8.TabIndex = 42;
            this.label8.Text = "Contraseña: ( Solo 4 números)";
            // 
            // lbl_permisos
            // 
            this.lbl_permisos.AutoSize = true;
            this.lbl_permisos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_permisos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_permisos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_permisos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_permisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_permisos.Location = new System.Drawing.Point(8, 77);
            this.lbl_permisos.Name = "lbl_permisos";
            this.lbl_permisos.Size = new System.Drawing.Size(86, 27);
            this.lbl_permisos.TabIndex = 41;
            this.lbl_permisos.Text = "Permisos:";
            this.ToolTip_usuarios.SetToolTip(this.lbl_permisos, "Clic para agregar un permiso");
            this.lbl_permisos.Click += new System.EventHandler(this.lbl_permisos_Click);
            // 
            // p_contraseña
            // 
            this.p_contraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_contraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_contraseña.Controls.Add(this.label7);
            this.p_contraseña.Controls.Add(this.txt_pass);
            this.p_contraseña.Controls.Add(this.cb_permisos);
            this.p_contraseña.Controls.Add(this.label8);
            this.p_contraseña.Controls.Add(this.lbl_permisos);
            this.p_contraseña.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_contraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_contraseña.Location = new System.Drawing.Point(0, 277);
            this.p_contraseña.Name = "p_contraseña";
            this.p_contraseña.Size = new System.Drawing.Size(347, 119);
            this.p_contraseña.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(347, 32);
            this.label7.TabIndex = 98;
            this.label7.Text = "Datos de Usuario";
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_pass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_pass.Location = new System.Drawing.Point(253, 42);
            this.txt_pass.MaxLength = 4;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(80, 26);
            this.txt_pass.TabIndex = 11;
            this.txt_pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_pass.TextDefault = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Apellido y nombre:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 32);
            this.label1.TabIndex = 99;
            this.label1.Text = "Datos de Personales";
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
            this.btn_VerBajas.Location = new System.Drawing.Point(13, 45);
            this.btn_VerBajas.Name = "btn_VerBajas";
            this.btn_VerBajas.Size = new System.Drawing.Size(110, 32);
            this.btn_VerBajas.TabIndex = 3;
            this.btn_VerBajas.Tag = "";
            this.btn_VerBajas.Text = "     Ver bajas";
            this.btn_VerBajas.UseVisualStyleBackColor = false;
            this.btn_VerBajas.Click += new System.EventHandler(this.btn_VerBajas_Click);
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
            this.btn_Reporte.Location = new System.Drawing.Point(128, 45);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(110, 32);
            this.btn_Reporte.TabIndex = 79;
            this.btn_Reporte.Text = "   Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // dgrid_usuarios
            // 
            this.dgrid_usuarios.AllowUserToAddRows = false;
            this.dgrid_usuarios.AllowUserToDeleteRows = false;
            this.dgrid_usuarios.AllowUserToResizeRows = false;
            this.dgrid_usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_usuarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_usuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_usuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_usuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_usuarios.Location = new System.Drawing.Point(0, 0);
            this.dgrid_usuarios.MultiSelect = false;
            this.dgrid_usuarios.Name = "dgrid_usuarios";
            this.dgrid_usuarios.ReadOnly = true;
            this.dgrid_usuarios.RowHeadersVisible = false;
            this.dgrid_usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_usuarios.Size = new System.Drawing.Size(638, 396);
            this.dgrid_usuarios.TabIndex = 64;
            this.dgrid_usuarios.SelectionChanged += new System.EventHandler(this.dgrid_usuarios_SelectionChanged);
            this.dgrid_usuarios.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_usuarios_MouseDoubleClick);
            // 
            // Frm_ABM_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1009, 497);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_usuarios";
            this.Text = "Administrar usuarios";
            this.Activated += new System.EventHandler(this.Frm_ABM_usuarios_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_usuarios_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_usuarios_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_usuarios_KeyDown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_usuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_permisos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_localidades)).EndInit();
            this.p_contraseña.ResumeLayout(false);
            this.p_contraseña.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_usuarios;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_localidades;
        private System.Windows.Forms.BindingSource bs_permisos;
        private System.Windows.Forms.BindingSource bs_localidades;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_permisos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_permisos;
        protected System.Windows.Forms.Panel p_contraseña;
        private System.Windows.Forms.Label label2;
        private CONTROLES.TextBox_Int txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private CONTROLES.ButtonImages btn_VerBajas;
        private CONTROLES.ButtonImages btn_Reporte;
        private System.Windows.Forms.ToolTip ToolTip_usuarios;
        private System.Windows.Forms.DataGridView dgrid_usuarios;
    }
}
