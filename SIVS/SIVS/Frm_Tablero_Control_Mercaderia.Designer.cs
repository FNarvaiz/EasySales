namespace SIVS
{
    partial class Frm_Tablero_Control_Mercaderia
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
            this.p_derecho = new System.Windows.Forms.Panel();
            this.label30 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label32 = new System.Windows.Forms.Label();
            this.p_buscador = new System.Windows.Forms.Panel();
            this.lbl_utilidad = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_activoAlCosto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_activoAlPrecio = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bs_mercaderias = new System.Windows.Forms.BindingSource(this.components);
            this.dgrid_objetos = new System.Windows.Forms.DataGridView();
            this.p_derecho.SuspendLayout();
            this.panel1.SuspendLayout();
            this.p_buscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_mercaderias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).BeginInit();
            this.SuspendLayout();
            // 
            // p_derecho
            // 
            this.p_derecho.Controls.Add(this.p_buscador);
            this.p_derecho.Controls.Add(this.label32);
            this.p_derecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_derecho.Location = new System.Drawing.Point(807, 5);
            this.p_derecho.Name = "p_derecho";
            this.p_derecho.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.p_derecho.Size = new System.Drawing.Size(237, 556);
            this.p_derecho.TabIndex = 136;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label30.Dock = System.Windows.Forms.DockStyle.Top;
            this.label30.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label30.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label30.Location = new System.Drawing.Point(5, 5);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(802, 32);
            this.label30.TabIndex = 147;
            this.label30.Text = "Mercaderia detallada";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgrid_objetos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(5, 37);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(802, 524);
            this.panel1.TabIndex = 148;
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label32.Dock = System.Windows.Forms.DockStyle.Top;
            this.label32.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label32.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label32.Location = new System.Drawing.Point(5, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(232, 32);
            this.label32.TabIndex = 147;
            this.label32.Text = "Totales";
            // 
            // p_buscador
            // 
            this.p_buscador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_buscador.Controls.Add(this.lbl_utilidad);
            this.p_buscador.Controls.Add(this.label19);
            this.p_buscador.Controls.Add(this.lbl_activoAlCosto);
            this.p_buscador.Controls.Add(this.label13);
            this.p_buscador.Controls.Add(this.lbl_activoAlPrecio);
            this.p_buscador.Controls.Add(this.label12);
            this.p_buscador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_buscador.Location = new System.Drawing.Point(5, 32);
            this.p_buscador.Name = "p_buscador";
            this.p_buscador.Padding = new System.Windows.Forms.Padding(8);
            this.p_buscador.Size = new System.Drawing.Size(232, 524);
            this.p_buscador.TabIndex = 148;
            // 
            // lbl_utilidad
            // 
            this.lbl_utilidad.BackColor = System.Drawing.Color.Transparent;
            this.lbl_utilidad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_utilidad.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_utilidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_utilidad.Location = new System.Drawing.Point(8, 148);
            this.lbl_utilidad.Name = "lbl_utilidad";
            this.lbl_utilidad.Size = new System.Drawing.Size(216, 28);
            this.lbl_utilidad.TabIndex = 144;
            this.lbl_utilidad.Text = "00000,00";
            this.lbl_utilidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Top;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label19.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label19.Location = new System.Drawing.Point(8, 120);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 28);
            this.label19.TabIndex = 145;
            this.label19.Text = "Utilidad: ";
            // 
            // lbl_activoAlCosto
            // 
            this.lbl_activoAlCosto.BackColor = System.Drawing.Color.Transparent;
            this.lbl_activoAlCosto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_activoAlCosto.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_activoAlCosto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_activoAlCosto.Location = new System.Drawing.Point(8, 92);
            this.lbl_activoAlCosto.Name = "lbl_activoAlCosto";
            this.lbl_activoAlCosto.Size = new System.Drawing.Size(216, 28);
            this.lbl_activoAlCosto.TabIndex = 143;
            this.lbl_activoAlCosto.Text = "00000,00";
            this.lbl_activoAlCosto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label13.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label13.Location = new System.Drawing.Point(8, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 28);
            this.label13.TabIndex = 142;
            this.label13.Text = "Activo al Costo :";
            // 
            // lbl_activoAlPrecio
            // 
            this.lbl_activoAlPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_activoAlPrecio.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_activoAlPrecio.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_activoAlPrecio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_activoAlPrecio.Location = new System.Drawing.Point(8, 36);
            this.lbl_activoAlPrecio.Name = "lbl_activoAlPrecio";
            this.lbl_activoAlPrecio.Size = new System.Drawing.Size(216, 28);
            this.lbl_activoAlPrecio.TabIndex = 141;
            this.lbl_activoAlPrecio.Text = "00000,00";
            this.lbl_activoAlPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label12.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label12.Location = new System.Drawing.Point(8, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(216, 28);
            this.label12.TabIndex = 140;
            this.label12.Text = "Activo al precio:";
            // 
            // dgrid_objetos
            // 
            this.dgrid_objetos.AllowUserToAddRows = false;
            this.dgrid_objetos.AllowUserToDeleteRows = false;
            this.dgrid_objetos.AllowUserToResizeRows = false;
            this.dgrid_objetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgrid_objetos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_objetos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_objetos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_objetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_objetos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_objetos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_objetos.Location = new System.Drawing.Point(5, 5);
            this.dgrid_objetos.Margin = new System.Windows.Forms.Padding(3, 3, 3, 41);
            this.dgrid_objetos.Name = "dgrid_objetos";
            this.dgrid_objetos.ReadOnly = true;
            this.dgrid_objetos.RowHeadersVisible = false;
            this.dgrid_objetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_objetos.Size = new System.Drawing.Size(792, 514);
            this.dgrid_objetos.TabIndex = 27;
            this.dgrid_objetos.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgrid_objetos_ColumnHeaderMouseClick);
            this.dgrid_objetos.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgrid_objetos_DataBindingComplete);
            this.dgrid_objetos.Resize += new System.EventHandler(this.dgrid_objetos_Resize);
            // 
            // Frm_ctrlMercaderia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1049, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.p_derecho);
            this.Name = "Frm_ctrlMercaderia";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Control de mercaderia";
            this.Load += new System.EventHandler(this.Frm_ctrlMercaderia_Load);
            this.Shown += new System.EventHandler(this.Frm_ctrlMercaderia_Shown);
            this.p_derecho.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.p_buscador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_mercaderias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_objetos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel p_derecho;
        private System.Windows.Forms.Panel p_buscador;
        private System.Windows.Forms.Label lbl_utilidad;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_activoAlCosto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_activoAlPrecio;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label30;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bs_mercaderias;
        private System.Windows.Forms.DataGridView dgrid_objetos;
    }
}