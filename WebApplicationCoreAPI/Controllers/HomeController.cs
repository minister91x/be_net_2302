using DataAccess.DependencyInjection.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Entities;
using UnitOfWork.DataAccess.UnitOfWork;
using WebApplicationCoreAPI.Entities;
using WebApplicationCoreAPI.Filter;
using WebApplicationCoreAPI.Helper;
using WebApplicationCoreAPI.LoggerService;
using WebApplicationCoreAPI.Models;
using WebApplicationCoreAPI.UnitOfWork;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    // [ServiceFilter(typeof(CustomExceptionFilterAttribute))]
    public class HomeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;
        // private readonly ILoggerManager _loggerManager;
        public HomeController(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
            //_loggerManager = loggerManager;
        }


        [HttpPost("Index")]
        public async Task<ActionResult> Index(Student student)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }


            //var a = 10;
            //var b = 0;
            //var c = a / b;
            return Ok();
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
            // _loggerManager.LogInfo("logId:" + logId + "|HomeController GetStringData employeerData:" + JsonConvert.SerializeObject(list));
            //  unitOfwork.ProductRepos.Product_GetAll();

            var b = 2;
            //   _loggerManager.LogInfo("logId:" + logId + "| b:" + b);

            return Ok(list);
        }

        [HttpPost("GetText")]
        public async Task<ActionResult> GetText(GetTextInputRequest request)
        {
            await Task.Yield();
            return Ok(request.Text);
        }

        [HttpPost("Import")]
        public async Task<ActionResult> Import([FromForm] UploadFileInputDto formFile)
        {
            var listModel = new List<ProductImportModels>();
            if (formFile == null || formFile.File.Length <= 0)
            {
                throw new UserFriendlyException(System.Net.HttpStatusCode.NotFound, "file dữ liệu không được trống");
            }

            if (!Path.GetExtension(formFile.File.FileName).Equals(".xlsx", StringComparison.OrdinalIgnoreCase))
            {
                throw new UserFriendlyException(System.Net.HttpStatusCode.NotFound, "Hệ thống chỉ hỗ trợ file .xlsx");
            }

            using (var stream = new MemoryStream())
            {

                await formFile.File.CopyToAsync(stream);

                using (var package = new ExcelPackage(stream))
                {
                    ExcelPackage.LicenseContext = LicenseContext.Commercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowCount = worksheet.Dimension.Rows;

                    for (int row = 3; row <= rowCount; row++)
                    {
                        var productname = worksheet.Cells[row, 1]?.Value?.ToString()?.Trim();
                        var short_desc = worksheet.Cells[row, 2]?.Value?.ToString()?.Trim();
                        var desc = worksheet.Cells[row, 3]?.Value?.ToString()?.Trim();
                        var price = worksheet.Cells[row, 4]?.Value?.ToString()?.Trim();
                        var date_export = worksheet.Cells[row, 5]?.Value?.ToString()?.Trim();



                        //var datenumval = !string.IsNullOrEmpty(date_export) ? date_export.Split(' ')[0].ToString() : string.Empty;
                        ////16/04/2023
                        ////4/16/2023
                        //var year = !string.IsNullOrEmpty(datenumval) ? Convert.ToInt32(date_export.Split('/')[2]?.ToString()) : 0;
                        //var month = !string.IsNullOrEmpty(datenumval) ? Convert.ToInt32(date_export.Split('/')[0]?.ToString()) : 0;
                        //var day = !string.IsNullOrEmpty(datenumval) ? Convert.ToInt32(date_export.Split('/')[1]?.ToString()) : 0;

                        //var new_date = new DateTime(year, month, day);

                        listModel.Add(new ProductImportModels
                        {
                            ProductName = productname,
                            ShortDes = short_desc,
                            Desc = desc,
                            Price = Convert.ToInt32(price)
                        });
                    }

                }
            }

            return Ok(listModel);
        }

        [HttpPost("GetListProduct")]
        public async Task<ActionResult> GetListProduct(ProductGetlistInputRequest request)
        {
            await Task.Yield();
            var list = new List<SANPHAM>();
            for (int i = 0; i < 5; i++)
            {
                list.Add(new SANPHAM
                {
                    TenSP = "Iphone 1" + i,
                    MaSP = "IPHONE_" + i,
                    DonGia = 10000 + i
                });
            }

            if (request != null)
            {
                if (!string.IsNullOrEmpty(request.MaSP))
                {
                    list = list.FindAll(s => s.MaSP == request.MaSP).ToList();
                }
            }

            return Ok(list);
        }
    }
}
