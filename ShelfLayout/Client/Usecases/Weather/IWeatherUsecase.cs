﻿using ShelfLayout.Shared.Entities.Observable;
using ShelfLayout.Shared.Entities.Weather;

namespace ShelfLayout.Client.Usecases.Weather
{
    public interface IWeatherUsecase
    {
        IPropertyObservable<WeatherForecast[]?> Forecasts { get; }

        Task GetAllAsync();
    }
}