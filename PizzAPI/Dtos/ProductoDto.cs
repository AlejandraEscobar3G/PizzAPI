namespace PizzAPI.Dtos
{
    public class ProductoDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<string>? Ingredientes { get; set; }
        public string Ruta { get; set; }
        public decimal Precio { get; set; }
    }
}
