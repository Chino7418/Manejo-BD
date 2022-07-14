using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryPederneraManejoBD
{
    public static class Conexion
    {   
        /// <summary>
        /// Variable con contiene la instancia de la conexion 
        /// </summary>
        private static OleDbConnection objConexion;
        /// <summary>
        /// Funcion singletone(Se asegura que exista solo una instancia del tipo OleDBConnection en todo el proyecto)
        /// </summary>
        /// <returns></returns>
        public static OleDbConnection GetConnection()
        {
            if (objConexion == null)
            {
                objConexion = new OleDbConnection();
                string Ruta = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + Application.StartupPath + "\\NEPTUNO.accdb";
                objConexion.ConnectionString = Ruta;
            }
            return objConexion;
        }
        /// <summary>
        /// Permite pasar una consulta de forma dinamica mediante una cadena de texto 
        /// </summary>
        /// <param name="Consulta"></param>
        /// <returns></returns>
        public static DataTable HacerConsulta(string Consulta)
        {
            OleDbConnection objConexion = GetConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter();            
            
            objConexion.Open();

            string cmdt = Consulta;

            cmd.Connection = objConexion;
            cmd.CommandType = CommandType.TableDirect;
            cmd.CommandText = cmdt;

            dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            objConexion.Close();
            return dt;
        }
         
    }


   
}
    