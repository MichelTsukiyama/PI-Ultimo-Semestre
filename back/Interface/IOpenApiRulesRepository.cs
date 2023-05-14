using back.Model.OpenAPI.Rules;

namespace back.Interface
{
    public interface IOpenApiRulesRepository
    {
        public OpenApiRules GetRuleById(int id);
        public List<OpenApiRules> GetAllRules();
        public OpenApiRules CreateRule(OpenApiRules regra);
        public OpenApiRules UpdateRule(OpenApiRules regra);
        public void DeleteRule(int id);
    }
}