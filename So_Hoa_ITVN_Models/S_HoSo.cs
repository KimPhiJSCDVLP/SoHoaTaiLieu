namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_HoSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_HoSo()
        {
            S_VanBan = new HashSet<S_VanBan>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HoSoID { get; set; }

        public int HopSoID { get; set; }

        [StringLength(50)]
        public string TieuDeHoSo { get; set; }

        [StringLength(50)]
        public string TenHoSo { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public virtual S_HopSo S_HopSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_VanBan> S_VanBan { get; set; }
    }
}
