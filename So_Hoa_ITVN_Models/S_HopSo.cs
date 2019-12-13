namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_HopSo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_HopSo()
        {
            S_HoSo = new HashSet<S_HoSo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HopSoID { get; set; }

        public int MucLucHoSoID { get; set; }

        [StringLength(50)]
        public string TieuDeHopSo { get; set; }

        public int? SoTo { get; set; }

        [StringLength(50)]
        public string ThoiHanBaoQuan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        public virtual S_MucLucHoSo S_MucLucHoSo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_HoSo> S_HoSo { get; set; }
    }
}
