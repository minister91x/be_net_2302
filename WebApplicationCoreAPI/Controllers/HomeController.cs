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
        private readonly IProductServices _productServices;
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IProductServices productServices, IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _productServices = productServices;
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }


        [HttpPost("GetStringData")]
        [AuthorizeDemo()]
        public async Task<ActionResult> GetStringData()
        {
            await Task.Yield();

            // var list = await _productServices.GetProducts();

            _unitOfWork.Products.Product_GetAll();
            _unitOfWork.employeer.Employeer_Insert(new NHANVIEN { DiaChi = "" });
            _unitOfWork.Save();
            //  unitOfwork.ProductRepos.Product_GetAll();

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
