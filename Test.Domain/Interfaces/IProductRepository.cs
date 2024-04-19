using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.OrderAggregation;
using Test.Domain.ProductAggregation;

namespace Test.Domain.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
         
        void Add(Product product);

        void Update(Product product);
        
        void Delete(Product product);

        Product GetById(Guid productId);

        void SaveChange();

    }
}
