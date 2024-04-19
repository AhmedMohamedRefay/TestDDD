using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Domain.OrderAggregation.Input
{
    public class OrderItemUserInput
    {
        public OrderItemUserInput(string name, string description, decimal price, int quantity)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
        }
        public OrderItemUserInput()
        {

        }
        public string name { get; set; }

        public string description { get; set; }
        public decimal price { get; set; }
        public int quantity { get; set; }

    }
}
