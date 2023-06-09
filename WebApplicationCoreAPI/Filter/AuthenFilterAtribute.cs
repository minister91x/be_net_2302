using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;
using System.Security.Claims;

namespace WebApplicationCoreAPI.Filter
{
    public class AuthenFilterAtribute : TypeFilterAttribute
    {
        public AuthenFilterAtribute(Type type) : base(typeof(TodayJobAuthorizeActionFilter))
        {
        }
    }

    public class TodayJobAuthorizeActionFilter : IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
           
            var identity = context.HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                context.HttpContext.Response.ContentType = "application/json";
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                return;
            }
        }
    }
}
