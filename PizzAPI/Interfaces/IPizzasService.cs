using PizzAPI.Dtos;

namespace PizzAPI.interfaces
{
    public interface IPizzasService
    {
        List<ProductoDto> ObtenerPizzas();
    }
}
