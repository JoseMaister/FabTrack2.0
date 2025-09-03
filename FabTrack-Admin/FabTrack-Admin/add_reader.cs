using System;
using System.Windows.Forms;
using DPFP;
using DPFP.Capture;
using MySql.Data.MySqlClient;
using FabTrack_Admin;

namespace FabTrack_Admin
{
    public partial class add_reader : Form
    {
        private Capture Capturer;

        public add_reader()
        {
            InitializeComponent();

        }



        private void add_reader_Load(object sender, EventArgs e)
        {
            try
            {
                Capturer.StartCapture(); // Inicia captura para disparar OnReaderConnect
            }
            catch
            {
                MessageBox.Show("No se pudo iniciar el lector");
            }
        }



        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample) { }
        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback) { }

        // --- Botón Agregar Lector ---
        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtname.Text.Trim();
            //  string serie = txtserie.Text.Trim();
            string serie = cbLectores.SelectedItem.ToString();

            // Validaciones básicas
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(serie))
            {
                MessageBox.Show("⚠️ Debes ingresar nombre y serie del lector.");
                return;
            }

            string sqlCheck = $"SELECT COUNT(*) FROM lectores WHERE serie = '{serie}'";
            string sqlInsert = $"INSERT INTO lectores (nombre, serie) VALUES ('{nombre}', '{serie}')";

            database db = new database();
            if (db.OpenConnection())
            {
                // Verificar si ya existe
                int count = Convert.ToInt32(db.ExecuteScalar(sqlCheck)); // ExecuteScalar devuelve el primer valor de la consulta
                if (count > 0)
                {
                    MessageBox.Show("⚠️ Este lector ya está registrado.");
                }
                else
                {
                    db.ExecuteQuery(sqlInsert);
                    MessageBox.Show("✅ Lector registrado correctamente!");
                }

                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("❌ Error en la conexión.");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (Capturer != null)
            {
                Capturer.StopCapture();
                Capturer = null;
            }
        }

        private void add_reader_Load_1(object sender, EventArgs e)
        {
            DetectarLectores();
            //DetectarLector();
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

                    //   txtserie.Text = serial;
                    MessageBox.Show("Lector detectado: " + serial);
                }
                else
                {
                    MessageBox.Show("⚠️ No se detectó ningún lector.");
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
                cbLectores.Items.Clear();

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
                        cbLectores.Items.Add(serial);
                    }

                    // Selecciona el primer elemento por defecto
                    cbLectores.SelectedIndex = 0;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
