using System.ComponentModel.DataAnnotations.Schema;
using Test.Domain.ProductAggregation;

namespace Test.Application.Dto
{
    public class orderDTO
    {
        public string City { get; set; }

        public string Country { get; set; }

        public string ZipCode { get; set; }

        public string Street { get; set; }

        public string itemName { get; set; }

        public string itemDescription { get;  set; }

        public decimal itemPrice { get;  set; }

        public int itemQuantity { get;  set; }

        public Guid productId { get; set; }
    }
}
