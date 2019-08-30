namespace SIVS
{
    partial class Frm_ABM_clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_clientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bs_clientes = new System.Windows.Forms.BindingSource(this.components);
            this.bs_localidades = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.cb_localidades = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cel = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_localidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.btn_VerBajas = new CONTROLES.ButtonImages();
            this.btn_GuardarMas = new CONTROLES.ButtonImages();
            this.btn_Reporte = new CONTROLES.ButtonImages();
            this.dgrid_clientes = new System.Windows.Forms.DataGridView();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_clientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_localidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.Location = new System.Drawing.Point(1, 45);
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(307, 45);
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(192, 46);
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Location = new System.Drawing.Point(245, 8);
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Location = new System.Drawing.Point(129, 8);
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Location = new System.Drawing.Point(13, 8);
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 393);
            this.pbtn.Size = new System.Drawing.Size(984, 85);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.label9);
            this.pn_abm.Controls.Add(this.cb_localidades);
            this.pn_abm.Controls.Add(this.txt_direccion);
            this.pn_abm.Controls.Add(this.txt_nombre);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.label5);
            this.pn_abm.Controls.Add(this.lbl_localidad);
            this.pn_abm.Controls.Add(this.label6);
            this.pn_abm.Controls.Add(this.label4);
            this.pn_abm.Controls.Add(this.txt_cel);
            this.pn_abm.Controls.Add(this.txt_mail);
            this.pn_abm.Controls.Add(this.txt_tel);
            this.pn_abm.Size = new System.Drawing.Size(419, 377);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_clientes);
            this.gb_abm.Controls.Add(this.label2);
            this.gb_abm.Controls.Add(this.txt_busqueda);
            this.gb_abm.Size = new System.Drawing.Size(541, 377);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(984, 393);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(549, 8);
            this.p_derecho.Size = new System.Drawing.Size(427, 377);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Controls.Add(this.btn_GuardarMas);
            this.pn_btnDerechos.Location = new System.Drawing.Point(557, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(427, 85);
            this.pn_btnDerechos.Controls.SetChildIndex(this.btn_Cancelar, 0);
            this.pn_btnDerechos.Controls.SetChildIndex(this.btn_GuardarMas, 0);
            this.pn_btnDerechos.Controls.SetChildIndex(this.btn_Guardar, 0);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.btn_Reporte);
            this.pn_btnABM.Controls.Add(this.btn_VerBajas);
            this.pn_btnABM.Size = new System.Drawing.Size(557, 85);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Eliminar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Modificar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Agregar, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_VerBajas, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.pn_btnSalir, 0);
            this.pn_btnABM.Controls.SetChildIndex(this.btn_Reporte, 0);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(438, 0);
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 85);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label9.Location = new System.Drawing.Point(12, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 28);
            this.label9.TabIndex = 68;
            this.label9.Text = "Direccion:";
            // 
            // txt_direccion
            // 
            this.txt_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_direccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_direccion.Location = new System.Drawing.Point(117, 192);
            this.txt_direccion.MaxLength = 100;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(290, 29);
            this.txt_direccion.TabIndex = 67;
            // 
            // cb_localidades
            // 
            this.cb_localidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_localidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_localidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_localidades.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_localidades.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_localidades.FormattingEnabled = true;
            this.cb_localidades.Location = new System.Drawing.Point(117, 156);
            this.cb_localidades.Name = "cb_localidades";
            this.cb_localidades.Size = new System.Drawing.Size(290, 31);
            this.cb_localidades.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 28);
            this.label5.TabIndex = 65;
            this.label5.Text = "Celular:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label6.Location = new System.Drawing.Point(12, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 64;
            this.label6.Text = "Telefono:";
            // 
            // txt_cel
            // 
            this.txt_cel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_cel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cel.Location = new System.Drawing.Point(117, 122);
            this.txt_cel.MaxLength = 20;
            this.txt_cel.Name = "txt_cel";
            this.txt_cel.Size = new System.Drawing.Size(290, 29);
            this.txt_cel.TabIndex = 63;
            // 
            // txt_tel
            // 
            this.txt_tel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tel.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_tel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tel.Location = new System.Drawing.Point(117, 87);
            this.txt_tel.MaxLength = 20;
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(290, 29);
            this.txt_tel.TabIndex = 62;
            // 
            // txt_mail
            // 
            this.txt_mail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_mail.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_mail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_mail.Location = new System.Drawing.Point(117, 52);
            this.txt_mail.MaxLength = 40;
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(290, 29);
            this.txt_mail.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.Location = new System.Drawing.Point(12, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 28);
            this.label4.TabIndex = 60;
            this.label4.Text = "Mail:";
            // 
            // lbl_localidad
            // 
            this.lbl_localidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_localidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_localidad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_localidad.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_localidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_localidad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_localidad.Location = new System.Drawing.Point(10, 158);
            this.lbl_localidad.Name = "lbl_localidad";
            this.lbl_localidad.Size = new System.Drawing.Size(99, 29);
            this.lbl_localidad.TabIndex = 58;
            this.lbl_localidad.Text = "Localidad:";
            this.lbl_localidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_localidad.Click += new System.EventHandler(this.lbl_localidad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 28);
            this.label1.TabIndex = 57;
            this.label1.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(117, 17);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(290, 29);
            this.txt_nombre.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(9, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 28);
            this.label2.TabIndex = 58;
            this.label2.Text = "Nombre y/o apellido :";
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_busqueda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_busqueda.Location = new System.Drawing.Point(207, 341);
            this.txt_busqueda.MaxLength = 100;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(328, 29);
            this.txt_busqueda.TabIndex = 57;
            this.txt_busqueda.TextChanged += new System.EventHandler(this.txt_busqueda_TextChanged);
            // 
            // btn_VerBajas
            // 
            this.btn_VerBajas.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_VerBajas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_VerBajas.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_VerBajas.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
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
            this.btn_VerBajas.Location = new System.Drawing.Point(12, 45);
            this.btn_VerBajas.Name = "btn_VerBajas";
            this.btn_VerBajas.Size = new System.Drawing.Size(227, 32);
            this.btn_VerBajas.TabIndex = 76;
            this.btn_VerBajas.Tag = "";
            this.btn_VerBajas.Text = "     Ver bajas";
            this.btn_VerBajas.UseVisualStyleBackColor = false;
            this.btn_VerBajas.Click += new System.EventHandler(this.btn_VerBajas_Click);
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
            this.btn_GuardarMas.Location = new System.Drawing.Point(192, 8);
            this.btn_GuardarMas.Name = "btn_GuardarMas";
            this.btn_GuardarMas.Size = new System.Drawing.Size(227, 32);
            this.btn_GuardarMas.TabIndex = 77;
            this.btn_GuardarMas.Text = "     Guardar y agregar otro";
            this.btn_GuardarMas.UseVisualStyleBackColor = false;
            this.btn_GuardarMas.Click += new System.EventHandler(this.btn_GuardarMas_Click);
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
            this.btn_Reporte.Location = new System.Drawing.Point(245, 45);
            this.btn_Reporte.Name = "btn_Reporte";
            this.btn_Reporte.Size = new System.Drawing.Size(110, 32);
            this.btn_Reporte.TabIndex = 79;
            this.btn_Reporte.Text = "   Reporte";
            this.btn_Reporte.UseVisualStyleBackColor = false;
            this.btn_Reporte.Click += new System.EventHandler(this.btn_Reporte_Click);
            // 
            // dgrid_clientes
            // 
            this.dgrid_clientes.AllowUserToAddRows = false;
            this.dgrid_clientes.AllowUserToDeleteRows = false;
            this.dgrid_clientes.AllowUserToResizeRows = false;
            this.dgrid_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrid_clientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_clientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_clientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_clientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_clientes.Location = new System.Drawing.Point(0, 0);
            this.dgrid_clientes.MultiSelect = false;
            this.dgrid_clientes.Name = "dgrid_clientes";
            this.dgrid_clientes.ReadOnly = true;
            this.dgrid_clientes.RowHeadersVisible = false;
            this.dgrid_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_clientes.Size = new System.Drawing.Size(541, 327);
            this.dgrid_clientes.TabIndex = 63;
            this.dgrid_clientes.SelectionChanged += new System.EventHandler(this.dgrid_clientes_SelectionChanged);
            this.dgrid_clientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_clientes_MouseDoubleClick);
            this.dgrid_clientes.Resize += new System.EventHandler(this.dgrid_clientes_Resize);
            // 
            // Frm_ABM_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(984, 478);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(902, 436);
            this.Name = "Frm_ABM_clientes";
            this.Text = "Administrar clientes";
            this.Activated += new System.EventHandler(this.Frm_ABM_clientes_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_clientes_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_clientes_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_clientes_KeyDown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.gb_abm.PerformLayout();
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_clientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_localidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_clientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_clientes;
        private System.Windows.Forms.BindingSource bs_localidades;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.ComboBox cb_localidades;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cel;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_localidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_busqueda;
        private CONTROLES.ButtonImages btn_VerBajas;
        protected CONTROLES.ButtonImages btn_GuardarMas;
        private CONTROLES.ButtonImages btn_Reporte;
        private System.Windows.Forms.DataGridView dgrid_clientes;
    }
}
