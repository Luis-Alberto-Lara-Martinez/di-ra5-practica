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
    public partial class VistaInfoCompras : Form
    {
        public VistaInfoCompras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla1 vistaTabla1 = new Vistas.Tablas.VistaTabla1();
            vistaTabla1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla6 vistaTabla6 = new Vistas.Tablas.VistaTabla6();
            vistaTabla6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla7 vistaTabla7 = new Vistas.Tablas.VistaTabla7();
            vistaTabla7.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico1 grafico1 = new Vistas.Graficos.Grafico1();
            grafico1.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico3 grafico3 = new Vistas.Graficos.Grafico3();
            grafico3.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico5 grafico5 = new Vistas.Graficos.Grafico5();
            grafico5.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
