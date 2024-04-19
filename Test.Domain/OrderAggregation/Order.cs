using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Test.Domain.SeedWork;

namespace Test.Domain.OrderAggregation
{
    public class Order:BaseEntity
    {
       

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems=> _orderItems;

        public  DateTime _orderDate { set; get; }
        public Address Address { get; private set; }
        
 

        
      public Order() { }
       
        public Order(Address address )
        {
            _orderItems = new List<OrderItem>();
           Address = address;
            _orderDate = DateTime.UtcNow;
         
        }

        public void AddOrderItem(OrderItem orderItem)
        {
          
            _orderItems.Add(orderItem);

        }
        public void RemoveItem(OrderItem orderItem)
        {
            _orderItems.Remove(orderItem);
        }


    }
}
