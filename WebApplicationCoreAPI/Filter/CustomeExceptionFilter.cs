using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace WebApplicationCoreAPI.Filter
{
    public class CustomeExceptionFilter : IExceptionFilter
    {

        public void OnException(ExceptionContext context)
        {
            if (context.Exception is UserFriendlyException userFriendlyException)
            {
                var resul = new { mesage = context.Exception.Message };
                context.Result = new JsonResult(JsonConvert.SerializeObject(resul));
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = (int)userFriendlyException.Status;
                context.ExceptionHandled = true;
            }
        }


    }
}
