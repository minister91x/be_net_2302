using MyShop.DataAccess.DAO;
using MyShop.DataAccess.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.DAL
{
    public class NhanVienRepository : INhanVienRepository
    {
        MyShopDBContext dBContext = new MyShopDBContext();
        public int NhanVien_Delete(string MaNhanVien)
        {
            var current = dBContext.nhanvien.ToList().FindAll(s => s.MaNV == MaNhanVien).FirstOrDefault();
            if(current == null || string.IsNullOrEmpty(current.MaNV)) { return -1; }

            dBContext.nhanvien.Remove(current);
            return dBContext.SaveChanges();
        }

        public List<DO.NhanVien> NhanVien_GetAll()
        {
            return dBContext.nhanvien.ToList();
        }

        public int NhanVien_Insert(DO.NhanVien nhanVien)
        {
            dBContext.nhanvien.Add(nhanVien);
            return dBContext.SaveChanges();
        }

        public int NhanVien_Update(DO.NhanVien nhanVien)
        {
            throw new NotImplementedException();
        }
    }
}
