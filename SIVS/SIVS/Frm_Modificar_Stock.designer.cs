namespace SIVS
{
    partial class Frm_Modificar_Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Modificar_Stock));
            this.cbb_articulo = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_articulo = new System.Windows.Forms.Panel();
            this.lbl_datos = new System.Windows.Forms.Label();
            this.btn_Modificar = new CONTROLES.ButtonImages();
            this.btn_Salir = new CONTROLES.ButtonImages();
            this.pbtn = new System.Windows.Forms.Panel();
            this.gb_articulo.SuspendLayout();
            this.pbtn.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_articulo
            // 
            this.cbb_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbb_articulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_articulo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.cbb_articulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cbb_articulo.FormattingEnabled = true;
            this.cbb_articulo.Location = new System.Drawing.Point(98, 22);
            this.cbb_articulo.Name = "cbb_articulo";
            this.cbb_articulo.Size = new System.Drawing.Size(560, 31);
            this.cbb_articulo.TabIndex = 0;
            this.cbb_articulo.SelectedIndexChanged += new System.EventHandler(this.cbb_articulo_SelectedIndexChanged);
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_codigo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_codigo.Location = new System.Drawing.Point(98, 59);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(210, 31);
            this.txt_codigo.TabIndex = 1;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress);
            // 
            // txt_stock
            // 
            this.txt_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.txt_stock.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_stock.Location = new System.Drawing.Point(462, 59);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(80, 31);
            this.txt_stock.TabIndex = 2;
            this.txt_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label6.Location = new System.Drawing.Point(15, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(592, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "y oprima el botón MODIFICAR o la tecla ENTER para realizar la modificación.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label5.Location = new System.Drawing.Point(15, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(653, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Una vez seleccionado el ARTÍCULO y SU CÓDIGO ingrese la ALTERACIÓN de STOCK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label4.Location = new System.Drawing.Point(13, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(416, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Para disminuir el stock ingrese un número negativo).";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label3.Location = new System.Drawing.Point(314, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Alteración Stock :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.label1.Location = new System.Drawing.Point(13, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artículo :";
            // 
            // gb_articulo
            // 
            this.gb_articulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_articulo.Controls.Add(this.lbl_datos);
            this.gb_articulo.Controls.Add(this.btn_Modificar);
            this.gb_articulo.Controls.Add(this.label6);
            this.gb_articulo.Controls.Add(this.cbb_articulo);
            this.gb_articulo.Controls.Add(this.label5);
            this.gb_articulo.Controls.Add(this.txt_codigo);
            this.gb_articulo.Controls.Add(this.label4);
            this.gb_articulo.Controls.Add(this.txt_stock);
            this.gb_articulo.Controls.Add(this.label3);
            this.gb_articulo.Controls.Add(this.label1);
            this.gb_articulo.Controls.Add(this.label2);
            this.gb_articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_articulo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gb_articulo.Location = new System.Drawing.Point(12, 12);
            this.gb_articulo.Name = "gb_articulo";
            this.gb_articulo.Size = new System.Drawing.Size(671, 212);
            this.gb_articulo.TabIndex = 31;
            // 
            // lbl_datos
            // 
            this.lbl_datos.AutoSize = true;
            this.lbl_datos.Font = new System.Drawing.Font("Segoe UI Light", 13F);
            this.lbl_datos.Location = new System.Drawing.Point(15, 122);
            this.lbl_datos.Name = "lbl_datos";
            this.lbl_datos.Size = new System.Drawing.Size(416, 25);
            this.lbl_datos.TabIndex = 34;
            this.lbl_datos.Text = "(Para disminuir el stock ingrese un número negativo).";
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Modificar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Modificar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Modificar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Modificar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_Modificar.BackgroundImage = global::SIVS.Properties.Resources.Edit;
            this.btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Modificar.FlatAppearance.BorderSize = 0;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Modificar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Modificar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Modificar.ImageEnableFalse = global::SIVS.Properties.Resources.Edit;
            this.btn_Modificar.ImageOnMouseDown = global::SIVS.Properties.Resources.Edit;
            this.btn_Modificar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Edit_flip30;
            this.btn_Modificar.ImageOnNothing = global::SIVS.Properties.Resources.Edit;
            this.btn_Modificar.Location = new System.Drawing.Point(548, 58);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(110, 32);
            this.btn_Modificar.TabIndex = 33;
            this.btn_Modificar.Text = "     Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Salir.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Salir.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Salir.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Salir.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(175)))), ((int)(((byte)(219)))));
            this.btn_Salir.BackgroundImage = global::SIVS.Properties.Resources.Login_door;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Salir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Salir.ImageEnableFalse = global::SIVS.Properties.Resources.Login_door;
            this.btn_Salir.ImageOnMouseDown = global::SIVS.Properties.Resources.Login_door;
            this.btn_Salir.ImageOnMouseEnter = global::SIVS.Properties.Resources.Login_door_flip30;
            this.btn_Salir.ImageOnNothing = global::SIVS.Properties.Resources.Login_door;
            this.btn_Salir.Location = new System.Drawing.Point(574, 7);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(110, 32);
            this.btn_Salir.TabIndex = 32;
            this.btn_Salir.Text = "    Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.btn_Salir);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 230);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(696, 45);
            this.pbtn.TabIndex = 33;
            // 
            // Frm_Modificar_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(696, 275);
            this.Controls.Add(this.pbtn);
            this.Controls.Add(this.gb_articulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Modificar_Stock";
            this.Text = "Administrar stock";
            this.Activated += new System.EventHandler(this.Frm_Modificar_Stock_Activated);
            this.Load += new System.EventHandler(this.Frm_Modificar_Stock_Load);
            this.gb_articulo.ResumeLayout(false);
            this.gb_articulo.PerformLayout();
            this.pbtn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_articulo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        protected System.Windows.Forms.Panel gb_articulo;
        protected CONTROLES.ButtonImages btn_Salir;
        protected System.Windows.Forms.Panel pbtn;
        protected CONTROLES.ButtonImages btn_Modificar;
        private System.Windows.Forms.Label lbl_datos;
    }
}