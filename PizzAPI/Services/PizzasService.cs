using Microsoft.EntityFrameworkCore;
using PizzAPI.Contexts;
using PizzAPI.Dtos;
using PizzAPI.interfaces;

namespace PizzAPI.Services
{
    public class PizzasService : IPizzasService
    {
        private readonly AppDbContext _appDbContext;
        public PizzasService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<ProductoDto> ObtenerPizzas()
        {
            return _appDbContext.Productos.ToList();
        }
    }
}
