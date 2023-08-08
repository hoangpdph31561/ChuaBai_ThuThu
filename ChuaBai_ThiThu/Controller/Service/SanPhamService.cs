using ChuaBai_ThiThu.Controller.Respository;
using ChuaBai_ThiThu.DomainClass;
using ChuaBai_ThiThu.Mod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_ThiThu.Controller.Service
{
    internal class SanPhamService
    {
        SanPhamRespository _res;
        public SanPhamService()
        {
            _res = new SanPhamRespository();
        }
        public List<LoaiSp> GetLoaiSP()
        {
            return _res.GetLoaiSanPhams();
        }
        public List<SanPham> GetSanPhams(string? find)
        {
            return _res.GetSanPhams(find);
        }
        public void AddSanPham(SanPham sanpham)
        {
            if(_res.AddSanPham(sanpham))
            {
                MessageBox.Show("Thêm được");
            }
            else
            {
                MessageBox.Show("Không thêm được","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void UpdateSanPham(Guid? id, SanPhamMod sanPhamMod)
        {
            if(_res.UpdateSanPham(id, sanPhamMod))
            {
                MessageBox.Show("Sửa được");
            }
            else
            {
                MessageBox.Show("Không Sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void RemoveSanPham(Guid? id)
        {
            if (_res.DeleteSanPham(id))
            {
                MessageBox.Show("Xóa được");
            }
            else
            {
                MessageBox.Show("Không Xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
