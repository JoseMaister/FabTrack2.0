namespace FabTrack_Admin
{
    partial class add_user
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            cb_turno = new ComboBox();
            txtemail = new TextBox();
            txt_telefono = new TextBox();
            txtno_empleado = new TextBox();
            txtmaterno = new TextBox();
            txtpaterno = new TextBox();
            txtname = new TextBox();
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel7 = new Panel();
            txtHuella3 = new TextBox();
            button8 = new Button();
            panel6 = new Panel();
            txtHuella2 = new TextBox();
            button6 = new Button();
            panel5 = new Panel();
            txtHuella1 = new TextBox();
            button4 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre *";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(167, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellido Paterno *";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Apellido Materno *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 141);
            label4.Name = "label4";
            label4.Size = new Size(212, 25);
            label4.TabIndex = 3;
            label4.Text = "Numero de Empleado *";
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
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(29, 216);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 5;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(29, 251);
            label7.Name = "label7";
            label7.Size = new Size(74, 25);
            label7.TabIndex = 6;
            label7.Text = "Turno *";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(91, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 295);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(cb_turno);
            panel2.Controls.Add(txtemail);
            panel2.Controls.Add(txt_telefono);
            panel2.Controls.Add(txtno_empleado);
            panel2.Controls.Add(txtmaterno);
            panel2.Controls.Add(txtpaterno);
            panel2.Controls.Add(txtname);
            panel2.Location = new Point(333, 42);
            panel2.Name = "panel2";
            panel2.Size = new Size(309, 295);
            panel2.TabIndex = 8;
            // 
            // cb_turno
            // 
            cb_turno.FormattingEnabled = true;
            cb_turno.Items.AddRange(new object[] { "1", "2", "3" });
            cb_turno.Location = new Point(8, 256);
            cb_turno.Name = "cb_turno";
            cb_turno.Size = new Size(265, 23);
            cb_turno.TabIndex = 6;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(8, 221);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(265, 23);
            txtemail.TabIndex = 5;
            // 
            // txt_telefono
            // 
            txt_telefono.Location = new Point(8, 183);
            txt_telefono.Name = "txt_telefono";
            txt_telefono.Size = new Size(265, 23);
            txt_telefono.TabIndex = 4;
            // 
            // txtno_empleado
            // 
            txtno_empleado.Location = new Point(8, 146);
            txtno_empleado.Name = "txtno_empleado";
            txtno_empleado.Size = new Size(265, 23);
            txtno_empleado.TabIndex = 3;
            // 
            // txtmaterno
            // 
            txtmaterno.Location = new Point(8, 103);
            txtmaterno.Name = "txtmaterno";
            txtmaterno.Size = new Size(265, 23);
            txtmaterno.TabIndex = 2;
            // 
            // txtpaterno
            // 
            txtpaterno.Location = new Point(8, 60);
            txtpaterno.Name = "txtpaterno";
            txtpaterno.Size = new Size(265, 23);
            txtpaterno.TabIndex = 1;
            // 
            // txtname
            // 
            txtname.Location = new Point(8, 20);
            txtname.Name = "txtname";
            txtname.Size = new Size(265, 23);
            txtname.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(212, 589);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 75);
            panel3.TabIndex = 9;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(159, 22);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 1;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(16, 22);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtHuella3);
            panel7.Controls.Add(button8);
            panel7.Location = new Point(91, 509);
            panel7.Name = "panel7";
            panel7.Size = new Size(551, 74);
            panel7.TabIndex = 18;
            // 
            // txtHuella3
            // 
            txtHuella3.Location = new Point(15, 20);
            txtHuella3.Name = "txtHuella3";
            txtHuella3.ReadOnly = true;
            txtHuella3.Size = new Size(283, 23);
            txtHuella3.TabIndex = 8;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button8.Location = new Point(304, 9);
            button8.Name = "button8";
            button8.Size = new Size(237, 37);
            button8.TabIndex = 1;
            button8.Text = "Agregar huella 3";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtHuella2);
            panel6.Controls.Add(button6);
            panel6.Location = new Point(91, 433);
            panel6.Name = "panel6";
            panel6.Size = new Size(551, 74);
            panel6.TabIndex = 17;
            // 
            // txtHuella2
            // 
            txtHuella2.Location = new Point(15, 23);
            txtHuella2.Name = "txtHuella2";
            txtHuella2.ReadOnly = true;
            txtHuella2.Size = new Size(283, 23);
            txtHuella2.TabIndex = 8;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(304, 12);
            button6.Name = "button6";
            button6.Size = new Size(237, 37);
            button6.TabIndex = 1;
            button6.Text = "Agregar huella 2";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtHuella1);
            panel5.Controls.Add(button4);
            panel5.Location = new Point(91, 358);
            panel5.Name = "panel5";
            panel5.Size = new Size(551, 74);
            panel5.TabIndex = 16;
            // 
            // txtHuella1
            // 
            txtHuella1.Location = new Point(15, 20);
            txtHuella1.Name = "txtHuella1";
            txtHuella1.ReadOnly = true;
            txtHuella1.Size = new Size(283, 23);
            txtHuella1.TabIndex = 8;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(304, 9);
            button4.Name = "button4";
            button4.Size = new Size(237, 37);
            button4.TabIndex = 1;
            button4.Text = "Agregar huella 1";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // add_user
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 673);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "add_user";
            Text = "Agregar Usuario";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private Panel panel2;
        private ComboBox cb_turno;
        private TextBox txtemail;
        private TextBox txt_telefono;
        private TextBox txtno_empleado;
        private TextBox txtmaterno;
        private TextBox txtpaterno;
        private TextBox txtname;
        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel7;
        private TextBox txtHuella3;
        private Button button8;
        private Panel panel6;
        private TextBox txtHuella2;
        private Button button6;
        private Panel panel5;
        private TextBox txtHuella1;
        private Button button4;
    }
}