using PizzAPI.enums;

namespace PizzAPI.Dtos
{
    public class BebidaDto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<string>? Ingredientes { get; set; }
        public string Ruta { get; set; }
        public EnumMenu Menu { get; set; }
        public decimal Precio { get; set; }
    }
}
