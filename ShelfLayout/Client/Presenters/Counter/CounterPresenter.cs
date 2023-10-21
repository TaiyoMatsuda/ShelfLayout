using ShelfLayout.Client.Usecases.Counter;
using ShelfLayout.Shared.Entities;
using ShelfLayout.Shared.Entities.Observable;

namespace ShelfLayout.Client.Presenters.Counter
{
    public class CounterPresenter : ICounterPresenter, IDisposable
    {
        public IPropertyObservable<int> Count => _count;
        private readonly PropertyObservable<int> _count;

        private readonly ICounterUsecase _usecase;

        private readonly DisposableList _disposables = new();

        public CounterPresenter(ICounterUsecase usecase)
        {
            _usecase = usecase;

            _count = new(0);

            var disposable = _usecase.Counts.Subscribe((num) =>
            {
                _count.Notify(num);
            });

            _disposables.Add(disposable);
        }

        public void IncrementCount()
        {
            _usecase.IncrementCount();
        }

        public void Dispose()
        {
            // Release all of registered subscriptions
            _disposables.DisposeAll();
        }
    }
}
