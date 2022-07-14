namespace PryPederneraManejoBD
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.lblCiudad = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblFechaContratacion = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtPais = new System.Windows.Forms.TextBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.dtpFNac = new System.Windows.Forms.DateTimePicker();
            this.dtpFCon = new System.Windows.Forms.DateTimePicker();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.cboTratamiento = new System.Windows.Forms.ComboBox();
            this.btnMenuBack = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnNuevoRegistro = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GbxDatos = new System.Windows.Forms.GroupBox();
            this.lblJefe = new System.Windows.Forms.Label();
            this.cboJefe = new System.Windows.Forms.ComboBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtExtension = new System.Windows.Forms.TextBox();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.gbxContacto = new System.Windows.Forms.GroupBox();
            this.gbxDIreccion = new System.Windows.Forms.GroupBox();
            this.GbxDatos.SuspendLayout();
            this.gbxContacto.SuspendLayout();
            this.gbxDIreccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(126, 209);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(66, 21);
            this.txtCodigo.TabIndex = 66;
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.BackColor = System.Drawing.Color.White;
            this.lblCodigoP.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoP.ForeColor = System.Drawing.Color.Black;
            this.lblCodigoP.Location = new System.Drawing.Point(15, 214);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(82, 16);
            this.lblCodigoP.TabIndex = 65;
            this.lblCodigoP.Text = "Codigo Postal";
            this.lblCodigoP.Click += new System.EventHandler(this.lblCodigoP_Click);
            // 
            // txtRegion
            // 
            this.txtRegion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegion.Location = new System.Drawing.Point(126, 161);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(66, 21);
            this.txtRegion.TabIndex = 64;
            this.txtRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRegion_KeyPress);
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.BackColor = System.Drawing.Color.White;
            this.lblRegion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegion.ForeColor = System.Drawing.Color.Black;
            this.lblRegion.Location = new System.Drawing.Point(20, 166);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(44, 16);
            this.lblRegion.TabIndex = 63;
            this.lblRegion.Text = "Región";
            // 
            // txtCiudad
            // 
            this.txtCiudad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiudad.ForeColor = System.Drawing.Color.Black;
            this.txtCiudad.Location = new System.Drawing.Point(126, 74);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(100, 21);
            this.txtCiudad.TabIndex = 62;
            this.txtCiudad.TextChanged += new System.EventHandler(this.txtCiudad_TextChanged);
            // 
            // lblCiudad
            // 
            this.lblCiudad.AutoSize = true;
            this.lblCiudad.BackColor = System.Drawing.Color.White;
            this.lblCiudad.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiudad.ForeColor = System.Drawing.Color.Black;
            this.lblCiudad.Location = new System.Drawing.Point(15, 79);
            this.lblCiudad.Name = "lblCiudad";
            this.lblCiudad.Size = new System.Drawing.Size(49, 16);
            this.lblCiudad.TabIndex = 61;
            this.lblCiudad.Text = "Ciudad";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(126, 111);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(100, 21);
            this.txtDireccion.TabIndex = 60;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.BackColor = System.Drawing.Color.White;
            this.lblDireccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(15, 116);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(57, 16);
            this.lblDireccion.TabIndex = 59;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblFechaContratacion
            // 
            this.lblFechaContratacion.AutoSize = true;
            this.lblFechaContratacion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaContratacion.ForeColor = System.Drawing.Color.Black;
            this.lblFechaContratacion.Location = new System.Drawing.Point(11, 233);
            this.lblFechaContratacion.Name = "lblFechaContratacion";
            this.lblFechaContratacion.Size = new System.Drawing.Size(136, 16);
            this.lblFechaContratacion.TabIndex = 57;
            this.lblFechaContratacion.Text = "Fecha de contratación ";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.BackColor = System.Drawing.Color.Transparent;
            this.lblFechaNacimiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaNacimiento.ForeColor = System.Drawing.Color.Black;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(11, 174);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(126, 16);
            this.lblFechaNacimiento.TabIndex = 55;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento ";
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.BackColor = System.Drawing.Color.Transparent;
            this.lblTratamiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTratamiento.ForeColor = System.Drawing.Color.Black;
            this.lblTratamiento.Location = new System.Drawing.Point(11, 136);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(75, 16);
            this.lblTratamiento.TabIndex = 53;
            this.lblTratamiento.Text = "Tratamiento ";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.BackColor = System.Drawing.Color.Transparent;
            this.lblCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.ForeColor = System.Drawing.Color.Black;
            this.lblCargo.Location = new System.Drawing.Point(11, 100);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(41, 16);
            this.lblCargo.TabIndex = 51;
            this.lblCargo.Text = "Cargo";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(139, 64);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 21);
            this.txtNombre.TabIndex = 50;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Black;
            this.lblNombre.Location = new System.Drawing.Point(11, 67);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 16);
            this.lblNombre.TabIndex = 49;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(139, 31);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 21);
            this.txtApellido.TabIndex = 48;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.Black;
            this.lblApellido.Location = new System.Drawing.Point(11, 31);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 16);
            this.lblApellido.TabIndex = 47;
            this.lblApellido.Text = "Apellido";
            // 
            // txtPais
            // 
            this.txtPais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPais.ForeColor = System.Drawing.Color.Black;
            this.txtPais.Location = new System.Drawing.Point(126, 31);
            this.txtPais.Name = "txtPais";
            this.txtPais.Size = new System.Drawing.Size(100, 21);
            this.txtPais.TabIndex = 46;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.White;
            this.lblPais.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPais.ForeColor = System.Drawing.Color.Black;
            this.lblPais.Location = new System.Drawing.Point(15, 36);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 16);
            this.lblPais.TabIndex = 45;
            this.lblPais.Text = "Pais";
            // 
            // txtNota
            // 
            this.txtNota.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(62, 151);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(184, 98);
            this.txtNota.TabIndex = 40;
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.BackColor = System.Drawing.Color.White;
            this.lblNotas.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotas.Location = new System.Drawing.Point(9, 154);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(38, 16);
            this.lblNotas.TabIndex = 39;
            this.lblNotas.Text = "Notas";
            // 
            // dtpFNac
            // 
            this.dtpFNac.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFNac.Location = new System.Drawing.Point(14, 193);
            this.dtpFNac.MaxDate = new System.DateTime(2004, 12, 31, 0, 0, 0, 0);
            this.dtpFNac.Name = "dtpFNac";
            this.dtpFNac.Size = new System.Drawing.Size(225, 21);
            this.dtpFNac.TabIndex = 69;
            this.dtpFNac.Value = new System.DateTime(1953, 1, 1, 0, 0, 0, 0);
            // 
            // dtpFCon
            // 
            this.dtpFCon.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFCon.Location = new System.Drawing.Point(14, 252);
            this.dtpFCon.Name = "dtpFCon";
            this.dtpFCon.Size = new System.Drawing.Size(226, 21);
            this.dtpFCon.TabIndex = 70;
            // 
            // cboCargo
            // 
            this.cboCargo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Items.AddRange(new object[] {
            "Representante de ventas",
            "Vicepresidente comercial",
            "Gerente de ventas",
            "Coordinador ventas interno"});
            this.cboCargo.Location = new System.Drawing.Point(139, 99);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(165, 24);
            this.cboCargo.TabIndex = 71;
            // 
            // cboTratamiento
            // 
            this.cboTratamiento.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTratamiento.FormattingEnabled = true;
            this.cboTratamiento.Items.AddRange(new object[] {
            "Sr.",
            "Sra.",
            "Dr.",
            "Dra.",
            "Srta."});
            this.cboTratamiento.Location = new System.Drawing.Point(139, 133);
            this.cboTratamiento.Name = "cboTratamiento";
            this.cboTratamiento.Size = new System.Drawing.Size(46, 24);
            this.cboTratamiento.TabIndex = 72;
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
            this.btnMenuBack.Location = new System.Drawing.Point(738, 390);
            this.btnMenuBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnMenuBack.Name = "btnMenuBack";
            this.btnMenuBack.Size = new System.Drawing.Size(161, 46);
            this.btnMenuBack.TabIndex = 75;
            this.btnMenuBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenuBack.Click += new System.EventHandler(this.btnMenuBack_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.ActiveBorderThickness = 1;
            this.btnNuevoRegistro.ActiveCornerRadius = 20;
            this.btnNuevoRegistro.ActiveFillColor = System.Drawing.Color.Green;
            this.btnNuevoRegistro.ActiveForecolor = System.Drawing.Color.White;
            this.btnNuevoRegistro.ActiveLineColor = System.Drawing.Color.Green;
            this.btnNuevoRegistro.BackColor = System.Drawing.Color.White;
            this.btnNuevoRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevoRegistro.BackgroundImage")));
            this.btnNuevoRegistro.ButtonText = "Nuevo Registro";
            this.btnNuevoRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistro.ForeColor = System.Drawing.Color.Green;
            this.btnNuevoRegistro.IdleBorderThickness = 1;
            this.btnNuevoRegistro.IdleCornerRadius = 20;
            this.btnNuevoRegistro.IdleFillColor = System.Drawing.Color.White;
            this.btnNuevoRegistro.IdleForecolor = System.Drawing.Color.Green;
            this.btnNuevoRegistro.IdleLineColor = System.Drawing.Color.Green;
            this.btnNuevoRegistro.Location = new System.Drawing.Point(400, 316);
            this.btnNuevoRegistro.Margin = new System.Windows.Forms.Padding(5);
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(161, 46);
            this.btnNuevoRegistro.TabIndex = 76;
            this.btnNuevoRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // GbxDatos
            // 
            this.GbxDatos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.GbxDatos.Controls.Add(this.txtApellido);
            this.GbxDatos.Controls.Add(this.lblApellido);
            this.GbxDatos.Controls.Add(this.lblNombre);
            this.GbxDatos.Controls.Add(this.txtNombre);
            this.GbxDatos.Controls.Add(this.cboTratamiento);
            this.GbxDatos.Controls.Add(this.lblCargo);
            this.GbxDatos.Controls.Add(this.cboCargo);
            this.GbxDatos.Controls.Add(this.lblTratamiento);
            this.GbxDatos.Controls.Add(this.dtpFCon);
            this.GbxDatos.Controls.Add(this.lblFechaNacimiento);
            this.GbxDatos.Controls.Add(this.dtpFNac);
            this.GbxDatos.Controls.Add(this.lblFechaContratacion);
            this.GbxDatos.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxDatos.Location = new System.Drawing.Point(12, 29);
            this.GbxDatos.Name = "GbxDatos";
            this.GbxDatos.Size = new System.Drawing.Size(317, 279);
            this.GbxDatos.TabIndex = 78;
            this.GbxDatos.TabStop = false;
            this.GbxDatos.Text = "Datos Personales";
            // 
            // lblJefe
            // 
            this.lblJefe.AutoSize = true;
            this.lblJefe.BackColor = System.Drawing.Color.White;
            this.lblJefe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJefe.Location = new System.Drawing.Point(9, 108);
            this.lblJefe.Name = "lblJefe";
            this.lblJefe.Size = new System.Drawing.Size(29, 16);
            this.lblJefe.TabIndex = 37;
            this.lblJefe.Text = "Jefe";
            // 
            // cboJefe
            // 
            this.cboJefe.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboJefe.FormattingEnabled = true;
            this.cboJefe.Items.AddRange(new object[] {
            "Fuller, Andrew",
            "Buchanan, Steve"});
            this.cboJefe.Location = new System.Drawing.Point(92, 108);
            this.cboJefe.Name = "cboJefe";
            this.cboJefe.Size = new System.Drawing.Size(121, 24);
            this.cboJefe.TabIndex = 73;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(92, 26);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 21);
            this.txtTelefono.TabIndex = 44;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtExtension
            // 
            this.txtExtension.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtension.Location = new System.Drawing.Point(92, 61);
            this.txtExtension.Name = "txtExtension";
            this.txtExtension.Size = new System.Drawing.Size(43, 21);
            this.txtExtension.TabIndex = 42;
            this.txtExtension.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExtension_KeyPress);
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.BackColor = System.Drawing.Color.White;
            this.lblExtension.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtension.Location = new System.Drawing.Point(9, 66);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(57, 16);
            this.lblExtension.TabIndex = 41;
            this.lblExtension.Text = "Extensión";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.BackColor = System.Drawing.Color.White;
            this.lblTelefono.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(9, 34);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 16);
            this.lblTelefono.TabIndex = 43;
            this.lblTelefono.Text = "Telefono";
            // 
            // gbxContacto
            // 
            this.gbxContacto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxContacto.Controls.Add(this.lblTelefono);
            this.gbxContacto.Controls.Add(this.lblExtension);
            this.gbxContacto.Controls.Add(this.txtExtension);
            this.gbxContacto.Controls.Add(this.txtTelefono);
            this.gbxContacto.Controls.Add(this.cboJefe);
            this.gbxContacto.Controls.Add(this.txtNota);
            this.gbxContacto.Controls.Add(this.lblJefe);
            this.gbxContacto.Controls.Add(this.lblNotas);
            this.gbxContacto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxContacto.Location = new System.Drawing.Point(628, 29);
            this.gbxContacto.Name = "gbxContacto";
            this.gbxContacto.Size = new System.Drawing.Size(271, 279);
            this.gbxContacto.TabIndex = 77;
            this.gbxContacto.TabStop = false;
            this.gbxContacto.Text = "Contacto";
            // 
            // gbxDIreccion
            // 
            this.gbxDIreccion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbxDIreccion.Controls.Add(this.lblDireccion);
            this.gbxDIreccion.Controls.Add(this.txtDireccion);
            this.gbxDIreccion.Controls.Add(this.txtPais);
            this.gbxDIreccion.Controls.Add(this.lblPais);
            this.gbxDIreccion.Controls.Add(this.lblCiudad);
            this.gbxDIreccion.Controls.Add(this.txtCodigo);
            this.gbxDIreccion.Controls.Add(this.txtCiudad);
            this.gbxDIreccion.Controls.Add(this.lblCodigoP);
            this.gbxDIreccion.Controls.Add(this.lblRegion);
            this.gbxDIreccion.Controls.Add(this.txtRegion);
            this.gbxDIreccion.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDIreccion.Location = new System.Drawing.Point(335, 29);
            this.gbxDIreccion.Name = "gbxDIreccion";
            this.gbxDIreccion.Size = new System.Drawing.Size(287, 279);
            this.gbxDIreccion.TabIndex = 78;
            this.gbxDIreccion.TabStop = false;
            this.gbxDIreccion.Text = "Dirección";
            this.gbxDIreccion.Enter += new System.EventHandler(this.gbxDIreccion_Enter);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.gbxDIreccion);
            this.Controls.Add(this.GbxDatos);
            this.Controls.Add(this.gbxContacto);
            this.Controls.Add(this.btnNuevoRegistro);
            this.Controls.Add(this.btnMenuBack);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Empleados";
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.GbxDatos.ResumeLayout(false);
            this.GbxDatos.PerformLayout();
            this.gbxContacto.ResumeLayout(false);
            this.gbxContacto.PerformLayout();
            this.gbxDIreccion.ResumeLayout(false);
            this.gbxDIreccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label lblCiudad;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblFechaContratacion;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtPais;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.DateTimePicker dtpFNac;
        private System.Windows.Forms.DateTimePicker dtpFCon;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.ComboBox cboTratamiento;
        private Bunifu.Framework.UI.BunifuThinButton2 btnMenuBack;
        private Bunifu.Framework.UI.BunifuThinButton2 btnNuevoRegistro;
        private System.Windows.Forms.GroupBox GbxDatos;
        private System.Windows.Forms.Label lblJefe;
        private System.Windows.Forms.ComboBox cboJefe;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtExtension;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.GroupBox gbxContacto;
        private System.Windows.Forms.GroupBox gbxDIreccion;
    }
}