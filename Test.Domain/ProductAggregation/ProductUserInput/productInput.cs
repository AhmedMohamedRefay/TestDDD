using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.ProductAggregation.ProductUserInput
{
    public class productInput
    {
        public productInput(string name, string description, decimal price)
        {
            this.name = name;
            this.description = description;
            this.price = price;
        }

        public productInput()
        {
            
        }
        public string  name { get; set; }

        public string description { get; set; }

        public decimal price { get; set; }
    }
}
