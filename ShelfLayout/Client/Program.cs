using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using ShelfLayout.Client;
using ShelfLayout.Client.Gateway.Counter;
using ShelfLayout.Client.Gateway.Weather;
using ShelfLayout.Client.Presenters.Counter;
using ShelfLayout.Client.Presenters.Weather;
using ShelfLayout.Client.Usecases.Counter;
using ShelfLayout.Client.Usecases.Weather;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddMudServices();

builder.Services.AddTransient<IWeatherPresenter, WeatherPresenter>();
builder.Services.AddTransient<ICounterPresenter, CounterPresenter>();

builder.Services.AddTransient<ICounterUsecase, CounterUsecase>();
builder.Services.AddTransient<IWeatherUsecase, WeatherUsecase>();

builder.Services.AddTransient<ICounterGateway, CounterGateway>();
builder.Services.AddTransient<IWeatherGateway, WeatherGateway>();


await builder.Build().RunAsync();
