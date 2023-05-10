using Dapper;
using DataAccess.DenpencyInjection.Models.Product;
using DataAccess.DependencyInjection.DbHelper;
using DataAccess.DependencyInjection.IServices;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyInjection.Services
{
    public class ProductServices : BaseApplicationService, IProductServices
    {
        private readonly IConfiguration configuration;
        public ProductServices(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
        public async Task<List<Product>> GetProducts()
        {
            try
            {
                var parameters = new DynamicParameters();
                var rersult = await ReadDbConnection.QueryAsync<Product>("SP_Country_GetList", parameters);
                return rersult;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
