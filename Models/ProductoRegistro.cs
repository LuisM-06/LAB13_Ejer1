namespace LAB13_Ejer1.Models
{
    public class ProductoRegistro
    {
        public string TipoProducto { get; set; } = string.Empty;

        public string CodigoProducto { get; set; } = string.Empty;
        public string NombreProducto { get; set; } = string.Empty;
        public string DescripcionProducto { get; set; } = string.Empty;
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }

        public DateTime FechaVencimiento { get; set; } = DateTime.Now;
        public string UnidadMedida { get; set; } = string.Empty;

        public int TiempoGarantia { get; set; }
        public string VoltajeUtiliza { get; set; } = string.Empty;

        public string Editorial { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
    }
}