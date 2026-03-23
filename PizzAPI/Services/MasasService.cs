using PizzAPI.Contexts;
using PizzAPI.Dtos;
using PizzAPI.interfaces;

namespace PizzAPI.Services
{
    public class MasasService : IMasasService
    {

        private readonly AppDbContext _appDbContext;
        public MasasService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<MasaDto> ObtenerMasas()
        {
            return _appDbContext.Masas.ToList();
        }
    }
}
