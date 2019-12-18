using API.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Service.Interface
{
   public interface ICommonService<T,K>
    {
        T FindById(K id);
        IQueryable<T> FindAll();
        PagedList<T> FindAllPaging(string keyword, int page, int pageSize);

        void Add(T entity);
        void Update(T entity);
        void Remove(K id);
        void RemoveMultiple(List<T> entities);
    }
}
