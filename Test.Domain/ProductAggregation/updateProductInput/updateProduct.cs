using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.ProductAggregation.updateProductInput
{
    public class updateProduct
    {
        public updateProduct(string name, string description, decimal price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public updateProduct()
        {
            
        }
        public string Name { get; set;}

        public string Description { get; set;}

        public decimal Price { set; get;}   
    }
}
