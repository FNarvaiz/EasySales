namespace SIVS
{
    partial class Frm_caja_diaria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_caja_diaria));
            this.dgrid_ventas = new System.Windows.Forms.DataGridView();
            this.bs_gastos = new System.Windows.Forms.BindingSource(this.components);
            this.bs_cobros = new System.Windows.Forms.BindingSource(this.components);
            this.bs_ventas = new System.Windows.Forms.BindingSource(this.components);
            this.tt_indicador = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.pn_abm = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_Ganancia = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Vtotal = new System.Windows.Forms.Label();
            this.lbl_Votros = new System.Windows.Forms.Label();
            this.lbl_Cobros = new System.Windows.Forms.Label();
            this.lbl_Gastos = new System.Windows.Forms.Label();
            this.lbl_Vefectivo = new System.Windows.Forms.Label();
            this.lbl_EfecFinal = new System.Windows.Forms.Label();
            this.lbl_EfecInicial = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EliminarGasto = new CONTROLES.ButtonImages();
            this.btn_ModificarGasto = new CONTROLES.ButtonImages();
            this.btn_AgregarGasto = new CONTROLES.ButtonImages();
            this.btn_EliminarCobro = new CONTROLES.ButtonImages();
            this.btn_ModificarCobro = new CONTROLES.ButtonImages();
            this.btn_AgregarCobro = new CONTROLES.ButtonImages();
            this.gb_ventas = new System.Windows.Forms.Panel();
            this.btn_Salir = new CONTROLES.ButtonImages();
            this.label15 = new System.Windows.Forms.Label();
            this.p_gastos = new System.Windows.Forms.Panel();
            this.dgrid_gastos = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.p_cobros = new System.Windows.Forms.Panel();
            this.dgrid_cobros = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ventas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gastos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cobros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ventas)).BeginInit();
            this.pn_abm.SuspendLayout();
            this.gb_ventas.SuspendLayout();
            this.p_gastos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_gastos)).BeginInit();
            this.p_cobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cobros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrid_ventas
            // 
            this.dgrid_ventas.AllowUserToAddRows = false;
            this.dgrid_ventas.AllowUserToDeleteRows = false;
            this.dgrid_ventas.AllowUserToResizeRows = false;
            this.dgrid_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_ventas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_ventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgrid_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_ventas.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgrid_ventas.Location = new System.Drawing.Point(0, 32);
            this.dgrid_ventas.MultiSelect = false;
            this.dgrid_ventas.Name = "dgrid_ventas";
            this.dgrid_ventas.ReadOnly = true;
            this.dgrid_ventas.RowHeadersVisible = false;
            this.dgrid_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_ventas.Size = new System.Drawing.Size(1003, 138);
            this.dgrid_ventas.TabIndex = 71;
            this.dgrid_ventas.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgrid_ventas_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label4.Location = new System.Drawing.Point(5, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Ventas otros :";
            this.tt_indicador.SetToolTip(this.label4, "CtaCte , Tarjeta, Etc. ");
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label21.Location = new System.Drawing.Point(5, 235);
            this.label21.Margin = new System.Windows.Forms.Padding(3);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(121, 32);
            this.label21.TabIndex = 103;
            this.label21.Text = "Ganancia :";
            this.tt_indicador.SetToolTip(this.label21, "GANANCIA SOBRE COSTO");
            // 
            // pn_abm
            // 
            this.pn_abm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pn_abm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pn_abm.Controls.Add(this.label19);
            this.pn_abm.Controls.Add(this.lbl_Ganancia);
            this.pn_abm.Controls.Add(this.label21);
            this.pn_abm.Controls.Add(this.label18);
            this.pn_abm.Controls.Add(this.label14);
            this.pn_abm.Controls.Add(this.label12);
            this.pn_abm.Controls.Add(this.label13);
            this.pn_abm.Controls.Add(this.label10);
            this.pn_abm.Controls.Add(this.label11);
            this.pn_abm.Controls.Add(this.label9);
            this.pn_abm.Controls.Add(this.label8);
            this.pn_abm.Controls.Add(this.lbl_Vtotal);
            this.pn_abm.Controls.Add(this.lbl_Votros);
            this.pn_abm.Controls.Add(this.lbl_Cobros);
            this.pn_abm.Controls.Add(this.lbl_Gastos);
            this.pn_abm.Controls.Add(this.lbl_Vefectivo);
            this.pn_abm.Controls.Add(this.lbl_EfecFinal);
            this.pn_abm.Controls.Add(this.lbl_EfecInicial);
            this.pn_abm.Controls.Add(this.label7);
            this.pn_abm.Controls.Add(this.label1);
            this.pn_abm.Controls.Add(this.label6);
            this.pn_abm.Controls.Add(this.label5);
            this.pn_abm.Controls.Add(this.label4);
            this.pn_abm.Controls.Add(this.label3);
            this.pn_abm.Controls.Add(this.label2);
            this.pn_abm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_abm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pn_abm.Location = new System.Drawing.Point(7, 8);
            this.pn_abm.Name = "pn_abm";
            this.pn_abm.Size = new System.Drawing.Size(267, 313);
            this.pn_abm.TabIndex = 76;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label19.Location = new System.Drawing.Point(125, 236);
            this.label19.Margin = new System.Windows.Forms.Padding(3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 32);
            this.label19.TabIndex = 105;
            this.label19.Text = "$";
            // 
            // lbl_Ganancia
            // 
            this.lbl_Ganancia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Ganancia.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.lbl_Ganancia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.lbl_Ganancia.Location = new System.Drawing.Point(158, 235);
            this.lbl_Ganancia.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Ganancia.Name = "lbl_Ganancia";
            this.lbl_Ganancia.Size = new System.Drawing.Size(105, 29);
            this.lbl_Ganancia.TabIndex = 104;
            this.lbl_Ganancia.Text = "0000,00";
            this.lbl_Ganancia.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label18.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(267, 32);
            this.label18.TabIndex = 102;
            this.label18.Text = "Registros";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label14.Location = new System.Drawing.Point(110, 273);
            this.label14.Margin = new System.Windows.Forms.Padding(3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 32);
            this.label14.TabIndex = 101;
            this.label14.Text = "$";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label12.Location = new System.Drawing.Point(147, 39);
            this.label12.Margin = new System.Windows.Forms.Padding(3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 25);
            this.label12.TabIndex = 100;
            this.label12.Text = "$";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label13.Location = new System.Drawing.Point(147, 66);
            this.label13.Margin = new System.Windows.Forms.Padding(3);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 25);
            this.label13.TabIndex = 99;
            this.label13.Text = "$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label10.Location = new System.Drawing.Point(147, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 25);
            this.label10.TabIndex = 98;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label11.Location = new System.Drawing.Point(147, 127);
            this.label11.Margin = new System.Windows.Forms.Padding(3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 25);
            this.label11.TabIndex = 97;
            this.label11.Text = "$";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label9.Location = new System.Drawing.Point(147, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 25);
            this.label9.TabIndex = 96;
            this.label9.Text = "$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label8.Location = new System.Drawing.Point(147, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 25);
            this.label8.TabIndex = 95;
            this.label8.Text = "$";
            // 
            // lbl_Vtotal
            // 
            this.lbl_Vtotal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vtotal.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Vtotal.Location = new System.Drawing.Point(165, 127);
            this.lbl_Vtotal.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Vtotal.Name = "lbl_Vtotal";
            this.lbl_Vtotal.Size = new System.Drawing.Size(88, 29);
            this.lbl_Vtotal.TabIndex = 93;
            this.lbl_Vtotal.Text = "0000,00";
            this.lbl_Vtotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Votros
            // 
            this.lbl_Votros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Votros.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Votros.Location = new System.Drawing.Point(165, 96);
            this.lbl_Votros.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Votros.Name = "lbl_Votros";
            this.lbl_Votros.Size = new System.Drawing.Size(88, 29);
            this.lbl_Votros.TabIndex = 92;
            this.lbl_Votros.Text = "0000,00";
            this.lbl_Votros.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Cobros
            // 
            this.lbl_Cobros.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cobros.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Cobros.Location = new System.Drawing.Point(165, 194);
            this.lbl_Cobros.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Cobros.Name = "lbl_Cobros";
            this.lbl_Cobros.Size = new System.Drawing.Size(88, 29);
            this.lbl_Cobros.TabIndex = 91;
            this.lbl_Cobros.Text = "0000,00";
            this.lbl_Cobros.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Gastos
            // 
            this.lbl_Gastos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Gastos.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Gastos.Location = new System.Drawing.Point(165, 160);
            this.lbl_Gastos.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Gastos.Name = "lbl_Gastos";
            this.lbl_Gastos.Size = new System.Drawing.Size(88, 29);
            this.lbl_Gastos.TabIndex = 90;
            this.lbl_Gastos.Text = "0000,00";
            this.lbl_Gastos.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Vefectivo
            // 
            this.lbl_Vefectivo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Vefectivo.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_Vefectivo.Location = new System.Drawing.Point(165, 66);
            this.lbl_Vefectivo.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_Vefectivo.Name = "lbl_Vefectivo";
            this.lbl_Vefectivo.Size = new System.Drawing.Size(88, 29);
            this.lbl_Vefectivo.TabIndex = 89;
            this.lbl_Vefectivo.Text = "0000,00";
            this.lbl_Vefectivo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_EfecFinal
            // 
            this.lbl_EfecFinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EfecFinal.Font = new System.Drawing.Font("Segoe UI Light", 22F);
            this.lbl_EfecFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.lbl_EfecFinal.Location = new System.Drawing.Point(143, 266);
            this.lbl_EfecFinal.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_EfecFinal.Name = "lbl_EfecFinal";
            this.lbl_EfecFinal.Size = new System.Drawing.Size(134, 42);
            this.lbl_EfecFinal.TabIndex = 88;
            this.lbl_EfecFinal.Text = "0000,00";
            this.lbl_EfecFinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EfecInicial
            // 
            this.lbl_EfecInicial.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EfecInicial.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.lbl_EfecInicial.Location = new System.Drawing.Point(167, 39);
            this.lbl_EfecInicial.Margin = new System.Windows.Forms.Padding(3);
            this.lbl_EfecInicial.Name = "lbl_EfecInicial";
            this.lbl_EfecInicial.Size = new System.Drawing.Size(86, 32);
            this.lbl_EfecInicial.TabIndex = 87;
            this.lbl_EfecInicial.Text = "0000,00";
            this.lbl_EfecInicial.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label7.Location = new System.Drawing.Point(5, 160);
            this.label7.Margin = new System.Windows.Forms.Padding(3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 86;
            this.label7.Text = "Gastos totales :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label1.Location = new System.Drawing.Point(5, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 85;
            this.label1.Text = "Cobros totales : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label6.Location = new System.Drawing.Point(5, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 84;
            this.label6.Text = "Ventas totales :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label5.Location = new System.Drawing.Point(5, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 83;
            this.label5.Text = "Ventas efectivo : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label3.Location = new System.Drawing.Point(5, 273);
            this.label3.Margin = new System.Windows.Forms.Padding(3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 81;
            this.label3.Text = "En caja :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.label2.Location = new System.Drawing.Point(5, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 79;
            this.label2.Text = "Efectivo inicial :";
            // 
            // btn_EliminarGasto
            // 
            this.btn_EliminarGasto.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_EliminarGasto.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_EliminarGasto.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_EliminarGasto.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_EliminarGasto.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_EliminarGasto.BackgroundImage = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarGasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_EliminarGasto.FlatAppearance.BorderSize = 0;
            this.btn_EliminarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarGasto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_EliminarGasto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_EliminarGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarGasto.ImageEnableFalse = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarGasto.ImageOnMouseDown = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarGasto.ImageOnMouseEnter = global::SIVS.Properties.Resources.Delete_flip30;
            this.btn_EliminarGasto.ImageOnNothing = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarGasto.Location = new System.Drawing.Point(241, 273);
            this.btn_EliminarGasto.Name = "btn_EliminarGasto";
            this.btn_EliminarGasto.Size = new System.Drawing.Size(110, 32);
            this.btn_EliminarGasto.TabIndex = 73;
            this.btn_EliminarGasto.Text = "      Eliminar";
            this.btn_EliminarGasto.UseVisualStyleBackColor = false;
            this.btn_EliminarGasto.Click += new System.EventHandler(this.btn_EliminarGasto_Click);
            // 
            // btn_ModificarGasto
            // 
            this.btn_ModificarGasto.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ModificarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_ModificarGasto.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_ModificarGasto.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_ModificarGasto.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_ModificarGasto.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_ModificarGasto.BackgroundImage = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarGasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ModificarGasto.FlatAppearance.BorderSize = 0;
            this.btn_ModificarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarGasto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ModificarGasto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ModificarGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarGasto.ImageEnableFalse = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarGasto.ImageOnMouseDown = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarGasto.ImageOnMouseEnter = global::SIVS.Properties.Resources.Edit_flip30;
            this.btn_ModificarGasto.ImageOnNothing = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarGasto.Location = new System.Drawing.Point(125, 273);
            this.btn_ModificarGasto.Name = "btn_ModificarGasto";
            this.btn_ModificarGasto.Size = new System.Drawing.Size(110, 32);
            this.btn_ModificarGasto.TabIndex = 72;
            this.btn_ModificarGasto.Text = "     Modificar";
            this.btn_ModificarGasto.UseVisualStyleBackColor = false;
            this.btn_ModificarGasto.Click += new System.EventHandler(this.btn_ModificarGasto_Click);
            // 
            // btn_AgregarGasto
            // 
            this.btn_AgregarGasto.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarGasto.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_AgregarGasto.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_AgregarGasto.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_AgregarGasto.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarGasto.BackgroundImage = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarGasto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AgregarGasto.FlatAppearance.BorderSize = 0;
            this.btn_AgregarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarGasto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AgregarGasto.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AgregarGasto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarGasto.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarGasto.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarGasto.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_AgregarGasto.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarGasto.Location = new System.Drawing.Point(9, 273);
            this.btn_AgregarGasto.Name = "btn_AgregarGasto";
            this.btn_AgregarGasto.Size = new System.Drawing.Size(110, 32);
            this.btn_AgregarGasto.TabIndex = 71;
            this.btn_AgregarGasto.Text = "      Nuevo";
            this.btn_AgregarGasto.UseVisualStyleBackColor = false;
            this.btn_AgregarGasto.Click += new System.EventHandler(this.btn_AgregarGasto_Click);
            // 
            // btn_EliminarCobro
            // 
            this.btn_EliminarCobro.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EliminarCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_EliminarCobro.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_EliminarCobro.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_EliminarCobro.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_EliminarCobro.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_EliminarCobro.BackgroundImage = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_EliminarCobro.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarCobro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_EliminarCobro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_EliminarCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_EliminarCobro.ImageEnableFalse = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarCobro.ImageOnMouseDown = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarCobro.ImageOnMouseEnter = global::SIVS.Properties.Resources.Delete_flip30;
            this.btn_EliminarCobro.ImageOnNothing = global::SIVS.Properties.Resources.Delete;
            this.btn_EliminarCobro.Location = new System.Drawing.Point(238, 273);
            this.btn_EliminarCobro.Name = "btn_EliminarCobro";
            this.btn_EliminarCobro.Size = new System.Drawing.Size(110, 32);
            this.btn_EliminarCobro.TabIndex = 76;
            this.btn_EliminarCobro.Text = "      Eliminar";
            this.btn_EliminarCobro.UseVisualStyleBackColor = false;
            this.btn_EliminarCobro.Click += new System.EventHandler(this.btn_EliminarCobro_Click);
            // 
            // btn_ModificarCobro
            // 
            this.btn_ModificarCobro.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_ModificarCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_ModificarCobro.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_ModificarCobro.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_ModificarCobro.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_ModificarCobro.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_ModificarCobro.BackgroundImage = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ModificarCobro.FlatAppearance.BorderSize = 0;
            this.btn_ModificarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarCobro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_ModificarCobro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ModificarCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ModificarCobro.ImageEnableFalse = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarCobro.ImageOnMouseDown = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarCobro.ImageOnMouseEnter = global::SIVS.Properties.Resources.Edit_flip30;
            this.btn_ModificarCobro.ImageOnNothing = global::SIVS.Properties.Resources.Edit;
            this.btn_ModificarCobro.Location = new System.Drawing.Point(122, 273);
            this.btn_ModificarCobro.Name = "btn_ModificarCobro";
            this.btn_ModificarCobro.Size = new System.Drawing.Size(110, 32);
            this.btn_ModificarCobro.TabIndex = 75;
            this.btn_ModificarCobro.Text = "     Modificar";
            this.btn_ModificarCobro.UseVisualStyleBackColor = false;
            this.btn_ModificarCobro.Click += new System.EventHandler(this.btn_ModificarCobro_Click);
            // 
            // btn_AgregarCobro
            // 
            this.btn_AgregarCobro.Alineacion = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AgregarCobro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarCobro.BackcolorEnableFalse = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(204)))), ((int)(((byte)(201)))));
            this.btn_AgregarCobro.BackcolorMouseDown = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(78)))), ((int)(((byte)(44)))));
            this.btn_AgregarCobro.BackcolorOnEnter = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(88)))));
            this.btn_AgregarCobro.BackcolorOnNothing = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.btn_AgregarCobro.BackgroundImage = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarCobro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_AgregarCobro.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCobro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCobro.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AgregarCobro.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_AgregarCobro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AgregarCobro.ImageEnableFalse = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarCobro.ImageOnMouseDown = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarCobro.ImageOnMouseEnter = global::SIVS.Properties.Resources.Add_flip30;
            this.btn_AgregarCobro.ImageOnNothing = global::SIVS.Properties.Resources.Add_1_1;
            this.btn_AgregarCobro.Location = new System.Drawing.Point(6, 273);
            this.btn_AgregarCobro.Name = "btn_AgregarCobro";
            this.btn_AgregarCobro.Size = new System.Drawing.Size(110, 32);
            this.btn_AgregarCobro.TabIndex = 74;
            this.btn_AgregarCobro.Text = "      Nuevo";
            this.btn_AgregarCobro.UseVisualStyleBackColor = false;
            this.btn_AgregarCobro.Click += new System.EventHandler(this.btn_AgregarCobro_Click);
            // 
            // gb_ventas
            // 
            this.gb_ventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gb_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gb_ventas.Controls.Add(this.btn_Salir);
            this.gb_ventas.Controls.Add(this.dgrid_ventas);
            this.gb_ventas.Controls.Add(this.label15);
            this.gb_ventas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gb_ventas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.gb_ventas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.gb_ventas.Location = new System.Drawing.Point(0, 327);
            this.gb_ventas.Margin = new System.Windows.Forms.Padding(4);
            this.gb_ventas.Name = "gb_ventas";
            this.gb_ventas.Size = new System.Drawing.Size(1004, 214);
            this.gb_ventas.TabIndex = 98;
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
            this.btn_Salir.Location = new System.Drawing.Point(882, 176);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(110, 32);
            this.btn_Salir.TabIndex = 72;
            this.btn_Salir.Text = "    Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label15.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(1004, 32);
            this.label15.TabIndex = 58;
            this.label15.Text = "Ventas";
            // 
            // p_gastos
            // 
            this.p_gastos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_gastos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_gastos.Controls.Add(this.dgrid_gastos);
            this.p_gastos.Controls.Add(this.btn_EliminarGasto);
            this.p_gastos.Controls.Add(this.label16);
            this.p_gastos.Controls.Add(this.btn_ModificarGasto);
            this.p_gastos.Controls.Add(this.btn_AgregarGasto);
            this.p_gastos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.p_gastos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_gastos.Location = new System.Drawing.Point(281, 8);
            this.p_gastos.Margin = new System.Windows.Forms.Padding(4);
            this.p_gastos.Name = "p_gastos";
            this.p_gastos.Size = new System.Drawing.Size(356, 313);
            this.p_gastos.TabIndex = 99;
            // 
            // dgrid_gastos
            // 
            this.dgrid_gastos.AllowUserToAddRows = false;
            this.dgrid_gastos.AllowUserToDeleteRows = false;
            this.dgrid_gastos.AllowUserToResizeRows = false;
            this.dgrid_gastos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_gastos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_gastos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_gastos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_gastos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgrid_gastos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_gastos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgrid_gastos.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_gastos.Location = new System.Drawing.Point(0, 32);
            this.dgrid_gastos.MultiSelect = false;
            this.dgrid_gastos.Name = "dgrid_gastos";
            this.dgrid_gastos.ReadOnly = true;
            this.dgrid_gastos.RowHeadersVisible = false;
            this.dgrid_gastos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_gastos.Size = new System.Drawing.Size(356, 233);
            this.dgrid_gastos.TabIndex = 74;
            this.dgrid_gastos.SelectionChanged += new System.EventHandler(this.dgrid_gastos_SelectionChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label16.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(356, 32);
            this.label16.TabIndex = 58;
            this.label16.Text = "Gastos";
            // 
            // p_cobros
            // 
            this.p_cobros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.p_cobros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p_cobros.Controls.Add(this.dgrid_cobros);
            this.p_cobros.Controls.Add(this.btn_EliminarCobro);
            this.p_cobros.Controls.Add(this.label17);
            this.p_cobros.Controls.Add(this.btn_ModificarCobro);
            this.p_cobros.Controls.Add(this.btn_AgregarCobro);
            this.p_cobros.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.p_cobros.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.p_cobros.Location = new System.Drawing.Point(644, 8);
            this.p_cobros.Margin = new System.Windows.Forms.Padding(4);
            this.p_cobros.Name = "p_cobros";
            this.p_cobros.Size = new System.Drawing.Size(356, 313);
            this.p_cobros.TabIndex = 100;
            // 
            // dgrid_cobros
            // 
            this.dgrid_cobros.AllowUserToAddRows = false;
            this.dgrid_cobros.AllowUserToDeleteRows = false;
            this.dgrid_cobros.AllowUserToResizeRows = false;
            this.dgrid_cobros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgrid_cobros.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgrid_cobros.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgrid_cobros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgrid_cobros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgrid_cobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgrid_cobros.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgrid_cobros.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgrid_cobros.Location = new System.Drawing.Point(0, 32);
            this.dgrid_cobros.MultiSelect = false;
            this.dgrid_cobros.Name = "dgrid_cobros";
            this.dgrid_cobros.ReadOnly = true;
            this.dgrid_cobros.RowHeadersVisible = false;
            this.dgrid_cobros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgrid_cobros.Size = new System.Drawing.Size(356, 233);
            this.dgrid_cobros.TabIndex = 77;
            this.dgrid_cobros.SelectionChanged += new System.EventHandler(this.dgrid_cobros_SelectionChanged);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(146)))), ((int)(((byte)(183)))));
            this.label17.Dock = System.Windows.Forms.DockStyle.Top;
            this.label17.Font = new System.Drawing.Font("Segoe UI Light", 18F);
            this.label17.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(356, 32);
            this.label17.TabIndex = 58;
            this.label17.Text = "Cobros";
            // 
            // Frm_caja_diaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(178)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1004, 541);
            this.Controls.Add(this.p_cobros);
            this.Controls.Add(this.p_gastos);
            this.Controls.Add(this.gb_ventas);
            this.Controls.Add(this.pn_abm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_caja_diaria";
            this.Text = "Caja diaria";
            this.Activated += new System.EventHandler(this.Frm_caja_diaria_Activated);
            this.Load += new System.EventHandler(this.Frm_caja_diaria_Load);
            this.Shown += new System.EventHandler(this.Frm_caja_diaria_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_ventas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_gastos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_cobros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_ventas)).EndInit();
            this.pn_abm.ResumeLayout(false);
            this.pn_abm.PerformLayout();
            this.gb_ventas.ResumeLayout(false);
            this.p_gastos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_gastos)).EndInit();
            this.p_cobros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrid_cobros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrid_ventas;
        private System.Windows.Forms.BindingSource bs_gastos;
        private System.Windows.Forms.BindingSource bs_cobros;
        private System.Windows.Forms.BindingSource bs_ventas;
        private System.Windows.Forms.ToolTip tt_indicador;
        protected System.Windows.Forms.Panel pn_abm;
        private System.Windows.Forms.Label lbl_Vtotal;
        private System.Windows.Forms.Label lbl_Votros;
        private System.Windows.Forms.Label lbl_Cobros;
        private System.Windows.Forms.Label lbl_Gastos;
        private System.Windows.Forms.Label lbl_Vefectivo;
        private System.Windows.Forms.Label lbl_EfecFinal;
        private System.Windows.Forms.Label lbl_EfecInicial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        protected CONTROLES.ButtonImages btn_EliminarCobro;
        protected CONTROLES.ButtonImages btn_ModificarCobro;
        protected CONTROLES.ButtonImages btn_AgregarCobro;
        protected CONTROLES.ButtonImages btn_EliminarGasto;
        protected CONTROLES.ButtonImages btn_ModificarGasto;
        protected CONTROLES.ButtonImages btn_AgregarGasto;
        protected System.Windows.Forms.Panel gb_ventas;
        private System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Panel p_gastos;
        private System.Windows.Forms.Label label16;
        protected System.Windows.Forms.Panel p_cobros;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        protected CONTROLES.ButtonImages btn_Salir;
        private System.Windows.Forms.DataGridView dgrid_gastos;
        private System.Windows.Forms.DataGridView dgrid_cobros;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_Ganancia;
        private System.Windows.Forms.Label label21;
    }
}