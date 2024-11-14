using AssetSync.BrandshareDAM.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetSync.BrandshareDAM.Repositories
{
    public class GenericRepository<Entity> where Entity : BaseEntity
    {
        private readonly BrandshareDAMDBContext _context;
        private DbSet<Entity> _dbSet;
        public GenericRepository(BrandshareDAMDBContext context)
        {
            _context = context;
            _dbSet = _context.Set<Entity>();

            _context.Database.EnsureCreated();
        }

        public async Task<List<Entity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Entity> GetAsync(Guid id)
        {
            return await _dbSet.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task CreateAsync(Entity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(Entity entity)
        {
            _dbSet.Update(entity);
        }

        public void Delete(Entity entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
