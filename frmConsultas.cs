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
    public partial class frmConsultas : Form
    {
        public frmConsultas()
        {
            InitializeComponent();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {


        }
        private void lstMostrar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;
        }

        private void btnMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (lstMostrar.Text == "")
            {
                MessageBox.Show("Debe seleccionar un item de la lista desplegable", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                OleDbConnection objConexion = new OleDbConnection();
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();

                try
                {   //Uso el objeto Connection para conectar a la base de datos y le indico la ubicacion de ella 
                    string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                    objConexion.ConnectionString = Ruta;
                    objConexion.Open();

                    cmd.Connection = objConexion;
                    cmd.CommandType = CommandType.TableDirect;
                    cmd.CommandText = lstMostrar.Text; // Le indico que la tabla a mostrar es lo que yo selecciono en el combobox

                    dataAdapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();//creo un tabla virtual y le indico que va a ser llenado con lo que tenga el adaptador
                    dataAdapter.Fill(dt);

                    OleDbDataReader dataR = cmd.ExecuteReader();

                    if (dataR.HasRows)
                    {
                        while (dataR.Read())
                        {
                            dgvConsulta.DataSource = dt;  //Lo que va a completar la grilla es lo que este cargado en el datatable

                        }
                    }
                    objConexion.Close();
                }
                catch (Exception mensajito)
                {
                    MessageBox.Show(mensajito.Message);
                    throw;
                }
            }
        }
    }

}