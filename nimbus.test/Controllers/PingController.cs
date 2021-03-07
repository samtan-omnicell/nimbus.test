using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace nimbus.test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingController : ControllerBase
    {
        private readonly ILogger<PingController> _logger;

        public PingController(ILogger<PingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            _logger.LogInformation("Returning Pong to the Ping");
            return "pong";
        }
    }
}
