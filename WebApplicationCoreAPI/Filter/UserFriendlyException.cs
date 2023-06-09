using System.Collections;
using System.Net;

namespace WebApplicationCoreAPI.Filter
{
    public class UserFriendlyException : Exception
    {
        public const HttpStatusCode DefaultStatus = HttpStatusCode.BadRequest;
        private IDictionary _Data { get; set; }
        public override IDictionary Data { get => _Data; }
        public object ErrorData { get; set; }
        public HttpStatusCode Status { get; set; }
        public string Detail { get; set; }

        public UserFriendlyException(HttpStatusCode status, string message) : base(message)
        {
            Status = status;
            Detail = message;
        }
    }

}
