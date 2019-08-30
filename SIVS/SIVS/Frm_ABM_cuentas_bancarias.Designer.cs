namespace SIVS
{
    partial class Frm_ABM_cuentas_bancarias
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM_cuentas_bancarias));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pn_busqueda = new System.Windows.Forms.Panel();
            this.txt_busqueda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgrid_cuentasBancarias = new System.Windows.Forms.DataGridView();
            this.txt_cbu = new System.Windows.Forms.TextBox();
            this.lbl_cbu = new System.Windows.Forms.Label();
            this.txt_titular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tipoCuenta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bs_bancos = new System.Windows.Forms.BindingSource(this.components);
            this.lbl_banco = new System.Windows.Forms.Label();
            this.cbb_banco = new System.Windows.Forms.ComboBox();
            this.bs_cuentasBancarias = new System.Windows.Forms.BindingSource(this.components);
            this.pbtn.SuspendLayout();
            this.pn_abm.SuspendLayout();
            this.gb_abm.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            this.pn_busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cuentasBancarias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_bancos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cuentasBancarias)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Cancelar.BackgroundImage")));
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.BackgroundImage")));
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
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
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click_1);
            // 
            // pbtn
            // 
            this.pbtn.Location = new System.Drawing.Point(0, 479);
            this.pbtn.Size = new System.Drawing.Size(1221, 51);
            // 
            // pn_abm
            // 
            this.pn_abm.Controls.Add(this.lbl_banco);
            this.pn_abm.Controls.Add(this.cbb_banco);
            this.pn_abm.Controls.Add(this.txt_tipoCuenta);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.txt_nroCuenta);
            this.pn_abm.Controls.Add(this.label3);
            this.pn_abm.Controls.Add(this.txt_titular);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.txt_cbu);
            this.pn_abm.Controls.Add(this.lbl_cbu);
            this.pn_abm.Padding = new System.Windows.Forms.Padding(10);
            this.pn_abm.Size = new System.Drawing.Size(451, 463);
            // 
            // gb_abm
            // 
            this.gb_abm.Controls.Add(this.dgrid_cuentasBancarias);
            this.gb_abm.Controls.Add(this.pn_busqueda);
            this.gb_abm.Size = new System.Drawing.Size(746, 463);
            // 
            // p_arriba
            // 
            this.p_arriba.Size = new System.Drawing.Size(1221, 479);
            // 
            // p_derecho
            // 
            this.p_derecho.Location = new System.Drawing.Point(754, 8);
            this.p_derecho.Size = new System.Drawing.Size(459, 463);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Location = new System.Drawing.Point(965, 0);
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Size = new System.Drawing.Size(965, 51);
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Location = new System.Drawing.Point(846, 0);
            // 
            // pn_busqueda
            // 
            this.pn_busqueda.Controls.Add(this.txt_busqueda);
            this.pn_busqueda.Controls.Add(this.label6);
            this.pn_busqueda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_busqueda.Location = new System.Drawing.Point(0, 424);
            this.pn_busqueda.Name = "pn_busqueda";
            this.pn_busqueda.Padding = new System.Windows.Forms.Padding(5);
            this.pn_busqueda.Size = new System.Drawing.Size(746, 39);
            this.pn_busqueda.TabIndex = 30;
            // 
            // txt_busqueda
            // 
            this.txt_busqueda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_busqueda.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_busqueda.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_busqueda.Location = new System.Drawing.Point(308, 5);
            this.txt_busqueda.MaxLength = 100;
            this.txt_busqueda.Name = "txt_busqueda";
            this.txt_busqueda.Size = new System.Drawing.Size(433, 30);
            this.txt_busqueda.TabIndex = 30;
            this.txt_busqueda.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(5, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(303, 28);
            this.label6.TabIndex = 29;
            this.label6.Text = "Busqueda por titular o nro cuenta :";
            this.label6.Visible = false;
            // 
            // dgrid_cuentasBancarias
            // 
            this.dgrid_cuentasBancarias.AllowUserToAddRows = false;
            this.dgrid_cuentasBancarias.AllowUserToDeleteRows = false;
            this.dgrid_cuentasBancarias.AllowUserToResizeRows = false;
            this.dgrid_cuentasBancarias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_cuentasBancarias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_cuentasBancarias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_cuentasBancarias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_cuentasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_cuentasBancarias.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_cuentasBancarias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_cuentasBancarias.Location = new System.Drawing.Point(0, 0);
            this.dgrid_cuentasBancarias.Margin = new System.Windows.Forms.Padding(3, 3, 3, 41);
            this.dgrid_cuentasBancarias.Name = "dgrid_cuentasBancarias";
            this.dgrid_cuentasBancarias.ReadOnly = true;
            this.dgrid_cuentasBancarias.RowHeadersVisible = false;
            this.dgrid_cuentasBancarias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_cuentasBancarias.Size = new System.Drawing.Size(746, 424);
            this.dgrid_cuentasBancarias.TabIndex = 31;
            this.dgrid_cuentasBancarias.SelectionChanged += new System.EventHandler(this.dgrid_cuentasBancarias_SelectionChanged);
            // 
            // txt_cbu
            // 
            this.txt_cbu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_cbu.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_cbu.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cbu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_cbu.Location = new System.Drawing.Point(10, 35);
            this.txt_cbu.Name = "txt_cbu";
            this.txt_cbu.Size = new System.Drawing.Size(431, 30);
            this.txt_cbu.TabIndex = 12;
            this.txt_cbu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_cbu
            // 
            this.lbl_cbu.AutoSize = true;
            this.lbl_cbu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_cbu.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_cbu.Location = new System.Drawing.Point(10, 10);
            this.lbl_cbu.Name = "lbl_cbu";
            this.lbl_cbu.Size = new System.Drawing.Size(54, 25);
            this.lbl_cbu.TabIndex = 13;
            this.lbl_cbu.Text = "CBU :";
            // 
            // txt_titular
            // 
            this.txt_titular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_titular.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_titular.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titular.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_titular.Location = new System.Drawing.Point(10, 90);
            this.txt_titular.Name = "txt_titular";
            this.txt_titular.Size = new System.Drawing.Size(431, 30);
            this.txt_titular.TabIndex = 20;
            this.txt_titular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(10, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Titular :";
            // 
            // txt_nroCuenta
            // 
            this.txt_nroCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nroCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nroCuenta.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nroCuenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nroCuenta.Location = new System.Drawing.Point(10, 145);
            this.txt_nroCuenta.Name = "txt_nroCuenta";
            this.txt_nroCuenta.Size = new System.Drawing.Size(431, 30);
            this.txt_nroCuenta.TabIndex = 22;
            this.txt_nroCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.Location = new System.Drawing.Point(10, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "Número de cuenta :";
            // 
            // txt_tipoCuenta
            // 
            this.txt_tipoCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_tipoCuenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_tipoCuenta.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoCuenta.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_tipoCuenta.Location = new System.Drawing.Point(10, 200);
            this.txt_tipoCuenta.Name = "txt_tipoCuenta";
            this.txt_tipoCuenta.Size = new System.Drawing.Size(431, 30);
            this.txt_tipoCuenta.TabIndex = 24;
            this.txt_tipoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(10, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tipo de cuenta :";
            // 
            // lbl_banco
            // 
            this.lbl_banco.AutoSize = true;
            this.lbl_banco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_banco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_banco.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_banco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.lbl_banco.Location = new System.Drawing.Point(14, 249);
            this.lbl_banco.Name = "lbl_banco";
            this.lbl_banco.Size = new System.Drawing.Size(70, 27);
            this.lbl_banco.TabIndex = 33;
            this.lbl_banco.Text = "Banco :";
            this.lbl_banco.Click += new System.EventHandler(this.lbl_banco_Click);
            // 
            // cbb_banco
            // 
            this.cbb_banco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_banco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_banco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_banco.Font = new System.Drawing.Font("Segoe UI Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_banco.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_banco.FormattingEnabled = true;
            this.cbb_banco.Location = new System.Drawing.Point(90, 246);
            this.cbb_banco.Name = "cbb_banco";
            this.cbb_banco.Size = new System.Drawing.Size(351, 31);
            this.cbb_banco.TabIndex = 32;
            // 
            // Frm_ABM_cuentas_bancarias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1221, 530);
            this.MinimumSize = new System.Drawing.Size(744, 436);
            this.Name = "Frm_ABM_cuentas_bancarias";
            this.Text = "Administración de cuentas bancarias";
            this.Activated += new System.EventHandler(this.Frm_ABM_cuentas_bancarias_Activated);
            this.Load += new System.EventHandler(this.Frm_ABM_cuentas_bancarias_Load);
            this.ResizeEnd += new System.EventHandler(this.Frm_ABM_cuentas_bancarias_ResizeEnd);
            this.pbtn.ResumeLayout(false);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_abm.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            this.pn_busqueda.ResumeLayout(false);
            this.pn_busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cuentasBancarias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_bancos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cuentasBancarias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_busqueda;
        private System.Windows.Forms.TextBox txt_busqueda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgrid_cuentasBancarias;
        private System.Windows.Forms.TextBox txt_cbu;
        private System.Windows.Forms.Label lbl_cbu;
        private System.Windows.Forms.TextBox txt_tipoCuenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_titular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bs_bancos;
        private System.Windows.Forms.Label lbl_banco;
        private System.Windows.Forms.ComboBox cbb_banco;
        private System.Windows.Forms.BindingSource bs_cuentasBancarias;
    }
}
