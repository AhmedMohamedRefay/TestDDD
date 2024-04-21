using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Interfaces;
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Repository
{
    public abstract class GnericRepository<T>  : IGenericRepository <T> where T : class
    {
        private readonly EcomerceDbContext _context;

        public GnericRepository(EcomerceDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }
        public  IEnumerable<T> GetAll()
        {
           return  _context.Set<T>().ToList();
        }

        public T GetByIdAsync(Guid id)
        {
            return  _context.Set<T>().Find(id);
        }

        public void UpdateAsync(T entity)
        {
              _context.Set<T>().Update(entity);
        }
    }
}
