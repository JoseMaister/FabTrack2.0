using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FabTrack_Admin
{
    public partial class update_reader : Form
    {
        string id_lector = null;
        database db = new database();
        public update_reader()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string serie = txtSerie.Text.Trim();
            string ubicacion = txtubi.Text.Trim();
            string dbplc = txtdbplc.Text.Trim();
            string comentarios = txtcoments.Text.Trim();

            // Preguntar antes de modificar
            DialogResult result = MessageBox.Show(
                "¿Seguro que quieres modificar este lector?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                string sqlUpdate = @"UPDATE lectores 
                         SET nombre = @nombre, serie = @serie, ubicacion = @ubicacion, direccion_plc = @dbplc, comentarios = @comentarios
                         WHERE id = @id";

                var parametros = new Dictionary<string, object>
                    {
                        {"@nombre", nombre},
                        {"@serie", serie},
                        {"@ubicacion", ubicacion},
                        {"@dbplc", dbplc},
                        {"@comentarios", comentarios},
                        {"@id", id_lector}
                    };

                database db = new database();
                int filas = db.ExecuteNonQuery(sqlUpdate, parametros);

                if (filas > 0)
                {
                    MessageBox.Show("✅ Lector modificado correctamente!");

                    // 🔹 Limpiar los TextBox después de modificar
                    txtBuscar.Clear();
                    txtNombre.Clear();
                    txtubi.Clear();
                    txtdbplc.Clear();
                    txtcoments.Clear();
                    txtSerie.Clear(); // Si quieres mantener la serie, deja esta línea comentada
                }
                else
                {
                    MessageBox.Show("❌ No se pudo modificar. Verifica el ID.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreBuscar = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(nombreBuscar))
            {
                MessageBox.Show("Ingresa un nombre para buscar");
                return;
            }

            // Llamamos al método correcto
            var lector = db.GetLectorPorNombre(nombreBuscar);

            if (lector.Count > 0)
            {
                id_lector = lector["id"]; // id_lector debe ser variable de clase
                txtNombre.Text = lector["nombre"];
                txtSerie.Text = lector["serie"];
                txtubi.Text = lector["ubicacion"];
                txtdbplc.Text = lector["direccion_plc"];
                txtcoments.Text = lector["comentarios"];
            }
            else
            {
                MessageBox.Show("Lector no encontrado");
                txtNombre.Text = "";
                txtSerie.Text = "";
            }
        }

    }
}
