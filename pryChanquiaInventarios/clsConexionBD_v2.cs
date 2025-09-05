using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

//para conexion de ACcess
using System.Data.OleDb;

using System.Windows.Forms;

namespace pryChanquiaInventarios
{
    internal class clsConexionBD
    {
        //cadena de conexion
        //sql - string cadenaConexion = "Server=localhost;Database=Ventas2;Trusted_Connection=True;";
        string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../dbGestiondeInventario.accdb";
        //conector
        //SqlConnection coneccionBaseDatos;
        OleDbConnection coneccionBaseDatos;
        //comando
        //SqlCommand comandoBaseDatos;
        OleDbCommand comandoBaseDatos;
        OleDbDataReader lectorDataReader;
       

        public string nombreBaseDeDatos;

        public void ConectarBD()
        {
            try
            {
                //coneccionBaseDatos = new SqlConnection(cadenaConexion);
                coneccionBaseDatos = new OleDbConnection(cadenaConexion);

                nombreBaseDeDatos = coneccionBaseDatos.Database;

                coneccionBaseDatos.Open();
                
                MessageBox.Show("Conectado a " + nombreBaseDeDatos);
            }
            catch (Exception error)
            {
                MessageBox.Show("Tiene un errorcito - " + error.Message);
            }     

        }

        public void CargarCategorias(ComboBox categoria)
        {
            comandoBaseDatos = new OleDbCommand();
            comandoBaseDatos.Connection = coneccionBaseDatos;
            comandoBaseDatos.CommandType =System.Data.CommandType.Text;
            comandoBaseDatos.CommandText = "SELECT categoria_de_producto FROM Productos ";
            lectorDataReader = comandoBaseDatos.ExecuteReader();

            while (lectorDataReader.Read())
            {
                categoria.Items.Add(lectorDataReader[0]);
            }

        }

        //public void AgregarProducto(Int32 id, Int32 cat,string nom, string obs )
        //{
        //    comandoBaseDatos = new OleDbCommand();
        //    comandoBaseDatos.Connection = coneccionBaseDatos;
        //    comandoBaseDatos.CommandType = System.Data.CommandType.Text;
        //    comandoBaseDatos.CommandText = "INSERT INTO Productos (Id1, categoria_de_producto, Nombre, observaciones)" + VALUES ( {{id}}, cat, nom, obs);
        //    lectorDataReader = comandoBaseDatos.ExecuteReader();

          
        //}

    }
}
