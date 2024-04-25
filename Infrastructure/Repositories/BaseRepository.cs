using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<T> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task<T> InsertAsync(T entity, CancellationToken token = default)
        {
            await _dbSet.AddAsync(entity, token);
            await _context.SaveChangesAsync(token);
            return entity;
        }

        public async Task<bool> DeleteAsync(T entity, CancellationToken token = default)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync(token) > 0;
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken token = default)
        {
            return await _dbSet.ToListAsync(token);
        }

        public async Task<T> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _dbSet.FindAsync(id, token);
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken token = default)
        {
            /*var myEntity = _dbSet.FirstOrDefault(u => u.Id == entity.Id);

            myEntity = entity;
            try { 
                _dbSet.Update(myEntity);
                await _context.SaveChangesAsync(token);
            } catch (Exception c) {
                Console.WriteLine("Error " + c.Message + " " + c.StackTrace);
            }
            return myEntity;*/
            _dbSet.Update(entity);
            await _context.SaveChangesAsync(token);
            return entity;
        }

    }
}
