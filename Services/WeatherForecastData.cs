using singleFileAPI.Models;

namespace singleFileAPI.Services;

public class WeatherForecastData
{
    private readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot"
    };

    public IEnumerable<WeatherForecast> GetData()
    {
        return  Enumerable.Range(1, 5).Select(i =>
                new WeatherForecast(
                    DateTime.Now.AddDays(i),
                    Random.Shared.Next(-20, 55),
                    Summaries[Random.Shared.Next(Summaries.Length)]
                ))
            .ToArray();
    }
}