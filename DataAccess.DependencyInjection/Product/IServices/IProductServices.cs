using DataAccess.DenpencyInjection.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DependencyInjection.IServices
{
    public interface IProductServices
    {
      Task<List<Product>> GetProducts();
    }
}
