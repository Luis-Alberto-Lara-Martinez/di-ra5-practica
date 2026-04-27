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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosLosDatosProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(11, 48);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(540, 337);
            this.reportViewer1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1222, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem});
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
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // todosLosDatosToolStripMenuItem
            // 
            this.todosLosDatosToolStripMenuItem.Name = "todosLosDatosToolStripMenuItem";
            this.todosLosDatosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.todosLosDatosToolStripMenuItem.Text = "1. Todos los datos (Compras)";
            this.todosLosDatosToolStripMenuItem.Click += new System.EventHandler(this.todosLosDatosToolStripMenuItem_Click);
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
            // todosLosDatosProductosToolStripMenuItem
            // 
            this.todosLosDatosProductosToolStripMenuItem.Name = "todosLosDatosProductosToolStripMenuItem";
            this.todosLosDatosProductosToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.todosLosDatosProductosToolStripMenuItem.Text = "2. Todos los datos (Productos)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(278, 22);
            this.toolStripMenuItem2.Text = "3. Productos por debajo de 50 (Filtro1)";
            // 
            // productosPorEncimaDe50Filtro2ToolStripMenuItem
            // 
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Name = "productosPorEncimaDe50Filtro2ToolStripMenuItem";
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.productosPorEncimaDe50Filtro2ToolStripMenuItem.Text = "4. Productos por encima de 50 (Filtro 2)";
            // 
            // comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Name = "comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem";
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.comprasPorMetodoDePagoEfectivoFiltro3ToolStripMenuItem.Text = "5. Compras por metodo de pago Efectivo (Filtro 3)";
            // 
            // comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.comprasPorMetodoDePagoTarjetaFiltro4ToolStripMenuItem.Text = "6. Compras por metodo de pago Tarjeta (Filtro 4)";
            // 
            // comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.comprasPorMetodoDePagoTarjetaFiltro5ToolStripMenuItem.Text = "7. Compras por metodo de pago Tarjeta (Filtro 5)";
            // 
            // comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem
            // 
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Name = "comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem";
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.comprasPorMetodoDePagoTarjetaFiltro6ToolStripMenuItem.Text = "8. Compras por metodo de pago Tarjeta (Filtro 6)";
            // 
            // VistaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 571);
            this.Controls.Add(this.reportViewer1);
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

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
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
    }
}

