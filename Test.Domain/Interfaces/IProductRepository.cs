using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.OrderAggregation;
using Test.Domain.ProductAggregation;

namespace Test.Domain.Interfaces
{
    public interface IProductRepository :IGenericRepository<Product>
    {
         

    }
}
