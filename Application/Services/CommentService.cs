using SocialSiteClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    internal class CommentService : IBaseService<Comment>
    {
        public Task<Comment> CreateAsync(Comment entity, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(Comment entity, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Comment>> GetAllAsync(CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetAsync(Guid id, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(Comment entity, CancellationToken token = default)
        {
            throw new NotImplementedException();
        }
    }
}
