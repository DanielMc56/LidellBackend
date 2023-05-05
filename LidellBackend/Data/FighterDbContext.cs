using LidellBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace LidellBackend.Data
{
    public class FighterDbContext : DbContext
    {
        public FighterDbContext(DbContextOptions<FighterDbContext> options) : base(options)
        {
        }

        public DbSet<Fighter> Fighters { get; set; }
    }
}

