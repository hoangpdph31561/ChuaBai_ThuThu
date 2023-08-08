using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuaBai_ThiThu.Mod
{
    internal class SanPhamMod
    {
        public string Ten { get; set; }
        public string Website { get; set; }
        public int SoLuong { get; set; }    
        public int TrangThai { get; set; }
        public Guid IdLoaiSP { get; set; }
    }
}
