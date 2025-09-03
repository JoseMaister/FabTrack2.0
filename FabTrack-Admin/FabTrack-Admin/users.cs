using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabTrack_Admin
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            string query = "SELECT id, CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno) AS Nombre, numero_empleado as No_Empleado, telefono as Telef, email as Email, turno as Turno FROM usuarios";

            database db = new database();
            DataTable dt = db.ExecuteQuery(query);

            dtUsers.DataSource = dt;
            dtUsers.ReadOnly = true;

            // Ajustar columnas automáticamente según contenido
            dtUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Opcional: que ocupe todo el espacio restante
            dtUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtUsers.Columns["id"].Visible = false; // opcional

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Escribe un valor para buscar.");
                return;
            }

            string query = "";

            if (rbNombre.Checked)
            {
                // Buscar por nombre completo concatenado
                query = @"SELECT id, CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno) AS Nombre, 
                         numero_empleado as No_Empleado, telefono as Telef, email as Email, turno as Turno
                  FROM usuarios
                  WHERE CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno) LIKE @valor";
            }
            else if (rbNoEmpleado.Checked)
            {
                // Buscar por número de empleado
                query = @"SELECT id, CONCAT(nombre, ' ', apellido_paterno, ' ', apellido_materno) AS Nombre, 
                         numero_empleado as No_Empleado, telefono as Telef, email as Email, turno as Turno
                  FROM usuarios
                  WHERE numero_empleado LIKE @valor";
            }
            else
            {
                MessageBox.Show("Selecciona una opción de búsqueda.");
                return;
            }

            database db = new database();
            DataTable dt = new DataTable();

            try
            {
                db.OpenConnection();
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@valor", "%" + busqueda + "%"); // Para búsqueda parcial
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }

            dtUsers.DataSource = dt;
            dtUsers.ReadOnly = true;
            dtUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtUsers.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
