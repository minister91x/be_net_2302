using DataAccess.DependencyInjection.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Entities;
using UnitOfWork.DataAccess.UnitOfWork;
using WebApplicationCoreAPI.Helper;
using WebApplicationCoreAPI.UnitOfWork;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }


        [HttpPost("GetStringData")]
        // [AuthorizeDemo()]
        public async Task<ActionResult> GetStringData()
        {
            await Task.Yield();

            // var list = await _productServices.GetProducts();

            var list = _unitOfWork._employeer.GetListNhanVien();

            //  unitOfwork.ProductRepos.Product_GetAll();

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
