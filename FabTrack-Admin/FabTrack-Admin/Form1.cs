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

        private void verLectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readers frm = new readers();
            frm.ShowDialog();
        }

        private void modificarLectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update_reader frm = new update_reader();
            frm.ShowDialog();
        }

        private void acercaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensaje =
"Acerca de esta aplicación\n\n" +
"Esta aplicación ha sido desarrollada y personalizada por InnovateX de México para el cliente final ZF-LifeTec, adquirida a través de su proveedor autorizado Grupo Regel.\n\n" +
"Su propósito principal es activar la estación de trabajo correspondiente mediante la captura de huella digital, dependiendo del lector utilizado. De esta manera, se garantiza un control seguro, eficiente y exclusivo del acceso y funcionamiento de la estación asignada.\n\n" +
"Soporte y asistencia técnica\n\n" +
"Para cualquier duda, incidencia o solicitud de soporte:\n" +
"1. Primer canal de contacto: Su proveedor autorizado Grupo Regel, quien le vendió la aplicación y podrá atender la mayoría de sus requerimientos.\n" +
"2. Contacto directo con InnovateX: Si tras este proceso el problema persiste y se confirma que está estrictamente relacionado con la aplicación de software, podrá comunicarse directamente con nosotros a través de:\n" +
"🌐 Sitio web: https://innovatexmexico.com\n\n" +
"Aviso legal y propiedad intelectual\n\n" +
"Esta aplicación es propiedad intelectual de InnovateX de México y ha sido autorizada exclusivamente para su instalación y uso en los equipos designados del cliente final ZF-LifeTec.\n\n" +
"Queda estrictamente prohibido:\n" +
"- Instalarla en equipos no autorizados.\n" +
"- Copiar, distribuir o modificar el software sin consentimiento expreso y por escrito de InnovateX de México.\n\n" +
"Cualquier uso no autorizado podrá derivar en acciones legales conforme a la normativa vigente en materia de propiedad intelectual y uso de software.\n\n" +
"Protección adicional\n\n" +
"El contenido de esta aplicación incluye marcas de agua digitales y códigos internos que permiten identificar la instalación y el equipo autorizado, asegurando que la aplicación no pueda ser reproducida o distribuida de forma no autorizada.";

            MessageBox.Show(mensaje, "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void configurarPLCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            config_plc frm = new config_plc();
            frm.ShowDialog();
        }
    }
}
