using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;

namespace Application.Services
{
    public class CommentService : IBaseService<Comment>
    {
        private readonly IBaseRepository<Comment> _commentRepository;

        public CommentService(IBaseRepository<Comment> repository)
        {
            _commentRepository = repository;
        }

        public async Task<Comment> InsertAsync(Comment entity, CancellationToken token = default)
        {
            return await _commentRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Comment entity, CancellationToken token = default)
        {
            return await _commentRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Comment>> GetAllAsync(CancellationToken token = default)
        {
            return await _commentRepository.GetAllAsync(token);
        }

        public async Task<Comment> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _commentRepository.GetAsync(id, token);
        }

        public async Task<Comment> UpdateAsync(Comment entity, CancellationToken token = default)
        {
            return await _commentRepository.UpdateAsync(entity, token);
        }
    }
}
