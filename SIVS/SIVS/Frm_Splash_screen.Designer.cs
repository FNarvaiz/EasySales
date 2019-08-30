namespace SIVS
{
    partial class Frm_Splash_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Splash_screen));
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_indicador = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(0, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(438, 21);
            this.label5.TabIndex = 99;
            this.label5.Text = "EasySoft Copyright © 2012 Todos los derechos reservados";
            // 
            // lbl_indicador
            // 
            this.lbl_indicador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_indicador.Font = new System.Drawing.Font("Segoe UI Semibold", 15F);
            this.lbl_indicador.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_indicador.Location = new System.Drawing.Point(0, 358);
            this.lbl_indicador.Name = "lbl_indicador";
            this.lbl_indicador.Size = new System.Drawing.Size(801, 51);
            this.lbl_indicador.TabIndex = 100;
            this.lbl_indicador.Text = ".";
            this.lbl_indicador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Splash_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::SIVS.Properties.Resources.EASYSALES_publicidad;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(801, 456);
            this.Controls.Add(this.lbl_indicador);
            this.Controls.Add(this.label5);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Splash_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasySoft GT";
            this.Load += new System.EventHandler(this.Frm_Splash_screen_Load);
            this.Shown += new System.EventHandler(this.Frm_Splash_screen_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_indicador;
    }
}