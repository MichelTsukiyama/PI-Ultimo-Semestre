using back.Context;
using back.Interface;
using back.Model;

namespace back.Repository
{
    public class TecnologiaRepository : ITecnologiaRepository
    {
        private readonly ApplicationDbContext _context;

        public TecnologiaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Tecnologia GetTecnologiaAsync(string? Nome)
        {
            return _context.Tecnologias.FirstOrDefault(x => x.Linguagem.Contains(Nome));
        }
    }
}