using ShelfLayout.Client.Gateway.Shelf;
using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.Shelf;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Client.Usecases.Shelf
{
    public class ShelfUsecase: IShelfUsecase
    {
        public IPropertyObservable<CabinetView> Cabinet => _cabinet;
        private readonly PropertyObservable<CabinetView> _cabinet;

        private readonly ICabinetGateway _gateway;

        public ShelfUsecase(ICabinetGateway gateway)
        {
            _gateway = gateway;

            _cabinet = new(new());
        }

        public async Task GetAsync()
        {
            var cabinets = await _gateway.GetAsync();

            var lanes = new List<LaneView>();

            var result = new CabinetView()
            {
                //Id = cabinet.Id,
                //PositionX = cabinet.PositionX,
                //PositionY = cabinet.PositionY,
                //PositionZ = cabinet.PositionZ,
                //Lanes = lanes
            };

            _cabinet.Notify(result);
        }
    }
}
