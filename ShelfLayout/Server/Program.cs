using ShelfLayout.Server.Infrastructure;
using ShelfLayout.Server.Repositorys.Shelf;
using ShelfLayout.Server.Repositorys.Weather;
using ShelfLayout.Server.Usecases.Shelf;
using ShelfLayout.Server.Usecases.Weather;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

builder.Services.AddTransient<DapperDbContext>();

builder.Services.AddTransient<IWeatherUsecase, WeatherUsecase>();
builder.Services.AddTransient<IShelfUsecase, ShelfUsecase>();

builder.Services.AddTransient<IWeatherRepository, WeatherRepository>();
builder.Services.AddTransient<IShelfRepository, ShelfRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
