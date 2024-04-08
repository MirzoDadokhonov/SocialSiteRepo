using SocialSiteClassLibrary.Interfaces.Repositories;

namespace Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        public bool Delete(T element)
        {
            throw new NotImplementedException();
        }

        public T Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T Insert(T element)
        {
            throw new NotImplementedException();
        }

        public bool Update(T element)
        {
            throw new NotImplementedException();
        }
    }
}
