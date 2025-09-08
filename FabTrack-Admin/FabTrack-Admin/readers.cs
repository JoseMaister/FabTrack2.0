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
    public partial class readers : Form
    {
        public readers()
        {
            InitializeComponent();
        }

        private void readers_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM lectores";

            database db = new database();
            DataTable dt = db.ExecuteQuery(query, null);

            dtReaders.DataSource = dt;
            dtReaders.ReadOnly = true;

            // Ajustar columnas automáticamente según contenido
            dtReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Opcional: que ocupe todo el espacio restante
            dtReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtReaders.Columns["id"].Visible = false; // opcional
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


            // Buscar por número de empleado
            query = @"SELECT *
                  FROM lectores
                  WHERE nombre LIKE @valor";


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

            dtReaders.DataSource = dt;
            dtReaders.ReadOnly = true;
            dtReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtReaders.Columns["id"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
