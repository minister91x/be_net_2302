using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Interface;
using UnitOfWork.DataAccess.Repository;
using WebApplicationCoreAPI.UnitOfWork;

namespace UnitOfWork.DataAccess.UnitOfWork
{
    public class MyShopUnitOfWork : IUnitOfWork
    {
        private readonly MyShopUnitOfWorkDbContext _dbContext;
        //public ProductRepository _products { get; }

        public IEmployeerRepository _employeer { get; }


        public MyShopUnitOfWork(MyShopUnitOfWorkDbContext dbContext,
                            IEmployeerRepository employeer)
        {
            _dbContext = dbContext;
            _employeer = employeer;
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
