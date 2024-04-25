using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GroupService : IBaseService<Group>
    {
        private readonly IBaseRepository<Group> _GroupRepository;

        public GroupService(IBaseRepository<Group> repository)
        {
            _GroupRepository = repository;
        }

        public async Task<Group> InsertAsync(Group entity, CancellationToken token = default)
        {
            return await _GroupRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Group entity, CancellationToken token = default)
        {
            return await _GroupRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Group>> GetAllAsync(CancellationToken token = default)
        {
            return await _GroupRepository.GetAllAsync(token);
        }

        public async Task<Group> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _GroupRepository.GetAsync(id, token);
        }

        public async Task<Group> UpdateAsync(Group entity, CancellationToken token = default)
        {
            return await _GroupRepository.UpdateAsync(entity, token);
        }

    }
}
