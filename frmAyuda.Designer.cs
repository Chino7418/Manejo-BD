namespace PryPederneraManejoBD
{
    partial class frmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyuda));
            this.lblAyuda = new System.Windows.Forms.Label();
            this.pbxPity = new System.Windows.Forms.PictureBox();
            this.tmrPity = new System.Windows.Forms.Timer(this.components);
            this.btnOK = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPity)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAyuda
            // 
            this.lblAyuda.BackColor = System.Drawing.Color.Red;
            this.lblAyuda.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(43, 18);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(456, 70);
            this.lblAyuda.TabIndex = 0;
            this.lblAyuda.Text = "¿Ayuda? Ayuda pedia Izquierdos para frenarlo al pity !!!! JAJAJAJAJA";
            // 
            // pbxPity
            // 
            this.pbxPity.BackColor = System.Drawing.Color.Transparent;
            this.pbxPity.Image = global::PryPederneraManejoBD.Properties.Resources.Pity;
            this.pbxPity.Location = new System.Drawing.Point(60, 101);
            this.pbxPity.Name = "pbxPity";
            this.pbxPity.Size = new System.Drawing.Size(429, 269);
            this.pbxPity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxPity.TabIndex = 1;
            this.pbxPity.TabStop = false;
            this.pbxPity.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmrPity
            // 
            this.tmrPity.Tick += new System.EventHandler(this.tmrPity_Tick);
            // 
            // btnOK
            // 
            this.btnOK.ActiveBorderThickness = 1;
            this.btnOK.ActiveCornerRadius = 20;
            this.btnOK.ActiveFillColor = System.Drawing.Color.Red;
            this.btnOK.ActiveForecolor = System.Drawing.Color.White;
            this.btnOK.ActiveLineColor = System.Drawing.Color.Red;
            this.btnOK.BackColor = System.Drawing.Color.Black;
            this.btnOK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOK.BackgroundImage")));
            this.btnOK.ButtonText = "Volver";
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.Red;
            this.btnOK.IdleBorderThickness = 1;
            this.btnOK.IdleCornerRadius = 20;
            this.btnOK.IdleFillColor = System.Drawing.Color.White;
            this.btnOK.IdleForecolor = System.Drawing.Color.Red;
            this.btnOK.IdleLineColor = System.Drawing.Color.Red;
            this.btnOK.Location = new System.Drawing.Point(192, 378);
            this.btnOK.Margin = new System.Windows.Forms.Padding(5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(161, 46);
            this.btnOK.TabIndex = 34;
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pbxPity);
            this.Controls.Add(this.lblAyuda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAyuda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vamos La banda !!!";
            ((System.ComponentModel.ISupportInitialize)(this.pbxPity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.PictureBox pbxPity;
        private System.Windows.Forms.Timer tmrPity;
        private Bunifu.Framework.UI.BunifuThinButton2 btnOK;
    }
}