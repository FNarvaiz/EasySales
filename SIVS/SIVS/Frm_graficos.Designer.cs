namespace SIVS
{
    partial class Frm_graficos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.p_izquierdo = new System.Windows.Forms.Panel();
            this.p_interiorIzquierdo = new System.Windows.Forms.Panel();
            this.p_abajo = new System.Windows.Forms.Panel();
            this.cb_3d = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_graficos = new System.Windows.Forms.ComboBox();
            this.btn_guardar = new CONTROLES.ButtonImages();
            this.btn_cancelar = new CONTROLES.ButtonImages();
            this.c_generico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.p_izquierdo.SuspendLayout();
            this.p_interiorIzquierdo.SuspendLayout();
            this.p_abajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_generico)).BeginInit();
            this.SuspendLayout();
            // 
            // p_izquierdo
            // 
            this.p_izquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.p_izquierdo.Controls.Add(this.p_interiorIzquierdo);
            this.p_izquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_izquierdo.Location = new System.Drawing.Point(0, 0);
            this.p_izquierdo.Name = "p_izquierdo";
            this.p_izquierdo.Padding = new System.Windows.Forms.Padding(10);
            this.p_izquierdo.Size = new System.Drawing.Size(841, 269);
            this.p_izquierdo.TabIndex = 13;
            // 
            // p_interiorIzquierdo
            // 
            this.p_interiorIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_interiorIzquierdo.Controls.Add(this.c_generico);
            this.p_interiorIzquierdo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_interiorIzquierdo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_interiorIzquierdo.Location = new System.Drawing.Point(10, 10);
            this.p_interiorIzquierdo.Name = "p_interiorIzquierdo";
            this.p_interiorIzquierdo.Padding = new System.Windows.Forms.Padding(10);
            this.p_interiorIzquierdo.Size = new System.Drawing.Size(821, 249);
            this.p_interiorIzquierdo.TabIndex = 0;
            // 
            // p_abajo
            // 
            this.p_abajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_abajo.Controls.Add(this.cb_3d);
            this.p_abajo.Controls.Add(this.label1);
            this.p_abajo.Controls.Add(this.cb_graficos);
            this.p_abajo.Controls.Add(this.btn_guardar);
            this.p_abajo.Controls.Add(this.btn_cancelar);
            this.p_abajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.p_abajo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_abajo.Location = new System.Drawing.Point(0, 269);
            this.p_abajo.Name = "p_abajo";
            this.p_abajo.Padding = new System.Windows.Forms.Padding(10);
            this.p_abajo.Size = new System.Drawing.Size(841, 57);
            this.p_abajo.TabIndex = 12;
            // 
            // cb_3d
            // 
            this.cb_3d.AutoSize = true;
            this.cb_3d.BackColor = System.Drawing.Color.Transparent;
            this.cb_3d.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_3d.Location = new System.Drawing.Point(380, 15);
            this.cb_3d.Name = "cb_3d";
            this.cb_3d.Size = new System.Drawing.Size(52, 29);
            this.cb_3d.TabIndex = 255;
            this.cb_3d.Text = "3D";
            this.cb_3d.UseVisualStyleBackColor = false;
            this.cb_3d.Click += new System.EventHandler(this.cb_3d_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 25);
            this.label1.TabIndex = 254;
            this.label1.Text = "Tipo de gráfico:";
            // 
            // cb_graficos
            // 
            this.cb_graficos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_graficos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_graficos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_graficos.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.cb_graficos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_graficos.FormattingEnabled = true;
            this.cb_graficos.Items.AddRange(new object[] {
            "Torta",
            "Columnas",
            "Columnas superpuestas",
            "Barras",
            "Lineas rectas",
            "Lineas onduladas"});
            this.cb_graficos.Location = new System.Drawing.Point(151, 17);
            this.cb_graficos.Name = "cb_graficos";
            this.cb_graficos.Size = new System.Drawing.Size(213, 28);
            this.cb_graficos.TabIndex = 253;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.btn_guardar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_guardar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btn_guardar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(102)))), ((int)(((byte)(242)))));
            this.btn_guardar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.ImageEnableFalse = null;
            this.btn_guardar.ImageOnMouseDown = null;
            this.btn_guardar.ImageOnMouseEnter = null;
            this.btn_guardar.ImageOnNothing = null;
            this.btn_guardar.Location = new System.Drawing.Point(529, 13);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(186, 32);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "      Guardar Imagen";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.btn_cancelar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_cancelar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(53)))), ((int)(((byte)(101)))));
            this.btn_cancelar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(102)))), ((int)(((byte)(242)))));
            this.btn_cancelar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(70)))), ((int)(((byte)(134)))));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.ImageEnableFalse = null;
            this.btn_cancelar.ImageOnMouseDown = null;
            this.btn_cancelar.ImageOnMouseEnter = null;
            this.btn_cancelar.ImageOnNothing = null;
            this.btn_cancelar.Location = new System.Drawing.Point(721, 13);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "      Salir";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // c_generico
            // 
            chartArea3.Name = "ChartArea1";
            this.c_generico.ChartAreas.Add(chartArea3);
            this.c_generico.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.c_generico.Legends.Add(legend3);
            this.c_generico.Location = new System.Drawing.Point(10, 10);
            this.c_generico.Name = "c_generico";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.c_generico.Series.Add(series3);
            this.c_generico.Size = new System.Drawing.Size(801, 229);
            this.c_generico.TabIndex = 0;
            this.c_generico.Text = "chart1";
            // 
            // Frm_graficos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 326);
            this.Controls.Add(this.p_izquierdo);
            this.Controls.Add(this.p_abajo);
            this.Name = "Frm_graficos";
            this.Text = "Frm_graficos";
            this.Shown += new System.EventHandler(this.frm_grafico_Shown);
            this.p_izquierdo.ResumeLayout(false);
            this.p_interiorIzquierdo.ResumeLayout(false);
            this.p_abajo.ResumeLayout(false);
            this.p_abajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c_generico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel p_izquierdo;
        protected System.Windows.Forms.Panel p_interiorIzquierdo;
        protected System.Windows.Forms.Panel p_abajo;
        private System.Windows.Forms.CheckBox cb_3d;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.ComboBox cb_graficos;
        protected CONTROLES.ButtonImages btn_guardar;
        protected CONTROLES.ButtonImages btn_cancelar;
        private System.Windows.Forms.DataVisualization.Charting.Chart c_generico;
    }
}