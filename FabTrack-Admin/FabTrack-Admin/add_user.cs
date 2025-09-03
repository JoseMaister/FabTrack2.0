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
    public partial class add_user : Form
    {
        string id_empleado = null;
        private int huellaActual = 0; // 1, 2 o 3
        private DPFP.Template[] Templates = new DPFP.Template[3];
        public add_user()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text.Trim();
            string paterno = txtpaterno.Text.Trim();
            string materno = txtmaterno.Text.Trim();
            string no_empleado = txtno_empleado.Text.Trim();
            string telefono = txt_telefono.Text.Trim(); // opcional
            string email = txtemail.Text.Trim();       // opcional
            string turno = cb_turno.SelectedItem?.ToString() ?? "";

            // Validación de campos obligatorios
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(paterno) ||
                string.IsNullOrEmpty(materno) || string.IsNullOrEmpty(no_empleado) ||
                string.IsNullOrEmpty(turno))
            {
                MessageBox.Show("❌ Debes completar todos los campos obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que al menos 1 huella exista
            if (Templates[0] == null && Templates[1] == null && Templates[2] == null)
            {
                MessageBox.Show("⚠ Debes capturar al menos 1 huella antes de guardar.");
                return;
            }

            // Guardar huellas (NULL si no existen)
            byte[] huella1 = Templates[0]?.Bytes;
            byte[] huella2 = Templates[1]?.Bytes;
            byte[] huella3 = Templates[2]?.Bytes;

            database db = new database();
            if (!db.OpenConnection())
            {
                MessageBox.Show("❌ Error en la conexión.");
                return;
            }

            try
            {
                // Insertar usuario con las huellas (pueden ser NULL algunas)
                string sqlInsert = @"INSERT INTO usuarios 
             (nombre, apellido_paterno, apellido_materno, numero_empleado, telefono, email, turno, huella1, huella2, huella3)
             VALUES (@nombre, @paterno, @materno, @no_empleado, @telefono, @email, @turno, @huella1, @huella2, @huella3)";

                MySqlCommand cmd = new MySqlCommand(sqlInsert, db.connection);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@paterno", paterno);
                cmd.Parameters.AddWithValue("@materno", materno);
                cmd.Parameters.AddWithValue("@no_empleado", no_empleado);
                cmd.Parameters.AddWithValue("@telefono", string.IsNullOrEmpty(telefono) ? DBNull.Value : (object)telefono);
                cmd.Parameters.AddWithValue("@email", string.IsNullOrEmpty(email) ? DBNull.Value : (object)email);
                cmd.Parameters.AddWithValue("@turno", turno);

                cmd.Parameters.AddWithValue("@huella1", (object)huella1 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@huella2", (object)huella2 ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@huella3", (object)huella3 ?? DBNull.Value);

                int filas = cmd.ExecuteNonQuery();

                if (filas > 0)
                {
                    MessageBox.Show("✅ Usuario y huellas registrados correctamente!");
                }
                else
                {
                    MessageBox.Show("⚠ No se pudo insertar el usuario.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar usuario: " + ex.Message);
            }
            finally
            {
                db.CloseConnection();
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
                            //btnAgregar1.Enabled = true;
                            break;
                        case 2:
                            txtHuella2.Text = "Huella 2 capturada correctamente";
                            //btnAgregar2.Enabled = true;
                            break;
                        case 3:
                            txtHuella3.Text = "Huella 3 capturada correctamente";
                            //btnAgregar3.Enabled = true;
                            break;
                    }
                }
                else
                {
                    MessageBox.Show($"La huella {huellaActual} no es válida. Repite el escaneo.", "Fingerprint Enrollment");
                }
            }));
        }
    }
}
