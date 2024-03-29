using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace MeuPrimeiroAPI.Controllers
{
    [ApiController]
    [Route("WeatherForecastController/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public WeatherForecastController() { }

        private static readonly string[] Summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };


        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}