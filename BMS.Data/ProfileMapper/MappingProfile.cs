using AutoMapper;
using BMS.Data.Entity;
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
                .ForMember(dest => dest.MRP, opt => opt.MapFrom(src => src.MRP))
                .ForMember(dest => dest.Sort_Order, opt => opt.MapFrom(src => src.Sort_Order))
                .ForMember(dest => dest.UOM, opt => opt.MapFrom(src => src.UOM));

            CreateMap<CategoryAddEditModal, Category>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.PreparationTeamId, opt => opt.MapFrom(src => src.PreparationTeamId))
                .ForMember(dest => dest.Sort_Order, opt => opt.MapFrom(src => src.Sort_Order))
                .ForMember(dest => dest.PreparationTeam,opt => opt.Ignore())
                .ForMember(dest => dest.CreatedById, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
                .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
                .ForMember(dest => dest.Products, opt => opt.Ignore())
                .ForMember(dest => dest.SubCategories, opt => opt.Ignore());

            CreateMap<ProductRawMaterialAddModal, ProductRawMaterial>()
               .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
               .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.ProductId))
               .ForMember(dest => dest.RawMaterialId, opt => opt.MapFrom(src => src.RawMaterialId))
               .ForMember(dest => dest.MapType, opt => opt.MapFrom(src => src.MapType))
               .ForMember(dest => dest.Product, opt => opt.Ignore())
               .ForMember(dest => dest.RawMaterial, opt => opt.Ignore());

            CreateMap<IngredientAddEditModal, RawMaterial>()
                .ForMember(dest => dest.RawMaterialId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.IngredientName))
                .ForMember(dest => dest.StockQuantity, opt => opt.MapFrom(src => src.SysStockQty))
                .ForMember(dest => dest.CP, opt => opt.MapFrom(src => src.CP))
                .ForMember(dest => dest.Unit, opt => opt.MapFrom(src => src.uom))
                .ForMember(dest => dest.ProductRawMaterials, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<CustomerAddEditModal, Customer>()
                .ForMember(dest => dest.CustomerId, opt => opt.MapFrom(src => src.CustomerId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
                .ForMember(dest => dest.GSTNo, opt => opt.MapFrom(src => src.GSTNo))
                .ForMember(dest => dest.ImgFileExtn, opt => opt.MapFrom(src => src.ImgFileExtn))
                .ForMember(dest => dest.CreatedById, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
                .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
                .ForMember(dest => dest.Orders, opt => opt.Ignore())
                .ForMember(dest => dest.Invoices, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<PreparationTeamAddEditModal, PreparationTeam>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.TeamName, opt => opt.MapFrom(src => src.TeamName))
                .ForMember(dest => dest.CreatedById, opt => opt.Ignore())
                .ForMember(dest => dest.CreatedOn, opt => opt.Ignore())
                .ForMember(dest => dest.IsDeleted, opt => opt.Ignore())
                .ForMember(dest => dest.Categories, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<ProductRawMaterialMapTypeAddEditModal, ProductRawMaterialMapType>().ReverseMap();

            CreateMap<UomAddEditModal, UomMaster>().ReverseMap();
        }
    }
}