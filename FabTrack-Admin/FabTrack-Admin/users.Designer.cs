namespace FabTrack_Admin
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            chbinactivos = new CheckBox();
            txtBuscar = new TextBox();
            button2 = new Button();
            rbNoEmpleado = new RadioButton();
            rbNombre = new RadioButton();
            panel2 = new Panel();
            dtUsers = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtUsers).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(chbinactivos);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(rbNoEmpleado);
            panel1.Controls.Add(rbNombre);
            panel1.Location = new Point(16, 15);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 68);
            panel1.TabIndex = 0;
            // 
            // chbinactivos
            // 
            chbinactivos.AutoSize = true;
            chbinactivos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbinactivos.Location = new Point(35, 14);
            chbinactivos.Name = "chbinactivos";
            chbinactivos.Size = new Size(110, 29);
            chbinactivos.TabIndex = 4;
            chbinactivos.Text = "Inactivos";
            chbinactivos.UseVisualStyleBackColor = true;
            chbinactivos.CheckedChanged += chbinactivos_CheckedChanged;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(471, 18);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(146, 23);
            txtBuscar.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(623, 12);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // rbNoEmpleado
            // 
            rbNoEmpleado.AutoSize = true;
            rbNoEmpleado.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbNoEmpleado.Location = new Point(314, 13);
            rbNoEmpleado.Name = "rbNoEmpleado";
            rbNoEmpleado.Size = new Size(151, 29);
            rbNoEmpleado.TabIndex = 1;
            rbNoEmpleado.TabStop = true;
            rbNoEmpleado.Text = "No. Empleado";
            rbNoEmpleado.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            rbNombre.AutoSize = true;
            rbNombre.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbNombre.Location = new Point(188, 14);
            rbNombre.Name = "rbNombre";
            rbNombre.Size = new Size(101, 29);
            rbNombre.TabIndex = 0;
            rbNombre.TabStop = true;
            rbNombre.Text = "Nombre";
            rbNombre.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dtUsers);
            panel2.Location = new Point(16, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 287);
            panel2.TabIndex = 1;
            // 
            // dtUsers
            // 
            dtUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtUsers.Location = new Point(13, 19);
            dtUsers.Name = "dtUsers";
            dtUsers.Size = new Size(744, 201);
            dtUsers.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(16, 401);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 4;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Usuarios";
            Text = "Usuarios";
            Load += Usuarios_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton rbNombre;
        private RadioButton rbNoEmpleado;
        private Button button2;
        private Panel panel2;
        private TextBox txtBuscar;
        private DataGridView dtUsers;
        private Button button1;
        private CheckBox chbinactivos;
    }
}