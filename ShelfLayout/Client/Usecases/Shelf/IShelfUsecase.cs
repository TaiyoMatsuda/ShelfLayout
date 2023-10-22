using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Client.Usecases.Shelf
{
    public interface IShelfUsecase
    {
        IPropertyObservable<CabinetView> Cabinet { get; }

        Task GetAsync();
    }
}
