using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace WebApplicationCoreAPI.Helper
{
    public class AuthorizeDemoAttribute : Microsoft.AspNetCore.Mvc.TypeFilterAttribute
    {
        public AuthorizeDemoAttribute() : base(typeof(DemoAuthorizeActionFilter))
        {
        }
    }

    public class DemoAuthorizeActionFilter : IAsyncAuthorizationFilter
    {
        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            var identity = context.HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                var userClaims = identity.Claims;

                var Email = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value;
                // check quyền theo user này
                if (string.IsNullOrEmpty(Email))
                {
                    throw new Exception("Vui lòng đăng nhập để thực hiện chức năng này");
                }

            }
        }
    }

}
