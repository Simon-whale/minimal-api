using singleFileAPI.Interfaces;
using singleFileAPI.Models;

namespace singleFileAPI.Services;

public class WeatherForecastData : IWeatherForcastData
{
    private readonly string[] _summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot"
    };

    public IEnumerable<WeatherForecast> GetData()
    {
        return  Enumerable.Range(1, 5).Select(i =>
                new WeatherForecast(
                    DateTime.Now.AddDays(i),
                    Random.Shared.Next(-20, 55),
                    _summaries[Random.Shared.Next(_summaries.Length)]
                ))
            .ToArray();
    }
}