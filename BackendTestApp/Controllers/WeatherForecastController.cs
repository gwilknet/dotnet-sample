using BackendTestApp.Application.Model;
using BackendTestApp.Application.QueryHandlers;
using Microsoft.AspNetCore.Mvc;

namespace BackendTestApp.Controllers
{
    [ApiController]
    [Route("api/v1/weather")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        [Route("forecast")]
        public IEnumerable<WeatherForecast>? Get([FromServices] IQuery<GetWeatherForecastResult> query)
        {
            var result = query.Handle();

            if (result is not null)
            {
                return result.ResultList;
            }

            return null;
        }
    }
}