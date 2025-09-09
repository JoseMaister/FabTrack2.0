namespace FabTrack_OT
{
    partial class reports
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
            panel2 = new Panel();
            dtReport = new DataGridView();
            panel1 = new Panel();
            button2 = new Button();
            label2 = new Label();
            cbMes = new ComboBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtReport).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dtReport);
            panel2.Location = new Point(14, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(772, 287);
            panel2.TabIndex = 3;
            // 
            // dtReport
            // 
            dtReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtReport.Location = new Point(13, 19);
            dtReport.Name = "dtReport";
            dtReport.Size = new Size(744, 201);
            dtReport.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cbMes);
            panel1.Location = new Point(14, 37);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 68);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(490, 19);
            button2.Name = "button2";
            button2.Size = new Size(117, 37);
            button2.TabIndex = 6;
            button2.Text = "Exportar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 19);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 4;
            label2.Text = "Seleccionar Mes";
            // 
            // cbMes
            // 
            cbMes.FormattingEnabled = true;
            cbMes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            cbMes.Location = new Point(180, 21);
            cbMes.Name = "cbMes";
            cbMes.Size = new Size(267, 23);
            cbMes.TabIndex = 5;
            cbMes.SelectedIndexChanged += cbMes_SelectedIndexChanged;
            // 
            // reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "reports";
            Text = "reports";
            Load += reports_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtReport).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dtReport;
        private Panel panel1;
        private Label label2;
        private ComboBox cbMes;
        private Button button2;
    }
}