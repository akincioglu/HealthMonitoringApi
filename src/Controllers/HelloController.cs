using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HealthMonitoringApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly ILogger<HelloWorldController> _logger;

        public HelloWorldController(ILogger<HelloWorldController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            _logger.LogInformation("Get metodu çağrıldı.");
            return Ok("Hello World");
        }
    }
}