using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChuaBai_ThiThu.DomainClass
{
    [Table("LoaiSP")]
    [Index("Ma", Name = "UQ__LoaiSP__3214CC9ED4998D6B", IsUnique = true)]
    public partial class LoaiSp
    {
        public LoaiSp()
        {
            SanPhams = new HashSet<SanPham>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(50)]
        public string? Ten { get; set; }

        [InverseProperty("IdLoaiSpNavigation")]
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
