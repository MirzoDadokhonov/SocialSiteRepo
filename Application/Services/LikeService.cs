using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class LikeService(IBaseRepository<Like> repository) : IBaseService<Like>
    {
        private readonly IBaseRepository<Like> _LikeRepository = repository;

		public async Task<Like> InsertAsync(Like entity, CancellationToken token = default)
        {
            return await _LikeRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Like entity, CancellationToken token = default)
        {
            return await _LikeRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Like>> GetAllAsync(CancellationToken token = default)
        {
            return await _LikeRepository.GetAllAsync(token);
        }

        public async Task<Like> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _LikeRepository.GetAsync(id, token);
        }

        public async Task<Like> UpdateAsync(Like entity, CancellationToken token = default)
        {
            return await _LikeRepository.UpdateAsync(entity, token);
        }

    }
}
