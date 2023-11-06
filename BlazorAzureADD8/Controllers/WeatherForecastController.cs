using BlazorAzureADD8.Client;
using BlazorAzureADD8.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace BlazorAzureADD8.Controllers;

[Authorize]
[ApiController]
[Route("[controller]")]
[RequiredScope(RequiredScopesConfigurationKey = "AzureAd:Scopes")] // this is not working could be me
public class WeatherForecastController : ControllerBase
{
    private readonly IWeatherForecaster _weatherForecaster;
    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(IWeatherForecaster weatherForecaster, ILogger<WeatherForecastController> logger)
    {
        _weatherForecaster = weatherForecaster;
        _logger = logger;
    }

    [HttpGet]
    public Task<IEnumerable<WeatherForecast>> Get() => _weatherForecaster.GetWeatherForecastAsync();
}

