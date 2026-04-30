using di_ra5_practica.Controladores;
using di_ra5_practica.Modelos;
using di_ra5_practica.Vistas;
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

        private void productosPorEncimaDe50Filtro2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla4 vistaTabla4 = new Vistas.Tablas.VistaTabla4();
            vistaTabla4.ShowDialog();
        }

        private void comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla5 vistaTabla5 = new Vistas.Tablas.VistaTabla5();
            vistaTabla5.ShowDialog();
        }

        private void comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla6 vistaTabla6 = new Vistas.Tablas.VistaTabla6();
            vistaTabla6.ShowDialog();
        }

        private void comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla7 vistaTabla7 = new Vistas.Tablas.VistaTabla7();
            vistaTabla7.ShowDialog();
        }

        private void comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Tablas.VistaTabla8 vistaTabla8 = new Vistas.Tablas.VistaTabla8();
            vistaTabla8.ShowDialog();
        }

        private void graficaTotalMetodoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico1 vistaGrafico1 = new Vistas.Graficos.Grafico1();
            vistaGrafico1.ShowDialog();
        }

        private void graficaStockPorCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico2 vistaGrafico2 = new Vistas.Graficos.Grafico2();
            vistaGrafico2.ShowDialog();
        }

        private void graficaIDProdcutoPorCantidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico3 vistaGrafico3 = new Vistas.Graficos.Grafico3();
            vistaGrafico3.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico4 vistaGrafico4 = new Vistas.Graficos.Grafico4();
            vistaGrafico4.ShowDialog();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico5 vistaGrafico5 = new Vistas.Graficos.Grafico5();
            vistaGrafico5.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico6 vistaGrafico6 = new Vistas.Graficos.Grafico6();
            vistaGrafico6.ShowDialog();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico7 vistaGrafico7 = new Vistas.Graficos.Grafico7();
            vistaGrafico7.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Vistas.Graficos.Grafico8 vistaGrafico8 = new Vistas.Graficos.Grafico8();
            vistaGrafico8.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VistaInfoCompras vistaInfoCompras = new VistaInfoCompras();
            vistaInfoCompras.ShowDialog();
        }
    }
}
