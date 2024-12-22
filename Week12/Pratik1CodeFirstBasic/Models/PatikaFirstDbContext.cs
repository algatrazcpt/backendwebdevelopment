using Microsoft.EntityFrameworkCore;
namespace Pratik1CodeFirstBasic.Models
{
    public class PatikaFirstDbContext:DbContext
    {
        private string connectionString = "Server=Tested;Host=localhost;Port=5432;Database=PatikaFirstDB;Username=postgres;Password=1;";
        public DbSet<Games> Games { get; set; }

        public DbSet<Movie>Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql(@connectionString);

            base.OnConfiguring(optionsBuilder);
        }

    }
}
