using RestSharp;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace WebApplicationCore.Services
{
    public static class HttpHelper
    {
        public static string PostPartner(string url, string jsonString)
        {
            try
            {
                var client = new RestClient(url);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddHeader("token", "676dc372-b56a-11ec-bb0a-66e89df8c7d3");
                request.AddParameter("application/json", jsonString, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                //ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateRemoteCertificate);
                //ServicePointManager.Expect100Continue = true;
                //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    return response.Content;
                }

            }
            catch (Exception ex)
            {

            }
            return string.Empty;
        }

        private static bool ValidateRemoteCertificate(
                     object sender,
                     X509Certificate certificate,
                     X509Chain chain,
                     System.Net.Security.SslPolicyErrors policyErrors)
        {
            return true;
        }


        public static async Task<string> UploadImage(string baseurl, string apiSrc, string body)
        {
            // Convert base 64 string to byte[]
            try
            {
                HttpClientHandler clientHandler = new HttpClientHandler();
                clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

                using (var client = new HttpClient(clientHandler))
                {
                    client.BaseAddress = new Uri(baseurl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var httpContent = new StringContent(body, Encoding.UTF8, "application/json");
                    var result = await client.PostAsync(apiSrc, httpContent);
                    string resultContent = await result.Content.ReadAsStringAsync();
                    return resultContent;
                }

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
