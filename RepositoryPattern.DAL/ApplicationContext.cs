using Microsoft.EntityFrameworkCore;
using RepositoryPattern.MODEL;

namespace RepositoryPattern.DAL
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Developer> Developers { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DeveloperEntityTypeConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProjectEntityTypeConfiguration).Assembly);
        }
    }


}
