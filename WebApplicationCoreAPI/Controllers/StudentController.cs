using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationCoreAPI.Entities;

namespace WebApplicationCoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost("GetAllStudent")]
        public async Task<ActionResult> GetAllStudent(StudentGetlistInputRequest request)
        {
            await Task.Yield();
            var list = new List<Student>();

            list.Add(new Student { Name = "Quan" });
            list.Add(new Student { Name = "Hoang" });
            list.Add(new Student { Name = "Tuan" });


            if (!string.IsNullOrEmpty(request.Name))
            {
                list = list.FindAll(s => s.Name?.ToLower() == request.Name.ToLower());
            }
            return Ok(list);
        }
    }
}
