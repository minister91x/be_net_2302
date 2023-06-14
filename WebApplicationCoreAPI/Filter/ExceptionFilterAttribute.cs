using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections;
using WebApplicationCoreAPI.LoggerService;

namespace WebApplicationCoreAPI.Filter
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private ILogger<CustomExceptionFilterAttribute> _Logger;
        public CustomExceptionFilterAttribute(ILogger<CustomExceptionFilterAttribute> loggerManager)
        {
            _Logger = loggerManager;
        }

        public override void OnException(ExceptionContext context)
        {

            if (context.Exception is UserFriendlyException userFriendlyException)
            {
                context.Result = new JsonResult(ApiResult<IDictionary>.Error(
                        context.Exception.Message
                        , userFriendlyException.Data
                    )
                );
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = (int)userFriendlyException.Status;
                context.ExceptionHandled = true;

                _Logger.LogWarning($"aaaaaaaaaaaaaaaaaaaaaa: {context.Exception.Message}", context.Exception);
                _Logger.LogWarning("bbbbbbbbbbbbbbbbbbbbbbb.");
                _Logger.LogError(new EventId(0), context.Exception, context.Exception.Message);
            }
        }
    }

}
