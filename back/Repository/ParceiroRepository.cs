using back.Context;
using back.Interface;
using back.Model.Sponsor;

namespace back.Repository
{
    public class ParceiroRepository : IParceiroRepository
    {
        private readonly ApplicationDbContext _context;

        public ParceiroRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Parceiro GetParceiroById(int id)
        {
            if(id > 0)
                return _context.Parceiros.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public List<Parceiro> GetAllParceiros()
        {
            return _context.Parceiros.ToList();
        }

        public Parceiro CreateParceiro(Parceiro parceiro)
        {
            if(parceiro != null)
            {
                _context.Parceiros.Add(parceiro);
                _context.SaveChanges();
                return parceiro;
            }

            return null;
        }

        public Parceiro UpdateParceiro(Parceiro parceiro)
        {
            var parceiroContext = _context.Parceiros.FirstOrDefault(x => x.Id == parceiro.Id);

            if(parceiroContext != null)
            {
                parceiroContext = parceiro;
                _context.SaveChanges();

                return parceiro;
            }

            return null;
        }

        public void DeleteParceiro(int id)
        {
            var parceiroContext = _context.Parceiros.FirstOrDefault(x => x.Id == id);

            if(parceiroContext != null)
            {
                _context.Parceiros.Remove(parceiroContext);
                _context.SaveChanges();
            }
        }
    }
}