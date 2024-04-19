using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.Interfaces;
using Test.Domain.ProductAggregation; 
using Test.Infrastructure.DataBase;

namespace Test.Infrastructure.Repository
{
    public class productRepository : IProductRepository
    {
        private readonly EcomerceDbContext _context;

        public productRepository(EcomerceDbContext context)
        {
            _context = context;
        }

        public void Add(Product Product)
        {
            _context.Add(Product);
        }

        public void Delete(Product Product)
        {
            _context.Remove(Product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(Guid ProductId)
        {

            var ord = _context.Products.Find(ProductId);

            return ord ;
        }

        public void Update(Product Product)
        {
            _context.Update(Product);
        }
        public void SaveChange()
        {
            _context.SaveChanges();
        }
    }
    
}
