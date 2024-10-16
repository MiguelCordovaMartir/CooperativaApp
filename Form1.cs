using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CooperativaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Crear la conexión
            ConexionMySQL conexion = new ConexionMySQL();
            MySqlConnection conn = conexion.ObtenerConexion();  // Abre la conexión

            if (conn != null)
            {
                // Consulta SQL para obtener los datos de la tabla 'Clientes'
                string query = "SELECT * FROM Clientes";

                // Crear el comando y adaptador de datos
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                // Crear un DataTable para almacenar los datos
                System.Data.DataTable dt = new System.Data.DataTable();

                // Llenar el DataTable con los datos del adaptador
                adapter.Fill(dt);

                // Asignar el DataTable al DataGridView para mostrar los datos
                dataGridViewClientes.DataSource = dt;

                // Cerrar la conexión
                conexion.CerrarConexion();
            }
        }

        
    }
}
