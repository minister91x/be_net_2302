using DataAccess.DependencyInjection.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Entities;
using UnitOfWork.DataAccess.UnitOfWork;
using WebApplicationCoreAPI.Helper;
using WebApplicationCoreAPI.LoggerService;
using WebApplicationCoreAPI.UnitOfWork;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILoggerManager _loggerManager;
        public HomeController(IConfiguration configuration, IUnitOfWork unitOfWork, ILoggerManager loggerManager)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            _loggerManager = loggerManager;
        }


        [HttpPost("GetStringData")]
        // [AuthorizeDemo()]
        public async Task<ActionResult> GetStringData()
        {
            var logId = DateTime.Now.Ticks;
            await Task.Yield();

            // var list = await _productServices.GetProducts();
            var a = 1;
            var list = _unitOfWork._employeer.GetAll();
            _loggerManager.LogInfo("logId:" + logId + "|HomeController GetStringData employeerData:" + JsonConvert.SerializeObject(list));
            //  unitOfwork.ProductRepos.Product_GetAll();

            var b = 2;
            _loggerManager.LogInfo("logId:" + logId + "| b:" + b);

            return Ok(list);
        }

        [HttpPost("GetText")]
        public async Task<ActionResult> GetText(GetTextInputRequest request)
        {
            await Task.Yield();
            return Ok(request.Text);
        }
    }
}
