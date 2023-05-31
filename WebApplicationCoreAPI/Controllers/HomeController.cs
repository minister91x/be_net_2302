using DataAccess.DependencyInjection.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.DataAccess.DbContext;
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

            // var list = await _productServices.GetProducts();

            var unitOfwork = new UnitOfWork.DataAccess.UnitOfWork.MyShopUnitOfWork(new MyShopUnitOfWorkDbContext());

            unitOfwork.ProductRepos.Product_GetAll();

            return Ok();
        }

        [HttpPost("GetText")]
        public async Task<ActionResult> GetText(GetTextInputRequest request)
        {
            await Task.Yield();
            return Ok(request.Text);
        }
    }
}
