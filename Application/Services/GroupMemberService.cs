using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class GroupMemberService(IBaseRepository<GroupMember> repository) : IBaseService<GroupMember>
    {
        private readonly IBaseRepository<GroupMember> _GroupMemberRepository = repository;

		public async Task<GroupMember> InsertAsync(GroupMember entity, CancellationToken token = default)
        {
            return await _GroupMemberRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(GroupMember entity, CancellationToken token = default)
        {
            return await _GroupMemberRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<GroupMember>> GetAllAsync(CancellationToken token = default)
        {
            return await _GroupMemberRepository.GetAllAsync(token);
        }

        public async Task<GroupMember> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _GroupMemberRepository.GetAsync(id, token);
        }

        public async Task<GroupMember> UpdateAsync(GroupMember entity, CancellationToken token = default)
        {
            return await _GroupMemberRepository.UpdateAsync(entity, token);
        }

    }
}
