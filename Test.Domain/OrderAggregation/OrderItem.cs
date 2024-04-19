using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Test.Domain.OrderAggregation.Input;
using Test.Domain.ProductAggregation;
using Test.Domain.SeedWork;

namespace Test.Domain.OrderAggregation
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(string name, string description, decimal price, int quantity, Guid productId)
        {
            Validate(new OrderItemUserInput(name, description, price, quantity));

            Name = name;
            Description = description;
            Price = price;
            Quantity = quantity;
            this.productId = productId;
        }
        public OrderItem()
        {

        }
        private static void Validate(OrderItemUserInput input)
        {
            if (string.IsNullOrEmpty(input.name)) throw new ArgumentNullException("name");
            if (string.IsNullOrEmpty(input.description)) throw new ArgumentNullException("description");



            if (input.price < 0) throw new Exception("price can not be negative");
            if (input.quantity <= 0) throw new Exception("quantity must be greater than 0");

        }
        public string Name { get; private set; }

        public string Description { get; private set; }

        public decimal Price { get; private set; }

        public int Quantity { get; private set; }

        [ForeignKey("product")]
        public Guid productId { get; private set; }

        public Product product { get; private set; }

    }
}