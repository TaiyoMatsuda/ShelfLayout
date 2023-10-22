using Microsoft.AspNetCore.Components;
using MudBlazor;
using ShelfLayout.Client.Presenters.Shelf;
using ShelfLayout.Client.Presenters.Weather;
using ShelfLayout.Shared.Entities;
using ShelfLayout.Shared.Entities.View.ShelfLayout;

namespace ShelfLayout.Client.Pages.Shelf
{
    public partial class Index
    {
        private CabinetView _cabinet { get; set; }

        private DisposableList _disposables = new();

        [Inject]
        private IShelfPresenter _presenter { get; set; }

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

        public bool SetHeight { get; set; } = false;
        public bool SetWidth { get; set; } = true;

        public int ImageHeight { get; set; } = 300;
        public int ImageWidth { get; set; } = 300;

        public ObjectFit ImageFit { get; set; } = ObjectFit.Cover;
        int _papers = 7;
        int papers { get { return _papers; } set { UpdatePapers(value); } }

        int[] breaks = new int[7] { 3, 4, 2, 3, 3, 2, 4 };

        Justify justification = Justify.FlexStart;

        void UpdatePapers(int value)
        {

            int[] newbreaks = Enumerable.Repeat(3, value).ToArray();

            for (int i = 0; i < newbreaks.Length; i++)
            {
                if (i < breaks.Length)
                {
                    newbreaks[i] = breaks[i];
                }
            }

            breaks = newbreaks;

            _papers = value;

            StateHasChanged();
        }

        void UpdateBreaks()
        {

            StateHasChanged();
        }
    }
}
