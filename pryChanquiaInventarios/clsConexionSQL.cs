using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryChanquiaInventarios
{
    internal class clsConexionSQL
    {
        //cadena de conexion
        string cadenaConexion = "Server=localhost;Database=gestion;Trusted_Connection=True;";
        //string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestiondeInventario.accdb";
        //conector
        SqlConnection coneccionBaseDatos;
        //OleDbConnection coneccionBaseDatos;
        //comando
        SqlCommand comandoBaseDatos;
        //OleDbCommand comandoBaseDatos;
       //OleDbDataReader lectorDataReader;


        public string nombreBaseDeDatos;

        public void ConectarSQL()
        {
            try
            {
                coneccionBaseDatos = new SqlConnection(cadenaConexion);
                //coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();

                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }

        }
        
    }
}
