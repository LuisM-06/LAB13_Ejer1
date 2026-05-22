namespace LAB13_Ejer1.Models
{
    public class Electronico : Producto
    {
        public int TiempoGarantia { get; set; }
        public string VoltajeUtiliza { get; set; } = string.Empty;
    }
}