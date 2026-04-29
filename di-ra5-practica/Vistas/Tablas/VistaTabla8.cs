using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Tablas
{
    public partial class VistaTabla8 : Form
    {
        public VistaTabla8()
        {
            InitializeComponent();
            this.Load += VistaTabla8_Load;
        }

        private void VistaTabla8_Load(object sender, EventArgs e)
        {
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = int.MaxValue;
            numericUpDown1.Value = 1;
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
                List<Productos> productos = ProductosControlador.cargarProductos();

                if (productos == null || productos.Count == 0)
                {
                    MessageBox.Show("No se pudieron cargar los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int idSeleccionado = (int)numericUpDown1.Value;
                var filtrados = productos.Where(p => p.Id == idSeleccionado).ToList();

                if (filtrados.Count == 0)
                {
                    MessageBox.Show($"No hay productos con el ID {idSeleccionado}.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
                string reportPath = Path.Combine(projectDir, "Reportes", "ReportProductos.rdlc");
                reportPath = Path.GetFullPath(reportPath);

                this.reportViewer1.LocalReport.ReportPath = reportPath;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetProductos", filtrados));
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
