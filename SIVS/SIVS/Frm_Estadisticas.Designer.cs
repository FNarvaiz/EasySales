namespace SIVS
{
    partial class Frm_Estadisticas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Estadisticas));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_mostrarReferencias = new CONTROLES.ButtonImages();
            this.btn_Buscar = new CONTROLES.ButtonImages();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pn_abm = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgrid_EstadisticasArt = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_abm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_EstadisticasArt)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgrid_EstadisticasArt);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1248, 464);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_mostrarReferencias);
            this.panel1.Controls.Add(this.btn_Buscar);
            this.panel1.Controls.Add(this.dtp_hasta);
            this.panel1.Controls.Add(this.dtp_desde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 51);
            this.panel1.TabIndex = 63;
            // 
            // btn_mostrarReferencias
            // 
            this.btn_mostrarReferencias.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mostrarReferencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_mostrarReferencias.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_mostrarReferencias.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.btn_mostrarReferencias.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_mostrarReferencias.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_mostrarReferencias.BackgroundImage = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_mostrarReferencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_mostrarReferencias.FlatAppearance.BorderSize = 0;
            this.btn_mostrarReferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarReferencias.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_mostrarReferencias.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_mostrarReferencias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_mostrarReferencias.ImageEnableFalse = null;
            this.btn_mostrarReferencias.ImageOnMouseDown = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_mostrarReferencias.ImageOnMouseEnter = global::SIVS.Properties.Resources.VerBajas_32x32_flip;
            this.btn_mostrarReferencias.ImageOnNothing = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_mostrarReferencias.Location = new System.Drawing.Point(549, 9);
            this.btn_mostrarReferencias.Name = "btn_mostrarReferencias";
            this.btn_mostrarReferencias.Size = new System.Drawing.Size(206, 32);
            this.btn_mostrarReferencias.TabIndex = 79;
            this.btn_mostrarReferencias.Tag = "";
            this.btn_mostrarReferencias.Text = "       Mostrar Referencias";
            this.btn_mostrarReferencias.UseVisualStyleBackColor = false;
            this.btn_mostrarReferencias.Click += new System.EventHandler(this.btn_mostrarReferencias_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_Buscar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Buscar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(240)))), ((int)(((byte)(48)))));
            this.btn_Buscar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Buscar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_Buscar.BackgroundImage = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.ImageEnableFalse = null;
            this.btn_Buscar.ImageOnMouseDown = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_Buscar.ImageOnMouseEnter = global::SIVS.Properties.Resources.VerBajas_32x32_flip;
            this.btn_Buscar.ImageOnNothing = global::SIVS.Properties.Resources.VerBajas_32x32;
            this.btn_Buscar.Location = new System.Drawing.Point(336, 9);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(206, 32);
            this.btn_Buscar.TabIndex = 78;
            this.btn_Buscar.Tag = "";
            this.btn_Buscar.Text = "       Mostrar Estadísticas";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(230, 15);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(80, 20);
            this.dtp_hasta.TabIndex = 50;
            this.dtp_hasta.ValueChanged += new System.EventHandler(this.dtp_hasta_ValueChanged);
            // 
            // dtp_desde
            // 
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(78, 15);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(80, 20);
            this.dtp_desde.TabIndex = 49;
            this.dtp_desde.ValueChanged += new System.EventHandler(this.dtp_hasta_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(164, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Hasta :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Desde :";
            // 
            // pn_abm
            // 
            this.pn_abm.BackColor = System.Drawing.Color.Transparent;
            this.pn_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_abm.Controls.Add(this.label10);
            this.pn_abm.Controls.Add(this.label8);
            this.pn_abm.Controls.Add(this.label14);
            this.pn_abm.Controls.Add(this.label13);
            this.pn_abm.Controls.Add(this.label11);
            this.pn_abm.Controls.Add(this.label12);
            this.pn_abm.Controls.Add(this.label9);
            this.pn_abm.Controls.Add(this.label7);
            this.pn_abm.Controls.Add(this.label6);
            this.pn_abm.Controls.Add(this.label5);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.label3);
            this.pn_abm.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.pn_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_abm.Location = new System.Drawing.Point(12, 482);
            this.pn_abm.Name = "pn_abm";
            this.pn_abm.Size = new System.Drawing.Size(1248, 100);
            this.pn_abm.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label10.Location = new System.Drawing.Point(821, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(413, 25);
            this.label10.TabIndex = 89;
            this.label10.Text = "Costo total generado por la compra del producto.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(618, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 28);
            this.label8.TabIndex = 88;
            this.label8.Text = "Costos Soportados :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label14.Location = new System.Drawing.Point(209, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(415, 25);
            this.label14.TabIndex = 87;
            this.label14.Text = "Ganancia obtenida por la venta total del producto.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label13.Location = new System.Drawing.Point(209, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(437, 25);
            this.label13.TabIndex = 86;
            this.label13.Text = "Ganancia obtenida por la venta unitaria del producto.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(109, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 28);
            this.label11.TabIndex = 85;
            this.label11.Text = "Utilidad :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(51, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(152, 28);
            this.label12.TabIndex = 84;
            this.label12.Text = "Margen Bruto :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label9.Location = new System.Drawing.Point(209, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(399, 25);
            this.label9.TabIndex = 82;
            this.label9.Text = "Monto total obtenido por la venta del producto.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 28);
            this.label7.TabIndex = 80;
            this.label7.Text = "Ingreso por Ventas :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label6.Location = new System.Drawing.Point(821, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 25);
            this.label6.TabIndex = 79;
            this.label6.Text = "Rentabilidad sobre Costos.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label5.Location = new System.Drawing.Point(821, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 78;
            this.label5.Text = "Rentabilidad sobre Ventas.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(730, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 28);
            this.label2.TabIndex = 76;
            this.label2.Text = "RV (%) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(730, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 28);
            this.label3.TabIndex = 77;
            this.label3.Text = "RC (%) :";
            // 
            // dgrid_EstadisticasArt
            // 
            this.dgrid_EstadisticasArt.AllowUserToAddRows = false;
            this.dgrid_EstadisticasArt.AllowUserToDeleteRows = false;
            this.dgrid_EstadisticasArt.AllowUserToResizeRows = false;
            this.dgrid_EstadisticasArt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_EstadisticasArt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_EstadisticasArt.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_EstadisticasArt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_EstadisticasArt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_EstadisticasArt.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_EstadisticasArt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_EstadisticasArt.Location = new System.Drawing.Point(3, 70);
            this.dgrid_EstadisticasArt.MultiSelect = false;
            this.dgrid_EstadisticasArt.Name = "dgrid_EstadisticasArt";
            this.dgrid_EstadisticasArt.ReadOnly = true;
            this.dgrid_EstadisticasArt.RowHeadersVisible = false;
            this.dgrid_EstadisticasArt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_EstadisticasArt.Size = new System.Drawing.Size(1242, 391);
            this.dgrid_EstadisticasArt.TabIndex = 64;
            // 
            // Frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1276, 591);
            this.Controls.Add(this.pn_abm);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Estadisticas";
            this.Text = "Estadísticas , Utilidades y Rentabilidades por Producto";
            this.Load += new System.EventHandler(this.Frm_Estadisticas_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_EstadisticasArt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Panel pn_abm;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CONTROLES.ButtonImages btn_Buscar;
        private CONTROLES.ButtonImages btn_mostrarReferencias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgrid_EstadisticasArt;


    }
}