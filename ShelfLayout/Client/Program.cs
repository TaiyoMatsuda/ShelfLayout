using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using ShelfLayout.Client;
using ShelfLayout.Client.Gateway.Shelf;
using ShelfLayout.Client.Presenters.Shelf;
using ShelfLayout.Client.Usecases.Shelf;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddTransient<IShelfPresenter, ShelfPresenter>();

builder.Services.AddTransient<IShelfUsecase, ShelfUsecase>();

builder.Services.AddTransient<ICabinetGateway, CabinetGateway>();


await builder.Build().RunAsync();
