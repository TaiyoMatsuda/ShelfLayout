using Microsoft.AspNetCore.Components;
using MudBlazor;
using ShelfLayout.Client.Presenters.Shelf;
using ShelfLayout.Shared.Entities;
using ShelfLayout.Shared.Entities.View.Shelf;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Client.Pages.Shelf
{
    public partial class Index
    {
        private CabinetView _cabinet { get; set; } = new CabinetView();

        private DisposableList _disposables = new();

        [Inject]
        private IShelfPresenter _presenter { get; set; }

        private CabinetRowLaneView _selectedLane = new CabinetRowLaneView();

        protected override async void OnInitialized()
        {
            await _presenter.GetAsync();

            var disposable = _presenter.Cabinet.Subscribe((x) =>
            {
                _cabinet = x;
                StateHasChanged();
            });

            _disposables.Add(disposable);
        }

        public void Dispose()
        {
            _disposables.DisposeAll();
        }

        void UpdateBreaks(CabinetRowLaneView lane)
        {
            _selectedLane = lane;
            StateHasChanged();
        }
    }
}
