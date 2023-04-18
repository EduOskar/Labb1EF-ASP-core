using Labb1EF_ASP_core.Models;
using Microsoft.EntityFrameworkCore;

namespace Labb1EF_ASP_core.Data
{
    public class Labb1EFDbContext : DbContext
    {
        public Labb1EFDbContext(DbContextOptions<Labb1EFDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Vacation> Vacations { get; set; }
    }
}
