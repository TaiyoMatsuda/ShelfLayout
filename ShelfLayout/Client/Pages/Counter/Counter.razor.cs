using Microsoft.AspNetCore.Components;
using ShelfLayout.Client.Presenters.Counter;
using ShelfLayout.Shared.Entities;
using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace ShelfLayout.Client.Pages.Counter
{
    public partial class Counter
    {
        private int _currentCount = 0;

        private Subject<int> clickSubject = new Subject<int>();

        private DisposableList _disposables = new();
        
        [Inject]
        private ICounterPresenter _presenter { get; set; }

        protected override void OnInitialized()
        {
            var disposable = _presenter.Count.Subscribe((x) =>
            {
                _currentCount = x;
                StateHasChanged();
            });

            _disposables.Add(disposable);
        }

        private void IncrementCount()
        {
            _presenter.IncrementCount();
        }

        public void Dispose()
        {
            _disposables.DisposeAll();
        }
    }
}
