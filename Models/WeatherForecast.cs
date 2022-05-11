namespace singleFileAPI.Models;

public record  WeatherForecast(DateTime Date, int TempratureC, string? Summary)
{
    public int TemperatureF => 32 + (int) (TempratureC / 0.5556);
}
