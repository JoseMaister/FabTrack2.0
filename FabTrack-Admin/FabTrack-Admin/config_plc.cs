using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FabTrack_Admin
{
    public partial class config_plc : Form
    {
        private string configPath;

        public config_plc()
        {
            InitializeComponent();

            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FabTrack");
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);
            configPath = Path.Combine(folder, "config.json");

            CargarConfig();
        }

        private void CargarConfig()
        {
            if (!File.Exists(configPath))
                return;

            try
            {
                string json = File.ReadAllText(configPath);
                var root = JsonSerializer.Deserialize<ConfigRoot>(json);

                if (root.PLC != null)
                {
                    txtIp.Text = root.PLC.IpAddress;
                    numRack.Value = root.PLC.Rack;
                    numSlot.Value = root.PLC.Slot;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando configuración PLC: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ConfigRoot root;

                if (File.Exists(configPath))
                {
                    string json = File.ReadAllText(configPath);
                    root = JsonSerializer.Deserialize<ConfigRoot>(json);
                }
                else
                {
                    root = new ConfigRoot();
                    root.Database = new DbConfig(); // mantenemos la sección BD
                }

                root.PLC = new PlcConfig
                {
                    IpAddress = txtIp.Text,
                    Rack = (short)numRack.Value,
                    Slot = (short)numSlot.Value
                };

                string updatedJson = JsonSerializer.Serialize(root, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(configPath, updatedJson);

                MessageBox.Show("✅ Configuración del PLC guardada correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error guardando configuración PLC: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
