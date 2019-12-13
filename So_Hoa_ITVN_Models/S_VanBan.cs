namespace So_Hoa_ITVN_Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_VanBan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public S_VanBan()
        {
            S_DetailsVanBan = new HashSet<S_DetailsVanBan>();
            S_File = new HashSet<S_File>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VanBanID { get; set; }

        public int HoSoID { get; set; }

        [StringLength(50)]
        public string TieuDeVanBan { get; set; }

        [StringLength(50)]
        public string TenVanBan { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayTao { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayCapNhat { get; set; }

        public int? LoaiVanBanID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_DetailsVanBan> S_DetailsVanBan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<S_File> S_File { get; set; }

        public virtual S_HoSo S_HoSo { get; set; }

        public virtual S_LoaiVanBan S_LoaiVanBan { get; set; }
    }
}
