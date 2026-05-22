namespace LAB13_Ejer1.Models
{
    public class Alimento : Producto
    {
        public DateTime FechaVencimiento { get; set; } = DateTime.Now;
        public string UnidadMedida { get; set; } = string.Empty;
    }
}