using Microsoft.EntityFrameworkCore;
using PetsAPI.Models;

namespace PetsAPI.Data
{
    public class StenPetsContext : DbContext
    {
        public StenPetsContext(DbContextOptions<StenPetsContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
    }
}