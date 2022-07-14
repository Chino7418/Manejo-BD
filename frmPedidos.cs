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
    public partial class frmPedidos : Form
    {

        public frmPedidos()
        {
            InitializeComponent();
        }


        private void btnClientes_Click(object sender, EventArgs e)
        {
            DataTable dt = Conexion.HacerConsulta("Select * From Pedidos where IdCliente = '" + cboCliente.Text + "'");
            dgvConsulta.DataSource = dt;
        }
        private void frmPedidos_Load(object sender, EventArgs e)
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
                cmd.CommandText = "Pedidos"; // Le indico que la tabla a mostrar es lo que yo selecciono en el combobox

                dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();//creo un tabla virtual y le indico que va a ser llenado con lo que tenga el adaptador
                dataAdapter.Fill(dt);

                OleDbDataReader dataR = cmd.ExecuteReader();


                if (dataR.HasRows)
                {
                    while (dataR.Read())
                    {
                        //dgvConsulta.DataSource = dt;  //Lo que va a completar la grilla es lo que este cargado en el datatable

                        if (!cboCiudad.Items.Contains(dataR["CiudadDestinatario"].ToString()))
                        {
                            cboCiudad.Items.Add(dataR["CiudadDestinatario"].ToString());
                        }

                        if (!cboCliente.Items.Contains(dataR["IdCliente"].ToString()))
                        {
                            cboCliente.Items.Add(dataR["IdCliente"].ToString());
                        }
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

        private void cboCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //segun la ciudad seleccionada
            //muestro y cargo el combo REGION 

            cboRegion.Visible = true;

            OleDbConnection objConexion = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();


            try
            {   //Uso el objeto Connection para conectar a la base de datos y le indico la ubicacion de ella 
                string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                objConexion.ConnectionString = Ruta;
                objConexion.Open();

                cmd.Connection = objConexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT CiudadDestinatario , RegiónDestinatario FROM Pedidos WHERE CiudadDestinatario = '" + cboCiudad.Text + "' GROUP BY CiudadDestinatario , RegiónDestinatario";

                cmd.ExecuteNonQuery();

                dataAdapter = new OleDbDataAdapter(cmd);
                DataSet dt = new DataSet();
                dataAdapter.Fill(dt, "Pedidos");

                cboRegion.DisplayMember = "RegiónDestinatario";
                cboRegion.DataSource = dt.Tables["Pedidos"];


                objConexion.Close();
            }
            catch (Exception mensajito)
            {
                MessageBox.Show(mensajito.Message);
                throw;
            }

        }

        private void btnMenuBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;
        }

        private void btnIDClientes_Click(object sender, EventArgs e)
        {
            DataTable dt = Conexion.HacerConsulta("Select * From Pedidos where IdCliente = '" + cboCliente.Text + "'");
            dgvConsulta.DataSource = dt;
        }

        private void btnRangoFechas_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = null;

            string varDesde = dtpDesde.Value.ToString();
            string varHasta = dtpHasta.Value.ToString();

            DataTable dt = Conexion.HacerConsulta("Select * FROM Pedidos where FechaPedido  between #" + varDesde + "# and #" + varHasta + "#");
            dgvConsulta.DataSource = dt;


        }

        private void BtnCiudadMostrar_Click(object sender, EventArgs e)
        {
            string varCity = cboCiudad.Text;
            DataTable dt = Conexion.HacerConsulta("Select * FROM Pedidos where CiudadDestinatario='" + varCity + "'");
            dgvConsulta.DataSource = dt;
        }

        private void BtnCargoM_Click(object sender, EventArgs e)
        {
            if (nudDesde.Value > nudHasta.Value)
            {
                MessageBox.Show("Seleccione un rango aceptable", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (nudDesde.Value < nudHasta.Value)
            {
                try
                {
                    OleDbConnection objConexion = new OleDbConnection();
                    OleDbCommand objComando = new OleDbCommand();
                    OleDbDataAdapter Adaptador = new OleDbDataAdapter();
                    objConexion.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Application.StartupPath + "\\NEPTUNO.accdb";
                    objConexion.Open();
                    String CadenaSql = "SELECT *FROM Pedidos WHERE Cargo BETWEEN @DesdeCargo AND @HastaCargo";
                    objComando = new OleDbCommand(CadenaSql, objConexion);
                    objComando.Parameters.AddWithValue("@DesdeCargo", ((float)nudDesde.Value));
                    objComando.Parameters.AddWithValue("@HastaCargo", ((float)nudHasta.Value));
                    Adaptador = new OleDbDataAdapter(objComando);
                    DataSet ds = new DataSet();
                    Adaptador.Fill(ds, "Pedidos");
                    dgvConsulta.DataSource = ds;
                    dgvConsulta.DataMember = "Pedidos";
                    MessageBox.Show(" El rango minimo es " + "$" + nudDesde.Value +
                        " y el rango maximo " + "$" + nudHasta.Value + "", " Valores seleccionados ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    nudDesde.Value = 0;
                    nudHasta.Value = 0;
                    objConexion.Close();
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
