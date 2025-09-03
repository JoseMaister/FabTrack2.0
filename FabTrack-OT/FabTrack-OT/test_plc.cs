using System;
using System.Windows.Forms;
using S7.Net;

namespace FabTrack_OT
{
    public partial class test_plc : Form
    {
        public test_plc()
        {
            InitializeComponent();
        }

        // PLC y lista de tags
        Plc PLC = new Plc(CpuType.S71200, "192.168.0.1", 0, 0);
        class_tag_list Tag_List = new class_tag_list();

        // Timer de Windows Forms para escaneo
        private System.Windows.Forms.Timer plcTimer = new System.Windows.Forms.Timer();

        private void test_plc_Load(object sender, EventArgs e)
        {
            try
            {
                PLC.Open();
                if (PLC.IsConnected)
                {
                    // Configurar timer
                    plcTimer.Interval = 1000; // 1 segundo
                    plcTimer.Tick += PLC_tagScan_Tick;
                    plcTimer.Enabled = true;
                }
                else
                {
                    MessageBox.Show("No se pudo conectar con el PLC.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el PLC: " + ex.Message);
            }
        }

        private void PLC_tagScan_Tick(object sender, EventArgs e)
        {
            try
            {
                var PLC_DB = 1;
                PLC.ReadClass(Tag_List, PLC_DB);

                // Actualizar TextBox con datos del PLC
                textBox1.Text = class_tag_list.DB_B_1.ToString();
                textBox2.Text = class_tag_list.DB_B.ToString();
                textBox3.Text = class_tag_list.DB_I.ToString();
                textBox4.Text = class_tag_list.DB_R.ToString("0.00");
            }
            catch (Exception ex)
            {
                // Mostrar error si falla lectura
                MessageBox.Show("Error al leer datos del PLC: " + ex.Message);
            }
        }
    }
}
