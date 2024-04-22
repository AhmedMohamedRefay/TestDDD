using Abp.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.ProductAggregation;

namespace Test.Domain.Specification
{
    public class productSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return p => p.Name.Length >= 10;
        }

    }
}
