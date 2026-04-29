using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Graficos
{
    public partial class Grafico5 : Form
    {
        public Grafico5()
        {
            InitializeComponent();
        }

        private void Grafico5_Load(object sender, EventArgs e)
        {
            try
            {
                List<Compras> compras = ComprasControlador.cargarCompras();

                string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
                string reportPath = Path.Combine(projectDir, "Reportes", "ReportGraficosCompras3.rdlc");
                reportPath = Path.GetFullPath(reportPath);

                this.reportViewer1.LocalReport.ReportPath = reportPath;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Compras", compras));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando el gráfico: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
