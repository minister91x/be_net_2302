using Microsoft.AspNetCore.Mvc;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpPost("GetStringData")]
        public async Task<ActionResult> GetStringData()
        {
           
            var list = new List<string>();
            list.Add("LOP");
            list.Add("BACKEND");
            list.Add("BE 2203");
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
