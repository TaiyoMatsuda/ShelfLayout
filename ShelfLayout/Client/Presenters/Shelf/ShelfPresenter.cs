using ShelfLayout.Client.Usecases.Shelf;
using ShelfLayout.Shared.Entities;
using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Client.Presenters.Shelf
{
    public class ShelfPresenter: IShelfPresenter
    {
        public IPropertyObservable<CabinetView> Cabinet => _cabinet;
        private readonly PropertyObservable<CabinetView> _cabinet;

        private readonly IShelfUsecase _usecase;

        private readonly DisposableList _disposables = new();

        public ShelfPresenter(IShelfUsecase usecase)
        {
            _usecase = usecase;

            _cabinet = new(new());

            var disposable = _usecase.Cabinet.Subscribe((num) =>
            {
                _cabinet.Notify(num);
            });

            _disposables.Add(disposable);
        }

        public async Task GetAsync()
        {
            await _usecase.GetAsync(1,1);
        }
    }
}
