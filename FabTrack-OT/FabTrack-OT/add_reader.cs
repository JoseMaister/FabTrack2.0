using DPFP;
using DPFP.Capture;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using FabTrack_OT;
using System.Net.NetworkInformation;

namespace FabTrack_OT
{
    public partial class add_reader : Form
    {
        public add_reader()
        {
            InitializeComponent();
        }

        private void add_reader_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                MessageBox.Show("Asegúrese de que esté conectado el LECTOR");
                DetectarLector();
            }));
        }

        private void DetectarLector()
        {
            try
            {
                // Obtiene todos los lectores conectados
                ReadersCollection readers = new ReadersCollection();

                if (readers.Count > 0)
                {
                    // Usamos el primero encontrado
                    string serial = readers[0].SerialNumber;

                    // Limpia las llaves { }
                    if (!string.IsNullOrEmpty(serial))
                        serial = serial.Replace("{", "").Replace("}", "").Trim();

                        txtserie.Text = serial;
                    //MessageBox.Show("Lector detectado: " + serial);
                }
                else
                {
                    string mensaje = "No se detecta ningún lector";

                    // Mostrar MessageBox
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Actualizar lblLector
                    lblLector.Text = mensaje;
                    lblLector.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detectando lector: " + ex.Message);
            }
        }
        private void DetectarLectores()
        {
            try
            {
                // Obtiene todos los lectores conectados
                ReadersCollection readers = new ReadersCollection();

                // Limpia el combobox antes de llenarlo
               // cbLectores.Items.Clear();

                if (readers.Count > 0)
                {
                    foreach (var readerPair in readers) // readerPair es KeyValuePair<Guid, ReaderDescription>
                    {
                        var reader = readerPair.Value; // Obtenemos el ReaderDescription
                        string serial = reader.SerialNumber;

                        // Limpia las llaves { }
                        if (!string.IsNullOrEmpty(serial))
                            serial = serial.Replace("{", "").Replace("}", "").Trim();

                        // Agrega al combobox
                     //   cbLectores.Items.Add(serial);
                    }

                    // Selecciona el primer elemento por defecto
                  //  cbLectores.SelectedIndex = 0;

                    //   MessageBox.Show("Lectores detectados: " + readers.Count);
                }
                else
                {
                    MessageBox.Show("⚠️ No se detectó ningún lector.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error detectando lectores: " + ex.Message);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text.Trim();
            string serie = txtserie.Text.Trim();
            string ubicacion = txtubi.Text.Trim();
            string dbplc = txtdbplc.Text.Trim();
            string comentarios = txtcoments.Text.Trim();
            //string serie = cbLectores.SelectedItem.ToString();

            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(serie))
            {
                MessageBox.Show("⚠️ Debes ingresar nombre y serie del lector.");
                return;
            }

            string sqlCheck = $"SELECT COUNT(*) FROM lectores WHERE serie = '{serie}'";
            string sqlInsert = $"INSERT INTO lectores (nombre, serie, ubicacion, direccion_plc, comentarios) " +
                               $"VALUES ('{nombre}', '{serie}', '{ubicacion}', '{dbplc}', '{comentarios}')";

            database db = new database();
            if (db.OpenConnection())
            {
                // Verificar si ya existe
                int count = Convert.ToInt32(db.ExecuteScalar(sqlCheck)); // ✅ No se modifica
                if (count > 0)
                {
                    MessageBox.Show("⚠️ Este lector ya está registrado.");
                }
                else
                {
                    DialogResult result = MessageBox.Show(
                         "¿Estás seguro de registrar este lector?",
                         "Confirmar acción",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question
                     );

                    if (result == DialogResult.Yes)
                    {
                        db.ExecuteQuery(sqlInsert, null);
                        MessageBox.Show("✅ Lector registrado correctamente!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 🔹 Limpiar los campos menos la serie
                        txtname.Clear();
                        txtubi.Clear();
                        txtdbplc.Clear();
                        txtcoments.Clear();

                        // 🔹 Preguntar si quiere registrar otro
                        DialogResult otro = MessageBox.Show(
                            "🔌 Ahora desconecte el lector.\n\n¿Desea registrar otro lector?",
                            "Siguiente paso",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (otro == DialogResult.Yes)
                        {
                            DetectarLector(); // 👉 Llamada a tu método
                        }
                    }
                    else
                    {
                        MessageBox.Show("❌ Registro cancelado.", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("❌ Error en la conexión.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
