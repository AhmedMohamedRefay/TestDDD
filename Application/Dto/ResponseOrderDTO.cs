namespace Test.Application.Dto
{
    public class ResponseOrderDTO
    {
        public List<OrderItemDTO>  OrderItems { set; get; }
        public AddressDTO address { set; get; }
     
    }
}
