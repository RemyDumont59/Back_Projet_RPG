using Back_Projet_RPG.Data;
using Back_Projet_RPG.Models;
using Microsoft.EntityFrameworkCore;

namespace Back_Projet_RPG.Repositories
{
    public class EnemyRepository : IRepository<Enemy>
    {
        private ApplicationDbContext _dbContext { get; }
        public EnemyRepository(ApplicationDbContext dbContext) 
        {  
            _dbContext = dbContext; 
        }
        public async Task<List<Enemy>> GetAll()
        {
            return await _dbContext.Enemies.ToListAsync();
        }

        public async Task<Enemy?> GetById(int id)
        {
            return await _dbContext.Enemies.FindAsync(id);
        }
    }
}
