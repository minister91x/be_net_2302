using DataAccess.DenpencyInjection.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyInjection.Account.IServices
{
    public interface IAccountServices
    {
        Task<int> Account_Authen(AccountAuthenRequestData requestData);
    }
}
