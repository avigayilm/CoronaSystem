using Microsoft.EntityFrameworkCore;
using CoronaSystem.Models;

namespace CoronaSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<CoronaSystem.Models.Person> Person { get; set; }
    }
}
