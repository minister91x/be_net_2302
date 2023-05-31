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
        private readonly MyShopUnitOfWorkDbContext _context;
        public ProductRepository(MyShopUnitOfWorkDbContext context)
        {
            _context = context;
        }
        public SANPHAM GetProductById(string MaSP)
        {
            return _context.sanpham.Where(s => s.MaSP == MaSP).FirstOrDefault() ;
        }

        public List<SANPHAM> Product_GetAll()
        {
            return _context.sanpham.ToList();
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
