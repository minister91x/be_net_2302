using System.ComponentModel.DataAnnotations;
using WebApplicationCoreAPI.Filter;

namespace WebApplicationCoreAPI.Entities
{
    public class Student
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


      //  public ILogger _logger { get; set; }
        //public Student(string name, string department, ILogger<Student> logger)
        //{
        //    Name = name;
        //    Department = department;
        //    _logger = logger;
        //    _logger.LogInformation("Name of student is " + Name + " and his department is " + Department);
        //}

    }
}
