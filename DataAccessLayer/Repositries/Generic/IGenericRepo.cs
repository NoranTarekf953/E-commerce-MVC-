using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositries.Generic
{
    public interface IGenericRepo<T> where T : class
    {
        Task<IEnumerable<T>> GetAll(Func<IQueryable<T>, IQueryable<T>>? include = null);
        Task<T?> GetById(int id);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(int id);
        Task SaveChangeAsync();
    }
}
