using System.ComponentModel.DataAnnotations.Schema;
using Test.Domain.ProductAggregation;

namespace Test.Application.Dto
{
    public class OrderItemDTO
    {
       

        public int Quantity { get; private set; }

       
        public Guid productId { get; private set; }

      
    }
}
