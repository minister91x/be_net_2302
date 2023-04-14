using BE2302.DataAccess.QLBanHang.DAO;
using BE2302.DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DAL
{
    public class NhanVienRepository : INHANVIEN
    {
        QuanlyNhanVienDBContext dbcontext = new QuanlyNhanVienDBContext();

        public List<NHANVIEN> Nhanvien_DanhSach()
        {
          return  dbcontext.nhanvien.ToList();
        }

        public int Nhanvien_Delete(string MaNV)
        {
            var nhanvien_remove = dbcontext.nhanvien.ToList().FindAll(s => s.MaNV == MaNV).FirstOrDefault();
            if (nhanvien_remove != null)
            {
                dbcontext.nhanvien.Remove(nhanvien_remove);
                return dbcontext.SaveChanges();
            }
            return 0;
        }

        public int Nhanvien_Themmoi(NHANVIEN nhanvien)
        {
            dbcontext.nhanvien.Add(nhanvien);
           return dbcontext.SaveChanges();
        }

        public int Nhanvien_update(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
