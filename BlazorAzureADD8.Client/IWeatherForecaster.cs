using BlazorAzureADD8.Models;

namespace BlazorAzureADD8.Client;

public interface IWeatherForecaster
{
    public Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync();
}
