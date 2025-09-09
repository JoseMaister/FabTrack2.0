using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;

namespace FabTrack_OT
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dtReport.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            try
            {
                // Crear libro y hoja
                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("Reporte");

                    // Escribir encabezados
                    for (int i = 0; i < dtReport.Columns.Count; i++)
                    {
                        worksheet.Cell(1, i + 1).Value = dtReport.Columns[i].HeaderText;
                        worksheet.Cell(1, i + 1).Style.Font.Bold = true;
                    }

                    // Escribir datos
                    for (int i = 0; i < dtReport.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtReport.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = dtReport.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    // Guardar archivo con diálogo de selección de ruta
                    using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "Reporte.xlsx" })
                    {
                        if (sfd.ShowDialog() == DialogResult.OK)
                        {
                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("✅ Exportación completada!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar: " + ex.Message);
            }
        }


        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMes.SelectedIndex == -1) return;

            // Diccionario para convertir nombre de mes a número
            Dictionary<string, int> meses = new Dictionary<string, int>
            {
                {"Enero", 1}, {"Febrero", 2}, {"Marzo", 3}, {"Abril", 4}, {"Mayo", 5}, {"Junio", 6},
                {"Julio", 7}, {"Agosto", 8}, {"Septiembre", 9}, {"Octubre", 10}, {"Noviembre", 11}, {"Diciembre", 12}
            };

            int mesSeleccionado = meses[cbMes.SelectedItem.ToString()];
            int anioActual = DateTime.Now.Year;

            // Calcular fechas de inicio y fin del mes
            DateTime fechaInicio = new DateTime(anioActual, mesSeleccionado, 1, 0, 0, 0);
            DateTime fechaFin = new DateTime(anioActual, mesSeleccionado, DateTime.DaysInMonth(anioActual, mesSeleccionado), 23, 59, 59);

            string query = @"
                SELECT lg.lector_serie, lg.empleado_numero, lg.fecha, lg.estado, CONCAT(u.nombre, ' ', u.apellido_paterno, ' ', u.apellido_materno) AS nombre_completo, l.nombre AS lector FROM log_huellas lg left JOIN usuarios u ON u.numero_empleado = lg.empleado_numero INNER JOIN lectores l ON l.serie = lg.lector_serie
                WHERE lg.fecha BETWEEN @inicio AND @fin
                ORDER BY lg.fecha ASC";

            var parametros = new Dictionary<string, object>
            {
                {"@inicio", fechaInicio},
                {"@fin", fechaFin}
            };

            database db = new database();
            DataTable dt = db.ExecuteQuery(query, parametros);
            dtReport.DataSource = dt;
        }

        private void reports_Load(object sender, EventArgs e)
        {

        }
    }
}
