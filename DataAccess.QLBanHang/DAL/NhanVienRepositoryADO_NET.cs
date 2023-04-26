using BE2302.DataAccess.QLBanHang.DAO;
using BE2302.DataAccess.QLBanHang.DO;
using DataAccess.QLBanHang.DBHelper;
using DataAccess.QLBanHang.DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.QLBanHang.DAL
{
    public class NhanVienRepositoryADO_NET : INHANVIEN
    {

        NhanVienRepositoryDbHelper helper = new NhanVienRepositoryDbHelper();
        public List<NHANVIEN> Nhanvien_DanhSach()
        {
            return helper.Nhanvien_GetList();
        }

        public int Nhanvien_Delete(string MaNV)
        {
            throw new NotImplementedException();
        }

        public int Nhanvien_Themmoi(NHANVIEN nhanvien)
        {
            return helper.NhanVien_Insert(nhanvien);
        }

        public int Nhanvien_update(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
