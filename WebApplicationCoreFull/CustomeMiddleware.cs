namespace WebApplicationCoreFull
{
    public class CustomeMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async System.Threading.Tasks.Task Invoke(HttpContext context)
        {
            await context.Response.WriteAsync("<div> before - CustomeMiddleware </div>");
            await _next(context);
            await context.Response.WriteAsync("<div> after - CustomeMiddleware </div>");
        }
    }
}
