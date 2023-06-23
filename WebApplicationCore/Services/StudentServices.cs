using Newtonsoft.Json;
using WebApplicationCore.Models;

namespace WebApplicationCore.Services
{
    public static class StudentServices
    {
        /// <summary>
        /// Hàm này dùng để lấy danh sách Student
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static List<StudentEditModel> GetAllStudent(string url, string data)
        {
            var result = HttpHelper.PostPartner(url + "GetAllStudent", data);

            return JsonConvert.DeserializeObject<List<StudentEditModel>>(result);
        }
        /// <summary>
        /// Hàm này để lấy thông tin student từ ID 
        /// </summary>
        /// <param name="url"></param>
        /// <param name="data"></param>
        /// <returns></returns>

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
