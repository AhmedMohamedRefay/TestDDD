using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Interfaces;
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EcomerceDbContext _context;

        public UnitOfWork(EcomerceDbContext context, IProductRepository productRepository, 
            IOrderRepository orderRepository)
        {
            _context = context;
            ProductRepository = productRepository;
            OrderRepository = orderRepository;
           
        }

        public IProductRepository ProductRepository { get; private set; }

        public IOrderRepository OrderRepository { get; private set; } 

        
        public int save()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
        }

    }
}
