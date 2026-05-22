namespace LAB13_Ejer1.Models
{
    public class Producto
    {
        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string DescripcionProducto { get; set; } = string.Empty;
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
    }
}
