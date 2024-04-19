using AutoMapper;
using Test.Application.Dto;
using Test.Domain.OrderAggregation;
using Test.Domain.ProductAggregation;
using Test.Domain.SeedWork;

namespace Test.Application.AuMapp
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
              .ForMember(dest => dest.address, opt => opt.MapFrom(src => src.Address))
              .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));

                cfg.CreateMap<Address, AddressDTO>();

                cfg.CreateMap<OrderItem, OrderItemDTO>()
                    .ForMember(dest => dest.Quantity, opt => opt.MapFrom(src => src.Quantity))
                    .ForMember(dest => dest.productId, opt => opt.MapFrom(src => src.productId));


            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
