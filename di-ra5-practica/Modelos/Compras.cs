using System;

namespace di_ra5_practica.Modelos
{
    internal class Compras
    {
        private int id;
        private int idProducto;
        private int cantidad;
        private DateTime fechaCompra;
        private double precioUnitario;
        private string proveedor;
        private string metodoPago;

        public int Id { get => id; set => id = value; }
        public int IdProducto { get => idProducto; set => idProducto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public DateTime FechaCompra { get => fechaCompra; set => fechaCompra = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
    }
}