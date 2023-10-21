using ShelfLayout.Shared.Entities.Observable;

namespace ShelfLayout.Client.Usecases.Counter
{
    public interface ICounterUsecase
    {
        IPropertyObservable<int> Counts { get; }
        void IncrementCount();
    }
}
