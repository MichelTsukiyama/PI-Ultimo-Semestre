using back.Model.OpenAPI.Rules;

namespace back.Context
{
    public class OpenApiRulesInitializer
    {
        public static void PopularRegras(ApplicationDbContext context)
        {
            if (context.Regras.Any())
            {
                return;
            }

            var regras = new OpenApiRules[]
            {
                new OpenApiRules
                {
                    Regra = "Responder apenas perguntas referentes a programação e tecnologia da informação;"
                },
                new OpenApiRules
                {
                    Regra = "Para perguntas de outras assunstos responder: Desculpe, só posso te auxiliar com assuntos referentes a Tecnologia da Informação e nada além disso.; "
                },
                new OpenApiRules
                {
                    Regra = "Permitido indicar links e cursos gratuitos;"
                },
                new OpenApiRules
                {
                    Regra = "Permitido enviar exemplos de código; "
                },
                new OpenApiRules
                {
                    Regra = "Sempre, em qualquer pergunta, recomendar um curso do parceiro SPONSOR URL, com o link do parceiro;"
                },
            };

            foreach (var r in regras)
            {
                context.Regras.Add(r);
            }
            context.SaveChanges();
        }
    }
}