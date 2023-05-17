using Dapper;
using DataAccess.DenpencyInjection.Models.Account;
using DataAccess.DependencyInjection.Account.IServices;
using DataAccess.DependencyInjection.DbHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyInjection.Account.Services
{
    public class AccountServices : BaseApplicationService, IAccountServices
    {
        public AccountServices(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        public async Task<int> Account_Authen(AccountAuthenRequestData requestData)
        {
            try
            {
                var parameters = new DynamicParameters();
                parameters.Add("@_UserName", requestData.UserName);
                parameters.Add("@_Password", requestData.Password);
                parameters.Add("@_ResponseCode", 0, System.Data.DbType.Int32, System.Data.ParameterDirection.Output);
                var rersult = await ReadDbConnection.ExecuteAsync("SP_UserLogin", parameters);
                var UserId = parameters.Get<int>("@_ResponseCode");
                return UserId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
