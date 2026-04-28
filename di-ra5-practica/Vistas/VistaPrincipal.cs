using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace di_ra5_practica
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            try
            {
                List<Compras> compras = ComprasControlador.cargarCompras();

                string projectDir = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "..", "..");
                string reportPath = Path.Combine(projectDir, "Reportes", "ReportCompras.rdlc");
                reportPath = Path.GetFullPath(reportPath);

                this.reportViewer1.LocalReport.ReportPath = reportPath;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSetCompras", compras));
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando el reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void todosLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla1 vistaTabla1 = new Vistas.Tablas.VistaTabla1();
            vistaTabla1.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void todosLosDatosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla2 vistaTabla2 = new Vistas.Tablas.VistaTabla2();
            vistaTabla2.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla3 vistaTabla3 = new Vistas.Tablas.VistaTabla3();
            vistaTabla3.ShowDialog();
        }
    }
}
