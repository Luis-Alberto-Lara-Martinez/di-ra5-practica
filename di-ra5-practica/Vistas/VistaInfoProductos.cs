using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace di_ra5_practica.Vistas
{
    public partial class VistaInfoProductos : Form
    {
        public VistaInfoProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla2 vistaTabla2 = new Vistas.Tablas.VistaTabla2();
            vistaTabla2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla4 vistaTabla4 = new Vistas.Tablas.VistaTabla4();
            vistaTabla4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla5 vistaTabla5 = new Vistas.Tablas.VistaTabla5();
            vistaTabla5.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla3 vistaTabla3 = new Vistas.Tablas.VistaTabla3();
            vistaTabla3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico2 grafico2 = new Vistas.Graficos.Grafico2();
            grafico2.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico4 grafico4 = new Vistas.Graficos.Grafico4();
            grafico4.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico6 grafico6 = new Vistas.Graficos.Grafico6();
            grafico6.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico7 grafico7 = new Vistas.Graficos.Grafico7();
            grafico7.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico8 grafico8 = new Vistas.Graficos.Grafico8();
            grafico8.Show();
        }
    }
}
