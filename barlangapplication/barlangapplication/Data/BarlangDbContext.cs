using barlangapplication.Model;
using Microsoft.EntityFrameworkCore;
using barlangapplication.DTOs;

namespace barlangapplication.Data
{
    public class BarlangDbContext : DbContext
    {
        public BarlangDbContext(DbContextOptions<BarlangDbContext> options) : base(options)
        {

        }
        public DbSet<Barlang> barlangok { get; set; }
        public DbSet<barlangapplication.DTOs.VarosokBarlangDTO> VarosokBarlangDTO { get; set; } = default!;
    }
}
