namespace FabTrack_OT
{
    partial class config_database
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
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            txtPassword = new TextBox();
            txtUser = new TextBox();
            txtDatabase = new TextBox();
            cmbSslMode = new ComboBox();
            txtServer = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(88, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 215);
            panel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 141);
            label4.Name = "label4";
            label4.Size = new Size(109, 25);
            label4.TabIndex = 3;
            label4.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 0;
            label1.Text = "Servidor/IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(129, 25);
            label2.TabIndex = 1;
            label2.Text = "Base de datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(29, 178);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 4;
            label5.Text = "SslMode";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(77, 25);
            label3.TabIndex = 2;
            label3.Text = "Usuario";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUser);
            panel2.Controls.Add(txtDatabase);
            panel2.Controls.Add(cmbSslMode);
            panel2.Controls.Add(txtServer);
            panel2.Location = new Point(355, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 215);
            panel2.TabIndex = 9;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(27, 143);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(178, 23);
            txtPassword.TabIndex = 9;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(27, 105);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(178, 23);
            txtUser.TabIndex = 8;
            // 
            // txtDatabase
            // 
            txtDatabase.Location = new Point(27, 65);
            txtDatabase.Name = "txtDatabase";
            txtDatabase.Size = new Size(178, 23);
            txtDatabase.TabIndex = 7;
            // 
            // cmbSslMode
            // 
            cmbSslMode.FormattingEnabled = true;
            cmbSslMode.Items.AddRange(new object[] { "none" });
            cmbSslMode.Location = new Point(27, 178);
            cmbSslMode.Name = "cmbSslMode";
            cmbSslMode.Size = new Size(178, 23);
            cmbSslMode.TabIndex = 6;
            // 
            // txtServer
            // 
            txtServer.Location = new Point(27, 25);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(178, 23);
            txtServer.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(189, 246);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 100);
            panel3.TabIndex = 10;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(156, 39);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 1;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(8, 39);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(button4);
            panel4.Location = new Point(189, 352);
            panel4.Name = "panel4";
            panel4.Size = new Size(302, 66);
            panel4.TabIndex = 11;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(8, 14);
            button4.Name = "button4";
            button4.Size = new Size(281, 37);
            button4.TabIndex = 0;
            button4.Text = "Probar conexion";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // config_database
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "config_database";
            Text = "Configurar base de datos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label5;
        private Label label3;
        private Panel panel2;
        private TextBox txtPassword;
        private TextBox txtUser;
        private TextBox txtDatabase;
        private ComboBox cmbSslMode;
        private TextBox txtServer;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel4;
        private Button button4;
    }
}