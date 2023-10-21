using ShelfLayout.Client.Gateway.Counter;
using ShelfLayout.Shared.Entities.Observable;

namespace ShelfLayout.Client.Usecases.Counter
{
    public class CounterUsecase : ICounterUsecase
    {
        public IPropertyObservable<int> Counts => _counts;
        private readonly PropertyObservable<int> _counts;

        private readonly ICounterGateway _gateway;

        public CounterUsecase(ICounterGateway gateway)
        {
            _gateway = gateway;

            _counts = new(new() { });
        }

        public void IncrementCount()
        {
            var current = _gateway.GetCount();
            var new_count = current + 1;
            _gateway.SetCount(new_count);

            _counts.Notify(new_count);
        }
    }
}
