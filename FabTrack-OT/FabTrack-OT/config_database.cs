using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace FabTrack_OT
{
    public partial class config_database : Form
    {
        // Carpeta dentro del perfil del usuario
        private readonly string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FabTrack");
        private readonly string path;

        public config_database()
        {
            InitializeComponent();

            // Definir ruta completa del JSON
            path = Path.Combine(folder, "config.json");

            // Asegurar que la carpeta exista
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // Asegurar que el archivo exista
            if (!File.Exists(path))
            {
                var defaultConfig = new ConfigRoot
                {
                    Database = new DbConfig
                    {
                        Server = "localhost",
                        Database = "fabtrack",
                        User = "root",
                        Password = "",
                        SslMode = "none"
                    }
                };

                string defaultJson = JsonSerializer.Serialize(defaultConfig, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, defaultJson);
            }

            config_database_Load();
        }

        private void config_database_Load()
        {
            try
            {
                string json = File.ReadAllText(path); // Lee el JSON
                var root = JsonSerializer.Deserialize<ConfigRoot>(json); // Deserializa

                // Asigna los valores a los controles del formulario
                txtServer.Text = root.Database.Server;
                txtDatabase.Text = root.Database.Database;
                txtUser.Text = root.Database.User;
                txtPassword.Text = root.Database.Password;
                cmbSslMode.Text = root.Database.SslMode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando configuración: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var config = new ConfigRoot
                {
                    Database = new DbConfig
                    {
                        Server = txtServer.Text,
                        Database = txtDatabase.Text,
                        User = txtUser.Text,
                        Password = txtPassword.Text,
                        SslMode = cmbSslMode.Text
                    }
                };

                string json = JsonSerializer.Serialize(config, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(path, json);

                MessageBox.Show("Configuración guardada correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando configuración: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}
