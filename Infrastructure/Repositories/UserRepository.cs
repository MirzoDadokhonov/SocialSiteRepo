

using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public class UserRepository : IBaseRepository<User>
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<User> _dbSet;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<User>();
        }
        public async Task<User> InsertAsync(User entity, CancellationToken token = default)
        {
            await _dbSet.AddAsync(entity, token);
            await _context.SaveChangesAsync(token);
            return entity;
        }

        public async Task<bool> DeleteAsync(User entity, CancellationToken token = default)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync(token) > 0;
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken token = default)
        {
            return await _dbSet.ToListAsync(token);
        }

        public async Task<User> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _dbSet.FindAsync(id, token);
        }

        public async Task<User> UpdateAsync(User entity, CancellationToken token = default)
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync(token);
            return entity;
        }

        public async Task<IEnumerable<User>> GetFilteredAsync(CancellationToken token, int postMessageOrLike = 3, int? top = null)
        {
            return null;
        }
    }
}
