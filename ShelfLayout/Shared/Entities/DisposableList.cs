namespace ShelfLayout.Shared.Entities
{
    public class DisposableList
    {
        private List<IDisposable> _list = new();

        public void Add(IDisposable disposable)
        {
            _list.Add(disposable);
        }

        public void DisposeAll()
        {
            foreach (var d in _list)
            {
                d?.Dispose();
            }
        }
    }
}
