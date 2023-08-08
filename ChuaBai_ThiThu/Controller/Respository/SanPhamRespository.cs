using ChuaBai_ThiThu.Context;
using ChuaBai_ThiThu.DomainClass;
using ChuaBai_ThiThu.Mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_ThiThu.Controller.Respository
{
    internal class SanPhamRespository
    {
        DBContext _db;
        public SanPhamRespository()
        {
            _db = new DBContext();
        }
        public List<LoaiSp> GetLoaiSanPhams()
        {
            return _db.LoaiSps.ToList();
        }
        public List<SanPham> GetSanPhams(string? find)
        {
            if (find == null)
            {
                return _db.SanPhams.ToList();
            }
            return _db.SanPhams.Where(x => !x.Ten.Trim().ToLower().Contains(find.ToLower())).ToList();
        }
        public bool AddSanPham(SanPham sanPham)
        {
            int maSP = 1;
            if (sanPham == null) return false;
            do
            {
                sanPham.Id = Guid.NewGuid();
                sanPham.Ma = "SP" + maSP.ToString(); //Mã sp là unique, dùng cách này để tự sinh mã
                maSP++;
            } while (_db.SanPhams.Any(x => x.Id == sanPham.Id || x.Ma == sanPham.Ma));
            _db.SanPhams.Add(sanPham);
            _db.SaveChanges();
            return true;
        }
        public bool UpdateSanPham(Guid? id, SanPhamMod SanPham)
        {
            var exist = _db.SanPhams.FirstOrDefault(x => x.Id == id);
            if (exist == null || SanPham == null) return false;
            exist.Ten = SanPham.Ten;
            exist.SoLuong = SanPham.SoLuong;
            exist.Website = SanPham.Website;
            exist.TrangThai = SanPham.TrangThai;
            exist.IdLoaiSp = SanPham.IdLoaiSP;
            _db.SanPhams.Update(exist);
            _db.SaveChanges();
            return true;
        }
        public bool DeleteSanPham(Guid? id)
        {
            var exist = _db.SanPhams.FirstOrDefault(x => x.Id == id);
            if (exist == null ) return false;
            _db.SanPhams.Remove(exist);
            _db.SaveChanges();
            return true;
        }
    }
}
