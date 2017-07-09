using System.Data.Entity;
using Treinamento.Domain.Entities;
using Treinamento.Infra.Mappings;

namespace Treinamento.Infra.Contexts
{
    public class AppDataContext : DbContext
    {
        public AppDataContext() : base("AppCnnStr"){}
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMap());
        }
    }
}
