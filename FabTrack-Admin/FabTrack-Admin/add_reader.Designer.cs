namespace FabTrack_Admin
{
    partial class add_reader
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
            cbLectores = new ComboBox();
            txtname = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Location = new Point(186, 215);
            panel3.Name = "panel3";
            panel3.Size = new Size(302, 100);
            panel3.TabIndex = 12;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(156, 39);
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
            panel2.Controls.Add(cbLectores);
            panel2.Controls.Add(txtname);
            panel2.Location = new Point(334, 92);
            panel2.Name = "panel2";
            panel2.Size = new Size(375, 117);
            panel2.TabIndex = 11;
            // 
            // cbLectores
            // 
            cbLectores.FormattingEnabled = true;
            cbLectores.Location = new Point(8, 65);
            cbLectores.Name = "cbLectores";
            cbLectores.Size = new Size(267, 23);
            cbLectores.TabIndex = 3;
            // 
            // txtname
            // 
            txtname.Location = new Point(8, 20);
            txtname.Name = "txtname";
            txtname.Size = new Size(265, 23);
            txtname.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(92, 92);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 117);
            panel1.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(83, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 60);
            label2.Name = "label2";
            label2.Size = new Size(156, 25);
            label2.TabIndex = 1;
            label2.Text = "Numero de Serie";
            // 
            // add_reader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "add_reader";
            Text = "Agregar Lector";
            Load += add_reader_Load_1;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private TextBox txtname;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private ComboBox cbLectores;
    }
}