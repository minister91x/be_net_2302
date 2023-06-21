using System.ComponentModel.DataAnnotations;
using WebApplicationCoreAPI.Entities;

namespace WebApplicationCoreAPI.Filter
{
    public class Min18Years: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var student = (Student)validationContext.ObjectInstance;

            if (student.DateofBirth == null)
                return new ValidationResult("Date of Birth is required.");
           
            var age = DateTime.Today.Year - student.DateofBirth.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Student should be at least 18 years old.");
        }
    }

}

