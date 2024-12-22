using Microsoft.EntityFrameworkCore;
using Pratik2CodeFirstRelation.Entitiy;
namespace Pratik2CodeFirstRelation
{
    internal class Program:DbContext
    {
        DbSet<Post> Posts { get; set; }
        DbSet<User> Users { get; set; }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        string connectionString = "Server=Tested;Host=localhost;Port=5432;Username=postgres;Password=1;Database=PatikaSecondDbContext;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseNpgsql(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
