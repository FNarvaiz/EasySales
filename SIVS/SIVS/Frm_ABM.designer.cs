namespace SIVS
{
    partial class Frm_ABM
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ABM));
            this.pn_abm = new System.Windows.Forms.Panel();
            this.pbtn = new System.Windows.Forms.Panel();
            this.pn_btnABM = new System.Windows.Forms.Panel();
            this.pn_btnSalir = new System.Windows.Forms.Panel();
            this.btn_Salir = new CONTROLES.ButtonImages();
            this.btn_Agregar = new CONTROLES.ButtonImages();
            this.btn_Modificar = new CONTROLES.ButtonImages();
            this.btn_Eliminar = new CONTROLES.ButtonImages();
            this.pn_btnDerechos = new System.Windows.Forms.Panel();
            this.btn_Guardar = new CONTROLES.ButtonImages();
            this.btn_Cancelar = new CONTROLES.ButtonImages();
            this.gb_abm = new System.Windows.Forms.Panel();
            this.p_arriba = new System.Windows.Forms.Panel();
            this.p_derecho = new System.Windows.Forms.Panel();
            this.tt_mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.pbtn.SuspendLayout();
            this.pn_btnABM.SuspendLayout();
            this.pn_btnSalir.SuspendLayout();
            this.pn_btnDerechos.SuspendLayout();
            this.p_arriba.SuspendLayout();
            this.p_derecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_abm
            // 
            this.pn_abm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_abm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_abm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_abm.Location = new System.Drawing.Point(8, 0);
            this.pn_abm.Name = "pn_abm";
            this.pn_abm.Size = new System.Drawing.Size(240, 331);
            this.pn_abm.TabIndex = 29;
            // 
            // pbtn
            // 
            this.pbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbtn.Controls.Add(this.pn_btnABM);
            this.pbtn.Controls.Add(this.pn_btnDerechos);
            this.pbtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbtn.Location = new System.Drawing.Point(0, 347);
            this.pbtn.Name = "pbtn";
            this.pbtn.Size = new System.Drawing.Size(728, 51);
            this.pbtn.TabIndex = 27;
            // 
            // pn_btnABM
            // 
            this.pn_btnABM.Controls.Add(this.pn_btnSalir);
            this.pn_btnABM.Controls.Add(this.btn_Agregar);
            this.pn_btnABM.Controls.Add(this.btn_Modificar);
            this.pn_btnABM.Controls.Add(this.btn_Eliminar);
            this.pn_btnABM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_btnABM.Location = new System.Drawing.Point(0, 0);
            this.pn_btnABM.Name = "pn_btnABM";
            this.pn_btnABM.Size = new System.Drawing.Size(472, 51);
            this.pn_btnABM.TabIndex = 7;
            // 
            // pn_btnSalir
            // 
            this.pn_btnSalir.Controls.Add(this.btn_Salir);
            this.pn_btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_btnSalir.Location = new System.Drawing.Point(353, 0);
            this.pn_btnSalir.Name = "pn_btnSalir";
            this.pn_btnSalir.Size = new System.Drawing.Size(119, 51);
            this.pn_btnSalir.TabIndex = 6;
            // 
            // btn_Salir
            // 
            this.btn_Salir.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Salir.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Salir.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Salir.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Salir.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
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
            this.btn_Salir.Location = new System.Drawing.Point(3, 10);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(110, 32);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "    Salir";
            this.tt_mensaje.SetToolTip(this.btn_Salir, "F4");
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Agregar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Agregar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Agregar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Agregar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Agregar.BackgroundImage = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Agregar.FlatAppearance.BorderSize = 0;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Agregar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_Agregar.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_Agregar.Location = new System.Drawing.Point(8, 10);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(110, 32);
            this.btn_Agregar.TabIndex = 0;
            this.btn_Agregar.Text = "      Nuevo";
            this.tt_mensaje.SetToolTip(this.btn_Agregar, "F1");
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Modificar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Modificar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Modificar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Modificar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
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
            this.btn_Modificar.Location = new System.Drawing.Point(124, 10);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(110, 32);
            this.btn_Modificar.TabIndex = 1;
            this.btn_Modificar.Text = "     Modificar";
            this.tt_mensaje.SetToolTip(this.btn_Modificar, "F2");
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Eliminar.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_Eliminar.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_Eliminar.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_Eliminar.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_Eliminar.BackgroundImage = global::SIVS.Properties.Resources.Delete;
            this.btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.ImageEnableFalse = global::SIVS.Properties.Resources.Delete;
            this.btn_Eliminar.ImageOnMouseDown = global::SIVS.Properties.Resources.Delete;
            this.btn_Eliminar.ImageOnMouseEnter = global::SIVS.Properties.Resources.Delete_flip30;
            this.btn_Eliminar.ImageOnNothing = global::SIVS.Properties.Resources.Delete;
            this.btn_Eliminar.Location = new System.Drawing.Point(240, 10);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(110, 32);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "      Eliminar";
            this.tt_mensaje.SetToolTip(this.btn_Eliminar, "F3");
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // pn_btnDerechos
            // 
            this.pn_btnDerechos.Controls.Add(this.btn_Guardar);
            this.pn_btnDerechos.Controls.Add(this.btn_Cancelar);
            this.pn_btnDerechos.Dock = System.Windows.Forms.DockStyle.Right;
            this.pn_btnDerechos.Location = new System.Drawing.Point(472, 0);
            this.pn_btnDerechos.Name = "pn_btnDerechos";
            this.pn_btnDerechos.Size = new System.Drawing.Size(256, 51);
            this.pn_btnDerechos.TabIndex = 6;
            this.pn_btnDerechos.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_btnDerechos_Paint);
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
            this.btn_Guardar.Location = new System.Drawing.Point(15, 10);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(110, 32);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.Text = "      Guardar";
            this.tt_mensaje.SetToolTip(this.btn_Guardar, "F7");
            this.btn_Guardar.UseVisualStyleBackColor = false;
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
            this.btn_Cancelar.Location = new System.Drawing.Point(131, 10);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(110, 32);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "     Cancelar";
            this.tt_mensaje.SetToolTip(this.btn_Cancelar, "F8");
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // gb_abm
            // 
            this.gb_abm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_abm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_abm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gb_abm.Location = new System.Drawing.Point(8, 8);
            this.gb_abm.Name = "gb_abm";
            this.gb_abm.Size = new System.Drawing.Size(464, 331);
            this.gb_abm.TabIndex = 30;
            // 
            // p_arriba
            // 
            this.p_arriba.Controls.Add(this.gb_abm);
            this.p_arriba.Controls.Add(this.p_derecho);
            this.p_arriba.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p_arriba.Location = new System.Drawing.Point(0, 0);
            this.p_arriba.Name = "p_arriba";
            this.p_arriba.Padding = new System.Windows.Forms.Padding(8);
            this.p_arriba.Size = new System.Drawing.Size(728, 347);
            this.p_arriba.TabIndex = 31;
            // 
            // p_derecho
            // 
            this.p_derecho.Controls.Add(this.pn_abm);
            this.p_derecho.Dock = System.Windows.Forms.DockStyle.Right;
            this.p_derecho.Location = new System.Drawing.Point(472, 8);
            this.p_derecho.Name = "p_derecho";
            this.p_derecho.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.p_derecho.Size = new System.Drawing.Size(248, 331);
            this.p_derecho.TabIndex = 31;
            // 
            // Frm_ABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(728, 398);
            this.Controls.Add(this.p_arriba);
            this.Controls.Add(this.pbtn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Frm_ABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_ABM_KeyDown);
            this.pbtn.ResumeLayout(false);
            this.pn_btnABM.ResumeLayout(false);
            this.pn_btnSalir.ResumeLayout(false);
            this.pn_btnDerechos.ResumeLayout(false);
            this.p_arriba.ResumeLayout(false);
            this.p_derecho.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        protected CONTROLES.ButtonImages btn_Salir;
        protected CONTROLES.ButtonImages btn_Cancelar;
        protected CONTROLES.ButtonImages btn_Guardar;
        protected CONTROLES.ButtonImages btn_Eliminar;
        protected CONTROLES.ButtonImages btn_Modificar;
        protected CONTROLES.ButtonImages btn_Agregar;
        protected System.Windows.Forms.Panel pbtn;
        protected System.Windows.Forms.Panel pn_abm;
        protected System.Windows.Forms.Panel gb_abm;
        protected System.Windows.Forms.Panel p_arriba;
        protected System.Windows.Forms.Panel p_derecho;
        protected System.Windows.Forms.Panel pn_btnDerechos;
        protected System.Windows.Forms.Panel pn_btnABM;
        protected System.Windows.Forms.Panel pn_btnSalir;
        protected System.Windows.Forms.ToolTip tt_mensaje;


    }
}

