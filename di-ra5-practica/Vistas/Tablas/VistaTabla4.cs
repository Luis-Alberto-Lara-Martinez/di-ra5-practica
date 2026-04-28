using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Tablas
{
    public partial class VistaTabla4 : Form
    {
        public VistaTabla4()
        {
            InitializeComponent();
            this.Load += VistaTabla4_Load;
        }

        private void VistaTabla4_Load(object sender, EventArgs e)
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
                List<Productos> productos = ProductosControlador.cargarProductos();
                
                if (productos == null || productos.Count == 0)
                {
                    MessageBox.Show("No se pudieron cargar los productos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int limiteStock = (int)this.numericUpDown1.Value;

                var filtrados = productos.Where(p => p.StockActual >= 0 && p.StockActual <= limiteStock).ToList();

                if (filtrados.Count == 0)
                {
                    MessageBox.Show($"No hay productos con stock entre 0 y {limiteStock}.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
