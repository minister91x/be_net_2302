using System.ComponentModel.DataAnnotations;

namespace WebApplicationCoreAPI.Models
{
    public class UploadFileInputDto
    {
        [Required]
        public IFormFile? File { get; set; }

    }
}
