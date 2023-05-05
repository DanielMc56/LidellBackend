using LidellBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace LidellBackend.Data
{
    public class ScoreDbContext : DbContext
    {
        public ScoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Score> Scores { get; set; }
    }
}
