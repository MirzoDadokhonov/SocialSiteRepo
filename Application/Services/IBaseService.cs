using SocialSiteClassLibrary.Entities;

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
