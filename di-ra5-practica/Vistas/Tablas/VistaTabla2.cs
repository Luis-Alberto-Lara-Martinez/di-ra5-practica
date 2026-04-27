using di_ra5_practica.Controladores;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas.Tablas
{
    public partial class VistaTabla2 : Form
    {
        public VistaTabla2()
        {
            InitializeComponent();
            this.Load += VistaTabla2_Load;
        }

        private void VistaTabla2_Load(object sender, EventArgs e)
        {
           
                List<Modelos.Productos> productos = ProductosControlador.cargarProductos();

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = productos;
            
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
