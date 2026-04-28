using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Tablas
{
    public partial class VistaTabla3 : Form
    {
        public VistaTabla3()
        {
            InitializeComponent();
            this.Load += VistaTabla3_Load;
        }

        private void VistaTabla3_Load(object sender, EventArgs e)
        {
           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void VistaTabla3_Load_1(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<Productos> productos = ProductosControlador.cargarProductos();
                if (double.TryParse(TextoPrecio.Text, out double limite))
                {
                    var filtrados = productos.Where(p => p.PrecioUnitario < limite).ToList();


                    string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
                    string reportPath = Path.Combine(projectDir, "Reportes", "ReportProductos.rdlc");
                    reportPath = Path.GetFullPath(reportPath);

                    this.reportViewer1.LocalReport.ReportPath = reportPath;
                    this.reportViewer1.LocalReport.DataSources.Clear();
                    this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetProductos", filtrados));
                    this.reportViewer1.RefreshReport();
                }
                else {                 
                    MessageBox.Show("Por favor, ingrese un número válido para el precio.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
