namespace FabTrack_Admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void capturarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_reader frm = new add_reader();
            frm.ShowDialog();
        }

        private void altaUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.ShowDialog();

        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios frm = new Usuarios();
            frm.ShowDialog();

        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_user frm = new update_user();
            frm.ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reports frm = new reports();
            frm.ShowDialog();
        }

        private void testConexionToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void configurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config_database frm = new config_database();
            frm.ShowDialog();
        }
    }
}
