using ConvensionApi.Model;
using ConvensionApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ConvensionApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ConvensionController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ConvensionController> _logger;

    private readonly IConvensionRepository _convensionRepository;

    public ConvensionController(ILogger<ConvensionController> logger, IConvensionRepository convensionRepository)
    {
        _logger = logger;
        _convensionRepository = convensionRepository;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Convension> Get()
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

