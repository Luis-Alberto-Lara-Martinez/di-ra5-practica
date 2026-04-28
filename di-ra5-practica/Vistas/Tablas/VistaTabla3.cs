using di_ra5_practica.Controladores;
using System;
using System.Collections.Generic;
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
           
                List<Modelos.Productos> productos = ProductosControlador.cargarProductos();
            var productosFiltrados = productos
                .Where(p => p.PrecioUnitario > 50)
                .ToList();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productosFiltrados;
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
