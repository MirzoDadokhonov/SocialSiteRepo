using SocialSiteClassLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        Task<T> InsertAsync(T element, CancellationToken token = default);
        Task<T> UpdateAsync(T element, CancellationToken token = default);
        Task<bool> DeleteAsync(T element, CancellationToken token = default);
        Task<T> GetAsync(Guid Id, CancellationToken token = default);
        Task<IEnumerable<T>> GetAllAsync(CancellationToken token = default);
    }
}
