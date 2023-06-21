using System.ComponentModel.DataAnnotations;
using WebApplicationCore.Filter;

namespace WebApplicationCore.Models
{
    public class StudentEditModel
    {
        [Required(ErrorMessage = "Vui lòng điền tên học sinh")]

        public string? Name { get; set; }
        public string? Department { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày sinh.")]
        [Min18Years]
        public DateTime DateofBirth { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn ngày .")]

        [CustomAdmissionDate(ErrorMessage = "Admission Date must be less than or equal to Today's Date.")]
        public DateTime AdmissionDate { get; set; }


    }
    public class StudentGetlistInputRequest
    {
        /// <summary>
        /// Trường này là điển nội dung muốn hiển thị
        /// </summary>
        public string? Name { get; set; }
    }


}
