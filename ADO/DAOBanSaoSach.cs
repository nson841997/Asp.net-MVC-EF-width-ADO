using QLThuVien.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLThuVien.ADO
{
    public class DAOBanSaoSach
    {
        ThuVienContext db;
        public DAOBanSaoSach()
        {
            db = new ThuVienContext();
        }

        public List<tBanSaoSach> getAll()
        {
            return db.tBanSaoSaches.ToList();
         }
    public List<tBanSaoSach> getByMaBanSao(string mbs)
    {
        return db.tBanSaoSaches
            .Where(cat => cat.MaBanSao == mbs).ToList();
    }
}
}