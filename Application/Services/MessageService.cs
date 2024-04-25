using SocialSiteClassLibrary.Entities;
using SocialSiteClassLibrary.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class MessageService(IBaseRepository<Message> repository) : IBaseService<Message>
    {
        private readonly IBaseRepository<Message> _MessageRepository = repository;

		public async Task<Message> InsertAsync(Message entity, CancellationToken token = default)
        {
            return await _MessageRepository.InsertAsync(entity, token);
        }

        public async Task<bool> DeleteAsync(Message entity, CancellationToken token = default)
        {
            return await _MessageRepository.DeleteAsync(entity, token);
        }

        public async Task<IEnumerable<Message>> GetAllAsync(CancellationToken token = default)
        {
            return await _MessageRepository.GetAllAsync(token);
        }

        public async Task<Message> GetAsync(Guid id, CancellationToken token = default)
        {
            return await _MessageRepository.GetAsync(id, token);
        }

        public async Task<Message> UpdateAsync(Message entity, CancellationToken token = default)
        {
            return await _MessageRepository.UpdateAsync(entity, token);
        }

    }
}
