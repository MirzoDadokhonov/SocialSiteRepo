using SocialSiteClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        Task<TEntity> GetAsync(Guid id, CancellationToken token = default);
        Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default);
        Task<TEntity> InsertAsync(TEntity entity, CancellationToken token = default);
        Task<TEntity> UpdateAsync(TEntity entity, CancellationToken token = default);
        Task<bool> DeleteAsync(TEntity entity, CancellationToken token = default);
    }
}
