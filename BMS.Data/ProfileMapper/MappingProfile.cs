using AutoMapper;
using BMS.Data.Models;

namespace BMS.Data.ProfileMapper
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
            CreateMap<ProductAddEditModal, Product>()
                .ForMember(dest => dest.Category, opt => opt.Ignore()) // Prevent circular reference
                .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.ProductName))
                .ForMember(dest => dest.MRP, opt => opt.MapFrom(src => src.MRP));
            CreateMap<CategoryAddEditModal, Category>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.PreparationTeamId, opt => opt.MapFrom(src => src.PreparationTeamId))
                .ForMember(dest => dest.PreparationTeam,opt => opt.Ignore())
                .ForMember(dest => dest.CreatedById, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
                .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore())
                .ForMember(dest => dest.SubCategories, opt => opt.Ignore());
        }
    }
}