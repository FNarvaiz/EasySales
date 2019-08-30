namespace SIVS
{
    partial class Frm_Tablero_Control_Formas_Pago
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Tablero_Control_Formas_Pago));
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_Buscar = new CONTROLES.ButtonImages();
            this.dgrid_RankFormasPago = new System.Windows.Forms.DataGridView();
            this.label27 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtp_formaPago_desde = new System.Windows.Forms.DateTimePicker();
            this.dtp_formaPago_hasta = new System.Windows.Forms.DateTimePicker();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_RankFormasPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.btn_Buscar);
            this.panel5.Controls.Add(this.dgrid_RankFormasPago);
            this.panel5.Controls.Add(this.label27);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.dtp_formaPago_desde);
            this.panel5.Controls.Add(this.dtp_formaPago_hasta);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(539, 377);
            this.panel5.TabIndex = 126;
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Buscar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Buscar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Buscar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Buscar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Buscar.BackgroundImage = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Buscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Buscar.ImageEnableFalse = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.ImageOnMouseDown = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.ImageOnMouseEnter = global::SIVS.Properties.Resources.buscar_32_flip;
            this.btn_Buscar.ImageOnNothing = global::SIVS.Properties.Resources.buscar_32;
            this.btn_Buscar.Location = new System.Drawing.Point(419, 42);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(110, 32);
            this.btn_Buscar.TabIndex = 143;
            this.btn_Buscar.Text = "      Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // dgrid_RankFormasPago
            // 
            this.dgrid_RankFormasPago.AllowUserToAddRows = false;
            this.dgrid_RankFormasPago.AllowUserToDeleteRows = false;
            this.dgrid_RankFormasPago.AllowUserToResizeRows = false;
            this.dgrid_RankFormasPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_RankFormasPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_RankFormasPago.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_RankFormasPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_RankFormasPago.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_RankFormasPago.Location = new System.Drawing.Point(10, 84);
            this.dgrid_RankFormasPago.MultiSelect = false;
            this.dgrid_RankFormasPago.Name = "dgrid_RankFormasPago";
            this.dgrid_RankFormasPago.ReadOnly = true;
            this.dgrid_RankFormasPago.RowHeadersVisible = false;
            this.dgrid_RankFormasPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_RankFormasPago.Size = new System.Drawing.Size(519, 285);
            this.dgrid_RankFormasPago.TabIndex = 72;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label27.Dock = System.Windows.Forms.DockStyle.Top;
            this.label27.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label27.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label27.Location = new System.Drawing.Point(0, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(539, 32);
            this.label27.TabIndex = 58;
            this.label27.Text = "Ranking Formas de Pago";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(5, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Desde :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(209, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 25);
            this.label7.TabIndex = 50;
            this.label7.Text = "Hasta :";
            // 
            // dtp_formaPago_desde
            // 
            this.dtp_formaPago_desde.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_formaPago_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_formaPago_desde.Location = new System.Drawing.Point(79, 40);
            this.dtp_formaPago_desde.Name = "dtp_formaPago_desde";
            this.dtp_formaPago_desde.Size = new System.Drawing.Size(111, 31);
            this.dtp_formaPago_desde.TabIndex = 28;
            // 
            // dtp_formaPago_hasta
            // 
            this.dtp_formaPago_hasta.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.dtp_formaPago_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_formaPago_hasta.Location = new System.Drawing.Point(278, 40);
            this.dtp_formaPago_hasta.Name = "dtp_formaPago_hasta";
            this.dtp_formaPago_hasta.Size = new System.Drawing.Size(111, 31);
            this.dtp_formaPago_hasta.TabIndex = 29;
            // 
            // Frm_Tablero_Control_Formas_Pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(539, 377);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Tablero_Control_Formas_Pago";
            this.Text = "Control de formas pagos";
            this.Load += new System.EventHandler(this.Frm_Tablero_Control_Formas_Pago_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_RankFormasPago)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgrid_RankFormasPago;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_formaPago_desde;
        private System.Windows.Forms.DateTimePicker dtp_formaPago_hasta;
        protected CONTROLES.ButtonImages btn_Buscar;
    }
}