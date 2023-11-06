using AutoMapper;
using ShelfLayout.Shared.Entities.Response;
using ShelfLayout.Shared.Entities.Response.Shelf;
using ShelfLayout.Shared.Entities.View;
using ShelfLayout.Shared.Entities.View.Shelf;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Shared.Profiles
{
    public class ShelfProfile : Profile
    {
        public ShelfProfile()
        {
            CreateMap<CabinetResponse, CabinetView>();
            CreateMap<CabinetRowResponse, CabinetRowView>();
            CreateMap<CabinetRowLaneResponse, CabinetRowLaneView>();
            CreateMap<ProductResponse, ProductView>();
        }
    }
}