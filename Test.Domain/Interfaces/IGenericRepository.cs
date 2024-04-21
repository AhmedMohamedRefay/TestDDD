using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
       IEnumerable<T> GetAll();
        T GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        void Delete(T entity);
      
        void UpdateAsync(T entity);

    }
}
