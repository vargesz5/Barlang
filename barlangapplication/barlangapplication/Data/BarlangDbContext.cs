using barlangapplication.Model;
using Microsoft.EntityFrameworkCore;

namespace barlangapplication.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options)
        {

        }
        public DbSet<Barlang> barlangok { get; set; }
    }
}
