namespace ShelfLayout.Client.Gateway.Counter
{
    public interface ICounterGateway
    {
        void SetCount(int new_value);
        int GetCount();
    }
}
