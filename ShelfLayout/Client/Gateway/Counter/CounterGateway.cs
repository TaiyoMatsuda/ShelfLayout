using ShelfLayout.Shared.Entities.Counter;

namespace ShelfLayout.Client.Gateway.Counter
{
    public class CounterGateway : ICounterGateway
    {
        private readonly Count _count;

        public CounterGateway()
        {
            _count = new Count();
        }

        public int GetCount()
        {
            return _count.Num;
        }
        public void SetCount(int new_value)
        {
            _count.Num = new_value;
        }
    }
}
