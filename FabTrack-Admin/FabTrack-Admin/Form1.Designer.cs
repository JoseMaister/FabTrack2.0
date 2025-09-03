namespace FabTrack_Admin
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            configurarBaseDeDatosToolStripMenuItem = new ToolStripMenuItem();
            testConexionToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            capturarLectorToolStripMenuItem = new ToolStripMenuItem();
            accionesToolStripMenuItem = new ToolStripMenuItem();
            altaUsuariosToolStripMenuItem = new ToolStripMenuItem();
            verUsuariosToolStripMenuItem = new ToolStripMenuItem();
            modificarUsuariosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configToolStripMenuItem, accionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarBaseDeDatosToolStripMenuItem, testConexionToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // configurarBaseDeDatosToolStripMenuItem
            // 
            configurarBaseDeDatosToolStripMenuItem.Name = "configurarBaseDeDatosToolStripMenuItem";
            configurarBaseDeDatosToolStripMenuItem.Size = new Size(206, 22);
            configurarBaseDeDatosToolStripMenuItem.Text = "Configurar base de datos";
            configurarBaseDeDatosToolStripMenuItem.Click += configurarBaseDeDatosToolStripMenuItem_Click;
            // 
            // testConexionToolStripMenuItem
            // 
            testConexionToolStripMenuItem.Name = "testConexionToolStripMenuItem";
            testConexionToolStripMenuItem.Size = new Size(206, 22);
            testConexionToolStripMenuItem.Text = "Probar Conexion";
            testConexionToolStripMenuItem.Click += testConexionToolStripMenuItem_Click;
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { capturarLectorToolStripMenuItem });
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // capturarLectorToolStripMenuItem
            // 
            capturarLectorToolStripMenuItem.Name = "capturarLectorToolStripMenuItem";
            capturarLectorToolStripMenuItem.Size = new Size(156, 22);
            capturarLectorToolStripMenuItem.Text = "Capturar Lector";
            capturarLectorToolStripMenuItem.Click += capturarLectorToolStripMenuItem_Click;
            // 
            // accionesToolStripMenuItem
            // 
            accionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { altaUsuariosToolStripMenuItem, verUsuariosToolStripMenuItem, modificarUsuariosToolStripMenuItem, reportesToolStripMenuItem });
            accionesToolStripMenuItem.Name = "accionesToolStripMenuItem";
            accionesToolStripMenuItem.Size = new Size(67, 20);
            accionesToolStripMenuItem.Text = "Acciones";
            // 
            // altaUsuariosToolStripMenuItem
            // 
            altaUsuariosToolStripMenuItem.Name = "altaUsuariosToolStripMenuItem";
            altaUsuariosToolStripMenuItem.Size = new Size(173, 22);
            altaUsuariosToolStripMenuItem.Text = "Alta Usuarios";
            altaUsuariosToolStripMenuItem.Click += altaUsuariosToolStripMenuItem_Click;
            // 
            // verUsuariosToolStripMenuItem
            // 
            verUsuariosToolStripMenuItem.Name = "verUsuariosToolStripMenuItem";
            verUsuariosToolStripMenuItem.Size = new Size(173, 22);
            verUsuariosToolStripMenuItem.Text = "Ver Usuarios";
            verUsuariosToolStripMenuItem.Click += verUsuariosToolStripMenuItem_Click;
            // 
            // modificarUsuariosToolStripMenuItem
            // 
            modificarUsuariosToolStripMenuItem.Name = "modificarUsuariosToolStripMenuItem";
            modificarUsuariosToolStripMenuItem.Size = new Size(173, 22);
            modificarUsuariosToolStripMenuItem.Text = "Modificar Usuarios";
            modificarUsuariosToolStripMenuItem.Click += modificarUsuariosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(173, 22);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FabTrack Admin";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem capturarLectorToolStripMenuItem;
        private ToolStripMenuItem accionesToolStripMenuItem;
        private ToolStripMenuItem altaUsuariosToolStripMenuItem;
        private ToolStripMenuItem verUsuariosToolStripMenuItem;
        private ToolStripMenuItem modificarUsuariosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem configurarBaseDeDatosToolStripMenuItem;
        private ToolStripMenuItem testConexionToolStripMenuItem;
    }
}
