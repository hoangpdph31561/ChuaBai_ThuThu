using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChuaBai_ThiThu.DomainClass
{
    [Table("LoaiXM")]
    [Index("Ma", Name = "UQ__LoaiXM__3214CC9EEDBC2110", IsUnique = true)]
    public partial class LoaiXm
    {
        public LoaiXm()
        {
            XeMays = new HashSet<XeMay>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(50)]
        public string? Ten { get; set; }

        [InverseProperty("IdLxmNavigation")]
        public virtual ICollection<XeMay> XeMays { get; set; }
    }
}
