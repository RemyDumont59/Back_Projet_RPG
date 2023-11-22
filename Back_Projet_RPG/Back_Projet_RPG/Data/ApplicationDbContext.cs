using Back_Projet_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_Projet_RPG.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Enemy> Enemies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Player> players = new List<Player>()
            {
                new Player()
                {
                    Id = 1,
                    LifePoint = 10,
                    Stamina = 10,
                    Strength = 10,
                    Agility = 10,
                    Intellect = 10,
                    Luck = 10
                },
            };

            List<Enemy> enemies = new List<Enemy>()
            {
                new Enemy()
                {
                    Id = 1,
                    LifePoint = 10,
                    Stamina = 10,
                    Strength = 10,
                    Agility = 10,
                    Intellect = 10,
                    Luck = 10
                }
            };
        }

    }
}
