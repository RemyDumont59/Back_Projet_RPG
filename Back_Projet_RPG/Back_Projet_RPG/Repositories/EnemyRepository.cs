using Back_Projet_RPG.Data;
using Back_Projet_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_Projet_RPG.Repositories
{
    public class EnemyRepository : IRepository<Player>
    {
        private ApplicationDbContext _dbContext { get; }
        public EnemyRepository(ApplicationDbContext dbContext) 
        {  
            _dbContext = dbContext; 
        }
        public async Task<List<Player>> GetAll()
        {
            return await _dbContext.Players.ToListAsync();
        }

        public async Task<Player?> GetById(int id)
        {
            return await _dbContext.Players.FindAsync(id);
        }
    }
}
