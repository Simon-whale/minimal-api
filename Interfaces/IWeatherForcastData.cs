using singleFileAPI.Models;

namespace singleFileAPI.Interfaces;

public interface IWeatherForcastData
{
    IEnumerable<WeatherForecast> GetData();
}