namespace SIVS
{
    partial class frm_multiSeleccion
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
            this.p_izquierdo = new System.Windows.Forms.Panel();
            this.p_interiorIzquierdo = new System.Windows.Forms.Panel();
            this.dgrid_objetos = new System.Windows.Forms.DataGridView();
            this.Incluir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lbl_argumento = new System.Windows.Forms.Label();
            this.p_abajo = new System.Windows.Forms.Panel();
            this.btn_todos = new CONTROLES.ButtonImages();
            this.btn_aceptar = new CONTROLES.ButtonImages();
            this.btn_salir = new CONTROLES.ButtonImages();
            this.bs_objetos = new System.Windows.Forms.BindingSource(this.components);
            this.p_izquierdo.SuspendLayout();
            this.p_interiorIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).BeginInit();
            this.p_abajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_objetos)).BeginInit();
            this.SuspendLayout();
            // 
            // p_izquierdo
            // 
            this.p_izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.p_izquierdo.Controls.Add(this.p_interiorIzquierdo);
            this.p_izquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_izquierdo.Location = new System.Drawing.Point(0, 0);
            this.p_izquierdo.Name = "p_izquierdo";
            this.p_izquierdo.Padding = new System.Windows.Forms.Padding(10);
            this.p_izquierdo.Size = new System.Drawing.Size(622, 453);
            this.p_izquierdo.TabIndex = 9;
            // 
            // p_interiorIzquierdo
            // 
            this.p_interiorIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_interiorIzquierdo.Controls.Add(this.dgrid_objetos);
            this.p_interiorIzquierdo.Controls.Add(this.lbl_argumento);
            this.p_interiorIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_interiorIzquierdo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_interiorIzquierdo.Location = new System.Drawing.Point(10, 10);
            this.p_interiorIzquierdo.Name = "p_interiorIzquierdo";
            this.p_interiorIzquierdo.Padding = new System.Windows.Forms.Padding(10);
            this.p_interiorIzquierdo.Size = new System.Drawing.Size(602, 433);
            this.p_interiorIzquierdo.TabIndex = 0;
            // 
            // dgrid_objetos
            // 
            this.dgrid_objetos.AllowUserToAddRows = false;
            this.dgrid_objetos.AllowUserToDeleteRows = false;
            this.dgrid_objetos.AllowUserToResizeRows = false;
            this.dgrid_objetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_objetos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_objetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_objetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_objetos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_objetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrid_objetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Incluir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_objetos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_objetos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_objetos.Location = new System.Drawing.Point(10, 41);
            this.dgrid_objetos.Name = "dgrid_objetos";
            this.dgrid_objetos.RowHeadersVisible = false;
            this.dgrid_objetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_objetos.Size = new System.Drawing.Size(582, 382);
            this.dgrid_objetos.TabIndex = 215;
            // 
            // Incluir
            // 
            this.Incluir.HeaderText = "Sel";
            this.Incluir.IndeterminateValue = "True";
            this.Incluir.Name = "Incluir";
            // 
            // lbl_argumento
            // 
            this.lbl_argumento.AutoSize = true;
            this.lbl_argumento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_argumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_argumento.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_argumento.Location = new System.Drawing.Point(10, 10);
            this.lbl_argumento.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_argumento.Name = "lbl_argumento";
            this.lbl_argumento.Size = new System.Drawing.Size(209, 25);
            this.lbl_argumento.TabIndex = 116;
            this.lbl_argumento.Text = "Seleccione los que quiera:";
            // 
            // p_abajo
            // 
            this.p_abajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_abajo.Controls.Add(this.btn_todos);
            this.p_abajo.Controls.Add(this.btn_aceptar);
            this.p_abajo.Controls.Add(this.btn_salir);
            this.p_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_abajo.Location = new System.Drawing.Point(0, 453);
            this.p_abajo.Name = "p_abajo";
            this.p_abajo.Padding = new System.Windows.Forms.Padding(10);
            this.p_abajo.Size = new System.Drawing.Size(622, 57);
            this.p_abajo.TabIndex = 8;
            // 
            // btn_todos
            // 
            this.btn_todos.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_todos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_todos.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_todos.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_todos.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_todos.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_todos.BackgroundImage = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_todos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_todos.FlatAppearance.BorderSize = 0;
            this.btn_todos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_todos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_todos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_todos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_todos.ImageEnableFalse = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_todos.ImageOnMouseDown = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_todos.ImageOnMouseEnter = global::SIVS.Properties.Resources.Confirmar_32_Flip;
            this.btn_todos.ImageOnNothing = global::SIVS.Properties.Resources.Confirmar_32;
            this.btn_todos.Location = new System.Drawing.Point(161, 12);
            this.btn_todos.Name = "btn_todos";
            this.btn_todos.Size = new System.Drawing.Size(216, 32);
            this.btn_todos.TabIndex = 35;
            this.btn_todos.Text = "      Seleccionar todos";
            this.btn_todos.UseVisualStyleBackColor = false;
            this.btn_todos.Click += new System.EventHandler(this.btn_todos_Click);
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_aceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_aceptar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_aceptar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_aceptar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_aceptar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_aceptar.BackgroundImage = global::SIVS.Properties.Resources.Guardar;
            this.btn_aceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_aceptar.FlatAppearance.BorderSize = 0;
            this.btn_aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aceptar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_aceptar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_aceptar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_aceptar.ImageEnableFalse = global::SIVS.Properties.Resources.Guardar;
            this.btn_aceptar.ImageOnMouseDown = global::SIVS.Properties.Resources.Guardar;
            this.btn_aceptar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Guardar_flip30;
            this.btn_aceptar.ImageOnNothing = global::SIVS.Properties.Resources.Guardar;
            this.btn_aceptar.Location = new System.Drawing.Point(383, 12);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(110, 32);
            this.btn_aceptar.TabIndex = 34;
            this.btn_aceptar.Text = "      Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = false;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_alta_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_salir.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_salir.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_salir.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_salir.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_salir.BackgroundImage = global::SIVS.Properties.Resources.Login_door;
            this.btn_salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_salir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salir.ImageEnableFalse = global::SIVS.Properties.Resources.Login_door;
            this.btn_salir.ImageOnMouseDown = global::SIVS.Properties.Resources.Login_door;
            this.btn_salir.ImageOnMouseEnter = global::SIVS.Properties.Resources.Login_door_flip30;
            this.btn_salir.ImageOnNothing = global::SIVS.Properties.Resources.Login_door;
            this.btn_salir.Location = new System.Drawing.Point(499, 12);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(110, 32);
            this.btn_salir.TabIndex = 33;
            this.btn_salir.Text = "    Cancelar";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // frm_multiSeleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 510);
            this.Controls.Add(this.p_izquierdo);
            this.Controls.Add(this.p_abajo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_multiSeleccion";
            this.Text = "Seleccione ";
            this.Load += new System.EventHandler(this.frm_multiSeleccion_Load);
            this.p_izquierdo.ResumeLayout(false);
            this.p_interiorIzquierdo.ResumeLayout(false);
            this.p_interiorIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).EndInit();
            this.p_abajo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_objetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel p_izquierdo;
        protected System.Windows.Forms.Panel p_interiorIzquierdo;
        private System.Windows.Forms.DataGridView dgrid_objetos;
        private System.Windows.Forms.Label lbl_argumento;
        protected System.Windows.Forms.Panel p_abajo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Incluir;
        protected CONTROLES.ButtonImages btn_salir;
        protected CONTROLES.ButtonImages btn_aceptar;
        private System.Windows.Forms.BindingSource bs_objetos;
        protected CONTROLES.ButtonImages btn_todos;
    }
}