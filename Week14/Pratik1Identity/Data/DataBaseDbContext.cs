using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using Microsoft.Extensions.Options;
using Pratik1Identity.Models;

namespace Pratik1Identity.Data
{
    public class DataBaseDbContext:IdentityDbContext<IdentityUser>
    {
        public DataBaseDbContext(DbContextOptions<DataBaseDbContext> dbContextOptions):base(dbContextOptions)
        {
        }


    }
}
