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

        public EmployeerRepository(MyShopUnitOfWorkDbContext context)
        {
            _context = context;
        }

       
        public List<NHANVIEN> GetListNhanVien()
        {
           return _context.nhanvien.ToList();
        }
    }
}
