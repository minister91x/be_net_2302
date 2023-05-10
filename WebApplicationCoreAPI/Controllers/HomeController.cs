using DataAccess.DependencyInjection.IServices;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<ActionResult> GetStringData()
        {
            await Task.Yield();

            var list = _productServices.GetProducts();
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
