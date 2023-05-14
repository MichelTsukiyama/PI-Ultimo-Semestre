using back.Context;
using back.Interface;
using back.Model.OpenAPI.Rules;

namespace back.Repository
{
    public class OpenApiRulesRepository : IOpenApiRulesRepository
    {
        private readonly ApplicationDbContext _context;

        public OpenApiRulesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public OpenApiRules GetRuleById(int id)
        {
            if(id > 0)
                return _context.Regras.FirstOrDefault(x => x.Id == id);

            return null;
        }

        public List<OpenApiRules> GetAllRules()
        {
            return _context.Regras.ToList();
        }

        public OpenApiRules CreateRule(OpenApiRules regra)
        {
            if(regra != null)
            {
                _context.Regras.Add(regra);
                _context.SaveChanges();
                return regra;
            }

            return null;
        }

        public OpenApiRules UpdateRule(OpenApiRules regra)
        {
            var regraContext = _context.Regras.FirstOrDefault(x => x.Id == regra.Id);

            if(regraContext != null)
            {
                regraContext = regra;
                _context.SaveChanges();

                return regra;
            }

            return null;
        }

        public void DeleteRule(int id)
        {
            var regraContext = _context.Regras.FirstOrDefault(x => x.Id == id);

            if(regraContext != null)
            {
                _context.Regras.Remove(regraContext);
                _context.SaveChanges();
            }
        }
    }
}