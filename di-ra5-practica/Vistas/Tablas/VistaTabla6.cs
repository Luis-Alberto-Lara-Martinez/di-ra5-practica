using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Tablas
{
    public partial class VistaTabla6 : Form
    {
        public VistaTabla6()
        {
            InitializeComponent();
            this.Load += VistaTabla5_Load;
        }

        private void VistaTabla5_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, seleccione un método de pago.", "Selección requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                List<Compras> compras = ComprasControlador.cargarCompras();
                
                if (compras == null || compras.Count == 0)
                {
                    MessageBox.Show("No se pudieron cargar las compras.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string metodoPagoSeleccionado = comboBox1.SelectedItem.ToString();
                var filtrados = compras.Where(c => c.MetodoPago.Equals(metodoPagoSeleccionado, StringComparison.OrdinalIgnoreCase)).ToList();

                if (filtrados.Count == 0)
                {
                    MessageBox.Show($"No hay compras realizadas con método de pago '{metodoPagoSeleccionado}'.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
                string reportPath = Path.Combine(projectDir, "Reportes", "ReportCompras.rdlc");
                reportPath = Path.GetFullPath(reportPath);

                this.reportViewer1.LocalReport.ReportPath = reportPath;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetCompras", filtrados));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento opcional para capturar cambios en la selección
        }
    }
}
