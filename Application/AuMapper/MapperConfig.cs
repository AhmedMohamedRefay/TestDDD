using AutoMapper;
using Test.Application.Dto;
using Test.Domain.OrderAggregation;
using Test.Domain.ProductAggregation;

namespace Test.Application.AuMapper
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            //Provide all the Mapping Configuration
            var config = new MapperConfiguration(cfg =>
            {
                
                cfg.CreateMap<Product, productDTO>()
             
                .ForMember(dest => dest.name, act => act.MapFrom(src => src.Name))

               
                .ForMember(dest => dest.description, act => act.MapFrom(src => src.Description))
                .ForMember(dest => dest.price, act => act.MapFrom(src => src.Price));



                cfg.CreateMap<Order, ResponseOrderDTO>()
                .ForMember(dest => dest.address, act => act.MapFrom(src => src.Address))
               ;
                cfg.CreateMap<OrderItem, OrderItemDTO>()
             .ForMember(dest => dest.productId, act => act.MapFrom(src => src.productId))
              .ForMember(dest => dest.Quantity, act => act.MapFrom(src => src.Quantity))
            ;


            });
    
            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
