using Microsoft.EntityFrameworkCore;
using Pratik2Jwt.Models;

namespace Pratik2Jwt.Data
{
    public class ApplicationDbContext:DbContext
    {

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

            public DbSet<Users> User { get; set; }

    }
}
