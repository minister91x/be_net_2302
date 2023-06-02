using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.DbContext;
using UnitOfWork.DataAccess.Entities;
using UnitOfWork.DataAccess.Interface;

namespace UnitOfWork.DataAccess.Repository
{
    public class EmployeerRepository : IEmployeerRepository
    {
        private readonly MyShopUnitOfWorkDbContext _context;

        public void Add(NHANVIEN entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<NHANVIEN> entities)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NHANVIEN> Find(Expression<Func<NHANVIEN, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NHANVIEN> GetAll()
        {
            throw new NotImplementedException();
        }

        public NHANVIEN GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(NHANVIEN entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<NHANVIEN> entities)
        {
            throw new NotImplementedException();
        }

        public void Update(NHANVIEN entity)
        {
            throw new NotImplementedException();
        }
    }
}
