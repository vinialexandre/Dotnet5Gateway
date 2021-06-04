using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Api1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PowersController : ControllerBase
    {
        private readonly ILogger<PowersController> _logger;

        public PowersController(ILogger<PowersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Web" };
        }
    }
}
