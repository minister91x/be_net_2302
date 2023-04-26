using BE2302.DataAccess.QLBanHang.DO;
using DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE2302.DataAccess.QLBanHang.DAO
{
    public interface INHANVIEN
    {
        int Nhanvien_Themmoi(NHANVIEN nhanvien);
        int Nhanvien_update(int ID);

        int Nhanvien_Delete(string MaNV);
        List<NHANVIEN> Nhanvien_DanhSach();
    }
}
