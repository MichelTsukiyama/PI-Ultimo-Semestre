using back.Model.Sponsor;

namespace back.Context
{
    public class ParceirosInitializer
    {
        public static void PopularParceiros(ApplicationDbContext context)
        {
            if (context.Parceiros.Any())
            {
                return;
            }

            var parceiros = new Parceiro[]
            {
                new Parceiro
                {
                    Nome = "Alura",
                    CNPJ = "05555382000133",
                    ImageUrl = "https://www.alura.com.br/assets/img/alura-share.1647533642.png",
                    Dominio = "https://www.alura.com.br/",
                    Code = "XXXXX",
                },
                new Parceiro
                {
                    Nome = "Udemy",
                    CNPJ = "35356042000144",
                    ImageUrl = "https://macmagazine.com.br/wp-content/uploads/2018/08/14-udemy.jpg",
                    Dominio = "https://www.udemy.com/",
                    Code = "YYYYYY",
                },
            };

            foreach (var p in parceiros)
            {
                context.Parceiros.Add(p);
            }
            context.SaveChanges();
        }
    }
}