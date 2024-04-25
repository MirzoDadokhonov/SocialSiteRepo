using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class PostService(IBaseRepository<Post> repository) : IBaseService<Post>
    {
        private readonly IBaseRepository<Post> _PostRepository = repository;

		public async Task<Post> InsertAsync(Post entity, CancellationToken token = default)
        {
            return await _PostRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Post entity, CancellationToken token = default)
        {
            return await _PostRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Post>> GetAllAsync(CancellationToken token = default)
        {
            return await _PostRepository.GetAllAsync(token);
        }

        public async Task<Post> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _PostRepository.GetAsync(id, token);
        }

        public async Task<Post> UpdateAsync(Post entity, CancellationToken token = default)
        {
            return await _PostRepository.UpdateAsync(entity, token);
        }

    }
}
