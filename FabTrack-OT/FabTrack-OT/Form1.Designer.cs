namespace FabTrack_OT
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            configurarBaseDeDatosToolStripMenuItem = new ToolStripMenuItem();
            probarConexionToolStripMenuItem = new ToolStripMenuItem();
            abirPLCToolStripMenuItem = new ToolStripMenuItem();
            configToolStripMenuItem = new ToolStripMenuItem();
            caputarurToolStripMenuItem = new ToolStripMenuItem();
            verLectoresToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cargarLectoresToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            lblUbicacion1 = new Label();
            lblUsuario1 = new Label();
            lblAccion1 = new Label();
            lblLector1 = new Label();
            panel2 = new Panel();
            lblUbicacion3 = new Label();
            lblUsuario3 = new Label();
            lblAccion3 = new Label();
            lblLector3 = new Label();
            panel3 = new Panel();
            lblUbicacion2 = new Label();
            lblUsuario2 = new Label();
            lblAccion2 = new Label();
            lblLector2 = new Label();
            panel4 = new Panel();
            lblUbicacion4 = new Label();
            lblUsuario4 = new Label();
            lblAccion4 = new Label();
            lblLector4 = new Label();
            lblLector = new Label();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, configToolStripMenuItem, cargarLectoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { configurarBaseDeDatosToolStripMenuItem, probarConexionToolStripMenuItem, abirPLCToolStripMenuItem, toolStripMenuItem2 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // configurarBaseDeDatosToolStripMenuItem
            // 
            configurarBaseDeDatosToolStripMenuItem.Name = "configurarBaseDeDatosToolStripMenuItem";
            configurarBaseDeDatosToolStripMenuItem.Size = new Size(206, 22);
            configurarBaseDeDatosToolStripMenuItem.Text = "Configurar base de datos";
            configurarBaseDeDatosToolStripMenuItem.Click += configurarBaseDeDatosToolStripMenuItem_Click;
            // 
            // probarConexionToolStripMenuItem
            // 
            probarConexionToolStripMenuItem.Name = "probarConexionToolStripMenuItem";
            probarConexionToolStripMenuItem.Size = new Size(206, 22);
            probarConexionToolStripMenuItem.Text = "Probar Conexion";
            probarConexionToolStripMenuItem.Click += probarConexionToolStripMenuItem_Click;
            // 
            // abirPLCToolStripMenuItem
            // 
            abirPLCToolStripMenuItem.Name = "abirPLCToolStripMenuItem";
            abirPLCToolStripMenuItem.Size = new Size(206, 22);
            abirPLCToolStripMenuItem.Text = "Abir PLC";
            abirPLCToolStripMenuItem.Click += abirPLCToolStripMenuItem_Click;
            // 
            // configToolStripMenuItem
            // 
            configToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caputarurToolStripMenuItem, verLectoresToolStripMenuItem, toolStripMenuItem1 });
            configToolStripMenuItem.Name = "configToolStripMenuItem";
            configToolStripMenuItem.Size = new Size(55, 20);
            configToolStripMenuItem.Text = "Config";
            // 
            // caputarurToolStripMenuItem
            // 
            caputarurToolStripMenuItem.Name = "caputarurToolStripMenuItem";
            caputarurToolStripMenuItem.Size = new Size(158, 22);
            caputarurToolStripMenuItem.Text = "Capturar Lector";
            caputarurToolStripMenuItem.Click += caputarurToolStripMenuItem_Click;
            // 
            // verLectoresToolStripMenuItem
            // 
            verLectoresToolStripMenuItem.Name = "verLectoresToolStripMenuItem";
            verLectoresToolStripMenuItem.Size = new Size(158, 22);
            verLectoresToolStripMenuItem.Text = "Ver lectores";
            verLectoresToolStripMenuItem.Click += verLectoresToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(158, 22);
            toolStripMenuItem1.Text = "Modificar lector";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // cargarLectoresToolStripMenuItem
            // 
            cargarLectoresToolStripMenuItem.Name = "cargarLectoresToolStripMenuItem";
            cargarLectoresToolStripMenuItem.Size = new Size(98, 20);
            cargarLectoresToolStripMenuItem.Text = "Cargar lectores";
            cargarLectoresToolStripMenuItem.Click += cargarLectoresToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblUbicacion1);
            panel1.Controls.Add(lblUsuario1);
            panel1.Controls.Add(lblAccion1);
            panel1.Controls.Add(lblLector1);
            panel1.Location = new Point(12, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 148);
            panel1.TabIndex = 3;
            // 
            // lblUbicacion1
            // 
            lblUbicacion1.AutoSize = true;
            lblUbicacion1.BorderStyle = BorderStyle.FixedSingle;
            lblUbicacion1.FlatStyle = FlatStyle.Flat;
            lblUbicacion1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbicacion1.Location = new Point(0, 107);
            lblUbicacion1.Name = "lblUbicacion1";
            lblUbicacion1.Size = new Size(2, 27);
            lblUbicacion1.TabIndex = 4;
            // 
            // lblUsuario1
            // 
            lblUsuario1.AutoSize = true;
            lblUsuario1.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario1.FlatStyle = FlatStyle.Flat;
            lblUsuario1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario1.Location = new Point(0, 75);
            lblUsuario1.Name = "lblUsuario1";
            lblUsuario1.Size = new Size(2, 27);
            lblUsuario1.TabIndex = 3;
            lblUsuario1.Click += lblUsuario1_Click;
            // 
            // lblAccion1
            // 
            lblAccion1.AutoSize = true;
            lblAccion1.BorderStyle = BorderStyle.FixedSingle;
            lblAccion1.FlatStyle = FlatStyle.Flat;
            lblAccion1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion1.Location = new Point(0, 40);
            lblAccion1.Name = "lblAccion1";
            lblAccion1.Size = new Size(2, 27);
            lblAccion1.TabIndex = 2;
            // 
            // lblLector1
            // 
            lblLector1.AutoSize = true;
            lblLector1.BorderStyle = BorderStyle.FixedSingle;
            lblLector1.FlatStyle = FlatStyle.Flat;
            lblLector1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector1.Location = new Point(0, 0);
            lblLector1.Name = "lblLector1";
            lblLector1.Size = new Size(2, 27);
            lblLector1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lblUbicacion3);
            panel2.Controls.Add(lblUsuario3);
            panel2.Controls.Add(lblAccion3);
            panel2.Controls.Add(lblLector3);
            panel2.Location = new Point(12, 241);
            panel2.Name = "panel2";
            panel2.Size = new Size(380, 148);
            panel2.TabIndex = 4;
            panel2.Paint += panel2_Paint;
            // 
            // lblUbicacion3
            // 
            lblUbicacion3.AutoSize = true;
            lblUbicacion3.BorderStyle = BorderStyle.FixedSingle;
            lblUbicacion3.FlatStyle = FlatStyle.Flat;
            lblUbicacion3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbicacion3.Location = new Point(-1, 110);
            lblUbicacion3.Name = "lblUbicacion3";
            lblUbicacion3.Size = new Size(2, 27);
            lblUbicacion3.TabIndex = 6;
            // 
            // lblUsuario3
            // 
            lblUsuario3.AutoSize = true;
            lblUsuario3.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario3.FlatStyle = FlatStyle.Flat;
            lblUsuario3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario3.Location = new Point(0, 75);
            lblUsuario3.Name = "lblUsuario3";
            lblUsuario3.Size = new Size(2, 27);
            lblUsuario3.TabIndex = 3;
            // 
            // lblAccion3
            // 
            lblAccion3.AutoSize = true;
            lblAccion3.BorderStyle = BorderStyle.FixedSingle;
            lblAccion3.FlatStyle = FlatStyle.Flat;
            lblAccion3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion3.Location = new Point(0, 40);
            lblAccion3.Name = "lblAccion3";
            lblAccion3.Size = new Size(2, 27);
            lblAccion3.TabIndex = 2;
            // 
            // lblLector3
            // 
            lblLector3.AutoSize = true;
            lblLector3.BorderStyle = BorderStyle.FixedSingle;
            lblLector3.FlatStyle = FlatStyle.Flat;
            lblLector3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector3.Location = new Point(0, 0);
            lblLector3.Name = "lblLector3";
            lblLector3.Size = new Size(2, 27);
            lblLector3.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblUbicacion2);
            panel3.Controls.Add(lblUsuario2);
            panel3.Controls.Add(lblAccion2);
            panel3.Controls.Add(lblLector2);
            panel3.Location = new Point(408, 87);
            panel3.Name = "panel3";
            panel3.Size = new Size(380, 148);
            panel3.TabIndex = 5;
            // 
            // lblUbicacion2
            // 
            lblUbicacion2.AutoSize = true;
            lblUbicacion2.BorderStyle = BorderStyle.FixedSingle;
            lblUbicacion2.FlatStyle = FlatStyle.Flat;
            lblUbicacion2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbicacion2.Location = new Point(0, 107);
            lblUbicacion2.Name = "lblUbicacion2";
            lblUbicacion2.Size = new Size(2, 27);
            lblUbicacion2.TabIndex = 5;
            // 
            // lblUsuario2
            // 
            lblUsuario2.AutoSize = true;
            lblUsuario2.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario2.FlatStyle = FlatStyle.Flat;
            lblUsuario2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario2.Location = new Point(0, 75);
            lblUsuario2.Name = "lblUsuario2";
            lblUsuario2.Size = new Size(2, 27);
            lblUsuario2.TabIndex = 3;
            // 
            // lblAccion2
            // 
            lblAccion2.AutoSize = true;
            lblAccion2.BorderStyle = BorderStyle.FixedSingle;
            lblAccion2.FlatStyle = FlatStyle.Flat;
            lblAccion2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion2.Location = new Point(0, 40);
            lblAccion2.Name = "lblAccion2";
            lblAccion2.Size = new Size(2, 27);
            lblAccion2.TabIndex = 2;
            // 
            // lblLector2
            // 
            lblLector2.AutoSize = true;
            lblLector2.BorderStyle = BorderStyle.FixedSingle;
            lblLector2.FlatStyle = FlatStyle.Flat;
            lblLector2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector2.Location = new Point(0, 0);
            lblLector2.Name = "lblLector2";
            lblLector2.Size = new Size(2, 27);
            lblLector2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblUbicacion4);
            panel4.Controls.Add(lblUsuario4);
            panel4.Controls.Add(lblAccion4);
            panel4.Controls.Add(lblLector4);
            panel4.Location = new Point(408, 241);
            panel4.Name = "panel4";
            panel4.Size = new Size(380, 148);
            panel4.TabIndex = 6;
            // 
            // lblUbicacion4
            // 
            lblUbicacion4.AutoSize = true;
            lblUbicacion4.BorderStyle = BorderStyle.FixedSingle;
            lblUbicacion4.FlatStyle = FlatStyle.Flat;
            lblUbicacion4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUbicacion4.Location = new Point(0, 110);
            lblUbicacion4.Name = "lblUbicacion4";
            lblUbicacion4.Size = new Size(2, 27);
            lblUbicacion4.TabIndex = 7;
            // 
            // lblUsuario4
            // 
            lblUsuario4.AutoSize = true;
            lblUsuario4.BorderStyle = BorderStyle.FixedSingle;
            lblUsuario4.FlatStyle = FlatStyle.Flat;
            lblUsuario4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario4.Location = new Point(0, 75);
            lblUsuario4.Name = "lblUsuario4";
            lblUsuario4.Size = new Size(2, 27);
            lblUsuario4.TabIndex = 3;
            // 
            // lblAccion4
            // 
            lblAccion4.AutoSize = true;
            lblAccion4.BorderStyle = BorderStyle.FixedSingle;
            lblAccion4.FlatStyle = FlatStyle.Flat;
            lblAccion4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccion4.Location = new Point(0, 40);
            lblAccion4.Name = "lblAccion4";
            lblAccion4.Size = new Size(2, 27);
            lblAccion4.TabIndex = 2;
            // 
            // lblLector4
            // 
            lblLector4.AutoSize = true;
            lblLector4.BorderStyle = BorderStyle.FixedSingle;
            lblLector4.FlatStyle = FlatStyle.Flat;
            lblLector4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector4.Location = new Point(0, 0);
            lblLector4.Name = "lblLector4";
            lblLector4.Size = new Size(2, 27);
            lblLector4.TabIndex = 1;
            // 
            // lblLector
            // 
            lblLector.AutoSize = true;
            lblLector.FlatStyle = FlatStyle.Flat;
            lblLector.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLector.Location = new Point(169, 37);
            lblLector.Name = "lblLector";
            lblLector.Size = new Size(0, 47);
            lblLector.TabIndex = 7;
            lblLector.TextAlign = ContentAlignment.TopCenter;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(206, 22);
            toolStripMenuItem2.Text = "Configurar PLC";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblLector);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "FabTrack";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem;
        private ToolStripMenuItem caputarurToolStripMenuItem;
        private Panel panel1;
        private Label lblUsuario1;
        private Label lblAccion1;
        private Label lblLector1;
        private Panel panel2;
        private Label lblUsuario3;
        private Label lblAccion3;
        private Label lblLector3;
        private Panel panel3;
        private Label lblUsuario2;
        private Label lblAccion2;
        private Label lblLector2;
        private Panel panel4;
        private Label lblUsuario4;
        private Label lblAccion4;
        private Label lblLector4;
        private ToolStripMenuItem verLectoresToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem configurarBaseDeDatosToolStripMenuItem;
        private ToolStripMenuItem probarConexionToolStripMenuItem;
        private Label lblLector;
        private Label lblUbicacion1;
        private Label lblUbicacion3;
        private Label lblUbicacion2;
        private Label lblUbicacion4;
        private ToolStripMenuItem cargarLectoresToolStripMenuItem;
        private ToolStripMenuItem abirPLCToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}
