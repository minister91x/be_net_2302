using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Repository;
using WebApplicationCoreAPI.UnitOfWork;

namespace UnitOfWork.DataAccess.UnitOfWork
{
    public class MyShopUnitOfWork : IUnitOfWork
    {
        private readonly MyShopUnitOfWorkDbContext _dbContext;
        public ProductRepository Products { get; }

        public EmployeerRepository employeer => throw new NotImplementedException();

        public MyShopUnitOfWork(MyShopUnitOfWorkDbContext dbContext,
                            ProductRepository productRepository)
        {
            _dbContext = dbContext;
            Products = productRepository;
        }

        public int Save()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                _dbContext.Dispose();
            }
        }
    }
}
