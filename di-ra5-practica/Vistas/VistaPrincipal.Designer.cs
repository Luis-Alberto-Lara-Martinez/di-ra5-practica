namespace di_ra5_practica
{
    partial class VistaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficaTotalMetodoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficaStockPorCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graficaIDProdcutoPorCantidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasConCamposCalculadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1629, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.graficosToolStripMenuItem,
            this.tablasConCamposCalculadosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosLosDatosToolStripMenuItem,
            this.todosLosDatosProductosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem,
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem,
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem,
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem,
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.todosLosDatosToolStripMenuItem.Text = "1. Todos los datos (Compras)";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
            // 
            // todosLosDatosProductosToolStripMenuItem
            // 
            this.todosLosDatosProductosToolStripMenuItem.Name = "todosLosDatosProductosToolStripMenuItem";
            this.todosLosDatosProductosToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.todosLosDatosProductosToolStripMenuItem.Text = "2. Todos los datos (Productos)";
            this.todosLosDatosProductosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosProductosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(374, 26);
            this.toolStripMenuItem2.Text = "3. Productos por Precio unitario (Filtro1)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // productosPorEncimaDe50Filtro2ToolStripMenuItem
            // 
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Name = "productosPorEncimaDe50Filtro2ToolStripMenuItem";
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Text = "4. Productos por stock (Filtro 2)";
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Click += new System.EventHandler(this.productosPorEncimaDe50Filtro2ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Name = "comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem";
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Text = "5. Productos por nombre (Filtro 3)";
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Text = "6. Compras por metodo de pago  (Filtro 4)";
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Text = "7. Compras por fecha (Filtro 5)";
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Size = new System.Drawing.Size(374, 26);
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Text = "8. Compras por ID(Filtro 6)";
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem_Click);
            // 
            // graficosToolStripMenuItem
            // 
            this.graficosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graficaTotalMetodoDePagoToolStripMenuItem,
            this.graficaStockPorCategoriaToolStripMenuItem,
            this.graficaIDProdcutoPorCantidadToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7});
            this.graficosToolStripMenuItem.Name = "graficosToolStripMenuItem";
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.graficosToolStripMenuItem.Text = "Graficos";
            // 
            // graficaTotalMetodoDePagoToolStripMenuItem
            // 
            this.graficaTotalMetodoDePagoToolStripMenuItem.Name = "graficaTotalMetodoDePagoToolStripMenuItem";
            this.graficaTotalMetodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.graficaTotalMetodoDePagoToolStripMenuItem.Text = "1. Grafica total metodo de pago";
            this.graficaTotalMetodoDePagoToolStripMenuItem.Click += new System.EventHandler(this.graficaTotalMetodoDePagoToolStripMenuItem_Click);
            // 
            // graficaStockPorCategoriaToolStripMenuItem
            // 
            this.graficaStockPorCategoriaToolStripMenuItem.Name = "graficaStockPorCategoriaToolStripMenuItem";
            this.graficaStockPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.graficaStockPorCategoriaToolStripMenuItem.Text = "2. Grafica Stock por categoria";
            this.graficaStockPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.graficaStockPorCategoriaToolStripMenuItem_Click);
            // 
            // graficaIDProdcutoPorCantidadToolStripMenuItem
            // 
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Name = "graficaIDProdcutoPorCantidadToolStripMenuItem";
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Size = new System.Drawing.Size(341, 26);
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Text = "3. Grafica IDProdcuto por cantidad";
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Click += new System.EventHandler(this.graficaIDProdcutoPorCantidadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(341, 26);
            this.toolStripMenuItem3.Text = "4. Grafica precio medio por categoria";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(341, 26);
            this.toolStripMenuItem4.Text = "5. Grafica cantidad por sumatotal";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(341, 26);
            this.toolStripMenuItem5.Text = "6. Grafica por mes";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(448, 26);
            this.toolStripMenuItem6.Text = "7. Gráfica de precio total de productos por proveedor";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(341, 26);
            this.toolStripMenuItem7.Text = "8.";
            // 
            // tablasConCamposCalculadosToolStripMenuItem
            // 
            this.tablasConCamposCalculadosToolStripMenuItem.Name = "tablasConCamposCalculadosToolStripMenuItem";
            this.tablasConCamposCalculadosToolStripMenuItem.Size = new System.Drawing.Size(293, 26);
            this.tablasConCamposCalculadosToolStripMenuItem.Text = "Tablas con Campos calculados";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 703);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "VistaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosLosDatosProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem productosPorEncimaDe50Filtro2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablasConCamposCalculadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficaTotalMetodoDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficaStockPorCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graficaIDProdcutoPorCantidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
    }
}

