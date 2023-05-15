using back.Model;
using back.Model.OpenAPI.Rules;
using back.Model.Sponsor;
using Microsoft.EntityFrameworkCore;

namespace back.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Tecnologia> Tecnologias {get; set;}
        public DbSet<OpenApiRules> Regras {get; set;}
        public DbSet<Parceiro> Parceiros {get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
    }
}