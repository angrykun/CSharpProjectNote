using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace RemoteSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderServiceController : ControllerBase
    {
        private static readonly string[] Sumaries = new[]
        {
            "Freezing","Bracing","Chilly","Cool","Mild","Warm","Balmy","Hot","Sweltering","Scorching"
        };

        private readonly ILogger<OrderServiceController> _logger;

        public OrderServiceController(ILogger<OrderServiceController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast()
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Sumaries[rng.Next(Sumaries.Length)]
            }).ToArray();
        }


    }
}
