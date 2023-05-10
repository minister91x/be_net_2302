using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyInjection.DbHelper
{
    public abstract class BaseApplicationService
    {
        public BaseApplicationService(IServiceProvider serviceProvider)
        {
            ReadDbConnection = serviceProvider.GetRequiredService<IDbHelper>();
        }

        protected IDbHelper ReadDbConnection { get; }
    }
}
