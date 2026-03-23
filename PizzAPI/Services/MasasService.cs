using PizzAPI.Dtos;
using PizzAPI.interfaces;

namespace PizzAPI.Services
{
    public class MasasService : IMasasService
    {
        public List<MasaDto> ObtenerMasas()
        {
            List<MasaDto> masas = new List<MasaDto>
            {
                new MasaDto
                {
                    Id = 1,
                    Nombre = "Original",
                    Descripcion = "La original y clásica masa fresca hecha al momento con orilla dorada y espolvoreada de especias que le dan nuestro toque único."
                },
                new MasaDto
                {
                    Id = 2,
                    Nombre = "Orilla rellena de queso",
                    Descripcion = "Masa fresca hecha al momento con deliciosa orilla dorada rellena de queso mozzarella derretido y espolvoreada con especias."
                },
                new MasaDto
                {
                    Id = 3,
                    Nombre = "Sartén",
                    Descripcion = "Masa dorada y esponjosa con toque de mantequilla, doble capa de queso (provolone y mozzarella) e ingredientes hasta la orilla."
                },
                new MasaDto
                {
                    Id = 4,
                    Nombre = "Crunchy",
                    Descripcion = "Masa delgada y crujiente con borde dorado, perfecta para resaltar el sabor de los ingredientes y ofrecer una experiencia más ligera."
                }
            };

            return masas;
        }
    }
}
