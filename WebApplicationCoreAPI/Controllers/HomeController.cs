using DataAccess.DependencyInjection.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreAPI.Helper;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IProductServices _productServices;
        private readonly IConfiguration _configuration;
        public HomeController(IProductServices productServices, IConfiguration configuration)
        {
            _productServices = productServices;
            _configuration = configuration;
        }


        [HttpPost("GetStringData")]
        [AuthorizeDemo()]
        public async Task<ActionResult> GetStringData()
        {
            await Task.Yield();

            var list = await _productServices.GetProducts();
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
