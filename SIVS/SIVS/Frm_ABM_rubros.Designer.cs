namespace SIVS
{
    partial class Frm_ABM_rubros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_rubros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrid_rubros = new System.Windows.Forms.DataGridView();
            this.bs_rubros = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numero = new CONTROLES.TextBox_Int();
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_rubros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.Location = new System.Drawing.Point(132, 10);
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.Location = new System.Drawing.Point(18, 10);
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.BackgroundImage")));
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Modificar.BackgroundImage")));
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.BackgroundImage")));
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // pbtn
            // 
            this.pbtn.Size = new System.Drawing.Size(729, 51);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.txt_numero);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.txt_nombre);
            this.pn_abm.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.pn_abm.Size = new System.Drawing.Size(236, 331);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_rubros);
            this.gb_abm.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.gb_abm.Size = new System.Drawing.Size(469, 331);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(729, 347);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(477, 8);
            this.p_derecho.Size = new System.Drawing.Size(244, 331);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(477, 0);
            this.pn_btnDerechos.Size = new System.Drawing.Size(252, 51);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(477, 51);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(358, 0);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(79, 47);
            this.txt_nombre.MaxLength = 60;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(143, 31);
            this.txt_nombre.TabIndex = 32;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantAlta_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(3, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Rubro :";
            // 
            // dgrid_rubros
            // 
            this.dgrid_rubros.AllowUserToAddRows = false;
            this.dgrid_rubros.AllowUserToDeleteRows = false;
            this.dgrid_rubros.AllowUserToResizeRows = false;
            this.dgrid_rubros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrid_rubros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_rubros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_rubros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_rubros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_rubros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_rubros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_rubros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_rubros.Location = new System.Drawing.Point(0, 0);
            this.dgrid_rubros.MultiSelect = false;
            this.dgrid_rubros.Name = "dgrid_rubros";
            this.dgrid_rubros.ReadOnly = true;
            this.dgrid_rubros.RowHeadersVisible = false;
            this.dgrid_rubros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_rubros.Size = new System.Drawing.Size(469, 331);
            this.dgrid_rubros.TabIndex = 26;
            this.dgrid_rubros.SelectionChanged += new System.EventHandler(this.dgrid_rubros_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Numero :";
            // 
            // txt_numero
            // 
            this.txt_numero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_numero.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_numero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_numero.Location = new System.Drawing.Point(122, 10);
            this.txt_numero.MaxLength = 9;
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 31);
            this.txt_numero.TabIndex = 31;
            this.txt_numero.TextDefault = null;
            // 
            // Frm_ABM_rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 398);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_rubros";
            this.Text = "Administrar rubros";
            this.Activated += new System.EventHandler(this.Frm_ABM_rubros_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_rubros_Load);
            this.Shown += new System.EventHandler(this.Frm_ABM_rubros_Shown);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_rubros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_rubros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgrid_rubros;
        private System.Windows.Forms.BindingSource bs_rubros;
        private System.Windows.Forms.Label label1;
        private CONTROLES.TextBox_Int txt_numero;
    }
}
