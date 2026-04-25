namespace di_ra5_practica.Modelos
{
    public class Productos
    {
        private int id;
        private string nombre;
        private string descripcion;
        private string categoria;
        private double precioUnitario;
        private int stockActual;
        private int stockMinimo;
        private string proveedor;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public double PrecioUnitario { get => precioUnitario; set => precioUnitario = value; }
        public int StockActual { get => stockActual; set => stockActual = value; }
        public int StockMinimo { get => stockMinimo; set => stockMinimo = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }
    }
}
