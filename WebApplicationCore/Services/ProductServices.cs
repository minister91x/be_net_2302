using Newtonsoft.Json;
using WebApplicationCore.Models;

namespace WebApplicationCore.Services
{
    public static class ProductServices
    {
        public static List<ProductModels> GetListProduct(string url,string requestdata)
        {
            var result = HttpHelper.PostPartner(url + "GetListProduct", requestdata);

            return JsonConvert.DeserializeObject<List<ProductModels>>(result);
        }
    }
}
