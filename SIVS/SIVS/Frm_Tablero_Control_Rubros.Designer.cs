namespace SIVS
{
    partial class Frm_Tablero_Control_Rubros
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_BuscarRubro = new CONTROLES.ButtonImages();
            this.dgrid_MontoVentasPorRubro = new System.Windows.Forms.DataGridView();
            this.label29 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_monto_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_monto_hasta = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgrid_CantArtiPorRubro = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_CantRubros = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_MontoVentasPorRubro)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CantArtiPorRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.btn_BuscarRubro);
            this.panel4.Controls.Add(this.dgrid_MontoVentasPorRubro);
            this.panel4.Controls.Add(this.label29);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.dtp_monto_desde);
            this.panel4.Controls.Add(this.dtp_monto_hasta);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 496);
            this.panel4.TabIndex = 126;
            // 
            // btn_BuscarRubro
            // 
            this.btn_BuscarRubro.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_BuscarRubro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_BuscarRubro.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_BuscarRubro.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_BuscarRubro.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_BuscarRubro.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_BuscarRubro.BackgroundImage = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_BuscarRubro.FlatAppearance.BorderSize = 0;
            this.btn_BuscarRubro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_BuscarRubro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_BuscarRubro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_BuscarRubro.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarRubro.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarRubro.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_BuscarRubro.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_BuscarRubro.Location = new System.Drawing.Point(389, 43);
            this.btn_BuscarRubro.Name = "btn_BuscarRubro";
            this.btn_BuscarRubro.Size = new System.Drawing.Size(110, 32);
            this.btn_BuscarRubro.TabIndex = 143;
            this.btn_BuscarRubro.Text = "      Buscar";
            this.btn_BuscarRubro.UseVisualStyleBackColor = false;
            this.btn_BuscarRubro.Click += new System.EventHandler(this.btn_BuscarRubro_Click);
            // 
            // dgrid_MontoVentasPorRubro
            // 
            this.dgrid_MontoVentasPorRubro.AllowUserToAddRows = false;
            this.dgrid_MontoVentasPorRubro.AllowUserToDeleteRows = false;
            this.dgrid_MontoVentasPorRubro.AllowUserToResizeRows = false;
            this.dgrid_MontoVentasPorRubro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_MontoVentasPorRubro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_MontoVentasPorRubro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_MontoVentasPorRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_MontoVentasPorRubro.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_MontoVentasPorRubro.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgrid_MontoVentasPorRubro.Location = new System.Drawing.Point(0, 99);
            this.dgrid_MontoVentasPorRubro.MultiSelect = false;
            this.dgrid_MontoVentasPorRubro.Name = "dgrid_MontoVentasPorRubro";
            this.dgrid_MontoVentasPorRubro.ReadOnly = true;
            this.dgrid_MontoVentasPorRubro.RowHeadersVisible = false;
            this.dgrid_MontoVentasPorRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_MontoVentasPorRubro.Size = new System.Drawing.Size(512, 397);
            this.dgrid_MontoVentasPorRubro.TabIndex = 73;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label29.Dock = System.Windows.Forms.DockStyle.Top;
            this.label29.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label29.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label29.Location = new System.Drawing.Point(0, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(512, 32);
            this.label29.TabIndex = 58;
            this.label29.Text = "Montos de ventas por rubro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 28);
            this.label4.TabIndex = 47;
            this.label4.Text = "Desde :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(194, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 48;
            this.label1.Text = "Hasta :";
            // 
            // dtp_monto_desde
            // 
            this.dtp_monto_desde.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_monto_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_monto_desde.Location = new System.Drawing.Point(77, 43);
            this.dtp_monto_desde.Name = "dtp_monto_desde";
            this.dtp_monto_desde.Size = new System.Drawing.Size(111, 31);
            this.dtp_monto_desde.TabIndex = 28;
            // 
            // dtp_monto_hasta
            // 
            this.dtp_monto_hasta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_monto_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_monto_hasta.Location = new System.Drawing.Point(269, 43);
            this.dtp_monto_hasta.Name = "dtp_monto_hasta";
            this.dtp_monto_hasta.Size = new System.Drawing.Size(111, 31);
            this.dtp_monto_hasta.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.dgrid_CantArtiPorRubro);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_CantRubros);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(521, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 496);
            this.panel1.TabIndex = 127;
            // 
            // dgrid_CantArtiPorRubro
            // 
            this.dgrid_CantArtiPorRubro.AllowUserToAddRows = false;
            this.dgrid_CantArtiPorRubro.AllowUserToDeleteRows = false;
            this.dgrid_CantArtiPorRubro.AllowUserToResizeRows = false;
            this.dgrid_CantArtiPorRubro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_CantArtiPorRubro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_CantArtiPorRubro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_CantArtiPorRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_CantArtiPorRubro.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_CantArtiPorRubro.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_CantArtiPorRubro.Location = new System.Drawing.Point(0, 32);
            this.dgrid_CantArtiPorRubro.MultiSelect = false;
            this.dgrid_CantArtiPorRubro.Name = "dgrid_CantArtiPorRubro";
            this.dgrid_CantArtiPorRubro.ReadOnly = true;
            this.dgrid_CantArtiPorRubro.RowHeadersVisible = false;
            this.dgrid_CantArtiPorRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_CantArtiPorRubro.Size = new System.Drawing.Size(373, 411);
            this.dgrid_CantArtiPorRubro.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 32);
            this.label3.TabIndex = 58;
            this.label3.Text = "Cantidad de artículos por rubro";
            // 
            // lbl_CantRubros
            // 
            this.lbl_CantRubros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_CantRubros.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_CantRubros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_CantRubros.Location = new System.Drawing.Point(277, 449);
            this.lbl_CantRubros.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_CantRubros.Name = "lbl_CantRubros";
            this.lbl_CantRubros.Size = new System.Drawing.Size(89, 39);
            this.lbl_CantRubros.TabIndex = 126;
            this.lbl_CantRubros.Text = "0";
            this.lbl_CantRubros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(5, 454);
            this.label9.Margin = new System.Windows.Forms.Padding(5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 28);
            this.label9.TabIndex = 125;
            this.label9.Text = "Cantidad de rubros cargados :";
            // 
            // Frm_Tablero_Control_Rubros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(894, 496);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Frm_Tablero_Control_Rubros";
            this.Text = "Control de rubros";
            this.Load += new System.EventHandler(this.Frm_Tablero_Control_Rubros_Load);
            this.Shown += new System.EventHandler(this.Frm_Tablero_Control_Rubros_Shown);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_MontoVentasPorRubro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_CantArtiPorRubro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel4;
        protected CONTROLES.ButtonImages btn_BuscarRubro;
        private System.Windows.Forms.DataGridView dgrid_MontoVentasPorRubro;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_monto_desde;
        private System.Windows.Forms.DateTimePicker dtp_monto_hasta;
        protected System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgrid_CantArtiPorRubro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_CantRubros;
        private System.Windows.Forms.Label label9;
    }
}