namespace PryPederneraManejoBD
{
    partial class frmPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.cboCiudad = new System.Windows.Forms.ComboBox();
            this.nudDesde = new System.Windows.Forms.NumericUpDown();
            this.nudHasta = new System.Windows.Forms.NumericUpDown();
            this.cboRegion = new System.Windows.Forms.ComboBox();
            this.btnMenuBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnIDClientes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnRangoFechas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnCiudadMostrar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnCargoM = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(10, 38);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(1078, 302);
            this.dgvConsulta.TabIndex = 19;
            // 
            // cboCliente
            // 
            this.cboCliente.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(68, 417);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(84, 24);
            this.cboCliente.TabIndex = 30;
            // 
            // dtpDesde
            // 
            this.dtpDesde.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDesde.Location = new System.Drawing.Point(236, 420);
            this.dtpDesde.MaxDate = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.dtpDesde.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(163, 21);
            this.dtpDesde.TabIndex = 25;
            this.dtpDesde.Value = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHasta.Location = new System.Drawing.Point(236, 454);
            this.dtpHasta.MaxDate = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            this.dtpHasta.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(163, 21);
            this.dtpHasta.TabIndex = 26;
            this.dtpHasta.Value = new System.DateTime(1998, 12, 31, 0, 0, 0, 0);
            // 
            // cboCiudad
            // 
            this.cboCiudad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCiudad.FormattingEnabled = true;
            this.cboCiudad.Location = new System.Drawing.Point(476, 417);
            this.cboCiudad.Name = "cboCiudad";
            this.cboCiudad.Size = new System.Drawing.Size(121, 24);
            this.cboCiudad.TabIndex = 27;
            this.cboCiudad.SelectedIndexChanged += new System.EventHandler(this.cboCiudad_SelectedIndexChanged);
            // 
            // nudDesde
            // 
            this.nudDesde.Location = new System.Drawing.Point(776, 417);
            this.nudDesde.Name = "nudDesde";
            this.nudDesde.Size = new System.Drawing.Size(57, 20);
            this.nudDesde.TabIndex = 28;
            // 
            // nudHasta
            // 
            this.nudHasta.Location = new System.Drawing.Point(776, 450);
            this.nudHasta.Name = "nudHasta";
            this.nudHasta.Size = new System.Drawing.Size(57, 20);
            this.nudHasta.TabIndex = 29;
            // 
            // cboRegion
            // 
            this.cboRegion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboRegion.FormattingEnabled = true;
            this.cboRegion.Location = new System.Drawing.Point(476, 451);
            this.cboRegion.Name = "cboRegion";
            this.cboRegion.Size = new System.Drawing.Size(121, 24);
            this.cboRegion.TabIndex = 32;
            this.cboRegion.Visible = false;
            // 
            // btnMenuBack
            // 
            this.btnMenuBack.ActiveBorderThickness = 1;
            this.btnMenuBack.ActiveCornerRadius = 20;
            this.btnMenuBack.ActiveFillColor = System.Drawing.Color.Red;
            this.btnMenuBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnMenuBack.ActiveLineColor = System.Drawing.Color.Red;
            this.btnMenuBack.BackColor = System.Drawing.Color.White;
            this.btnMenuBack.ButtonText = "Menu Principal";
            this.btnMenuBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBack.ForeColor = System.Drawing.Color.Red;
            this.btnMenuBack.IdleBorderThickness = 1;
            this.btnMenuBack.IdleCornerRadius = 20;
            this.btnMenuBack.IdleFillColor = System.Drawing.Color.White;
            this.btnMenuBack.IdleForecolor = System.Drawing.Color.Red;
            this.btnMenuBack.IdleLineColor = System.Drawing.Color.Red;
            this.btnMenuBack.Location = new System.Drawing.Point(889, 429);
            this.btnMenuBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuBack.Name = "btnMenuBack";
            this.btnMenuBack.Size = new System.Drawing.Size(161, 46);
            this.btnMenuBack.TabIndex = 33;
            this.btnMenuBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuBack.Click += new System.EventHandler(this.btnMenuBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Limpiar Grilla";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnClear.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClear.Location = new System.Drawing.Point(882, 348);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(168, 61);
            this.btnClear.TabIndex = 34;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnIDClientes
            // 
            this.btnIDClientes.ActiveBorderThickness = 1;
            this.btnIDClientes.ActiveCornerRadius = 20;
            this.btnIDClientes.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnIDClientes.ActiveForecolor = System.Drawing.Color.White;
            this.btnIDClientes.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnIDClientes.BackColor = System.Drawing.Color.White;
            this.btnIDClientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIDClientes.BackgroundImage")));
            this.btnIDClientes.ButtonText = "Mostrar ID Clientes";
            this.btnIDClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIDClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIDClientes.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnIDClientes.IdleBorderThickness = 1;
            this.btnIDClientes.IdleCornerRadius = 20;
            this.btnIDClientes.IdleFillColor = System.Drawing.Color.White;
            this.btnIDClientes.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnIDClientes.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnIDClientes.Location = new System.Drawing.Point(32, 348);
            this.btnIDClientes.Margin = new System.Windows.Forms.Padding(5);
            this.btnIDClientes.Name = "btnIDClientes";
            this.btnIDClientes.Size = new System.Drawing.Size(168, 61);
            this.btnIDClientes.TabIndex = 35;
            this.btnIDClientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnIDClientes.Click += new System.EventHandler(this.btnIDClientes_Click);
            // 
            // btnRangoFechas
            // 
            this.btnRangoFechas.ActiveBorderThickness = 1;
            this.btnRangoFechas.ActiveCornerRadius = 20;
            this.btnRangoFechas.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnRangoFechas.ActiveForecolor = System.Drawing.Color.White;
            this.btnRangoFechas.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnRangoFechas.BackColor = System.Drawing.Color.White;
            this.btnRangoFechas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRangoFechas.BackgroundImage")));
            this.btnRangoFechas.ButtonText = "Mostrar rango de fecha";
            this.btnRangoFechas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRangoFechas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRangoFechas.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRangoFechas.IdleBorderThickness = 1;
            this.btnRangoFechas.IdleCornerRadius = 20;
            this.btnRangoFechas.IdleFillColor = System.Drawing.Color.White;
            this.btnRangoFechas.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnRangoFechas.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnRangoFechas.Location = new System.Drawing.Point(236, 348);
            this.btnRangoFechas.Margin = new System.Windows.Forms.Padding(5);
            this.btnRangoFechas.Name = "btnRangoFechas";
            this.btnRangoFechas.Size = new System.Drawing.Size(168, 61);
            this.btnRangoFechas.TabIndex = 36;
            this.btnRangoFechas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRangoFechas.Click += new System.EventHandler(this.btnRangoFechas_Click);
            // 
            // BtnCiudadMostrar
            // 
            this.BtnCiudadMostrar.ActiveBorderThickness = 1;
            this.BtnCiudadMostrar.ActiveCornerRadius = 20;
            this.BtnCiudadMostrar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnCiudadMostrar.ActiveForecolor = System.Drawing.Color.White;
            this.BtnCiudadMostrar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnCiudadMostrar.BackColor = System.Drawing.Color.White;
            this.BtnCiudadMostrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCiudadMostrar.BackgroundImage")));
            this.BtnCiudadMostrar.ButtonText = "Mostrar Ciudad";
            this.BtnCiudadMostrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCiudadMostrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCiudadMostrar.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnCiudadMostrar.IdleBorderThickness = 1;
            this.BtnCiudadMostrar.IdleCornerRadius = 20;
            this.BtnCiudadMostrar.IdleFillColor = System.Drawing.Color.White;
            this.BtnCiudadMostrar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnCiudadMostrar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnCiudadMostrar.Location = new System.Drawing.Point(448, 348);
            this.BtnCiudadMostrar.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCiudadMostrar.Name = "BtnCiudadMostrar";
            this.BtnCiudadMostrar.Size = new System.Drawing.Size(168, 61);
            this.BtnCiudadMostrar.TabIndex = 37;
            this.BtnCiudadMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCiudadMostrar.Click += new System.EventHandler(this.BtnCiudadMostrar_Click);
            // 
            // BtnCargoM
            // 
            this.BtnCargoM.ActiveBorderThickness = 1;
            this.BtnCargoM.ActiveCornerRadius = 20;
            this.BtnCargoM.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnCargoM.ActiveForecolor = System.Drawing.Color.White;
            this.BtnCargoM.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnCargoM.BackColor = System.Drawing.Color.White;
            this.BtnCargoM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCargoM.BackgroundImage")));
            this.BtnCargoM.ButtonText = "Mostrar Cargo";
            this.BtnCargoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCargoM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCargoM.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnCargoM.IdleBorderThickness = 1;
            this.BtnCargoM.IdleCornerRadius = 20;
            this.BtnCargoM.IdleFillColor = System.Drawing.Color.White;
            this.BtnCargoM.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnCargoM.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnCargoM.Location = new System.Drawing.Point(665, 348);
            this.BtnCargoM.Margin = new System.Windows.Forms.Padding(5);
            this.BtnCargoM.Name = "BtnCargoM";
            this.BtnCargoM.Size = new System.Drawing.Size(168, 61);
            this.BtnCargoM.TabIndex = 38;
            this.BtnCargoM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCargoM.Click += new System.EventHandler(this.BtnCargoM_Click);
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(710, 417);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 16);
            this.lblDesde.TabIndex = 39;
            this.lblDesde.Text = "Desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.Location = new System.Drawing.Point(712, 450);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(39, 16);
            this.lblHasta.TabIndex = 40;
            this.lblHasta.Text = "Hasta";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1102, 503);
            this.Controls.Add(this.lblHasta);
            this.Controls.Add(this.lblDesde);
            this.Controls.Add(this.BtnCargoM);
            this.Controls.Add(this.BtnCiudadMostrar);
            this.Controls.Add(this.btnRangoFechas);
            this.Controls.Add(this.btnIDClientes);
            this.Controls.Add(this.cboCliente);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMenuBack);
            this.Controls.Add(this.cboRegion);
            this.Controls.Add(this.nudHasta);
            this.Controls.Add(this.nudDesde);
            this.Controls.Add(this.cboCiudad);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.dgvConsulta);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Tabla Pedidos";
            this.Load += new System.EventHandler(this.frmPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.ComboBox cboCiudad;
        private System.Windows.Forms.NumericUpDown nudDesde;
        private System.Windows.Forms.NumericUpDown nudHasta;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.ComboBox cboRegion;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMenuBack;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnIDClientes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnRangoFechas;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnCiudadMostrar;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnCargoM;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblHasta;
    }
}