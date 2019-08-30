namespace SIVS
{
    partial class Frm_confirmacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_confirmacion));
            this.lbl_argumento = new System.Windows.Forms.Label();
            this.btn_op3 = new CONTROLES.ButtonImages();
            this.pbtn = new System.Windows.Forms.Panel();
            this.btn_op1 = new CONTROLES.ButtonImages();
            this.btn_op2 = new CONTROLES.ButtonImages();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_importe = new CONTROLES.TextBox_Decimal();
            this.pbtn.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_argumento
            // 
            this.lbl_argumento.AutoSize = true;
            this.lbl_argumento.BackColor = System.Drawing.Color.Transparent;
            this.lbl_argumento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_argumento.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_argumento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_argumento.Location = new System.Drawing.Point(3, 25);
            this.lbl_argumento.Name = "lbl_argumento";
            this.lbl_argumento.Size = new System.Drawing.Size(303, 37);
            this.lbl_argumento.TabIndex = 5;
            this.lbl_argumento.Text = "aaaaaaaaaabbbbbbbbbbccccccccc";
            // 
            // btn_op3
            // 
            this.btn_op3.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_op3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_op3.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_op3.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_op3.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_op3.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_op3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_op3.FlatAppearance.BorderSize = 0;
            this.btn_op3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_op3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_op3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_op3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_op3.ImageEnableFalse = null;
            this.btn_op3.ImageOnMouseDown = null;
            this.btn_op3.ImageOnMouseEnter = null;
            this.btn_op3.ImageOnNothing = null;
            this.btn_op3.Location = new System.Drawing.Point(135, 7);
            this.btn_op3.Name = "btn_op3";
            this.btn_op3.Size = new System.Drawing.Size(110, 32);
            this.btn_op3.TabIndex = 6;
            this.btn_op3.Text = "Agregar";
            this.btn_op3.UseVisualStyleBackColor = false;
            this.btn_op3.Click += new System.EventHandler(this.btn_op3_Click);
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.btn_op1);
            this.pbtn.Controls.Add(this.btn_op2);
            this.pbtn.Controls.Add(this.btn_op3);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 80);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(489, 51);
            this.pbtn.TabIndex = 28;
            // 
            // btn_op1
            // 
            this.btn_op1.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_op1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_op1.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_op1.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_op1.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_op1.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_op1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_op1.FlatAppearance.BorderSize = 0;
            this.btn_op1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_op1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_op1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_op1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_op1.ImageEnableFalse = null;
            this.btn_op1.ImageOnMouseDown = null;
            this.btn_op1.ImageOnMouseEnter = null;
            this.btn_op1.ImageOnNothing = null;
            this.btn_op1.Location = new System.Drawing.Point(367, 7);
            this.btn_op1.Name = "btn_op1";
            this.btn_op1.Size = new System.Drawing.Size(110, 32);
            this.btn_op1.TabIndex = 8;
            this.btn_op1.Text = "Agregar";
            this.btn_op1.UseVisualStyleBackColor = false;
            this.btn_op1.Click += new System.EventHandler(this.btn_op1_Click);
            // 
            // btn_op2
            // 
            this.btn_op2.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_op2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_op2.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_op2.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_op2.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_op2.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_op2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_op2.FlatAppearance.BorderSize = 0;
            this.btn_op2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_op2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_op2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_op2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_op2.ImageEnableFalse = null;
            this.btn_op2.ImageOnMouseDown = null;
            this.btn_op2.ImageOnMouseEnter = null;
            this.btn_op2.ImageOnNothing = null;
            this.btn_op2.Location = new System.Drawing.Point(251, 7);
            this.btn_op2.Name = "btn_op2";
            this.btn_op2.Size = new System.Drawing.Size(110, 32);
            this.btn_op2.TabIndex = 6;
            this.btn_op2.Text = "Agregar";
            this.btn_op2.UseVisualStyleBackColor = false;
            this.btn_op2.Click += new System.EventHandler(this.btn_op2_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.lbl_argumento);
            this.flowLayoutPanel1.Controls.Add(this.txt_importe);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(489, 80);
            this.flowLayoutPanel1.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "                                                                                ";
            // 
            // txt_importe
            // 
            this.txt_importe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_importe.CantDecimales = 2;
            this.txt_importe.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_importe.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_importe.Location = new System.Drawing.Point(312, 28);
            this.txt_importe.MaxLength = 8;
            this.txt_importe.Name = "txt_importe";
            this.txt_importe.Size = new System.Drawing.Size(105, 31);
            this.txt_importe.TabIndex = 54;
            this.txt_importe.Text = "0";
            this.txt_importe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_importe.TextDefault = "0";
            this.txt_importe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_importe_KeyPress);
            // 
            // Frm_confirmacion
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
            this.Name = "Frm_confirmacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capcion";
            this.Activated += new System.EventHandler(this.Frm_confirmacion_Activated);
            this.Load += new System.EventHandler(this.Frm_confirmacion_Load);
            this.pbtn.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_argumento;
        protected CONTROLES.ButtonImages btn_op3;
        protected System.Windows.Forms.Panel pbtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        protected CONTROLES.ButtonImages btn_op1;
        protected CONTROLES.ButtonImages btn_op2;
        private CONTROLES.TextBox_Decimal txt_importe;
    }
}