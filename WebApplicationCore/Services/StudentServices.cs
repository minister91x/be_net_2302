using Newtonsoft.Json;
using WebApplicationCore.Models;

namespace WebApplicationCore.Services
{
    public static class StudentServices
    {

        public static List<StudentEditModel> GetAllStudent(string url, string data)
        {
            var result = HttpHelper.PostPartner(url + "GetAllStudent", data);

            return JsonConvert.DeserializeObject<List<StudentEditModel>>(result);
        }

        public static StudentEditModel GetStudentByID(string url, string data)
        {
            var result = HttpHelper.PostPartner(url + "GetStudentByID", data);

            return JsonConvert.DeserializeObject<StudentEditModel>(result);
        }

        public static ResponseData DeleteStudentByID(string url, string data)
        {
            var result = HttpHelper.PostPartner(url + "DeleteStudentByID", data);

            return JsonConvert.DeserializeObject<ResponseData>(result);
        }
    }
}
