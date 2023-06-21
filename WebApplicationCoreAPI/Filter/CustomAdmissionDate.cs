using System.ComponentModel.DataAnnotations;

namespace WebApplicationCoreAPI.Filter
{
    public class CustomAdmissionDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime = Convert.ToDateTime(value);
            return dateTime <= DateTime.Now;
        }
    }

}
