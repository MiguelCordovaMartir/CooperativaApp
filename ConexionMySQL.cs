using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace CooperativaApp
{
    public class ConexionMySQL
    {
        private MySqlConnection conexion;

        // Constructor para inicializar la conexión
        public ConexionMySQL()
        {
            
            string conexionString = "Server=localhost;Database=acoemprendedores;Uid=root;Pwd=1202M2708i2024g;";
            conexion = new MySqlConnection(conexionString);
        }

        // Método para abrir la conexión
        public MySqlConnection ObtenerConexion()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexión exitosa a la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Método para cerrar la conexión
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
                MessageBox.Show("Conexión cerrada.", "Conexión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
