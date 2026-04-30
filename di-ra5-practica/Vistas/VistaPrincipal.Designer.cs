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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
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
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
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
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.todosLosDatosToolStripMenuItem.Text = "1. Todos los datos (Compras)";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
            // 
            // todosLosDatosProductosToolStripMenuItem
            // 
            this.todosLosDatosProductosToolStripMenuItem.Name = "todosLosDatosProductosToolStripMenuItem";
            this.todosLosDatosProductosToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.todosLosDatosProductosToolStripMenuItem.Text = "2. Todos los datos (Productos)";
            this.todosLosDatosProductosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosProductosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(296, 22);
            this.toolStripMenuItem2.Text = "3. Productos por Precio unitario (Filtro1)";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // productosPorEncimaDe50Filtro2ToolStripMenuItem
            // 
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Name = "productosPorEncimaDe50Filtro2ToolStripMenuItem";
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Text = "4. Productos por stock (Filtro 2)";
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Click += new System.EventHandler(this.productosPorEncimaDe50Filtro2ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Name = "comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem";
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Text = "5. Productos por nombre (Filtro 3)";
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Text = "6. Compras por metodo de pago  (Filtro 4)";
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Text = "7. Compras por fecha (Filtro 5)";
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Click += new System.EventHandler(this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem_Click);
            // 
            // comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Size = new System.Drawing.Size(296, 22);
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
            this.graficosToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.graficosToolStripMenuItem.Text = "Graficos";
            // 
            // graficaTotalMetodoDePagoToolStripMenuItem
            // 
            this.graficaTotalMetodoDePagoToolStripMenuItem.Name = "graficaTotalMetodoDePagoToolStripMenuItem";
            this.graficaTotalMetodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.graficaTotalMetodoDePagoToolStripMenuItem.Text = "1. Gráfica total metodo de pago";
            this.graficaTotalMetodoDePagoToolStripMenuItem.Click += new System.EventHandler(this.graficaTotalMetodoDePagoToolStripMenuItem_Click);
            // 
            // graficaStockPorCategoriaToolStripMenuItem
            // 
            this.graficaStockPorCategoriaToolStripMenuItem.Name = "graficaStockPorCategoriaToolStripMenuItem";
            this.graficaStockPorCategoriaToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.graficaStockPorCategoriaToolStripMenuItem.Text = "2. Gráfica Stock por categoria";
            this.graficaStockPorCategoriaToolStripMenuItem.Click += new System.EventHandler(this.graficaStockPorCategoriaToolStripMenuItem_Click);
            // 
            // graficaIDProdcutoPorCantidadToolStripMenuItem
            // 
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Name = "graficaIDProdcutoPorCantidadToolStripMenuItem";
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Size = new System.Drawing.Size(353, 22);
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Text = "3. Gráfica IDProdcuto por cantidad";
            this.graficaIDProdcutoPorCantidadToolStripMenuItem.Click += new System.EventHandler(this.graficaIDProdcutoPorCantidadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(353, 22);
            this.toolStripMenuItem3.Text = "4. Gráfica precio medio por categoria";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(353, 22);
            this.toolStripMenuItem4.Text = "5. Gráfica cantidad por sumatotal";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(353, 22);
            this.toolStripMenuItem5.Text = "6. Gráfica porcentaje de productos por categoria";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(353, 22);
            this.toolStripMenuItem6.Text = "7. Gráfica de precio total de productos por proveedor";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(353, 22);
            this.toolStripMenuItem7.Text = "8. Gráfica de Stock por proveedor";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // tablasConCamposCalculadosToolStripMenuItem
            // 
            this.tablasConCamposCalculadosToolStripMenuItem.Name = "tablasConCamposCalculadosToolStripMenuItem";
            this.tablasConCamposCalculadosToolStripMenuItem.Size = new System.Drawing.Size(236, 22);
            this.tablasConCamposCalculadosToolStripMenuItem.Text = "Tablas con Campos calculados";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(751, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona la clase que quieras ver";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(134, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 140);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ver info Compras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Compras";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(799, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 140);
            this.button2.TabIndex = 5;
            this.button2.Text = "Ver info Productos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(844, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Productos";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1088, 519);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 40);
            this.button3.TabIndex = 7;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 571);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
    }
}

