namespace LAB13_Ejer1.Models
{
    public class Libro : Producto
    {
        public string Editorial { get; set; } = string.Empty;
        public string Categoria { get; set; } = string.Empty;
        public string Autor { get; set; } = string.Empty;
    }
}