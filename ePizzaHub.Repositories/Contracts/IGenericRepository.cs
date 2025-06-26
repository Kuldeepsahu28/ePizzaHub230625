using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ePizzaHub.Repositories.Contracts
{
    public interface IGenericRepository<T> where T:class
    {
        Task<T> AddAsync(T entity);
        IEnumerable<T> GetAllAsync();
        Task<int> CommitAsync();
    }
}
