using AutoMapper;
using BMS.Data.Models;

namespace BMS.Data.Models
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderNewEdit, Order>()
                .ForMember(dest => dest.OrderId, opt => opt.Ignore()) // Usually ignored for new entities
                .ForMember(dest => dest.OrderItems, opt => opt.MapFrom(src => src.OrderItems));
            CreateMap<OrderItemNewEdit, OrderItem>()
                .ForMember(dest => dest.OrderItemId, opt => opt.Ignore()) // Usually ignored for new entities
                .ForMember(dest => dest.Order, opt => opt.Ignore()); // Prevent circular reference
        }
    }
}