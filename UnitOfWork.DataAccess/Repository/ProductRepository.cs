using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Entities;
using UnitOfWork.DataAccess.Interface;

namespace UnitOfWork.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        MyShopUnitOfWorkDbContext context = new MyShopUnitOfWorkDbContext();
        public SANPHAM GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SANPHAM> Product_GetAll()
        {
            throw new NotImplementedException();
        }

        public int Product_Insert(SANPHAM product)
        {
            throw new NotImplementedException();
        }

        public int Product_Update(SANPHAM product)
        {
            throw new NotImplementedException();
        }
    }
}
