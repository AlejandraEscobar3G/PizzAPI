using PizzAPI.Contexts;
using PizzAPI.Dtos;
using PizzAPI.enums;
using PizzAPI.interfaces;

namespace PizzAPI.Services
{
    public class BebidasService : IBebidasService
    {
        private readonly AppDbContext _appDbContext;
        public BebidasService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public List<BebidaDto> ObtenerBebidas()
        {
            return _appDbContext.Bebidas.ToList();
        }
    }
}
