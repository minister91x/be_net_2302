using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreAPI.Entities;
using WebApplicationCoreAPI.LoggerService;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogingController : ControllerBase
    {
        public ILogger<Student> _logger;
        private readonly ILoggerManager _loggerManager;

        public LogingController(ILogger<Student> logger, ILoggerManager loggerManager)
        {
            _logger = logger;
            _loggerManager = loggerManager;
        }

        [HttpPost("Index")]
        public IActionResult Index()
        {
            var student = new Student("MrQuan", "BE_NET_CORE_0323", _logger);
            return Ok();
        }

        [HttpPost("Index2")]
        public IActionResult Index2()
        {
            _loggerManager.LogInfo("Here is info message from the controller.");
            _loggerManager.LogDebug("Here is debug message from the controller.");
            _loggerManager.LogWarn("Here is warn message from the controller.");
            _loggerManager.LogError("Here is error message from the controller.");
            return Ok();
        }

    }

}
