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
    public class ProductRepository : IProductRepository
    {
        private readonly MyShopUnitOfWorkDbContext _context;

        public ProductRepository(MyShopUnitOfWorkDbContext context)
        {
            _context = context;
        }

        public void Add(SANPHAM entity)
        {
            throw new NotImplementedException();
        }

        //public void AddRange(IEnumerable<SANPHAM> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<SANPHAM> Find(Expression<Func<SANPHAM, bool>> expression)
        //{
        //    throw new NotImplementedException();
        //}

        public IEnumerable<SANPHAM> GetAll()
        {
            return _context.sanpham.ToList();
        }

        //public SANPHAM GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Remove(SANPHAM entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void RemoveRange(IEnumerable<SANPHAM> entities)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(SANPHAM entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
