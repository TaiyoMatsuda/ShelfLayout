using ShelfLayout.Shared.Entities.Observable;

namespace ShelfLayout.Client.Presenters.Counter
{
    public interface ICounterPresenter
    {
        IPropertyObservable<int> Count { get; }
        public void IncrementCount();
    }
}