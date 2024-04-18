using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class FriendService : IBaseService<Friend>
    {
        private readonly IBaseRepository<Friend> _friendRepository;

        public FriendService(IBaseRepository<Friend> repository)
        {
            _friendRepository = repository;
        }

        public async Task<Friend> InsertAsync(Friend entity, CancellationToken token = default)
        {
            return await _friendRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Friend entity, CancellationToken token = default)
        {
            return await _friendRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Friend>> GetAllAsync(CancellationToken token = default)
        {
            return await _friendRepository.GetAllAsync(token);
        }

        public async Task<Friend> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _friendRepository.GetAsync(id, token);
        }

        public async Task<Friend> UpdateAsync(Friend entity, CancellationToken token = default)
        {
            return await _friendRepository.UpdateAsync(entity, token);
        }

    }
}
