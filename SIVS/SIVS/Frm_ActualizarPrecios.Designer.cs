namespace SIVS
{
    partial class Frm_ActualizarPrecios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ActualizarPrecios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_QuitarRubro = new CONTROLES.ButtonImages();
            this.btn_QuitarArticulo = new CONTROLES.ButtonImages();
            this.dgrid_Articulos = new System.Windows.Forms.DataGridView();
            this.btn_Agregar = new CONTROLES.ButtonImages();
            this.cbb_Rubros = new System.Windows.Forms.ComboBox();
            this.dgrid_Rubros = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_totalActualizado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Diferencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_signo = new System.Windows.Forms.Label();
            this.rb_Porcentaje = new System.Windows.Forms.RadioButton();
            this.rb_MontoFijo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_valor = new CONTROLES.TextBox_Decimal();
            this.btn_GenerarVista = new CONTROLES.ButtonImages();
            this.cb_Redondear = new System.Windows.Forms.CheckBox();
            this.pn_tipo2 = new System.Windows.Forms.Panel();
            this.rb_Decremento = new System.Windows.Forms.RadioButton();
            this.rb_Incremento = new System.Windows.Forms.RadioButton();
            this.pn_tipo1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgrid_ArticulosActualizados = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_Actualizar = new CONTROLES.ButtonImages();
            this.btn_Cancelar = new CONTROLES.ButtonImages();
            this.pbtn = new System.Windows.Forms.Panel();
            this.bs_CbbRubros = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Articulos = new System.Windows.Forms.BindingSource(this.components);
            this.bs_DgridRubros = new System.Windows.Forms.BindingSource(this.components);
            this.bs_ArticulosActualizados = new System.Windows.Forms.BindingSource(this.components);
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Rubros)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_tipo2.SuspendLayout();
            this.pn_tipo1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ArticulosActualizados)).BeginInit();
            this.pbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_CbbRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_DgridRubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ArticulosActualizados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_QuitarRubro);
            this.panel4.Controls.Add(this.btn_QuitarArticulo);
            this.panel4.Controls.Add(this.dgrid_Articulos);
            this.panel4.Controls.Add(this.btn_Agregar);
            this.panel4.Controls.Add(this.cbb_Rubros);
            this.panel4.Controls.Add(this.dgrid_Rubros);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(719, 302);
            this.panel4.TabIndex = 126;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(7, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 28);
            this.label3.TabIndex = 159;
            this.label3.Text = "Rubros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 21);
            this.label1.TabIndex = 158;
            this.label1.Text = "Rubros a actualizar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(222, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 21);
            this.label5.TabIndex = 157;
            this.label5.Text = "Artículos a actualizar precio de venta";
            // 
            // btn_QuitarRubro
            // 
            this.btn_QuitarRubro.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_QuitarRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_QuitarRubro.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_QuitarRubro.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_QuitarRubro.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_QuitarRubro.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_QuitarRubro.BackgroundImage = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QuitarRubro.FlatAppearance.BorderSize = 0;
            this.btn_QuitarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuitarRubro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_QuitarRubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_QuitarRubro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuitarRubro.ImageEnableFalse = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarRubro.ImageOnMouseDown = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarRubro.ImageOnMouseEnter = global::SIVS.Properties.Resources.Delete_flip30;
            this.btn_QuitarRubro.ImageOnNothing = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarRubro.Location = new System.Drawing.Point(12, 261);
            this.btn_QuitarRubro.Name = "btn_QuitarRubro";
            this.btn_QuitarRubro.Size = new System.Drawing.Size(208, 32);
            this.btn_QuitarRubro.TabIndex = 151;
            this.btn_QuitarRubro.Text = "     Quitar rubro de la lista";
            this.btn_QuitarRubro.UseVisualStyleBackColor = false;
            this.btn_QuitarRubro.Click += new System.EventHandler(this.btn_QuitarRubro_Click);
            // 
            // btn_QuitarArticulo
            // 
            this.btn_QuitarArticulo.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_QuitarArticulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_QuitarArticulo.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_QuitarArticulo.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_QuitarArticulo.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_QuitarArticulo.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_QuitarArticulo.BackgroundImage = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarArticulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_QuitarArticulo.FlatAppearance.BorderSize = 0;
            this.btn_QuitarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QuitarArticulo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_QuitarArticulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_QuitarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_QuitarArticulo.ImageEnableFalse = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarArticulo.ImageOnMouseDown = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarArticulo.ImageOnMouseEnter = global::SIVS.Properties.Resources.Delete_flip30;
            this.btn_QuitarArticulo.ImageOnNothing = global::SIVS.Properties.Resources.Delete;
            this.btn_QuitarArticulo.Location = new System.Drawing.Point(486, 261);
            this.btn_QuitarArticulo.Name = "btn_QuitarArticulo";
            this.btn_QuitarArticulo.Size = new System.Drawing.Size(226, 32);
            this.btn_QuitarArticulo.TabIndex = 151;
            this.btn_QuitarArticulo.Text = "     Quitar artículo de la lista";
            this.btn_QuitarArticulo.UseVisualStyleBackColor = false;
            this.btn_QuitarArticulo.Click += new System.EventHandler(this.btn_QuitarArticulo_Click);
            // 
            // dgrid_Articulos
            // 
            this.dgrid_Articulos.AllowUserToAddRows = false;
            this.dgrid_Articulos.AllowUserToDeleteRows = false;
            this.dgrid_Articulos.AllowUserToResizeRows = false;
            this.dgrid_Articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Articulos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Articulos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Articulos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_Articulos.Location = new System.Drawing.Point(226, 104);
            this.dgrid_Articulos.MultiSelect = false;
            this.dgrid_Articulos.Name = "dgrid_Articulos";
            this.dgrid_Articulos.ReadOnly = true;
            this.dgrid_Articulos.RowHeadersVisible = false;
            this.dgrid_Articulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Articulos.Size = new System.Drawing.Size(486, 151);
            this.dgrid_Articulos.TabIndex = 148;
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Agregar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Agregar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Agregar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Agregar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Agregar.BackgroundImage = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Agregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_Agregar.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.Location = new System.Drawing.Point(365, 40);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(208, 32);
            this.btn_Agregar.TabIndex = 147;
            this.btn_Agregar.Text = "      Agregar rubro";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // cbb_Rubros
            // 
            this.cbb_Rubros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_Rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Rubros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_Rubros.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cbb_Rubros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_Rubros.FormattingEnabled = true;
            this.cbb_Rubros.Location = new System.Drawing.Point(86, 41);
            this.cbb_Rubros.Name = "cbb_Rubros";
            this.cbb_Rubros.Size = new System.Drawing.Size(266, 31);
            this.cbb_Rubros.TabIndex = 144;
            // 
            // dgrid_Rubros
            // 
            this.dgrid_Rubros.AllowUserToAddRows = false;
            this.dgrid_Rubros.AllowUserToDeleteRows = false;
            this.dgrid_Rubros.AllowUserToResizeRows = false;
            this.dgrid_Rubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Rubros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Rubros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Rubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Rubros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_Rubros.Location = new System.Drawing.Point(12, 104);
            this.dgrid_Rubros.MultiSelect = false;
            this.dgrid_Rubros.Name = "dgrid_Rubros";
            this.dgrid_Rubros.ReadOnly = true;
            this.dgrid_Rubros.RowHeadersVisible = false;
            this.dgrid_Rubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Rubros.Size = new System.Drawing.Size(208, 151);
            this.dgrid_Rubros.TabIndex = 73;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(719, 32);
            this.label29.TabIndex = 58;
            this.label29.Text = "Seleccione un RUBRO de la lista y oprima \" Agregar rubro\".";
            // 
            // lbl_Total
            // 
            this.lbl_Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lbl_Total.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Total.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Total.Location = new System.Drawing.Point(788, 46);
            this.lbl_Total.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(133, 39);
            this.lbl_Total.TabIndex = 126;
            this.lbl_Total.Text = "00000,00";
            this.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(590, 51);
            this.label8.Margin = new System.Windows.Forms.Padding(5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 28);
            this.label8.TabIndex = 125;
            this.label8.Text = "Total sin actualizar : $";
            // 
            // lbl_totalActualizado
            // 
            this.lbl_totalActualizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_totalActualizado.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_totalActualizado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_totalActualizado.Location = new System.Drawing.Point(788, 91);
            this.lbl_totalActualizado.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_totalActualizado.Name = "lbl_totalActualizado";
            this.lbl_totalActualizado.Size = new System.Drawing.Size(133, 39);
            this.lbl_totalActualizado.TabIndex = 154;
            this.lbl_totalActualizado.Text = "00000,00";
            this.lbl_totalActualizado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(604, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 28);
            this.label2.TabIndex = 153;
            this.label2.Text = "Total actualizado : $";
            // 
            // lbl_Diferencia
            // 
            this.lbl_Diferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.lbl_Diferencia.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_Diferencia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Diferencia.Location = new System.Drawing.Point(788, 136);
            this.lbl_Diferencia.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Diferencia.Name = "lbl_Diferencia";
            this.lbl_Diferencia.Size = new System.Drawing.Size(133, 39);
            this.lbl_Diferencia.TabIndex = 156;
            this.lbl_Diferencia.Text = "00000,00";
            this.lbl_Diferencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(660, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 155;
            this.label4.Text = "Diferencia : $";
            // 
            // lbl_signo
            // 
            this.lbl_signo.AutoSize = true;
            this.lbl_signo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_signo.Location = new System.Drawing.Point(4, 213);
            this.lbl_signo.Name = "lbl_signo";
            this.lbl_signo.Size = new System.Drawing.Size(95, 25);
            this.lbl_signo.TabIndex = 158;
            this.lbl_signo.Text = "Valor en %";
            // 
            // rb_Porcentaje
            // 
            this.rb_Porcentaje.AutoSize = true;
            this.rb_Porcentaje.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.rb_Porcentaje.Checked = true;
            this.rb_Porcentaje.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_Porcentaje.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Porcentaje.Location = new System.Drawing.Point(0, 0);
            this.rb_Porcentaje.Name = "rb_Porcentaje";
            this.rb_Porcentaje.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.rb_Porcentaje.Size = new System.Drawing.Size(194, 29);
            this.rb_Porcentaje.TabIndex = 160;
            this.rb_Porcentaje.TabStop = true;
            this.rb_Porcentaje.Text = "Porcentaje";
            this.rb_Porcentaje.UseVisualStyleBackColor = false;
            this.rb_Porcentaje.CheckedChanged += new System.EventHandler(this.rb_Porcentaje_CheckedChanged);
            // 
            // rb_MontoFijo
            // 
            this.rb_MontoFijo.AutoSize = true;
            this.rb_MontoFijo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.rb_MontoFijo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rb_MontoFijo.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_MontoFijo.Location = new System.Drawing.Point(0, 33);
            this.rb_MontoFijo.Name = "rb_MontoFijo";
            this.rb_MontoFijo.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.rb_MontoFijo.Size = new System.Drawing.Size(194, 29);
            this.rb_MontoFijo.TabIndex = 161;
            this.rb_MontoFijo.Text = "Monto fijo";
            this.rb_MontoFijo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_valor);
            this.panel1.Controls.Add(this.btn_GenerarVista);
            this.panel1.Controls.Add(this.cb_Redondear);
            this.panel1.Controls.Add(this.pn_tipo2);
            this.panel1.Controls.Add(this.pn_tipo1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbl_signo);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(725, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 302);
            this.panel1.TabIndex = 158;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_valor.CantDecimales = 2;
            this.txt_valor.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_valor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_valor.Location = new System.Drawing.Point(105, 210);
            this.txt_valor.MaxLength = 8;
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(95, 31);
            this.txt_valor.TabIndex = 167;
            this.txt_valor.Text = "1";
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_valor.TextDefault = "1";
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // btn_GenerarVista
            // 
            this.btn_GenerarVista.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_GenerarVista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_GenerarVista.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_GenerarVista.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_GenerarVista.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_GenerarVista.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_GenerarVista.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_GenerarVista.BackgroundImage")));
            this.btn_GenerarVista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_GenerarVista.FlatAppearance.BorderSize = 0;
            this.btn_GenerarVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenerarVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_GenerarVista.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GenerarVista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_GenerarVista.ImageEnableFalse = global::SIVS.Properties.Resources.CopiarAbajo_32;
            this.btn_GenerarVista.ImageOnMouseDown = global::SIVS.Properties.Resources.CopiarAbajo_32;
            this.btn_GenerarVista.ImageOnMouseEnter = global::SIVS.Properties.Resources.CopiarAbajo_32_flip;
            this.btn_GenerarVista.ImageOnNothing = ((System.Drawing.Image)(resources.GetObject("btn_GenerarVista.ImageOnNothing")));
            this.btn_GenerarVista.Location = new System.Drawing.Point(9, 262);
            this.btn_GenerarVista.Name = "btn_GenerarVista";
            this.btn_GenerarVista.Size = new System.Drawing.Size(191, 32);
            this.btn_GenerarVista.TabIndex = 163;
            this.btn_GenerarVista.Text = "    Generar vista previa";
            this.btn_GenerarVista.UseVisualStyleBackColor = false;
            this.btn_GenerarVista.Click += new System.EventHandler(this.btn_GenerarVista_Click);
            // 
            // cb_Redondear
            // 
            this.cb_Redondear.AutoSize = true;
            this.cb_Redondear.BackColor = System.Drawing.Color.Transparent;
            this.cb_Redondear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.cb_Redondear.FlatAppearance.BorderSize = 0;
            this.cb_Redondear.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.cb_Redondear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.cb_Redondear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.cb_Redondear.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.cb_Redondear.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Redondear.Location = new System.Drawing.Point(18, 175);
            this.cb_Redondear.Name = "cb_Redondear";
            this.cb_Redondear.Size = new System.Drawing.Size(182, 29);
            this.cb_Redondear.TabIndex = 166;
            this.cb_Redondear.Text = "Redondear precios";
            this.cb_Redondear.UseVisualStyleBackColor = false;
            // 
            // pn_tipo2
            // 
            this.pn_tipo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pn_tipo2.Controls.Add(this.rb_Decremento);
            this.pn_tipo2.Controls.Add(this.rb_Incremento);
            this.pn_tipo2.Location = new System.Drawing.Point(6, 41);
            this.pn_tipo2.Name = "pn_tipo2";
            this.pn_tipo2.Size = new System.Drawing.Size(194, 60);
            this.pn_tipo2.TabIndex = 165;
            // 
            // rb_Decremento
            // 
            this.rb_Decremento.AutoSize = true;
            this.rb_Decremento.BackColor = System.Drawing.Color.Transparent;
            this.rb_Decremento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rb_Decremento.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Decremento.Location = new System.Drawing.Point(0, 31);
            this.rb_Decremento.Name = "rb_Decremento";
            this.rb_Decremento.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.rb_Decremento.Size = new System.Drawing.Size(194, 29);
            this.rb_Decremento.TabIndex = 163;
            this.rb_Decremento.Text = "Decremento";
            this.rb_Decremento.UseVisualStyleBackColor = false;
            // 
            // rb_Incremento
            // 
            this.rb_Incremento.AutoSize = true;
            this.rb_Incremento.BackColor = System.Drawing.Color.Transparent;
            this.rb_Incremento.Checked = true;
            this.rb_Incremento.Dock = System.Windows.Forms.DockStyle.Top;
            this.rb_Incremento.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.rb_Incremento.Location = new System.Drawing.Point(0, 0);
            this.rb_Incremento.Name = "rb_Incremento";
            this.rb_Incremento.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.rb_Incremento.Size = new System.Drawing.Size(194, 29);
            this.rb_Incremento.TabIndex = 162;
            this.rb_Incremento.TabStop = true;
            this.rb_Incremento.Text = "Incremento";
            this.rb_Incremento.UseVisualStyleBackColor = false;
            // 
            // pn_tipo1
            // 
            this.pn_tipo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.pn_tipo1.Controls.Add(this.rb_MontoFijo);
            this.pn_tipo1.Controls.Add(this.rb_Porcentaje);
            this.pn_tipo1.Location = new System.Drawing.Point(6, 107);
            this.pn_tipo1.Name = "pn_tipo1";
            this.pn_tipo1.Size = new System.Drawing.Size(194, 62);
            this.pn_tipo1.TabIndex = 164;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(207, 32);
            this.label9.TabIndex = 58;
            this.label9.Text = "Opciones";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.dgrid_ArticulosActualizados);
            this.panel2.Controls.Add(this.btn_Actualizar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_Total);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lbl_Diferencia);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbl_totalActualizado);
            this.panel2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(0, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 234);
            this.panel2.TabIndex = 162;
            // 
            // dgrid_ArticulosActualizados
            // 
            this.dgrid_ArticulosActualizados.AllowUserToAddRows = false;
            this.dgrid_ArticulosActualizados.AllowUserToDeleteRows = false;
            this.dgrid_ArticulosActualizados.AllowUserToResizeRows = false;
            this.dgrid_ArticulosActualizados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ArticulosActualizados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_ArticulosActualizados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_ArticulosActualizados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_ArticulosActualizados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_ArticulosActualizados.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgrid_ArticulosActualizados.Location = new System.Drawing.Point(0, 32);
            this.dgrid_ArticulosActualizados.MultiSelect = false;
            this.dgrid_ArticulosActualizados.Name = "dgrid_ArticulosActualizados";
            this.dgrid_ArticulosActualizados.ReadOnly = true;
            this.dgrid_ArticulosActualizados.RowHeadersVisible = false;
            this.dgrid_ArticulosActualizados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ArticulosActualizados.Size = new System.Drawing.Size(589, 202);
            this.dgrid_ArticulosActualizados.TabIndex = 153;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(932, 32);
            this.label7.TabIndex = 58;
            this.label7.Text = "Vista previa de la actualización. (Oprima ACTUALIZAR para hacer efectiva la actua" +
    "lilzación)";
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Actualizar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Actualizar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Actualizar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Actualizar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Actualizar.BackgroundImage = global::SIVS.Properties.Resources.Guardar;
            this.btn_Actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Actualizar.FlatAppearance.BorderSize = 0;
            this.btn_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Actualizar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Actualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Actualizar.ImageEnableFalse = global::SIVS.Properties.Resources.Guardar;
            this.btn_Actualizar.ImageOnMouseDown = global::SIVS.Properties.Resources.Guardar;
            this.btn_Actualizar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Guardar_flip30;
            this.btn_Actualizar.ImageOnNothing = global::SIVS.Properties.Resources.Guardar;
            this.btn_Actualizar.Location = new System.Drawing.Point(595, 193);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(326, 32);
            this.btn_Actualizar.TabIndex = 157;
            this.btn_Actualizar.Text = "      Actualizar precios";
            this.btn_Actualizar.UseVisualStyleBackColor = false;
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Cancelar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Cancelar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Cancelar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Cancelar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Cancelar.BackgroundImage = global::SIVS.Properties.Resources.Cancelar;
            this.btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancelar.ImageEnableFalse = global::SIVS.Properties.Resources.Cancelar;
            this.btn_Cancelar.ImageOnMouseDown = global::SIVS.Properties.Resources.Cancelar;
            this.btn_Cancelar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Cancel_flip30;
            this.btn_Cancelar.ImageOnNothing = global::SIVS.Properties.Resources.Cancelar;
            this.btn_Cancelar.Location = new System.Drawing.Point(814, 7);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_Cancelar.TabIndex = 158;
            this.btn_Cancelar.Text = "     Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.btn_Cancelar);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 546);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(936, 51);
            this.pbtn.TabIndex = 163;
            // 
            // Frm_ActualizarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(936, 597);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Frm_ActualizarPrecios";
            this.Text = "Actualizacion de precios";
            this.Load += new System.EventHandler(this.Frm_ActualizarPrecios_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Rubros)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_tipo2.ResumeLayout(false);
            this.pn_tipo2.PerformLayout();
            this.pn_tipo1.ResumeLayout(false);
            this.pn_tipo1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ArticulosActualizados)).EndInit();
            this.pbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_CbbRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_DgridRubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ArticulosActualizados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbb_Rubros;
        private System.Windows.Forms.DataGridView dgrid_Rubros;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgrid_Articulos;
        protected CONTROLES.ButtonImages btn_Agregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Diferencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_totalActualizado;
        private System.Windows.Forms.Label label2;
        protected CONTROLES.ButtonImages btn_QuitarRubro;
        protected CONTROLES.ButtonImages btn_QuitarArticulo;
        private System.Windows.Forms.Label lbl_signo;
        private System.Windows.Forms.RadioButton rb_MontoFijo;
        private System.Windows.Forms.RadioButton rb_Porcentaje;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_tipo2;
        private System.Windows.Forms.RadioButton rb_Decremento;
        private System.Windows.Forms.RadioButton rb_Incremento;
        private System.Windows.Forms.Panel pn_tipo1;
        private System.Windows.Forms.Label label9;
        protected System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgrid_ArticulosActualizados;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_Redondear;
        protected CONTROLES.ButtonImages btn_GenerarVista;
        protected CONTROLES.ButtonImages btn_Actualizar;
        protected CONTROLES.ButtonImages btn_Cancelar;
        protected System.Windows.Forms.Panel pbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bs_CbbRubros;
        private System.Windows.Forms.BindingSource bs_Articulos;
        private System.Windows.Forms.BindingSource bs_DgridRubros;
        private CONTROLES.TextBox_Decimal txt_valor;
        private System.Windows.Forms.BindingSource bs_ArticulosActualizados;
    }
}