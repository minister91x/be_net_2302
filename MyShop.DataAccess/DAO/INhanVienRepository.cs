using MyShop.DataAccess.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.DataAccess.DAO
{
    public interface INhanVienRepository
    {
        List<NhanVien> NhanVien_GetAll();

        int NhanVien_Insert(NhanVien nhanVien);
        int NhanVien_Update(NhanVien nhanVien);

        int NhanVien_Delete(string MaNhanVien);
    }
}
