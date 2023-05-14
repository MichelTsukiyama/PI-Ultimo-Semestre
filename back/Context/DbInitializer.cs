using System.Net.Mime;
using back.Model;

namespace back.Context
{
    public class DbInitializer
    {
        public static void Initiazlize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            TecnologiaInitializer.PopularTecnologias(context);
            OpenApiRulesInitializer.PopularRegras(context);
            ParceirosInitializer.PopularParceiros(context);
        }
    }
}