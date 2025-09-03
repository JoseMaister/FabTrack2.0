namespace FabTrack_OT
{
    partial class readers
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
            button2 = new Button();
            txtBuscar = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            dtReaders = new DataGridView();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtReaders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(txtBuscar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(23, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(723, 100);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(471, 28);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 4;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(182, 33);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(265, 23);
            txtBuscar.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 28);
            label1.Name = "label1";
            label1.Size = new Size(141, 25);
            label1.TabIndex = 3;
            label1.Text = "Nombre Lector";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtReaders);
            panel2.Location = new Point(23, 118);
            panel2.Name = "panel2";
            panel2.Size = new Size(723, 270);
            panel2.TabIndex = 5;
            // 
            // dtReaders
            // 
            dtReaders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtReaders.Location = new Point(15, 12);
            dtReaders.Name = "dtReaders";
            dtReaders.Size = new Size(692, 245);
            dtReaders.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(23, 401);
            button1.Name = "button1";
            button1.Size = new Size(117, 37);
            button1.TabIndex = 6;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // readers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "readers";
            Text = "Lectores";
            Load += readers_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtReaders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private TextBox txtBuscar;
        private Label label1;
        private Panel panel2;
        private DataGridView dtReaders;
        private Button button1;
    }
}