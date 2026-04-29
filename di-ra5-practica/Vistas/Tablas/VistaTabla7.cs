using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Tablas
{
    public partial class VistaTabla7 : Form
    {
        public VistaTabla7()
        {
            InitializeComponent();
            this.Load += VistaTabla7_Load;
        }

        private void VistaTabla7_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Value = DateTime.Today;
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
            List<Compras> compras = ComprasControlador.cargarCompras();
            DateTime fechaSeleccionada = dateTimePicker1.Value.Date;

            List<Compras> comprasFiltradas = compras
                .Where(c => c.FechaCompra.Date == fechaSeleccionada)
                .ToList();

            string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
            string reportPath = Path.Combine(projectDir, "Reportes", "ReportCompras.rdlc");
            reportPath = Path.GetFullPath(reportPath);

            this.reportViewer1.LocalReport.ReportPath = reportPath;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSetCompras", comprasFiltradas));
            this.reportViewer1.RefreshReport();
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evento opcional para capturar cambios en la selección
        }
    }
}
