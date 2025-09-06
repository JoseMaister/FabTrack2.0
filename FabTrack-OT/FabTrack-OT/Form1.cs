using S7.Net;
using DPFP;
using DPFP.Capture;
using FabTrack_OT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.FieldOptions.Types;
using System.Threading.Tasks;

namespace FabTrack_OT
{
    public partial class Form1 : Form, DPFP.Capture.EventHandler
    {
        private Label[] lblLectores;
        private Label[] lblAcciones;
        private Label[] lblUsuarios;
        private Label[] lblUbicaciones;
        private string[] serialesLectores;
        private List<Capture> capturadores = new List<Capture>();
        string location = null;
        private string[] direccionesPLC; // <- array para guardar la dirección de cada lector en el PLC

        database db = new database();

        public Form1()
        {
            InitializeComponent();
        }
        private void cargar_lectores()
        {
            lblLectores = new Label[] { lblLector1, lblLector2, lblLector3, lblLector4 };
            lblAcciones = new Label[] { lblAccion1, lblAccion2, lblAccion3, lblAccion4 };
            lblUsuarios = new Label[] { lblUsuario1, lblUsuario2, lblUsuario3, lblUsuario4 };
            lblUbicaciones = new Label[] { lblUbicacion1, lblUbicacion2, lblUbicacion3, lblUbicacion4 };
            serialesLectores = new string[lblLectores.Length];
            direccionesPLC = new string[lblLectores.Length]; // inicializamos array de direcciones


            DataTable dt = db.ExecuteQuery("SELECT nombre, serie, ubicacion, direccion_plc FROM lectores", null);

            for (int i = 0; i < dt.Rows.Count && i < lblLectores.Length; i++)
            {
                string serie = dt.Rows[i]["serie"].ToString().Trim();
                lblLectores[i].Text = dt.Rows[i]["nombre"].ToString();
                serialesLectores[i] = serie;
                lblAcciones[i].Text = "";
                lblUsuarios[i].Text = "";
                lblUbicaciones[i].Text = dt.Rows[i]["ubicacion"].ToString();
                location = dt.Rows[i]["ubicacion"].ToString();
                direccionesPLC[i] = dt.Rows[i]["direccion_plc"].ToString();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            cargar_lectores();
            IniciarCaptura();
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            this.Invoke(new Action(() =>
            {
                string usuario = VerificarUsuario(Sample) ?? "Desconocido";

                int index = Array.FindIndex(serialesLectores, s => s.Trim().Equals(ReaderSerialNumber.Trim(), StringComparison.OrdinalIgnoreCase));
                if (index != -1)
                {
                    //lblAcciones[index].Text = $"📌 Tocado - {ReaderSerialNumber}";
                    lblAcciones[index].Text = $"📌 Activado";
                    lblAcciones[index].ForeColor = Color.Green;
                    lblUsuarios[index].Text = usuario;
                    RegistrarLog(ReaderSerialNumber.ToString(), usuario);
                    db.EscribirBoolPLC(direccionesPLC[index], true);
                    _ = Task.Run(async () =>
                    {
                        await Task.Delay(2000); // 2000 ms = 2 segundos
                        db.EscribirBoolPLC(direccionesPLC[index], false);
                    });



                }
            }));
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber) { }
        public void OnFingerGone(object Capture, string ReaderSerialNumber) { }
        public void OnReaderConnect(object Capture, string ReaderSerialNumber) { }
        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber) { }
        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback Feedback) { }

        private void MarcarLector(string serieLector, Sample sample)
        {
            serieLector = serieLector.Trim();
            int index = Array.FindIndex(serialesLectores, s => s.Trim().Equals(serieLector, StringComparison.OrdinalIgnoreCase));
            if (index == -1) return;

            lblAcciones[index].Text = $"📌 Tocado - {serieLector}";

            // -------------------------
            // Extracción de features
            // -------------------------
            FeatureSet features = new FeatureSet();
            CaptureFeedback feedback = CaptureFeedback.None;

            try
            {
                DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
                extractor.CreateFeatureSet(sample, DPFP.Processing.DataPurpose.Verification, ref feedback, ref features);

                if (feedback == DPFP.Capture.CaptureFeedback.Good)
                {
                    byte[] huellaBytes = null;
                    features.Serialize(ref huellaBytes);

                    database db = new database();
                    DataTable dtUsuarios = db.ExecuteQuery("SELECT id, nombre, numero_empleado, huella1, huella2, huella3 FROM usuarios", null);

                    string nombreUsuario = "Desconocido";
                    int empleadoId = 0;
                    string empleadoNumero = "";

                    foreach (DataRow row in dtUsuarios.Rows)
                    {
                        if ((row["huella1"] as byte[])?.SequenceEqual(huellaBytes) == true ||
                            (row["huella2"] as byte[])?.SequenceEqual(huellaBytes) == true ||
                            (row["huella3"] as byte[])?.SequenceEqual(huellaBytes) == true)
                        {
                            nombreUsuario = row["nombre"].ToString();
                            empleadoId = Convert.ToInt32(row["id"]);
                            empleadoNumero = row["numero_empleado"].ToString();
                            break;
                        }
                    }

                    lblUsuarios[index].Text = nombreUsuario;

                    // -------------------------
                    // Registrar en log_huellas si se encontró usuario
                    // -------------------------
                    if (nombreUsuario != "Desconocido")
                    {
                        try
                        {
                            string logQuery = @"INSERT INTO log_huellas
                                        (lector_serie, empleado_numero, estado)
                                        VALUES ( @serie, @num, @estado)";
                            var parametros = new Dictionary<string, object>
                    {

                        {"@serie", serieLector},
                        {"@num", empleadoNumero},
                        {"@estado", "OK"}
                    };
                            db.ExecuteNonQuery(logQuery, parametros);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error registrando log: " + ex.Message);
                        }
                    }
                }
                else
                {
                    lblUsuarios[index].Text = "Mala calidad";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error extrayendo huella: " + ex.Message);
            }
        }




        private void IniciarCaptura()
        {
            try
            {
                ReadersCollection readers = new ReadersCollection();
                if (readers.Count == 0)
                {
                    string mensaje = "No se detecta ningún lector";

                    // Mostrar MessageBox
                    MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // Actualizar lblLector
                    lblLector.Text = mensaje;
                    lblLector.ForeColor = Color.Red;

                    return;
                }

                foreach (var reader in readers)
                {
                    try
                    {
                        Capture cap = new Capture(reader.Value.SerialNumber);
                        cap.EventHandler = this;
                        cap.StartCapture();
                        capturadores.Add(cap);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"No se pudo iniciar lector {reader.Value.SerialNumber}: {ex.Message}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar captura: " + ex.Message);
            }
        }
        private string VerificarUsuario(DPFP.Sample sample)
        {
            // Extraer características del sample para verificación
            DPFP.FeatureSet features = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification);
            if (features == null) return null;

            DPFP.Verification.Verification verificator = new DPFP.Verification.Verification();
            DPFP.Verification.Verification.Result result = new DPFP.Verification.Verification.Result();

            database db = new database();
            DataTable dt = db.ExecuteQuery("SELECT id, numero_empleado, nombre, huella1, huella2, huella3 FROM usuarios WHERE huella1 IS NOT NULL OR huella2 IS NOT NULL OR huella3 IS NOT NULL", null);

            foreach (DataRow row in dt.Rows)
            {
                DPFP.Template template;

                for (int i = 1; i <= 3; i++)
                {
                    if (row[$"huella{i}"] == DBNull.Value) continue;

                    using (var ms = new System.IO.MemoryStream((byte[])row[$"huella{i}"]))
                    {
                        template = new DPFP.Template(ms);
                    }

                    verificator.Verify(features, template, ref result);

                    if (result.Verified)
                    {
                        // Retornamos el nombre del usuario si coincide
                        return row["numero_empleado"].ToString();
                    }
                }
            }

            return null; // No encontrado
        }
        private DPFP.FeatureSet ExtractFeatures(DPFP.Sample sample, DPFP.Processing.DataPurpose purpose)
        {
            try
            {
                DPFP.Processing.FeatureExtraction extractor = new DPFP.Processing.FeatureExtraction();
                DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
                DPFP.FeatureSet features = new DPFP.FeatureSet();
                extractor.CreateFeatureSet(sample, purpose, ref feedback, ref features);

                if (feedback == DPFP.Capture.CaptureFeedback.Good)
                    return features;
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }
        private void RegistrarLog(string lectorSerie, string empleadoNumero)
        {
            try
            {
                database db = new database();

                string query = @"INSERT INTO log_huellas 
                             (lector_serie, empleado_numero, estado)
                             VALUES (@serie,@num, @estado)";

                var parametros = new Dictionary<string, object>
            {
                {"@serie", lectorSerie},
                {"@num", empleadoNumero},
                {"@estado", "OK"}
            };

                db.ExecuteNonQuery(query, parametros);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar log: " + ex.Message);
            }
        }

        private void verLectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readers frm = new readers();
            frm.ShowDialog();
        }

        private void caputarurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_reader frm = new add_reader();
            frm.ShowDialog();
        }

        private void modificarLectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_reader frm = new add_reader();
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            update_reader frm = new update_reader();
            frm.ShowDialog();
        }

        private void configurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config_database frm = new config_database();
            frm.ShowDialog();
        }

        private void probarConexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            database db = new database();
            if (db.OpenConnection())
            {
                MessageBox.Show("✅ Conexión exitosa a la BD!");
                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("❌ Error en la conexión.");
            }
        }

        private void lblUsuario1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cargarLectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargar_lectores();
        }

        private void abirPLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
       

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            config_plc frm = new config_plc();
            frm.ShowDialog();
        }
    }
}

