using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PryPederneraManejoBD
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
            connection.Open();

            // Se agregar todos los valores al comando sql separados por renglon para que quede mas ordenado.
            string NuevoReg = "INSERT INTO Empleados (Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, FechaContratación," +
                "Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión,  Notas, Jefe) VALUES(";
            NuevoReg += "'" + txtApellido.Text + "', ";
            NuevoReg += "'" + txtNombre.Text + "', ";
            NuevoReg += "'" + cboCargo.Text + "', ";
            NuevoReg += "'" + cboTratamiento.Text + "', ";
            NuevoReg += "'" + dtpFNac.Value + "', ";
            NuevoReg += "'" + dtpFCon.Value + "', ";
            NuevoReg += "'" + txtDireccion.Text + "', ";
            NuevoReg += "'" + txtCiudad.Text + "', ";
            NuevoReg += "'" + txtRegion.Text + "', ";
            NuevoReg += "'" + txtCodigo.Text + "', ";
            NuevoReg += "'" + txtPais.Text + "', ";
            NuevoReg += "'" + txtTelefono.Text + "', ";
            NuevoReg += "'" + txtExtension.Text + "', ";
            NuevoReg += "'" + txtNota.Text + "', ";
            NuevoReg += "'" + cboJefe.Text+"') ";

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = NuevoReg;

            if (command.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Registro realizado correctamente!", "Empleado registrado",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se han podido agregar el empleado", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            connection.Close();

            txtApellido.Text = "";
            txtNombre.Text = "";
            cboCargo.Text = "";
          
            

        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }


        private void btnMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            if (txtApellido.Text == "" |
            txtNombre.Text == "" |
            cboCargo.Text == "" |
            cboTratamiento.Text == "" |
            txtDireccion.Text == "" |
            txtCiudad.Text == "" |
            txtRegion.Text == "" |
            txtCodigo.Text == "" |
            txtPais.Text == "" |
            txtTelefono.Text == "" |
            txtExtension.Text == "" |
            txtNota.Text == "" |
            cboJefe.Text == "")
            {
                MessageBox.Show("Falta completar campos", "Atención", MessageBoxButtons.OK);
            }

            else
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                connection.Open();

                // Se agregar todos los valores al comando sql separados por renglon para que quede mas ordenado.
                string NuevoReg = "INSERT INTO Empleados (Apellidos, Nombre, Cargo, Tratamiento, FechaNacimiento, FechaContratación," +
                    "Dirección, Ciudad, Región, CódPostal, País, TelDomicilio, Extensión,  Notas, Jefe) VALUES(";
                NuevoReg += "'" + txtApellido.Text + "', ";
                NuevoReg += "'" + txtNombre.Text + "', ";
                NuevoReg += "'" + cboCargo.Text + "', ";
                NuevoReg += "'" + cboTratamiento.Text + "', ";
                NuevoReg += "'" + dtpFNac.Value + "', ";
                NuevoReg += "'" + dtpFCon.Value + "', ";
                NuevoReg += "'" + txtDireccion.Text + "', ";
                NuevoReg += "'" + txtCiudad.Text + "', ";
                NuevoReg += "'" + txtRegion.Text + "', ";
                NuevoReg += "'" + txtCodigo.Text + "', ";
                NuevoReg += "'" + txtPais.Text + "', ";
                NuevoReg += "'" + txtTelefono.Text + "', ";
                NuevoReg += "'" + txtExtension.Text + "', ";
                NuevoReg += "'" + txtNota.Text + "', ";
                NuevoReg += "'" + cboJefe.Text + "') ";

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = NuevoReg;

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Registro realizado correctamente!", "Empleado registrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se han podido agregar el empleado", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                connection.Close();

                txtApellido.Text = "";
                txtNombre.Text = "";
                cboCargo.Text = "";
                cboTratamiento.Text = "";
                txtDireccion.Text = "";
                txtCiudad.Text = "";
                txtRegion.Text = "";
                txtCodigo.Text = "";
                txtPais.Text = "";
                txtTelefono.Text = "";
                txtExtension.Text = "";
                txtNota.Text = "";
                cboJefe.Text = "";

            }    



        }

        private void gbxDIreccion_Enter(object sender, EventArgs e)
        {

        }

        private void txtCiudad_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCodigoP_Click(object sender, EventArgs e)
        {

        }

        private void txtRegion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtExtension_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }
    }
}
