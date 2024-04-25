using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;

namespace Application.Services
{
    public class UserService : IBaseService<User>
    {
        private readonly IBaseRepository<User> _userRepository;

        public UserService(IBaseRepository<User> repository)
        {
            _userRepository = repository;
        }

        public async Task<User> InsertAsync(User entity, CancellationToken token = default)
        {
            return await _userRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(User entity, CancellationToken token = default)
        {
            return await _userRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<User>> GetAllAsync(CancellationToken token = default)
        {
            return await _userRepository.GetAllAsync(token);
        }

        public async Task<User> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _userRepository.GetAsync(id, token);
        }

        public async Task<User> UpdateAsync(User entity, CancellationToken token = default)
        {
            
            return await _userRepository.UpdateAsync(entity, token);
        }
    }
}
