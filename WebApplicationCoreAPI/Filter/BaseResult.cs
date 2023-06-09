using System.Net;

namespace WebApplicationCoreAPI.Filter
{
    public abstract class BaseResult
    {
        public virtual string Status { get; set; } = "Ok";
        public virtual HttpStatusCode Code { get; set; } = HttpStatusCode.OK;
        public virtual string Message { get; set; } = "Success";
    }
    public class ApiResult : BaseResult
    {
        public static ApiResult Ok(HttpStatusCode code = HttpStatusCode.OK, string message = "Success")
        {
            return new ApiResult
            {
                Code = code,
                Message = message
            };
        }
        public static ApiResult Error(string message, HttpStatusCode code = HttpStatusCode.BadRequest)
        { return new ApiResult { Message = message, Status = "NOTOK", Code = code, }; }
    }
    public class ApiResult<TData> : BaseResult
    {
        public static ApiResult<TData> Ok(TData data, HttpStatusCode code = HttpStatusCode.OK, string message = "Success")
        {
            return new ApiResult<TData>
            {
                Data = data,
                Code = code,
                Message = message
            };
        }
        public static ApiResult<TData> Error(string message, TData data = default, HttpStatusCode code = HttpStatusCode.BadRequest) 
        { return new ApiResult<TData> { Message = message, Status = "NOTOK", Data = data, Code = code, }; }
        public TData Data { get; set; } = default;
    }

}
