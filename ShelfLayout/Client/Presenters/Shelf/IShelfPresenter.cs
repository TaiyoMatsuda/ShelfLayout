using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Client.Presenters.Shelf
{
    public interface IShelfPresenter
    {
        IPropertyObservable<CabinetView> Cabinet { get; }

        Task GetAsync();
    }
}
