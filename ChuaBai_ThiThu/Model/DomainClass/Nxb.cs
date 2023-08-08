using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ChuaBai_ThiThu.DomainClass
{
    [Table("NXB")]
    [Index("Ma", Name = "UQ__NXB__3214CC9E334C60F8", IsUnique = true)]
    public partial class Nxb
    {
        public Nxb()
        {
            Saches = new HashSet<Sach>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? Ma { get; set; }
        [StringLength(50)]
        public string? Ten { get; set; }

        [InverseProperty("IdNxbNavigation")]
        public virtual ICollection<Sach> Saches { get; set; }
    }
}
