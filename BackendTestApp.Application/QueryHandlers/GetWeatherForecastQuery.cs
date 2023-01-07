using BackendTestApp.Application.Model;

namespace BackendTestApp.Application.QueryHandlers;

public interface IQuery<TResult>
{
    TResult Handle();
}

public class GetWeatherForecastResult
{
    public IEnumerable<WeatherForecast>? ResultList { get; set; }
}

public class GetWeatherForecastQuery : IQuery<GetWeatherForecastResult>
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public GetWeatherForecastResult Handle()
    {
        return new GetWeatherForecastResult
        {
            ResultList = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray()
        };
    }
}
