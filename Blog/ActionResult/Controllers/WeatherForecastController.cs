using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ActionResult.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        // /// <summary>
        // /// Specific type
        // /// 指定回傳型別為 IEnumerable<WeatherForecast>，並將 Http Status Code 設為 400
        // /// </summary>
        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     Response.StatusCode = 400;
        //
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }

        // /// <summary>
        // /// IActionResult
        // /// 透過 ControllerBase 的方法來縮寫 NotFoundResult() & OkObjectResult()
        // /// </summary>
        // [HttpGet("{id}")]
        // public IActionResult Get(int id)
        // {
        //     if (id == 0)
        //     {
        //         // return new NotFoundResult();
        //         return NotFound();
        //     }
        //
        //     // return new OkObjectResult(product);
        //     return Ok(Summaries);
        // }

        // /// <summary>
        // /// IActionResult
        // /// 透過 Attribute ProducesResponseType 定義 Http Status Code & 回傳型別
        // /// </summary>
        // [HttpGet("{id}")]
        // [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string[]))]
        // public IActionResult Get(int id)
        // {
        //     return Ok(Summaries);
        // }

        /// <summary>
        /// ActionResult<T>
        /// 透過 Attribute ProducesResponseType 定義 Http Status Code
        /// 回傳型別可由 ActionResult<T> 取得
        /// return 可簡寫成 return Summaries;
        /// </summary>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<string[]> Get(int id)
        {
            return Summaries;
        }
    }
}
