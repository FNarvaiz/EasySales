namespace SIVS
{
    partial class Frm_Operacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Operacion));
            this.label2 = new System.Windows.Forms.Label();
            this.cb_registrar = new System.Windows.Forms.CheckBox();
            this.lbl_persona = new System.Windows.Forms.Label();
            this.cb_FormasPagos = new System.Windows.Forms.ComboBox();
            this.pn_abm = new System.Windows.Forms.Panel();
            this.txt_importe = new CONTROLES.TextBox_Decimal();
            this.cb_concepto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbtn = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new CONTROLES.ButtonImages();
            this.btn_Guardar = new CONTROLES.ButtonImages();
            this.bs_FormasPagos = new System.Windows.Forms.BindingSource(this.components);
            this.bs_conceptos = new System.Windows.Forms.BindingSource(this.components);
            this.pn_abm.SuspendLayout();
            this.pbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_FormasPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_conceptos)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 47;
            this.label2.Text = "Importe:  $";
            // 
            // cb_registrar
            // 
            this.cb_registrar.AutoSize = true;
            this.cb_registrar.BackColor = System.Drawing.Color.Transparent;
            this.cb_registrar.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_registrar.Location = new System.Drawing.Point(12, 115);
            this.cb_registrar.Name = "cb_registrar";
            this.cb_registrar.Size = new System.Drawing.Size(97, 29);
            this.cb_registrar.TabIndex = 60;
            this.cb_registrar.Text = "Registrar";
            this.cb_registrar.UseVisualStyleBackColor = false;
            this.cb_registrar.CheckedChanged += new System.EventHandler(this.cb_registrar_CheckedChanged);
            // 
            // lbl_persona
            // 
            this.lbl_persona.AutoSize = true;
            this.lbl_persona.BackColor = System.Drawing.Color.Transparent;
            this.lbl_persona.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_persona.Location = new System.Drawing.Point(7, 147);
            this.lbl_persona.Name = "lbl_persona";
            this.lbl_persona.Size = new System.Drawing.Size(16, 25);
            this.lbl_persona.TabIndex = 61;
            this.lbl_persona.Text = ".";
            // 
            // cb_FormasPagos
            // 
            this.cb_FormasPagos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_FormasPagos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_FormasPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_FormasPagos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_FormasPagos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_FormasPagos.FormattingEnabled = true;
            this.cb_FormasPagos.Location = new System.Drawing.Point(204, 74);
            this.cb_FormasPagos.Name = "cb_FormasPagos";
            this.cb_FormasPagos.Size = new System.Drawing.Size(164, 31);
            this.cb_FormasPagos.TabIndex = 64;
            // 
            // pn_abm
            // 
            this.pn_abm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_abm.Controls.Add(this.txt_importe);
            this.pn_abm.Controls.Add(this.cb_concepto);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.cb_FormasPagos);
            this.pn_abm.Controls.Add(this.lbl_persona);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Controls.Add(this.cb_registrar);
            this.pn_abm.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.pn_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_abm.Location = new System.Drawing.Point(12, 12);
            this.pn_abm.Name = "pn_abm";
            this.pn_abm.Size = new System.Drawing.Size(377, 192);
            this.pn_abm.TabIndex = 65;
            // 
            // txt_importe
            // 
            this.txt_importe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_importe.CantDecimales = 2;
            this.txt_importe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_importe.Location = new System.Drawing.Point(101, 74);
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(97, 31);
            this.txt_importe.TabIndex = 68;
            this.txt_importe.Text = "0";
            this.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_importe.TextDefault = "0";
            // 
            // cb_concepto
            // 
            this.cb_concepto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_concepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_concepto.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cb_concepto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_concepto.FormattingEnabled = true;
            this.cb_concepto.Location = new System.Drawing.Point(10, 32);
            this.cb_concepto.Name = "cb_concepto";
            this.cb_concepto.Size = new System.Drawing.Size(358, 31);
            this.cb_concepto.TabIndex = 67;
            this.cb_concepto.SelectedIndexChanged += new System.EventHandler(this.cb_concepto_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(5, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 66;
            this.label1.Text = "Concepto:";
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.btn_Cancelar);
            this.pbtn.Controls.Add(this.btn_Guardar);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 212);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(401, 51);
            this.pbtn.TabIndex = 68;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(279, 10);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "     Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Guardar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Guardar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Guardar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Guardar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Guardar.BackgroundImage = global::SIVS.Properties.Resources.Guardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Guardar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Guardar.ImageEnableFalse = global::SIVS.Properties.Resources.Guardar;
            this.btn_Guardar.ImageOnMouseDown = global::SIVS.Properties.Resources.Guardar;
            this.btn_Guardar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Guardar_flip30;
            this.btn_Guardar.ImageOnNothing = global::SIVS.Properties.Resources.Guardar;
            this.btn_Guardar.Location = new System.Drawing.Point(163, 10);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 32);
            this.btn_Guardar.TabIndex = 5;
            this.btn_Guardar.Text = "      Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // Frm_Operacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(401, 263);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.pn_abm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Operacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Operacion";
            this.Load += new System.EventHandler(this.Frm_Operacion_Load);
            this.Shown += new System.EventHandler(this.Frm_Operacion_Shown);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.pbtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bs_FormasPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_conceptos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_registrar;
        private System.Windows.Forms.Label lbl_persona;
        private System.Windows.Forms.ComboBox cb_FormasPagos;
        private System.Windows.Forms.BindingSource bs_FormasPagos;
        protected System.Windows.Forms.Panel pn_abm;
        protected System.Windows.Forms.Panel pbtn;
        protected CONTROLES.ButtonImages btn_Cancelar;
        protected CONTROLES.ButtonImages btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_concepto;
        private System.Windows.Forms.BindingSource bs_conceptos;
        private CONTROLES.TextBox_Decimal txt_importe;
    }
}