namespace SIVS
{
    partial class Frm_Eleccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Eleccion));
            this.lbl_indicador = new System.Windows.Forms.Label();
            this.pn_abm = new System.Windows.Forms.Panel();
            this.dgrid_Generico = new System.Windows.Forms.DataGridView();
            this.lbl_cap = new System.Windows.Forms.Label();
            this.pn_abm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Generico)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_indicador
            // 
            this.lbl_indicador.AutoSize = true;
            this.lbl_indicador.BackColor = System.Drawing.Color.Transparent;
            this.lbl_indicador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_indicador.Font = new System.Drawing.Font("Segoe UI Light", 15F);
            this.lbl_indicador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_indicador.Location = new System.Drawing.Point(0, 234);
            this.lbl_indicador.Name = "lbl_indicador";
            this.lbl_indicador.Size = new System.Drawing.Size(242, 28);
            this.lbl_indicador.TabIndex = 25;
            this.lbl_indicador.Text = "Doble click para seleccionar";
            // 
            // pn_abm
            // 
            this.pn_abm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_abm.Controls.Add(this.dgrid_Generico);
            this.pn_abm.Controls.Add(this.lbl_cap);
            this.pn_abm.Controls.Add(this.lbl_indicador);
            this.pn_abm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_abm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pn_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_abm.Location = new System.Drawing.Point(0, 0);
            this.pn_abm.Name = "pn_abm";
            this.pn_abm.Size = new System.Drawing.Size(386, 262);
            this.pn_abm.TabIndex = 30;
            // 
            // dgrid_Generico
            // 
            this.dgrid_Generico.AllowUserToAddRows = false;
            this.dgrid_Generico.AllowUserToDeleteRows = false;
            this.dgrid_Generico.AllowUserToResizeRows = false;
            this.dgrid_Generico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_Generico.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_Generico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_Generico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_Generico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_Generico.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_Generico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrid_Generico.Location = new System.Drawing.Point(0, 32);
            this.dgrid_Generico.MultiSelect = false;
            this.dgrid_Generico.Name = "dgrid_Generico";
            this.dgrid_Generico.ReadOnly = true;
            this.dgrid_Generico.RowHeadersVisible = false;
            this.dgrid_Generico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_Generico.Size = new System.Drawing.Size(386, 202);
            this.dgrid_Generico.TabIndex = 76;
            this.dgrid_Generico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgrid_Generico_KeyDown);
            this.dgrid_Generico.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_FPagos_MouseDoubleClick);
            // 
            // lbl_cap
            // 
            this.lbl_cap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_cap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_cap.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_cap.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_cap.Location = new System.Drawing.Point(0, 0);
            this.lbl_cap.Name = "lbl_cap";
            this.lbl_cap.Size = new System.Drawing.Size(386, 32);
            this.lbl_cap.TabIndex = 3;
            this.lbl_cap.Text = "Gastos";
            // 
            // Frm_Eleccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(386, 262);
            this.Controls.Add(this.pn_abm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_Eleccion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capcion";
            this.Load += new System.EventHandler(this.Frm_Eleccion_Load);
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_Generico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_indicador;
        protected System.Windows.Forms.Panel pn_abm;
        private System.Windows.Forms.Label lbl_cap;
        private System.Windows.Forms.DataGridView dgrid_Generico;

    }
}