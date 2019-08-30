namespace SIVS
{
    partial class Frm_Activacion
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
            this.pbtn = new System.Windows.Forms.Panel();
            this.btn_Soporte = new CONTROLES.ButtonImages();
            this.btn_Free = new CONTROLES.ButtonImages();
            this.btn_activacion = new CONTROLES.ButtonImages();
            this.lbl_argumento = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.pbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.btn_Soporte);
            this.pbtn.Controls.Add(this.btn_Free);
            this.pbtn.Controls.Add(this.btn_activacion);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 103);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(488, 51);
            this.pbtn.TabIndex = 29;
            // 
            // btn_Soporte
            // 
            this.btn_Soporte.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Soporte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Soporte.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Soporte.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Soporte.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Soporte.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Soporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Soporte.FlatAppearance.BorderSize = 0;
            this.btn_Soporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Soporte.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Soporte.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Soporte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Soporte.ImageEnableFalse = null;
            this.btn_Soporte.ImageOnMouseDown = null;
            this.btn_Soporte.ImageOnMouseEnter = null;
            this.btn_Soporte.ImageOnNothing = null;
            this.btn_Soporte.Location = new System.Drawing.Point(54, 7);
            this.btn_Soporte.Name = "btn_Soporte";
            this.btn_Soporte.Size = new System.Drawing.Size(110, 32);
            this.btn_Soporte.TabIndex = 9;
            this.btn_Soporte.Text = "Soporte";
            this.btn_Soporte.UseVisualStyleBackColor = false;
            this.btn_Soporte.Click += new System.EventHandler(this.btn_Soporte_Click);
            // 
            // btn_Free
            // 
            this.btn_Free.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Free.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Free.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Free.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Free.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Free.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Free.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Free.FlatAppearance.BorderSize = 0;
            this.btn_Free.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Free.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Free.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Free.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Free.ImageEnableFalse = null;
            this.btn_Free.ImageOnMouseDown = null;
            this.btn_Free.ImageOnMouseEnter = null;
            this.btn_Free.ImageOnNothing = null;
            this.btn_Free.Location = new System.Drawing.Point(286, 7);
            this.btn_Free.Name = "btn_Free";
            this.btn_Free.Size = new System.Drawing.Size(191, 32);
            this.btn_Free.TabIndex = 8;
            this.btn_Free.Text = "Usar versión free";
            this.btn_Free.UseVisualStyleBackColor = false;
            this.btn_Free.Click += new System.EventHandler(this.btn_Free_Click);
            // 
            // btn_activacion
            // 
            this.btn_activacion.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_activacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_activacion.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_activacion.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_activacion.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_activacion.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_activacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_activacion.FlatAppearance.BorderSize = 0;
            this.btn_activacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activacion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_activacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_activacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activacion.ImageEnableFalse = null;
            this.btn_activacion.ImageOnMouseDown = null;
            this.btn_activacion.ImageOnMouseEnter = null;
            this.btn_activacion.ImageOnNothing = null;
            this.btn_activacion.Location = new System.Drawing.Point(170, 7);
            this.btn_activacion.Name = "btn_activacion";
            this.btn_activacion.Size = new System.Drawing.Size(110, 32);
            this.btn_activacion.TabIndex = 6;
            this.btn_activacion.Text = "Activar";
            this.btn_activacion.UseVisualStyleBackColor = false;
            this.btn_activacion.Click += new System.EventHandler(this.btn_activacion_Click);
            // 
            // lbl_argumento
            // 
            this.lbl_argumento.AutoSize = true;
            this.lbl_argumento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_argumento.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_argumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_argumento.Location = new System.Drawing.Point(122, 9);
            this.lbl_argumento.Name = "lbl_argumento";
            this.lbl_argumento.Size = new System.Drawing.Size(254, 28);
            this.lbl_argumento.TabIndex = 55;
            this.lbl_argumento.Text = "Ingrese la clave de activación";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(12, 54);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(464, 29);
            this.txt_nombre.TabIndex = 57;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_Activacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(488, 154);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_argumento);
            this.Controls.Add(this.pbtn);
            this.Name = "Frm_Activacion";
            this.Text = "Activación de versiones";
            this.pbtn.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Panel pbtn;
        protected CONTROLES.ButtonImages btn_Free;
        protected CONTROLES.ButtonImages btn_activacion;
        private System.Windows.Forms.Label lbl_argumento;
        private System.Windows.Forms.TextBox txt_nombre;
        protected CONTROLES.ButtonImages btn_Soporte;
    }
}