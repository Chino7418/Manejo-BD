namespace PryPederneraManejoBD
{
    partial class frmConsultas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultas));
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lstMostrar = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnMenuBack = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvConsulta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvConsulta.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Location = new System.Drawing.Point(25, 71);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.Size = new System.Drawing.Size(735, 316);
            this.dgvConsulta.TabIndex = 18;
            // 
            // lstMostrar
            // 
            this.lstMostrar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstMostrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.Items.AddRange(new object[] {
            "Categorías",
            "Clientes",
            "Compañías de envíos",
            "Detalles de pedidos",
            "Empleados",
            "Pedidos",
            "Productos",
            "Proveedores"});
            this.lstMostrar.Location = new System.Drawing.Point(25, 25);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(349, 25);
            this.lstMostrar.TabIndex = 17;
            this.lstMostrar.SelectedIndexChanged += new System.EventHandler(this.lstMostrar_SelectedIndexChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.ActiveBorderThickness = 1;
            this.btnConsultar.ActiveCornerRadius = 20;
            this.btnConsultar.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.ActiveForecolor = System.Drawing.Color.White;
            this.btnConsultar.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.BackColor = System.Drawing.Color.White;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.ButtonText = "Consultar Tablas";
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.IdleBorderThickness = 1;
            this.btnConsultar.IdleCornerRadius = 20;
            this.btnConsultar.IdleFillColor = System.Drawing.Color.White;
            this.btnConsultar.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnConsultar.Location = new System.Drawing.Point(409, 14);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(5);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(161, 46);
            this.btnConsultar.TabIndex = 23;
            this.btnConsultar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnClear
            // 
            this.btnClear.ActiveBorderThickness = 1;
            this.btnClear.ActiveCornerRadius = 20;
            this.btnClear.ActiveFillColor = System.Drawing.Color.Red;
            this.btnClear.ActiveForecolor = System.Drawing.Color.White;
            this.btnClear.ActiveLineColor = System.Drawing.Color.Red;
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.ButtonText = "Limpiar Grilla";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Red;
            this.btnClear.IdleBorderThickness = 1;
            this.btnClear.IdleCornerRadius = 20;
            this.btnClear.IdleFillColor = System.Drawing.Color.White;
            this.btnClear.IdleForecolor = System.Drawing.Color.Red;
            this.btnClear.IdleLineColor = System.Drawing.Color.Red;
            this.btnClear.Location = new System.Drawing.Point(594, 14);
            this.btnClear.Margin = new System.Windows.Forms.Padding(5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(161, 46);
            this.btnClear.TabIndex = 22;
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnMenuBack
            // 
            this.btnMenuBack.ActiveBorderThickness = 1;
            this.btnMenuBack.ActiveCornerRadius = 20;
            this.btnMenuBack.ActiveFillColor = System.Drawing.Color.Red;
            this.btnMenuBack.ActiveForecolor = System.Drawing.Color.White;
            this.btnMenuBack.ActiveLineColor = System.Drawing.Color.Red;
            this.btnMenuBack.BackColor = System.Drawing.Color.White;
            this.btnMenuBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMenuBack.BackgroundImage")));
            this.btnMenuBack.ButtonText = "Menu Principal";
            this.btnMenuBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBack.ForeColor = System.Drawing.Color.Red;
            this.btnMenuBack.IdleBorderThickness = 1;
            this.btnMenuBack.IdleCornerRadius = 20;
            this.btnMenuBack.IdleFillColor = System.Drawing.Color.White;
            this.btnMenuBack.IdleForecolor = System.Drawing.Color.Red;
            this.btnMenuBack.IdleLineColor = System.Drawing.Color.Red;
            this.btnMenuBack.Location = new System.Drawing.Point(599, 419);
            this.btnMenuBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuBack.Name = "btnMenuBack";
            this.btnMenuBack.Size = new System.Drawing.Size(161, 46);
            this.btnMenuBack.TabIndex = 21;
            this.btnMenuBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuBack.Click += new System.EventHandler(this.btnMenuBack_Click);
            // 
            // frmConsultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(769, 492);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnMenuBack);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.lstMostrar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Tablas ";
            this.Load += new System.EventHandler(this.frmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.ComboBox lstMostrar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConsultar;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClear;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMenuBack;
    }
}

