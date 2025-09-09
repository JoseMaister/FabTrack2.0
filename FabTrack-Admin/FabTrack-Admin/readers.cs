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
            string query = "SELECT * FROM lectores"; // Traemos activo

            database db = new database();
            DataTable dt = db.ExecuteQuery(query, null);

            dtReaders.DataSource = dt;
            dtReaders.ReadOnly = true;

            // Ajustar columnas automáticamente según contenido
            dtReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dtReaders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dtReaders.Columns["id"].Visible = false;     // opcional
            dtReaders.Columns["activo"].Visible = false; // opcional, solo para control interno

            // Evento para colorear filas según activo
            dtReaders.CellFormatting -= DtReaders_CellFormatting; // evitar duplicar
            dtReaders.CellFormatting += DtReaders_CellFormatting;
        }

        private void DtReaders_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dtReaders.Rows[e.RowIndex].Cells["activo"].Value != null)
            {
                int activo = Convert.ToInt32(dtReaders.Rows[e.RowIndex].Cells["activo"].Value);
                if (activo == 0)
                {
                    dtReaders.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    dtReaders.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
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
