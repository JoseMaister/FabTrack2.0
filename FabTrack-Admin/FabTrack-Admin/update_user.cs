

using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FabTrack_Admin
{
    public partial class update_user : Form
    {
        string id_empleado = null;
        private int huellaActual = 0; // 1, 2 o 3
        private DPFP.Template[] Templates = new DPFP.Template[3]; // almacena las 3 huellas
        database db = new database();

        public update_user()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string empleadoID = txtEmpleadoID.Text.Trim();


            // Obtener datos del empleado
            var empleado = db.GetEmpleado(empleadoID);
            if (empleado.Count > 0)
            {
                id_empleado = empleado["id"];
                txtNombre.Text = empleado["nombre"];
                txtApellidoP.Text = empleado["apellido_paterno"];
                txtApellidoM.Text = empleado["apellido_materno"];
                txtNumeroEmpleado.Text = empleado["numero_empleado"];
                txtTelefono.Text = empleado["telefono"];
                txtEmail.Text = empleado["email"];
                string turnoEmpleado = empleado["turno"]; // viene de la DB, probablemente "1", "2" o "3"

                if (comboTurno.Items.Contains(turnoEmpleado))
                {
                    comboTurno.SelectedItem = turnoEmpleado;
                }
                else
                {
                    comboTurno.SelectedIndex = -1; // Ninguno seleccionado si no coincide
                }

            }
            else
            {
                MessageBox.Show("Empleado no encontrado");

                txtNombre.Text = "";
                txtApellidoP.Text = "";
                txtApellidoM.Text = "";
                txtNumeroEmpleado.Text = "";
                txtTelefono.Text = "";
                txtEmail.Text = "";

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string paterno = txtApellidoP.Text;
            string materno = txtApellidoM.Text;
            string no_empleado = txtNumeroEmpleado.Text;
            string telefono = txtTelefono.Text;
            string email = txtEmail.Text;
            string turno = comboTurno.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(turno))
            {
                MessageBox.Show("⚠️ Debes seleccionar un turno.");
                return;
            }

            // Confirmación antes de guardar
            DialogResult confirm = MessageBox.Show(
                "¿Está seguro de que desea guardar los cambios del usuario?",
                "Confirmar modificación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm != DialogResult.Yes)
            {
                return; // Canceló, no se ejecuta el update
            }

            // Sentencia SQL con parámetros
            string sqlUpdate = @"
        UPDATE usuarios
        SET nombre = @nombre,
            apellido_paterno = @paterno,
            apellido_materno = @materno,
            numero_empleado = @numero_empleado,
            telefono = @telefono,
            email = @email,
            turno = @turno
        WHERE id = @id_empleado";

            // Diccionario de parámetros
            var parametros = new Dictionary<string, object>
    {
        { "@nombre", nombre },
        { "@paterno", paterno },
        { "@materno", materno },
        { "@numero_empleado", no_empleado },
        { "@telefono", telefono },
        { "@email", email },
        { "@turno", turno },
        { "@id_empleado", id_empleado }
    };

            // Ejecutar
            database db = new database();
            int rows = db.ExecuteNonQuery(sqlUpdate, parametros);

            if (rows > 0)
            {
                MessageBox.Show("✅ Usuario modificado correctamente!");

                // 🔹 Limpiar campos
                txtEmpleadoID.Clear();
                txtNombre.Clear();
                txtApellidoP.Clear();
                txtApellidoM.Clear();
                txtNumeroEmpleado.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                comboTurno.SelectedIndex = -1; // Deseleccionar
            }
            else
            {
                MessageBox.Show("❌ No se pudo modificar el usuario.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            huellaActual = 1;
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                if (template != null)
                {
                    Templates[huellaActual - 1] = template; // guarda en el índice correcto
                    MessageBox.Show($"Huella {huellaActual} lista para guardarse.", "Fingerprint Enrollment");

                    // Cambiar el textbox y botón correspondientes
                    switch (huellaActual)
                    {
                        case 1:
                            txtHuella1.Text = "Huella 1 capturada correctamente";
                            btnAgregar1.Enabled = true;
                            break;
                        case 2:
                            txtHuella2.Text = "Huella 2 capturada correctamente";
                            btnAgregar2.Enabled = true;
                            break;
                        case 3:
                            txtHuella3.Text = "Huella 3 capturada correctamente";
                            btnAgregar3.Enabled = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show($"La huella {huellaActual} no es válida. Repite el escaneo.", "Fingerprint Enrollment");
                }
            }));
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GuardarHuella(0);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            huellaActual = 2;
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            huellaActual = 3;
            CapturarHuella capturar = new CapturarHuella();
            capturar.OnTemplate += this.OnTemplate;
            capturar.ShowDialog();
        }

        private void GuardarHuella(int indice)
        {
            if (Templates[indice] == null)
            {
                MessageBox.Show("No hay huella capturada.");
                return;
            }

            byte[] streamHuella = Templates[indice].Bytes;

            database db = new database();
            if (!db.OpenConnection())
            {
                MessageBox.Show("❌ Error al abrir la conexión a la base de datos.");
                return;
            }

            try
            {
                string query = $"UPDATE usuarios SET huella{indice + 1} = @huella WHERE id = @no_empleado";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@huella", streamHuella);
                cmd.Parameters.AddWithValue("@no_empleado", id_empleado);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                    MessageBox.Show($"✅ Huella {indice + 1} actualizada correctamente!");
                else
                    MessageBox.Show("⚠ No se encontró el usuario con ese número de empleado.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al actualizar huella: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        private void btnAgregar2_Click(object sender, EventArgs e)
        {
            GuardarHuella(1);
        }

        private void btnAgregar3_Click(object sender, EventArgs e)
        {
            GuardarHuella(2);
        }
    }
}
