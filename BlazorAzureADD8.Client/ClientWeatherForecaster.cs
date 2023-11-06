using System.Net.Http.Json;
using BlazorAzureADD8.Models;

namespace BlazorAzureADD8.Client;

internal sealed class ClientWeatherForecaster(HttpClient httpClient) : IWeatherForecaster
{
    public async Task<IEnumerable<WeatherForecast>> GetWeatherForecastAsync() =>
        await httpClient.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast")
        ?? throw new IOException("No weather forecast!");
}
