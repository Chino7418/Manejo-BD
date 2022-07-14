using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPederneraManejoBD
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void consultarTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();    
            frmConsultas consultas = new frmConsultas();
            consultas.ShowDialog();
        }

        private void tablaPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPedidos Pedidos = new frmPedidos();
            Pedidos.ShowDialog();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }

      
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        

       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmAyuda frmAyuda = new frmAyuda();
            frmAyuda.ShowDialog();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmConsultas consultas = new frmConsultas();
            consultas.ShowDialog();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPedidos Pedidos = new frmPedidos();
            Pedidos.ShowDialog();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistro frmRegistro = new frmRegistro();
            frmRegistro.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
            tmrLogo.Start();
        }
    }
    
}
