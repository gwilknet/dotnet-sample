using Microsoft.AspNetCore.Mvc;

namespace BackendTestApp.Controllers
{
    [ApiController]
    [Route("api/v1/workouts")]
    public class WorkoutsController : ControllerBase
    {
        //private readonly ILogger<WeatherForecastController> _logger;

        //public WeatherForecastController(ILogger<WeatherForecastController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet()]
        //[Route("forecast")]
        //public IEnumerable<WeatherForecast>? Get([FromServices] IQueryHandler<GetWeatherForecastResult> query)
        //{
        //    var result = query.Handle();

        //    if (result is not null)
        //    {
        //        return result.ResultList;
        //    }

        //    return null;
        //}
    }
}