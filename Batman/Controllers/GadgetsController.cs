using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Api2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GadgetsController : ControllerBase
    {

        private readonly ILogger<GadgetsController> _logger;

        public GadgetsController(ILogger<GadgetsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Batrang" };
        }
    }
}
