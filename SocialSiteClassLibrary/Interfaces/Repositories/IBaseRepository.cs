using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialSiteClassLibrary.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        T Insert(T element);
        bool Update(T element);
        bool Delete(T element);
        T Get(Guid Id);
        IEnumerable<T> GetAll();
    }
}
