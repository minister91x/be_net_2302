using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.DataAccess.Entities;

namespace UnitOfWork.DataAccess.Interface
{
    public interface IProductRepository
    {
        List<SANPHAM> Product_GetAll();
        SANPHAM GetProductById(string MaSP);
        int Product_Insert(SANPHAM product);
        int Product_Update(SANPHAM product);
    }
}
