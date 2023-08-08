using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChuaBai_ThiThu.DomainClass
{
    [Table("MoiQuanHe")]
    [Index("Ma", Name = "UQ__MoiQuanH__3214CC9E617C3933", IsUnique = true)]
    public partial class MoiQuanHe
    {
        public MoiQuanHe()
        {
            Bans = new HashSet<Ban>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(50)]
        public string? Ten { get; set; }

        [InverseProperty("IdMqhNavigation")]
        public virtual ICollection<Ban> Bans { get; set; }
    }
}
