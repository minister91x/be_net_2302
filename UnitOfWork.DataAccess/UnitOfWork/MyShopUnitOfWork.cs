using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Repository;

namespace UnitOfWork.DataAccess.UnitOfWork
{
    public class MyShopUnitOfWork
    {
        ProductRepository _productRepository;
        EmployeerRepository _employeerRepository;
        MyShopUnitOfWorkDbContext _shopDbContext;

        public MyShopUnitOfWork(MyShopUnitOfWorkDbContext shopDbContext)
        {
            _shopDbContext = shopDbContext;
        }

        public ProductRepository ProductRepos
        {
            get
            {
                if (_productRepository == null)
                {
                    _productRepository = new ProductRepository();
                }
                return _productRepository;
            }
        }

        public EmployeerRepository EmployeerRepos
        {
            get
            {
                if (_employeerRepository == null)
                {
                    _employeerRepository = new EmployeerRepository();
                }
                return _employeerRepository;
            }
        }

        public void Save()
        {
           // _shopDbContext.SaveChanges();
        }
    }
}
