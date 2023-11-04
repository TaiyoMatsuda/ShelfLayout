using AutoMapper;
using ShelfLayout.Client.Gateway.Shelf;
using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.ShelfLayout;
using ShelfLayout.Shared.Profiles;

namespace ShelfLayout.Client.Usecases.Shelf
{
    public class ShelfUsecase: IShelfUsecase
    {
        public IPropertyObservable<CabinetView> Cabinet => _cabinet;
        private readonly PropertyObservable<CabinetView> _cabinet;

        private readonly ICabinetGateway _gateway;
        private readonly IMapper _mapper;

        public ShelfUsecase(ICabinetGateway gateway)
        {
            _gateway = gateway;

            _cabinet = new(new());

            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ShelfProfile());
            });
             _mapper = mapperConfig.CreateMapper();
        }

        public async Task GetAsync(int storeId, int cabinetId)
        {
            var cabinets = await _gateway.GetAsync(storeId, cabinetId);
            var cabinet = cabinets.FirstOrDefault();
            var result = _mapper.Map<CabinetView>(cabinet);
            _cabinet.Notify(result);
        }
    }
}
