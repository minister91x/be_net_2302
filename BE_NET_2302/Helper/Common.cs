using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BE_NET_2302.Helper
{
    public static class Common
    {
        public static string SendPost_Authen(string url, string data)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "5055dbea-37fe-7494-8495-b5e67d66528b");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("content-type", "application/json");
            request.AddParameter("application/json", data, ParameterType.RequestBody);
            var response = client.Execute(request);
            return response.Content;
        }

        public static string SendPost(string url, string data, string token)
        {
            var client = new RestClient(url);
            var request = new RestRequest(Method.POST);
            request.AddHeader("postman-token", "7a9d4964-edc0-b288-044d-f15f38219344");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("authorization", "Bearer " + token);

            request.AddHeader("content-type", "application/json");

            request.AddParameter("application/json", data, ParameterType.RequestBody);

            var response = client.Execute(request);

            return response.Content;
        }
    }
}