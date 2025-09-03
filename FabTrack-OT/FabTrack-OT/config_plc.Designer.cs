namespace FabTrack_OT
{
    partial class config_plc
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
            panel3 = new Panel();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            numSlot = new NumericUpDown();
            txtOutput = new TextBox();
            numRack = new NumericUpDown();
            txtIp = new TextBox();
            panel1 = new Panel();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSlot).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRack).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(250, 286);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 100);
            panel3.TabIndex = 13;
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
            // panel2
            // 
            panel2.Controls.Add(numSlot);
            panel2.Controls.Add(txtOutput);
            panel2.Controls.Add(numRack);
            panel2.Controls.Add(txtIp);
            panel2.Location = new Point(416, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 182);
            panel2.TabIndex = 12;
            // 
            // numSlot
            // 
            numSlot.Location = new Point(27, 109);
            numSlot.Name = "numSlot";
            numSlot.Size = new Size(178, 23);
            numSlot.TabIndex = 15;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(27, 143);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(178, 23);
            txtOutput.TabIndex = 9;
            // 
            // numRack
            // 
            numRack.Location = new Point(27, 66);
            numRack.Name = "numRack";
            numRack.Size = new Size(178, 23);
            numRack.TabIndex = 14;
            // 
            // txtIp
            // 
            txtIp.Location = new Point(27, 25);
            txtIp.Name = "txtIp";
            txtIp.Size = new Size(178, 23);
            txtIp.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(149, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 182);
            panel1.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 141);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 3;
            label4.Text = "Output ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(29, 25);
            label1.TabIndex = 0;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Rack ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 103);
            label3.Name = "label3";
            label3.Size = new Size(50, 25);
            label3.TabIndex = 2;
            label3.Text = "Slot ";
            // 
            // config_plc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "config_plc";
            Text = "Configurar PLC";
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSlot).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRack).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox txtOutput;
        private TextBox txtIp;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numSlot;
        private NumericUpDown numRack;
    }
}