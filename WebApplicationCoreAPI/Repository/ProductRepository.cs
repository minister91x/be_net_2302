using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Entities;
using UnitOfWork.DataAccess.Interface;
using WebApplicationCoreAPI.Repository;

namespace UnitOfWork.DataAccess.Repository
{
    public class ProductRepository : GenericRepository<SANPHAM>, IProductRepository
    {
        public ProductRepository(MyShopUnitOfWorkDbContext context) : base(context) { }
    }
}
