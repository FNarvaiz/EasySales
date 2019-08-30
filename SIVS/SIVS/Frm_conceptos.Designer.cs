namespace SIVS
{
    partial class Frm_conceptos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_conceptos));
            this.pbtn = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_argumento = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new CONTROLES.ButtonImages();
            this.btn_guardar = new CONTROLES.ButtonImages();
            this.pbtn.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.btn_cancelar);
            this.pbtn.Controls.Add(this.btn_guardar);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 80);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(489, 51);
            this.pbtn.TabIndex = 28;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lbl_argumento);
            this.flowLayoutPanel1.Controls.Add(this.txt_nombre);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 80);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // lbl_argumento
            // 
            this.lbl_argumento.AutoSize = true;
            this.lbl_argumento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_argumento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_argumento.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_argumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_argumento.Location = new System.Drawing.Point(13, 10);
            this.lbl_argumento.Name = "lbl_argumento";
            this.lbl_argumento.Size = new System.Drawing.Size(109, 28);
            this.lbl_argumento.TabIndex = 58;
            this.lbl_argumento.Text = "Descripción";
            // 
            // txt_nombre
            // 
            this.txt_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_nombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.txt_nombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_nombre.Location = new System.Drawing.Point(13, 41);
            this.txt_nombre.MaxLength = 100;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(464, 29);
            this.txt_nombre.TabIndex = 59;
            this.txt_nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_cancelar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_cancelar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_cancelar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_cancelar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
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
            this.btn_cancelar.Location = new System.Drawing.Point(367, 7);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_guardar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_guardar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_guardar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_guardar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
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
            this.btn_guardar.Location = new System.Drawing.Point(251, 7);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(110, 32);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Frm_conceptos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(489, 131);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_conceptos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conceptos";
            this.Load += new System.EventHandler(this.Frm_conceptos_Load);
            this.Shown += new System.EventHandler(this.Frm_conceptos_Shown);
            this.pbtn.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Panel pbtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        protected CONTROLES.ButtonImages btn_cancelar;
        protected CONTROLES.ButtonImages btn_guardar;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_argumento;
    }
}